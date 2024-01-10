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
using System.Security.Claims;
using ErpOnClick.ErpMain.Utitlites;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.Emp.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class EmpController : Controller
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
        public EmpController(IUserService UserService,ILogger<EmpController> logger, IPositionsService positionsService, IHostingEnvironment env, IEmpContractsPackageService empContractsPackageService, IPayGroupsService payGroupsService, IEmpContractsService empContractsService, ITeamService TeamService, ISubSectionService SubSectionService, IDivisionsService DivisionService, IDepartmentService DepartmentService, IUnitService UnitService, ISectionService SectionService, IActivityLogService activityLogService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
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

            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            return View(expObj);
        }

        public IActionResult _list(string model)
        {
            expObj.EmpList = _EmpService.dbset().Include(c => c.DesignationPosition).ToList();
            return PartialView(expObj);
        }



        public async Task<IActionResult> edit(int id)
        {
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

            var emp = _EmpService.GetById(id);
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
                    EmpOfficeLaborCode = emp.EmpOfficeLaborCode,
                    IdIssueDate = emp.IdIssueDate,
                    IdIssueDateH = emp.IdIssueDateH,
                    IdExpiryDate = emp.IdExpiryDate,
                    IdExpiryDateH = emp.IdExpiryDateH
                };
                expObj.empDetails = empDetails;
            }
            else
            {
                expObj.empDetails = new EmpInheritied();
            }
            expObj.empDetails = _EmpService.GetById(id);

            return View(expObj);
        }



        [HttpPost]
        public async Task<ActionResult> save(EmpInheritied postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                //Log Data into Json Format
                var logEmp = Newtonsoft.Json.JsonConvert.SerializeObject(postedData);
                var item = _EmpService.GetById(postedData.EmpId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Emp " + postedData.EmpId + " is already exists !";
                }
                else
                {

                    var currentYear = DateTime.Now.Year.ToString();
                    var empCode = _EmpService.GetAll().Select(x => x.EmpCode).LastOrDefault();
                    if (empCode != null)
                    {
                        var lastEmpCodeYear = empCode.Substring(0, 4);
                        var lastEmpCode = _EmpService.GetAll().Select(x => x.EmpCode).LastOrDefault();


                        if (lastEmpCodeYear != currentYear)
                        {
                            postedData.EmpCode = currentYear + 01;
                        }
                        else
                        {
                            postedData.EmpCode = ((lastEmpCode != null ? Int32.Parse(lastEmpCode) : 0) + 1).ToString();
                        }
                    }
                    else
                    {
                        postedData.EmpCode = currentYear + 01;
                    }

                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;
                    var profilePicPath = await FileHandling.UploadFile(_HostEnvironment, postedData.ProfilePicFile, _env);

                    if (!String.IsNullOrWhiteSpace(profilePicPath))
                    {
                        postedData.ProfilePic = profilePicPath;
                    }

                    result.msg = _EmpService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _EmpService.SaveChanges();
                        if (result.msg == "")
                        {
                            var logData = new ActivityLog();
                            logData.LogDate = DateTime.Now;
                            logData.LogDetail = Newtonsoft.Json.JsonConvert.SerializeObject(postedData);
                            logData.ModuleId = null;
                            logData.NavigationId = null;
                            logData.Remarks = "New Employee Is Created";
                            logData.UserId = LoginSessionDetails.GetLoginUserId(HttpContext);
                            logData.UserIp = LoginSessionDetails.GetUserIp(HttpContext);
                            logData.LogType = "Create";

                            LogDetails.LogData(_activityLogService, logData);
                        }
                        result.scalerVal = postedData.EmpId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
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

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            var empObk = _EmpService.GetById(Int32.Parse(id));
            _EmpService.Delete(Int32.Parse(id));

            result.msg = _EmpService.SaveChanges();
            if (result.msg == "")
            {
                var logData = new ActivityLog();
                logData.LogDate = DateTime.Now;
                logData.LogDetail = Newtonsoft.Json.JsonConvert.SerializeObject(empObk);
                logData.ModuleId = null;
                logData.NavigationId = null;
                logData.Remarks = "Employee Deleted";
                logData.UserId = LoginSessionDetails.GetLoginUserId(HttpContext);
                logData.UserIp = LoginSessionDetails.GetUserIp(HttpContext);
                logData.LogType = "Delete";

                LogDetails.LogData(_activityLogService, logData);
            }
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

        public IActionResult PrintList(bool empSalaryCheck)
        {
            var empListReport = new List<ReportModel>();
            var empList = _EmpService.GetAll();
            var lookupList = _LookupService.GetAll();
            var allowanceTypeLookups = lookupList.Where(x => x.LookupTypeId == LookupTypList.ALLOWANCE_TYPE_026).ToList();

            foreach (var emp in empList)
            {
                ReportModel reportEmp = new ReportModel();

                var empContract = _empContractsService.dbset().Include(x => x.Division).Include(x => x.Department).Include(x => x.Section).Include(x => x.SubSection).Include(x => x.Unit).Include(x => x.Team).Include(x => x.PayGroup).Where(x => x.EmpId == emp.EmpId && x.ContractStatus == "027002").FirstOrDefault();

                if (empContract != null)
                {
                    var allowanceTypeIds = _empContractsPackageService.Find(x => x.EmpContractId == empContract.EmpContractId).ToList();
                    var allowanceTypeIdsForSearch = allowanceTypeIds.Select(x => x.AllowanceTypeId).ToList();
                    var allowances = allowanceTypeLookups.Where(x => allowanceTypeIdsForSearch.Contains(x.LookupId)).Select(x => x.LookupNameEn).ToList();

                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("001"))
                    {
                        reportEmp.BasicSalray = allowanceTypeIds.Where(x => x.AllowanceTypeId == "001").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("002"))
                    {
                        reportEmp.Housing = allowanceTypeIds.Where(x => x.AllowanceTypeId == "002").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("003"))
                    {
                        reportEmp.Transport = allowanceTypeIds.Where(x => x.AllowanceTypeId == "003").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("004"))
                    {
                        reportEmp.Food = allowanceTypeIds.Where(x => x.AllowanceTypeId == "004").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("005"))
                    {
                        reportEmp.Other = allowanceTypeIds.Where(x => x.AllowanceTypeId == "005").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("006"))
                    {
                        reportEmp.LeavePay = allowanceTypeIds.Where(x => x.AllowanceTypeId == "006").Select(x => x.Amount).First();
                    }
                    if (allowanceTypeIds.Select(x => x.AllowanceTypeId).Contains("007"))
                    {
                        reportEmp.Indemnity = allowanceTypeIds.Where(x => x.AllowanceTypeId == "007").Select(x => x.Amount).First();
                    }



                    reportEmp.EmpName = emp.FirstNameEn + " " + emp.GrandNameEn + " " + emp.FamilyNameEn;
                    reportEmp.EmpCompany = _CompanyService.Find(x => x.CompanyId == emp.CompanyId).Select(x => x.CoNameEn).FirstOrDefault();
                    reportEmp.EmpBranch = _BranchService.Find(x => x.BranchId == emp.BranchId).Select(x => x.BranchNameEn).FirstOrDefault();
                    reportEmp.EmpDivison = (empContract.Division != null ? empContract.Division.DivisionNameEn : "");
                    reportEmp.EmpDepartment = (empContract.Department != null ? empContract.Department.DepartmentNameEn : "");
                    reportEmp.EmpSection = (empContract.Section != null ? empContract.Section.SectionNameEn : "");
                    reportEmp.EmpSubSection = (empContract.SubSection != null ? empContract.SubSection.SubSectionNameEn : "");
                    reportEmp.EmpUnit = (empContract.Unit != null ? empContract.Unit.UnitNameEn : "");
                    reportEmp.EmpTeam = (empContract.Team != null ? empContract.Team.TeamEn : "");
                    reportEmp.EmpSalaray = (empContract.PayGroup != null ? empContract.PayGroup.PayGroupNameEn : "");


                    //reportEmp.EmpAllowances = allowances;

                    empListReport.Add(reportEmp);
                }

            }

            expObj.empListReport = empListReport;
            expObj.empSalaryCheck = empSalaryCheck;
            expObj.CompanyDetail = _CompanyService.GetById(1);


            return View(expObj);
        }
        public ActionResult GeorgianToHijri(string date)
        {
            var dateHijri = DateConverter.covertToHijri(date);

            return Json(new { result = dateHijri });
        }
        public ActionResult HijriToGeogian(string date)
        {
            var dateHijri = DateConverter.covertToGregorian(date);

            return Json(new { result = dateHijri });
        }

        public IActionResult GetGeneralInfo(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var emp = _EmpService.GetById(id);
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
                    ProfilePic = emp.ProfilePic,
                    CompanyId = emp.CompanyId,
                    BranchId = emp.BranchId,
                    PortalId = emp.PortalId,
                    CreatedDate = emp.CreatedDate,
                    CreatedBy = emp.CreatedBy,
                    ModifiedDate = emp.ModifiedDate,
                    ModifiedBy = emp.ModifiedBy
                    
                };
                expObj.empDetails = empDetails;
            }
            else
            {
                expObj.empDetails = new EmpInheritied();
            }
            expObj.empDetails = _EmpService.GetById(id);

            return PartialView("_generalInfoPartial", expObj);
        }
    }
}
