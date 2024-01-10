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
using ErpOnClick.DAL.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Hosting;
using ErpOnClick.ErpMain.Models;
using Microsoft.EntityFrameworkCore;
using ErpOnClick.ErpMain.Areas.ESS.Controllers;
using ErpOnClick.EmpDependents.Areas.Admin.Controllers;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers.General_Requests
{

    public class ExpClaimsRequestController : BaseController
    {
        private readonly ILogger<ExpClaimsController> _logger;
        private IExpClaimsService _ExpClaimsService;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IApprovalTaskService _approvalTaskService;
        private IApprovalRouteService _approvalRouteService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;

        private dynamic expObj;
        public ExpClaimsRequestController(IUserService UserService, ILogger<ExpClaimsController> logger, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IExpClaimsService ExpClaimsService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService)
        {
            _logger = logger;
            _UserService = UserService;
            _ExpClaimsService = ExpClaimsService;
            _EmpService = EmpService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;
            _approvalTaskService = approvalTaskService;
            _approvalRouteService = approvalRouteService;
            _approvalRouteDetailsService = approvalRouteDetailsService;

            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult _list()
        {
            var empId = GetEmployeeId();
            var lookupList = _LookupService.GetAll();

            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();

            expObj.ExpClaimsList = _ExpClaimsService.dbset().Include(c => c.Emp).Where(x => x.EmpId == empId).ToList();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var empId = GetEmployeeId();
            var lookupList = _LookupService.GetAll();

            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            //expObj.employeesList = _EmpService.GetAll();
            expObj.employeesList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.ExpClaimDetails = _ExpClaimsService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> saveAsync(ExpclaimsInheritied postedData)
        {
            var empId = GetEmployeeId();
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _ExpClaimsService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "ExpClaimId " + postedData.RecId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    postedData.EngagementId = 0;
                    postedData.EmpId = empId;

                    var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.FileToUpload);

                    if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                    {
                        postedData.Attachment = attachmentfilePath;
                    }
                    result.msg = _ExpClaimsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _ExpClaimsService.SaveChanges();
                        result.scalerVal = postedData.RecId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> updateAsync(ExpclaimsInheritied postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var attachmentfilePath = await FileHandling.UploadFile(_HostEnvironment, postedData.FileToUpload);
                if (!String.IsNullOrWhiteSpace(attachmentfilePath))
                {
                    postedData.Attachment = attachmentfilePath;
                }

                result.msg = _ExpClaimsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ExpClaimsService.SaveChanges();
                    result.scalerVal = postedData.RecId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            var expclaim = _ExpClaimsService.GetById(Int32.Parse(id));

            _ExpClaimsService.Delete(Int32.Parse(id));
            var resultFile = FileHandling.DeleteFile(_HostEnvironment, expclaim.Attachment);

            result.msg = _ExpClaimsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult Post(string id)
        {
            DbResult result = new DbResult();

            var expClaimId = (id != null ? Int32.Parse(id) : 0);
            var leave = _ExpClaimsService.GetById(expClaimId);
            leave.RequestStatus = "007001";
            result.msg = _ExpClaimsService.Update(leave);
            result.msg = _ExpClaimsService.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "Expense Claim Request").FirstOrDefault();
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
                routeDetail.RequestedBy = leave.EmpId;
                routeDetail.RecordId = expClaimId + "";
                routeDetail.ApprovalStatus = "007001";
                routeDetail.RecordNotes = null;
                routeDetail.ApproverNotes = null;
                routeDetail.ActionDate = DateTime.Now;
                routeDetail.CreatedDate = DateTime.Now;
                routeDetail.CreatedBy = GetEmployeeId();
                routeDetail.RecordName = "Expense Claim Request";
                routeDetail.RecordNotes = "Expense Claim pending for apporval";

                result.msg = _approvalRouteDetailsService.Insert(routeDetail);
            }
            result.msg = _approvalRouteDetailsService.SaveChanges();
            result.scalerVal = expClaimId;
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
