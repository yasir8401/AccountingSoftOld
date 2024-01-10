using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ErpOnClick.Recruitment.Controllers.Ajax
{
    [Authorize]
    public class AjaxController : Controller
    {
        private IBranchService _BranchService;
        public AjaxController(IBranchService BranchService)
        {
            _BranchService = BranchService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult BranchCascading(int id)
        {

            var test = _BranchService.Find(c => c.CompanyId == id).Select(x => new { x.BranchId, x.BranchNameEn }).ToList();

            return Json(new { result = test });

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
