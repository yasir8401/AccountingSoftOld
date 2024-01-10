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
    public class TasksController : Controller
    {
        private readonly ILogger<TasksController> _logger;
        private ITaskService _TaskService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _empService;
        private IProjectService _projectService;
        private IUserService _UserService;


        private dynamic expObj;
        public TasksController(IUserService UserService,ILogger<TasksController> logger, IProjectService projectService, IEmpsService empService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ITaskService TaskService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _empService = empService;
            _TaskService = TaskService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _projectService = projectService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.TaskList = _TaskService.dbset().Include(x => x.AssignedToEmp).Include(x=>x.TaskStatus).Include(x => x.Project).Include(x=>x.TaskType).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.TaskTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.TaskType_045).ToList();
            expObj.TaskStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ProjectStatus_044).ToList();
            expObj.empList = _empService.GetAll();
            expObj.parentTaskList = _TaskService.GetAll();
            expObj.projectList = _projectService.GetAll();
            
            expObj.TaskDetails = _TaskService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Tasks postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _TaskService.GetById(postedData.TaskId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "TaskId " + postedData.TaskId + " is already exists !";
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

                    result.msg = _TaskService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _TaskService.SaveChanges();
                        result.scalerVal = postedData.TaskId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Tasks postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _TaskService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _TaskService.SaveChanges();
                    result.scalerVal = postedData.TaskId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _TaskService.Delete(Int32.Parse(id));

            result.msg = _TaskService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
