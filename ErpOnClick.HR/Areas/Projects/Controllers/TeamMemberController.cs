using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

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
    public class TeamMembersController : Controller
    {
        private readonly ILogger<TeamMembersController> _logger;
        private ITeamMemberService _TeamMemberService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IEmpsService _empService;
        private IProjectService _projectService;
        private ITaskService _taskService;

        private IUserService _UserService;



        private dynamic expObj;
        public TeamMembersController(IUserService UserService,ILogger<TeamMembersController> logger, ITaskService taskService, IProjectService projectService, IEmpsService empService, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, ITeamMemberService TeamMemberService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _empService = empService;
            _TeamMemberService = TeamMemberService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
            _VacantJobsService = VacantJobsService;
            _BranchService = BranchService;
            _projectService = projectService;
            _taskService = taskService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult _list()
        {
            expObj.TeamMemberList = _TeamMemberService.dbset().Include(x => x.Emp).Include(x => x.Status).Include(x => x.Task).Include(x=>x.Project).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            
            expObj.TeamMemberStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.ProjectStatus_044).ToList();
            expObj.empList = _empService.GetAll();
            expObj.parentTeamMemberList = _TeamMemberService.GetAll();
            expObj.projectList = _projectService.GetAll();
            expObj.taskList = _taskService.GetAll();
            expObj.TeamMemberDetails = _TeamMemberService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.TeamMembers postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _TeamMemberService.GetById(postedData.TeamMemberId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "TeamMemberId " + postedData.TeamMemberId + " is already exists !";
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

                    result.msg = _TeamMemberService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _TeamMemberService.SaveChanges();
                        result.scalerVal = postedData.TeamMemberId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.TeamMembers postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _TeamMemberService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _TeamMemberService.SaveChanges();
                    result.scalerVal = postedData.TeamMemberId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _TeamMemberService.Delete(Int32.Parse(id));

            result.msg = _TeamMemberService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
