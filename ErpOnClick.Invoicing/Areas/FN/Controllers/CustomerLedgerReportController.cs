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
    public class CustomerLedgerReportController : Controller
    {
        private readonly ILogger<CustomerLedgerReportController> _logger;
      
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private ICustomersService _CustomersService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IGeneralEntriesLinesService _generalEntriesLinesService;

        private dynamic expObj;
        public CustomerLedgerReportController(ILogger<CustomerLedgerReportController> logger, ICustomersService CustomersService, IAccountsService accountsService, IGeneralEntriesLinesService generalEntriesLinesService, ICompanyService CompanyService, IBranchService BranchService,  IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
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
            return View();
        }

        public IActionResult _list(DateTime FromDate, DateTime ToDate)
        {
            expObj.listReportCustomerLedger = GenerateReportForCustomerLegder(FromDate, ToDate);

            return PartialView(expObj);
        }

        public IActionResult PrintList(DateTime FromDate, DateTime ToDate)
        {
            expObj.listReportCustomerLedger = GenerateReportForCustomerLegder(FromDate,ToDate);
            expObj.CompanyDetail = _CompanyService.GetById(1);

            return PartialView(expObj);
        }

        public List<CustomerReportModel> GenerateReportForCustomerLegder(DateTime FromDate, DateTime ToDate)
        {
            List<CustomerReportModel> listReportCustomerLedger = new List<CustomerReportModel>();

            IEnumerable<GeneralEntriesLines> allgeneralEntriesList = _generalEntriesLinesService.dbset().Include(x => x.Account.Customers);
            List<IGrouping<Accounts, GeneralEntriesLines>> newgeneralEntriesList = null;

            #region MakingReportForCustomerLedger

            newgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate) && x.Account.Customers.Count() != 0).OrderBy(c=>c.CreatedDate.Value.Date).AsEnumerable().GroupBy(c=>c.Account).ToList();
            

            foreach (var item in newgeneralEntriesList)
            {
                foreach(var inneritem in item.Key.Customers) { 
                CustomerReportModel reportObject = new CustomerReportModel();
                reportObject.Credit = item.Sum(c=>c.Credit);
                reportObject.Debit = item.Sum(c => c.Debit);
                reportObject.Balance = reportObject.Debit - reportObject.Credit;
                reportObject.Account = item.Select(x => x.Account.AccountNameEn).FirstOrDefault();
                reportObject.CreatedDate = item.Select(x => x.CreatedDate).FirstOrDefault();
                reportObject.CustomerId = Convert.ToInt32(item.Select(x => x.Account.Customers.Where(c=>c.CustomerId==inneritem.CustomerId).Select(c => c.CustomerId).FirstOrDefault()).FirstOrDefault());
                reportObject.Customer = item.Select(x => x.Account.Customers.Where(c=>c.CustomerId==inneritem.CustomerId).Select(c=>c.CustomerNameEn).FirstOrDefault().ToString()).FirstOrDefault().ToString();
                reportObject.FromDate = FromDate;
                reportObject.ToDate = ToDate;
                listReportCustomerLedger.Add(reportObject);
                }
            }
            #endregion

            return listReportCustomerLedger;
        }


    }
}
