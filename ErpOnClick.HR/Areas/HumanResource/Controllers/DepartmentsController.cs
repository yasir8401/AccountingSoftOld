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
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.ErpMain.Areas.Admin
{
    [Area("HumanResource")]
    [Authorize]
    public class DepartmentsController : Controller
    {
        private readonly ILogger<DepartmentsController> _logger;
        private IDepartmentService _DepartmentService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IDivisionsService _DivisionService;
        private IEmpsService _EmpService;
        private IUserService _UserService;

        private dynamic expObj;

        public DepartmentsController(IUserService UserService,ILogger<DepartmentsController> logger, IEmpsService EmpService, IVacantJobsService VacantJobsService, IBranchService BranchService, IDivisionsService DivisionService, ICompanyService CompanyService, IDepartmentService DepartmentService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _EmpService = EmpService;
            _DepartmentService = DepartmentService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _DivisionService = DivisionService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/divisions/{divisionId}")]
        public IActionResult Index(int divisionId = 0)
        {
            var lookupList = _LookupService.GetAll();
            expObj.deptList = lookupList.Where(x => x.LookupTypeId == LookupTypList.Departments_001).ToList();

            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);
            return View(expObj);
        }

        public IActionResult _list(int divisionId)
        {
            expObj.divisionId = divisionId;
     
            expObj.DepartmentList = _DepartmentService.dbset().Include(x=>x.ReportingToU).Include(x=>x.DepartmentHeadU).Include(x => x.Division).Where(x => x.DivisionId == divisionId).ToList();
        

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/divisions/{divisionId}/{id=0}")]
        public IActionResult edit(int divisionId, int id)
        {
            expObj.EmpList = _EmpService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.divisionList = _DivisionService.Find(c => c.DivisionId == divisionId).ToList();


            expObj.DepartmentDetails = _DepartmentService.GetById(id);
            expObj.divisionId = divisionId;
            expObj.divisionDetails = _DivisionService.GetById(divisionId);

            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Departments postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _DepartmentService.GetById(postedData.DepartmentId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "DepartmentId " + postedData.DepartmentId + " is already exists !";
                }
                else
                {
                    var EmpId = Convert.ToInt32(User.Identity.Name);
                    var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                    postedData.CompanyId = user.CompanyId;
                    postedData.BranchId = user.BranchId;
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  

                    result.msg = _DepartmentService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _DepartmentService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Departments postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _DepartmentService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _DepartmentService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _DepartmentService.Delete(Int32.Parse(id));

            result.msg = _DepartmentService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
