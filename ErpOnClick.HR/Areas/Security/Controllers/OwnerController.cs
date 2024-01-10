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
    public class OwnerController : Controller
    {
        private ILookupsService _lookupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IBuildingsService _BuildingsService;
        private IOwnerService _OwnerService;
        private dynamic expObj;
        public OwnerController(IOwnerService OwnerService,IBuildingsService BuildingsService, IBranchService BranchService, ICompanyService CompanyService, ILookupsService lookupsService)
        {
            _OwnerService = OwnerService;
            _lookupsService = lookupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _BuildingsService = BuildingsService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View(expObj);
        }
        public IActionResult _list()
        {
            expObj.OwnerList = _OwnerService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.ownerDetail = _OwnerService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Owner postedData)
        {
            DbResult result = new DbResult();

            postedData.CreatedDate = System.DateTime.Now;
            postedData.CreatedBy = 0;
          
            result.msg = _OwnerService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _OwnerService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Owner postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _OwnerService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _OwnerService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            _OwnerService.Delete(id);

            result.msg = _OwnerService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }
    }
}
