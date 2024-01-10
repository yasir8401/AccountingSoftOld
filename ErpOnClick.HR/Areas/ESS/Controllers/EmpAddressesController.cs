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
    public class EmpAddressesController : BaseController
    {
        private readonly ILogger<EmpAddressesController> _logger;
        private IEmpAddressService _EmpAddressesService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpAddressesController(IUserService UserService,ILogger<EmpAddressesController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IEmpAddressService EmpAddressesService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _EmpAddressesService = EmpAddressesService;
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
            expObj.EmpAddressesList = _EmpAddressesService.Find(x => x.EmpId == empId).ToList();
            expObj.empId = empId;
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/view/emp/{empId}/{id=0}")]
        public async Task<IActionResult> view(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.countryList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.citiyList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.EmpAddressesDetails = _EmpAddressesService.GetById(id);
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);


            return View(expObj);
        }

        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpAddresses postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                if (postedData.IsPrimary == true)//For Active Address
                {
                    var empAddresses = _EmpAddressesService.Find(x => x.EmpAddressId != postedData.EmpAddressId).ToList();
                    foreach (var addressessEmp in empAddresses)
                    {
                        addressessEmp.IsPrimary = false;
                    }
                    _EmpAddressesService.dbset().UpdateRange(empAddresses);
                }

                result.msg = _EmpAddressesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpAddressesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }
    }
}
