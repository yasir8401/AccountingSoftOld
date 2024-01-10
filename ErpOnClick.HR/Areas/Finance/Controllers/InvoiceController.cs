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
    public class InvoiceController : Controller
    {
        private readonly ILogger<InvoiceController> _logger;
        private IInvoicesService _InvoicesService;
        private IInvoicesLinesService _InvoicesLinesService;
        private IItemsService _ItemsService;
        private ITaxRatesService _TaxRatesService;
        private ICustomersService _customerService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public InvoiceController(ILogger<InvoiceController> logger, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IItemsService ItemsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, ICustomersService customerService, IInvoicesLinesService InvoicesLinesService, IInvoicesService InvoicesService)
        {
            _logger = logger;
            this._InvoicesService = InvoicesService;
            this._InvoicesLinesService = InvoicesLinesService;
            this._customerService = customerService;
            this._ItemsService = ItemsService;
            this._TaxRatesService = TaxRatesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            this._dbcontext = dbcontext;

        }
        public IActionResult Index()
        {
            expObj.customersList = _customerService.GetAll();
            return View(expObj);
        }


        public IActionResult _list(DateTime IncoiveDateFrom, DateTime IncoiveDateTo, int CustomerId, DateTime DueDateFrom, DateTime DueDateto)
        {
            string invoicedatefrom = IncoiveDateFrom.ToString("yyyy-MM-dd");
            string invoicedateto = IncoiveDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateto.ToString("yyyy-MM-dd");

            expObj.invoiceMList = _InvoicesService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (invoicedatefrom != "0001-01-01" && c.InvoiceDate >= Convert.ToDateTime(invoicedatefrom) || invoicedatefrom == "0001-01-01")
                && (invoicedateto != "0001-01-01" && c.InvoiceDate <= Convert.ToDateTime(invoicedateto) || invoicedateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult Edit(int id)
        {
            expObj.invoiceNo = 0;
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.customersList = _customerService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.invoiceMDetail = _InvoicesService.GetById(id);
            expObj.invoiceDList = _InvoicesLinesService.Find(c => (c.InvoiceId == id)).ToList();

            if (id == 0 && _InvoicesService.GetAll() != null && _InvoicesService.GetAll().ToList() != null && _InvoicesService.GetAll().ToList().Count > 0)
            {
                expObj.invoiceNo = (_InvoicesService.GetAll().ToList().Max(x => x.InvoiceId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.invoiceNo = "00001";
            }

            return View(expObj);
        }


        public IActionResult print(int id)
        {
            expObj.invoiceMDetail = _InvoicesService.dbset().Where(c => c.InvoiceId == id).IncludeOptimized(c => c.TaxRate).FirstOrDefault();
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.customersList = _customerService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetById(expObj.invoiceMDetail.CompanyId);
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.invoiceDList = _InvoicesLinesService.Find(c => (c.InvoiceId == id)).ToList();

            return View(expObj);
        }

        public IActionResult PrintList(DateTime IncoiveDateFrom, DateTime IncoiveDateTo, int CustomerId, DateTime DueDateFrom, DateTime DueDateTo)
        {
            string invoicedatefrom = IncoiveDateFrom.ToString("yyyy-MM-dd");
            string invoicedateto = IncoiveDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateTo.ToString("yyyy-MM-dd");
            expObj.IncoiveDateFrom = IncoiveDateFrom.ToString("yyyy-MM-dd");
            expObj.IncoiveDateTo = IncoiveDateTo.ToString("yyyy-MM-dd");
            if (CustomerId == 0)
            {
                expObj.CustomerId = "All";
            }
            else
            {
                expObj.CustomerId = _customerService.GetById(CustomerId).CustomerNameEn;
            }
            expObj.DueDateFrom = DueDateFrom.ToString("yyyy-MM-dd");
            expObj.DueDateTo = DueDateTo.ToString("yyyy-MM-dd");
            expObj.invoiceMList = _InvoicesService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (invoicedatefrom != "0001-01-01" && c.InvoiceDate >= Convert.ToDateTime(invoicedatefrom) || invoicedatefrom == "0001-01-01")
                && (invoicedateto != "0001-01-01" && c.InvoiceDate <= Convert.ToDateTime(invoicedateto) || invoicedateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return View(expObj);
        }


        [HttpPost]
        public IActionResult Save(InvoiceExtented Invoice)
        {
            DbResult result = new DbResult();
            var invoiceMId = 0;
            //int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == Invoice.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();


            if (Invoice != null)
            {
                Invoices invoiceM = new Invoices();
                invoiceM.CreatedBy = 0;
                invoiceM.CreatedDate = System.DateTime.Now;
                invoiceM.PortalId = 0;
                invoiceM.CompanyId = 1;
                invoiceM.BranchId = 1;
                invoiceM.InvoiceNo = Invoice.InvoiceNo;
                invoiceM.CustomerId = Invoice.CustomerId;
                invoiceM.DueDate = Invoice.DueDate;
                invoiceM.InvoiceDate = Invoice.InvoiceDate;
                invoiceM.TaxRateId = _TaxRatesService.Find(c => c.TaxPercent == (Invoice.InvoiceD.Count() > 0 ? Invoice.InvoiceD.FirstOrDefault().TaxPercent : null)).Select(c => c.TaxRateId).FirstOrDefault();
                invoiceM.Note = Invoice.Note;
                invoiceM.SubTotal = Invoice.SubTotal;
                invoiceM.TotalTax = Invoice.TotalTax;
                invoiceM.TotalDiscount = Invoice.TotalDiscount;
                invoiceM.Total = Invoice.Total;
                result.msg = _InvoicesService.Insert(invoiceM);
                if (result.msg == "")
                {
                    result.msg = _InvoicesService.SaveChanges();
                    invoiceMId = invoiceM.InvoiceId;
                    if (Invoice.InvoiceD != null)
                    {
                        foreach (var item in Invoice.InvoiceD)
                        {
                            item.InvoiceId = invoiceMId;
                            int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == item.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                            item.TaxRateId = Dtaxrateid;
                            item.PortalId = 0;
                            item.CompanyId = 1;
                            item.BranchId = 1;
                            item.CreatedBy = 0;
                            item.CreatedDate = System.DateTime.Now;
                            result.msg = _InvoicesLinesService.Insert(item);
                            if (result.msg == "")
                            {
                                result.msg = _InvoicesLinesService.SaveChanges();
                            }
                        }
                    }
                    result.isError = (result.msg != "" ? true : false);
                }
            }

            return Json(new { result = result });
        }



        [HttpPost]
        public ActionResult Update(InvoiceExtented invoiceViewModel)
        {
            DbResult result = new DbResult();
            if (invoiceViewModel != null)
            {
                if (invoiceViewModel.InvoiceId != 0)
                {
                    Invoices invoiceMDetail = _InvoicesService.GetById(invoiceViewModel.InvoiceId);
                    invoiceMDetail.ModifiedDate = System.DateTime.Now;
                    invoiceMDetail.ModifiedBy = 1;
                    invoiceMDetail.CustomerId = invoiceViewModel.CustomerId;
                    invoiceMDetail.InvoiceDate = invoiceViewModel.InvoiceDate;
                    invoiceMDetail.DueDate = invoiceViewModel.DueDate;
                    invoiceMDetail.Note = invoiceViewModel.Note;
                    //int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == invoiceViewModel.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

                    invoiceMDetail.TaxRateId = _TaxRatesService.Find(c => c.TaxPercent == (invoiceViewModel.InvoiceD.Count() > 0 ? invoiceViewModel.InvoiceD.FirstOrDefault().TaxPercent : null)).Select(c => c.TaxRateId).FirstOrDefault();
                    invoiceMDetail.TotalTax = invoiceViewModel.TotalTax;
                    invoiceMDetail.TotalDiscount = invoiceViewModel.TotalDiscount;

                    invoiceMDetail.SubTotal = invoiceViewModel.SubTotal;
                    invoiceMDetail.Total = invoiceViewModel.Total;
                    if (invoiceViewModel.InvoiceD.Count != 0)
                    {
                        foreach (var i in invoiceViewModel.InvoiceD)
                        {
                            if (i.CreatedDate == null && i.CreatedBy == null)
                            {
                                i.PortalId = 0;
                                i.CompanyId = 1;
                                i.BranchId = 1;
                                i.CreatedBy = 0;
                                i.CreatedDate = System.DateTime.Now;
                            }
                            int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == i.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                            i.TaxRateId = Dtaxrateid;
                            i.InvoiceId = invoiceViewModel.InvoiceId;
                        }
                        _dbcontext.InvoicesLines.UpdateRange(invoiceViewModel.InvoiceD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in invoiceViewModel.InvoiceD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.InvoicesLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();

                    _dbcontext.Invoices.Update(invoiceMDetail);
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
                Invoices obj = _dbcontext.Invoices.Find(id);
                var invoiceDList = _dbcontext.InvoicesLines.Where(x => x.InvoiceId == id).ToList();
                _dbcontext.InvoicesLines.RemoveRange(invoiceDList);
                _dbcontext.SaveChanges();


                _dbcontext.Invoices.Remove(obj);
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
