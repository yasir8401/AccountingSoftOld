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
using Microsoft.AspNetCore.Localization;

namespace ErpOnClick.Application.Areas.Admin.Controllers
{
    [Area("Admin")] 
    [Authorize]
    public class ApplicationController : Controller
    {
        private readonly ILogger<ApplicationController> _logger;
        private IApplicationsService _ApplicationService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;


        private dynamic expObj;
        public ApplicationController(ILogger<ApplicationController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IApplicationsService ApplicationService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _ApplicationService = ApplicationService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            return View(expObj);
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.applicationList = _ApplicationService.GetAll().Where(c =>
                  (c.JobDepartmentId == JobDepartmentId || JobDepartmentId == null )
          ).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.applicationSourceList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationSourceType_006).ToList();
            expObj.applicationStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.degreeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Degree_008).ToList();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            
            expObj.vacantJobList = _VacantJobsService.GetAll();
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();


            expObj.applicationDetails = _ApplicationService.GetById(id);
            if (expObj.applicationDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.applicationDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Applications postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _ApplicationService.GetById(postedData.ApplicantId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "JobId " + postedData.ApplicantId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _ApplicationService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _ApplicationService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Applications postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _ApplicationService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ApplicationService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _ApplicationService.Delete(Int32.Parse(id));

            result.msg = _ApplicationService.SaveChanges();
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
