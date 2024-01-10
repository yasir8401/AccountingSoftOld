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

namespace ErpOnClick.NationalHoliday.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class NationalHolidaysController : Controller
    {
        private readonly ILogger<NationalHolidaysController> _logger;
        private INationalHolidaysService _NationalHolidayservice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IOvertimeSettingsService _OverTimeSettingService;
        private IUserService _UserService;

        private dynamic expObj;
        public NationalHolidaysController(IUserService UserService,ILogger<NationalHolidaysController> logger, IOvertimeSettingsService OverTimeSettingService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, INationalHolidaysService NationalHolidayservice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _NationalHolidayservice = NationalHolidayservice;
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
            expObj.NationalHolidayList = _NationalHolidayservice.dbset().Include(x => x.OvertimeSetting).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.overtimeSettingList = _OverTimeSettingService.GetAll();

            expObj.NationalHolidayDetails = _NationalHolidayservice.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.NationalHolidays postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _NationalHolidayservice.GetById(postedData.NationalHolidayId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "NationalHolidayId " + postedData.NationalHolidayId + " is already exists !";
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

                    result.msg = _NationalHolidayservice.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _NationalHolidayservice.SaveChanges();
                        result.scalerVal = postedData.NationalHolidayId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.NationalHolidays postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _NationalHolidayservice.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _NationalHolidayservice.SaveChanges();
                    result.scalerVal = postedData.NationalHolidayId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _NationalHolidayservice.Delete(Int32.Parse(id));

            result.msg = _NationalHolidayservice.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
