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
using ErpOnClick.ErpMain.Models.Finance;
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
    public class ProfitLossController : Controller
    {
        private readonly ILogger<ProfitLossController> _logger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _voucherLinesService;

        private dynamic expObj;
        public ProfitLossController(ILogger<ProfitLossController> logger, IVoucherLinesService voucherLinesService, IAccountsService accountsService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
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

        public IActionResult _list()
        {
            expObj.profitLossViewModel = GenerateReportForProfitLoss();

            return PartialView(expObj);
        }

        public IActionResult PrintList()
        {
            expObj.profitLossViewModel = GenerateReportForProfitLoss();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public ProfitLossViewModel GenerateReportForProfitLoss()
        {
            ProfitLossViewModel profitLossViewModel = new ProfitLossViewModel();
            List<IGrouping<Accounts, VoucherLines>> voucherLines = _voucherLinesService.dbset().IncludeOptimized(x => x.Account).IncludeOptimized(c => c.Voucher).IncludeOptimized(c => c.Voucher.VoucherLines).AsEnumerable().GroupBy(x => x.Account).ToList();
            var allaccounts = _accountsService.dbset().IncludeOptimized(c => c.ParentAccount.ParentAccount.ParentAccount.ParentAccount).ToList();

            #region MakingReportForProfitLoss


            foreach (var accountVouchers in voucherLines)
            {
                var accountDetail = allaccounts.Where(c => c.AccountId == Convert.ToInt32(accountVouchers.Key.AccountId)).FirstOrDefault();
                if (accountDetail.ParentAccount.AccountNameEn.Contains("Revenue") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Revenue") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Revenue") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Revenue"))
                {
                    profitLossViewModel.Revenue2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit));
                    profitLossViewModel.Revenue2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("Cost of Revenue") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Cost of Revenue") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Cost of Revenue") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Cost of Revenue"))
                {
                    profitLossViewModel.CostOfRevenue2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit));
                    profitLossViewModel.CostOfRevenue2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("General and Administrative Expenses") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("General and Administrative Expenses") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("General and Administrative Expenses") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("General and Administrative Expenses"))
                {
                    profitLossViewModel.GeneralAndAdministrativeExpense2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit));
                    profitLossViewModel.GeneralAndAdministrativeExpense2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("Operating Expenses") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Operating Expenses") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Operating Expenses") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Operating Expenses"))
                {
                    profitLossViewModel.OperatingExpense2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit));
                    profitLossViewModel.OperatingExpense2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("Selling and Distribution") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Selling and Distribution") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Selling and Distribution") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Selling and Distribution"))
                {
                    profitLossViewModel.SellingAndDistributionExpense2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit));
                    profitLossViewModel.SellingAndDistributionExpense2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("Finance Cost") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Finance Cost") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Finance Cost") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Finance Cost"))
                {
                    profitLossViewModel.FinanceCost2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit));
                    profitLossViewModel.FinanceCost2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit));
                }
                else if (accountDetail.ParentAccount.AccountNameEn.Contains("Taxation") || accountDetail.ParentAccount.ParentAccount.AccountNameEn.Contains("Taxation") || accountDetail.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Taxation") || accountDetail.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn.Contains("Taxation"))
                {
                    profitLossViewModel.Taxation2021 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit));
                    profitLossViewModel.Taxation2020 = Convert.ToDecimal(accountVouchers.Where(c => c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit));
                }

                profitLossViewModel.Revenue2021 = (profitLossViewModel.Revenue2021 != null ? profitLossViewModel.Revenue2021 : 0);
                profitLossViewModel.Revenue2020 = (profitLossViewModel.Revenue2020 != null ? profitLossViewModel.Revenue2020 : 0);
                profitLossViewModel.CostOfRevenue2021 = (profitLossViewModel.CostOfRevenue2021 != null ? profitLossViewModel.CostOfRevenue2021 : 0);
                profitLossViewModel.CostOfRevenue2020 = (profitLossViewModel.CostOfRevenue2020 != null ? profitLossViewModel.CostOfRevenue2020 : 0);
                profitLossViewModel.GeneralAndAdministrativeExpense2021 = (profitLossViewModel.GeneralAndAdministrativeExpense2021 != null ? profitLossViewModel.GeneralAndAdministrativeExpense2021 : 0);
                profitLossViewModel.GeneralAndAdministrativeExpense2020 = (profitLossViewModel.GeneralAndAdministrativeExpense2020 != null ? profitLossViewModel.GeneralAndAdministrativeExpense2020 : 0);
                profitLossViewModel.OperatingExpense2021 = (profitLossViewModel.OperatingExpense2021 != null ? profitLossViewModel.OperatingExpense2021 : 0);
                profitLossViewModel.OperatingExpense2020 = (profitLossViewModel.OperatingExpense2020 != null ? profitLossViewModel.OperatingExpense2020 : 0);
                profitLossViewModel.SellingAndDistributionExpense2021 = (profitLossViewModel.SellingAndDistributionExpense2021 != null ? profitLossViewModel.SellingAndDistributionExpense2021 : 0);
                profitLossViewModel.SellingAndDistributionExpense2020 = (profitLossViewModel.SellingAndDistributionExpense2020 != null ? profitLossViewModel.SellingAndDistributionExpense2020 : 0);
                profitLossViewModel.FinanceCost2021 = (profitLossViewModel.FinanceCost2021 != null ? profitLossViewModel.FinanceCost2021 : 0);
                profitLossViewModel.FinanceCost2020 = (profitLossViewModel.FinanceCost2020 != null ? profitLossViewModel.FinanceCost2020 : 0);
                profitLossViewModel.Taxation2021 = (profitLossViewModel.Taxation2021 != null ? profitLossViewModel.Taxation2021 : 0);
                profitLossViewModel.Taxation2020 = (profitLossViewModel.Taxation2020 != null ? profitLossViewModel.Taxation2020 : 0);
                profitLossViewModel.GrossProfitLoss2021 = profitLossViewModel.Revenue2021 - profitLossViewModel.CostOfRevenue2021;
                profitLossViewModel.GrossProfitLoss2020 = profitLossViewModel.Revenue2020 - profitLossViewModel.CostOfRevenue2020;
                profitLossViewModel.TotalOperatingExpenses2021 = profitLossViewModel.GeneralAndAdministrativeExpense2021 + profitLossViewModel.OperatingExpense2021 + profitLossViewModel.SellingAndDistributionExpense2021;
                profitLossViewModel.TotalOperatingExpenses2020 = profitLossViewModel.GeneralAndAdministrativeExpense2020 + profitLossViewModel.OperatingExpense2020 + profitLossViewModel.SellingAndDistributionExpense2020;
                profitLossViewModel.ProfitLossBeforeTaxation2021 = profitLossViewModel.GrossProfitLoss2021 - profitLossViewModel.TotalOperatingExpenses2021;
                profitLossViewModel.ProfitLossBeforeTaxation2020 = profitLossViewModel.GrossProfitLoss2020 - profitLossViewModel.TotalOperatingExpenses2020;
                profitLossViewModel.ProfitLossAfterTaxation2021 = profitLossViewModel.ProfitLossBeforeTaxation2021 - profitLossViewModel.Taxation2021;
                profitLossViewModel.ProfitLossAfterTaxation2020 = profitLossViewModel.ProfitLossBeforeTaxation2020 - profitLossViewModel.Taxation2020;

            }
            #endregion

            return profitLossViewModel;
        }

    }
}
