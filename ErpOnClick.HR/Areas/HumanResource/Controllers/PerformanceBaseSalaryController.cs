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
    public class PerformanceBaseSalaryController : Controller
    {
        private readonly ILogger<PerformanceBaseSalaryController> _logger;
        private IPerformanceBaseSalaryService _PerformanceBaseSalaryervice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _EmpService;
        private IEmpContractsService _empContractService;
        private IEmpBankService _empBankService;
        private IEmpShiftsService _empshiftService;
        private IOverTimeRequestService _overTimeRequestService;
        private IOverTimeRequestLineService _overTimeRequestLineService;


        private dynamic expObj;
        public PerformanceBaseSalaryController(ILogger<PerformanceBaseSalaryController> logger, IOverTimeRequestService overTimeRequestService, IOverTimeRequestLineService overTimeRequestLineService, IEmpContractsService empContractService, IEmpBankService empBankService, IEmpShiftsService empshiftService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IPerformanceBaseSalaryService PerformanceBaseSalaryervice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _PerformanceBaseSalaryervice = PerformanceBaseSalaryervice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _overTimeRequestLineService = overTimeRequestLineService;
            _overTimeRequestService = overTimeRequestService;
            _EmpService = EmpService;
            _empBankService = empBankService;
            _empContractService = empContractService;
            _empshiftService = empshiftService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index(string performanceBaseSalaryDate)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            if(performanceBaseSalaryDate is not null)
            {
                var dateYear = Int32.Parse(performanceBaseSalaryDate.Split('-')[0]);
                var dateMonth = Int32.Parse(performanceBaseSalaryDate.Split('-')[1]);

                var dateAttendance = new DateTime(dateYear, dateMonth, 1);
                expObj.performanceBaseSalaryDate = dateAttendance;
            }
            else
            {
                expObj.performanceBaseSalaryDate = DateTime.Now;
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
                expObj.empPerformanceBaseSalaryList = _PerformanceBaseSalaryervice.dbset().Include(x => x.Emp).Where(x=> x.Date.Value.Date.Month == dateAttendance.Date.Month && x.Date.Value.Date.Year == dateAttendance.Date.Year).ToList();
            }
            else
            {
                expObj.empPerformanceBaseSalaryList = _PerformanceBaseSalaryervice.dbset().Include(x => x.Emp).ToList();
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
            var overTimeComplete = _overTimeRequestService.dbset().Include(x => x.OvertimeRequestsLines).Where(x => x.OvertimeDate.Value.Date.Month == dateEmp.Date.Month).ToList();
            var otThis = _overTimeRequestLineService.Find(x => x.CreatedDate.Value.Date.Month == dateEmp.Date.Month).ToList();
            if (empList != null)
            {
                foreach (var emp in empList)
                {
                    var empCheck = _PerformanceBaseSalaryervice.Find(x=>x.EmpId == emp.EmpId && x.Date.Value.Date.Month == dateEmp.Month && x.Date.Value.Date.Year == dateEmp.Year ).FirstOrDefault();
                    var a = otThis.Where(x => x.EmpId == emp.EmpId).Sum(x => x.OtHours);
                    if (empCheck == null)
                    {
                        var ass = overTimeComplete.Select(x => x.OvertimeRequestsLines.Where(x => x.EmpId == emp.EmpId).Sum(x => x.OtHours)).ToList();
                        var empPerformanceBasedsalary = new ErpOnClick.DAL.Models.PerformanceBaseSalary()
                        {
                            EmpId = emp.EmpId,
                            Date = dateEmp,
                            SalaryYear = dateEmp.Year,
                            SalaryMonth = dateEmp.Month,
                            OvertimeHours = otThis.Where(x => x.EmpId == emp.EmpId).Sum(x => x.OtHours),
                            OvertimeTotalMoney = otThis.Where(x => x.EmpId == emp.EmpId).Sum(x => x.OtAmount),

                        };
                        result.msg = _PerformanceBaseSalaryervice.Insert(empPerformanceBasedsalary);
                    }
                }
                result.msg = _PerformanceBaseSalaryervice.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }


     


        [HttpPost]
        public ActionResult save(IList<ErpOnClick.DAL.Models.PerformanceBaseSalary> postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                foreach (var item in postedData)
                {
                    if (item != null)
                    {
                        
                            item.ModifiedDate = DateTime.Now;
                            item.ModifiedBy = 1;
                            item.EarnedSalary = (item.ReferenceBasedCommission !=null ? item.ReferenceBasedCommission:0) + (item.DemoCommission!=null ? item.DemoCommission:0) + (item.SaleCommision !=null ? item.SaleCommision:0) + (item._500Commission!=null? item._500Commission:0 ) + (item.ZeroPaid!=null? item.ZeroPaid:0) + (item.GiftAmount!=null? item.GiftAmount:0) + (item.RecurringAmount!=null? item.RecurringAmount:0) + (item.MonthlyBonus!=null? item.MonthlyBonus:0) + (item.OvertimeTotalMoney != null ? item.OvertimeTotalMoney : 0);

                            result.msg = _PerformanceBaseSalaryervice.Update(item);
                            result.msg = _PerformanceBaseSalaryervice.SaveChanges();
                        
                    }
                }
               
            }

            return Json(new { result = result });
        }

     
      
    }
}
