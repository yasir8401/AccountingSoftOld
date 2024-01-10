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

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class RolePrivilegesController : Controller
    {
        private readonly ILogger<RolePrivilegesController> _logger;
        private IRolesPrivilegesService _RolePrivilegesService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IRoleService _RoleService;
        private IPrivilegesService _PrivilegesService;

        private dynamic expObj;
        public RolePrivilegesController(ILogger<RolePrivilegesController> logger, IPrivilegesService PrivilegesService, IRoleService RoleService, IBranchService BranchService, ICompanyService CompanyService, IRolesPrivilegesService RolePrivilegesService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _RoleService = RoleService;
            _RolePrivilegesService = RolePrivilegesService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _PrivilegesService = PrivilegesService;

            expObj = new ExpandoObject();
        }

        [Route("{area}/{controller}/Role/{RoleId}")]
        public IActionResult Index(int RoleId = 0)
        {
            expObj.RoleId = RoleId;
            expObj.RoleDetails = _RoleService.GetById(RoleId);
            return View(expObj);
        }

        public IActionResult _list(int RoleId)
        {
            expObj.RoleId = RoleId;
            expObj.RolePrivilegesList = _RolePrivilegesService.dbset().Include(c => c.Role).Include(c => c.Privilege).ToList();

            return PartialView(expObj);
        }


        [Route("{area}/{controller}/edit/Role/{RoleId}/{id=0}")]
        public IActionResult edit(int RoleId, int id)
        {
            expObj.companyList = _CompanyService.GetAll();
            expObj.privilagesList = _PrivilegesService.GetAll();
            expObj.RoleList = _RoleService.Find(c => c.RoleId == RoleId).ToList();

            expObj.RoleId = RoleId;
            expObj.RoleDetails = _RoleService.GetById(RoleId);
            if (expObj.RoleDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.RoleDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.RolePrivilegesDetails = _RolePrivilegesService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.RolePrivileges postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _RolePrivilegesService.GetById(postedData.RolePrivilegeId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "RolePrivilegeId " + postedData.RolePrivilegeId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _RolePrivilegesService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _RolePrivilegesService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.RolePrivileges postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _RolePrivilegesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _RolePrivilegesService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _RolePrivilegesService.Delete(Int32.Parse(id));

            result.msg = _RolePrivilegesService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
