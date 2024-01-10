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

    public class EmpPaySlipController : BaseController
    {
        private readonly ILogger<EmpPaySlipController> _logger;
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
        private IPayRunDService _payRunDService;
        private IPaySlipSerivce _paySlipSerivce;
        private IPayRunMService _payRunMService;


        private dynamic expObj;
        public EmpPaySlipController(IUserService UserService, ILogger<EmpPaySlipController> logger, ILeaveService leaveService, IEmpContractsService empContractService, IEmpBankService empBankService, IEmpShiftsService empshiftService, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IEmpAttendancesService EmpAttendanceService, ILookupsService LookupService, ILookupTypesService LookupTypesService, IPayRunDService payRunDService, IPayRunMService payRunMService, IPaySlipSerivce paySlipSerivce)
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
            _payRunDService = payRunDService;
            _payRunMService = payRunMService;
            _paySlipSerivce = paySlipSerivce;

            expObj = new ExpandoObject();
        }
        public IActionResult Index(string paySlipDate)
        {
            var EmpId = GetEmployeeId();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var payRunDRecord = _payRunDService.Find(x => x.SalaryMonth == Convert.ToDateTime(paySlipDate).Month && x.SalaryYear == Convert.ToDateTime(paySlipDate).Year && x.EmpId == EmpId).FirstOrDefault();
            var empPayRunDId = payRunDRecord != null ? payRunDRecord.EmpPayrunId : 0;

            var paySlipDetails = _paySlipSerivce.Find(x => x.EmpPayrunId == empPayRunDId).ToList();

            expObj.PaySlipDetails = paySlipDetails;
            expObj.PaySlipDate = Convert.ToDateTime(paySlipDate);

            return View(expObj);
        }

        public IActionResult _list(string date)
        {
            var EmpId = GetEmployeeId();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var payRunDRecord = _payRunDService.Find(x => x.SalaryMonth == Convert.ToDateTime(date).Month && x.SalaryYear == Convert.ToDateTime(date).Year && x.EmpId == EmpId).FirstOrDefault();
            var empPayRunDId = payRunDRecord != null ? payRunDRecord.EmpPayrunId : 0;

            var paySlipDetails = _paySlipSerivce.Find(x => x.EmpPayrunId == empPayRunDId).ToList();

            expObj.PaySlipDetails = paySlipDetails;
            expObj.PaySlipDate = date;

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/PrintPaySlip/{paySlipDate}")]
        public IActionResult PrintPaySlip(string paySlipDate)
        {
            var EmpId = GetEmployeeId();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var payRunDRecord = _payRunDService.Find(x => x.SalaryMonth == Convert.ToDateTime(paySlipDate).Month && x.SalaryYear == Convert.ToDateTime(paySlipDate).Year && x.EmpId == EmpId).FirstOrDefault();
            var empPayRunDId = payRunDRecord != null ? payRunDRecord.EmpPayrunId : 0;

            var paySlipDetails = _paySlipSerivce.Find(x => x.EmpPayrunId == empPayRunDId).ToList();

            expObj.PaySlipDetails = paySlipDetails;
            expObj.PaySlipDate = paySlipDate;
            expObj.employee = _EmpService.GetById(EmpId);
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }
    }
}
