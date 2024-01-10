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

namespace ErpOnClick.Section.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class SectionsController : Controller
    {
        private readonly ILogger<SectionsController> _logger;
        private ISectionService _SectionService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IDivisionsService _DivisionService;
        private IDepartmentService _DepartmentService;
        private IEmpsService _EmpService;
        private IUserService _UserService;

        private dynamic expObj;
        public SectionsController(IUserService UserService,ILogger<SectionsController> logger, IEmpsService EmpService, IDepartmentService DepartmentService, IVacantJobsService VacantJobsService, IBranchService BranchService, IDivisionsService DivisionService, ICompanyService CompanyService, ISectionService SectionService, ILookupsService LookupService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _SectionService = SectionService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;
            _DepartmentService = DepartmentService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/divisions/{divisionId}")]
        public IActionResult Index(int divisionId = 0)
        {
           
            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);
            return View(expObj);
        }

        public IActionResult _list(int divisionId)
        {
           
            expObj.divisionId = divisionId;
            expObj.SectionList = _SectionService.dbset().Include(x => x.Department).Include(x=>x.ReportingToU).Include(x=>x.SectionHeadU).Where(x => x.DivisionId == divisionId).ToList();
          
            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/divisions/{divisionId}/{id=0}")]
        public IActionResult edit(int divisionId, int id)
        {
            expObj.EmpList = _EmpService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.divisionList = _DivisionService.Find(c => c.DivisionId == divisionId).ToList();
            expObj.departmentList = _DepartmentService.GetAll();


            expObj.SectionDetails = _SectionService.GetById(id);
            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Sections postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _SectionService.GetById(postedData.SectionId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "SectionId " + postedData.SectionId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _SectionService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _SectionService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Sections postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _SectionService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _SectionService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _SectionService.Delete(Int32.Parse(id));

            result.msg = _SectionService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
