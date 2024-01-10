using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.DAL.Interfaces;
using System.Dynamic;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using ErpOnClick.DAL.AppStart;

namespace ErpOnClick.ErpMain.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _userService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        private IEmpsService _empsService;
        private ERPonClickContext _context;

        //public string SessionInfo_Name { get; private set; }

        private dynamic expObj;
        public HomeController(ILogger<HomeController> logger, IUserService userService, IApprovalRouteDetailsService approvalRouteDetailsService, IBranchService BranchService, ICompanyService CompanyService, IEmpsService empsService, ERPonClickContext eRPonClickContext)
        {

            _approvalRouteDetailsService = approvalRouteDetailsService;
            _userService = userService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _logger = logger;
            _empsService = empsService;
            _context = eRPonClickContext;
            expObj = new ExpandoObject();


        }

        public IActionResult Index()
        {
            if (!User.IsInRole("Staff"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "essdashboard", new { area = "ESS" });
            }


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

        public IActionResult _notification()
        {
            List<ApprovalRoutesDetail> approvalRouteDetail = new List<ApprovalRoutesDetail>();

            var userId = (HttpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);
            var allRequests = _approvalRouteDetailsService.GetAll();

            var approvalRouteListForThisUserPending = allRequests.Where(x => x.ApproverUserId == userId && x.ApprovalStatus == "007001").ToList();

            foreach (var request in approvalRouteListForThisUserPending)
            {
                if (request.SeqId == 1)
                {
                    approvalRouteDetail.Add(request);
                }
                else
                {
                    var requestSequenceAboveCurrentRequest = request.SeqId - 1; //Getting about request sequence

                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == request.RecordId && x.RecordName == request.RecordName && x.SeqId == requestSequenceAboveCurrentRequest).Select(x => x.ApprovalStatus).FirstOrDefault();
                    if (aboveSequenceUserStatus == "007002")
                    {
                        approvalRouteDetail.Add(request);
                    }
                }
            }

            expObj.myApprovals = approvalRouteDetail.OrderByDescending(c => c.CreatedDate).Take(5);
            expObj.count = approvalRouteDetail.Count();

            List<DAL.Models.Emp> allEmployees = _empsService.GetAll().ToList();
            DAL.Models.Emp employeeProfileUpdate = new DAL.Models.Emp();
            DAL.Models.Emp employeeIDExpired = new DAL.Models.Emp();
            List<DAL.Models.Emp> employeesWithIDExpired = new List<DAL.Models.Emp>();

            if (allEmployees != null && allEmployees.Count > 0)
            {
                employeeProfileUpdate = (from em in _context.Emp
                                         join add in _context.EmpAddresses on em.EmpId equals add.EmpId into EmpAddGroup
                                         from EA in EmpAddGroup.DefaultIfEmpty()
                                         join ba in _context.EmpBanks on em.EmpId equals ba.EmpId into EmpBankGroup
                                         from EB in EmpBankGroup.DefaultIfEmpty()
                                         join edu in _context.EmpEducation on em.EmpId equals edu.EmpId into EmpEduGroup
                                         from EE in EmpEduGroup.DefaultIfEmpty()
                                         where ((em.CreatedDate < DateTime.Now.AddMonths(-1) && (em.ModifiedDate == null)) || (em.CreatedDate < DateTime.Now.AddMonths(-1) && (em.ModifiedDate != null) && em.ModifiedDate < DateTime.Now.AddMonths(-1)))
                                         && em.EmpId == GetEmployeeId()
                                         //&& EA.ModifiedDate < DateTime.Now.AddMonths(-1) && EA.CreatedDate < DateTime.Now.AddMonths(-1)
                                         //&& EB.ModifiedDate < DateTime.Now.AddMonths(-1) && EB.CreatedDate < DateTime.Now.AddMonths(-1)
                                         //&& EE.ModifiedDate < DateTime.Now.AddMonths(-1) && EE.CreatedDate < DateTime.Now.AddMonths(-1)
                                         select em).FirstOrDefault();

                employeeIDExpired = (from em in _context.Emp
                                     where ((em.IdExpiryDate > DateTime.Now.AddMonths(-1) && em.IdExpiryDate < DateTime.Now.AddMonths(1)) || (em.IdExpiryDate == null))
                                     && em.EmpId == GetEmployeeId()
                                     select em).FirstOrDefault();

                employeesWithIDExpired = (from em in _context.Emp
                                          where ((em.IdExpiryDate > DateTime.Now.AddMonths(-1) && em.IdExpiryDate < DateTime.Now.AddMonths(1)) || (em.IdExpiryDate == null))
                                          select em).ToList();
            }

            expObj.EmployeeRrofileUpdate = employeeProfileUpdate;

            if (employeeProfileUpdate != null)
            {
                expObj.count = expObj.count + 1;
            }
            

            expObj.EmployeeIDExpired = employeeIDExpired;

            if (employeeIDExpired != null)
            {
                expObj.count = expObj.count + 1;
            }

            expObj.EmployeesWithIDExpired = employeesWithIDExpired;
            if (employeesWithIDExpired != null)
            {
                expObj.count = expObj.count + employeesWithIDExpired.Count();
            }

           
            return Json(expObj);
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }

        public int GetEmployeeId()
        {

            var claimsPrincipal = new ClaimsPrincipal(User.Identity);
            string empId = claimsPrincipal.Claims.Where(c => c.Type == "EmployeeId")
                           .Select(c => c.Value).SingleOrDefault();

            return empId != null ? Convert.ToInt32(empId) : 0;

        }
    }
}
