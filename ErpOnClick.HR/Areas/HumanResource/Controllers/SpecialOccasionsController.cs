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

namespace ErpOnClick.SpecialOccasion.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class SpecialOccasionsController : Controller
    {
        private readonly ILogger<SpecialOccasionsController> _logger;
        private ISpecialOccasionsService _SpecialOccasionservice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IOvertimeSettingsService _OverTimeSettingService;
        private IUserService _UserService;

        private dynamic expObj;
        public SpecialOccasionsController(IUserService UserService,ILogger<SpecialOccasionsController> logger, IOvertimeSettingsService OverTimeSettingService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ISpecialOccasionsService SpecialOccasionservice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _SpecialOccasionservice = SpecialOccasionservice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _OverTimeSettingService = OverTimeSettingService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.SpecialOccasionList = _SpecialOccasionservice.dbset().Include(x=>x.OvertimeSetting).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.overtimeSettingList = _OverTimeSettingService.GetAll();

            expObj.SpecialOccasionDetails = _SpecialOccasionservice.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.SpecialOccasions postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _SpecialOccasionservice.GetById(postedData.SpecialOccasionId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "SpecialOccasionId " + postedData.SpecialOccasionId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;

                    result.msg = _SpecialOccasionservice.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _SpecialOccasionservice.SaveChanges();
                        result.scalerVal = postedData.SpecialOccasionId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.SpecialOccasions postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _SpecialOccasionservice.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _SpecialOccasionservice.SaveChanges();
                    result.scalerVal = postedData.SpecialOccasionId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _SpecialOccasionservice.Delete(Int32.Parse(id));

            result.msg = _SpecialOccasionservice.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
