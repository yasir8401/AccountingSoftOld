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

namespace ErpOnClick.AbsentProfile.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class LeavesReturnController : Controller
    {
        private readonly ILogger<LeavesReturnController> _logger;
        private ILeavesReturnService _LeavesReturnService;
        private ILeaveService _LeaveService;
        private IEmpsService _EmpsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;


        private dynamic expObj;
        public LeavesReturnController(ILogger<LeavesReturnController> logger, ILeaveService LeaveService, IBranchService BranchService, ICompanyService CompanyService, ILeavesReturnService LeavesReturnService, IEmpsService EmpsService)
        {
            _logger = logger;
            _LeavesReturnService = LeavesReturnService;
            _LeaveService = LeaveService;
            _EmpsService = EmpsService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult _list()
        {
            expObj.LeavesReturnList = _LeavesReturnService.dbset().Include(c => c.Emp).ToList();

            return PartialView(expObj);
        }



        public IActionResult edit(int id, int empid = 0, int leaveid = 0)
        {
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.employeesList = _EmpsService.dbset().Where(c => (empid != 0 && c.EmpId == empid || empid == 0)).ToList();

            expObj.LeavesReturnDetails = _LeavesReturnService.GetById(id);
            expObj.LeaveDetails = _LeaveService.GetById(leaveid);

            return PartialView(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.LeavesReturn postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _LeavesReturnService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "LeavesReturnId " + postedData.RecId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                    postedData.PortalId = 0;

                    result.msg = _LeavesReturnService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _LeavesReturnService.SaveChanges();
                        result.scalerVal = postedData.RecId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.LeavesReturn postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _LeavesReturnService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _LeavesReturnService.SaveChanges();
                    result.scalerVal = postedData.RecId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _LeavesReturnService.Delete(Int32.Parse(id));

            result.msg = _LeavesReturnService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
