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

        private dynamic expObj;
        public AccountLedgerController(ILogger<AccountLedgerController> logger, ICustomersService CustomersService, IAccountsService accountsService, IGeneralEntriesLinesService generalEntriesLinesService, ICompanyService CompanyService, IBranchService BranchService,  IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;

            _CustomersService = CustomersService;
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
            expObj.listReportAccountLedger = GenerateReportForAccountLedger(FromDate,ToDate,AccountId);
            expObj.CompanyDetail = _CompanyService.GetById(1);

            return PartialView(expObj);
        }

        public List<AccountLedgerReportModel> GenerateReportForAccountLedger(DateTime FromDate, DateTime ToDate,int AccountId)
        {
            int OpeningBalance = 0;
            List<AccountLedgerReportModel> listReportAccountLedger = new List<AccountLedgerReportModel>();
            List<GeneralEntriesLines> allgeneralEntriesList = _generalEntriesLinesService.dbset().Include(x => x.Account).ToList();
            List<GeneralEntriesLines> newgeneralEntriesList = null;
            List<GeneralEntriesLines> oldgeneralEntriesList = null;

            #region MakingReportForAccountLedger
            
                newgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate) && x.AccountId== AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
                oldgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate < Convert.ToDateTime(FromDate) && x.AccountId== AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
            
            if(oldgeneralEntriesList.Count() > 0)
            {
                foreach(var oldlines in oldgeneralEntriesList)
                {
                    OpeningBalance += Convert.ToInt32(oldlines.Debit - oldlines.Credit);
                }
            }

            foreach (var item in newgeneralEntriesList)
            {
                AccountLedgerReportModel reportObject = new AccountLedgerReportModel();
                reportObject.Credit = item.Credit;
                reportObject.Debit = item.Debit;
                reportObject.Balance = reportObject.Debit - reportObject.Credit;
                reportObject.Account = item.Account.AccountNameEn;
                reportObject.CreatedDate = item.CreatedDate;
               
                listReportAccountLedger.Add(reportObject);
            }
            AccountLedgerReportModel firstRow = new AccountLedgerReportModel();
            firstRow.Account = "Opening Balance";
            firstRow.CreatedDate = FromDate;
            firstRow.Balance = OpeningBalance;
            listReportAccountLedger.Insert(0, firstRow);
            
            #endregion

            return listReportAccountLedger;
        }


    }
}
