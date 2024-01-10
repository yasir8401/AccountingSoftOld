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

namespace ErpOnClick.AirTicketProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class AirTicketProfilesController : Controller
    {
        private readonly ILogger<AirTicketProfilesController> _logger;
        private IAirTicketProfilesService _AirTicketProfileService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public AirTicketProfilesController(IUserService UserService,ILogger<AirTicketProfilesController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IAirTicketProfilesService AirTicketProfileService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _AirTicketProfileService = AirTicketProfileService;
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
            expObj.AirTicketProfileList = _AirTicketProfileService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.AirTicketProfileDetails = _AirTicketProfileService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.AirTicketProfiles postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _AirTicketProfileService.GetById(postedData.AirTicketProfileId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "AirTicketProfileId " + postedData.AirTicketProfileId + " is already exists !";
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

                    result.msg = _AirTicketProfileService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _AirTicketProfileService.SaveChanges();
                        result.scalerVal = postedData.AirTicketProfileId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.AirTicketProfiles postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _AirTicketProfileService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AirTicketProfileService.SaveChanges();
                    result.scalerVal = postedData.AirTicketProfileId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _AirTicketProfileService.Delete(Int32.Parse(id));

            result.msg = _AirTicketProfileService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
