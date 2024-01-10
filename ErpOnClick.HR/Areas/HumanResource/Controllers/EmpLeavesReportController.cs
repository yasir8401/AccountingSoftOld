using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Models;
using ErpOnClick.ErpMain.ViewModel;
using ErpOnClick.Invoicing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpLeavesReportController : Controller
    {
        private readonly ILogger<EmpLeavesReportController> _logger;

        private IEmpsService _EmpsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ILeaveService _LeaveService;
        private ILookupsService _LookupsService;
        private ILookupTypesService _LookupTypesService;
        private IGeneralEntriesLinesService _generalEntriesLinesService;

        private dynamic expObj;
        public EmpLeavesReportController(ILogger<EmpLeavesReportController> logger, ILookupTypesService LookupTypesService, ILookupsService LookupsService, ILeaveService LeaveService, IEmpsService EmpsService, ICompanyService CompanyService, IBranchService BranchService)
        {
            _logger = logger;

            _EmpsService = EmpsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _LeaveService = LeaveService;
            _LookupsService = LookupsService;
            _LookupTypesService = LookupTypesService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index(int EmpId)
        {
            expObj.empsList = _EmpsService.GetAll();
            expObj.EmpId = EmpId;

            return View(expObj);
        }

        public IActionResult _list(int EmpId)
        {
            expObj.leaveList = _LeaveService.dbset().Include(x => x.AttachmentTypeNavigation).Include(x => x.LeaveStatusNavigation).Include(x => x.Emp).Include(x => x.LeaveType).Where(x=>x.EmpId == EmpId).ToList();

            return PartialView(expObj);
        }

        public IActionResult PrintList(int EmpId)
        {
            expObj.leaveList = _LeaveService.dbset().Include(x => x.AttachmentTypeNavigation).Include(x => x.LeaveStatusNavigation).Include(x => x.Emp).Include(x => x.LeaveType).Where(x => x.EmpId == EmpId).ToList();
            expObj.CompanyDetail = _CompanyService.GetById(1);

            return PartialView(expObj);
        }

        public List<EmpLeavesReportModel> GenerateReportForEmpLeaves(DateTime FromDate, DateTime ToDate, int EmpId)
        {
            var lookupList = _LookupsService.GetAll();

            List<EmpLeavesReportModel> listReportEmpLeaves = new List<EmpLeavesReportModel>();
            List<Leaves> allLeaves = _LeaveService.dbset().Include(x => x.Emp).ToList();
            List<IGrouping<ErpOnClick.DAL.Models.Emp, Leaves>> leavesList = null;
            List<ErpOnClick.DAL.Models.Emp> empList = _EmpsService.GetAll().ToList();
            ErpOnClick.DAL.Models.Emp empDetails = _EmpsService.GetById(EmpId);

            #region MakingReportForEmpLeaves
            if (EmpId != 0)
            {
                leavesList = allLeaves.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate) && x.EmpId == empDetails.EmpId).OrderBy(c => c.CreatedDate.Value.Date).AsEnumerable().GroupBy(c => c.Emp).ToList();
            }
            else
            {
                leavesList = allLeaves.Where(x => x.CreatedDate >= Convert.ToDateTime(FromDate) && x.CreatedDate <= Convert.ToDateTime(ToDate)).OrderBy(c => c.CreatedDate.Value.Date).AsEnumerable().GroupBy(c => c.Emp).ToList();
            }

            foreach (var item in leavesList)
            {
                EmpLeavesReportModel reportObject = new EmpLeavesReportModel();
                reportObject.Total = 0;
                reportObject.Used = Convert.ToInt32(item.Sum(c => c.PaidDays) + item.Sum(c => c.UnpaidDays));
                reportObject.Balance = reportObject.Total - reportObject.Used;
                reportObject.EmployeeId = item.Key.EmpId;
                reportObject.Employee = item.Key.FirstNameEn + " " + item.Key.FamilyNameEn + " " + item.Key.FamilyNameEn;

                reportObject.FromDate = FromDate;
                reportObject.ToDate = ToDate;

                listReportEmpLeaves.Add(reportObject);
            }

            #endregion

            return listReportEmpLeaves;
        }


    }
}
