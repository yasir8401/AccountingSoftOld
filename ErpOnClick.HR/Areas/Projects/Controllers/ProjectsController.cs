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

namespace ErpOnClick.ErpMain.Areas.Projects.Controllers
{
    [Area("Projects")]
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly ILogger<ProjectsController> _logger;
        private IProjectService _ProjectService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _empService;
        private IUserService _UserService;


        private dynamic expObj;
        public ProjectsController(IUserService UserService,ILogger<ProjectsController> logger, IEmpsService empService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IProjectService ProjectService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _empService = empService;
            _ProjectService = ProjectService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.ProjectList = _ProjectService.dbset().Include(x=>x.ProjectManagerEmp).Include(x=>x.ProjectType).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.projectTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ProjectType_043).ToList();
            expObj.projectStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ProjectStatus_044).ToList();
            
            expObj.empList = _empService.GetAll();
            expObj.parentProjectList = _ProjectService.GetAll();
            expObj.ProjectDetails = _ProjectService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Projects postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _ProjectService.GetById(postedData.ProjectId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "ProjectId " + postedData.ProjectId + " is already exists !";
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

                    result.msg = _ProjectService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _ProjectService.SaveChanges();
                        result.scalerVal = postedData.ProjectId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Projects postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _ProjectService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ProjectService.SaveChanges();
                    result.scalerVal = postedData.ProjectId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _ProjectService.Delete(Int32.Parse(id));

            result.msg = _ProjectService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
