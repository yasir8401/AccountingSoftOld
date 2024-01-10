using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.Recruitment.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.Recruitment.Areas.Admin.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IJobPortalUserService _JobPortalUserService;
        //public string SessionInfo_Name { get; private set; }

        private dynamic expObj;
        public LoginController(ILogger<LoginController> logger, IJobPortalUserService JobPortalUserService, IBranchService BranchService, ICompanyService CompanyService)
        {
            _JobPortalUserService = JobPortalUserService;
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
        public IActionResult LoginValidation(JobPortalUsers postedData)
        {
            var status = false;
            var JobPortalUserInfo = _JobPortalUserService.Find(x => x.Email == postedData.Email && x.Password == postedData.Password).FirstOrDefault();
            if (JobPortalUserInfo != null)
            {
                var JobPortalUserClaims = new List<Claim>() {
                    new Claim(ClaimTypes.Name,JobPortalUserInfo.JobPortalUserId.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,JobPortalUserInfo.UserName),
                    new Claim(ClaimTypes.Email,JobPortalUserInfo.Email),
                    new Claim(ClaimTypes.Role, "")  
                };

                var JobPortalUserIdentity = new ClaimsIdentity(JobPortalUserClaims, "JobPortalUser Identity");
                var JobPortalUserPrincipal = new ClaimsPrincipal(new[] { JobPortalUserIdentity });

                HttpContext.SignInAsync(JobPortalUserPrincipal);
                status = JobPortalUserPrincipal.Identity.IsAuthenticated;
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
        public IActionResult RegistrationValidation(JobPortalUsers postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _JobPortalUserService.Find(x => x.Email == postedData.Email).FirstOrDefault();
                if (item == null)
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    result.msg = _JobPortalUserService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _JobPortalUserService.SaveChanges();

                    }
                }

            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });

        }
        public IActionResult ChangePassword()
        {
            try
            {
                var userId = Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value.ToString());
                expObj.CompanyDetail = _CompanyService.GetAll();
                expObj.BranchDetail = _BranchService.GetAll();
                expObj.userDetails = _JobPortalUserService.GetById(userId);
            }
            catch (Exception ex)
            {
            }
            return View(expObj);
        }

        [HttpPost]
        public IActionResult ChangePasswordValidation(JobPortalUsers postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                if (postedData != null)
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    result.msg = _JobPortalUserService.Update(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _JobPortalUserService.SaveChanges();

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

            return RedirectToAction("Index","Home", new { area = "" });
        }
    }
}
