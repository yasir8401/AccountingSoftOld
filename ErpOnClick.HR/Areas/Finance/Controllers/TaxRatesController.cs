using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class TaxRatesController : Controller
    {
        private readonly ILogger<TaxRatesController> _logger;
        private ITaxRatesService _TaxRatesService;
        private ILookupsService _LookupService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public TaxRatesController(IUserService UserService,ILogger<TaxRatesController> logger, ICompanyService CompanyService, IBranchService BranchService, ILookupsService LookupTypesService, ITaxRatesService TaxRatesService)
        {
            _logger = logger;
            _UserService = UserService;
            _TaxRatesService = TaxRatesService;
            _LookupService = LookupTypesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;

            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();
            return View(expObj);
        }

        public IActionResult _list(string Status)
        {
            expObj.TaxRatesIdList = _TaxRatesService.dbset()
                .Where(c =>  (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(string Status)
        {
            expObj.TaxRatesIdList = _TaxRatesService.dbset()
                .Where(c =>  (Status != null && c.ActiveStatus == Status || Status == null))
                .ToList();

            if(Status == null)
            {
                expObj.Status = "All";
            }
            else
            {
                expObj.Status = Status;

            }

            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.ActiveStatus = lookupList.Where(x => x.LookupTypeId == LookupTypList.ActiveStatus_015).ToList();
            expObj.IdDetail = _TaxRatesService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(TaxRates postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                var EmpId = Convert.ToInt32(User.Identity.Name);
                var user = _UserService.dbset().Where(c => c.UserId == EmpId).FirstOrDefault();
                postedData.CompanyId = user.CompanyId;
                postedData.BranchId = user.BranchId;
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;

                result.msg = _TaxRatesService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _TaxRatesService.SaveChanges();
                    result.scalerVal = postedData.TaxRateId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(TaxRates postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _TaxRatesService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _TaxRatesService.SaveChanges();
                    result.scalerVal = postedData.TaxRateId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();
            if (id != 0)
            {
                _TaxRatesService.Delete(id);
                result.msg = _TaxRatesService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
