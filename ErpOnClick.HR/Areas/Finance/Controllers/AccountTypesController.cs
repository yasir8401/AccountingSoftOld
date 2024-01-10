using System;
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

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class AccountTypesController : Controller
    {
        private readonly ILogger<AccountTypesController> _logger;
        private IAccountTypesService _AccountTypesService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public AccountTypesController(IUserService UserService,ILogger<AccountTypesController> logger, ICompanyService CompanyService, IBranchService BranchService, IAccountTypesService AccountTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _AccountTypesService = AccountTypesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.AccountsTypes = _AccountTypesService.GetAll();
            return View(expObj);
        }


        public IActionResult _list(int AccountTypeId)
        {
            expObj.AccountTypes = _AccountTypesService.GetAll();
            expObj.AccountTypeIdList = _AccountTypesService.dbset()
                .Where(c => (AccountTypeId != 0 && c.ParentAccountTypeId == AccountTypeId || AccountTypeId == 0))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int AccountTypeId)
        {
            expObj.AccountTypeIdList = _AccountTypesService.dbset()
                .Where(c => (AccountTypeId != 0 && c.ParentAccountTypeId == AccountTypeId || AccountTypeId == 0))
                .ToList();

            if(AccountTypeId == 0)
            {
                expObj.AccountType = "All";

            }
            else
            {
                expObj.AccountType = _AccountTypesService.GetById(AccountTypeId).AccountTypeNameEn;
            }


            expObj.AccountTypes = _AccountTypesService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return PartialView(expObj);
        }

        public IActionResult edit(int id)
        {
            expObj.IdDetail = _AccountTypesService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.AccountTypesList = _AccountTypesService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(AccountTypes postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                result.msg = _AccountTypesService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountTypesService.SaveChanges();
                    result.scalerVal = postedData.AccountTypeId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(AccountTypes postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _AccountTypesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountTypesService.SaveChanges();
                    result.scalerVal = postedData.AccountTypeId;
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
                _AccountTypesService.Delete(id);
                result.msg = _AccountTypesService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
