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
    public class CompanyController : Controller
    {
        private readonly ILogger<CompanyController> _logger;
        private ICompanyService _CompanyService;
        private ILookupTypesService _LookupTypesService;

        private dynamic expObj;
        public CompanyController(ILogger<CompanyController> logger, ICompanyService CompanyService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _CompanyService = CompanyService;
            _LookupTypesService = LookupTypesService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View(expObj);
        }

        public IActionResult _list(int CompanyId)
        {
            expObj.CompanyIdList = _CompanyService.GetAll();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {

            expObj.CompanyIdDetail = _CompanyService.GetById(id);
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Company postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var item = _CompanyService.GetById(postedData.CompanyId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Company ID " + postedData.CompanyId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;

                    result.msg = _CompanyService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _CompanyService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Company postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _CompanyService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _CompanyService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            var n = _CompanyService.Find(c => c.CompanyId == id).Count();
            if (n > 0)
            {
                result.isError = true;
                result.msg = "Company " + id + " is being used in Company !";
            }
            else
            {
                _CompanyService.Delete(id);

                result.msg = _CompanyService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

    }
}
