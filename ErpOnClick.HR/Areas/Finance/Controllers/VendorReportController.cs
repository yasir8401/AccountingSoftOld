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
    public class VendorReportController : Controller
    {
        private readonly ILogger<VendorReportController> _logger;
      
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IVendorsService _VendorsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAccountsService _accountsService;
        private IVoucherLinesService _VoucherLinesService;

        private dynamic expObj;
        public VendorReportController(ILogger<VendorReportController> logger, IVendorsService VendorsService, IAccountsService accountsService, IVoucherLinesService VoucherLinesService, ICompanyService CompanyService, IBranchService BranchService,  IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;

            _VendorsService = VendorsService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _VoucherLinesService = VoucherLinesService;
            _accountsService = accountsService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index(int VendorId, DateTime FromDate, DateTime ToDate)
        {
            expObj.vendorsList = _VendorsService.GetAll();
            expObj.vendorId = VendorId;
            expObj.fromDate = FromDate;
            expObj.toDate = ToDate;

            return View(expObj);
        }

        public IActionResult _list(DateTime FromDate, DateTime ToDate, int VendorId)
        {
            expObj.listReportVendor = GenerateReportForVendor(FromDate, ToDate, VendorId);

            return PartialView(expObj);
        }

        public IActionResult PrintList(DateTime FromDate, DateTime ToDate, int VendorId)
        {
            expObj.listReportVendor = GenerateReportForVendor(FromDate,ToDate, VendorId);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        public List<VendorReportModel> GenerateReportForVendor(DateTime FromDate, DateTime ToDate,int VendorId)
        {
            int OpeningBalance = 0;
            int Balance = 0;
            List<VendorReportModel> listReportVendor = new List<VendorReportModel>();
            List<VoucherLines> allgeneralEntriesList = _VoucherLinesService.dbset().IncludeOptimized(x => x.Account).ToList();
            List<VoucherLines> newgeneralEntriesList = null;
            List<VoucherLines> oldgeneralEntriesList = null;
            Vendors vendorDetails = _VendorsService.GetById(VendorId);

            #region MakingReportForVendor
            
                newgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate) && x.AccountId== vendorDetails.AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
                oldgeneralEntriesList = allgeneralEntriesList.Where(x => x.CreatedDate < Convert.ToDateTime(FromDate) && x.AccountId== vendorDetails.AccountId).OrderBy(c=>c.CreatedDate.Value.Date).ToList();
            
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
            VendorReportModel firstRow = new VendorReportModel();
            firstRow.Account = "Opening Balance";
            firstRow.CreatedDate = FromDate;
            firstRow.Balance = OpeningBalance;
            listReportVendor.Insert(0, firstRow);
            Balance = OpeningBalance;
            foreach (var item in newgeneralEntriesList)
            {
                if (item.Credit == null)
                {
                    item.Credit = 0;
                }
                if (item.Debit == null)
                {
                    item.Debit = 0;
                }
                Balance = Convert.ToInt32(Balance + (item.Debit - item.Credit));
                VendorReportModel reportObject = new VendorReportModel();
                reportObject.Credit = item.Credit;
                reportObject.Debit = item.Debit;
                reportObject.Balance = Balance;
                reportObject.Account = item.Account.AccountNameEn;
                reportObject.CreatedDate = item.CreatedDate;

                listReportVendor.Add(reportObject);
            }
            
            
            #endregion

            return listReportVendor;
        }


    }
}
