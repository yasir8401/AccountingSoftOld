using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    public class EmpEducationController : BaseController
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
        public EmpEducationController(IUserService UserService, ILogger<EmpEducationController> logger, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpEducationService EmpEducationService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
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
            expObj.EmpEducationList = _EmpEducationService.Find(c => c.EmpId == empId).ToList();
            return PartialView(expObj);
        }

        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]

        public async Task<IActionResult> view(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.degreeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DegreeType_066).ToList();


            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();
            var empEducation = _EmpEducationService.GetById(id);
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
                    ModifiedBy = empEducation.ModifiedBy

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
    }
}
