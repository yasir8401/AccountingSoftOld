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
    public class CreditNotesController : Controller
    {
        private readonly ILogger<CreditNotesController> _logger;
        private ICreditNotesService _CreditNotesService;
        private ICreditNotesLinesService _CreditNotesLinesService;
        private IItemsService _ItemsService;
        private ITaxRatesService _TaxRatesService;
        private ICustomersService _customerService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public CreditNotesController(ILogger<CreditNotesController> logger, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IItemsService ItemsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, ICustomersService customerService, ICreditNotesLinesService CreditNotesLinesService, ICreditNotesService CreditNotesService)
        {
            _logger = logger;
            this._CreditNotesService = CreditNotesService;
            this._CreditNotesLinesService = CreditNotesLinesService;
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

        public IActionResult _list(DateTime CreditNoteDateFrom, DateTime CreditNoteDateTo, int CustomerId, DateTime DueDateFrom, DateTime DueDateto)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string creditnotedatefrom = CreditNoteDateFrom.ToString("yyyy-MM-dd");
            string creditnotedateto = CreditNoteDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateto.ToString("yyyy-MM-dd");


            expObj.creditNotesMList = _CreditNotesService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (creditnotedatefrom != "0001-01-01" && c.CreditNoteDate >= Convert.ToDateTime(creditnotedatefrom) || creditnotedatefrom == "0001-01-01")
                && (creditnotedateto != "0001-01-01" && c.CreditNoteDate <= Convert.ToDateTime(creditnotedateto) || creditnotedateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }




        public IActionResult Edit(int id)
        {
            expObj.creditNotes = 0;
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.customersList = _customerService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            //expObj.CompanyDetail = _CompanyService.GetAll();
            //expObj.BranchDetail = _BranchService.GetAll();
            expObj.creditNotesMDetail = _CreditNotesService.GetById(id);
            expObj.creditNotesDList = _CreditNotesLinesService.Find(c => (c.CreditNoteId == id)).ToList();

            if (id == 0 && _CreditNotesService.GetAll() != null && _CreditNotesService.GetAll().ToList() != null && _CreditNotesService.GetAll().ToList().Count > 0)
            {
                expObj.creditNotes = (_CreditNotesService.GetAll().ToList().Max(x => x.CreditNoteId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.creditNotes = "00001";
            }

            return View(expObj);
        }

        public IActionResult print(int id)
        {
            expObj.creditNotesMDetail = _CreditNotesService.GetById(id);
            expObj.ItemsList = _ItemsService.GetAll().ToList();
            expObj.customersList = _customerService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetById(expObj.creditNotesMDetail.CompanyId);
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.creditNotesDList = _CreditNotesLinesService.Find(c => (c.CreditNoteId == id)).ToList();

            return View(expObj);
        }


        public IActionResult PrintList(DateTime CreditNoteDateFrom, DateTime CreditNoteDateTo, int CustomerId, DateTime DueDateFrom, DateTime DueDateTo)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string creditnotedatefrom = CreditNoteDateFrom.ToString("yyyy-MM-dd");
            string creditnotedateto = CreditNoteDateTo.ToString("yyyy-MM-dd");
            string duedatefrom = DueDateFrom.ToString("yyyy-MM-dd");
            string duedateto = DueDateTo.ToString("yyyy-MM-dd");

            expObj.CreditNoteDateFrom = CreditNoteDateFrom.ToString("yyyy-MM-dd");
            expObj.CreditNoteDateTo = CreditNoteDateTo.ToString("yyyy-MM-dd");
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

            expObj.creditNotesMDetail = _CreditNotesService.dbset()
                .IncludeOptimized(c => c.Customer)
                .Where(c => (c.CustomerId == CustomerId || CustomerId == 0)
                && (creditnotedatefrom != "0001-01-01" && c.CreditNoteDate >= Convert.ToDateTime(creditnotedatefrom) || creditnotedatefrom == "0001-01-01")
                && (creditnotedateto != "0001-01-01" && c.CreditNoteDate <= Convert.ToDateTime(creditnotedateto) || creditnotedateto == "0001-01-01")
                && (duedatefrom != "0001-01-01" && c.DueDate >= Convert.ToDateTime(duedatefrom) || duedatefrom == "0001-01-01")
                && (duedateto != "0001-01-01" && c.DueDate <= Convert.ToDateTime(duedateto) || duedateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            return View(expObj);
        }

        [HttpPost]
        public IActionResult Save(CreditNotesExtented CreditNotes)
        {
            DbResult result = new DbResult();
            var creditNotesMId = 0;
            int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == CreditNotes.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

            if (CreditNotes != null)
            {
                CreditNotes creditNotesM = new CreditNotes();
                creditNotesM.CreatedBy = 0;
                creditNotesM.CreatedDate = System.DateTime.Now;
                creditNotesM.PortalId = 0;
                creditNotesM.CompanyId = 1;
                creditNotesM.BranchId = 1;
                creditNotesM.CreditNoteNo = CreditNotes.CreditNoteNo;
                creditNotesM.CustomerId = CreditNotes.CustomerId;
                creditNotesM.DueDate = CreditNotes.DueDate;
                creditNotesM.CreditNoteDate = CreditNotes.CreditNoteDate;
                creditNotesM.TaxRateId = taxrateid;
                creditNotesM.Note = CreditNotes.Note;
                creditNotesM.SubTotal = CreditNotes.SubTotal;
                creditNotesM.TotalTax = CreditNotes.TotalTax;
                creditNotesM.Total = CreditNotes.Total;
                result.msg = _CreditNotesService.Insert(creditNotesM);
                if (result.msg == "")
                {
                    result.msg = _CreditNotesService.SaveChanges();
                    creditNotesMId = creditNotesM.CreditNoteId;
                    if (CreditNotes.CreditNotesD != null)
                    {
                        foreach (var item in CreditNotes.CreditNotesD)
                        {
                            item.CreditNoteId = creditNotesMId;
                            //int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == item.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                            //item.TaxRateId = Dtaxrateid;
                            item.PortalId = 0;
                            item.CompanyId = 1;
                            item.BranchId = 1;
                            item.CreatedBy = 0;
                            item.CreatedDate = System.DateTime.Now;
                            result.msg = _CreditNotesLinesService.Insert(item);
                            if (result.msg == "")
                            {
                                result.msg = _CreditNotesLinesService.SaveChanges();
                            }
                        }
                    }
                    result.isError = (result.msg != "" ? true : false);
                }
            }

            return Json(new { result = result });
        }



        [HttpPost]
        public ActionResult Update(CreditNotesExtented creditViewModel)
        {
            DbResult result = new DbResult();
            if (creditViewModel != null)
            {
                if (creditViewModel.CreditNoteId != 0)
                {
                    CreditNotes creditNotesMDetail = _CreditNotesService.GetById(creditViewModel.CreditNoteId);
                    creditNotesMDetail.ModifiedDate = System.DateTime.Now;
                    creditNotesMDetail.ModifiedBy = 1;
                    creditNotesMDetail.CustomerId = creditViewModel.CustomerId;
                    creditNotesMDetail.CreditNoteDate = creditViewModel.CreditNoteDate;
                    creditNotesMDetail.DueDate = creditViewModel.DueDate;
                    creditNotesMDetail.Note = creditViewModel.Note;
                    int taxrateid = _TaxRatesService.Find(c => c.TaxPercent == creditViewModel.TaxRateId).Select(c => c.TaxRateId).FirstOrDefault();

                    creditNotesMDetail.TaxRateId = taxrateid;
                    creditNotesMDetail.TotalTax = creditViewModel.TotalTax;
                    creditNotesMDetail.SubTotal = creditViewModel.SubTotal;
                    creditNotesMDetail.Total = creditViewModel.Total;
                    if (creditViewModel.CreditNotesD.Count != 0)
                    {
                        foreach (var i in creditViewModel.CreditNotesD)
                        {
                            if (i.CreatedDate == null && i.CreatedBy == null)
                            {
                                i.PortalId = 0;
                                i.CompanyId = 1;
                                i.BranchId = 1;
                                i.CreatedBy = 0;
                                i.CreatedDate = System.DateTime.Now;
                            }
                            //int Dtaxrateid = _TaxRatesService.Find(c => c.TaxPercent == i.TaxPercent).Select(c => c.TaxRateId).FirstOrDefault();

                            //i.TaxRateId = Dtaxrateid;
                            i.CreditNoteId = creditViewModel.CreditNoteId;
                        }
                        _dbcontext.CreditNotesLines.UpdateRange(creditViewModel.CreditNotesD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in creditViewModel.CreditNotesD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.CreditNotesLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();

                    _dbcontext.CreditNotes.Update(creditNotesMDetail);
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
                CreditNotes obj = _dbcontext.CreditNotes.Find(id);
                var creditNotesDList = _dbcontext.CreditNotesLines.Where(x => x.CreditNoteId == id).ToList();
                _dbcontext.CreditNotesLines.RemoveRange(creditNotesDList);
                _dbcontext.SaveChanges();


                _dbcontext.CreditNotes.Remove(obj);
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
