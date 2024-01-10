using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ErpOnClick.Authorization.Models;
using ErpOnClick.DAL.AppStart;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.Authorization.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _userService;
        private IUserRolesService _userRoleService;
        private IRoleService _roleService;

       

        private dynamic expObj;
        public LoginController(ILogger<LoginController> logger, IRoleService roleService, IUserRolesService userRoleService, IUserService userService, IBranchService BranchService, ICompanyService CompanyService)
        {
            _roleService = roleService;
            _userRoleService = userRoleService;
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
            string status = "";
           
            var userInfo = _userService.dbset().Include(x => x.UserRoles).Where(x => x.Email == postedData.Email && x.Password == postedData.Password).FirstOrDefault();
            if (userInfo != null)
            {
                var roleId = userInfo.UserRoles.Select(x => x.RoleId).FirstOrDefault();
                var userRolesName = _roleService.Find(x => x.RoleId == roleId && x.RoleNameEn ==UserRolesStatic.SuperAdmin).Select(x=>x.RoleNameEn).FirstOrDefault();

                if (!String.IsNullOrWhiteSpace(userRolesName))
                {
                    var userClaims = new List<Claim>() {
                    new Claim(ClaimTypes.Name,userInfo.UserId.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,userInfo.UserName),
                    new Claim(ClaimTypes.Email,userInfo.Email),
                    new Claim(ClaimTypes.Role, UserRolesStatic.SuperAdmin)
                     };

                    var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });

                    HttpContext.SignInAsync(userPrincipal);
                    var result =  userPrincipal.Identity.IsAuthenticated;
                    if(result)
                    {
                        status = "Success";
                    }
                }
                else
                {
                    status = "NotAuthorised";
                }
                
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
