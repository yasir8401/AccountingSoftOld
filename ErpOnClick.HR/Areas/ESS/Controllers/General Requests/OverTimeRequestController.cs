
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers.General_Requests
{

    public class OverTimeRequestController : BaseController
    {
        private readonly ILogger<OverTimeRequestController> _logger;
        private IOverTimeRequestService _OverTimeRequestService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IDepartmentService _departmentService;
        private IOverTimeRequestLineService _OverTimeRequestLineService;
        private INavigationService _NavigationService;
        private IEmpsService _empsService;
        private ERPonClickContext _context;
        private ILookupsService _LookupService;
        private IApprovalTaskService _approvalTaskService;
        private IApprovalRouteService _approvalRouteService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        private IEmpAttendancesService _EmpAttendancesService;

        private dynamic expObj;
        public OverTimeRequestController(ILogger<OverTimeRequestController> logger, IEmpsService empsService, INavigationService NavigationService, IOverTimeRequestLineService OverTimeRequestLineService, IDepartmentService departmentService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IOverTimeRequestService OverTimeRequestService, ILookupTypesService LookupTypesService, ERPonClickContext context, ILookupsService LookupService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService, IEmpAttendancesService empAttendancesService)
        {
            _logger = logger;
            _NavigationService = NavigationService;
            _OverTimeRequestService = OverTimeRequestService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _UserService = UserService;
            _departmentService = departmentService;
            _OverTimeRequestLineService = OverTimeRequestLineService;
            _empsService = empsService;
            _context = context;
            _LookupService = LookupService;
            _approvalTaskService = approvalTaskService;
            _approvalRouteService = approvalRouteService;
            _approvalRouteDetailsService = approvalRouteDetailsService;
            _EmpAttendancesService = empAttendancesService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string FromDate, string ToDate)
        {
            var empId = GetEmployeeId();

            var overTimeListQuery = from p in _context.OvertimeRequests.Include(x => x.RequestStatusNavigation)
                               where _context.OvertimeRequestsLines.Any(x => x.EmpId == empId)
                               select p;
            var overTimeList = overTimeListQuery.ToList<OvertimeRequests>();
            if (!String.IsNullOrWhiteSpace(FromDate) && !String.IsNullOrWhiteSpace(ToDate))
            {
                overTimeList = overTimeList.Where(x => x.OvertimeDate.Value.Date >= DateTime.Parse(FromDate).Date && x.OvertimeDate.Value.Date <= DateTime.Parse(ToDate).Date).ToList();
            }
            expObj.OverTimeRequestList = overTimeList;

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.OverTimeRequestDetails = _OverTimeRequestService.GetById(id);
            expObj.empList = _empsService.Find(x => x.EmpId == GetEmployeeId()).ToList();
            expObj.deptList = _departmentService.GetAll();
            expObj.navigationList = _NavigationService.GetAll();
            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();


            expObj.OverTimeRequestLinesList = _OverTimeRequestLineService.Find(x => x.OvertimeRequestId == id).ToList();

            return View(expObj);

        }


        [HttpPost]
        public async Task<ActionResult> save(OverTimeRequestAndLineViewModel postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _OverTimeRequestService.GetById(postedData.OverTimeRequest.OvertimeRequestId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "OvertimeRequestId " + postedData.OverTimeRequest.OvertimeRequestId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.OverTimeRequest.CompanyId = user.CompanyId;
                    postedData.OverTimeRequest.BranchId = user.BranchId;
                    postedData.OverTimeRequest.CreatedDate = System.DateTime.Now;
                    postedData.OverTimeRequest.CreatedBy = 0;

                    result.msg = _OverTimeRequestService.Insert(postedData.OverTimeRequest);
                    if (result.msg == "")
                    {
                        result.msg = _OverTimeRequestService.SaveChanges();
                        if (result.msg == "")
                        {
                            if (postedData.OvertimeRequestsLines != null)
                            {
                                foreach (var itemRoutes in postedData.OvertimeRequestsLines)
                                {
                                    itemRoutes.OvertimeRequestId = postedData.OverTimeRequest.OvertimeRequestId;
                                    itemRoutes.CreatedBy = 0;
                                    itemRoutes.CreatedDate = System.DateTime.Now;
                                    itemRoutes.CompanyId = postedData.OverTimeRequest.CompanyId;
                                    itemRoutes.BranchId = postedData.OverTimeRequest.BranchId;
                                    result.msg = _OverTimeRequestLineService.Insert(itemRoutes);
                                }
                                result.msg = _OverTimeRequestLineService.SaveChanges();
                            }

                        }

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(OverTimeRequestAndLineViewModel postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.OverTimeRequest.ModifiedDate = System.DateTime.Now;
                postedData.OverTimeRequest.ModifiedBy = 1;

                result.msg = _OverTimeRequestService.Update(postedData.OverTimeRequest);
                if (result.msg == "")
                {
                    result.msg = _OverTimeRequestService.SaveChanges();
                    if (result.msg == "")
                    {
                        if (postedData.OvertimeRequestsLines != null)
                        {
                            foreach (var itemRoutes in postedData.OvertimeRequestsLines)
                            {
                                itemRoutes.OvertimeRequestId = postedData.OverTimeRequest.OvertimeRequestId;
                                itemRoutes.ModifiedBy = 1;
                                itemRoutes.CompanyId = postedData.OverTimeRequest.CompanyId;
                                itemRoutes.BranchId = postedData.OverTimeRequest.BranchId;
                                itemRoutes.ModifiedDate = System.DateTime.Now;
                                result.msg = _OverTimeRequestLineService.Update(itemRoutes);
                            }
                            result.msg = _OverTimeRequestLineService.SaveChanges();
                            foreach (var itemRoutes in postedData.OvertimeRequestsLines)
                            {
                                if (itemRoutes.IsDeleted == "true")
                                {
                                    result.msg = _OverTimeRequestLineService.Delete(itemRoutes.LineId);
                                }
                            }
                            result.msg = _OverTimeRequestLineService.SaveChanges();
                        }

                    }
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var overTimeRequestLines = _OverTimeRequestLineService.Find(x => x.OvertimeRequestId == Int32.Parse(id)).ToList();
            _OverTimeRequestLineService.dbset().RemoveRange(overTimeRequestLines);
            result.msg = _OverTimeRequestService.Delete(Int32.Parse(id));
            result.msg = _OverTimeRequestService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Post(string id)
        {
            DbResult result = new DbResult();

            var overTimeId = (id != null ? Int32.Parse(id) : 0);
            var overtime = _OverTimeRequestService.GetById(overTimeId);
            overtime.RequestStatus = "007001";
            result.msg = _OverTimeRequestService.Update(overtime);
            result.msg = _OverTimeRequestService.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "OverTime Request").FirstOrDefault();
            var approvalRoutes = _approvalRouteService.Find(x => x.ApprovalTaskId == approvalTask.ApprovalTaskId).ToList();

            foreach (var route in approvalRoutes)
            {
                var routeDetail = new ApprovalRoutesDetail();


                routeDetail.ApprovalRouteId = route.ApprovalRouteId;
                routeDetail.SeqId = route.SeqId;
                routeDetail.ApprovalTaskId = approvalTask.ApprovalTaskId + "";
                routeDetail.ApproverUserId = route.UserId;
                routeDetail.IsDepartment = route.IsDepartment;
                routeDetail.DepartmentId = route.DepartmentId;
                routeDetail.RequestedBy = GetEmployeeId();
                routeDetail.RecordId = overTimeId + "";
                routeDetail.ApprovalStatus = "007001";
                routeDetail.RecordNotes = null;
                routeDetail.ApproverNotes = null;
                routeDetail.ActionDate = DateTime.Now;
                routeDetail.CreatedDate = DateTime.Now;
                routeDetail.CreatedBy = GetEmployeeId();
                routeDetail.RecordName = "OverTime Request";
                routeDetail.RecordNotes = "OverTime pending for apporval";

                result.msg = _approvalRouteDetailsService.Insert(routeDetail);
            }
            result.msg = _approvalRouteDetailsService.SaveChanges();
            result.scalerVal = overTimeId;
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        public ActionResult GetCurrentAttendance(string requestedDate)
        {
            var date = Convert.ToDateTime(requestedDate);

            var attendance = _EmpAttendancesService.Find(x => x.AttendanceDate == date).FirstOrDefault();

            if (attendance != null)
            {
                return Json(new { timeIn = Convert.ToDateTime(attendance.TimeIn).TimeOfDay, timeOut = Convert.ToDateTime(attendance.TimeOut).TimeOfDay });
            }

            return Json(new { timeIn = "", timeOut = "" });

        }

    }
}
