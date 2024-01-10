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
using System.Security.Cryptography.X509Certificates;

namespace ErpOnClick.Division.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class DivisionsController : Controller
    {
        private readonly ILogger<DivisionsController> _logger;
        private IDivisionsService _DivisionService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _EmpService;
        private IUserService _UserService;

        private dynamic expObj;
        public DivisionsController(IUserService UserService,ILogger<DivisionsController> logger, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IDivisionsService DivisionService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _DivisionService = DivisionService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();
            return View(expObj);
        }

        public IActionResult _list()
        {
            
            expObj.DivisionList = _DivisionService.dbset().Include(x=>x.DivisionHeadU).Include(x=>x.ReportingToU).Include(b => b.Branch).Include(c=>c.Company).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.EmpList = _EmpService.GetAll();

            expObj.DivisionDetails = _DivisionService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Divisions postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _DivisionService.GetById(postedData.DivisionId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "DivisionId " + postedData.DivisionId + " is already exists !";
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

                    result.msg = _DivisionService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _DivisionService.SaveChanges();
                        result.scalerVal = postedData.DivisionId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Divisions postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _DivisionService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _DivisionService.SaveChanges();
                    result.scalerVal = postedData.DivisionId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _DivisionService.Delete(Int32.Parse(id));

            result.msg = _DivisionService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
