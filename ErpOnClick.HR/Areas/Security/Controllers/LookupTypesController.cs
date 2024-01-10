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
    public class LookupTypesController : Controller
    {
        private readonly ILogger<LookupTypesController> _logger;
        private ILookupTypesService _LookupTypesService;
        private ILookupsService _LookupsService;

        private dynamic expObj;
        public LookupTypesController(ILogger<LookupTypesController> logger, ILookupTypesService LookupTypesService, ILookupsService LookupsService)
        {
            _logger = logger;
            _LookupTypesService = LookupTypesService;
            _LookupsService = LookupsService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.LookupTypeList = _LookupTypesService.GetAll();
            return View(expObj);
        }

        public IActionResult _list()
        {
            expObj.LookupTypeList = _LookupTypesService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(string id)
        {
            expObj.LookupTypeDetail = _LookupTypesService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(LookupTypes postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var item = _LookupTypesService.GetById(postedData.LookupTypeId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Code type " + postedData.LookupTypeId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;

                    _LookupTypesService.Insert(postedData);
                    result.msg = _LookupTypesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _LookupTypesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(LookupTypes postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                _LookupTypesService.Update(postedData);

                result.msg = _LookupTypesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _LookupTypesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var n = _LookupsService.Find(c => c.LookupTypeId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "Code type " + id + " is being used in lookups !";
            }
            else
            {
                _LookupTypesService.Delete(id);

                result.msg = _LookupTypesService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

    }
}
