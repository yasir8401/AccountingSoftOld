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
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.Main.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class RoomsController : Controller
    {
        private ILookupsService _lookupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IBuildingsService _BuildingsService;
        private IRoomsService _RoomsService;
        private IUserService _UserService;

        private dynamic expObj;
        public RoomsController(IUserService UserService,IRoomsService RoomsService,IBuildingsService BuildingsService, IBranchService BranchService, ICompanyService CompanyService, ILookupsService lookupsService)
        {
            _RoomsService = RoomsService;
            _UserService = UserService;
            _lookupsService = lookupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _BuildingsService = BuildingsService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            expObj.BuildingsType = _BuildingsService.GetAll().ToList();
            return View(expObj);
        }
        public IActionResult _list(int BuildingId)
        {
            expObj.RoomList = _RoomsService.dbset().Include(c => c.Building).ToList();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.IdDetail = _RoomsService.GetById(id);
            expObj.BuildingDetail = _BuildingsService.GetAll();
            expObj.BranchIdDetail = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            var lookupList = _lookupsService.GetAll();
            expObj.Roomslist = lookupList.Where(x => x.LookupTypeId == LookupTypList.RoomsType_023).ToList();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Rooms postedData)
        {
            DbResult result = new DbResult();
            var EmpId = Convert.ToInt32(User.Identity.Name);
            var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
            postedData.CompanyId = user.CompanyId;
            postedData.BranchId = user.BranchId;
            postedData.CreatedDate = System.DateTime.Now;
            postedData.CreatedBy = 0;
            postedData.PortalId = 0;
            result.msg = _RoomsService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _RoomsService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Rooms postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _RoomsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _RoomsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            _RoomsService.Delete(id);

            result.msg = _RoomsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }
    }
}
