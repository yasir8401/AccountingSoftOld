using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.Recruitment.Models;
using ErpOnClick.DAL.Interfaces;
using System.Dynamic;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using System.Runtime.CompilerServices;
using ErpOnClick.Recruitment.ViewModel;
using Microsoft.EntityFrameworkCore;


namespace ErpOnClick.Recruitment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private dynamic expObj;
        private IVacantJobsService _VacantJobsService;
        private ILookupsService _LookupService;
        private ERPonClickContext _db;
        public HomeController(ILogger<HomeController> logger, ERPonClickContext DB, IVacantJobsService VacantJobsService,ILookupsService LookupService)
        {
            _logger = logger;
            _VacantJobsService = VacantJobsService;
            _LookupService = LookupService;
            _db = DB;
            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            expObj.VacantJobLists = _VacantJobsService.dbset().Include(x=>x.Company).Include(x=>x.JobType).ToList();
            return View(expObj);
        }
        [HttpGet]
        public IActionResult List(string category, string jobType = null, string location = null, string date = null,string fromRange = null , string toRange = null)
        {
            #region Fitler 

            var jobs = _VacantJobsService.dbset().Include(x=>x.Company).ToList();
            //var jobs = _db.VacantJobs.Include(x => x.JobDepartment).Include(Y => Y.Company).Include(b => b.Branch).Include(s => s.JobStatus).Include(t => t.JobType).ToList();

            if (!string.IsNullOrWhiteSpace(category))
            {
                jobs = jobs.Where(x => x.JobDepartmentId == category).ToList();
            }
            if (!string.IsNullOrWhiteSpace(jobType))
            {
                jobs = jobs.Where(x => x.JobTypeId == jobType).ToList();
            }
            if (!string.IsNullOrWhiteSpace(location))
            {
                jobs = jobs.Where(x => x.CountryId == location).ToList();
            }
            if (!string.IsNullOrWhiteSpace(fromRange) && !string.IsNullOrWhiteSpace(toRange))
            {
                jobs = jobs.Where(x => (x.SalaryRangeStart >= Int32.Parse(fromRange) && x.SalaryRangeEnd <= Int32.Parse(toRange))).ToList();
            }
            if (!string.IsNullOrWhiteSpace(date))
            {

                if (date == "today")
                {
                    jobs = jobs.Where(x => x.CreatedDate == DateTime.UtcNow).ToList();
                }
                else if (date == "2")
                {
                    jobs = jobs.Where(x => x.CreatedDate == DateTime.UtcNow.AddDays(-2)).ToList();
                }
                else if (date == "3")
                {
                    jobs = jobs.Where(x => x.CreatedDate == DateTime.UtcNow.AddDays(-3)).ToList();
                }
                else if (date == "5")
                {
                    jobs = jobs.Where(x => x.CreatedDate == DateTime.UtcNow.AddDays(-5)).ToList();
                }
                else if (date == "10")
                {
                    jobs = jobs.Where(x => x.CreatedDate == DateTime.UtcNow.AddDays(-10)).ToList();
                }
                else
                {
                    jobs = jobs.ToList();
                }
            }
         
            expObj.VacantJobLists = jobs;

            #endregion
            
            expObj.departmentsList = _LookupService.Find(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            expObj.jobTypeList = _LookupService.Find(x => x.LookupTypeId == LookupTypList.RecruitmentJobTypes_003).ToList();
            expObj.locationList = _LookupService.Find(x => x.LookupTypeId == LookupTypList.Country_004).ToList();

            expObj.categoryCheck = category;
            expObj.jobTypeCheck = jobType;
            expObj.locationCheck = location;
            expObj.dateCheck = date;
            expObj.fromRangeCheck = fromRange;
            expObj.toRangeCheck = toRange;

            return PartialView(expObj);
        }
     

        public IActionResult Details(int id)
        {
            expObj.IdDetail = _VacantJobsService.dbset().Include(x=>x.JobType).Include(x=>x.Company).Where(x=>x.JobId == id).FirstOrDefault();
            return View(expObj);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}