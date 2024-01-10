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


namespace ErpOnClick.OverTimeSetting.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class OverTimeSettingsController : Controller
    {
        private readonly ILogger<OverTimeSettingsController> _logger;
        private IOvertimeSettingsService _OverTimeSettingService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public OverTimeSettingsController(IUserService UserService,ILogger<OverTimeSettingsController> logger,  IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IOvertimeSettingsService OverTimeSettingService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _OverTimeSettingService = OverTimeSettingService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();

            return View(expObj);
        }

        public IActionResult _list()
        {
            expObj.OverTimeSettingList = _OverTimeSettingService.GetAll();
        

            return PartialView(expObj);
        }



        public async Task<IActionResult> edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.contractStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.CONTRACT_STATUS_027).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.AllowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();
            expObj.OverTimeSettingDetails = _OverTimeSettingService.GetById(id);
       

            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.OvertimeSettings postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _OverTimeSettingService.GetById(postedData.OvertimeSettingId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "OvertimeSettingId " + postedData.OvertimeSettingId + " is already exists !";
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

                    result.msg = _OverTimeSettingService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _OverTimeSettingService.SaveChanges();
                        result.scalerVal = postedData.OvertimeSettingId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.OvertimeSettings postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _OverTimeSettingService.Update(postedData);
                if (result.msg == "")
                {
                    result.scalerVal = postedData.OvertimeSettingId;
                    result.msg = _OverTimeSettingService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _OverTimeSettingService.Delete(Int32.Parse(id));

            result.msg = _OverTimeSettingService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
