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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class PaymentsController : Controller
    {
        private readonly ILogger<PaymentsController> _logger;
        private IAccountsService _AccountsService;
        private IUserService _UserService;

        private IPaymentsService _PaymentsService;
        private IVendorsService _VendorsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;

        private dynamic expObj;
        public PaymentsController(IUserService UserService,ILogger<PaymentsController> logger, IAccountsService AccountsService, IVendorsService VendorsService, ICompanyService CompanyService, IBranchService BranchService, IPaymentsService PaymentsService)
        {
            _logger = logger;
            _UserService = UserService;
            _AccountsService = AccountsService;
            _VendorsService = VendorsService;
            _PaymentsService = PaymentsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.vendorsList = _VendorsService.GetAll();
            return View(expObj);
        }


        public IActionResult _list(DateTime PaymentsDateFrom, DateTime PaymentsDateTo, int VendorId)
        {
            string paymentsdatefrom = PaymentsDateFrom.ToString("yyyy-MM-dd");
            string paymentsdateto = PaymentsDateTo.ToString("yyyy-MM-dd");
            expObj.PaymentIdList = _PaymentsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (paymentsdatefrom != "0001-01-01" && c.PaymentDate >= Convert.ToDateTime(paymentsdatefrom) || paymentsdatefrom == "0001-01-01")
                && (paymentsdateto != "0001-01-01" && c.PaymentDate <= Convert.ToDateTime(paymentsdateto) || paymentsdateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult edit(int id)
        {
            expObj.paymentNo = 0;
            expObj.Accounts = _AccountsService.GetAll();

            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.Vendors = _VendorsService.GetAll();
            expObj.IdDetail = _PaymentsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }

            if (id == 0 && _PaymentsService.GetAll() != null && _PaymentsService.GetAll().ToList() != null && _PaymentsService.GetAll().ToList().Count > 0)
            {
                expObj.paymentNo = (_PaymentsService.GetAll().ToList().Max(x => x.PaymentId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.paymentNo = "00001";
            }

            return View(expObj);
        }

        public IActionResult PrintList(DateTime PaymentsDateFrom, DateTime PaymentsDateTo, int VendorId)
        {
            string paymentsdatefrom = PaymentsDateFrom.ToString("yyyy-MM-dd");
            string paymentsdateto = PaymentsDateTo.ToString("yyyy-MM-dd");

            expObj.PaymentsDateFrom = PaymentsDateFrom.ToString("yyyy-MM-dd");
            expObj.PaymentsDateTo = PaymentsDateTo.ToString("yyyy-MM-dd");
            if (VendorId == 0)
            {
                expObj.VendorId = "All";
            }
            else
            {
                expObj.VendorId = _VendorsService.GetById(VendorId).VendorNameEn;
            }

            expObj.PaymentIdList = _PaymentsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (paymentsdatefrom != "0001-01-01" && c.PaymentDate >= Convert.ToDateTime(paymentsdatefrom) || paymentsdatefrom == "0001-01-01")
                && (paymentsdateto != "0001-01-01" && c.PaymentDate <= Convert.ToDateTime(paymentsdateto) || paymentsdateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();

            return PartialView(expObj);
        }

        [HttpPost]
        public ActionResult save(Payments postedData)
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

                result.msg = _PaymentsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _PaymentsService.SaveChanges();
                    result.scalerVal = postedData.PaymentId;
                }
                result.isError = (result.msg != "" ? true : false);

            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Payments postedData)
        {

            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {

                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;


                result.msg = _PaymentsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _PaymentsService.SaveChanges();
                    result.scalerVal = postedData.PaymentId;
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
                _PaymentsService.Delete(id);
                result.msg = _PaymentsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }

    }
}
