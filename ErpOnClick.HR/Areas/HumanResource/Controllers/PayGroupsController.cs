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

namespace ErpOnClick.PayGroup.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class PayGroupsController : Controller
    {
        private readonly ILogger<PayGroupsController> _logger;
        private IPayGroupsService _PayGroupService;
        private ILookupsService _LookupService;
        private IVacantJobsService _VacantJobsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private IUserService _UserService;


        private dynamic expObj;
        public PayGroupsController(IUserService UserService,ILogger<PayGroupsController> logger, IVacantJobsService VacantJobsService, IBranchService BranchService, ICompanyService CompanyService, IPayGroupsService PayGroupService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _PayGroupService = PayGroupService;
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
            expObj.PayGroupList = _PayGroupService.GetAll();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.PayGroupDetails = _PayGroupService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.PayGroups postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _PayGroupService.GetById(postedData.PayGroupId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "PayGroupId " + postedData.PayGroupId + " is already exists !";
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

                    result.msg = _PayGroupService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _PayGroupService.SaveChanges();
                        result.scalerVal = postedData.PayGroupId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.PayGroups postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _PayGroupService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _PayGroupService.SaveChanges();
                    result.scalerVal = postedData.PayGroupId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            
            _PayGroupService.Delete(Int32.Parse(id));

            result.msg = _PayGroupService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
