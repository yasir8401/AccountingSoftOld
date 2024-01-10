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
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.EmpShifts.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpShiftsController : Controller
    {
        private readonly ILogger<EmpShiftsController> _logger;
        private IEmpShiftsService _EmpShiftsService;
        private IShiftsService _shiftsService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;

        private dynamic expObj;
        public EmpShiftsController(ILogger<EmpShiftsController> logger, IShiftsService shiftsService, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpShiftsService EmpShiftsService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _EmpShiftsService = EmpShiftsService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _shiftsService = shiftsService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);
            expObj.ShiftLists = _shiftsService.GetAll();

            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.ShiftLists = _shiftsService.GetAll();
            expObj.EmpShiftsList = _EmpShiftsService.dbset().Include(x => x.Shift).Where(x => x.EmpId == empId).ToList();

            return PartialView(expObj);
        }

    

     [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.EmpShifts postedData)
        {
            DbResult result = new DbResult();
            int ?empId = 1;
            if (postedData != null)
            {
                empId = postedData.EmpId;
                var item = _EmpShiftsService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "RecId " + postedData.RecId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    

                    result.msg = _EmpShiftsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpShiftsService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Redirect("/HumanResource/EmpShifts/emp/" + empId);
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpShifts postedData)
        {
            DbResult result = new DbResult();

            int? empId = 1;
            if (postedData != null)
            {
                empId = postedData.EmpId;
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _EmpShiftsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpShiftsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Redirect("/HumanResource/EmpShifts/emp/" + empId);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpShiftsService.Delete(Int32.Parse(id));

            result.msg = _EmpShiftsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
        [HttpPost]
        public ActionResult GetShifts(string id)
        {
            DbResult result = new DbResult();

            result.scalerVal = _shiftsService.GetAll();
            return Json(new { result = result });
        }
    }
}
