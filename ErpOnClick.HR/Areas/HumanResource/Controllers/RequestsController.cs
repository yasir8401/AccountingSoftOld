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
    public class RequestsController : Controller
    {
        private readonly ILogger<RequestsController> _logger;
        private IRequestsService _RequestsService;
        private IEmpsService _EmpsService;
        private IBranchService _BranchService;
        private ICompanyService  _CompanyService;
        private ILookupsService _LookupsService;
        private ILookupTypesService _LookupTypesService;
        private IUserService _UserService;


        private dynamic expObj;
        public RequestsController(IUserService UserService,ILogger<RequestsController> logger, ILookupTypesService LookupTypesService, ILookupsService LookupsService, IBranchService BranchService, ICompanyService CompanyService, IRequestsService RequestsService, IEmpsService EmpsService)
        {
            _logger = logger;
            _UserService = UserService;
            _LookupsService = LookupsService;
            _LookupTypesService = LookupTypesService;
            _RequestsService = RequestsService;
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
            var lookupList = _LookupsService.GetAll();

            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();

            expObj.RequestsList = _RequestsService.dbset().Include(c=>c.Emp).ToList();
          
            return PartialView(expObj);
        }



        public IActionResult edit(int id)
        {
            var lookupList = _LookupsService.GetAll();

            expObj.RequestStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ApplicationStatus_007).ToList();
            expObj.RequestType = lookupList.Where(x => x.LookupTypeId == LookupTypList.RequestType_042).ToList();

            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();

            expObj.employeesList = _EmpsService.GetAll();

            expObj.RequestDetails = _RequestsService.GetById(id);


            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(ErpOnClick.DAL.Models.Requests postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {

                var item = _RequestsService.GetById(postedData.RecId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "RequestId " + postedData.RecId + " is already exists !";
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

                    result.msg = _RequestsService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _RequestsService.SaveChanges();
                        result.scalerVal = postedData.RecId;
                       
                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Requests postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _RequestsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _RequestsService.SaveChanges();
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

            _RequestsService.Delete(Int32.Parse(id));

            result.msg = _RequestsService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
