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
using ErpOnClick.ErpMain.Models;
using ErpOnClick.DAL.Utilities;
using Microsoft.AspNetCore.Hosting;

namespace ErpOnClick.AbsentProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")] 
    [Authorize]
    public class LoansController : Controller
    {
        private readonly ILogger<LoansController> _logger;
        private ILoansService _Loanservice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _EmpService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public LoansController(IUserService UserService,ILogger<LoansController> logger, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ILoansService Loanservice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _Loanservice = Loanservice;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _EmpService = EmpService;
            _HostEnvironment = HostEnvironment;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.LoansList = _Loanservice.dbset().Include(x => x.Emp).Include(x => x.LoanStatusNavigation).Include(x => x.LoanType).ToList();


            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.LoansTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Loan_Type_033).ToList();
            expObj.attachmentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).ToList();
            expObj.LoansStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Loan_Status_37).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.GetAll();

            expObj.LoansDetails = _Loanservice.GetById(id);
      

            return View(expObj);
        }


        [HttpPost]
        public async Task<ActionResult> save(LoansInherited postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _Loanservice.GetById(postedData.LoanId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Loans Id " + postedData.LoanId + " is already exists !";
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
                    result.msg = _Loanservice.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _Loanservice.SaveChanges();
                        result.scalerVal = postedData.LoanId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(LoansInherited postedData)
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

                result.msg = _Loanservice.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _Loanservice.SaveChanges();
                    result.scalerVal = postedData.LoanId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _Loanservice.Delete(Int32.Parse(id));

            result.msg = _Loanservice.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
