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
    public class EmpExperienceController : Controller
    {
        private IEmpExperienceService _EmpExperienceService;
        private IEmpBankService _EmpBanksService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpExperienceController(IEmpExperienceService EmpExperienceService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpBankService EmpBanksService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _EmpExperienceService = EmpExperienceService;
            _UserService = UserService;
            _EmpBanksService = EmpBanksService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }
        
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult _list()
        {
            expObj.EmpexprnceList = _EmpExperienceService.GetAll();
            return PartialView(expObj);
        }


        
        public async Task<IActionResult> edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.collegeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.College_Type_068).ToList();
            expObj.contractList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Contract_Type_069).ToList();
            expObj.academicrankList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Academic_Rank_070).ToList();
            expObj.functionalstatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Functional_Status_071).ToList();
            expObj.functionaltypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Functional_Types_072).ToList();
            expObj.empList = _EmpService.GetAll();
            expObj.EmpExperienceDetails = _EmpExperienceService.GetById(id);
            return View(expObj);
        }

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.EmpExperience postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 0;
                result.msg = _EmpExperienceService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpExperienceService.SaveChanges();
                }
                result.isError = (result.msg != "" ? true : false);


            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpExperience postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _EmpExperienceService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpExperienceService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpExperienceService.Delete(Int32.Parse(id));

            result.msg = _EmpExperienceService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
    }
}
