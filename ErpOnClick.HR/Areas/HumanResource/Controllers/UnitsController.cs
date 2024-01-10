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

namespace ErpOnClick.Unit.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class UnitsController : Controller
    {
        private readonly ILogger<UnitsController> _logger;
        private IUnitService _UnitService;
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
        public UnitsController(IUserService UserService,ILogger<UnitsController> logger, IEmpsService EmpService, ISubSectionService SubSectionService, ISectionService SectionService, IDepartmentService DepartmentService, IVacantJobsService VacantJobsService, IBranchService BranchService, IDivisionsService DivisionService, ICompanyService CompanyService, IUnitService UnitService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _UnitService = UnitService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;
            _DepartmentService = DepartmentService;
            _SectionService = SectionService;
            _SubSectionService = SubSectionService;

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
            expObj.UnitList = _UnitService.dbset().Include(x => x.ReportingToU).Include(x => x.UnitHeadU).ToList();
          
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
            expObj.subSectionsList = _SubSectionService.GetAll();


            expObj.UnitDetails = _UnitService.GetById(id);
            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Units postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _UnitService.GetById(postedData.UnitId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "UnitId " + postedData.UnitId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _UnitService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _UnitService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Units postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _UnitService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _UnitService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _UnitService.Delete(Int32.Parse(id));

            result.msg = _UnitService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
