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

using Microsoft.AspNetCore.Hosting;
using ErpOnClick.DAL.Utilities;

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class NavigationController : Controller
    {
        private readonly ILogger<NavigationController> _logger;
        private INavigationService _NavigationService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IModuleService _ModuleService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public NavigationController(IUserService UserService,ILogger<NavigationController> logger, IModuleService ModuleService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, INavigationService NavigationService)
        {
            _logger = logger;
            _UserService = UserService;
            _NavigationService = NavigationService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _ModuleService = ModuleService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {

            expObj.NavigationList = _NavigationService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.moduleList = _ModuleService.GetAll();

            expObj.NavigationDetails = _NavigationService.GetById(id);
            if (expObj.NavigationDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.NavigationDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Navigations postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _NavigationService.GetById(postedData.NavigationId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "NavigationId " + postedData.NavigationId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _NavigationService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _NavigationService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(Navigations postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _NavigationService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _NavigationService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _NavigationService.Delete(Int32.Parse(id));


            result.msg = _NavigationService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
