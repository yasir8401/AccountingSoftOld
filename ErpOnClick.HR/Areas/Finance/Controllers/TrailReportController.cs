using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class TrailReportController : Controller
    {
        private readonly ILogger<TrailReportController> _logger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _voucherLinesService;

        private dynamic expObj;
        public TrailReportController(ILogger<TrailReportController> logger, IVoucherLinesService voucherLinesService, IAccountsService accountsService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;

            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _voucherLinesService = voucherLinesService;
            _accountsService = accountsService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string FromDate, string ToDate)
        {
            expObj.listReportTrailBalance = GenerateReportForTrailBalance(FromDate, ToDate);

            return PartialView(expObj);
        }

        public IActionResult PrintList(string FromDate, string ToDate)
        {
            expObj.listReportTrailBalance = GenerateReportForTrailBalance(FromDate, ToDate);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public List<TrailBalanceReportModel> GenerateReportForTrailBalance(string FromDate, string ToDate)
        {
            var allAccounts = _accountsService.GetAll();

            var allVouchersLines = _voucherLinesService.dbset().IncludeOptimized(x => x.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.ParentAccount).IncludeOptimized(c => c.Voucher.VoucherLines).ToList();
            List<TrailBalanceReportModel> listReportTrailBalance = new List<TrailBalanceReportModel>();
            List<IGrouping<Accounts, VoucherLines>> voucherLines = allVouchersLines.AsEnumerable().GroupBy(x => x.Account).ToList();
            List<IGrouping<Accounts, VoucherLines>> newvoucherLines = null;
            List<IGrouping<Accounts, VoucherLines>> oldvoucherLines = null;
           
            #region MakingReportForTrailBalance
            newvoucherLines = allVouchersLines.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1)).AsEnumerable().GroupBy(x => x.Account).ToList();
            oldvoucherLines = allVouchersLines.Where(x => x.CreatedDate < Convert.ToDateTime(FromDate)).OrderBy(c => c.CreatedDate.Value.Date).AsEnumerable().GroupBy(x => x.Account).ToList();

            foreach (var lines in voucherLines)
            {
                if (lines.Select(c => c.Account.AccountLevel == 5).FirstOrDefault())
                {
                    TrailBalanceReportModel reportObject = new TrailBalanceReportModel();

                    reportObject.Code = lines.Select(c => c.Account.AccountCode).FirstOrDefault();
                    reportObject.Account = lines.Select(x => x.Account.AccountNameEn).FirstOrDefault();
                    reportObject.Type = lines.Select(x => x.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn).FirstOrDefault();
                    reportObject.Head = lines.Select(x => x.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn).FirstOrDefault();
                    reportObject.SubHead = lines.Select(x => x.Account.ParentAccount.ParentAccount.AccountNameEn).FirstOrDefault();

                    if (reportObject.Type == "Assets" || reportObject.Type == "Expenses")
                    {
                        reportObject.ODebit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Debit);
                        reportObject.OCredit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Credit);

                        reportObject.OTotal = reportObject.ODebit - reportObject.OCredit;

                        reportObject.ADebit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Debit);
                        reportObject.ACredit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Credit);

                        reportObject.ATotal = reportObject.ADebit - reportObject.ACredit;

                        reportObject.CDebit = reportObject.ODebit + reportObject.ADebit;
                        reportObject.CCredit = reportObject.OCredit + reportObject.ACredit;

                        reportObject.CTotal = reportObject.CDebit - reportObject.CCredit;
                    }
                    else if (reportObject.Type == "Revenue" || reportObject.Type == "Liabilities" || reportObject.Type == "Equity" || reportObject.Type == "Accumulated fund")
                    {
                        reportObject.ODebit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Debit);
                        reportObject.OCredit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Credit);

                        reportObject.OTotal = reportObject.OCredit - reportObject.ODebit;

                        reportObject.ADebit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Debit);
                        reportObject.ACredit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Credit);

                        reportObject.ATotal = reportObject.ACredit - reportObject.ADebit;

                        reportObject.CDebit = reportObject.ODebit + reportObject.ADebit;
                        reportObject.CCredit = reportObject.OCredit + reportObject.ACredit;

                        reportObject.CTotal = reportObject.CCredit - reportObject.CDebit;
                    }


                    //reportObject.ODebit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Debit);
                    //reportObject.OCredit = allVouchersLines.Where(c => c.CreatedDate < Convert.ToDateTime(FromDate) && c.Account == lines.Key).Sum(c => c.Credit);

                    //reportObject.OTotal = reportObject.ODebit - reportObject.OCredit;

                    //reportObject.ADebit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Debit);
                    //reportObject.ACredit = allVouchersLines.Where(c => c.CreatedDate >= Convert.ToDateTime(FromDate) && c.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1) && c.Account == lines.Key).Sum(c => c.Credit);

                    //reportObject.ATotal = reportObject.ADebit - reportObject.ACredit;

                    //reportObject.CDebit = reportObject.ODebit + reportObject.ADebit;
                    //reportObject.CCredit = reportObject.OCredit + reportObject.ACredit;

                    //reportObject.CTotal = reportObject.CDebit - reportObject.CCredit;

                    listReportTrailBalance.Add(reportObject);
                }
                else
                {
                }
            }

            var accountsWithVoucher = allVouchersLines.AsEnumerable().GroupBy(x => x.Account).ToList().Select(x => x.Key.AccountId).ToList();
            var accountWithNoVoucher = allAccounts.Where(x => !(accountsWithVoucher.Contains(x.AccountId))).ToList();
            foreach (var account in accountWithNoVoucher)
            {
                if (account.AccountLevel == 5)
                {
                    TrailBalanceReportModel reportObject = new TrailBalanceReportModel();

                    reportObject.Code = account.AccountCode;
                    reportObject.Account = account.AccountNameEn;
                    reportObject.Type = account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn;
                    reportObject.Head = account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn;
                    reportObject.SubHead = account.ParentAccount.ParentAccount.AccountNameEn;
                    listReportTrailBalance.Add(reportObject);
                }
            }
            #endregion
            return listReportTrailBalance;
        }
    }
}
