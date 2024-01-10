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


namespace ErpOnClick.Position.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class PositionsController : Controller
    {
        private readonly ILogger<PositionsController> _logger;
        private IPositionsService _PositionService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public PositionsController(IUserService UserService,ILogger<PositionsController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IPositionsService PositionService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _UserService = UserService;
            _logger = logger;
            _PositionService = PositionService;
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

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.PositionList = _PositionService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.parentPositionList = _PositionService.GetAll();
            expObj.PositionTyplList = lookupList.Where(x => x.LookupTypeId == LookupTypList.POSITION_TYPE_025).ToList();

            expObj.PositionDetails = _PositionService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Positions postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _PositionService.GetById(postedData.PositionId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "PositionId " + postedData.PositionId + " is already exists !";
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

                    result.msg = _PositionService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _PositionService.SaveChanges();
                        result.scalerVal = postedData.PositionId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Positions postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _PositionService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _PositionService.SaveChanges();
                    result.scalerVal = postedData.PositionId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _PositionService.Delete(Int32.Parse(id));

            result.msg = _PositionService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
