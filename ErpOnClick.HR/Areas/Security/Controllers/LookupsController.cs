using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.DAL.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class LookupsController : Controller
    {
        private readonly ILogger<LookupsController> _logger;
        private ILookupsService _LookupsService;
        private ILookupTypesService _LookupTypesService;

        private dynamic expObj;
        public LookupsController(ILogger<LookupsController> logger, ILookupsService LookupsService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _LookupsService = LookupsService;
            _LookupTypesService = LookupTypesService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.LookupTypeList = _LookupTypesService.Find(c => c.Locked == false).ToList();
            expObj.CodeList = _LookupsService.GetAll();
            return View(expObj);
        }

        public IActionResult _list(string LookupTypeId)
        {
            expObj.LookupTypeList = _LookupTypesService.GetAll();
            expObj.CodeList = _LookupsService.Find(c => c.LookupTypeId == LookupTypeId || string.IsNullOrEmpty(LookupTypeId)).ToList();
            return PartialView(expObj);
        }


        public IActionResult edit(string id)
        {
            expObj.LookupTypeList = _LookupTypesService.Find(c=>c.Locked==false).ToList();

            expObj.CodeDetail = _LookupsService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Lookups postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.Code = string.Concat(postedData.LookupTypeId, postedData.LookupId);

                var item = _LookupsService.GetById(postedData.Code);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Code " + postedData.Code + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;

                    result.msg = _LookupsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _LookupsService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Lookups postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.Code = string.Concat(postedData.LookupTypeId, postedData.LookupId);

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _LookupsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _LookupsService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var n = _LookupsService.Find(c => c.LookupId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "Code type " + id + " is being used in lookups !";
            }
            else
            {
                _LookupsService.Delete(id);

                result.msg = _LookupsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

    }
}
