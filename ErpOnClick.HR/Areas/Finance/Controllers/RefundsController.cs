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
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class RefundsController : Controller
    {
        private readonly ILogger<RefundsController> _logger;
        private IRefundsService _RefundsService;
        private IRefundsLinesService _RefundsLinesService;
        private IItemsService _ItemsService;
        private ITaxRatesService _TaxRatesService;
        private IVendorsService _vendorsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public RefundsController(ILogger<RefundsController> logger, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IItemsService ItemsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, IVendorsService vendorsService, IRefundsLinesService RefundsLinesService, IRefundsService RefundsService)
        {
            _logger = logger;
            this._RefundsService = RefundsService;
            this._RefundsLinesService = RefundsLinesService;
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


        public IActionResult _list(DateTime RefundDateFrom, DateTime RefundDateTo, int VendorId, DateTime DueDateFrom, DateTime DueDateTo)
        {
            

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string refunddatefrom = RefundDateFrom.ToString("yyyy-MM-dd");
            string refunddateto = RefundDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateTo.ToString("yyyy-MM-dd");


            expObj.refundMList = _RefundsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (refunddatefrom != "0001-01-01" && c.RefundDate >= Convert.ToDateTime(refunddatefrom) || refunddatefrom == "0001-01-01")
                && (refunddateto != "0001-01-01" && c.RefundDate <= Convert.ToDateTime(refunddateto) || refunddateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();

            

            return PartialView(expObj);
        }




        public IActionResult Edit(int id)
        {
            expObj.refundNo = 0;
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.vendorsList = _vendorsService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            //expObj.CompanyDetail = _CompanyService.GetAll();
            //expObj.BranchDetail = _BranchService.GetAll();
            expObj.refundMDetail = _RefundsService.GetById(id);
            expObj.refundDList = _RefundsLinesService.Find(c => (c.RefundId == id)).ToList();


            if (id == 0 && _RefundsService.GetAll() != null && _RefundsService.GetAll().ToList() != null && _RefundsService.GetAll().ToList().Count > 0)
            {
                expObj.refundNo = (_RefundsService.GetAll().ToList().Max(x => x.RefundId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.refundNo = "00001";
            }

            return View(expObj);
        }

        public IActionResult print(int id)
        {
            expObj.refundMDetail = _RefundsService.GetById(id);
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.vendorsList = _vendorsService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetById(expObj.refundMDetail.CompanyId);
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.refundDList = _RefundsLinesService.Find(c => (c.RefundId == id)).ToList();

            return View(expObj);
        }


        public IActionResult PrintList(DateTime RefundDateFrom, DateTime RefundDateTo, int VendorId, DateTime DueDateFrom, DateTime DueDateTo)
        {
            string refunddatefrom = RefundDateFrom.ToString("yyyy-MM-dd");
            string refunddateto = RefundDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateTo.ToString("yyyy-MM-dd");

            expObj.RefundDateFrom = RefundDateFrom.ToString("yyyy-MM-dd");
            expObj.RefundDateTo = RefundDateTo.ToString("yyyy-MM-dd");
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

            expObj.refundMList = _RefundsService.dbset()
                .IncludeOptimized(c => c.Vendor)
                .Where(c => (c.VendorId == VendorId || VendorId == 0)
                && (refunddatefrom != "0001-01-01" && c.RefundDate >= Convert.ToDateTime(refunddatefrom) || refunddatefrom == "0001-01-01")
                && (refunddateto != "0001-01-01" && c.RefundDate <= Convert.ToDateTime(refunddateto) || refunddateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return View(expObj);
        }




        [HttpPost]
        public IActionResult Save(RefundsExtented Refund)
        {
            DbResult result = new DbResult();
            var refundMId = 0;
            int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == Refund.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

                if (Refund != null)
                {
                    Refunds RefundM = new Refunds();
                    RefundM.CreatedBy = 0;
                    RefundM.CreatedDate = System.DateTime.Now;
                    RefundM.PortalId = 0;
                    RefundM.CompanyId = 1;
                    RefundM.BranchId = 1;
                    RefundM.RefundNo = Refund.RefundNo;
                    RefundM.VendorId = Refund.VendorId;
                    RefundM.DueDate = Refund.DueDate;
                    RefundM.RefundDate = Refund.RefundDate;
                    RefundM.TaxRateId = taxrateid;
                    RefundM.Note = Refund.Note;
                    RefundM.SubTotal = Refund.SubTotal;
                    RefundM.TotalTax = Refund.TotalTax;
                    RefundM.Total = Refund.Total;
                    result.msg = _RefundsService.Insert(RefundM);
                    if (result.msg == "")
                    {
                        result.msg = _RefundsService.SaveChanges();
                        refundMId = RefundM.RefundId;
                        if (Refund.RefundD != null)
                        {
                            foreach (var item in Refund.RefundD)
                            {
                                item.RefundId = refundMId;
                                //int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == item.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                                //item.TaxRateId = Dtaxrateid;
                                item.PortalId = 0;
                                item.CreatedBy = 0;
                                item.CompanyId = 1;
                                item.BranchId = 1;
                                item.CreatedDate = System.DateTime.Now;
                                result.msg = _RefundsLinesService.Insert(item);
                                if (result.msg == "")
                                {
                                    result.msg = _RefundsLinesService.SaveChanges();
                                }
                            }
                        }
                        result.isError = (result.msg != "" ? true : false);
                    }
                
            }
            return Json(new { result = result });
        }



        [HttpPost]
        public ActionResult Update(RefundsExtented refundViewModel)
        {
            DbResult result = new DbResult();
            if (refundViewModel != null)
            {
                if (refundViewModel.RefundId != 0)
                {
                    Refunds BillMDetail = _RefundsService.GetById(refundViewModel.RefundId);
                    BillMDetail.ModifiedDate = System.DateTime.Now;
                    BillMDetail.ModifiedBy = 1;
                    BillMDetail.VendorId = refundViewModel.VendorId;
                    BillMDetail.RefundDate = refundViewModel.RefundDate;
                    BillMDetail.DueDate = refundViewModel.DueDate;
                    BillMDetail.Note = refundViewModel.Note;
                    int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == refundViewModel.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

                    BillMDetail.TaxRateId = taxrateid;
                    BillMDetail.TotalTax = refundViewModel.TotalTax;
                    BillMDetail.SubTotal = refundViewModel.SubTotal;
                    BillMDetail.Total = refundViewModel.Total;
                    if (refundViewModel.RefundD.Count != 0)
                    {
                        foreach (var i in refundViewModel.RefundD)
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
                            i.RefundId = refundViewModel.RefundId;
                        }
                        _dbcontext.RefundsLines.UpdateRange(refundViewModel.RefundD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in refundViewModel.RefundD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.RefundsLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();
                    
                    _dbcontext.Refunds.Update(BillMDetail);
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
                Refunds obj = _dbcontext.Refunds.Find(id);
                var BillDList = _dbcontext.RefundsLines.Where(x => x.RefundId == id).ToList();
                _dbcontext.RefundsLines.RemoveRange(BillDList);
                _dbcontext.SaveChanges();


                _dbcontext.Refunds.Remove(obj);
                _dbcontext.SaveChanges();
                result.msg = "deleted";
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }

    }
}
