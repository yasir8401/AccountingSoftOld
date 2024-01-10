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
using Microsoft.EntityFrameworkCore;
using ErpOnClick.ErpMain.ViewModel;
using ErpOnClick.ErpMain.ViewModel.HumanResource;

namespace ErpOnClick.EmpAttendance.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpAttendancesController : Controller
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
        public EmpAttendancesController(IUserService UserService,ILogger<EmpAttendancesController> logger, ILeaveService leaveService ,IEmpContractsService empContractService, IEmpBankService empBankService, IEmpShiftsService empshiftService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IEmpAttendancesService EmpAttendanceService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
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
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.attendanceDate = (attendanceDate != null ? DateTime.Parse(attendanceDate) : DateTime.Now);

            var attndncedate = (attendanceDate != null ? attendanceDate : DateTime.Now.ToString());


            var empcheck = new List<ErpOnClick.DAL.Models.EmpAttendance>();

            if (!String.IsNullOrEmpty(attndncedate))
            {
                var dateAttendance = DateTime.Parse(attndncedate);
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.AttendanceDate.Value.Date == dateAttendance.Date).ToList();
            }
            
            expObj.employeecheck = empcheck;
            return View(expObj);
        }

        public IActionResult _list(string date)
        {
            var empshift = _empshiftService.dbset().Include(c => c.Shift).ToList();
            var empcheck = new List<ErpOnClick.DAL.Models.EmpAttendance>();
            if (!String.IsNullOrEmpty(date))
            {
                var dateAttendance = DateTime.Parse(date);
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).Where(x => x.AttendanceDate.Value.Date == dateAttendance.Date).ToList();
            }
            else
            {
                empcheck = _EmpAttendanceService.dbset().Include(x => x.Emp).ToList();
            }
            foreach (var emp in empcheck)
            {
                emp.TimeIn = Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault());
                emp.TimeOut = Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault());
            }
            expObj.empAttendanceList = empcheck;
            return PartialView(expObj);
        }
        [HttpPost]
        public IActionResult GetEmployees(string date)
        {
            DbResult result = new DbResult();

            var leaveRequestAll = _leaveService.dbset().Include(x=>x.LeaveStatusNavigation).ToList();
            var empList = _EmpService.GetAll();
            var empshift = _empshiftService.dbset().Include(c => c.Shift).ToList();
            if (empList != null)
            {
                foreach (var emp in empList)
                {
                    var dateAtt = (date != null ? DateTime.Parse(date) : DateTime.Now);
                    var currentEmpLeavesDeatils = leaveRequestAll.Where(x => x.EmpId == emp.EmpId && x.DateFrom.Value.Date <= dateAtt.Date && x.DateTo.Value.Date >= dateAtt.Date && x.LeaveStatusNavigation.LookupNameEn.ToLower() =="approved").FirstOrDefault();
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
                            IsPaidLeave = (currentEmpLeavesDeatils!=null ? true:false),
                            IsUnpaidLeave = false,
                            IsShortLeave = false,
                            IsSaved = false,
                            TimeIn = (empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault()!=null ?  Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.FromTime).FirstOrDefault()):null),
                            TimeOut = (empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault()!=null ?Convert.ToDateTime(empshift.Where(c => c.EmpId == emp.EmpId).Select(c => c.Shift.ToTime).FirstOrDefault()):null)

                        };
                        result.msg = _EmpAttendanceService.Insert(empAttendace);
                    }
                }
                result.msg = _EmpAttendanceService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }


        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.EmpAttendanceDetails = _EmpAttendanceService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(IList<ErpOnClick.DAL.Models.EmpAttendance> postedData)
        {
            DbResult result = new DbResult();
            var monthcheck = 0;
            if (postedData != null)
            {
                var attendanceMonth = postedData.FirstOrDefault().AttendanceDate.Value.Month;
                var currentMonth = System.DateTime.Now.Month;
                if(attendanceMonth == currentMonth)
                {
                    foreach (var item in postedData)
                    {

                        if (item != null)
                        {
                            //if (item.TimeIn == null)
                            //{
                            //    result.msg = _EmpAttendanceService.Delete(item.EmpAttendanceId);
                            //    result.msg = _EmpAttendanceService.SaveChanges();
                            //}
                            //else
                            //{

                            var EmpId = Convert.ToInt32(User.Identity.Name);
                            var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                            item.CompanyId = user.CompanyId;
                            item.BranchId = user.BranchId;
                            item.ModifiedDate = DateTime.Now;
                            item.ModifiedBy = 1;
                            item.IsSaved = true;

                            result.msg = _EmpAttendanceService.Update(item);
                            result.msg = _EmpAttendanceService.SaveChanges();
                            //}
                        }
                    }
                }
                else
                {
                    monthcheck = 1;
                }
                

            }

            return Json(new { result = result, monthcheck= monthcheck }) ;
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.EmpAttendance postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _EmpAttendanceService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _EmpAttendanceService.SaveChanges();
                    result.scalerVal = postedData.EmpAttendanceId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _EmpAttendanceService.Delete(Int32.Parse(id));

            result.msg = _EmpAttendanceService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }


        public IActionResult EmpAttendanceReport()
        {
            return View();
        }
        public IActionResult _ListEmpAttendanceReport(string date, int id)
        {
            var allEmps = _EmpService.GetAll();
            var allAttendances = _EmpAttendanceService.GetAll();
            var allContracts = _empContractService.dbset().Include(x => x.Department).Include(x => x.PayGroup).ToList();
            var allshifts = _empshiftService.dbset().Include(x => x.Shift).ToList();
            var allBanks = _empBankService.GetAll();
            var lookups = _LookupService.GetAll();

            var empAttendanceReportViewModel = new List<EmpAttendanceReportViewModel>();
            var dateYear = Int32.Parse(date.Split('-')[0]);
            var dateMonth = Int32.Parse(date.Split('-')[1]);

            var dateM = new DateTime(dateYear, dateMonth, 1);
            expObj.date = dateM;

            foreach (var emp in allEmps)
            {
                EmpAttendanceReportViewModel obj = new EmpAttendanceReportViewModel();
                var attendanceOfCurrentEmpThisMonth = allAttendances.Where(x => x.EmpId == emp.EmpId && x.AttendanceDate.Value.Year == dateM.Year && x.CreatedDate.Value.Month == dateM.Month).ToList();
                var currentEmpContract = allContracts.Where(x => x.EmpId == emp.EmpId).FirstOrDefault();
                var currentEmpShift = allshifts.Where(x => x.EmpId == emp.EmpId).FirstOrDefault();
                var currenEmpBank = allBanks.Where(x => x.EmpId == emp.EmpId).FirstOrDefault();
                int totalAttendanceDays = 0;

                obj.EmpId = emp.EmpId;
                obj.EmpCode = emp.EmpCode;
                obj.EmpName = emp.FirstNameEn + " " + emp.FatherNameEn;
                obj.EmpCNIC = "215564564";
                obj.NTN = "12153";
                obj.DOB = emp.Dob;
                obj.JoiningDate = DateTime.Now;
                obj.LeavingDate = DateTime.Now;
                obj.JoinerLeaver = "Retainer";
                obj.OfficeLocation = "Saidpur";
                obj.Department = (currentEmpContract != null && currentEmpContract.Department != null ? currentEmpContract.Department.DepartmentNameEn : "Null");
                obj.Shift = (currentEmpShift != null && currentEmpShift.Shift is not null ? currentEmpShift.Shift.ShiftNameEn : "Null");
                obj.Designation = "Director";
                obj.EmpType = "Probation";
                obj.WageGroup = (currentEmpContract != null && currentEmpContract.PayGroup is not null ? currentEmpContract.PayGroup.PayGroupNameEn : "Null");
                obj.BeneficiaryName = "";
                obj.CustomerRef = "";
                obj.BankAccountNo = (currenEmpBank != null ? currenEmpBank.BankAccountNo : "Null");
                obj.BankCode = (currenEmpBank != null ? currenEmpBank.BankIban : "Null");
                if (currenEmpBank != null)
                {
                    obj.BankName = lookups.Where(x => x.Code == currenEmpBank.BankId).Select(x => x.LookupNameEn).FirstOrDefault();
                }
                else
                {
                    obj.BankName = "Null";
                }

                obj.BankBranch = "";
                obj.Currency = "";
                var absentPresent = new List<string>();
                for (int i = 1; i <= DateTime.DaysInMonth(dateM.Year, dateM.Month); i++)
                {
                    DateTime dt = new DateTime(dateM.Year, dateM.Month, i);

                    var absPrsentCheck = allAttendances.Where(x => x.EmpId == emp.EmpId && x.AttendanceDate.Value.Date == dt.Date).Select(x => x.IsPresent).FirstOrDefault();

                    if (absPrsentCheck != null)
                    {
                        string absPrsent = (absPrsentCheck == true ? "P" : "X");
                        absentPresent.Add(absPrsent);
                        totalAttendanceDays++;
                    }
                    else
                    {
                        string absPresent = "Missing";
                        absentPresent.Add(absPresent);
                    }


                }
                obj.ListMonthAttendancePresentAbsent = absentPresent;
                obj.Tardies = 1;
                obj.ShortLeaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsShortLeave == true).Count();
                obj.Absents = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPresent == false).Count();
                obj.PaidLeaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPaidLeave == true).Count();
                obj.UnpaidLeaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsUnpaidLeave == true).Count();
                obj.Presents = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPresent == true).Count();
                obj.TotalDays = totalAttendanceDays;
                obj.DeductedDays = attendanceOfCurrentEmpThisMonth.Where(x => x.IsUnpaidLeave == true).Count();
                obj.SalaryMonth = dateM;

                empAttendanceReportViewModel.Add(obj);
            }

            expObj.empAttendanceReportViewModel = empAttendanceReportViewModel;

            return PartialView(expObj);
        }
    }
}
