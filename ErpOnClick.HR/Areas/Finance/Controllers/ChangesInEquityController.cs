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
    public class ChangesInEquityController : Controller
    {
        private readonly ILogger<ChangesInEquityController> _logger;
        private readonly ILogger<ProfitLossController> _pllogger;

        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _voucherLinesService;

        private dynamic expObj;
        public ChangesInEquityController(ILogger<ChangesInEquityController> logger, IVoucherLinesService voucherLinesService, IAccountsService accountsService, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
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
            expObj.changesInEquityViewModel = GenerateReportForChangesInEquity();

            return PartialView(expObj);
        }

        public IActionResult PrintList()
        {
            expObj.changesInEquityViewModel = GenerateReportForChangesInEquity();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public ChangesInEquityViewModel GenerateReportForChangesInEquity()
        {

            ChangesInEquityViewModel changesInEquityViewModel = new ChangesInEquityViewModel();
            List<VoucherLines> voucherLines = _voucherLinesService.dbset().IncludeOptimized(x => x.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.ParentAccount).ToList();

            #region MakingReportForChangesInEquity

            ProfitLossController profitLossController = new ProfitLossController(_pllogger, _voucherLinesService, _accountsService, _CompanyService, _BranchService, _AccountTypesService, _AccountGroupsService);
            ProfitLossViewModel plvm = profitLossController.GenerateReportForProfitLoss();
            changesInEquityViewModel.PLAT_2021 = plvm.ProfitLossAfterTaxation2021;
            changesInEquityViewModel.PLAT_2020 = plvm.ProfitLossAfterTaxation2020;

            changesInEquityViewModel.OCI_2021 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period") && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit);
            changesInEquityViewModel.OCI_2020 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Other comprehensive income for the period") && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit);

            changesInEquityViewModel.ISP_2021 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital") && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit);
            changesInEquityViewModel.ISP_2020 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Issued, subscribed and paid up share capital") && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit);

            changesInEquityViewModel.SP_2021 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Share premium") && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit);
            changesInEquityViewModel.SP_2020 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Share premium" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Share premium") && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit);

            changesInEquityViewModel.R_2021 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Reserve") && c.CreatedDate.Value.Year == 2021).Sum(c => c.Credit);
            changesInEquityViewModel.R_2020 = voucherLines.Where(c => (c.Account.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Reserve" || c.Account.ParentAccount.ParentAccount.ParentAccount.ParentAccount.AccountNameEn == "Reserve") && c.CreatedDate.Value.Year == 2020).Sum(c => c.Credit);

            changesInEquityViewModel.OCI_2021 = (changesInEquityViewModel.OCI_2021 != null ? changesInEquityViewModel.OCI_2021 : 0);
            changesInEquityViewModel.OCI_2020 = (changesInEquityViewModel.OCI_2020 != null ? changesInEquityViewModel.OCI_2020 : 0);
            changesInEquityViewModel.ISP_2021 = (changesInEquityViewModel.ISP_2021 != null ? changesInEquityViewModel.ISP_2021 : 0);
            changesInEquityViewModel.ISP_2020 = (changesInEquityViewModel.ISP_2020 != null ? changesInEquityViewModel.ISP_2020 : 0);
            changesInEquityViewModel.SP_2021 = (changesInEquityViewModel.SP_2021 != null ? changesInEquityViewModel.SP_2021 : 0);
            changesInEquityViewModel.SP_2020 = (changesInEquityViewModel.SP_2020 != null ? changesInEquityViewModel.SP_2020 : 0);
            changesInEquityViewModel.R_2021 = (changesInEquityViewModel.R_2021 != null ? changesInEquityViewModel.R_2021 : 0);
            changesInEquityViewModel.R_2020 = (changesInEquityViewModel.R_2020 != null ? changesInEquityViewModel.R_2020 : 0);

            #endregion

            return changesInEquityViewModel;
        }


    }
}
