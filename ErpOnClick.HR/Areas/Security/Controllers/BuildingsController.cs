using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ErpOnClick.Main.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class BuildingsController : Controller
    {
        private ILookupsService _lookupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IBuildingsService _BuildingsService;
        private IUserService _UserService;

        private dynamic expObj;
        public BuildingsController(IUserService UserService,IBuildingsService BuildingsService, IBranchService BranchService, ICompanyService CompanyService, ILookupsService lookupsService)
        {
            _UserService = UserService;
            _lookupsService = lookupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _BuildingsService = BuildingsService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult _list(int BuildingId)
        {
            expObj.BuildingsList = _BuildingsService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {

            var lookupList = _lookupsService.GetAll();
            expObj.Countrylist = lookupList.Where(x => x.LookupTypeId == LookupTypList.Country_004).ToList();
            expObj.CityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.BuildingIdDetail = _BuildingsService.GetById(id);
            expObj.BranchIdDetail = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Buildings postedData)
        {
            DbResult result = new DbResult();
            var EmpId = Convert.ToInt32(User.Identity.Name);
            var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
            postedData.CompanyId = user.CompanyId;
            postedData.BranchId = user.BranchId;
            postedData.CreatedDate = System.DateTime.Now;
            postedData.CreatedBy = 0;
            postedData.PortalId = 0;
            result.msg = _BuildingsService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _BuildingsService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);




            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Buildings postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _BuildingsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _BuildingsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            _BuildingsService.Delete(id);

            result.msg = _BuildingsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }

    }
}
