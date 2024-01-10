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


namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class PrivilegesController : Controller
    {
        private readonly ILogger<PrivilegesController> _logger;
        private IPrivilegesService _PrivilegesService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private INavigationService _NavigationService;
        private IModuleService _ModuleService;
        private IUserService _UserService;

        private dynamic expObj;
        public PrivilegesController(IUserService UserService,ILogger<PrivilegesController> logger, INavigationService NavigationService, IModuleService ModuleService, IBranchService BranchService, ICompanyService CompanyService, IPrivilegesService PrivilegesService)
        {
            _logger = logger;
            _UserService = UserService;
            _PrivilegesService = PrivilegesService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _NavigationService = NavigationService;
            _ModuleService = ModuleService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.PrivilegesList = _PrivilegesService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.moduleList = _ModuleService.GetAll();
            expObj.navigationList = _NavigationService.GetAll();

            expObj.PrivilegesDetails = _PrivilegesService.GetById(id);
            if (expObj.PrivilegesDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.PrivilegesDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Privileges postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _PrivilegesService.GetById(postedData.PrivilegeId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "PrivilegeId " + postedData.PrivilegeId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _PrivilegesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _PrivilegesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Privileges postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _PrivilegesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _PrivilegesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _PrivilegesService.Delete(Int32.Parse(id));

            result.msg = _PrivilegesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
