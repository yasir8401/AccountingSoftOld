using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ErpOnClick.Main.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class TrustiesController : Controller
    {
        private ILookupsService _lookupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IBuildingsService _BuildingsService;
        private ITrustiesService _TrustiesService;
        private dynamic expObj;
        public TrustiesController(ITrustiesService TrustiesService, IBuildingsService BuildingsService, IBranchService BranchService, ICompanyService CompanyService, ILookupsService lookupsService)
        {
            _TrustiesService = TrustiesService;
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
        public IActionResult _list()
        {
            expObj.TrustiesList = _TrustiesService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.TrusteDetail = _TrustiesService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Trusties postedData)
        {
            DbResult result = new DbResult();

            postedData.CreatedDate = System.DateTime.Now;
            postedData.CreatedBy = 0;

            result.msg = _TrustiesService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _TrustiesService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Trusties postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModfiedBy = 1;
                result.msg = _TrustiesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _TrustiesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            _TrustiesService.Delete(id);

            result.msg = _TrustiesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }
    }
}
