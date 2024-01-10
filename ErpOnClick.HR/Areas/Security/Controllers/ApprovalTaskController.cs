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

using Microsoft.AspNetCore.Localization;
using ErpOnClick.ErpMain.ViewModel;

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles ="SuperAdmin")]
    public class ApprovalTaskController : Controller
    {
        private readonly ILogger<ApprovalTaskController> _logger;
        private IApprovalTaskService _ApprovalTaskService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IDepartmentService _departmentService;
        private IApprovalRouteService _approvalRouteService;
        private INavigationService _NavigationService;

        private dynamic expObj;
        public ApprovalTaskController(ILogger<ApprovalTaskController> logger, INavigationService NavigationService, IApprovalRouteService approvalRouteService, IDepartmentService departmentService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IApprovalTaskService ApprovalTaskService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _NavigationService = NavigationService;
            _ApprovalTaskService = ApprovalTaskService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _UserService = UserService;
            _departmentService = departmentService;
            _approvalRouteService = approvalRouteService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
          
            expObj.ApprovalTaskList = _ApprovalTaskService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
           
            expObj.ApprovalTaskDetails = _ApprovalTaskService.GetById(id);
            expObj.userList = _UserService.GetAll();
            expObj.deptList = _departmentService.GetAll();
            expObj.navigationList = _NavigationService.GetAll();


            expObj.approvalRoutesList = _approvalRouteService.Find(x => x.ApprovalTaskId == id).ToList();

            return View(expObj);

        }


        [HttpPost]
        public async Task<ActionResult> save(ApprovalTaskRouteViewModel postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _ApprovalTaskService.GetById(postedData.ApprovalTask.ApprovalTaskId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "ApprovalTaskId " + postedData.ApprovalTask.ApprovalTaskId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.ApprovalTask.CompanyId = user.CompanyId;
                    postedData.ApprovalTask.BranchId = user.BranchId;
                    postedData.ApprovalTask.CreatedDate = System.DateTime.Now;
                    postedData.ApprovalTask.CreatedBy = 0;
                  
                    result.msg = _ApprovalTaskService.Insert(postedData.ApprovalTask);
                    if (result.msg == "")
                    {
                        result.msg = _ApprovalTaskService.SaveChanges();
                        if (result.msg == "")
                        {
                            if (postedData.ApprovalRoutes != null)
                            {
                                foreach (var itemRoutes in postedData.ApprovalRoutes)
                                {
                                    itemRoutes.ApprovalTaskId = postedData.ApprovalTask.ApprovalTaskId;
                                    itemRoutes.CreatedBy = 0;
                                    itemRoutes.CreatedDate = System.DateTime.Now;
                                    itemRoutes.CompanyId = postedData.ApprovalTask.CompanyId;
                                    itemRoutes.BranchId = postedData.ApprovalTask.BranchId;
                                    result.msg = _approvalRouteService.Insert(itemRoutes);
                                }
                                result.msg = _approvalRouteService.SaveChanges();
                            }
                           
                        }
                        
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(ApprovalTaskRouteViewModel postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ApprovalTask.ModifiedDate = System.DateTime.Now;
                postedData.ApprovalTask.ModifiedBy = 1;
              
                result.msg = _ApprovalTaskService.Update(postedData.ApprovalTask);
                if (result.msg == "")
                {
                    result.msg = _ApprovalTaskService.SaveChanges();
                    if (result.msg == "")
                    {
                        if (postedData.ApprovalRoutes != null)
                        {
                            foreach (var itemRoutes in postedData.ApprovalRoutes)
                            {
                                itemRoutes.ApprovalTaskId = postedData.ApprovalTask.ApprovalTaskId;
                                itemRoutes.ModifiedBy = 1;
                                itemRoutes.CompanyId = postedData.ApprovalTask.CompanyId;
                                itemRoutes.BranchId = postedData.ApprovalTask.BranchId;
                                itemRoutes.ModifiedDate = System.DateTime.Now;
                                result.msg = _approvalRouteService.Update(itemRoutes);
                            }
                            result.msg = _approvalRouteService.SaveChanges();
                            foreach (var itemRoutes in postedData.ApprovalRoutes)
                            {
                                if (itemRoutes.IsDeleted == "true")
                                {
                                    result.msg = _approvalRouteService.Delete(itemRoutes.ApprovalRouteId);
                                }
                            }
                            result.msg = _approvalRouteService.SaveChanges();
                        }
                        
                    }
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _ApprovalTaskService.Delete(Int32.Parse(id));

       
            result.msg = _ApprovalTaskService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnurl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnurl);
        }
    }
}
