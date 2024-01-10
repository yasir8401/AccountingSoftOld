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

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    public class EmpDependentsController : BaseController
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


        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]
        public async Task<IActionResult> view(int empId, int id)
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

    }
}
