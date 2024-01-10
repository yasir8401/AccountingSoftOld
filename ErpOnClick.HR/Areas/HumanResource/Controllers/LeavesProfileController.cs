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
using Microsoft.AspNetCore.Localization;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class LeavesProfileController : Controller
    {
        private readonly ILogger<LeavesProfileController> _logger;
        private IAbsentProfilesService _AbsentProfileService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;
        private ILeavesProfileService _LeavesProfileService;

        private dynamic expObj;
        public LeavesProfileController(IUserService UserService, ILogger<LeavesProfileController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IAbsentProfilesService AbsentProfileService, ILookupsService LookupService, ILookupTypesService LookupTypesService, ILeavesProfileService leavesProfileService)
        {
            _logger = logger;
            _UserService = UserService;
            _AbsentProfileService = AbsentProfileService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _LeavesProfileService = leavesProfileService;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            var leavesProfileDetail = _LeavesProfileService.GetAll().FirstOrDefault();

            expObj.LeavesProfileDetail = leavesProfileDetail;

            return View(expObj);
        }

        [HttpPost]
        public async Task<ActionResult> save(LeavesProfile postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _LeavesProfileService.GetById(postedData.LeavesProfileId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Leaves Profile Id " + postedData.LeavesProfileId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = EmpId;
                    postedData.PortalId = 0;
                    
                    result.msg = _LeavesProfileService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _LeavesProfileService.SaveChanges();
                        result.scalerVal = postedData.LeavesProfileId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public async Task<ActionResult> update(LeavesProfile postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _LeavesProfileService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _LeavesProfileService.SaveChanges();
                    result.scalerVal = postedData.LeavesProfileId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

    }
}
