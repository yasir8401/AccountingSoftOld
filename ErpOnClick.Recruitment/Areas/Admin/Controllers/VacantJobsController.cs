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


namespace ErpOnClick.VacantJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class VacantJobsController : Controller
    {
        private readonly ILogger<VacantJobsController> _logger;
        private IVacantJobsService _VacantJobsService;
        private ILookupsService _LookupService;

        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;

        private dynamic expObj;
        public VacantJobsController(ILogger<VacantJobsController> logger, IBranchService BranchService, ICompanyService CompanyService,  IVacantJobsService VacantJobsService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _VacantJobsService = VacantJobsService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            return View(expObj);
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.VacantJobLists = _VacantJobsService.GetAll().Where(c =>
                    (c.JobDepartmentId == JobDepartmentId || JobDepartmentId==null)
            ).ToList();
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
           
            var lookupList = _LookupService.GetAll();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            expObj.statusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobStatus_002).ToList();
            expObj.typeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.RecruitmentJobTypes_003).ToList();
            expObj.countryList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.cityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();


            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.JobIdDetail = _VacantJobsService.GetById(id);
            if (expObj.JobIdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.JobIdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.VacantJobs postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

             
                var item = _VacantJobsService.GetById(postedData.JobId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "JobId " + postedData.JobId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _VacantJobsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _VacantJobsService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.VacantJobs postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _VacantJobsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _VacantJobsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _VacantJobsService.Delete(Int32.Parse(id));

            result.msg = _VacantJobsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
