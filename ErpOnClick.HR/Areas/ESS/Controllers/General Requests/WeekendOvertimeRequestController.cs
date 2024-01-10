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
    public class WeekendOvertimeRequestController : BaseController
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
        private IWeekendOvertimeService _weekendOvertimeService;

        private dynamic expObj;
        public WeekendOvertimeRequestController(ILogger<OverTimeRequestController> logger, IEmpsService empsService, INavigationService NavigationService, IOverTimeRequestLineService OverTimeRequestLineService, IDepartmentService departmentService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IOverTimeRequestService OverTimeRequestService, ILookupTypesService LookupTypesService, ERPonClickContext context, ILookupsService LookupService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService, IEmpAttendancesService empAttendancesService, IWeekendOvertimeService weekendOvertimeService)
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
            _weekendOvertimeService = weekendOvertimeService;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string FromDate, string ToDate)
        {
            var empId = GetEmployeeId();

            var weekendOverTimeListQuery = _weekendOvertimeService.dbset().Include(x => x.ApprovalStatusNavigation).Where(x => x.EmpId == empId);
            var weekendOverTimeList = weekendOverTimeListQuery.ToList<WeekendOvertime>();
            if (!String.IsNullOrWhiteSpace(FromDate) && !String.IsNullOrWhiteSpace(ToDate))
            {
                weekendOverTimeList = weekendOverTimeList.Where(x => x.CreatedDate.Value.Date >= DateTime.Parse(FromDate).Date && x.CreatedDate.Value.Date <= DateTime.Parse(ToDate).Date).ToList();
            }
            expObj.WeekendWeekendOvertimeRequestList = weekendOverTimeList;

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
            expObj.employee = _empsService.Find(x => x.EmpId == GetEmployeeId()).ToList();
            expObj.employeesList = _empsService.Find(x => x.EmpId != GetEmployeeId()).ToList();


            expObj.WeekendOvertimeDetail = _weekendOvertimeService.GetById(id);

            return View(expObj);

        }

        [HttpPost]
        public async Task<ActionResult> saveAsync(WeekendOvertime postedData)
        {
            var empId = GetEmployeeId();
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _weekendOvertimeService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "WeekendOvertimeId " + postedData.RecId + " is already exists !";
                }
                else
                {
                    var user = _UserService.dbset().Where(c => c.UserId == empId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = empId;
                    postedData.PortalId = 0;
                    postedData.EmpId = empId;

                    result.msg = _weekendOvertimeService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _weekendOvertimeService.SaveChanges();
                        result.scalerVal = postedData.RecId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public async Task<ActionResult> updateAsync(WeekendOvertime postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = GetEmployeeId();

                result.msg = _weekendOvertimeService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _weekendOvertimeService.SaveChanges();
                    result.scalerVal = postedData.RecId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Post(string id)
        {
            DbResult result = new DbResult();

            var weekendOvertimeId = (id != null ? Int32.Parse(id) : 0);
            var weekendOvertime = _weekendOvertimeService.GetById(weekendOvertimeId);
            weekendOvertime.ApprovalStatus = "007001";
            result.msg = _weekendOvertimeService.Update(weekendOvertime);
            result.msg = _weekendOvertimeService.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "Weekend Overtime Request").FirstOrDefault();
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
                routeDetail.RequestedBy = weekendOvertime.EmpId;
                routeDetail.RecordId = weekendOvertimeId + "";
                routeDetail.ApprovalStatus = "007001";
                routeDetail.RecordNotes = null;
                routeDetail.ApproverNotes = null;
                routeDetail.ActionDate = DateTime.Now;
                routeDetail.CreatedDate = DateTime.Now;
                routeDetail.CreatedBy = GetEmployeeId();
                routeDetail.RecordName = "Weekend Overtime Request";
                routeDetail.RecordNotes = "Weekend Overtime pending for apporval";

                result.msg = _approvalRouteDetailsService.Insert(routeDetail);
            }
            result.msg = _approvalRouteDetailsService.SaveChanges();
            result.scalerVal = weekendOvertimeId;
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }



    }
}
