

using ErpOnClick.AbsentProfile.Areas.Admin.Controllers;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Models;
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
    public class EmpLoansController : BaseController
    {

        private readonly ILogger<EmpLoansController> _logger;
        private ILoansService _Loanservice;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _EmpService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public EmpLoansController(IUserService UserService, ILogger<EmpLoansController> logger, IWebHostEnvironment HostEnvironment, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ILoansService Loanservice, ILookupsService LookupService, ILookupTypesService LookupTypesService)
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

        [Route("{area}/{controller}/emp/{empId}")]
        public IActionResult Index(int empId = 0)
        {
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);
            return View(expObj);
        }

        public IActionResult _list(int empId)
        {
            expObj.LoansList = _Loanservice.dbset().Include(x => x.Emp).Include(x => x.LoanStatusNavigation).Include(x => x.LoanType).Where(x => x.EmpId == empId).ToList();
            expObj.empId = empId;

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/emp/{empId}/{id=0}")]
        public IActionResult edit(int empId, int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.LoansTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Loan_Type_033).ToList();
            expObj.attachmentTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.DocumentTypes_010).ToList();
            expObj.LoansStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Loan_Status_37).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.empList = _EmpService.Find(c => c.EmpId == empId).ToList();

            expObj.LoansDetails = _Loanservice.GetById(id);
            expObj.empId = empId;
            expObj.empDetails = _EmpService.GetById(empId);

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
