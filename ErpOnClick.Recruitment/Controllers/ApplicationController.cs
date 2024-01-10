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
using System.Security.Claims;
using ErpOnClick.DAL.Utilities;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.Recruitment.ViewModel;
using ErpOnClick.Recruitment.Models;

namespace ErpOnClick.Application.Controllers
{
  
    [Authorize]
    public class ApplicationController : Controller
    {
        private readonly ILogger<ApplicationController> _logger;
        private IApplicationsService _ApplicationService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private ERPonClickContext _db;
        private IJobPortalUserService _JobPortalUserService;

        private dynamic expObj;
        public ApplicationController(ILogger<ApplicationController> logger, IJobPortalUserService JobPortalUserService, ERPonClickContext db, IWebHostEnvironment HostEnvironment, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IApplicationsService ApplicationService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _ApplicationService = ApplicationService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _JobPortalUserService = JobPortalUserService;
            _HostEnvironment = HostEnvironment;
            _db = db;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
         
         
            return View(expObj);
        }

        public IActionResult _list(string JobDepartmentId)
        {
             var ApplicantId = Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value.ToString());
         
            var joinedQuery = _db.Applications.Join(_db.Lookups, app => app.ApplicationStatus, look => look.Code, (app, look) => new ApplicantLookUpViewModel { Application = app, Lookup = look }).ToList();
            expObj.applicationList = joinedQuery.Where(x => x.Application.ApplicantId == ApplicantId).ToList();
            return PartialView(expObj);
        }   



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.vacantJobList = _VacantJobsService.GetAll();
            expObj.vacantJobDetail = _VacantJobsService.GetById(id);
            expObj.applicationDetails = _ApplicationService.GetById(0);
            expObj.degreeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Degree_008).ToList();

            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> save(ApplicationInherited postedData)
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
                    var userID = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
                    var user = _JobPortalUserService.GetById(userID);

                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.ApplicantId = Int32.Parse( HttpContext.User.FindFirst(ClaimTypes.Name).Value.ToString());
                    postedData.ApplicationSourceType = "";
                    postedData.ApplicationStatus = "007001";

                    postedData.ApplicantName = user.UserName;
                    postedData.Email = user.Email;
                    postedData.Phone = user.MobileNo;

                    var filePath = await FileHandling.UploadFile(_HostEnvironment, postedData.CVFile);
                    if (!String.IsNullOrWhiteSpace(filePath))
                    {
                        postedData.CvAttachment = filePath;
                    }
                    var filePathCoverLetter = await FileHandling.UploadFile(_HostEnvironment, postedData.CoverLetterFile);
                    if (!String.IsNullOrWhiteSpace(filePathCoverLetter))
                    {
                        postedData.CoverNote = filePathCoverLetter;
                    }

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


       

    }
}
