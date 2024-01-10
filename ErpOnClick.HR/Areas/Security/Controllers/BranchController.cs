using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.DAL.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class BranchController : Controller
    {
        private readonly ILogger<BranchController> _logger;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;

        private dynamic expObj;
        public BranchController(ILogger<BranchController> logger, IBranchService BranchService, ICompanyService CompanyService)
        {
            _logger = logger;
            _BranchService = BranchService;
            _CompanyService = CompanyService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View(expObj);
        }

        public IActionResult _list(int BranchId)
        {
            expObj.BranchList = _BranchService.dbset().Include(c => c.Company).ToList();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {

            expObj.BranchIdDetail = _BranchService.GetById(id);
            expObj.companyList = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Branch postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var item = _BranchService.GetById(postedData.BranchId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Branch ID " + postedData.BranchId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;

                    result.msg = _BranchService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _BranchService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(Branch postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _BranchService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _BranchService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            //var n = _BranchService.Find(c => c.BranchId == id).Count();
            //if (n > 0)
            //{
            //    result.isError = true;
            //    result.msg = "Branch " + id + " is being used in Branch !";
            //}
            //else
            //{
                _BranchService.Delete(id);

                result.msg = _BranchService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            //}
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
