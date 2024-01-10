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


namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    public class EmpMedicalsController : BaseController
    {
        private readonly ILogger<EmpMedicalsController> _logger;
        private IEmpMedicalService _EmpMedicalsService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpMedicalsController(IUserService UserService,ILogger<EmpMedicalsController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpMedicalService EmpMedicalsService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _EmpMedicalsService = EmpMedicalsService;
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
            expObj.EmpMedicalsList = _EmpMedicalsService.Find(x => x.EmpId == empId).ToList();
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]
        public async Task<IActionResult> view(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.medicalCompanyList = lookupList.Where(x => x.LookupTypeId == LookupTypList.MedicalCompany_017).ToList();
            expObj.medicalClassList = lookupList.Where(x => x.LookupTypeId == LookupTypList.MedicalClass_018).ToList();
            expObj.bloodGroupList = lookupList.Where(x => x.LookupTypeId == LookupTypList.BloodGroup_019).ToList();
            expObj.SpecialList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Special_Needs_067).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.EmpMedicalsDetails = _EmpMedicalsService.GetById(id);
            expObj.empDetails = _EmpService.GetById(empId);

            expObj.empId = empId;


            return View(expObj);
        }

    }
}
