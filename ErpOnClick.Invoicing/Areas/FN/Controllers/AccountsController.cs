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

namespace ErpOnClick.Invoicing.Areas.FN.Controllers
{
    [Area("FN")]
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;
        private IAccountsService _AccountsService;
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;

        private dynamic expObj;
        public AccountsController(ILogger<AccountsController> logger, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;
            _AccountsService = AccountsService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.AccountsGroups = _AccountGroupsService.GetAll();
            expObj.AccountsTypes = _AccountTypesService.GetAll();
            return View(expObj);
        }

        public IActionResult _list(int TypeId,int GroupId)
        {
            expObj.AccountIdList = _AccountsService.dbset()
                .Include(c => c.AccountType)
                .Include(c=>c.AccountGroup)
                .Where(c=>(TypeId != 0 && c.AccountTypeId== TypeId || TypeId==0)
                && (GroupId != 0 && c.AccountGroupId == GroupId || GroupId == 0))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int TypeId,int GroupId)
        {
            expObj.AccountIdList = _AccountsService.dbset()
                .Include(c => c.AccountType)
                .Include(c=>c.AccountGroup)
                .Where(c=>(TypeId != 0 && c.AccountTypeId== TypeId || TypeId==0)
                && (GroupId != 0 && c.AccountGroupId == GroupId || GroupId == 0))
                .ToList();

            if (TypeId == 0)
            {
                expObj.Type = "All";
            }
            else
            {
                expObj.Type = _AccountTypesService.GetById(TypeId).AccountTypeNameEn;
            }

            if (GroupId == 0)
            {
                expObj.Group = "All";
            }
            else
            {
                expObj.Group = _AccountGroupsService.GetById(GroupId).AccountGroupNameEn;
            }

            expObj.CompanyDetail = _CompanyService.GetById(1);

            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.IdDetail = _AccountsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.AccountList = _AccountsService.GetAll();
            expObj.AccountTypesList = _AccountTypesService.GetAll();
            expObj.AccountGroupsList = _AccountGroupsService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Accounts postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;

                result.msg = _AccountsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountsService.SaveChanges();
                    result.scalerVal = postedData.AccountId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Accounts postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _AccountsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountsService.SaveChanges();
                    result.scalerVal = postedData.AccountId;
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
                _AccountsService.Delete(id);
                result.msg = _AccountsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
