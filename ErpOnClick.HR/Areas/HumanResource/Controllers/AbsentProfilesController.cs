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

namespace ErpOnClick.AbsentProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")] 
    [Authorize]
    public class AbsentProfilesController : Controller
    {
        private readonly ILogger<AbsentProfilesController> _logger;
        private IAbsentProfilesService _AbsentProfileService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public AbsentProfilesController(IUserService UserService,ILogger<AbsentProfilesController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IAbsentProfilesService AbsentProfileService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _AbsentProfileService = AbsentProfileService;
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
            expObj.AbsentProfileList = _AbsentProfileService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.AbsentProfileDetails = _AbsentProfileService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.AbsentProfiles postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _AbsentProfileService.GetById(postedData.AbsentProfileId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "AbsentProfileId " + postedData.AbsentProfileId + " is already exists !";
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

                    result.msg = _AbsentProfileService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _AbsentProfileService.SaveChanges();
                        result.scalerVal = postedData.AbsentProfileId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.AbsentProfiles postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _AbsentProfileService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AbsentProfileService.SaveChanges();
                    result.scalerVal = postedData.AbsentProfileId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _AbsentProfileService.Delete(Int32.Parse(id));

            result.msg = _AbsentProfileService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });

        }
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnurl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnurl);
        }

    }
}
