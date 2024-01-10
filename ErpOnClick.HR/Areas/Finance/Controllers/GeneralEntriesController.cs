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

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class GeneralEntriesController : Controller
    {
        private readonly ILogger<GeneralEntriesController> _logger;
        private IGeneralEntriesService _GeneralEntriesService;
        private IGeneralEntriesLinesService _GeneralEntriesLinesService;
        private IAccountsService _AccountsService;
        private ITaxRatesService _TaxRatesService;
        private ICustomersService _customerService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public GeneralEntriesController(ILogger<GeneralEntriesController> logger, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, ICustomersService customerService, IGeneralEntriesLinesService GeneralEntriesLinesService, IGeneralEntriesService GeneralEntriesService)
        {
            _logger = logger;
            this._GeneralEntriesService = GeneralEntriesService;
            this._GeneralEntriesLinesService = GeneralEntriesLinesService;
            this._customerService = customerService;
            this._AccountsService = AccountsService;
            this._TaxRatesService = TaxRatesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            this._dbcontext = dbcontext;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _list(DateTime GeneralEntryDateFrom, DateTime GeneralEntryDateTo)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string generalentrydatefrom = GeneralEntryDateFrom.ToString("yyyy-MM-dd");
            string generalentrydateto = GeneralEntryDateTo.ToString("yyyy-MM-dd");
            expObj.generalEntriesMList = _GeneralEntriesService.dbset()
                .Where(c =>(generalentrydatefrom != "0001-01-01" && c.GeneralEntryDate >= Convert.ToDateTime(generalentrydatefrom) || generalentrydatefrom == "0001-01-01")
                && (generalentrydateto != "0001-01-01" && c.GeneralEntryDate <= Convert.ToDateTime(generalentrydateto) || generalentrydateto == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }



        public IActionResult Edit(int id)
        {
            expObj.AccountsList = _AccountsService.GetAll().ToList();
            expObj.TaxList = _TaxRatesService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.generalEntriesMDetail = _GeneralEntriesService.GetById(id);
            expObj.generalEntriesDList = _GeneralEntriesLinesService.Find(c => (c.GeneralEntryId == id)).ToList();

            return View(expObj);
        }


        public IActionResult print(int id)
        {
            expObj.generalEntriesMDetail = _GeneralEntriesService.GetById(id);
            expObj.AccountsList = _AccountsService.GetAll().ToList();

            expObj.CompanyDetail = _CompanyService.GetById(expObj.generalEntriesMDetail.CompanyId);
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.generalEntriesDList = _GeneralEntriesLinesService.Find(c => (c.GeneralEntryId == id)).ToList();

            return View(expObj);
        }

        public IActionResult PrintList(DateTime GeneralEntryDateFrom, DateTime GeneralEntryDateTo)
        {

            //string date = IncoiveDate.ToString("yyyy-MM-dd");
            string generalentrydatefrom = GeneralEntryDateFrom.ToString("yyyy-MM-dd");
            string generalentrydateto = GeneralEntryDateTo.ToString("yyyy-MM-dd");

            expObj.GeneralEntryDateFrom= GeneralEntryDateFrom.ToString("yyyy-MM-dd");
            expObj.GeneralEntryDateTo = GeneralEntryDateTo.ToString("yyyy-MM-dd");

            expObj.generalentryMList = _GeneralEntriesService.dbset()
                .Where(c => (generalentrydatefrom != "0001-01-01" && c.GeneralEntryDate >= Convert.ToDateTime(generalentrydatefrom) || generalentrydatefrom == "0001-01-01")
                && (generalentrydateto != "0001-01-01" && c.GeneralEntryDate <= Convert.ToDateTime(generalentrydateto) || generalentrydateto == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetById(2);
            return View(expObj);
        }



        [HttpPost]
        public IActionResult Save(GeneralLinesExtended generalLines)
        {
            DbResult result = new DbResult();
            var generalEntriesMId = 0;
            if (ModelState.IsValid)
            {
                if (generalLines != null)
                {
                    GeneralEntries generalEntriesM = new GeneralEntries();
                    generalEntriesM.CreatedBy = 0;
                    generalEntriesM.CreatedDate = System.DateTime.Now;
                    generalEntriesM.PortalId = 0;
                    generalEntriesM.CompanyId = 1;
                    generalEntriesM.BranchId = 1;
                    generalEntriesM.GeneralEntryDate = generalLines.GeneralEntryDate;
                    generalEntriesM.GeneralEntryNo = generalLines.GeneralEntryNo;
                    generalEntriesM.Currency = generalLines.Currency;
                    generalEntriesM.Note = generalLines.Note;
                    generalEntriesM.TotalCredit = generalLines.TotalCredit;
                    generalEntriesM.TotalDebit = generalLines.TotalDebit;
                    result.msg = _GeneralEntriesService.Insert(generalEntriesM);
                    if (result.msg == "")
                    {
                        result.msg = _GeneralEntriesService.SaveChanges();
                        generalEntriesMId = generalEntriesM.GeneralEntryId;
                        if (generalLines.GeneralEntriesLinesD != null)
                        {
                            foreach (var item in generalLines.GeneralEntriesLinesD)
                            {
                                item.GeneralEntryId = generalEntriesMId;
                                item.PortalId = 0;
                                item.CompanyId = 1;
                                item.BranchId = 1;
                                item.CreatedBy = 0;
                                item.CreatedDate = System.DateTime.Now;
                                result.msg = _GeneralEntriesLinesService.Insert(item);
                                if (result.msg == "")
                                {
                                    result.msg = _GeneralEntriesLinesService.SaveChanges();
                                }
                            }
                        }
                        result.isError = (result.msg != "" ? true : false);
                    }
                }
            }
            return Json(new { result = result });
        }



        [HttpPost]
        public ActionResult Update(GeneralLinesExtended generalLinesViewModel)
        {
            DbResult result = new DbResult();
            if (generalLinesViewModel != null)
            {
                if (generalLinesViewModel.GeneralEntryId != 0)
                {
                    GeneralEntries generalEntriesMDetail = _GeneralEntriesService.GetById(generalLinesViewModel.GeneralEntryId);
                    generalEntriesMDetail.ModifiedDate = System.DateTime.Now;
                    generalEntriesMDetail.ModifiedBy = 1;
                    generalEntriesMDetail.TotalDebit = generalLinesViewModel.TotalDebit;
                    generalEntriesMDetail.TotalCredit = generalLinesViewModel.TotalCredit;
                    generalEntriesMDetail.GeneralEntryDate = generalLinesViewModel.GeneralEntryDate;
                    generalEntriesMDetail.Note = generalLinesViewModel.Note;
                    generalEntriesMDetail.GeneralEntryNo = generalLinesViewModel.GeneralEntryNo;
                    generalEntriesMDetail.Currency = generalLinesViewModel.Currency;
                    if (generalLinesViewModel.GeneralEntriesLinesD.Count != 0)
                    {
                        foreach (var i in generalLinesViewModel.GeneralEntriesLinesD)
                        {
                            if(i.CreatedDate == null && i.CreatedBy == null)
                            {
                                i.PortalId = 0;
                                i.CompanyId = 1;
                                i.BranchId = 1;
                                i.CreatedBy = 0;
                                i.CreatedDate = System.DateTime.Now;
                            }
                            i.GeneralEntryId = generalLinesViewModel.GeneralEntryId;
                        }
                        _dbcontext.GeneralEntriesLines.UpdateRange(generalLinesViewModel.GeneralEntriesLinesD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in generalLinesViewModel.GeneralEntriesLinesD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.GeneralEntriesLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();
                    
                    _dbcontext.GeneralEntries.Update(generalEntriesMDetail);
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
                GeneralEntries obj = _dbcontext.GeneralEntries.Find(id);
                var generalEntriesDList = _dbcontext.GeneralEntriesLines.Where(x => x.GeneralEntryId == id).ToList();
                _dbcontext.GeneralEntriesLines.RemoveRange(generalEntriesDList);
                _dbcontext.SaveChanges();


                _dbcontext.GeneralEntries.Remove(obj);
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
