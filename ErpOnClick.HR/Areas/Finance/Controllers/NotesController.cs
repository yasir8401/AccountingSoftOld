using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ErpOnClick.DAL.Common;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.ViewModel;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Syncfusion.XlsIO;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class NotesController : Controller
    {
        private readonly ILogger<NotesController> _logger;
        private IAccountsService _AccountsService;
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private INotesService _NotesService;

        public static IWebHostEnvironment _HostEnvironment;
        public static IHostingEnvironment _env;


        string wwwRootPath = "";
        private dynamic expObj;
        public NotesController(IHostingEnvironment env, IWebHostEnvironment HostEnvironment, ILogger<NotesController> logger, INotesService NotesService, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _env = env;

            _logger = logger;
            _AccountsService = AccountsService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _NotesService = NotesService;

            wwwRootPath = HostEnvironment.WebRootPath;
            _HostEnvironment = HostEnvironment;


            expObj = new ExpandoObject();
        }

        public IActionResult Index()
        {
            expObj.Notes = _NotesService.dbset().IncludeOptimized(c => c.ParentNote.ParentNote).ToList();

            return View(expObj);
        }

        [HttpPost]
        public JsonResult GetParentNotes()
        {
            var notes = _NotesService.GetAll();

            return Json(new { result = notes });
        }

        [HttpPost]
        public JsonResult GetNoteDetails(int noteid)
        {
            Notes note = _NotesService.GetById(noteid);

            return Json(new { result = note });
        }


        public IActionResult DownloadExcelDocument()
        {
            DbResult result = new DbResult();
            List<Accounts> accounts = _AccountsService.dbset().IncludeOptimized(c => c.AccountGroup).IncludeOptimized(c => c.AccountType).IncludeOptimized(c => c.ParentAccount).ToList();
            IFormFile file = null;
            var count = 0;
            string filePath = String.Empty;

            //Initialize ExcelEngine.
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize Application.
                IApplication application = excelEngine.Excel;

                //Set default version for application.
                application.DefaultVersion = ExcelVersion.Excel2013;

                //Create a new workbook.
                IWorkbook workbook = application.Workbooks.Create(1);

                //Accessing first worksheet in the workbook.
                IWorksheet worksheet = workbook.Worksheets[0];
                worksheet.Name = "Chart of Account";
                worksheet.Range["A1"].Text = "Code";
                worksheet.Range["B1"].Text = "Name";
                worksheet.Range["C1"].Text = "Level";
                worksheet.Range["D1"].Text = "Nature";
                worksheet.Range["E1"].Text = "Type";
                worksheet.Range["F1"].Text = "Opening Balance";
                worksheet.Range["G1"].Text = "Closing Balance";
                worksheet.Range["H1"].Text = "IsTransactionable";
                count = 1;

                foreach (var head in accounts.Where(c => c.ParentAccountId == null))
                {
                    count = count + 1;
                    worksheet.Range["A" + count].Text = head.AccountCode;
                    worksheet.Range["B" + count].Value = head.AccountNameEn;
                    worksheet.Range["C" + count].Value = head.AccountLevel.ToString();
                    worksheet.Range["D" + count].Value = head.AccountCode.Substring(0, 1);
                    worksheet.Range["E" + count].Value = head.DefaultType;
                    worksheet.Range["F" + count].Value = head.OpeningBalance.ToString();
                    worksheet.Range["G" + count].Value = head.ClosingBalance.ToString();
                    worksheet.Range["H" + count].Value = head.IsTransactionable.ToString();

                    foreach (var subhead in accounts.Where(c => c.ParentAccountId == head.AccountId))
                    {
                        count = count + 1;

                        worksheet.Range["A" + count].Text = subhead.AccountCode;
                        worksheet.Range["B" + count].Value = subhead.AccountNameEn;
                        worksheet.Range["C" + count].Value = subhead.AccountLevel.ToString();
                        worksheet.Range["D" + count].Value = subhead.AccountCode.Substring(0, 1);
                        worksheet.Range["E" + count].Value = subhead.DefaultType;
                        worksheet.Range["F" + count].Value = head.OpeningBalance.ToString();
                        worksheet.Range["G" + count].Value = head.ClosingBalance.ToString();
                        worksheet.Range["H" + count].Value = subhead.IsTransactionable.ToString();


                        foreach (var subsubhead in accounts.Where(c => c.ParentAccountId == subhead.AccountId))
                        {
                            count = count + 1;

                            worksheet.Range["A" + count].Text = subsubhead.AccountCode;
                            worksheet.Range["B" + count].Value = subsubhead.AccountNameEn;
                            worksheet.Range["C" + count].Value = subsubhead.AccountLevel.ToString();
                            worksheet.Range["D" + count].Value = subsubhead.AccountCode.Substring(0, 1);
                            worksheet.Range["E" + count].Value = subsubhead.DefaultType;
                            worksheet.Range["F" + count].Value = head.OpeningBalance.ToString();
                            worksheet.Range["G" + count].Value = head.ClosingBalance.ToString();
                            worksheet.Range["H" + count].Value = subsubhead.IsTransactionable.ToString();


                            foreach (var subsubsubhead in accounts.Where(c => c.ParentAccountId == subsubhead.AccountId))
                            {
                                count = count + 1;

                                worksheet.Range["A" + count].Text = subsubsubhead.AccountCode;
                                worksheet.Range["B" + count].Value = subsubsubhead.AccountNameEn;
                                worksheet.Range["C" + count].Value = subsubsubhead.AccountLevel.ToString();
                                worksheet.Range["D" + count].Value = subsubsubhead.AccountCode.Substring(0, 1);
                                worksheet.Range["E" + count].Value = subsubsubhead.DefaultType;
                                worksheet.Range["F" + count].Value = head.OpeningBalance.ToString();
                                worksheet.Range["G" + count].Value = head.ClosingBalance.ToString();
                                worksheet.Range["H" + count].Value = subsubsubhead.IsTransactionable.ToString();


                                foreach (var lower in accounts.Where(c => c.ParentAccountId == subsubsubhead.AccountId))
                                {
                                    count = count + 1;

                                    worksheet.Range["A" + count].Text = lower.AccountCode;
                                    worksheet.Range["B" + count].Value = lower.AccountNameEn;
                                    worksheet.Range["C" + count].Value = lower.AccountLevel.ToString();
                                    worksheet.Range["D" + count].Value = lower.AccountCode.Substring(0, 1);
                                    worksheet.Range["E" + count].Value = lower.DefaultType;
                                    worksheet.Range["F" + count].Value = head.OpeningBalance.ToString();
                                    worksheet.Range["G" + count].Value = head.ClosingBalance.ToString();
                                    worksheet.Range["H" + count].Value = lower.IsTransactionable.ToString();

                                }
                            }
                        }
                    }
                }
                //Saving the Excel to the MemoryStream 
                MemoryStream stream = new MemoryStream();

                workbook.SaveAs(stream);

                //Set the position as '0'.
                stream.Position = 0;

                //Download the Excel file in the browser
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/excel");

                fileStreamResult.FileDownloadName = "Notes";

                return fileStreamResult;
            }
        }

        [HttpPost]
        public IActionResult AddNote(Notes postedData)
        {
            DbResult result = new DbResult();
            if (postedData.ParentNoteId == null)
            {
                postedData.NoteLevel = 1;
            }
            else if (postedData.ParentNoteId != null)
            {
                var parentNote = _NotesService.GetById(postedData.ParentNoteId);
                if (parentNote.ParentNoteId == null)
                {
                    postedData.NoteLevel = 2;
                }
                else if (parentNote.ParentNoteId != null)
                {
                    postedData.NoteLevel = 3;
                }
            }
            result.msg = _NotesService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _NotesService.SaveChanges();
            }
            if (result.msg == "")
            {
                result.isError = false;
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public IActionResult EditNote(Notes postedData)
        {
            DbResult result = new DbResult();
            var notedetails = _NotesService.GetById(postedData.NoteId);
            notedetails.NoteTitle = postedData.NoteTitle;
            notedetails.NoteDescription = postedData.NoteDescription;
            notedetails.ParentNoteId = postedData.ParentNoteId;
            if (notedetails.ParentNoteId == null)
            {
                notedetails.NoteLevel = 1;
            }
            else if (notedetails.ParentNoteId != null)
            {
                var parentNote = _NotesService.GetById(notedetails.ParentNoteId);
                if (parentNote.ParentNoteId == null)
                {
                    notedetails.NoteLevel = 2;
                }
                else if (parentNote.ParentNoteId != null)
                {
                    notedetails.NoteLevel = 3;
                }
            }
            result.msg = _NotesService.Update(notedetails);
            if (result.msg == "")
            {
                result.msg = _NotesService.SaveChanges();
            }
            if (result.msg == "")
            {
                result.isError = false;
            }
            return Json(new { result = result });
        }
    }
}
