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

namespace ErpOnClick.EmpDependents.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpDependentsController : Controller
    {
        private readonly ILogger<EmpDependentsController> _logger;
        private IEmpDependentsService _EmpDependentsService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpDependentsController(IUserService UserService,ILogger<EmpDependentsController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpDependentsService EmpDependentsService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpDependentsService = EmpDependentsService;
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
            expObj.EmpDependentsList = _EmpDependentsService.Find(x => x.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]
        public async Task<IActionResult> edit(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.nationalityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Nationality_012).ToList();
            expObj.genderList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Gende_014).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            var empDependent = _EmpDependentsService.GetById(id);
            EmpDependentInheritied EmpDependentsDetails = null;
            if (empDependent!= null)
            {
                EmpDependentsDetails = new EmpDependentInheritied()
                {
                    DependentId = empDependent.DependentId,
                    DependentNameEn = empDependent.DependentNameEn,
                    DependentNameAr = empDependent.DependentNameAr,
                    Dob = empDependent.Dob,
                    GenderId = empDependent.GenderId,
                    RelationTypeId = empDependent.NationalityId,
                    NationalityId = empDependent.NationalityId,
                    IdNo = empDependent.IdNo,
                    IdIssuedFrom = empDependent.IdIssuedFrom,
                    IdIssuedDate = empDependent.IdIssuedDate,
                    IdIssuedDateH = empDependent.IdIssuedDateH,
                    IdEndDate = empDependent.IdEndDate,
                    IdEndDateH = empDependent.IdEndDateH,
                    IdAttachment = empDependent.IdAttachment,
                    PassportNo = empDependent.PassportNo,
                    PassportIssuedFrom = empDependent.PassportIssuedFrom,
                    PassportIssuedDate = empDependent.PassportIssuedDate,
                    PassportIssuedDateH = empDependent.PassportIssuedDateH,
                    PassportExpiryDate = empDependent.PassportExpiryDate,
                    PassportExpiryDateH = empDependent.PassportExpiryDateH,
                    PassportAttachment = empDependent.PassportAttachment,
                    Attachments = empDependent.Attachments,
                    CompanyId = empDependent.CompanyId,
                    BranchId = empDependent.BranchId,
                    PortalId = empDependent.PortalId,
                    CreatedDate = empDependent.CreatedDate,
                    CreatedBy = empDependent.CreatedBy,
                    ModifiedDate = empDependent.ModifiedDate,
                    ModifiedBy = empDependent.ModifiedBy
                };
                expObj.EmpDependentsDetails = EmpDependentsDetails;

            }
            else
            {
                expObj.EmpDependentsDetails = _EmpDependentsService.GetById(id);
            }

          
            expObj.empDetails = _EmpService.GetById(empId);
            expObj.empId = empId;


            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(EmpDependentInheritied postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _EmpDependentsService.GetById(postedData.DependentId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Dependent Id " + postedData.DependentId + " is already exists !";
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
                    var passportfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.PassportFile);
                    if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                    {
                        postedData.IdAttachment = attachmentfilePath;
                    }
                    if (!String.IsNullOrWhiteSpace(passportfilePath))
                    {
                        postedData.PassportAttachment = passportfilePath;
                    }

                    result.msg = _EmpDependentsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpDependentsService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(EmpDependentInheritied postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                var passportfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.PassportFile);
                if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                {
                    postedData.IdAttachment = attachmentfilePath;
                }
                if (!String.IsNullOrWhiteSpace(passportfilePath))
                {
                    postedData.PassportAttachment = passportfilePath;
                }

                result.msg = _EmpDependentsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpDependentsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
             var dependent = _EmpDependentsService.GetById(Int32.Parse(id));
            _EmpDependentsService.Delete(Int32.Parse(id));
            var resultFile = FileHandling.DeleteFile(_HostEnvironment, dependent.IdAttachment);
            var resultFiles = FileHandling.DeleteFile(_HostEnvironment, dependent.PassportAttachment);
            result.msg = _EmpDependentsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
