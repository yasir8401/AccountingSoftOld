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
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.HousingAllowance.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class HousingAllowancesController : Controller
    {
        private readonly ILogger<HousingAllowancesController> _logger;
        private IHousingAllowancesService _HousingAllowanceService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public HousingAllowancesController(IUserService UserService,ILogger<HousingAllowancesController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IHousingAllowancesService HousingAllowanceService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _HousingAllowanceService = HousingAllowanceService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.HousingAllowanceList = _HousingAllowanceService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.AllowanceTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();
            expObj.PaymentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.HousingPaymentType_029).ToList();



            expObj.HousingAllowanceDetails = _HousingAllowanceService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.HousingAllowances postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _HousingAllowanceService.GetById(postedData.HousingAllowanceId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "HousingAllowanceId " + postedData.HousingAllowanceId + " is already exists !";
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

                    result.msg = _HousingAllowanceService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _HousingAllowanceService.SaveChanges();
                        result.scalerVal = postedData.HousingAllowanceId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.HousingAllowances postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _HousingAllowanceService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _HousingAllowanceService.SaveChanges();
                    result.scalerVal = postedData.HousingAllowanceId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _HousingAllowanceService.Delete(Int32.Parse(id));

            result.msg = _HousingAllowanceService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
