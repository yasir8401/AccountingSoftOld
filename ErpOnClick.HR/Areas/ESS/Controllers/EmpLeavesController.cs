using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Models;
using ErpOnClick.ErpMain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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

    public class EmpLeavesController : BaseController
    {

        private readonly ILogger<EmpLeavesController> _logger;
        private ILeaveService _Leaveervice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _EmpService;
        private IApprovalTaskService _approvalTaskService;
        private IApprovalRouteService _approvalRouteService;
        private IApprovalRouteDetailsService _approvalRouteDetailsService;
        private IUserService _userService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;
        private IEmpContractsService _EmpContractsService;
        private ILeavesProfileService _LeavesProfileService;

        private dynamic expObj;
        public EmpLeavesController(IUserService UserService, ILogger<EmpLeavesController> logger, IUserService userService, IApprovalRouteService approvalRouteService, IApprovalRouteDetailsService approvalRouteDetailsService, IApprovalTaskService approvalTaskService, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ILeaveService Leaveervice, ILookupsService LookupService, ILookupTypesService LookupTypesService, IEmpContractsService empContractsService, ILeavesProfileService leavesProfileService)
        {
            _logger = logger;
            _UserService = UserService;
            _userService = userService;
            _Leaveervice = Leaveervice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _HostEnvironment = HostEnvironment;
            _approvalTaskService = approvalTaskService;
            _approvalRouteService = approvalRouteService;
            _approvalRouteDetailsService = approvalRouteDetailsService;
            _EmpContractsService = empContractsService;
            _LeavesProfileService = leavesProfileService;

            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            var EmpId = GetEmployeeId();

            var leavesDetail = new List<DAL.Models.Leaves>();
            leavesDetail = _Leaveervice.dbset().Include(x => x.AttachmentTypeNavigation).Include(x => x.LeaveStatusNavigation).Include(x => x.Emp).Include(x => x.LeaveType).Where(x => x.EmpId == EmpId).ToList();

            double TotalAnnualLeaves = GetAnnualLeavesByEmployeeId(EmpId);

            expObj.LeaveList = leavesDetail;
            expObj.TotalLeaves = TotalAnnualLeaves;
            expObj.LeavesProfile = _LeavesProfileService.GetAll().SingleOrDefault();
            return View(expObj);
        }

        private double GetAnnualLeavesByEmployeeId(int EmpId)
        {
            var contractActive = _EmpContractsService.Find(x => x.EmpId == EmpId && x.ContractStatus == "027002").FirstOrDefault();
            DateTime joiningDate = Convert.ToDateTime(_EmpContractsService.Find(x => x.EmpId == EmpId).OrderByDescending(x => x.JoiningDate).SingleOrDefault().JoiningDate);

            DateTime currentDateTime = DateTime.Now;

            var totalMonthsInService = currentDateTime.Subtract(joiningDate).Days / (365.25 / 12);

            float leavsPerMonth = (float)((double)(contractActive.TotalAnnualLeavesPerYear ?? 0) / 12);

            var TotalAnnualLeaves = (int) (Math.Round(totalMonthsInService, 2) * Math.Round(leavsPerMonth, 2));
            return TotalAnnualLeaves;
        }

        public IActionResult _list()
        {
            var EmpId = GetEmployeeId();
            expObj.LeaveList = _Leaveervice.dbset().Include(x => x.AttachmentTypeNavigation).Include(x => x.LeaveStatusNavigation).Include(x => x.Emp).Include(x => x.LeaveType).Where(x => x.EmpId == EmpId).ToList();

            

            return PartialView(expObj);
        }

        public IActionResult view(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.leaveTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.LeaveType_032).ToList();
            expObj.attachmentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).ToList();
            expObj.leaveStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(x => x.EmpId != GetEmployeeId()).ToList();
            expObj.employee = _EmpService.Find(x => x.EmpId == GetEmployeeId()).ToList();

            expObj.LeaveDetails = _Leaveervice.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> save(leaveStatusInherited postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _Leaveervice.GetById(postedData.LeaveId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Leave Id " + postedData.LeaveId + " is already exists !";
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
                    var attachMentFile = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                    if (!String.IsNullOrWhiteSpace(attachMentFile))
                    {
                        postedData.Attachment = attachMentFile;
                    }
                    result.msg = _Leaveervice.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _Leaveervice.SaveChanges();
                        result.scalerVal = postedData.LeaveId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Post(string id)
        {
            DbResult result = new DbResult();

            var leaveId = (id != null ? Int32.Parse(id) : 0);
            var leave = _Leaveervice.GetById(leaveId);
            leave.LeaveStatus = "007001";
            result.msg = _Leaveervice.Update(leave);
            result.msg = _Leaveervice.SaveChanges();


            var approvalTask = _approvalTaskService.Find(x => x.ApprovalTaskNameEn == "Leave Request").FirstOrDefault();
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
                routeDetail.RecordId = leaveId + "";
                routeDetail.ApprovalStatus = "007001";
                routeDetail.RecordNotes = null;
                routeDetail.ApproverNotes = null;
                routeDetail.ActionDate = DateTime.Now;
                routeDetail.CreatedDate = DateTime.Now;
                routeDetail.CreatedBy = GetEmployeeId();
                routeDetail.RecordName = "Employee Leave Request";
                routeDetail.RecordNotes = "Leaves pending for apporval";

                result.msg = _approvalRouteDetailsService.Insert(routeDetail);
            }
            result.msg = _approvalRouteDetailsService.SaveChanges();
            result.scalerVal = leaveId;
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        [HttpPost]
        public async Task<ActionResult> update(leaveStatusInherited postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var attachMentFile = await FileHandling.UploadFile(_HostEnvironment, postedData.AttachmentFile);
                if (!String.IsNullOrWhiteSpace(attachMentFile))
                {
                    postedData.Attachment = attachMentFile;
                }

                result.msg = _Leaveervice.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _Leaveervice.SaveChanges();
                    result.scalerVal = postedData.LeaveId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Preview(string id)
        {
            DbResult result = new DbResult();

            var records = _approvalRouteDetailsService.Find(x => x.RecordId == id).ToList();
            var recordList = new List<RecordsPreviewViewModel>();

            foreach (var record in records)
            {
                var recordModel = new RecordsPreviewViewModel();

                var user = _userService.GetById(record.ApproverUserId);

                recordModel.UserName = user.DisplayNameEn;
                recordModel.Comments = record.ApproverNotes;
                recordModel.SeqId = record.SeqId + "";
                recordModel.Status = _LookupService.Find(x => x.Code == record.ApprovalStatus).Select(x => x.LookupNameEn).FirstOrDefault();

                recordList.Add(recordModel);
            }

            recordList = recordList.OrderBy(x => x.SeqId).ToList();

            result.scalerVal = recordList;
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }

        public ActionResult CalculateRemainingBalance(string leaveTypeId)
        {
            double totalLeaves = 0;
            double? remainingLeaves = 0;

            var leavesProfile = _LeavesProfileService.GetAll().FirstOrDefault();
            var previousLeavesRequests = _Leaveervice.Find(x => x.EmpId == GetEmployeeId()).ToList();
            var avaialedLeaves = previousLeavesRequests.Where(x => x.LeaveTypeId == leaveTypeId && x.LeaveStatus == "007002").Sum(x => x.PaidDays);
            if (leaveTypeId == "032001")
            {

                totalLeaves = leavesProfile.TotalSickLeaves;

            }
            else if (leaveTypeId == "032002") 
            {
                totalLeaves = GetAnnualLeavesByEmployeeId(GetEmployeeId());
                
            }
            else if (leaveTypeId == "032003")
            {
                totalLeaves = (int)leavesProfile.TotalSpecialLeaves;

            }
            else if (leaveTypeId == "032004")
            {
                totalLeaves = leavesProfile.TotalEmergencyLeaves;

            }
            else if (leaveTypeId == "032005")
            {
                totalLeaves = leavesProfile.TotalBusinessLeaves;
            }
            else if (leaveTypeId == "032006")
            {
                totalLeaves = (int)leavesProfile.TotalMarriageLeaves;
            }
            else if (leaveTypeId == "032007")
            {
                totalLeaves = (int)leavesProfile.TotalPaternityLeaves;
            }
            else if (leaveTypeId == "032008")
            {
                totalLeaves = (int)leavesProfile.TotalExaminationLeaves;
            }
            else if (leaveTypeId == "032009")
            {
                totalLeaves = (int)leavesProfile.TotalEducationalLeaves;
            }

            remainingLeaves = totalLeaves - avaialedLeaves;

          
            return Json(new { remainingLeaves });

        }

    }
}
