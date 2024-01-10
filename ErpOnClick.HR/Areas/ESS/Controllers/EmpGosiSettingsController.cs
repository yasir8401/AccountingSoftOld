using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    public class EmpGosiSettingsController : BaseController
    {
        private readonly ILogger<EmpGosiSettingsController> _logger;
        private IEmpsService _EmpService;
        private IEmpGosiSettingsService _EmpGosiSettingsService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private dynamic expObj;
        public EmpGosiSettingsController(IUserService UserService, ILogger<EmpGosiSettingsController> logger, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpGosiSettingsService EmpGosiSettingsService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _EmpGosiSettingsService = EmpGosiSettingsService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            var lookupList = _LookupService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.EmpGosiSettingsDetails = _EmpGosiSettingsService.Find(x => x.EmpId == empId).SingleOrDefault();
            expObj.empDetails = _EmpService.GetById(empId);

            expObj.empId = empId;


            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.EmpGosiSettings postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _EmpGosiSettingsService.GetById(postedData.GosiSettingsId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "EmpGosiSettingsId " + postedData.GosiSettingsId + " is already exists !";
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

                    result.msg = _EmpGosiSettingsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpGosiSettingsService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpGosiSettings postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.PortalId = 0;
                postedData.ModifiedBy = 1;


                result.msg = _EmpGosiSettingsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpGosiSettingsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

    }
}
