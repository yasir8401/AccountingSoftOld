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


namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class RoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        private IRoleService _RoleService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;


        private dynamic expObj;
        public RoleController(ILogger<RoleController> logger, IBranchService BranchService, ICompanyService CompanyService, IRoleService RoleService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _RoleService = RoleService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.RoleList = _RoleService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();


            expObj.RoleDetails = _RoleService.GetById(id);
            if (expObj.RoleDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.RoleDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Roles postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _RoleService.GetById(postedData.RoleId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "RoleId " + postedData.RoleId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _RoleService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _RoleService.SaveChanges();
                        result.scalerVal = postedData.RoleId;
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Roles postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _RoleService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _RoleService.SaveChanges();
                    result.scalerVal = postedData.RoleId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _RoleService.Delete(Int32.Parse(id));

            result.msg = _RoleService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
