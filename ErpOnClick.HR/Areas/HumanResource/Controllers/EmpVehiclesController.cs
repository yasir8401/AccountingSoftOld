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


namespace ErpOnClick.EmpVehicles.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpVehiclesController : Controller
    {
        private readonly ILogger<EmpVehiclesController> _logger;
        private IEmpVehicalService _EmpVehiclesService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpVehiclesController(IUserService UserService,ILogger<EmpVehiclesController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpVehicalService EmpVehiclesService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpVehiclesService = EmpVehiclesService;
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
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.EmpVehiclesList = _EmpVehiclesService.Find(x => x.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]
        public async Task<IActionResult> edit(int empId, int id)
        {

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.EmpVehiclesDetails = _EmpVehiclesService.GetById(id);
            expObj.empDetails = _EmpService.GetById(empId);
            expObj.empId = empId;

            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.EmpVehicles postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _EmpVehiclesService.GetById(postedData.EmpVehicleId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "EmpVehicleId " + postedData.EmpVehicleId + " is already exists !";
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

                    result.msg = _EmpVehiclesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpVehiclesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpVehicles postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _EmpVehiclesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpVehiclesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpVehiclesService.Delete(Int32.Parse(id));

            result.msg = _EmpVehiclesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
