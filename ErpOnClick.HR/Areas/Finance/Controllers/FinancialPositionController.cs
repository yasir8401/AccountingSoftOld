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
    public class FinancialPositionController : Controller
    {
        private readonly ILogger<FinancialPositionController> _logger;
        private readonly ILogger<OtherComprehensiveIncomeController> _OCIlogger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _voucherLinesService;

        private dynamic expObj;
        public FinancialPositionController(ILogger<FinancialPositionController> logger, IVoucherLinesService voucherLinesService, IAccountsService accountsService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
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
            expObj.financialPositionViewModel = GenerateReportForFinancialPosition();

            return PartialView(expObj);
        }

        public IActionResult PrintList()
        {
            expObj.financialPositionViewModel = GenerateReportForFinancialPosition();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public FinancialPositionViewModel GenerateReportForFinancialPosition()
        {
            List<VoucherLines> voucherLines = _voucherLinesService.dbset().IncludeOptimized(x => x.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.ParentAccount).ToList();
            FinancialPositionViewModel _report = new FinancialPositionViewModel();

            List<Accounts> accouts = _accountsService.dbset().IncludeOptimized(c => c.ParentAccount.ParentAccount.ParentAccount.ParentAccount).ToList();

            #region MakingReportForFinancialPosition
            _report.Operatingfixedassets_2021 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Fixed assets" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Fixed assets" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) : 0);
            _report.Operatingfixedassets_2020 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Fixed assets" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Fixed assets" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) : 0);

            _report.BankBalance_2021 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Bank Balances" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Bank Balances" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) : 0);
            _report.BankBalance_2020 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Bank Balances" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Bank Balances" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) : 0);

            _report.Receivables_2021 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Receivable" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Receivable" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) : 0);
            _report.Receivables_2020 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Receivable" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Receivable" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) : 0);

            _report.OtherCurrentAssets_2021 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other Current Asset" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other Current Asset" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Debit) : 0);
            _report.OtherCurrentAssets_2020 = (voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other Current Asset" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) != null ? voucherLines.Where(c => c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other Current Asset" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Debit) : 0);

            _report.TotalCurrentAsset_2021 = _report.BankBalance_2021 + _report.Receivables_2021 + _report.OtherCurrentAssets_2021;
            _report.TotalCurrentAsset_2020 = _report.BankBalance_2020 + _report.Receivables_2020 + _report.OtherCurrentAssets_2020;

            _report.TotalAsset_2021 = _report.TotalCurrentAsset_2021 + _report.Operatingfixedassets_2021;
            _report.TotalAsset_2020 = _report.TotalCurrentAsset_2020 + _report.Operatingfixedassets_2020;

            _report.AccountPaybles_2021 = (voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Accounts Payable" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit) != null ? voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Accounts Payable" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit) : 0);
            _report.AccountPaybles_2020 = (voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Accounts Payable" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit) != null ? voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Accounts Payable" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit) : 0);
            _report.OtherCurrentLibilities_2021 = ((voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Other Current Liability" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit)) != null ? (voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Other Current Liability" && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit)) : 0);
            _report.OtherCurrentLibilities_2020 = ((voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Other Current Liability" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit)) != null ? (voucherLines.Where(c => c.Account.ParentAccount.AccountNameEn == "Other Current Liability" && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit)) : 0);
            _report.TotalLiability_2021 = _report.AccountPaybles_2021 + _report.OtherCurrentLibilities_2021;
            _report.TotalLiability_2020 = _report.AccountPaybles_2020 + _report.OtherCurrentLibilities_2020;

            OtherComprehensiveIncomeController otherComprehensiveIncomeController = new OtherComprehensiveIncomeController(_OCIlogger, _voucherLinesService, _accountsService, _CompanyService, _BranchService, _AccountTypesService, _AccountGroupsService);
            OtherComprehensiveIncomeViewModel ocivm = otherComprehensiveIncomeController.GenerateReportForOtherComprehensiveIncome();
            _report.AccumulatedProfit_2021 = ocivm.TCI_2021;
            _report.AccumulatedProfit_2020 = ocivm.TCI_2020;


            _report.TotalReserve_2021 = _report.AccumulatedProfit_2021;
            _report.TotalReserve_2020 = _report.AccumulatedProfit_2020;


            _report.Totalequity_2021 = _report.TotalLiability_2021 + _report.TotalReserve_2021;
            _report.Totalequity_2020 = _report.TotalLiability_2020 + _report.TotalReserve_2020;
            #endregion

            return _report;
        }


    }
}
