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
    public class CustomerReportController : Controller
    {
        private readonly ILogger<CustomerReportController> _logger;
      
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private ICustomersService _CustomersService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _VoucherLinesService;

        private dynamic expObj;
        public CustomerReportController(ILogger<CustomerReportController> logger, ICustomersService CustomersService, IAccountsService accountsService, IVoucherLinesService voucherLinesService, ICompanyService CompanyService, IBranchService BranchService,  IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;

            _CustomersService = CustomersService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _VoucherLinesService = voucherLinesService;
            _accountsService = accountsService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index(int CustomerId,DateTime FromDate, DateTime ToDate)
        {
            expObj.customersList = _CustomersService.GetAll();
            expObj.customerId = CustomerId;
            expObj.fromDate = FromDate;
            expObj.toDate = ToDate;

            return View(expObj);
        }

        public IActionResult _list(DateTime FromDate, DateTime ToDate, int CustomerId)
        {
            expObj.listReportCustomer = GenerateReportForCustomer(FromDate, ToDate, CustomerId);

            return PartialView(expObj);
        }

        public IActionResult PrintList(DateTime FromDate, DateTime ToDate, int CustomerId)
        {
            expObj.listReportCustomer = GenerateReportForCustomer(FromDate,ToDate, CustomerId);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public List<CustomerReportModel> GenerateReportForCustomer(DateTime FromDate, DateTime ToDate,int CustomerId)
        {
            int OpeningBalance = 0;
            int Balance = 0;
            List<CustomerReportModel> listReportCutomer = new List<CustomerReportModel>();
            List<VoucherLines> allgeneralEntriesList = _VoucherLinesService.dbset().IncludeOptimized(x => x.Account).ToList();
            List<VoucherLines> newgeneralEntriesList = null;
            List<VoucherLines> oldgeneralEntriesList = null;
            Customers cutomerDetails = _CustomersService.GetById(CustomerId);

            #region MakingReportForCustomer
            
                newgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate) && x.AccountId== cutomerDetails.AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
                oldgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate < Convert.ToDateTime(FromDate) && x.AccountId== cutomerDetails.AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
            
            if(oldgeneralEntriesList.Count() > 0)
            {
                foreach(var oldlines in oldgeneralEntriesList)
                {
                    if(oldlines.Credit== null)
                    {
                        oldlines.Credit = 0;
                    }
                    if(oldlines.Debit== null)
                    {
                        oldlines.Debit = 0;
                    }
                    OpeningBalance += Convert.ToInt32(oldlines.Debit - oldlines.Credit);
                }
            }
            CustomerReportModel firstRow = new CustomerReportModel();
            firstRow.Account = "Opening Balance";
            firstRow.CreatedDate = FromDate;
            firstRow.Balance = OpeningBalance;
            listReportCutomer.Insert(0, firstRow);
            Balance = OpeningBalance;
            foreach (var item in newgeneralEntriesList)
            {
                if(item.Credit== null)
                {
                    item.Credit = 0;
                }
                if(item.Debit== null)
                {
                    item.Debit = 0;
                }
                Balance = Convert.ToInt32(Balance + (item.Debit - item.Credit));
                CustomerReportModel reportObject = new CustomerReportModel();
                reportObject.Credit = item.Credit;
                reportObject.Debit = item.Debit;
                reportObject.Balance = Balance;
                reportObject.Account = item.Account.AccountNameEn;
                reportObject.CreatedDate = item.CreatedDate;

                listReportCutomer.Add(reportObject);
            }
            
            
            #endregion

            return listReportCutomer;
        }


    }
}
