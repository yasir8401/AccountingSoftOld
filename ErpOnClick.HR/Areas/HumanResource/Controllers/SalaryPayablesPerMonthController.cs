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
    public class SalaryPayablesPerMonthController : Controller
    {
        private readonly ILogger<SalaryPayablesPerMonthController> _logger;
        private ISalaryPayablesPerMonthService _SalaryPayablesPerMonthervice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _EmpService;
        private IEmpContractsService _empContractService;
        private IEmpBankService _empBankService;
        private IEmpShiftsService _empshiftService;
        private ILoansService _loanService;


        private dynamic expObj;
        public SalaryPayablesPerMonthController(ILogger<SalaryPayablesPerMonthController> logger, ILoansService loanService, IEmpContractsService empContractService, IEmpBankService empBankService, IEmpShiftsService empshiftService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ISalaryPayablesPerMonthService SalaryPayablesPerMonthervice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _SalaryPayablesPerMonthervice = SalaryPayablesPerMonthervice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _empBankService = empBankService;
            _empContractService = empContractService;
            _empshiftService = empshiftService;
            _loanService = loanService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index(string SalaryPayablesPerMonthDate)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            if(SalaryPayablesPerMonthDate is not null)
            {
                var dateYear = Int32.Parse(SalaryPayablesPerMonthDate.Split('-')[0]);
                var dateMonth = Int32.Parse(SalaryPayablesPerMonthDate.Split('-')[1]);

                var dateAttendance = new DateTime(dateYear, dateMonth, 1);
                expObj.SalaryPayablesPerMonthDate = dateAttendance;
            }
            else
            {
                expObj.SalaryPayablesPerMonthDate = DateTime.Now;
            }

           

            return View(expObj);
        }

        public IActionResult _list(string date)
       {
            if (!String.IsNullOrEmpty(date))
            {
                var dateYear = Int32.Parse(date.Split('-')[0]);
                var dateMonth = Int32.Parse(date.Split('-')[1]);

                var dateAttendance = new DateTime(dateYear, dateMonth, 1);
                expObj.empSalaryPayablesPerMonthList = _SalaryPayablesPerMonthervice.dbset().Include(x => x.Emp).Where(x=> x.SalaryDate.Value.Date.Month == dateAttendance.Date.Month && x.SalaryDate.Value.Date.Year == dateAttendance.Date.Year).ToList();
            }
            else
            {
                expObj.empSalaryPayablesPerMonthList = _SalaryPayablesPerMonthervice.dbset().Include(x => x.Emp).ToList();
            }
          

            return PartialView(expObj);
        }
        [HttpPost]
        public IActionResult GetEmployees(string date)
        {
            DbResult result = new DbResult();
            DateTime dateEmp = DateTime.Now;
            if(date!=null)
            {
                var dateYear = Int32.Parse(date.Split('-')[0]);
                var dateMonth = Int32.Parse(date.Split('-')[1]);

                dateEmp = new DateTime(dateYear, dateMonth, 1);
            }
            var empList = _EmpService.GetAll();
            var allLoans = _loanService.GetAll();
            if (empList != null)
            {
                foreach (var emp in empList)
                {
                    var currentEmpLoanApproved = allLoans.Where(x => x.EmpId == emp.EmpId && x.LoanStatus == "037001").FirstOrDefault();
                    decimal? remainingAmount = null;
                    decimal? thisMonthAmount = null;
                    if (currentEmpLoanApproved!=null)
                    {
                        var totalAppliedMonths = (currentEmpLoanApproved.DateStart.Value.Date < dateEmp.Date) ? dateEmp.Date.Month - currentEmpLoanApproved.DateStart.Value.Date.Month : 0;
                        int? remainingMonths = currentEmpLoanApproved.NoOfInstallments - totalAppliedMonths;
                        remainingAmount = currentEmpLoanApproved.LoanAmount - currentEmpLoanApproved.DeductAmount;

                        if(currentEmpLoanApproved.DateStart.Value.Date <= dateEmp.Date && remainingAmount!= 0)
                        {
                            thisMonthAmount = remainingAmount / remainingMonths;

                            currentEmpLoanApproved.DeductAmount += thisMonthAmount;
                            _loanService.Update(currentEmpLoanApproved);
                        }
                    }

                    var empCheck = _SalaryPayablesPerMonthervice.Find(x=>x.EmpId == emp.EmpId && x.SalaryDate.Value.Date.Month == dateEmp.Month && x.SalaryDate.Value.Date.Year == dateEmp.Year ).FirstOrDefault();
                    if (empCheck == null)
                    {
                        var empPerformanceBasedsalary = new ErpOnClick.DAL.Models.SalaryPayablesPerMonth()
                        {
                            EmpId = emp.EmpId,
                            SalaryDate = dateEmp,
                            SalaryYear = dateEmp.Year,
                            SalaryMonth = dateEmp.Month,
                            LoadDeductionThisMonth = thisMonthAmount,

                        };
                        result.msg = _SalaryPayablesPerMonthervice.Insert(empPerformanceBasedsalary);
                    }
                }
                result.msg = _SalaryPayablesPerMonthervice.SaveChanges();
                result.msg = _loanService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult save(IList<ErpOnClick.DAL.Models.SalaryPayablesPerMonth> postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                foreach (var item in postedData)
                {
                    if (item != null)
                    {
                            item.ModifiedBy = 1;
                            item.TotalDeduction = (item.UnpaidDaysDeduction != null ? item.UnpaidDaysDeduction : 0) + (item.OtherDeduction != null ? item.OtherDeduction : 0) + (item.AbsentFine != null ? item.AbsentFine : 0) + (item.LoadDeductionThisMonth != null ? item.LoadDeductionThisMonth : 0);

                        result.msg = _SalaryPayablesPerMonthervice.Update(item);
                            result.msg = _SalaryPayablesPerMonthervice.SaveChanges();
                        
                    }
                }
               
            }

            return Json(new { result = result });
        }

      
    }
}
