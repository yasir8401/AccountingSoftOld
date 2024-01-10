using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Services;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class BillsController : Controller
    {
        private readonly ILogger<BillsController> _logger;
        private IBillsService _BillsService;
        private IBillsLinesService _BillsLinesService;
        private IItemsService _ItemsService;
        private ITaxRatesService _TaxRatesService;
        private IVendorsService _vendorsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public BillsController(ILogger<BillsController> logger, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IItemsService ItemsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, IVendorsService vendorsService, IBillsLinesService BillsLinesService, IBillsService BillsService)
        {
            _logger = logger;
            this._BillsService = BillsService;
            this._BillsLinesService = BillsLinesService;
            this._vendorsService = vendorsService;
            this._ItemsService = ItemsService;
            this._TaxRatesService = TaxRatesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            this._dbcontext = dbcontext;

        }
        public IActionResult Index()
        {
            expObj.vendorsList = _vendorsService.GetAll();
            return View(expObj);
        }



        public IActionResult _list(DateTime BillDateFrom, DateTime BillDateTo, int VendorId, DateTime DueDateFrom, DateTime DueDateto)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string billdatefrom = BillDateFrom.ToString("yyyy-MM-dd");
            string billdateto = BillDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateto.ToString("yyyy-MM-dd");
          

            expObj.billMList = _BillsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (billdatefrom != "0001-01-01" && c.BillDate >= Convert.ToDateTime(billdatefrom) || billdatefrom == "0001-01-01")
                && (billdateto != "0001-01-01" && c.BillDate <= Convert.ToDateTime(billdateto) || billdateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }


        public IActionResult Edit(int id)
        {
            expObj.billNo = 0;
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.vendorsList = _vendorsService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            //expObj.CompanyDetail = _CompanyService.GetAll();
            //expObj.BranchDetail = _BranchService.GetAll();
            expObj.billMDetail = _BillsService.GetById(id);
            expObj.billDList = _BillsLinesService.Find(c => (c.BillId == id)).ToList();

            if (id == 0 && _BillsService.GetAll() != null && _BillsService.GetAll().ToList() != null && _BillsService.GetAll().ToList().Count > 0)
            {
                expObj.billNo = (_BillsService.GetAll().ToList().Max(x => x.BillId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.billNo = "00001";
            }

            return View(expObj);
        }

        public IActionResult print(int id)
        {
            expObj.billMDetail = _BillsService.GetById(id);
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.vendorsList = _vendorsService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetById(expObj.billMDetail.CompanyId);
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.billDList = _BillsLinesService.Find(c => (c.BillId == id)).ToList();

            return View(expObj);
        }


        public IActionResult PrintList(DateTime BillDateFrom, DateTime BillDateTo, int VendorId, DateTime DueDateFrom, DateTime DueDateTo)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string billdatefrom = BillDateFrom.ToString("yyyy-MM-dd");
            string billdateto = BillDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateTo.ToString("yyyy-MM-dd");

            expObj.BillDateFrom = BillDateFrom.ToString("yyyy-MM-dd");
            expObj.BillDateTo = BillDateTo.ToString("yyyy-MM-dd");
            if (VendorId == 0)
            {
                expObj.VendorId = "All";
            }
            else
            {
                expObj.VendorId = _vendorsService.GetById(VendorId).VendorNameEn;
            }
            expObj.DueDateFrom = DueDateFrom.ToString("yyyy-MM-dd");
            expObj.DueDateTo = DueDateTo.ToString("yyyy-MM-dd");

            expObj.billMList = _BillsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (billdatefrom != "0001-01-01" && c.BillDate >= Convert.ToDateTime(billdatefrom) || billdatefrom == "0001-01-01")
                && (billdateto != "0001-01-01" && c.BillDate <= Convert.ToDateTime(billdateto) || billdateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return View(expObj);
        }



        [HttpPost]
        public IActionResult Save(BillsExtented Bill)
        {
            DbResult result = new DbResult();
            var billMId = 0;
            int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == Bill.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

            
                if (Bill != null)
                {
                    Bills BillM = new Bills();
                    BillM.CreatedBy = 0;
                    BillM.CreatedDate = System.DateTime.Now;
                    BillM.PortalId = 0;
                    BillM.CompanyId = 1;
                    BillM.BranchId = 1;
                    BillM.BillNo = Bill.BillNo;
                    BillM.BillNo = Bill.BillNo;
                    BillM.VendorId = Bill.VendorId;
                    BillM.DueDate = Bill.DueDate;
                    BillM.BillDate = Bill.BillDate;
                    BillM.TaxRateId = taxrateid;
                    BillM.Note = Bill.Note;
                    BillM.SubTotal = Bill.SubTotal;
                    BillM.TotalTax = Bill.TotalTax;
                    BillM.Total = Bill.Total;
                    result.msg = _BillsService.Insert(BillM);
                    if (result.msg == "")
                    {
                        result.msg = _BillsService.SaveChanges();
                        billMId = BillM.BillId;
                        if (Bill.BillD != null)
                        {
                            foreach (var item in Bill.BillD)
                            {
                                item.BillId = billMId;
                                //int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == item.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                                //item.TaxRateId = Dtaxrateid;
                                item.PortalId = 0;
                                item.CreatedBy = 0;
                                item.CompanyId = 1;
                                item.BranchId = 1;
                                item.CreatedDate = System.DateTime.Now;
                                result.msg = _BillsLinesService.Insert(item);
                                if (result.msg == "")
                                {
                                    result.msg = _BillsLinesService.SaveChanges();
                                }
                            }
                        }
                        result.isError = (result.msg != "" ? true : false);
                    }
                
            }
            return Json(new { result = result });
        }



        [HttpPost]
        public ActionResult Update(BillsExtented billViewModel)
        {
            DbResult result = new DbResult();
            if (billViewModel != null)
            {
                if (billViewModel.BillId != 0)
                {
                    Bills BillMDetail = _BillsService.GetById(billViewModel.BillId);
                    BillMDetail.ModifiedDate = System.DateTime.Now;
                    BillMDetail.ModifiedBy = 1;
                    BillMDetail.VendorId = billViewModel.VendorId;
                    BillMDetail.BillDate = billViewModel.BillDate;
                    BillMDetail.DueDate = billViewModel.DueDate;
                    BillMDetail.Note = billViewModel.Note;
                    int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == billViewModel.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

                    BillMDetail.TaxRateId = taxrateid;
                    BillMDetail.TotalTax = billViewModel.TotalTax;
                    BillMDetail.SubTotal = billViewModel.SubTotal;
                    BillMDetail.Total = billViewModel.Total;
                    if (billViewModel.BillD.Count != 0)
                    {
                        foreach (var i in billViewModel.BillD)
                        {
                            if(i.CreatedDate == null && i.CreatedBy == null)
                            {
                                i.CompanyId = 1;
                                i.BranchId = 1;
                                i.PortalId = 0;
                                i.CreatedBy = 0;
                                i.CreatedDate = System.DateTime.Now;
                            }
                            //int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == i.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                            //i.TaxRateId = Dtaxrateid;
                            i.BillId = billViewModel.BillId;
                        }
                        _dbcontext.BillsLines.UpdateRange(billViewModel.BillD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in billViewModel.BillD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.BillsLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();
                    
                    _dbcontext.Bills.Update(BillMDetail);
                    _dbcontext.SaveChanges();
                }
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            if (id != 0)
            {
                Bills obj = _dbcontext.Bills.Find(id);
                var BillDList = _dbcontext.BillsLines.Where(x => x.BillId == id).ToList();
                _dbcontext.BillsLines.RemoveRange(BillDList);
                _dbcontext.SaveChanges();


                _dbcontext.Bills.Remove(obj);
                _dbcontext.SaveChanges();
                result.msg = "deleted";
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnurl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnurl);
        }

    }
}
