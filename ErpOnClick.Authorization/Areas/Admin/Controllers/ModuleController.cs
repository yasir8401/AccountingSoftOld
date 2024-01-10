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

using Microsoft.AspNetCore.Hosting;
using ErpOnClick.DAL.Utilities;

namespace ErpOnClick.Authorization.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class ModuleController : Controller
    {
        private readonly ILogger<ModuleController> _logger;
        private IModuleService _ModuleService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;

        private dynamic expObj;
        public ModuleController(ILogger<ModuleController> logger, IWebHostEnvironment HostEnvironment, IBranchService BranchService, ICompanyService CompanyService, IModuleService ModuleService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _ModuleService = ModuleService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
          
            expObj.ModuleList = _ModuleService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
           
            expObj.ModuleDetails = _ModuleService.GetById(id);
            if (expObj.ModuleDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.ModuleDetails.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);

        }


        [HttpPost]
        public async Task<ActionResult> save(Modules postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _ModuleService.GetById(postedData.ModuleId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "ModuleId " + postedData.ModuleId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;
                  
                    result.msg = _ModuleService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _ModuleService.SaveChanges();
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public async Task<ActionResult> update(Modules postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;
              
                result.msg = _ModuleService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ModuleService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();
            _ModuleService.Delete(Int32.Parse(id));

       
            result.msg = _ModuleService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
