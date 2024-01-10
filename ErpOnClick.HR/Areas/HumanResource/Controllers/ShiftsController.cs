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
using ErpOnClick.ErpMain.Models;
using ErpOnClick.DAL.Utilities;
using Microsoft.AspNetCore.Hosting;

namespace ErpOnClick.AbsentProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")] 
    [Authorize]
    public class ShiftsController : Controller
    {
        private readonly ILogger<ShiftsController> _logger;
        private IShiftsService _Shiftservice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _EmpService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public ShiftsController(IUserService UserService,ILogger<ShiftsController> logger, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IShiftsService Shiftservice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _Shiftservice = Shiftservice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.ShiftsList = _Shiftservice.GetAll();
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
        
            expObj.ShiftsDetails = _Shiftservice.GetById(id);
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> save(Shifts postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _Shiftservice.GetById(postedData.ShiftId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Shifts Id " + postedData.ShiftId + " is already exists !";
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
                  
                    result.msg = _Shiftservice.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _Shiftservice.SaveChanges();
                        result.scalerVal = postedData.ShiftId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(Shifts postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
            

                result.msg = _Shiftservice.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _Shiftservice.SaveChanges();
                    result.scalerVal = postedData.ShiftId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _Shiftservice.Delete(Int32.Parse(id));

            result.msg = _Shiftservice.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
       

    }
}
