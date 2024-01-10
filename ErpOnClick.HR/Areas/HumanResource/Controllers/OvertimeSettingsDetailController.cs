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


namespace ErpOnClick.OvertimeSettingsDetail.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class OvertimeSettingsDetailController : Controller
    {
        private readonly ILogger<OvertimeSettingsDetailController> _logger;
        private IOvertimeSettingsDetailsService _OvertimeSettingsDetailService;
        private IOvertimeSettingsService _OvertimesettingsService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public OvertimeSettingsDetailController(IUserService UserService,ILogger<OvertimeSettingsDetailController> logger,  IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IOvertimeSettingsDetailsService OvertimeSettingsDetailService, IOvertimeSettingsService OvertimesettingsService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _OvertimeSettingsDetailService = OvertimeSettingsDetailService;
            _OvertimesettingsService = OvertimesettingsService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/Overtimesettings/{OvertimesettingsID}")]
        public IActionResult Index(int OvertimesettingsID=0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.OvertimesettingsID = OvertimesettingsID;
            expObj.OvertimesettingsDetails = _OvertimesettingsService.GetById(OvertimesettingsID);

            return View(expObj);
        }


        public IActionResult _list(int OvertimesettingsID)
        {
            expObj.OvertimesettingsID = OvertimesettingsID;
            expObj.OvertimeSettingsDetailList = _OvertimeSettingsDetailService.Find(c => c.OvertimeSettingId == OvertimesettingsID).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/Overtimesettings/{OvertimesettingsID}/{id=0}")]

        public async Task<IActionResult> edit(int OvertimesettingsID, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.allowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.OvertimesettingsList = _OvertimesettingsService.Find(c => c.OvertimeSettingId == OvertimesettingsID).ToList();

            expObj.OvertimeSettingsDetailDetails = _OvertimeSettingsDetailService.GetById(id);
            expObj.OvertimesettingsID = OvertimesettingsID;
            expObj.OvertimesettingsDetails = _OvertimesettingsService.GetById(OvertimesettingsID);
        



            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.OvertimeSettingsDetail postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _OvertimeSettingsDetailService.GetById(postedData.OvertimeSettingDetailId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "OvertimeSettingsDetailId  " + postedData.OvertimeSettingDetailId + " is already exists !";
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
                

                    result.msg = _OvertimeSettingsDetailService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _OvertimeSettingsDetailService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(ErpOnClick.DAL.Models.OvertimeSettingsDetail postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
              

                result.msg = _OvertimeSettingsDetailService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _OvertimeSettingsDetailService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _OvertimeSettingsDetailService.Delete(Int32.Parse(id));

            result.msg = _OvertimeSettingsDetailService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
