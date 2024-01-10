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

namespace ErpOnClick.SubSection.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class SubSectionsController : Controller
    {
        private readonly ILogger<SubSectionsController> _logger;
        private ISubSectionService _SubSectionService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IDivisionsService _DivisionService;
        private IDepartmentService _DepartmentService;
        private ISectionService _SectionService;
        private IEmpsService _EmpService;
        private IUserService _UserService;

        private dynamic expObj;
        public SubSectionsController(IUserService UserService,ILogger<SubSectionsController> logger, IEmpsService EmpService, ISectionService SectionService, IDepartmentService DepartmentService, IVacantJobsService VacantJobsService, IBranchService BranchService, IDivisionsService DivisionService, ICompanyService CompanyService, ISubSectionService SubSectionService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _SubSectionService = SubSectionService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;
            _DepartmentService = DepartmentService;
            _SectionService = SectionService;


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
            expObj.SubSectionList = _SubSectionService.dbset().Include(x => x.ReportingToU).Include(x => x.SubSectionHeadU).ToList();
          
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
            expObj.sectionsList = _SectionService.GetAll();


            expObj.SubSectionDetails = _SubSectionService.GetById(id);
            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.SubSections postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _SubSectionService.GetById(postedData.SubSectionId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "SubSectionId " + postedData.SubSectionId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _SubSectionService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _SubSectionService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.SubSections postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _SubSectionService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _SubSectionService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _SubSectionService.Delete(Int32.Parse(id));

            result.msg = _SubSectionService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
