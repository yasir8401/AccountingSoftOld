using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpPreviousExpController : Controller
    {
        private IEmpPreviousExperienceService _EmpPreviousExperienceService;
        private IEmpBankService _EmpBanksService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpPreviousExpController(IEmpPreviousExperienceService EmpPreviousExperienceService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpBankService EmpBanksService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _EmpPreviousExperienceService = EmpPreviousExperienceService;
            _UserService = UserService;
            _EmpBanksService = EmpBanksService;
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
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);
            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.EmpprevexpList = _EmpPreviousExperienceService.Find(x => x.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]
        public async Task<IActionResult> edit(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.collegeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.College_Type_068).ToList();
            expObj.functionaltypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Functional_Types_072).ToList();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();
            expObj.PreviousExperienceDetails = _EmpPreviousExperienceService.GetById(id);
            expObj.empDetails = _EmpService.GetById(empId);
            expObj.empId = empId;


            return View(expObj);
        }



        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.EmpPreviousexperience postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {



                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 0;

                result.msg = _EmpPreviousExperienceService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpPreviousExperienceService.SaveChanges();
                }
                result.isError = (result.msg != "" ? true : false);


            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpPreviousexperience postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _EmpPreviousExperienceService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpPreviousExperienceService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpPreviousExperienceService.Delete(Int32.Parse(id));

            result.msg = _EmpPreviousExperienceService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
    }
}
