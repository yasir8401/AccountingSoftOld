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
using ErpOnClick.DAL.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Hosting;


namespace ErpOnClick.Grade.Areas.Admin.Controllers
{
    [Area("HumanResource")]
    [Authorize]
    public class GradesController : Controller
    {
        private readonly ILogger<GradesController> _logger;
        private IGradesService _GradeService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        public static IWebHostEnvironment _HostEnvironment;
        private IUserService _UserService;

        private dynamic expObj;
        public GradesController(IUserService UserService,ILogger<GradesController> logger, IWebHostEnvironment HostEnvironment,   IBranchService BranchService, ICompanyService CompanyService, IGradesService GradeService, ILookupsService LookupService, ILookupTypesService LookupTypesService)
        {
            _logger = logger;
            _UserService = UserService;
            _GradeService = GradeService;
            _LookupService = LookupService;
            _CompanyService = CompanyService;
        
            _BranchService = BranchService;
     
            _HostEnvironment = HostEnvironment;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.ownerTypeList = lookupList.Where(x => x.LookupTypeId == LookupTypList.OwnerType_009).ToList();
            return View(expObj);
        }

        public IActionResult _list(string model)
        {
            expObj.GradeList = _GradeService.GetAll();
            return PartialView(expObj);
        }



        public async Task<IActionResult> edit(int id)
        {
            var lookupList = _LookupService.GetAll();

            expObj.contractStatusList = lookupList.Where(x => x.LookupTypeId == LookupTypList.CONTRACT_STATUS_027).ToList();
            expObj.branchList = _BranchService.GetAll();
            expObj.companyList = _CompanyService.GetAll();
       
            expObj.GradeDetails = _GradeService.GetById(id);




            return View(expObj);
        }

     

        [HttpPost]
        public async Task<ActionResult> save(ErpOnClick.DAL.Models.Grades1 postedData)
        {
            DbResult result = new DbResult();
            if (postedData != null)
            {
                var item = _GradeService.GetById(postedData.GradeId);
                if (item != null)
                {
                    result.isError = true;
                    result.msg = "Grade " + postedData.GradeId + " is already exists !";
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

                    result.msg = _GradeService.Insert(postedData);
                    if (result.msg == "")
                    {
                        result.msg = _GradeService.SaveChanges();
                        result.scalerVal = postedData.GradeId;

                    }
                    result.isError = (result.msg != "" ? true : false);

                }
            }

            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(ErpOnClick.DAL.Models.Grades1 postedData)
        {
            DbResult result = new DbResult();

            if (postedData != null)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _GradeService.Update(postedData);
                if (result.msg == "")
                {
                    result.scalerVal = postedData.GradeId;
                    result.msg = _GradeService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            DbResult result = new DbResult();

            _GradeService.Delete(Int32.Parse(id));

            result.msg = _GradeService.SaveChanges();
            result.isError = (result.msg != "" ? true : false);
            return Json(new { result = result });
        }

    }
}
