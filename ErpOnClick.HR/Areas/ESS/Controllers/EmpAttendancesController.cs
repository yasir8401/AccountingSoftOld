using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Areas.ESS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{

    public class EmpAttendancesController : BaseController
    {
        private readonly ILogger<EmpAttendancesController> _logger;
        private IEmpAttendancesService _EmpAttendanceService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _EmpService;
        private IEmpContractsService _empContractService;
        private IEmpBankService _empBankService;
        private IEmpShiftsService _empshiftService;
        private ILeaveService _leaveService;
        private IUserService _UserService;


        private dynamic expObj;
        public EmpAttendancesController(IUserService UserService, ILogger<EmpAttendancesController> logger, ILeaveService leaveService, IEmpContractsService empContractService, IEmpBankService empBankService, IEmpShiftsService empshiftService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IEmpAttendancesService EmpAttendanceService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpAttendanceService = EmpAttendanceService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _empBankService = empBankService;
            _empContractService = empContractService;
            _empshiftService = empshiftService;
            _leaveService = leaveService;

            expObj = new ExpandoObject();
        }
        public IActionResult Index(string attendanceDate)
        {
            var EmpId = GetEmployeeId();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.attendanceDate = (attendanceDate != null ? DateTime.Parse(attendanceDate) : DateTime.Now);

            var attndncedate = (attendanceDate != null ? attendanceDate : DateTime.Now.ToString());


            var empcheck = new List<ErpOnClick.DAL.Models.EmpAttendance>();

            if (!String.IsNullOrEmpty(attndncedate))
            {
                var dateAttendance = DateTime.Parse(attndncedate);
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.AttendanceDate.Value.Date.Month == dateAttendance.Date.Month && x.AttendanceDate.Value.Date.Year == dateAttendance.Date.Year && x.EmpId == EmpId).ToList();
            }

            expObj.employeecheck = empcheck;
            return View(expObj);
        }

        public IActionResult _list(string date)
        {
            var EmpId = GetEmployeeId();
            var empshift = _empshiftService.dbset().Include(c => c.Shift).ToList();
            var empcheck = new List<ErpOnClick.DAL.Models.EmpAttendance>();
            var empcheckVM = new List<EmpAttendanceVM>();
            if (!String.IsNullOrEmpty(date))
            {
                var dateAttendance = DateTime.Parse(date);
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.AttendanceDate.Value.Date.Month == dateAttendance.Date.Month && x.AttendanceDate.Value.Date.Year == dateAttendance.Date.Year && x.EmpId == EmpId).ToList();
            }
            else
            {
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).ToList();
            }
            foreach (var emp in empcheck)
            {
                empcheckVM.Add(new EmpAttendanceVM() { 
                    ActualTimeIn = emp.TimeIn,
                    ActualTimeOut = emp.TimeOut,
                    AttendanceDate = emp.AttendanceDate,
                    BranchId = emp.BranchId,
                    CompanyId = emp.CompanyId,
                    CreatedBy = emp.CreatedBy,
                    CreatedDate = emp.CreatedDate,
                    EmpAttendanceId = emp.EmpAttendanceId,
                    EmpId = emp.EmpId,
                    IsPaidLeave = emp.IsPaidLeave,
                    IsPresent = emp.IsPresent,
                    IsSaved = emp.IsSaved,
                    IsShortLeave = emp.IsShortLeave,
                    IsUnpaidLeave = emp.IsUnpaidLeave,
                    ModifiedBy = emp.ModifiedBy,
                    ModifiedDate = emp.ModifiedDate,
                    Note = emp.Note,
                    PortalId = emp.PortalId

                });
            }

            foreach (var empVM in empcheckVM)
            {
                empVM.PlannedTimeIn = Convert.ToDateTime(empshift.Where(c => c.EmpId == empVM.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault());
                empVM.PlannedTimeOut = Convert.ToDateTime(empshift.Where(c => c.EmpId == empVM.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault());
            }

            expObj.empAttendanceList = empcheckVM;
            return PartialView(expObj);
        }

        [HttpPost]
        public IActionResult GetEmployees(string date)
        {
            DbResult result = new DbResult();

            var leaveRequestAll = _leaveService.dbset().Include(x => x.LeaveStatusNavigation).ToList();
            var empList = _EmpService.GetAll();
            var empshift = _empshiftService.dbset().Include(c => c.Shift).ToList();
            if (empList != null)
            {
                foreach (var emp in empList)
                {
                    var dateAtt = (date != null ? DateTime.Parse(date) : DateTime.Now);
                    var currentEmpLeavesDeatils = leaveRequestAll.Where(x => x.EmpId == emp.EmpId && x.DateFrom.Value.Date <= dateAtt.Date && x.DateTo.Value.Date >= dateAtt.Date && x.LeaveStatusNavigation.LookupNameEn.ToLower() == "approved").FirstOrDefault();
                    var empCheck = _EmpAttendanceService.Find(x => x.EmpId == emp.EmpId && x.AttendanceDate.Value.Date == (date != null ? DateTime.Parse(date) : DateTime.Now)).FirstOrDefault();
                    if (empCheck == null)
                    {

                        var empAttendace = new ErpOnClick.DAL.Models.EmpAttendance()
                        {
                            EmpId = emp.EmpId,
                            AttendanceDate = dateAtt,
                            Note = string.Empty,
                            CreatedBy = 0,
                            CreatedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            IsPresent = false,
                            IsPaidLeave = (currentEmpLeavesDeatils != null ? true : false),
                            IsUnpaidLeave = false,
                            IsShortLeave = false,
                            IsSaved = false,
                            TimeIn = (empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault() != null ? Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault()) : null),
                            TimeOut = (empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault() != null ? Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault()) : null)

                        };
                        result.msg = _EmpAttendanceService.Insert(empAttendace);
                    }
                }
                result.msg = _EmpAttendanceService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        [Route("{area}/{controller}/printattendance/{attendaceDate}")]
        public IActionResult PrintAttendance(string attendaceDate)
        {
            var EmpId = GetEmployeeId();
            var empshift = _empshiftService.dbset().Include(c => c.Shift).ToList();
            var empcheck = new List<ErpOnClick.DAL.Models.EmpAttendance>();
            var empcheckVM = new List<EmpAttendanceVM>();
            if (!String.IsNullOrEmpty(attendaceDate))
            {
                var dateAttendance = DateTime.Parse(attendaceDate);
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.AttendanceDate.Value.Date.Month == dateAttendance.Date.Month && x.AttendanceDate.Value.Date.Year == dateAttendance.Date.Year && x.EmpId == EmpId).ToList();
            }
            else
            {
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.EmpId == EmpId).ToList();
            }
            foreach (var emp in empcheck)
            {
                empcheckVM.Add(new EmpAttendanceVM()
                {
                    ActualTimeIn = emp.TimeIn,
                    ActualTimeOut = emp.TimeOut,
                    AttendanceDate = emp.AttendanceDate,
                    BranchId = emp.BranchId,
                    CompanyId = emp.CompanyId,
                    CreatedBy = emp.CreatedBy,
                    CreatedDate = emp.CreatedDate,
                    EmpAttendanceId = emp.EmpAttendanceId,
                    EmpId = emp.EmpId,
                    IsPaidLeave = emp.IsPaidLeave,
                    IsPresent = emp.IsPresent,
                    IsSaved = emp.IsSaved,
                    IsShortLeave = emp.IsShortLeave,
                    IsUnpaidLeave = emp.IsUnpaidLeave,
                    ModifiedBy = emp.ModifiedBy,
                    ModifiedDate = emp.ModifiedDate,
                    Note = emp.Note,
                    PortalId = emp.PortalId

                });
            }

            foreach (var empVM in empcheckVM)
            {
                empVM.PlannedTimeIn = Convert.ToDateTime(empshift.Where(c => c.EmpId == empVM.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault());
                empVM.PlannedTimeOut = Convert.ToDateTime(empshift.Where(c => c.EmpId == empVM.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault());
            }

            expObj.EmpAttendance = empcheckVM;
            expObj.employee = _EmpService.GetById(EmpId);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return PartialView(expObj);
        }


    }
}
