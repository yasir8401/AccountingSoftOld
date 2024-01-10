using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ErpOnClick.ErpMain.Controllers.Ajax
{
    public class AjaxController : Controller
    {
        private IBranchService _BranchService;
        private IDivisionsService _divisionsService;
        private IDepartmentService _departmentService;
        private ISectionService _sectionService;
        private ISubSectionService _subSectionService;
        private IUnitService _unitService;
        private ITeamService _teamService;
        private IEmpsService _empService;
        private IEmpContractsService _empContractsService;

        public AjaxController(IBranchService BranchService, IEmpsService empService, IEmpContractsService empContractsService, IDivisionsService divisionsService, IDepartmentService departmentService, ISectionService sectionService, ISubSectionService subSectionService, IUnitService unitService, ITeamService teamService)
        {
            _BranchService = BranchService;
            _divisionsService = divisionsService;
            _departmentService = departmentService;
            _sectionService = sectionService;
            _subSectionService = subSectionService;
            _unitService = unitService;
            _teamService = teamService;
            _empService = empService;
            _empContractsService = empContractsService;


        }
        public IActionResult Index()
        {
            return View();
        }

        #region Cascasding Lists
        public JsonResult BranchCascading(int id)
        {
            var test = _BranchService.Find(c => c.CompanyId == id).Select(x => new { x.BranchId, x.BranchNameEn }).ToList();

            return Json(new { result = test });

        }
        public JsonResult DepartmentCascading(int id)
        {

            var department = _departmentService.Find(c => c.DivisionId == id).Select(x => new { x.DepartmentId, x.DepartmentNameEn }).ToList();

            return Json(new { result = department });

        }
        public JsonResult SectionCascading(int id)
        {

            var section = _sectionService.Find(c => c.DepartmentId == id).Select(x => new { x.SectionId, x.SectionNameEn }).ToList();

            return Json(new { result = section });

        }
        public JsonResult SubSectionCascading(int id)
        {

            var subSection = _subSectionService.Find(c => c.SectionId == id).Select(x => new { x.SubSectionId, x.SubSectionNameEn }).ToList();

            return Json(new { result = subSection });

        }
        public JsonResult UnitsCascading(int id)
        {

            var units = _unitService.Find(c => c.SubSectionId == id).Select(x => new { x.UnitId, x.UnitNameEn }).ToList();


            return Json(new { result = units });

        }
        public JsonResult TeamCascading(int id)
        {

            var units = _teamService.Find(c => c.UnitId == id).Select(x => new { x.TeamId, x.TeamEn }).ToList();


            return Json(new { result = units });

        }
        #endregion
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnurl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnurl);
        }
        [HttpPost]
        public JsonResult GetEmployee(string empCode)
        {
            var empJointDetails = new EmpJointDetails();
            try
            {
                var empDetails = _empService.Find(x => x.EmpCode == empCode).FirstOrDefault();
                var empContractDetails = _empContractsService.Find(x => x.EmpId == empDetails.EmpId && x.ContractStatus == "027002").FirstOrDefault();

                if (empContractDetails != null)
                {
                    empJointDetails.EmpName = empDetails.FirstNameEn + " " + empDetails.FatherNameEn;
                    empJointDetails.JobTitle = empDetails.EmpPosition;
                    empJointDetails.DepartMent = _departmentService.GetById(empContractDetails.DepartmentId).DepartmentNameEn;
                    empJointDetails.JoiningDate = empContractDetails.JoiningDate.ToString();
                    empJointDetails.ProfilePictureUrl = empDetails.ProfilePic;
                    empJointDetails.EmpId = empDetails.EmpId;

                }
                else
                {
                    return Json(new { result = "contract" });
                }

                return Json(new { result = empJointDetails });
            }
            catch (Exception ex)
            {
                return Json(new { result = "" });

            }

        }

    }
}
