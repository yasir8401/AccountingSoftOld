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
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private IUserService _UserService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IEmpsService _empService;
        private ERPonClickContext _db;

        private dynamic expObj;
        public UserController(ILogger<UserController> logger, IBranchService BranchService, ICompanyService CompanyService, IUserService UserService, ILookupTypesService LookupTypesService, IEmpsService EmpService, ERPonClickContext db)
        {
            _logger = logger;
            _UserService = UserService;
            _CompanyService = CompanyService;
            _BranchService = BranchService;
            _empService = EmpService;
            _db = db;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(string JobDepartmentId)
        {
            expObj.UserList = _UserService.GetAll();

            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            //expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
            expObj.employeeList = _empService.GetAll();

            expObj.UserDetails = _UserService.GetById(id);

            if (expObj.UserDetails != null)
            {
                int compnayid = Convert.ToInt32(expObj.UserDetails.CompanyId);
                int empId = Convert.ToInt32(expObj.UserDetails.EmpId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
                expObj.employeeList = _empService.Find(x => x.EmpId == empId).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
                expObj.employeeList = _db.Emp.Where(x => x.Users.Count < 1).ToList(); 
                //expObj.employeeList = _db.Emp.Include(x => x.Users).Where(x => x.Users == null).ToList(); //_empService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Users postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _UserService.GetById(postedData.UserId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "UserId " + postedData.UserId + " is already exists !";
                }
                else
                {
                    postedData.CreatedDate = System.DateTime.Now;
                    postedData.CreatedBy = 0;


                    result.msg = _UserService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _UserService.SaveChanges();
                        result.scalerVal = postedData.UserId;
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Users postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _UserService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _UserService.SaveChanges();
                    result.scalerVal = postedData.UserId;
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _UserService.Delete(Int32.Parse(id));

            result.msg = _UserService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
