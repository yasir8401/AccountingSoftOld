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
    public class UserRoleController : Controller
    {
        private readonly ILogger<UserRoleController> _logger;
        private IUserRolesService _UserRolesService;
        private IRoleService _RoleService;
        private IUserService _UserService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;


        private dynamic expObj;
        public UserRoleController(ILogger<UserRoleController> logger, IRoleService RoleService, IUserService UserService, IBranchService BranchService, ICompanyService CompanyService, IUserRolesService UserRolesService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _RoleService = RoleService;
            _UserRolesService = UserRolesService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _UserService = UserService;

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
            expObj.UserRolesList = _UserRolesService.dbset().Include(c => c.Role).Include(c => c.User).Where(x=>x.UserId == userId).ToList();

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/user/{userId}/{id=0}")]
        public IActionResult edit(int userId, int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.userList = _UserService.Find(c => c.UserId == userId).ToList();
            expObj.roleList = _RoleService.GetAll();

            expObj.userId = userId;
            expObj.userDetails = _UserService.GetById(userId);
            expObj.UserRolesDetails = _UserRolesService.GetById(id);
            if (expObj.UserRolesDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.UserRolesDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.UserRoles postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _UserRolesService.GetById(postedData.UserRoleId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "UserRoleId " + postedData.UserRoleId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _UserRolesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _UserRolesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.UserRoles postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _UserRolesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _UserRolesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _UserRolesService.Delete(Int32.Parse(id));

            result.msg = _UserRolesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
