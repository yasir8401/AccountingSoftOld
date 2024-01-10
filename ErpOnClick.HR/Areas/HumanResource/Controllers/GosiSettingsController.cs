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

namespace ErpOnClick.GosiSetting.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class GosiSettingsController : Controller
    {
        private readonly ILogger<GosiSettingsController> _logger;
        private IGosiSettingsService _GosiSettingService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public GosiSettingsController(IUserService UserService,ILogger<GosiSettingsController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IGosiSettingsService GosiSettingService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _GosiSettingService = GosiSettingService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.GosiSettingList = _GosiSettingService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.AllowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();


            expObj.GosiSettingDetails = _GosiSettingService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.GosiSettings postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _GosiSettingService.GetById(postedData.GosiSettingId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "GosiSettingId " + postedData.GosiSettingId + " is already exists !";
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

                    result.msg = _GosiSettingService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _GosiSettingService.SaveChanges();
                        result.scalerVal = postedData.GosiSettingId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.GosiSettings postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _GosiSettingService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _GosiSettingService.SaveChanges();
                    result.scalerVal = postedData.GosiSettingId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _GosiSettingService.Delete(Int32.Parse(id));

            result.msg = _GosiSettingService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
