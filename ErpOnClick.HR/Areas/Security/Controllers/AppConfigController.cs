using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.Main.Areas.Admin.Controllers
{
    [Area("Security")]
    [Authorize(Roles = "SuperAdmin")]
    public class AppConfigController : Controller
    {
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IAppConfigService _AppConfigServ;
        private dynamic expObj;
        private IUserService _UserService;

        public AppConfigController(IUserService UserService,IBranchService BranchService, ICompanyService CompanyService, IAppConfigService AppConfigServ)
        {
            _BranchService = BranchService;
            _UserService = UserService;
            _CompanyService = CompanyService;
            _AppConfigServ = AppConfigServ;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View(expObj);
        }

        public IActionResult _list()
        {
            expObj.AppConfigServList = _AppConfigServ.dbset().Include(c => c.Company).ToList();
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {

            expObj.AppConfigIdDetail = _AppConfigServ.GetById(id);
            expObj.BranchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(AppConfig postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 0;
                postedData.PortalId = 0;

                result.msg = _AppConfigServ.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _AppConfigServ.SaveChanges();
                }
                result.isError = (result.msg != "" ? true : false);


            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(AppConfig postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _AppConfigServ.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _AppConfigServ.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            _AppConfigServ.Delete(id);
            result.msg = _AppConfigServ.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }
    }
}
