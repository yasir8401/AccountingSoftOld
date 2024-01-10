using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.Emp.Areas.Admin.Controllers;
using ErpOnClick.ErpMain.Models;
using ErpOnClick.ErpMain.Utitlites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{
    
    public class ProfileController : BaseController
    {

        private readonly ILogger<EmpController> _logger;
        private IEmpsService _EmpService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        public static IHostingEnvironment _env;
        private IActivityLogService _activityLogService;
        private IDivisionsService _DivisionService;
        private IDepartmentService _DepartmentService;
        private ISectionService _SectionService;
        private IUnitService _UnitService;
        private ISubSectionService _SubSectionService;
        private ITeamService _TeamService;
        private IEmpContractsService _empContractsService;
        private IPayGroupsService _payGroupsService;
        private IEmpContractsPackageService _empContractsPackageService;
        private IPositionsService _positionsService;
        private IUserService _UserService;

        private dynamic expObj;
        public ProfileController(IUserService UserService, ILogger<EmpController> logger, IPositionsService positionsService, IHostingEnvironment env, IEmpContractsPackageService empContractsPackageService, IPayGroupsService payGroupsService, IEmpContractsService empContractsService, ITeamService TeamService, ISubSectionService SubSectionService, IDivisionsService DivisionService, IDepartmentService DepartmentService, IUnitService UnitService, ISectionService SectionService, IActivityLogService activityLogService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _positionsService = positionsService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _activityLogService = activityLogService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;
            _DepartmentService = DepartmentService;
            _SectionService = SectionService;
            _SubSectionService = SubSectionService;
            _UnitService = UnitService;
            _TeamService = TeamService;
            _empContractsService = empContractsService;
            _payGroupsService = payGroupsService;
            _empContractsPackageService = empContractsPackageService;


            _HostEnvironment = HostEnvironment;
            _env = env;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {


            var EmpId = GetEmployeeId();

            var lookupList = _LookupService.GetAll();

            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            expObj.martialStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.MaritalStatus_011).ToList();
            expObj.citiyList = lookupList.Where(x => x.LookupTypeId == LookupTypList.City_005).ToList();
            expObj.nationalityList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Nationality_012).ToList();
            expObj.religionList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Religion_013).ToList();
            expObj.genderList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Gende_014).ToList();
            expObj.activeStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();
            expObj.postions = _positionsService.GetAll();
            expObj.idTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ID_Type_056).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var emp = _EmpService.GetById(EmpId);
            EmpInheritied empDetails = null;
            if (emp != null)
            {
                empDetails = new EmpInheritied()
                {
                    EmpId = emp.EmpId,
                    FirstNameEn = emp.FirstNameEn,
                    FatherNameEn = emp.FatherNameEn,
                    GrandNameEn = emp.GrandNameEn,
                    FamilyNameEn = emp.FamilyNameEn,
                    FirstNameAr = emp.FirstNameAr,
                    FatherNameAr = emp.FatherNameAr,
                    GrandNameAr = emp.GrandNameAr,
                    FamilyNameAr = emp.FamilyNameAr,
                    Dob = emp.Dob,
                    DobH = emp.DobH,
                    Age = emp.Age,
                    BirthPlaceId = emp.BirthPlaceId,
                    NationalityId = emp.NationalityId,
                    ReligionId = emp.ReligionId,
                    GenderId = emp.GenderId,
                    MaritalStatusId = emp.MaritalStatusId,
                    MobileNo = emp.MobileNo,
                    Email = emp.Email,
                    SponsorId = emp.SponsorId,
                    StayingWithFamily = emp.StayingWithFamily,
                    ProfilePic = emp.ProfilePic,
                    ActiveStatus = emp.ActiveStatus,
                    CompanyId = emp.CompanyId,
                    BranchId = emp.BranchId,
                    PortalId = emp.PortalId,
                    CreatedDate = emp.CreatedDate,
                    CreatedBy = emp.CreatedBy,
                    ModifiedDate = emp.ModifiedDate,
                    ModifiedBy = emp.ModifiedBy,
                    IdtypeId = emp.IdtypeId,
                    PassportNo = emp.PassportNo,
                    PassportIssuedDate = emp.PassportIssuedDate,
                    PassportIssuedDateH = emp.PassportIssuedDateH,
                    PassportExpiryDate = emp.PassportExpiryDate,
                    PassportExpiryDateH = emp.PassportExpiryDateH,
                    PassportIssuedFrom = emp.PassportIssuedFrom,
                    PassportAttachment = emp.PassportAttachment,
                    VisaCode = emp.VisaCode,
                    VisaJob = emp.VisaJob,
                    VisaDate = emp.VisaDate,
                    PassCode = emp.PassCode,
                    PassDate = emp.PassDate,
                    PassPort = emp.PassPort,
                    EmpOfficeLaborCode = emp.EmpOfficeLaborCode
                };
                expObj.empDetails = empDetails;
            }
            else
            {
                expObj.empDetails = new EmpInheritied();
            }
            expObj.empDetails = _EmpService.GetById(EmpId);

            return View(expObj);
        }

        [HttpPost]
        public async Task<ActionResult> update(EmpInheritied postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {
                var emp = _EmpService.Find(x => x.EmpId == postedData.EmpId).FirstOrDefault();

                postedData.EmpCode = emp.EmpCode;
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
                var profilePicPath = await FileHandling.UploadFile(_HostEnvironment, postedData.ProfilePicFile, _env);

                if (!String.IsNullOrWhiteSpace(profilePicPath))
                {
                    postedData.ProfilePic = profilePicPath;
                }

                result.msg = _EmpService.Update(postedData);
                if (result.msg == "")
                {
                    result.scalerVal = postedData.EmpId;
                    result.msg = _EmpService.SaveChanges();
                    if (result.msg == "")
                    {
                        var logData = new ActivityLog();
                        logData.LogDate = DateTime.Now;
                        logData.LogDetail = Newtonsoft.Json.JsonConvert.SerializeObject(postedData);
                        logData.ModuleId = null;
                        logData.NavigationId = null;
                        logData.Remarks = "Employee Updated";
                        logData.UserId = LoginSessionDetails.GetLoginUserId(HttpContext);
                        logData.UserIp = LoginSessionDetails.GetUserIp(HttpContext);
                        logData.LogType = "Update";

                        LogDetails.LogData(_activityLogService, logData);
                    }
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }
    }
}
