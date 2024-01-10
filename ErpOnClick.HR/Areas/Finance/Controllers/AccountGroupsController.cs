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
using Microsoft.Extensions.Logging;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class AccountGroupsController : Controller
    {
        private readonly ILogger<AccountGroupsController> _logger;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public AccountGroupsController(IUserService UserService,ILogger<AccountGroupsController> logger, ICompanyService CompanyService, IBranchService BranchService, IAccountGroupsService AccountGroupsService)
        {
            _logger = logger;
            _UserService = UserService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            expObj.AccountsGroups = _AccountGroupsService.GetAll();
            return View(expObj);
        }


        public IActionResult _list(int AccountGroupId)
        {
            expObj.AccountsGroups = _AccountGroupsService.GetAll();
            expObj.AccountGroupsIdList = _AccountGroupsService.dbset()
                .Where(c => (AccountGroupId != 0 && c.ParentAccountGroupId == AccountGroupId || AccountGroupId == 0))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int AccountGroupId)
        {
            expObj.AccountGroupsIdList = _AccountGroupsService.dbset()
                .Where(c => (AccountGroupId != 0 && c.ParentAccountGroupId == AccountGroupId || AccountGroupId == 0))
                .ToList();

            if (AccountGroupId == 0)
            {
                expObj.AccountGroup = "All";

            }
            else
            {
                expObj.AccountGroup = _AccountGroupsService.GetById(AccountGroupId).AccountGroupNameEn;
            }

            expObj.AccountsGroups = _AccountGroupsService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.IdDetail = _AccountGroupsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.AccountGroupsList = _AccountGroupsService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(AccountGroups postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;
                result.msg = _AccountGroupsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountGroupsService.SaveChanges();
                    result.scalerVal = postedData.AccountGroupId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(AccountGroups postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _AccountGroupsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AccountGroupsService.SaveChanges();
                    result.scalerVal = postedData.AccountGroupId;
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
                _AccountGroupsService.Delete(id);
                result.msg = _AccountGroupsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
