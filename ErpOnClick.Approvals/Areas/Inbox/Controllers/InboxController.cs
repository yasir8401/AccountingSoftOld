﻿using ErpOnClick.Approvals.Models;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;

namespace ErpOnClick.Inbox.Areas.Inbox.Controllers
{
    [Area("Inbox")]
    [Authorize]
    public class InboxController : Controller
    {
        private readonly ILogger<InboxController> _logger;

        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        private IDivisionsService _DivisionService;
        private IEmpsService _EmpService;
        private ILeaveService _leaveService;
        private IUserService _userService;
        private ILookupsService _lookupsService;
        private IExceptionsClassCapacityService _ExceptionsClassCapacityService;
        private IExceptionsCoursesService _ExceptionsCoursesService;
        private IStdLettersService _StdLettersService;
        private IClassesService _ClassesService;

        private dynamic expObj;

        public InboxController(IClassesService ClassesService,IStdLettersService StdLettersService, IExceptionsCoursesService ExceptionsCoursesService, IExceptionsClassCapacityService ExceptionsClassCapacityService, ILogger<InboxController> logger, ILookupsService lookupsService, IUserService userService, ILeaveService leaveService, IApprovalRouteDetailsService approvalRouteDetailsService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, IDivisionsService DivisionService, ICompanyService CompanyService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _ClassesService = ClassesService;
            _StdLettersService = StdLettersService;
            _ExceptionsClassCapacityService = ExceptionsClassCapacityService;
            _ExceptionsCoursesService = ExceptionsCoursesService;
            _logger = logger;
            _EmpService = EmpService;
            _approvalRouteDetailsService = approvalRouteDetailsService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;
            _leaveService = leaveService;
            _userService = userService;
            _lookupsService = lookupsService;


            expObj = new ExpandoObject();
        }


        public IActionResult Index(string status)
        {
            expObj.status = status;
            return View(expObj);
        }

        public IActionResult _list(string status)
        {
            List<ApprovalRoutesDetail> approvalRouteDetail = new List<ApprovalRoutesDetail>();
            var userId = (HttpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);
            var allRequests = _approvalRouteDetailsService.GetAll();

            if (status == "007001")//Pending
            {
                var approvalRouteListForThisUserPending = allRequests.Where(x => x.ApproverUserId == userId && x.ApprovalStatus == status).ToList();

                foreach (var request in approvalRouteListForThisUserPending)
                {
                    if(request.SeqId == 1)
                    {
                        approvalRouteDetail.Add(request);
                    }
                    else
                    {
                        var requestSequenceAboveCurrentRequest = request.SeqId-1; //Getting about request sequence

                        var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == request.RecordId && x.RecordName == request.RecordName && x.SeqId == requestSequenceAboveCurrentRequest).Select(x=>x.ApprovalStatus).FirstOrDefault();
                        if(aboveSequenceUserStatus == "007002")
                        {
                            approvalRouteDetail.Add(request);
                        }
                    }
                }
              
            }
            else //Approved and rejected
            {
                approvalRouteDetail = _approvalRouteDetailsService.Find(x => x.ApproverUserId == userId && x.ApprovalStatus == status).ToList();

            }

            var approvalTaskId = approvalRouteDetail.Select(x => x.ApprovalTaskId).ToList();
            var approvalRoutes = approvalRouteDetail.GroupBy(x => x.ApprovalTaskId).ToList();
            var routeList = new List<ApprovalRouteDetailViewModel>();
            var allUsers = _userService.GetAll();
            var allLookUps = _lookupsService.GetAll();


            foreach (var item in approvalRouteDetail)
            {
                var route = new ApprovalRouteDetailViewModel();
                var requestDetail = new RequestDetails();

                route.RequestedBy = _EmpService.Find(x => x.EmpId == item.RequestedBy).Select(x => (x.FirstNameEn + " " + x.FatherNameEn).ToString()).FirstOrDefault();
                route.Status = _LookupService.Find(x => x.Code == item.ApprovalStatus).Select(x => x.LookupNameEn).FirstOrDefault();
                route.Route = item;
                route.ApprovarUser = _userService.GetById(item.ApproverUserId).DisplayNameEn;

                requestDetail.RequestStatus = route.Status;
                requestDetail.Date = item.CreatedDate.ToString();

                route.RequestDetail = requestDetail;

                route.ApproverUsersList = allRequests.Where(x => x.RecordId == item.RecordId && x.RecordName == item.RecordName)
                    .Select
                    (x => new ApprovalUser
                    {
                        UserName = allUsers.Where(y => y.UserId == x.ApproverUserId).Select(z => z.DisplayNameEn).FirstOrDefault(),
                        Status = allRequests.Where(a => a.ApproverUserId == x.ApproverUserId).Select(b => allLookUps.Where(c => c.Code == x.ApprovalStatus).Select(d => d.LookupNameEn).FirstOrDefault()).FirstOrDefault()
                    }).ToList();

                routeList.Add(route);
            }
            expObj.ApprovalRouteDetailViewModelList = routeList;

            return PartialView(expObj);
        }


        public IActionResult edit(int divisionId, int id)
        {
            expObj.EmpList = _EmpService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.divisionList = _DivisionService.Find(c => c.DivisionId == divisionId).ToList();



            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);

            return View(expObj);
        }

        public IActionResult ChangeStatus(string status, string APPROVER_NOTES, int id)
        {
            var userId = (HttpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);
            var allRequests = _approvalRouteDetailsService.GetAll();
            var route = _approvalRouteDetailsService.GetById(id);

            if(route.RecordName !=null)
            {
                if (route.RecordName == "Skip Prerequisite")
                {
                    route.ApprovalStatus = status;
                    route.ApproverNotes = APPROVER_NOTES;

                    _approvalRouteDetailsService.Update(route);
                    _approvalRouteDetailsService.SaveChanges();

                    var Expcourse = _ExceptionsCoursesService.GetById(Int32.Parse(route.RecordId));

                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == route.RecordId && x.RecordName == route.RecordName).ToList();
                    var totalCountOfRequestUser = aboveSequenceUserStatus.Count();
                    int countCheck = 0;


                    foreach (var request in aboveSequenceUserStatus)
                    {
                        if (request.ApprovalStatus == "007002")
                        {
                            countCheck++;
                        }
                        if (totalCountOfRequestUser == countCheck)
                        {
                            Expcourse.ApprovalStatusId = "007002";
                        }
                        if (request.ApprovalStatus == "007003")
                        {
                            Expcourse.ApprovalStatusId = "007003";
                        }
                    }

                    _ExceptionsCoursesService.Update(Expcourse);
                    _ExceptionsCoursesService.SaveChanges();
                }
                else if (route.RecordName == "Expand Class Capacity")
                {
                    route.ApprovalStatus = status;
                    route.ApproverNotes = APPROVER_NOTES;

                    _approvalRouteDetailsService.Update(route);
                    _approvalRouteDetailsService.SaveChanges();

                    var ClsCapacity = _ExceptionsClassCapacityService.GetById(Int32.Parse(route.RecordId));

                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == route.RecordId && x.RecordName == route.RecordName).ToList();
                    var totalCountOfRequestUser = aboveSequenceUserStatus.Count();
                    int countCheck = 0;


                    foreach (var request in aboveSequenceUserStatus)
                    {
                        if (request.ApprovalStatus == "007002")
                        {
                            countCheck++;
                        }
                        if (totalCountOfRequestUser == countCheck)
                        {
                            ClsCapacity.ApprovalStatusId = "007002";
                        }
                        if (request.ApprovalStatus == "007003")
                        {
                            ClsCapacity.ApprovalStatusId = "007003";
                        }
                    }

                    _ExceptionsClassCapacityService.Update(ClsCapacity);
                    _ExceptionsClassCapacityService.SaveChanges();
                }
                else if (route.RecordName == "Grade Request")
                {
                    route.ApprovalStatus = status;
                    route.ApproverNotes = APPROVER_NOTES;

                    _approvalRouteDetailsService.Update(route);
                    _approvalRouteDetailsService.SaveChanges();

                    var Cls = _ClassesService.GetById(Int32.Parse(route.RecordId));
                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == route.RecordId && x.RecordName == route.RecordName).ToList();
                    var totalCountOfRequestUser = aboveSequenceUserStatus.Count();
                    int countCheck = 0;


                    foreach (var request in aboveSequenceUserStatus)
                    {
                        if (request.ApprovalStatus == "007002")
                        {
                            countCheck++;
                        }
                        if (totalCountOfRequestUser == countCheck)
                        {
                            Cls.GradeStatusId = "007002";
                        }
                        if (request.ApprovalStatus == "007003")
                        {
                            Cls.GradeStatusId = "007003";
                        }
                    }
                    _ClassesService.Update(Cls);
                    _ClassesService.SaveChanges();
                }
                else if (route.RecordName == "Warning")
                {
                    route.ApprovalStatus = status;
                    route.ApproverNotes = APPROVER_NOTES;

                    _approvalRouteDetailsService.Update(route);
                    _approvalRouteDetailsService.SaveChanges();

                    var Warning = _StdLettersService.GetById(Int32.Parse(route.RecordId));
                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == route.RecordId && x.RecordName == route.RecordName).ToList();
                    var totalCountOfRequestUser = aboveSequenceUserStatus.Count();
                    int countCheck = 0;


                    foreach (var request in aboveSequenceUserStatus)
                    {
                        if (request.ApprovalStatus == "007002")
                        {
                            countCheck++;
                        }
                        if (totalCountOfRequestUser == countCheck)
                        {
                            Warning.ApprovalStatusId = "007002";
                        }
                        if (request.ApprovalStatus == "007003")
                        {
                            Warning.ApprovalStatusId = "007003";
                        }
                    }
                    _StdLettersService.Update(Warning);
                    _StdLettersService.SaveChanges();
                }
                else
                {
                    route.ApprovalStatus = status;
                    route.ApproverNotes = APPROVER_NOTES;

                    _approvalRouteDetailsService.Update(route);
                    _approvalRouteDetailsService.SaveChanges();

                    var leave = _leaveService.GetById(Int32.Parse(route.RecordId));
                    var aboveSequenceUserStatus = allRequests.Where(x => x.RecordId == route.RecordId && x.RecordName == route.RecordName).ToList();
                    var totalCountOfRequestUser = aboveSequenceUserStatus.Count();
                    int countCheck = 0;


                    foreach (var request in aboveSequenceUserStatus)
                    {
                        if (request.ApprovalStatus == "007002")
                        {
                            countCheck++;
                        }
                        if (totalCountOfRequestUser == countCheck)
                        {
                            leave.LeaveStatus = "007002";
                        }
                        if (request.ApprovalStatus == "007003")
                        {
                            leave.LeaveStatus = "007003";
                        }
                    }

                    _leaveService.Update(leave);
                    _leaveService.SaveChanges();
                }
            }

            return RedirectToAction("Index");
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
