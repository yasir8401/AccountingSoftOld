using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ErpOnClick.ErpMain.ViewModel;
using Microsoft.AspNetCore.Localization;

namespace ErpOnClick.ErpMain.Areas.Projects.Controllers
{
    [Area("Projects")]
    [Authorize]
    public class ProjectDetailController : Controller
    {
        private readonly ILogger<ProjectDetailController> _logger;
        private ITeamMemberService _TeamMemberService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _empService;
        private IProjectService _projectService;
        private ITaskService _taskService;




        private dynamic expObj;
        public ProjectDetailController(ILogger<ProjectDetailController> logger, ITaskService taskService, IProjectService projectService, IEmpsService empService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ITeamMemberService TeamMemberService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _empService = empService;
            _TeamMemberService = TeamMemberService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _projectService = projectService;
            _taskService = taskService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            
            //string fileName = "test.txt";
            //string sourcePath = @"C:\Hamza Nayel\NayelSourceCodes\ErpOnClick\ErpOnClick.ErpMain\wwwroot\Files";
            //string targetPath = @"C:\Hamza Nayel\NayelSourceCodes\ErpOnClick\ErpOnClick.Projects\wwwroot\Files";
            //// Use Path class to manipulate file and directory paths.
            //string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            //string destFile = System.IO.Path.Combine(targetPath, fileName);
            //System.IO.File.Copy(sourceFile, destFile, true);

            var projectDetailListing = new List<ProjectDetailListingViewModel> ();
            var projects = _projectService.GetAll();
            var teamMembers = _TeamMemberService.GetAll();
            var empsList = _empService.GetAll();
            var allLookups = _LookupService.GetAll();
            var statuses = allLookups.Where(x => x.LookupTypeId == LookupTypList.ProjectStatus_044).ToList();
            var projectTypeList = allLookups.Where(x => x.LookupTypeId == LookupTypList.ProjectType_043).ToList();

            foreach (var project in projects)
            {
                var projectDetail = new ProjectDetailListingViewModel();
                var planStartDate = project.PlanDateFrom;
                var startDate = project.ProjectStartDate;

                if (planStartDate < startDate)
                {
                    projectDetail.DaysBehidSchedule = (startDate - planStartDate).ToString();
                }

                projectDetail.Project = project;
                projectDetail.TeamMembersList = empsList.Where(x=> teamMembers.Where(y=>y.ProjectId == project.ProjectId).Select(z=>z.EmpId).ToList().Contains(x.EmpId)).ToList();
                projectDetail.Status = statuses.Where(x => x.Code == project.ProjectStatusId).Select(x=>x.LookupNameEn).FirstOrDefault();
                projectDetail.ProjectType = projectTypeList.Where(x => x.Code == project.ProjectTypeId).Select(x=>x.LookupNameEn).FirstOrDefault();
                projectDetail.ProjectManager = empsList.Where(x => x.EmpId == project.ProjectManagerEmpId).FirstOrDefault();
                projectDetailListing.Add(projectDetail);
            }

            expObj.projectDetailListing = projectDetailListing;

            return PartialView(expObj);
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
