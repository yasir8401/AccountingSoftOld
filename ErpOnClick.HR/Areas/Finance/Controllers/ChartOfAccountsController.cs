using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public class ChartOfAccountsController : Controller
    {
        private readonly ILogger<ChartOfAccountsController> _logger;
        private IAccountsService _AccountsService;
        private IAccountTypesService _AccountTypesService;
        private IAccountGroupsService _AccountGroupsService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IVoucherLinesService _VoucherLinesService;

        public static IWebHostEnvironment _HostEnvironment;
        public static IHostingEnvironment _env;


        string wwwRootPath = "";
        private dynamic expObj;
        public ChartOfAccountsController(IHostingEnvironment env, IWebHostEnvironment HostEnvironment, IVoucherLinesService VoucherLinesService, ILogger<ChartOfAccountsController> logger, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, IAccountGroupsService AccountGroupsService)
        {
            _env = env;

            _logger = logger;
            _AccountsService = AccountsService;
            _AccountTypesService = AccountTypesService;
            _AccountGroupsService = AccountGroupsService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _VoucherLinesService = VoucherLinesService;

            wwwRootPath = HostEnvironment.WebRootPath;
            _HostEnvironment = HostEnvironment;


            expObj = new ExpandoObject();
        }

        public IActionResult Index(string filename = "charts_of_accounts_xc.xlsx")
        {
            List<importData> datas = new List<importData>();

            expObj.Accounts = _AccountsService.dbset().IncludeOptimized(c => c.AccountType.ParentAccountType.ParentAccountType).OrderBy(x => x.AccountCode).ToList();
            expObj.AccountTypes = _AccountTypesService.GetAll().ToList();
            if (filename == "")
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = System.IO.File.Open(wwwRootPath + "/Files/" + filename, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() == "Code" && reader.GetValue(1).ToString() == "Name" && reader.GetValue(2).ToString() == "Level" && reader.GetValue(3).ToString() == "Nature" && reader.GetValue(4).ToString() == "Opening_Balance" && reader.GetValue(5).ToString() == "Closing_Balance")
                            {
                            }
                            else
                            {
                                datas.Add(new importData
                                {
                                    Code = reader.GetValue(0).ToString(),
                                    Name = reader.GetValue(1).ToString(),
                                    Level = reader.GetValue(2).ToString(),
                                    Nature = reader.GetValue(3).ToString(),
                                    OpeningBalance = Convert.ToDecimal(reader.GetValue(4)),
                                    Balance = Convert.ToDecimal(reader.GetValue(5))
                                });
                            }
                        }
                    }
                }
            }
            expObj.importedData = datas;
            return View(expObj);
        }

        [HttpPost]
        public JsonResult GetChartOfAccounts()
        {
            string filename = "charts_of_accounts_xc.xlsx";
            List<importData> datas = new List<importData>();

            //if (filename != "")
            //{
            //    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //    using (var stream = System.IO.File.Open(wwwRootPath + "/Files/" + filename, FileMode.Open, FileAccess.Read))
            //    {
            //        using (var reader = ExcelReaderFactory.CreateReader(stream))
            //        {
            //            while (reader.Read())
            //            {
            //                if (reader.GetValue(0).ToString() == "Code" && reader.GetValue(1).ToString() == "Name" && reader.GetValue(2).ToString() == "Level" && reader.GetValue(3).ToString() == "Nature" && reader.GetValue(4).ToString() == "Type")
            //                {
            //                }
            //                else
            //                {
            //                    datas.Add(new importData
            //                    {
            //                        Code = reader.GetValue(0).ToString(),
            //                        Name = reader.GetValue(1).ToString(),
            //                        Level = reader.GetValue(2).ToString(),
            //                        Nature = reader.GetValue(3).ToString(),
            //                        Type = reader.GetValue(4).ToString()
            //                    });
            //                }
            //            }
            //        }
            //    }
            //}
            List<Accounts> accounts = _AccountsService.dbset().Where(c => c.AccountLevel != 5).ToList();
            List<AccountTypes> accounttypes = _AccountTypesService.GetAll().ToList();
            foreach (var account in accounts)
            {
                datas.Add(new importData
                {
                    AccountId = account.AccountId,
                    Code = account.AccountCode,
                    Name = account.AccountNameEn,
                    Level = account.AccountLevel.ToString(),
                    Nature = (account.AccountCode != null ? account.AccountCode.Substring(0, 1) : ""),
                    Type = account.DefaultType,
                    OpeningBalance = account.OpeningBalance,
                    Balance = account.ClosingBalance
                });
            }
            return Json(new { result = datas });
        }

        [HttpPost]
        public JsonResult GetAccountTypes()
        {
            List<AccountTypes> accounttypes = _AccountTypesService.GetAll().ToList();

            return Json(new { result = accounttypes });
        }

        [HttpPost]
        public JsonResult GetAccountDetails(int id)
        {
            var accountDetails = _AccountsService.GetById(id);

            return Json(new { result = accountDetails });
        }

        [HttpPost]
        public async Task<IActionResult> ImportDataAsync(IFormFile File)
        {
            DbResult result = new DbResult();
            List<importData> datas = new List<importData>();

            string filePath = String.Empty;

            var attachmentfilePath = await FileHandling.UploadExcelFile(_HostEnvironment, File, "charts_of_accounts_xc");
            if (!String.IsNullOrWhiteSpace(attachmentfilePath))
            {
                filePath = attachmentfilePath;
            }

            if (filePath != "")
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = System.IO.File.Open(wwwRootPath + "/Files/" + filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() == "Code" && reader.GetValue(1).ToString() == "Name" && reader.GetValue(2).ToString() == "Level" && reader.GetValue(3).ToString() == "Nature" && reader.GetValue(4).ToString() == "Type" && reader.GetValue(5).ToString() == "Opening Balance" && reader.GetValue(6).ToString() == "Closing Balance" && reader.GetValue(7).ToString() == "IsTransactionable")
                            {
                            }
                            else
                            {
                                datas.Add(new importData
                                {
                                    Code = reader.GetValue(0).ToString(),
                                    Name = reader.GetValue(1).ToString(),
                                    Level = reader.GetValue(2).ToString(),
                                    Nature = reader.GetValue(3).ToString(),
                                    Type = reader.GetValue(4).ToString(),
                                    OpeningBalance = Convert.ToDecimal(reader.GetValue(5)),
                                    Balance = Convert.ToDecimal(reader.GetValue(6)),
                                    IsTransactionable = Convert.ToBoolean(reader.GetValue(7))
                                });
                            }
                        }
                    }
                }
                foreach (var item in datas)
                {
                    var accountdetails = _AccountsService.dbset().Where(c => c.AccountNameEn == item.Name && c.AccountCode == item.Code).FirstOrDefault();
                    if (accountdetails == null)
                    {
                        Accounts account = new Accounts();
                        account.AccountCode = item.Code;
                        account.AccountNameEn = item.Name;
                        account.CreatedBy = 1;
                        account.CreatedDate = System.DateTime.Now;
                        account.DefaultType = item.Type;
                        account.OpeningBalance = item.OpeningBalance;
                        account.ClosingBalance = item.Balance;
                        if (item.Level != 1.ToString())
                        {
                            if (item.Code.Length == 2 && item.Level == 2.ToString())
                            {
                                account.ParentAccountId = _AccountsService.dbset().Where(c => c.AccountCode == item.Code.Substring(0, 1)).Select(c => c.AccountId).FirstOrDefault();
                            }
                            else if (item.Code.Length == 4 && item.Level == 3.ToString())
                            {
                                account.ParentAccountId = _AccountsService.dbset().Where(c => c.AccountCode == item.Code.Substring(0, 2)).Select(c => c.AccountId).FirstOrDefault();
                            }

                            else if (item.Code.Length == 6 && item.Level == 4.ToString())
                            {
                                account.ParentAccountId = _AccountsService.dbset().Where(c => c.AccountCode == item.Code.Substring(0, 4)).Select(c => c.AccountId).FirstOrDefault();
                            }

                            else if (item.Code.Length == 16 && item.Level == 5.ToString())
                            {
                                account.ParentAccountId = _AccountsService.dbset().Where(c => c.AccountCode == item.Code.Substring(0, 6)).Select(c => c.AccountId).FirstOrDefault();
                            }
                        }
                        account.AccountLevel = Convert.ToInt32(item.Level);
                        if (account.AccountLevel == 5)
                        {
                            account.IsTransactionable = true;
                        }
                        else
                        {
                            account.IsTransactionable = false;
                        }
                        //account.AccountTypeId = _AccountTypesService.dbset().Where(c => c.AccountTypeNameEn == item.Type).Select(c => c.AccountTypeId).FirstOrDefault();
                        account.CompanyId = _CompanyService.GetAll().FirstOrDefault().CompanyId;
                        account.BranchId = _BranchService.GetAll().FirstOrDefault().BranchId;
                        result.msg = _AccountsService.Insert(account);
                        if (result.msg == "")
                        {
                            result.msg = _AccountsService.SaveChanges();
                        }
                    }
                }

            }
            result.isError = false;
            result.msg = filePath;
            return Json(new { result = result });
        }

        public IActionResult DownloadExcelDocument()
        {
            DbResult result = new DbResult();
            List<Accounts> accounts = _AccountsService.dbset().Include(c => c.AccountGroup).Include(c => c.AccountType).Include(c => c.ParentAccount).ToList();
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

                fileStreamResult.FileDownloadName = "Chart of Accounts.xlsx";

                return fileStreamResult;
            }
        }

        [HttpPost]
        public IActionResult AddChartOfAccount(ChartOfAccount chartOfAccount)
        {
            DbResult result = new DbResult();
            if (chartOfAccount.Id == 0)
            {
                var parent = _AccountsService.GetById(Convert.ToInt32(chartOfAccount.Parent));
                Accounts account = new Accounts();
                account.DefaultType = chartOfAccount.DefaultType;
                account.AccountCode = chartOfAccount.Code;
                account.OpeningBalance = chartOfAccount.OpeningBalance;
                account.ClosingBalance = chartOfAccount.Balance;
                account.AccountNameEn = chartOfAccount.Name;
                account.AccountTypeId = Convert.ToInt32(chartOfAccount.AccountType);
                account.CreatedBy = 1;
                account.CreatedDate = System.DateTime.Now;
                account.DefaultType = chartOfAccount.DefaultType;
                account.Status = (chartOfAccount.Status == "Active" ? true : false);
                account.IsTransactionable = (chartOfAccount.IsTransactionable == "true" ? true : false);
                account.ParentAccountId = Convert.ToInt32(chartOfAccount.Parent);
                if (account.ParentAccountId != null)
                {
                    account.AccountLevel = (parent != null ? parent.AccountLevel + 1 : 1);
                }
                else
                {
                    account.AccountLevel = 1;
                }
                account.CompanyId = _CompanyService.GetAll().FirstOrDefault().CompanyId;
                account.BranchId = _BranchService.GetAll().FirstOrDefault().BranchId;
                result.msg = _AccountsService.Insert(account);
            }
            else
            {
                var parent = _AccountsService.GetById(Convert.ToInt32(chartOfAccount.Parent));
                var accountdetails = _AccountsService.GetById(chartOfAccount.Id);
                accountdetails.AccountNameEn = chartOfAccount.Name;
                accountdetails.AccountCode = chartOfAccount.Code;
                accountdetails.ParentAccountId = Convert.ToInt32(chartOfAccount.Parent);
                accountdetails.DefaultType = chartOfAccount.DefaultType;
                accountdetails.Status = (chartOfAccount.Status == "Active" ? true : false);
                accountdetails.AccountTypeId = Convert.ToInt32(chartOfAccount.AccountType);
                accountdetails.OpeningBalance = chartOfAccount.OpeningBalance;
                accountdetails.ClosingBalance = chartOfAccount.Balance;
                accountdetails.IsTransactionable = (chartOfAccount.IsTransactionable == "true" ? true : false);
                if (accountdetails.ParentAccountId != null)
                {
                    accountdetails.AccountLevel = (parent != null ? parent.AccountLevel + 1 : 1);
                }
                else
                {
                    accountdetails.AccountLevel = 1;
                }
                accountdetails.ModifiedBy = 1;
                accountdetails.ModifiedDate = System.DateTime.Now;
                result.msg = _AccountsService.Update(accountdetails);
            }
            if (result.msg == "")
            {
                result.msg = _AccountsService.SaveChanges();
            }
            if (result.msg == "")
            {
                result.isError = false;
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DbResult result = new DbResult();

            if (id != 0)
            {
                var count = _VoucherLinesService.dbset().Where(c => c.AccountId == id).Count();
                if (count > 0)
                {
                    result.msg = "Account is used in General Entries";

                }
                else
                {
                    _AccountsService.Delete(id);
                    result.msg = _AccountsService.SaveChanges();
                    result.isError = (result.msg != "" ? true : false);
                }
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }

        public IActionResult ExcelDocument()
        {
            DbResult result = new DbResult();
            List<Accounts> accounts = _AccountsService.dbset().Include(c => c.AccountGroup).Include(c => c.AccountType).Include(c => c.ParentAccount).ToList();
            IFormFile file = null;
            UInt32 RowIndex = 1;
            var count = 0;
            string filePath = String.Empty;

            using (MemoryStream mem = new MemoryStream())
            {
                SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(mem, SpreadsheetDocumentType.Workbook);

                // Add a WorkbookPart to the document.
                WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                workbookpart.Workbook = new Workbook();

                // Add a WorksheetPart to the WorkbookPart.
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Add Sheets to the Workbook.
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Add a row to the cell table.
                Row row;
                row = new Row() { RowIndex = RowIndex };
                sheetData.Append(row);
                RowIndex = RowIndex + 1;
                Cell A1 = new Cell() { CellReference = "A1" };
                A1.CellValue = new CellValue("Code");
                A1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(A1);

                Cell B1 = new Cell() { CellReference = "B1" };
                B1.CellValue = new CellValue("Name");
                B1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(B1);

                Cell C1 = new Cell() { CellReference = "C1" };
                C1.CellValue = new CellValue("Level");
                C1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(C1);

                Cell D1 = new Cell() { CellReference = "D1" };
                D1.CellValue = new CellValue("Nature");
                D1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(D1);

                Cell E1 = new Cell() { CellReference = "E1" };
                E1.CellValue = new CellValue("Type");
                E1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(E1);

                Cell F1 = new Cell() { CellReference = "F1" };
                F1.CellValue = new CellValue("Opening Balance");
                F1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(F1);

                Cell G1 = new Cell() { CellReference = "G1" };
                G1.CellValue = new CellValue("Closing Balance");
                G1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(G1);

                Cell H1 = new Cell() { CellReference = "H1" };
                H1.CellValue = new CellValue("IsTransactionable");
                H1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(H1);

                count = 1;

                foreach (var head in accounts.Where(c => c.ParentAccountId == null))
                {
                    count = count + 1;

                    Row headrow;
                    headrow = new Row() { RowIndex = RowIndex };
                    sheetData.Append(headrow);
                    RowIndex = RowIndex + 1;

                    Cell HeadA = new Cell() { CellReference = "A" + count };
                    HeadA.CellValue = new CellValue(head.AccountCode);
                    HeadA.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(HeadA);

                    Cell headb = new Cell() { CellReference = "B" + count };
                    headb.CellValue = new CellValue(head.AccountNameEn);
                    headb.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headb);

                    Cell headc = new Cell() { CellReference = "C" + count };
                    headc.CellValue = new CellValue(head.AccountLevel.ToString());
                    headc.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headc);

                    Cell headd = new Cell() { CellReference = "D" + count };
                    headd.CellValue = new CellValue(head.AccountCode.Substring(0, 1));
                    headd.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headd);

                    Cell heade = new Cell() { CellReference = "E" + count };
                    heade.CellValue = new CellValue(head.DefaultType);
                    heade.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(heade);

                    Cell headf = new Cell() { CellReference = "F" + count };
                    headf.CellValue = new CellValue(head.OpeningBalance.ToString());
                    headf.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headf);

                    Cell headg = new Cell() { CellReference = "G" + count };
                    headg.CellValue = new CellValue(head.ClosingBalance.ToString());
                    headg.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headg);

                    Cell headh = new Cell() { CellReference = "H" + count };
                    headh.CellValue = new CellValue(head.IsTransactionable.ToString());
                    headh.DataType = new EnumValue<CellValues>(CellValues.String);
                    headrow.AppendChild(headh);

                    foreach (var subhead in accounts.Where(c => c.ParentAccountId == head.AccountId))
                    {
                        count = count + 1;

                        Row subheadrow;
                        subheadrow = new Row() { RowIndex = RowIndex };
                        sheetData.Append(subheadrow);
                        RowIndex = RowIndex + 1;

                        Cell subheadA = new Cell() { CellReference = "A" + count };
                        subheadA.CellValue = new CellValue(subhead.AccountCode);
                        subheadA.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadA);

                        Cell subheadb = new Cell() { CellReference = "B" + count };
                        subheadb.CellValue = new CellValue(subhead.AccountNameEn);
                        subheadb.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadb);

                        Cell subheadc = new Cell() { CellReference = "C" + count };
                        subheadc.CellValue = new CellValue(subhead.AccountLevel.ToString());
                        subheadc.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadc);

                        Cell subheadd = new Cell() { CellReference = "D" + count };
                        subheadd.CellValue = new CellValue(subhead.AccountCode.Substring(0, 1));
                        subheadd.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadd);

                        Cell subheade = new Cell() { CellReference = "E" + count };
                        subheade.CellValue = new CellValue(subhead.DefaultType);
                        subheade.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheade);

                        Cell subheadf = new Cell() { CellReference = "F" + count };
                        subheadf.CellValue = new CellValue(subhead.OpeningBalance.ToString());
                        subheadf.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadf);

                        Cell subheadg = new Cell() { CellReference = "G" + count };
                        subheadg.CellValue = new CellValue(subhead.ClosingBalance.ToString());
                        subheadg.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadg);

                        Cell subheadh = new Cell() { CellReference = "H" + count };
                        subheadh.CellValue = new CellValue(subhead.IsTransactionable.ToString());
                        subheadh.DataType = new EnumValue<CellValues>(CellValues.String);
                        subheadrow.AppendChild(subheadh);

                        foreach (var subsubhead in accounts.Where(c => c.ParentAccountId == subhead.AccountId))
                        {
                            count = count + 1;

                            Row subsubheadrow;
                            subsubheadrow = new Row() { RowIndex = RowIndex };
                            sheetData.Append(subsubheadrow);
                            RowIndex = RowIndex + 1;

                            Cell subsubheadA = new Cell() { CellReference = "A" + count };
                            subsubheadA.CellValue = new CellValue(subsubhead.AccountCode);
                            subsubheadA.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadA);

                            Cell subsubheadb = new Cell() { CellReference = "B" + count };
                            subsubheadb.CellValue = new CellValue(subsubhead.AccountNameEn);
                            subsubheadb.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadb);

                            Cell subsubheadc = new Cell() { CellReference = "C" + count };
                            subsubheadc.CellValue = new CellValue(subsubhead.AccountLevel.ToString());
                            subsubheadc.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadc);

                            Cell subsubheadd = new Cell() { CellReference = "D" + count };
                            subsubheadd.CellValue = new CellValue(subsubhead.AccountCode.Substring(0, 1));
                            subsubheadd.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadd);

                            Cell subsubheade = new Cell() { CellReference = "E" + count };
                            subsubheade.CellValue = new CellValue(subsubhead.DefaultType);
                            subsubheade.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheade);

                            Cell subsubheadf = new Cell() { CellReference = "F" + count };
                            subsubheadf.CellValue = new CellValue(subsubhead.OpeningBalance.ToString());
                            subsubheadf.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadf);

                            Cell subsubheadg = new Cell() { CellReference = "G" + count };
                            subsubheadg.CellValue = new CellValue(subsubhead.ClosingBalance.ToString());
                            subsubheadg.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadg);

                            Cell subsubheadh = new Cell() { CellReference = "H" + count };
                            subsubheadh.CellValue = new CellValue(subsubhead.IsTransactionable.ToString());
                            subsubheadh.DataType = new EnumValue<CellValues>(CellValues.String);
                            subsubheadrow.AppendChild(subsubheadh);

                            foreach (var subsubsubhead in accounts.Where(c => c.ParentAccountId == subsubhead.AccountId))
                            {
                                count = count + 1;

                                Row subsubsubheadrow;
                                subsubsubheadrow = new Row() { RowIndex = RowIndex };
                                sheetData.Append(subsubsubheadrow);
                                RowIndex = RowIndex + 1;

                                Cell subsubsubheadA = new Cell() { CellReference = "A" + count };
                                subsubsubheadA.CellValue = new CellValue(subsubsubhead.AccountCode);
                                subsubsubheadA.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadA);

                                Cell subsubsubheadb = new Cell() { CellReference = "B" + count };
                                subsubsubheadb.CellValue = new CellValue(subsubsubhead.AccountNameEn);
                                subsubsubheadb.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadb);

                                Cell subsubsubheadc = new Cell() { CellReference = "C" + count };
                                subsubsubheadc.CellValue = new CellValue(subsubsubhead.AccountLevel.ToString());
                                subsubsubheadc.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadc);

                                Cell subsubsubheadd = new Cell() { CellReference = "D" + count };
                                subsubsubheadd.CellValue = new CellValue(subsubsubhead.AccountCode.Substring(0, 1));
                                subsubsubheadd.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadd);

                                Cell subsubsubheade = new Cell() { CellReference = "E" + count };
                                subsubsubheade.CellValue = new CellValue(subsubsubhead.DefaultType);
                                subsubsubheade.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheade);

                                Cell subsubsubheadf = new Cell() { CellReference = "F" + count };
                                subsubsubheadf.CellValue = new CellValue(subsubsubhead.OpeningBalance.ToString());
                                subsubsubheadf.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadf);

                                Cell subsubsubheadg = new Cell() { CellReference = "G" + count };
                                subsubsubheadg.CellValue = new CellValue(subsubsubhead.ClosingBalance.ToString());
                                subsubsubheadg.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadg);

                                Cell subsubsubheadh = new Cell() { CellReference = "H" + count };
                                subsubsubheadh.CellValue = new CellValue(subsubsubhead.IsTransactionable.ToString());
                                subsubsubheadh.DataType = new EnumValue<CellValues>(CellValues.String);
                                subsubsubheadrow.AppendChild(subsubsubheadh);

                                foreach (var lower in accounts.Where(c => c.ParentAccountId == subsubsubhead.AccountId))
                                {
                                    count = count + 1;

                                    Row lowerrow;
                                    lowerrow = new Row() { RowIndex = RowIndex };
                                    sheetData.Append(lowerrow);
                                    RowIndex = RowIndex + 1;

                                    Cell lowerA = new Cell() { CellReference = "A" + count };
                                    lowerA.CellValue = new CellValue(lower.AccountCode);
                                    lowerA.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerA);

                                    Cell lowerb = new Cell() { CellReference = "B" + count };
                                    lowerb.CellValue = new CellValue(lower.AccountNameEn);
                                    lowerb.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerb);

                                    Cell lowerc = new Cell() { CellReference = "C" + count };
                                    lowerc.CellValue = new CellValue(lower.AccountLevel.ToString());
                                    lowerc.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerc);

                                    Cell lowerd = new Cell() { CellReference = "D" + count };
                                    lowerd.CellValue = new CellValue(lower.AccountCode.Substring(0, 1));
                                    lowerd.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerd);

                                    Cell lowere = new Cell() { CellReference = "E" + count };
                                    lowere.CellValue = new CellValue(lower.DefaultType);
                                    lowere.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowere);

                                    Cell lowerf = new Cell() { CellReference = "F" + count };
                                    lowerf.CellValue = new CellValue(lower.OpeningBalance.ToString());
                                    lowerf.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerf);

                                    Cell lowerg = new Cell() { CellReference = "G" + count };
                                    lowerg.CellValue = new CellValue(lower.ClosingBalance.ToString());
                                    lowerg.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerg);

                                    Cell lowerh = new Cell() { CellReference = "H" + count };
                                    lowerh.CellValue = new CellValue(lower.IsTransactionable.ToString());
                                    lowerh.DataType = new EnumValue<CellValues>(CellValues.String);
                                    lowerrow.AppendChild(lowerh);
                                }
                            }
                        }
                    }
                }

                // Append a new worksheet and associate it with the workbook.
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Chart of Account"
                };

                sheets.Append(sheet);

                workbookpart.Workbook.Save();
                spreadsheetDocument.Close();

                return File(mem.ToArray(), System.Net.Mime.MediaTypeNames.Application.Octet, "Chart of Account.xlsx");
            }

        }
    }
}
