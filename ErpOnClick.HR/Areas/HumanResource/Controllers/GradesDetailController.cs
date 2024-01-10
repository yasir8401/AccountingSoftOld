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
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.GradesDetail.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class GradesDetailController : Controller
    {
        private readonly ILogger<GradesDetailController> _logger;
        private IGradesDetailService _GradesDetailService;
        private IGradesService _GradeService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;

        private dynamic expObj;
        public GradesDetailController(ILogger<GradesDetailController> logger,  IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IGradesDetailService GradesDetailService, IGradesService GradeService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _GradesDetailService = GradesDetailService;
            _GradeService = GradeService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/grade/{gradeID}")]
        public IActionResult Index(int gradeID=0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.gradeID = gradeID;
            expObj.gradeDetails = _GradeService.GetById(gradeID);

            return View(expObj);
        }


        public IActionResult _list(int gradeID)
        {
            expObj.gradeID = gradeID;
            var gradeDetailL = _GradesDetailService.dbset().Include(x => x.Grade);
            expObj.GradesDetailList = gradeDetailL.Where(x => x.GradeId == gradeID).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/grade/{gradeID}/{id=0}")]

        public async Task<IActionResult> edit(int gradeID, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.allowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.gradeList = _GradeService.Find(c => c.GradeId == gradeID).ToList();

            expObj.GradesDetailDetails = _GradesDetailService.GetById(id);
            expObj.gradeID = gradeID;
            expObj.gradeDetails = _GradeService.GetById(gradeID);



            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.GradesDetail postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _GradesDetailService.GetById(postedData.GradeDetailId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "GradesDetailId  " + postedData.GradeDetailId + " is already exists !";
                }
                else
                {
                    var grade = _GradeService.GetById(postedData.GradeId);

                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    postedData.IsEnable = true;
                    postedData.CompanyId = grade.CompanyId;
                    postedData.BranchId = grade.BranchId;

                    result.msg = _GradesDetailService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _GradesDetailService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(ErpOnClick.DAL.Models.GradesDetail postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
              

                result.msg = _GradesDetailService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _GradesDetailService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _GradesDetailService.Delete(Int32.Parse(id));

            result.msg = _GradesDetailService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
