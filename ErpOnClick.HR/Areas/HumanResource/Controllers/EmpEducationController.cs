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
using ErpOnClick.ErpMain.Models;

namespace ErpOnClick.EmpEducation.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpEducationController : Controller
    {
        private readonly ILogger<EmpEducationController> _logger;
        private IEmpEducationService _EmpEducationService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpEducationController(IUserService UserService,ILogger<EmpEducationController> logger,  IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpEducationService EmpEducationService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpEducationService = EmpEducationService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId=0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.assessmentAssignmentList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Assessment_Assignment_073).ToList();
            expObj.GPATypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.GPA_Type_074).ToList();
            expObj.studyTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Study_Type_075).ToList();
            expObj.countryList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.cityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

            return View(expObj);
        }


        public IActionResult _list(int empId)
        {
            expObj.empId = empId;
            expObj.EmpEducationList = _EmpEducationService.Find(c => c.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]

        public async Task<IActionResult> edit(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.degreeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DegreeType_066).ToList();
            expObj.assessmentAssignmentList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Assessment_Assignment_073).ToList();
            expObj.GPATypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.GPA_Type_074).ToList();
            expObj.studyTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Study_Type_075).ToList();
            expObj.countryList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.cityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();
            var empEducation =  _EmpEducationService.GetById(id);
            EmpEducationInheritied EmpEducation = null;
            if (empEducation != null)
            {
                 EmpEducation = new EmpEducationInheritied()
                {
                    EmpEducationId = empEducation.EmpEducationId,
                    EmpId = empEducation.EmpId,
                    DegreeId = empEducation.DegreeId,
                    DegreeName = empEducation.DegreeName,
                    UniversityName = empEducation.UniversityName,
                    FromDate = empEducation.FromDate,
                    ToDate = empEducation.ToDate,
                    Detail = empEducation.Detail,
                    Attachments = empEducation.Attachments,
                    CompanyId = empEducation.CompanyId,
                    BranchId = empEducation.BranchId,
                    PortalId = empEducation.PortalId,
                    CreatedDate = empEducation.CreatedDate,
                    CreatedBy = empEducation.CreatedBy,
                    ModifiedDate = empEducation.ModifiedDate,
                    ModifiedBy = empEducation.ModifiedBy,
                    AssessmentAssignmentId = empEducation.AssessmentAssignmentId,
                    CityId = empEducation.CityId,
                    CountryId = empEducation.CountryId,
                    College = empEducation.College,
                    CulturalAttache = empEducation.CulturalAttache,
                    GpaTypeCodeId = empEducation.GpaTypeCodeId,
                    GraduateYear = empEducation.GraduateYear,
                    ScientificDegreeDate = empEducation.ScientificDegreeDate,
                    StudyTypeCodeId = empEducation.StudyTypeCodeId

                };
                expObj.EmpEducationDetails = EmpEducation;
            }
            else
            {
                expObj.EmpEducationDetails = new EmpEducationInheritied();
                
            }

            expObj.EmpEducationDetails = _EmpEducationService.GetById(id);


            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);



            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(EmpEducationInheritied postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _EmpEducationService.GetById(postedData.EmpEducationId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "EmpEducationId  " + postedData.EmpEducationId + " is already exists !";
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
                    var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                    if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                    {
                        postedData.Attachments = attachmentfilePath;
                    }

                    result.msg = _EmpEducationService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpEducationService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(EmpEducationInheritied postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                {
                    postedData.Attachments = attachmentfilePath;
                }

                result.msg = _EmpEducationService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpEducationService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpEducationService.Delete(Int32.Parse(id));

            result.msg = _EmpEducationService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
