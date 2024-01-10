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
using ErpOnClick.ErpMain.Models;
using ErpOnClick.DAL.Utilities;
using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography.X509Certificates;
using ErpOnClick.ErpMain.ViewModel;
using ErpOnClick.ErpMain.ViewModel.HumanResource;

namespace ErpOnClick.AbsentProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class PayRunMController : Controller
    {
        private readonly ILogger<PayRunMController> _logger;
        private IPayRunMService _PayRunMervice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _EmpService;
        private IPayRunDService _payRunDService;
        public static IWebHostEnvironment _HostEnvironment;
        private IEmpBankService _empBankService;
        private IEmpContractsService _empContractService;
        private IEmpContractsPackageService _empContractsPackageService;
        private IPaySlipSerivce _paySlipSerivce;
        private IPerformanceBaseSalaryService _performanceBaseSalaryService;
        private ISalaryPayablesPerMonthService _salaryPayablesPerMonthService;
        private IEmpAttendancesService _EmpAttendanceService;
        private IEmpShiftsService _empShiftsService;

        private dynamic expObj;
        public PayRunMController(ILogger<PayRunMController> logger, IEmpShiftsService empShiftsService, IEmpAttendancesService EmpAttendanceService, ISalaryPayablesPerMonthService salaryPayablesPerMonthService, IPerformanceBaseSalaryService performanceBaseSalaryService, IPaySlipSerivce paySlipSerivce, IEmpContractsPackageService empContractsPackageService, IEmpContractsService empContractService, IEmpBankService empBankService, IPayRunDService payRunDService, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IPayRunMService PayRunMervice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _EmpAttendanceService = EmpAttendanceService;
            _performanceBaseSalaryService = performanceBaseSalaryService;
            _salaryPayablesPerMonthService = salaryPayablesPerMonthService;
            _PayRunMervice = PayRunMervice;
            _payRunDService = payRunDService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _HostEnvironment = HostEnvironment;
            _empBankService = empBankService;
            _empContractService = empContractService;
            _empContractsPackageService = empContractsPackageService;
            _paySlipSerivce = paySlipSerivce;
            _empShiftsService = empShiftsService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult _list()
        {

            expObj.PayRunMList = _PayRunMervice.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.GetAll();


            expObj.PayRunMDetails = _PayRunMervice.GetById(id);



            return View(expObj);
        }
        public IActionResult _listPayRunD(string date, int id)
        {
            var payRunViewModel = new List<PayRunViewModel>();
            var allContracts = _empContractService.dbset().Include(x => x.Department).Include(x => x.PayGroup).ToList();
            var allBanks = _empBankService.GetAll();
            var allShifts = _empShiftsService.dbset().Include(x => x.Shift).ToList();
            var allAttendances = _EmpAttendanceService.GetAll();

            var dateYear = Int32.Parse(date.Split('-')[0]);
            var dateMonth = Int32.Parse(date.Split('-')[1]);

            var dateM = new DateTime(dateYear, dateMonth, 1);
            var payRunDList = _payRunDService.dbset().Include(x => x.Emp).Where(x => x.SalaryDate.Value.Month == dateMonth && x.SalaryDate.Value.Year == dateYear).ToList();


            foreach (var item in payRunDList)
            {

                var currentEmpContract = allContracts.Where(x => x.EmpId == item.EmpId).FirstOrDefault();
                var currentEmpShift = allShifts.Where(x => x.EmpId == item.EmpId).FirstOrDefault();
                var currenEmpBank = allBanks.Where(x => x.EmpId == item.EmpId).FirstOrDefault();
                var attendanceOfCurrentEmpThisMonth = allAttendances.Where(x => x.EmpId == item.EmpId && x.AttendanceDate.Value.Year == dateM.Year && x.CreatedDate.Value.Month == dateM.Month).ToList();

                var empDetails = new EmpAttendanceReportViewModel();
                var payRunViewmodelObject = new PayRunViewModel();
                empDetails.EmpId = item.EmpId;
                empDetails.EmpCode = item.Emp.EmpCode;
                empDetails.EmpName = item.Emp.FirstNameEn;
                empDetails.EmpCNIC = item.Emp.EmpCnic;
                empDetails.NTN = item.Emp.EmpNtn;
                empDetails.DOB = item.Emp.Dob;
                empDetails.JoiningDate = DateTime.Now;
                empDetails.LeavingDate = DateTime.Now;
                empDetails.JoinerLeaver = "Retainer";
                empDetails.OfficeLocation = "Saidpur";
                empDetails.Department = (currentEmpContract != null && currentEmpContract.Department != null ? currentEmpContract.Department.DepartmentNameEn : "Null");
                empDetails.Shift = (currentEmpShift != null && currentEmpShift.Shift is not null ? currentEmpShift.Shift.ShiftNameEn : "Null");
                empDetails.Designation = "Director";
                empDetails.EmpType = "Probation";
                empDetails.WageGroup = (currentEmpContract != null && currentEmpContract.PayGroup is not null ? currentEmpContract.PayGroup.PayGroupNameEn : "Null");
                empDetails.BeneficiaryName = "";
                empDetails.CustomerRef = "";
                empDetails.BankAccountNo = (currenEmpBank != null ? currenEmpBank.BankAccountNo : "Null");
                empDetails.BankCode = (currenEmpBank != null ? currenEmpBank.BankIban : "Null");


                empDetails.Tardies = (int)item.Tardies;
                empDetails.ShortLeaves = (int)item.Shortleaves;
                empDetails.Absents = (int)item.Absents;
                empDetails.PaidLeaves = (int)item.PaidLeaves;
                empDetails.UnpaidLeaves = (int)item.UnpaidLeaves;
                empDetails.Presents = (int)item.Presents;
                empDetails.TotalDays = (int)item.TotalDays;
                empDetails.DeductedDays = (int)item.DeductedDays;
                empDetails.SalaryMonth = item.SalaryDate.Value;

                payRunViewmodelObject.empDetails = empDetails;
                payRunViewmodelObject.payRund = item;
                payRunViewModel.Add(payRunViewmodelObject);


            }



            expObj.payRunViewModel = payRunViewModel;

            return PartialView(expObj);
        }

        [HttpPost]
        public IActionResult CalculatePayRoll(string date, int payRunMId)
        {
            DbResult result = new DbResult();

            var lookupList = _LookupService.GetAll();
            var allAllowances = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();
            var dateYear = Int32.Parse(date.Split('-')[0]);
            var dateMonth = Int32.Parse(date.Split('-')[1]);
            var dateM = new DateTime(dateYear, dateMonth, 1);
            var allContracts = _empContractService.GetAll();
            var allContractsPackage = _empContractsPackageService.GetAll();
            var allCommisionsThisMonth = _performanceBaseSalaryService.Find(x => x.Date.Value.Year == dateM.Year && x.Date.Value.Month == dateM.Month).ToList();

            var allDeductionsThisMonth = _salaryPayablesPerMonthService.dbset().Include(x => x.Emp).Where(x => x.SalaryDate.Value.Date.Month == dateM.Date.Month && x.SalaryDate.Value.Date.Year == dateM.Date.Year).ToList();
            var allAttendaces = _EmpAttendanceService.GetAll();
            var allPayRunD = _payRunDService.GetAll();
            var empId = _EmpService.GetAll().FirstOrDefault().EmpId;

            int thisMonthDaysCount = DateTime.DaysInMonth(dateYear, dateMonth);
            var attendancesThisMonth = _EmpAttendanceService.Find(x => x.AttendanceDate.Value.Year == dateYear && x.AttendanceDate.Value.Month == dateMonth).ToList();
            var isSavedCount = attendancesThisMonth.Where(x => x.IsSaved == true && x.EmpId == empId).Count();
            var notMarkAttendancesThisMonth = attendancesThisMonth.Where(x => x.IsSaved == false && x.EmpId == empId).Select(x => x.AttendanceDate).ToList();

            if (isSavedCount != thisMonthDaysCount)
            {
                result.msg = "AttendanceFill";
                result.isError = (result.msg != "" ? true : false);
                return Json(new { result = result, notMarkAttendancesThisMonth = notMarkAttendancesThisMonth });
            }




            List<PayrunD> payRundList = new List<PayrunD>();
            var payRunM = new PayrunM();
            payRunM.CreatedDate = DateTime.Now;
            payRunM.CreatedBy = 0;
            payRunM.YearId = dateYear;
            payRunM.MonthId = dateMonth;

            result.msg = _PayRunMervice.Insert(payRunM);
            result.msg = _payRunDService.SaveChanges();


            var allEmps = _EmpService.GetAll();
            foreach (var emp in allEmps)
            {


                var attendanceOfCurrentEmpThisMonth = allAttendaces.Where(x => x.EmpId == emp.EmpId && x.AttendanceDate.Value.Year == dateM.Year && x.CreatedDate.Value.Month == dateM.Month).ToList();
                var payRunD = new PayrunD();
                payRunD.EmpId = emp.EmpId;
                payRunD.EmpName = emp.FirstNameEn;
                payRunD.BankAccount = _empBankService.Find(x => x.EmpId == emp.EmpId).Select(x => x.BankAccountNo).FirstOrDefault();
                payRunD.PayrunId = payRunM.PayrunId;
                payRunD.CreatedBy = 0;
                payRunD.CreatedDate = dateM;
                var empContractId = allContracts.Where(x => x.EmpId == emp.EmpId && x.ContractStatus == "027002").Select(x => x.EmpContractId).FirstOrDefault();


                payRunD.SalaryMonth = dateM.Month;
                payRunD.SalaryDate = dateM;
                payRunD.SalaryYear = dateM.Year;
                payRunD.BasicSalary = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "001").Select(x => x.Amount).FirstOrDefault();
                payRunD.HousingAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "002").Select(x => x.Amount).FirstOrDefault();
                payRunD.TransportAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "003").Select(x => x.Amount).FirstOrDefault();
                payRunD.FoodAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "004").Select(x => x.Amount).FirstOrDefault();
                payRunD.OtherAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "005").Select(x => x.Amount).FirstOrDefault();
                payRunD.LeavePayAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "006").Select(x => x.Amount).FirstOrDefault();
                payRunD.IndemnityAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "007").Select(x => x.Amount).FirstOrDefault();
                payRunD.MedicalAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "008").Select(x => x.Amount).FirstOrDefault();
                payRunD.IncrementAllowance = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "009").Select(x => x.Amount).FirstOrDefault();
                payRunD.EobiEmployerContribution = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "010").Select(x => x.Amount).FirstOrDefault();
                payRunD.PessiEmployerContribution = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "011").Select(x => x.Amount).FirstOrDefault();
                payRunD.GroupInsuranceEmployerContribution = allContractsPackage.Where(x => x.EmpContractId == empContractId && x.AllowanceTypeId == "012").Select(x => x.Amount).FirstOrDefault();
                payRunD.TotalBasicSalary = allContractsPackage.Where(x => x.EmpContractId == empContractId).Sum(x => x.Amount);

                //Emp Commisions
                payRunD.ReferenceCommision = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.ReferenceBasedCommission).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.ReferenceBasedCommission).FirstOrDefault() : 0;
                payRunD.DemoCommission = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.DemoCommission).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.DemoCommission).FirstOrDefault() : 0;
                payRunD.SaleCommision = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.SaleCommision).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.SaleCommision).FirstOrDefault() : 0;
                payRunD._500Commision = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x._500Commission).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x._500Commission).FirstOrDefault() : 0;
                payRunD.ZeroPaid = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.ZeroPaid).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.ZeroPaid).FirstOrDefault() : 0;
                payRunD.GiftAmount = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.GiftAmount).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.GiftAmount).FirstOrDefault() : 0;
                payRunD.RecurringCommision = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.RecurringAmount).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.RecurringAmount).FirstOrDefault() : 0;
                payRunD.MonthlyBonus = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.MonthlyBonus).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.MonthlyBonus).FirstOrDefault() : 0;
                payRunD.EarnedSalary = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.EarnedSalary).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.EarnedSalary).FirstOrDefault() : 0;
                payRunD.OvertimeAmount = allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.OvertimeTotalMoney).FirstOrDefault() != null ? allCommisionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.OvertimeTotalMoney).FirstOrDefault() : 0;

                //Emp attendance Summary
                payRunD.Tardies = 1;
                payRunD.Shortleaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsShortLeave == true).Count();
                payRunD.Absents = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPresent == false).Count();
                payRunD.PaidLeaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPaidLeave == true).Count();
                payRunD.UnpaidLeaves = attendanceOfCurrentEmpThisMonth.Where(x => x.IsUnpaidLeave == true).Count();
                payRunD.Presents = attendanceOfCurrentEmpThisMonth.Where(x => x.IsPresent == true).Count();
                payRunD.TotalDays = payRunD.Absents + payRunD.Presents;
                payRunD.DeductedDays = attendanceOfCurrentEmpThisMonth.Where(x => x.IsUnpaidLeave == true).Count();


                //Salary Payables :
                payRunD.LoanDeduction = allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.LoadDeductionThisMonth).FirstOrDefault() != null ? allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.LoadDeductionThisMonth).FirstOrDefault() : 0;
                payRunD.GrossSalary = payRunD.TotalBasicSalary + payRunD.EarnedSalary;
                payRunD.OtherDeductions = allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.OtherDeduction).FirstOrDefault() != null ? allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.OtherDeduction).FirstOrDefault() : 0;
                payRunD.AbscentFine = allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.AbsentFine).FirstOrDefault() != null ? allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.AbsentFine).FirstOrDefault() : 0;
                payRunD.UnpaidDays = payRunD.UnpaidLeaves;
                payRunD.SalaryPerDayCalculation = payRunD.TotalBasicSalary;
                payRunD.PerDay = payRunD.SalaryPerDayCalculation / DateTime.DaysInMonth(dateM.Year, dateM.Month);
                payRunD.SalaryDedeuction = payRunD.PerDay * payRunD.UnpaidDays;
                payRunD.TotalDeduction = payRunD.SalaryDedeuction + payRunD.AbscentFine + payRunD.OtherDeductions + payRunD.LoanDeduction;
                payRunD.Additions = allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.Additions).FirstOrDefault() != null ? allDeductionsThisMonth.Where(x => x.EmpId == emp.EmpId).Select(x => x.Additions).FirstOrDefault() : 0;
                payRunD.NetSalary = (payRunD.GrossSalary - payRunD.TotalDeduction) + payRunD.Additions;



                payRunD.ThresholdSalary = (allContracts.Where(x => x.EmpId == emp.EmpId).Select(x => x.ThreshHoldSalary).FirstOrDefault() != null ? (allContracts.Where(x => x.EmpId == emp.EmpId).Select(x => x.ThreshHoldSalary).FirstOrDefault()) : 0);
                payRunD.NetSalaryPaBeforeTax = payRunD.NetSalary - payRunD.ThresholdSalary;
                payRunD.PreviouslyEarnedSalaryCommulative = allPayRunD.Where(x => x.EmpId == emp.EmpId).Sum(x => x.FinalPaymentForThisMonth);

                var remainingMonthsForCurrentYearFinancial = 6 - dateM.Month;
                if (remainingMonthsForCurrentYearFinancial == 0)
                {
                    remainingMonthsForCurrentYearFinancial = 12;
                }
                else if (remainingMonthsForCurrentYearFinancial < 0)
                {
                    remainingMonthsForCurrentYearFinancial = 12 + remainingMonthsForCurrentYearFinancial;
                }

                payRunD.TotalEstimatedSalaryFty = payRunD.NetSalaryPaBeforeTax * remainingMonthsForCurrentYearFinancial;
                payRunD.ExemptSalaryFromPrviousEmplopyer = (allContracts.Where(x => x.EmpId == emp.EmpId).Select(x => x.TotalExamptSalaryFromPreviousEmployer).FirstOrDefault() != null ? (allContracts.Where(x => x.EmpId == emp.EmpId).Select(x => x.TotalExamptSalaryFromPreviousEmployer).FirstOrDefault()) : 0);
                payRunD.TotalEstimatedExamptSalary = payRunD.ExemptSalaryFromPrviousEmplopyer * remainingMonthsForCurrentYearFinancial;
                payRunD.AnnualTaxLiability = payRunD.TotalEstimatedSalaryFty + payRunD.TotalEstimatedExamptSalary;
                payRunD.TaxAlreadyDeduct = 0;
                payRunD.RemainingTaxLiability = payRunD.AnnualTaxLiability - payRunD.TaxAlreadyDeduct;
                payRunD.NoOfMonthRemaining = remainingMonthsForCurrentYearFinancial;
                payRunD.TaxPaForTheMonth = payRunD.RemainingTaxLiability / remainingMonthsForCurrentYearFinancial;

                //#region Tax Calculation
                //double totalTaxThisMonth = 0;
                //double totalSalaryOfEmp = (double)(payRunD.GrossSalary!=null ?payRunD.GrossSalary:0) * 12;
                //if (totalSalaryOfEmp >= 600000 && totalSalaryOfEmp <= 1200000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 600000;
                //    if(remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 5; // Five Percent tax
                //    }
                //}
                //else if (totalSalaryOfEmp >= 1200000 && totalSalaryOfEmp <= 1800000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 1200000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 10; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 30000; 
                //    }
                //}
                //else if (totalSalaryOfEmp >= 1800000 && totalSalaryOfEmp <= 2500000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 1800000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 15; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 90000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 2500000 && totalSalaryOfEmp <= 3500000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 2500000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 17.5; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 195000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 3500000 && totalSalaryOfEmp <= 5000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 3500000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 20; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 370000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 5000000 && totalSalaryOfEmp <= 8000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 5000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 22.5; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 670000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 8000000 && totalSalaryOfEmp <= 12000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 8000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 25; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 1345000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 12000000 && totalSalaryOfEmp <= 30000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 12000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 27.5; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 2345000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 30000000 && totalSalaryOfEmp <= 50000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 30000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 30; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 7295000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 50000000 && totalSalaryOfEmp <= 75000000)
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 50000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 32.5; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 13295000;
                //    }
                //}
                //else if (totalSalaryOfEmp >= 75000000 )
                //{
                //    var remainingTaxableAbmount = totalSalaryOfEmp - 75000000;
                //    if (remainingTaxableAbmount > 0)
                //    {
                //        totalTaxThisMonth = remainingTaxableAbmount / 35; // Ten Percent tax
                //        totalTaxThisMonth = totalTaxThisMonth + 21420000;
                //    }
                //}
                //else
                //{
                //    totalTaxThisMonth = 0;
                //}

                //#endregion


                //payRunD.NetPayableSalaryAfterTax = payRunD.NetSalaryPaBeforeTax - (decimal)totalTaxThisMonth;
                //payRunD.NetPayableSalaryAfterTaxAndStatuaryDeduction = 0;


                //For Removing of taxes i am using salarey before tax so when deloy in pak i will add after tax salary in calculations from here on b
                payRunD.PreviousPayableSalary = allPayRunD.Where(x => x.EmpId == emp.EmpId && x.SalaryDate.Value.Year == dateM.Year && x.SalaryDate.Value.Month == dateM.AddMonths(-1).Month).Select(x => x.FinalPaymentForThisMonth).FirstOrDefault() != null ? allPayRunD.Where(x => x.SalaryDate.Value.Year == dateM.Year && x.SalaryDate.Value.Month == dateM.AddMonths(-1).Month).Select(x => x.FinalPaymentForThisMonth).FirstOrDefault() : 0;
                payRunD.TotalPayableThisMonthAndPrevious = payRunD.NetSalaryPaBeforeTax + (allPayRunD.Where(x => x.EmpId == emp.EmpId && x.SalaryDate.Value.Year == dateM.Year && x.SalaryDate.Value.Month == dateM.AddMonths(-1).Month).Select(x => x.FinalPaymentForThisMonth).FirstOrDefault() != null ? allPayRunD.Where(x => x.EmpId == emp.EmpId && x.SalaryDate.Value.Year == dateM.Year && x.SalaryDate.Value.Month == dateM.AddMonths(-1).Month).Select(x => x.FinalPaymentForThisMonth).FirstOrDefault() : 0);
                payRunD.FinalPaymentForThisMonth = payRunD.NetSalaryPaBeforeTax;

                payRunD.Earning = payRunD.FinalPaymentForThisMonth;
                payRunD.Deduction = payRunD.TotalDeduction;
                payRunD.DifferAmount = payRunD.Earning - payRunD.TotalDeduction;

                payRundList.Add(payRunD);
                _payRunDService.Insert(payRunD);

            }

            result.msg = _payRunDService.SaveChanges();

            var updatedPayRun = _PayRunMervice.GetById(payRunM.PayrunId);
            updatedPayRun.TotalEarning = payRundList.Sum(x => x.Earning);
            updatedPayRun.TotalDeduction = payRundList.Sum(x => x.Deduction);
            updatedPayRun.NetTotal = updatedPayRun.TotalEarning - updatedPayRun.TotalDeduction;

            result.msg = _PayRunMervice.Update(updatedPayRun);
            result.msg = _PayRunMervice.SaveChanges();
            allPayRunD = _payRunDService.GetAll();
            allPayRunD = allPayRunD.Where(x => x.PayrunId == payRunM.PayrunId).ToList();

            foreach (var item in allPayRunD)
            {
                var empContractId = _empContractService.Find(x => x.EmpId == item.EmpId).Select(x => x.EmpContractId).FirstOrDefault();
                var allowances = _empContractsPackageService.Find(x => x.EmpContractId == empContractId).ToList();
                foreach (var allowance in allowances)
                {
                    var payRunPaySlip = new PayrunPayslip();
                    payRunPaySlip.EmpPayrunId = item.EmpPayrunId;
                    payRunPaySlip.AllowanceTypeId = "026" + allowance.AllowanceTypeId;
                    payRunPaySlip.CreatedDate = item.CreatedDate;
                    payRunPaySlip.Earning = allowance.Amount;
                    payRunPaySlip.Deduction = 0;
                    payRunPaySlip.Description = allAllowances.Where(x => x.LookupId == allowance.AllowanceTypeId).Select(x => x.LookupNameEn).FirstOrDefault();

                    result.msg = _paySlipSerivce.Insert(payRunPaySlip);
                    result.msg = _paySlipSerivce.SaveChanges();
                }

            }
            result.msg = _paySlipSerivce.SaveChanges();

            result.isError = (result.msg != "" ? true : false);
            result.scalerVal = payRunM.PayrunId;

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var idDel = Int32.Parse(id);

            var payRunDList = _payRunDService.Find(x => x.PayrunId == idDel).ToList();

            foreach (var item in payRunDList)
            {
                var paySlips = _paySlipSerivce.Find(x => x.EmpPayrunId == item.EmpPayrunId).ToList();
                _paySlipSerivce.dbset().RemoveRange(paySlips);

            }
            _paySlipSerivce.SaveChanges();
            _payRunDService.dbset().RemoveRange(payRunDList);
            _payRunDService.SaveChanges();

            _PayRunMervice.Delete(idDel);

            result.msg = _PayRunMervice.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }



    }
}
