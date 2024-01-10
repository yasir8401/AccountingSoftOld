using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.Invoicing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.Invoicing.Areas.FN.Controllers
{
    [Area("FN")]
    [Authorize]
    public class TrailReportController : Controller
    {
        private readonly ILogger<TrailReportController> _logger;
      
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IGeneralEntriesLinesService _generalEntriesLinesService;

        private dynamic expObj;
        public TrailReportController(ILogger<TrailReportController> logger, IAccountsService accountsService, IGeneralEntriesLinesService generalEntriesLinesService, ICompanyService CompanyService, IBranchService BranchService,  IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;
          
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _generalEntriesLinesService = generalEntriesLinesService;
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
            expObj.listReportTrailBalance = GenerateReportForTrailBalance(FromDate,ToDate);
            expObj.CompanyDetail = _CompanyService.GetById(1);

            return PartialView(expObj);
        }

        public List<TrailBalanceReportModel> GenerateReportForTrailBalance(string FromDate, string ToDate)
        {
            List<TrailBalanceReportModel> listReportTrailBalance = new List<TrailBalanceReportModel>();
            List<IGrouping<Accounts, GeneralEntriesLines>> generalEntriesList = null;
            var allAccounts = _accountsService.GetAll();

            #region MakingReportForTrailBalance
            if (!String.IsNullOrWhiteSpace(FromDate) && !String.IsNullOrWhiteSpace(ToDate))
            {
                generalEntriesList = _generalEntriesLinesService.dbset().Include(x => x.Account).Where(x => x.CreatedDate.Value.Date >= DateTime.Parse(FromDate).Date && x.CreatedDate.Value.Date <= DateTime.Parse(ToDate)).AsEnumerable().GroupBy(x => x.Account).ToList();
            }
            else
            {
                generalEntriesList = _generalEntriesLinesService.dbset().Include(x => x.Account).AsEnumerable().GroupBy(x => x.Account).ToList();
            }

            foreach (var item in generalEntriesList)
            {
                TrailBalanceReportModel reportObject = new TrailBalanceReportModel();

                reportObject.Credit = item.Sum(x => x.Credit);
                reportObject.Debit = item.Sum(x => x.Debit);
                reportObject.Balance = reportObject.Debit - reportObject.Credit;
                reportObject.Account = item.Select(x => x.Account.AccountNameEn).FirstOrDefault();

                listReportTrailBalance.Add(reportObject);
            }
            var accountsWithGeneralEntries = generalEntriesList.Select(x => x.Key.AccountId).ToList();
            var accountWithNoGeneralEntries = allAccounts.Where(x => !(accountsWithGeneralEntries.Contains(x.AccountId))).ToList();
            foreach (var account in accountWithNoGeneralEntries)
            {
                TrailBalanceReportModel reportObject = new TrailBalanceReportModel();

                reportObject.Credit = 0;
                reportObject.Debit = 0;
                reportObject.Balance = 0;
                reportObject.Account = account.AccountNameEn;

                listReportTrailBalance.Add(reportObject);
            }
            #endregion

            return listReportTrailBalance;
        }

    }
}
