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

using Microsoft.AspNetCore.Hosting;
using ErpOnClick.DAL.Utilities;

using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class LogActivityController : Controller
    {
        private readonly ILogger<LogActivityController> _logger;
        private IActivityLogService _ActivityLogService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IDepartmentService _departmentService;
        private IApprovalRouteService _approvalRouteService;
        private IModuleService _moduleService;
        private INavigationService _navigationService;
        private ILookupsService _lookupsService;
        private ERPonClickContext _db;

        private dynamic expObj;
        public LogActivityController(ILogger<LogActivityController> logger,ERPonClickContext db, ILookupsService lookupsService, INavigationService navigationService, IModuleService moduleService, IApprovalRouteService approvalRouteService, IDepartmentService departmentService, IUserService UserService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IActivityLogService ActivityLogService, ILookupTypesService LookupTypesService)
        {
            _db = db;
            _logger = logger;
            _ActivityLogService = ActivityLogService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _UserService = UserService;
            _departmentService = departmentService;
            _approvalRouteService = approvalRouteService;
            _moduleService = moduleService;
            _navigationService = navigationService;
            _lookupsService = lookupsService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index(int? pageNumber,int pageSize)
        {
            var lookupList = _lookupsService.GetAll();

            expObj.moduleList = _moduleService.GetAll();
            expObj.navigationList = _navigationService.GetAll();
          

            expObj.pageNumber = (pageNumber==null ? 1:pageNumber);
            expObj.pageSize = (pageSize != 0 ? pageSize : 5);

            return View(expObj);
        }

        public async Task<IActionResult> _list(int? pageNumber,int pageSize,string LogType,int? moduleId,int? navigationId,int ? RefId)
        {
            var total = Convert.ToDecimal(_ActivityLogService.GetAll().Count());
            var countRecords = Math.Ceiling(total / Convert.ToDecimal(pageSize));
       
            pageSize = (pageSize != 0 ? pageSize : 5);
            expObj.pageSize = pageSize;
            pageNumber = (countRecords == 1 ? 1 : pageNumber);
            expObj.pageNumber = pageNumber;
            var activityLog = _db.ActivityLog.Include(x=>x.User);

            #region Search Filter
            if (!String.IsNullOrWhiteSpace(LogType) && LogType != "All")
            {
                activityLog = activityLog.Where(x => x.LogType.ToLower() == LogType.ToLower()).Include(x=>x.User);
            }
            if (moduleId !=null)
            {
                activityLog = activityLog.Where(x => x.ModuleId == moduleId).Include(x => x.User);
            }
            if (navigationId != null)
            {
                activityLog = activityLog.Where(x => x.NavigationId == navigationId).Include(x => x.User);
            }
            if (RefId != null)
            {
                activityLog = activityLog.Where(x => x.RefId == RefId).Include(x => x.User);
            }
            #endregion

            var list = await PaginatedList<ErpOnClick.DAL.Models.ActivityLog>.CreateAsync(activityLog, pageNumber ?? 1, pageSize);
            expObj.countRecords = countRecords;
            expObj.ActivityLogList = list;

            return PartialView(expObj);
        }
     
        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _ActivityLogService.Delete(Int32.Parse(id));

       
            result.msg = _ActivityLogService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
