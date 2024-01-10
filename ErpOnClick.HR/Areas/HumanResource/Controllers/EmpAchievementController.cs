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
using ErpOnClick.DAL.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.ErpMain.Models;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpAchievementController : Controller
    {
        private readonly ILogger<EmpAchievementController> _logger;
        private IEmpEducationService _EmpEducationService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IAchievementService _AchievementService;

        private dynamic expObj;
        public EmpAchievementController(IUserService UserService, ILogger<EmpAchievementController> logger, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpEducationService EmpEducationService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService, IAchievementService achievementService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpEducationService = EmpEducationService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _AchievementService = achievementService;
            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }


        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.AchievementList = _AchievementService.Find(x => x.EmpId == empId).ToList();
           
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]

        public async Task<IActionResult> edit(int empId, int id)
        {

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.EmpAchievementDetails = _AchievementService.GetById(id);
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }



        [HttpPost]
        public async Task<ActionResult> save(Achievement postedData)
        {
            DbResult result = new DbResult();
            var empId = Convert.ToInt32(User.Identity.Name);
            if (postedData != null)
            {
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = empId;
                
                result.msg = _AchievementService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AchievementService.SaveChanges();

                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(Achievement postedData)
        {
            DbResult result = new DbResult();
            var empId = Convert.ToInt32(User.Identity.Name);
            if (postedData != null)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = empId;

                result.msg = _AchievementService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AchievementService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _AchievementService.Delete(Int32.Parse(id));
            result.msg = _AchievementService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
