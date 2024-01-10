using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserPrivilegesController : Controller
    {
        private readonly ILogger<UserPrivilegesController> _logger;
        private IUserPrivilegesService _UserPrivilegesService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;
        private IPrivilegesService _PrivilegesService;

        private dynamic expObj;
        public UserPrivilegesController(ILogger<UserPrivilegesController> logger, IPrivilegesService PrivilegesService, IUserService UserService, IBranchService BranchService, ICompanyService CompanyService, IUserPrivilegesService UserPrivilegesService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _UserPrivilegesService = UserPrivilegesService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _PrivilegesService = PrivilegesService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/user/{userId}")]
        public IActionResult Index(int userId = 0)
        {
            expObj.userId = userId;
            expObj.userDetails = _UserService.GetById(userId);
            return View(expObj);
        }

        public IActionResult _list(int userId)
        {
            expObj.userId = userId;
            expObj.UserPrivilegesList = _UserPrivilegesService.dbset().Include(c => c.Privilege).Include(c => c.User).ToList();

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/user/{userId}/{id=0}")]
        public IActionResult edit(int userId, int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.privilagesList = _PrivilegesService.GetAll();
            expObj.userList = _UserService.Find(c => c.UserId == userId).ToList();

            expObj.userId = userId;
            expObj.userDetails = _UserService.GetById(userId);

            expObj.UserPrivilegesDetails = _UserPrivilegesService.GetById(id);
            if (expObj.UserPrivilegesDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.UserPrivilegesDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.UserPrivileges postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _UserPrivilegesService.GetById(postedData.UserPrivilegeId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "UserPrivilegeId " + postedData.UserPrivilegeId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _UserPrivilegesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _UserPrivilegesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.UserPrivileges postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _UserPrivilegesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _UserPrivilegesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _UserPrivilegesService.Delete(Int32.Parse(id));

            result.msg = _UserPrivilegesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
