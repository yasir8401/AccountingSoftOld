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
    public class AccountLedgerController : Controller
    {
        private readonly ILogger<AccountLedgerController> _logger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private ICustomersService _CustomersService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IGeneralEntriesLinesService _generalEntriesLinesService;
        private IVoucherLinesService _voucherLinesService;

        private dynamic expObj;
        public AccountLedgerController(ILogger<AccountLedgerController> logger, IVoucherLinesService VoucherLinesService, ICustomersService CustomersService, IAccountsService accountsService, IGeneralEntriesLinesService generalEntriesLinesService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;

            _CustomersService = CustomersService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _generalEntriesLinesService = generalEntriesLinesService;
            _accountsService = accountsService;
            _voucherLinesService = VoucherLinesService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.accountsList = _accountsService.GetAll();

            return View(expObj);
        }

        public IActionResult _list(DateTime FromDate, DateTime ToDate, int AccountID)
        {
            expObj.listReportAccountLedger = GenerateReportForAccountLedger(FromDate, ToDate, AccountID);

            return PartialView(expObj);
        }

        public IActionResult PrintList(DateTime FromDate, DateTime ToDate, int AccountId)
        {
            expObj.listReportAccountLedger = GenerateReportForAccountLedger(FromDate, ToDate, AccountId);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public List<AccountLedgerReportModel> GenerateReportForAccountLedger(DateTime FromDate, DateTime ToDate, int AccountId)
        {
            int OpeningBalance = 0;
            int Credit = 0;
            int Debit = 0;
            List<AccountLedgerReportModel> listReportAccountLedger = new List<AccountLedgerReportModel>();
            List<VoucherLines> allgeneralEntriesList = _voucherLinesService.dbset().IncludeOptimized(c => c.Voucher).IncludeOptimized(c => c.Voucher.VoucherTypeNavigation).IncludeOptimized(x => x.Account).IncludeOptimized(c=>c.Account.ParentAccount).IncludeOptimized(c=>c.Account.ParentAccount.ParentAccount).IncludeOptimized(c=>c.Account.ParentAccount.ParentAccount.ParentAccount).IncludeOptimized(c=>c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount).ToList();
            List<VoucherLines> newgeneralEntriesList = null;
            List<VoucherLines> oldgeneralEntriesList = null;

            #region MakingReportForAccountLedger

            newgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate).AddDays(1)).OrderBy(c => c.CreatedDate.Value.Date).ToList();
            oldgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate < Convert.ToDateTime(FromDate)).OrderBy(c => c.CreatedDate.Value.Date).ToList();

            if (oldgeneralEntriesList.Count() > 0)
            {
                foreach (var oldlines in oldgeneralEntriesList)
                {
                    if (oldlines.AccountId == AccountId)
                    {
                        Credit += Convert.ToInt32(oldlines.Credit);
                        Debit += Convert.ToInt32(oldlines.Debit);
                        OpeningBalance += Convert.ToInt32(oldlines.Debit - oldlines.Credit);
                    }
                    //if (oldlines.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountId == AccountId)
                    //{
                    //    Credit += Convert.ToInt32(oldlines.Credit);
                    //    Debit += Convert.ToInt32(oldlines.Debit);
                    //    OpeningBalance += Convert.ToInt32(oldlines.Debit - oldlines.Credit);
                    //}
                    else
                    {
                    }
                }
            }

            foreach (var item in newgeneralEntriesList)
            {
                //if (item.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountId == AccountId)
                if (item.AccountId == AccountId)
                {
                    AccountLedgerReportModel reportObject = new AccountLedgerReportModel();
                    reportObject.Credit = item.Credit;
                    reportObject.Debit = item.Debit;
                    reportObject.Description = item.Description;
                    reportObject.Voucher = Convert.ToInt32(item.VoucherId);
                    reportObject.Type = item.Voucher.VoucherTypeNavigation.LookupNameEn.Substring(item.Voucher.VoucherTypeNavigation.LookupNameEn.IndexOf("(")).Replace("(", "").Replace(")", "");
                    if (item.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Assests" || item.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Expenses")
                    {
                        reportObject.Balance = item.Account.OpeningBalance + (reportObject.Debit - reportObject.Credit);
                    }
                    else if (item.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Liabilities" || item.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Revenue")
                    {
                        reportObject.Balance = item.Account.OpeningBalance + (reportObject.Credit - reportObject.Debit);
                    }
                    reportObject.Account = item.Account.AccountNameEn;
                    reportObject.AccountCode = item.Account.AccountCode;
                    reportObject.CreatedDate = item.CreatedDate;

                    listReportAccountLedger.Add(reportObject);
                }
                else
                {
                    //newgeneralEntriesList.Remove(item);
                }

            }
            AccountLedgerReportModel firstRow = new AccountLedgerReportModel();
            //firstRow.Account = "Opening Balance";
            firstRow.CreatedDate = FromDate;
            firstRow.Debit = Debit;
            firstRow.Description = "Opening Balance";
            firstRow.Type = "";
            firstRow.Credit = Credit;
            firstRow.Balance = OpeningBalance;
            listReportAccountLedger.Insert(0, firstRow);

            #endregion

            return listReportAccountLedger;
        }


    }
}
