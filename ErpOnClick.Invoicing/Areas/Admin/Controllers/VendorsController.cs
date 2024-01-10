﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.Invoicing.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class VendorsController : Controller
    {
        private readonly ILogger<VendorsController> _logger;
        private IVendorsService _VendorsService;
        private IAccountsService _AccountsService;

        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;

        private dynamic expObj;
        public VendorsController(ILogger<VendorsController> logger, ICompanyService CompanyService, IBranchService BranchService, ILookupsService LookupTypesService, IVendorsService VendorsService, IAccountsService AccountsService)
        {
            _logger = logger;
            _AccountsService = AccountsService;

            _VendorsService = VendorsService;
            _LookupService = LookupTypesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.Accounts = _AccountsService.GetAll();
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();

            return View(expObj);
        }


        public IActionResult _list(int AccountId, string Status)
        {
            expObj.VendorIdList = _VendorsService.dbset()
                .Include(c => c.Account)
                .Where(c => (c.AccountId == AccountId || AccountId == 0)
                && (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int AccountId, string Status)
        {
            expObj.VendorIdList = _VendorsService.dbset()
                .Include(c => c.Account)
                .Where(c => (c.AccountId == AccountId || AccountId == 0)
                && (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();

            if (AccountId == 0)
            {
                expObj.AccountId = "All";
            }
            else
            {
                expObj.AccountId = _AccountsService.GetById(AccountId).AccountNameEn;
            }
            if (Status == null)
            {
                expObj.Status = "All";
            }
            else
            {
                expObj.Status = Status;
            }

            expObj.CompanyDetail = _CompanyService.GetById(1);
            return PartialView(expObj);
        }

        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();
            expObj.City = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.Country = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.State = lookupList.Where(x => x.LookupTypeId == LookupTypList.State_028).ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.Accounts = _AccountsService.GetAll();

            //expObj.BranchDetail = _BranchService.GetAll();
            expObj.IdDetail = _VendorsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Vendors postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;

                result.msg = _VendorsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _VendorsService.SaveChanges();
                    result.scalerVal = postedData.VendorId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Vendors postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _VendorsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _VendorsService.SaveChanges();
                    result.scalerVal = postedData.VendorId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            if (id != 0)
            {
                _VendorsService.Delete(id);
                result.msg = _VendorsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
