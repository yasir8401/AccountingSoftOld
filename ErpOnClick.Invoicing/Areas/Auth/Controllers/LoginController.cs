using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.Invoicing.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.Invoicing.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _userService;
        //public string SessionInfo_Name { get; private set; }

        private dynamic expObj;
        public LoginController(ILogger<LoginController> logger, IUserService userService, IBranchService BranchService, ICompanyService CompanyService)
        {
            _userService = userService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _logger = logger;
            expObj = new ExpandoObject();

        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginValidation(Users postedData)
        {
            var status = false;
            var userInfo = _userService.Find(x => x.Email == postedData.Email && x.Password == postedData.Password).FirstOrDefault();
            if (userInfo != null)
            {
                var userClaims = new List<Claim>() {
                    new Claim(ClaimTypes.Name,userInfo.UserId.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,userInfo.UserName),
                    new Claim(ClaimTypes.Email,userInfo.Email),
                    new Claim(ClaimTypes.Role, "")
                };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });

                HttpContext.SignInAsync(userPrincipal);
                status = userPrincipal.Identity.IsAuthenticated;
            }

            return Json(new { status = status });
        }



        public IActionResult Registration()
        {
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.BranchDetail = _BranchService.GetAll();
            return View(expObj);
        }

        [HttpPost]
        public IActionResult RegistrationValidation(Users postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _userService.Find(x => x.Email == postedData.Email).FirstOrDefault();
                if (item == null)
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    result.msg = _userService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _userService.SaveChanges();

                    }
                }

            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}
