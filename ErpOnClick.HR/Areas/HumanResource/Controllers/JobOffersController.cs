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
using System.IO;
using System.Web;
using Microsoft.AspNetCore.StaticFiles;
using WordToPDF;
using Microsoft.Office.Interop.Word;
using System.Net;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class JobOffersController : Controller
    {
        private readonly ILogger<JobOffersController> _logger;
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
        private IJobOffersService _JobOfferService;
        private ERPonClickContext _context;

        string wwwRootPath = "";
        private dynamic expObj;
        public JobOffersController(IUserService UserService, ILogger<JobOffersController> logger, IPositionsService positionsService, IHostingEnvironment env, IEmpContractsPackageService empContractsPackageService, IPayGroupsService payGroupsService, IEmpContractsService empContractsService, ITeamService TeamService, ISubSectionService SubSectionService, IDivisionsService DivisionService, IDepartmentService DepartmentService, IUnitService UnitService, ISectionService SectionService, IActivityLogService activityLogService, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IEmpsService EmpService, ILookupsService LookupService, ILookupTypesService LookupTypesService, IJobOffersService jobOffersService, ERPonClickContext eRPonClickContext)
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
            _JobOfferService = jobOffersService;
            _context = eRPonClickContext;

            wwwRootPath = HostEnvironment.WebRootPath;
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
            expObj.JobOffersList = _JobOfferService.GetAll().ToList();
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
            expObj.departmentList = _DepartmentService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            var jobOfferDetails = _JobOfferService.GetById(id);

            expObj.JobOfferDetails = jobOfferDetails;

            return View(expObj);
        }



        [HttpPost]
        public async Task<ActionResult> save(JobOffers postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                //Log Data into Json Format
                var logEmp = Newtonsoft.Json.JsonConvert.SerializeObject(postedData);
                var item = _EmpService.GetById(postedData.JobOfferId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "JobOfferId " + postedData.JobOfferId + " is already exists !";
                }
                else
                {

                    var currentYear = DateTime.Now.Year.ToString();
                    var empCode = _EmpService.GetAll().Select(x => x.EmpCode).LastOrDefault();

                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;


                    result.msg = _JobOfferService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _JobOfferService.SaveChanges();
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
                        result.scalerVal = postedData.JobOfferId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(JobOffers postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {
                var emp = _JobOfferService.Find(x => x.JobOfferId == postedData.JobOfferId).FirstOrDefault();

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _JobOfferService.Update(postedData);
                if (result.msg == "")
                {
                    result.scalerVal = postedData.JobOfferId;
                    result.msg = _JobOfferService.SaveChanges();
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

            var empObk = _JobOfferService.GetById(Int32.Parse(id));
            _JobOfferService.Delete(Int32.Parse(id));

            result.msg = _JobOfferService.SaveChanges();
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

        public IActionResult PrintProposal(int JobOfferId)
        {

            try
            {
                string strFileName = wwwRootPath + "\\JobOffers\\" + "SAMPLE_OFFER.docx";
                string strFileNamePDF = wwwRootPath + "\\JobOffers\\" + "SAMPLE_OFFER.pdf";
                var jobOfferDetail = _JobOfferService.GetById(JobOfferId);
                var department = _DepartmentService.Find(x => x.DepartmentId == Convert.ToInt32(jobOfferDetail.Department)).FirstOrDefault();


                var values = new Dictionary<string, string>
                     {
                       {"CandidateName", jobOfferDetail.FirstNameEn + " " + jobOfferDetail.FatherNameEn + " " + jobOfferDetail.FamilyNameEn},
                       { "JobTitleName", jobOfferDetail.JobTitle },
                       { "JoiningDateValue", jobOfferDetail.ExpectingJoiningDate.ToString() },
                       { "DepartmentValue", department.DepartmentNameEn },
                       { "EmployementTypeValue", jobOfferDetail.EmployementType == "Full" ? "Full Time" : jobOfferDetail.EmployementType == "Part" ? "Part Time" : jobOfferDetail.EmployementType == "Remote" ? "Remote" : jobOfferDetail.EmployementType == "Contract" ? "Contract Base" : "Project Base" },
                       {  "BasicSalaryValue", jobOfferDetail.BasicSalary.ToString() },
                       { "HousingAllowance", jobOfferDetail.HousingAllowance.ToString() },
                       { "TicketAllowance", jobOfferDetail.TicketAllowance.ToString() },
                       { "TransportAllowance", jobOfferDetail.TransportationAllowance.ToString() },
                       { "GosiDeduction", jobOfferDetail.GosiDeduction.ToString() },
                       { "SanedDeduction", jobOfferDetail.SanedDeduction.ToString() },
                       { "TotalSalary", jobOfferDetail.TotalSalary.ToString() },
                       { "BonusValue", jobOfferDetail.Bonus },
                       { "ProbationValue", jobOfferDetail.ProbationPeriod.ToString() + " Months" },
                       { "ManagerName", jobOfferDetail.ReportingManager }
                      };
                IDocumentGenerator genereator = new WordGenerator();
                var result = genereator.GenerateDocument(values, strFileName);

                using (var fs = new FileStream(strFileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(result, 0, result.Length);
                }

                return Json(new { result = strFileName });

                //return File(result, ("application/vnd.openxmlformats-officedocument.wordprocessingml.document"), "WordTest.docx");


                //Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                //Word2Pdf objWorPdf = new Word2Pdf();
                //object filename = wwwRootPath + "\\Files\\" + "SAMPLE_OFFER.docx";
                //string strFileName = wwwRootPath + "\\Files\\" + "SAMPLE_OFFER.docx";
                //string strFileNamePDF = wwwRootPath + "\\Files\\" + "SAMPLE_OFFER.pdf";


                //object confirmConversions = Type.Missing;
                //object readOnly = Type.Missing;
                //object addToRecentFiles = Type.Missing;
                //object passwordDoc = Type.Missing;
                //object passwordTemplate = Type.Missing;
                //object revert = Type.Missing;
                //object writepwdoc = Type.Missing;
                //object writepwTemplate = Type.Missing;
                //object format = Type.Missing;
                //object encoding = Type.Missing;
                //object visible = Type.Missing;
                //object openRepair = Type.Missing;
                //object docDirection = Type.Missing;
                //object notEncoding = Type.Missing;
                //object xmlTransform = Type.Missing;

                //Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(ref filename, ref confirmConversions, ref readOnly, ref addToRecentFiles, ref passwordDoc, ref passwordTemplate,
                //    ref revert, ref writepwdoc, ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,
                //    ref docDirection, ref notEncoding, ref xmlTransform);


                //var jobOfferDetail = _JobOfferService.GetById(JobOfferId);
                //var department = _DepartmentService.Find(x => x.DepartmentId == Convert.ToInt32(jobOfferDetail.Department)).FirstOrDefault();


                //ReplaceBookmarkText(doc, "CandidateName", jobOfferDetail.FirstNameEn + " " + jobOfferDetail.FatherNameEn + " " + jobOfferDetail.FamilyNameEn);
                //ReplaceBookmarkText(doc, "JobTitleName", jobOfferDetail.JobTitle);
                //ReplaceBookmarkText(doc, "JoiningDateValue", jobOfferDetail.ExpectingJoiningDate.ToString());
                //ReplaceBookmarkText(doc, "DepartmentValue", department.DepartmentNameEn);
                //ReplaceBookmarkText(doc, "EmployementTypeValue", jobOfferDetail.EmployementType);
                //ReplaceBookmarkText(doc, "BasicSalaryValue", jobOfferDetail.BasicSalary.ToString());
                //ReplaceBookmarkText(doc, "HousingAllowance", jobOfferDetail.HousingAllowance.ToString());
                //ReplaceBookmarkText(doc, "TicketAllowance", jobOfferDetail.TicketAllowance.ToString());
                //ReplaceBookmarkText(doc, "TransportAllowance", jobOfferDetail.TransportationAllowance.ToString());
                //ReplaceBookmarkText(doc, "GosiDeduction", jobOfferDetail.GosiDeduction.ToString());
                //ReplaceBookmarkText(doc, "SanedDeduction", jobOfferDetail.SanedDeduction.ToString());
                //ReplaceBookmarkText(doc, "TotalSalary", jobOfferDetail.TotalSalary.ToString());
                //ReplaceBookmarkText(doc, "BonusValue", jobOfferDetail.Bonus);
                //ReplaceBookmarkText(doc, "ProbationValue", jobOfferDetail.ProbationPeriod.ToString() + " Months");
                //ReplaceBookmarkText(doc, "ManagerName", jobOfferDetail.ReportingManager);

                //doc.SaveAs2(strFileNamePDF, WdSaveFormat.wdFormatPDF);


                //var stream = new FileStream(strFileNamePDF, FileMode.Open);
                //return new FileStreamResult(stream, "application/pdf");

                //return File(strFileNamePDF, "text/plain", "Job Proposal.pdf");
                //return File(strFileNamePDF, "text/html");

                //return Json(new { result = strFileNamePDF });

            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                _logger.LogError(ex.StackTrace);
                return null;
            }
        }

        //private void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc, string bookmarkName, string text)
        //{
        //    if (doc.Bookmarks.Exists(bookmarkName))
        //    {
        //        Object name = bookmarkName;
        //        Microsoft.Office.Interop.Word.Range range =
        //            doc.Bookmarks.get_Item(ref name).Range;

        //        range.Text = text;
        //        object newRange = range;
        //        doc.Bookmarks.Add(bookmarkName, ref newRange);
        //    }
        //}


    }
}
