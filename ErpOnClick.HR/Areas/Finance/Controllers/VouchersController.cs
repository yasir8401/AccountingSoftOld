using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Services;
using ErpOnClick.DAL.Utilities;
using ErpOnClick.ErpMain.Models;
using ErpOnClick.ErpMain.Models.Finance;
using ErpOnClick.ErpMain.ViewModel;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Syncfusion.XlsIO;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Admin.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class VouchersController : Controller
    {
        private readonly ILogger<VouchersController> _logger;
        private IVoucherService _VoucherService;
        private IVoucherLinesService _VoucherLinesService;
        private IAccountsService _AccountsService;
        private ITaxRatesService _TaxRatesService;
        private ICustomersService _customerService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ILookupsService _LookupsService;
        private IUserService _UserService;
        private IApprovalRouteDetailsService _ApprovalRouteDetailsService;
        private IApprovalRouteService _ApprovalRouteService;
        private IVendorsService _VendorsService;
        private IEmpsService _EmpsService;
        string wwwRootPath = "";

        public static IWebHostEnvironment _HostEnvironment;
        public static IHostingEnvironment _env;


        private ErpOnClick.DAL.Models.ERPonClickContext _dbcontext;
        dynamic expObj = new ExpandoObject();
        public VouchersController(IHostingEnvironment env, IEmpsService EmpsService, IVendorsService VendorsService, IWebHostEnvironment HostEnvironment, ILogger<VouchersController> logger, IApprovalRouteService ApprovalRouteService, IApprovalRouteDetailsService ApprovalRouteDetailsService, IUserService UserService, ILookupsService LookupsService, ITaxRatesService TaxRatesService, ICompanyService CompanyService, IBranchService BranchService, IAccountsService AccountsService, ErpOnClick.DAL.Models.ERPonClickContext dbcontext, ICustomersService customerService, IVoucherLinesService VoucherLinesService, IVoucherService VoucherService)
        {

            _env = env;

            _logger = logger;
            this._EmpsService = EmpsService;
            this._VendorsService = VendorsService;
            this._UserService = UserService;
            this._VoucherService = VoucherService;
            this._VoucherLinesService = VoucherLinesService;
            this._customerService = customerService;
            this._AccountsService = AccountsService;
            this._TaxRatesService = TaxRatesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            _LookupsService = LookupsService;
            _ApprovalRouteDetailsService = ApprovalRouteDetailsService;
            _ApprovalRouteService = ApprovalRouteService;
            this._dbcontext = dbcontext;
            wwwRootPath = HostEnvironment.WebRootPath;
            _HostEnvironment = HostEnvironment;
        }
        public IActionResult Index()
        {
            //expObj.types = _LookupsService.Find(c => c.LookupTypeId == "058").ToList();
            expObj.types = _LookupsService.Find(c => c.LookupTypeId == "061").ToList(); // for old db

            return View(expObj);
        }

        public IActionResult _list(string data, string DateFrom, string DateTo)
        {

            expObj.generalEntriesMList = _VoucherService.dbset().IncludeOptimized(c => c.VoucherTypeNavigation)
                .Where(c => (c.VoucherType == data || data == null || data == "0") && (DateFrom != "0001-01-01" && c.CreatedDate >= Convert.ToDateTime(DateFrom) || DateFrom == "0001-01-01")
                && (DateTo != "0001-01-01" && c.CreatedDate <= Convert.ToDateTime(DateTo).AddDays(1) || DateTo == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult Edit(int id)
        {
            expObj.voucherNo = 0;
            VoucherExtended voucherExtended = new VoucherExtended();
            var voucher = _VoucherService.GetById(id);
            if (voucher != null)
            {
                voucherExtended.CreatedByName = _UserService.dbset().Where(c => c.UserId == voucher.CreatedBy).Select(c => c.DisplayNameEn).FirstOrDefault();
                voucherExtended.CreatedByName = (voucherExtended.CreatedByName != null ? voucherExtended.CreatedByName : "Admin");

                var approvaldetails = _ApprovalRouteDetailsService.dbset().Where(c => c.RecordId == voucher.VoucherId.ToString()).ToList();
                var Status = "Not Yet Approved";
                var ApprovarName = "Not Yet Approved";
                var ActionDate = "Not Yet Approved";

                if (approvaldetails != null)
                {
                    foreach (var item in approvaldetails)
                    {
                        if (item.ApprovalStatus != "007001")
                        {
                            ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                            Status = item.ApprovalStatus;
                            ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();
                        }
                        else if (item.ApprovalStatus != "007002")
                        {
                            ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                            Status = item.ApprovalStatus;
                            ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();

                        }
                        else if (item.ApprovalStatus != "007003")
                        {
                            ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                            Status = item.ApprovalStatus;
                            ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();
                        }
                    }
                }
                if (Status == "007002")
                {
                    voucherExtended.ApprovedByName = ApprovarName;
                    voucherExtended.ApprovedDate = ActionDate;
                }


                voucherExtended.VendorId = voucher.VendorId;
                voucherExtended.CustomerId = voucher.CustomerId;
                voucherExtended.BranchId = voucher.BranchId;
                voucherExtended.CompanyId = voucher.CompanyId;
                voucherExtended.CreatedBy = voucher.CreatedBy;
                voucherExtended.CreatedDate = voucher.CreatedDate;
                voucherExtended.Currency = voucher.Currency;
                voucherExtended.Description = voucher.Description;
                voucherExtended.IsPosted = voucher.IsPosted;
                voucherExtended.ModifiedBy = voucher.ModifiedBy;
                voucherExtended.ModifiedDate = voucher.ModifiedDate;
                voucherExtended.PortalId = voucher.PortalId;
                voucherExtended.PostedBy = voucher.PostedBy;
                voucherExtended.PostedDate = voucher.PostedDate;
                voucherExtended.TotalCredit = voucher.TotalCredit;
                voucherExtended.TotalDebit = voucher.TotalDebit;
                voucherExtended.VoucherCode = voucher.VoucherCode;
                voucherExtended.VoucherEntryDate = voucher.VoucherEntryDate;
                voucherExtended.VoucherId = voucher.VoucherId;
                voucherExtended.VoucherLines = voucher.VoucherLines;
                voucherExtended.VoucherType = voucher.VoucherType;
            }

            expObj.voucherMDetail = voucherExtended;
            expObj.CustomersList = _customerService.GetAll().ToList();
            expObj.VendorsList = _VendorsService.GetAll().ToList();
            expObj.AccountsList = _AccountsService.GetAll().ToList();
            expObj.EmployeesList = _EmpsService.GetAll().ToList();
            expObj.VoucherTypes = _LookupsService.Find(c => c.LookupTypeId == "061").ToList();
            expObj.CompanyDetail = _CompanyService.GetAll();
            expObj.BranchDetail = _BranchService.GetAll();
            expObj.voucherDList = _VoucherLinesService.Find(c => (c.VoucherId == id)).ToList();

            if (id == 0 && _VoucherService.GetAll() != null && _VoucherService.GetAll().ToList() != null && _VoucherService.GetAll().ToList().Count > 0)
            {
                expObj.voucherNo = (_VoucherService.GetAll().ToList().Max(x => x.VoucherId) + 1).ToString("00000");
            }
            else if (id == 0)
            {
                expObj.voucherNo = "00001";
            }

            return View(expObj);
        }

        public IActionResult Posted(int id)
        {
            DbResult result = new DbResult();
            var userId = (HttpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);

            var voucher = _VoucherService.GetById(id);
            if (voucher != null)
            {
                var inpending = _ApprovalRouteDetailsService.dbset().Where(c => c.RecordId == voucher.VoucherId.ToString() && c.ApprovalStatus == "007001").Count();
                if (inpending > 0)
                {

                }
                else
                {
                    var routeMembers = _ApprovalRouteService.dbset().Where(c => c.ApprovalTaskId == 13).ToList();
                    if (routeMembers.Count() > 0)
                    {
                        foreach (var item in routeMembers)
                        {
                            ApprovalRoutesDetail newWorkflow = new ApprovalRoutesDetail
                            {
                                ApprovalRouteId = item.ApprovalRouteId,
                                ApproverUserId = item.UserId,
                                SeqId = item.SeqId,
                                RecordId = voucher.VoucherId.ToString(),
                                ApprovalTaskId = item.ApprovalTaskId.ToString(),
                                RequestedBy = userId,
                                DepartmentId = item.DepartmentId,
                                ApprovalStatus = "007001",
                                RecordNotes = " Vouche Code=" + voucher.VoucherCode + " & Voucher Type=" + voucher.VoucherType,
                                RecordName = "Voucher Request (Finance)",
                                CreatedDate = System.DateTime.Now,
                                CreatedBy = userId,
                                IsDepartment = item.IsDepartment
                            };
                            _ApprovalRouteDetailsService.Insert(newWorkflow);
                        }
                        result.msg = _ApprovalRouteDetailsService.SaveChanges();
                        if (result.msg == "")
                        {
                            voucher.IsPosted = true;
                            voucher.PostedDate = System.DateTime.Now;
                            _VoucherService.Update(voucher);
                            _VoucherService.SaveChanges();
                        }
                    }
                    else
                    {
                        result.msg = "Approval Route Not Found!";
                    }
                }
            }
            else
            {
                result.msg = "Voucher Not Found!";
            }

            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }

        public ActionResult PostAll()
        {
            DbResult result = new DbResult();
            var ApprovalRouteDetails = _ApprovalRouteDetailsService.GetAll();
            var ApprovalRoutes = _ApprovalRouteService.GetAll();
            var userId = (HttpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(HttpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);

            var vouchers = _VoucherService.dbset().Where(c => c.IsPosted == false).ToList();
            foreach (var voucher in vouchers)
            {
                if (voucher != null)
                {
                    var inpending = ApprovalRouteDetails.Where(c => c.RecordId == voucher.VoucherId.ToString() && c.ApprovalStatus == "007001").Count();
                    if (inpending > 0)
                    {

                    }
                    else
                    {
                        var routeMembers = ApprovalRoutes.Where(c => c.ApprovalTaskId == 13).ToList();
                        if (routeMembers.Count() > 0)
                        {
                            foreach (var item in routeMembers)
                            {
                                ApprovalRoutesDetail newWorkflow = new ApprovalRoutesDetail
                                {
                                    ApprovalRouteId = item.ApprovalRouteId,
                                    ApproverUserId = item.UserId,
                                    SeqId = item.SeqId,
                                    RecordId = voucher.VoucherId.ToString(),
                                    ApprovalTaskId = item.ApprovalTaskId.ToString(),
                                    RequestedBy = userId,
                                    DepartmentId = item.DepartmentId,
                                    ApprovalStatus = "007001",
                                    RecordNotes = " Vouche Code=" + voucher.VoucherCode + " & Voucher Type=" + voucher.VoucherType,
                                    RecordName = "Voucher Request (Finance)",
                                    CreatedDate = System.DateTime.Now,
                                    CreatedBy = userId,
                                    IsDepartment = item.IsDepartment
                                };
                                _ApprovalRouteDetailsService.Insert(newWorkflow);
                            }
                            result.msg = _ApprovalRouteDetailsService.SaveChanges();
                            if (result.msg == "")
                            {
                                voucher.IsPosted = true;
                                voucher.PostedDate = System.DateTime.Now;
                                _VoucherService.Update(voucher);
                                _VoucherService.SaveChanges();
                            }
                        }
                        else
                        {
                            result.msg = "Approval Route Not Found!";
                        }
                    }
                }
                else
                {
                    result.msg = "Voucher Not Found!";
                }
            }
            result.isError = (result.msg != "" ? true : false);

            return Json(new { result = result });
        }

        public IActionResult print(int id)
        {
            VoucherViewModel voucherViewModel = new VoucherViewModel();
            voucherViewModel.voucher = _VoucherService.dbset().Where(c => c.VoucherId == id).IncludeOptimized(c => c.VoucherTypeNavigation).FirstOrDefault();
            expObj.AccountsList = _AccountsService.GetAll().ToList();
            expObj.CompanyDetail = _CompanyService.GetAll().FirstOrDefault();
            expObj.BranchDetail = _BranchService.GetAll().FirstOrDefault();
            expObj.VoucherDList = _VoucherLinesService.Find(c => (c.VoucherId == id)).ToList();
            expObj.Users = _UserService.GetAll();
            expObj.Emps = _EmpsService.GetAll();

            var approvaldetails = _ApprovalRouteDetailsService.dbset().Where(c => c.RecordId == id.ToString()).ToList();
            var Status = "Not Yet Approved";
            var ApprovarName = "Not Yet Approved";
            var ActionDate = "Not Yet Approved";

            if (approvaldetails != null)
            {
                foreach (var item in approvaldetails)
                {
                    if (item.ApprovalStatus != "007001")
                    {
                        ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                        Status = item.ApprovalStatus;
                        ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();
                    }
                    else if (item.ApprovalStatus != "007002")
                    {
                        ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                        Status = item.ApprovalStatus;
                        ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();

                    }
                    else if (item.ApprovalStatus != "007003")
                    {
                        ActionDate = Convert.ToDateTime(item.ActionDate).ToString("dd-MMM-yyyy");
                        Status = item.ApprovalStatus;
                        ApprovarName = _UserService.dbset().Where(c => c.UserId == item.ApproverUserId).Select(c => c.DisplayNameEn).FirstOrDefault();
                    }
                }
            }
            if (Status == "007002")
            {
                voucherViewModel.ApprovedByName = ApprovarName;
                voucherViewModel.ApprovedDate = ActionDate;
            }
            else if (Status == "007001")
            {
                voucherViewModel.ApprovedByName = "Not Yet Approved";
                voucherViewModel.ApprovedDate = ActionDate;
            }

            expObj.VoucherMDetails = voucherViewModel;
            return View(expObj);
        }

        public IActionResult GetAccountTitle(int account)
        {
            DbResult result = new DbResult();

            var accountTitle = _AccountsService.dbset().Where(c => c.AccountId == account).Select(c => c.AccountNameEn).FirstOrDefault();
            result.msg = accountTitle;
            result.isError = false;
            return Json(new { result = result });

        }

        public IActionResult GetEmployeeTitle(int employee)
        {
            DbResult result = new DbResult();

            var employeeTitle = _EmpsService.dbset().Where(c => c.EmpId == employee).Select(c => c.FirstNameEn).FirstOrDefault();
            result.msg = employeeTitle;
            result.isError = false;
            return Json(new { result = result });

        }

        [HttpPost]
        public IActionResult Save(VoucherLinesExtended vouceherLines)
        {
            DbResult result = new DbResult();
            var voucherMId = 0;
            if (ModelState.IsValid)
            {
                if (vouceherLines != null)
                {
                    Voucher voucehrM = new Voucher();
                    voucehrM.CreatedBy = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault());
                    voucehrM.CreatedDate = System.DateTime.Now;
                    voucehrM.VoucherType = vouceherLines.VoucherType;
                    voucehrM.PortalId = 0;
                    voucehrM.CompanyId = 1;
                    voucehrM.BranchId = 1;
                    voucehrM.IsPosted = false;
                    voucehrM.VoucherEntryDate = vouceherLines.VoucherEntryDate;
                    voucehrM.VoucherCode = vouceherLines.VoucherCode;
                    voucehrM.Description = vouceherLines.Description;
                    voucehrM.TotalCredit = vouceherLines.TotalCredit;
                    voucehrM.TotalDebit = vouceherLines.TotalDebit;
                    voucehrM.CustomerId = vouceherLines.CustomerId;
                    voucehrM.VendorId = vouceherLines.VendorId;
                    result.msg = _VoucherService.Insert(voucehrM);
                    if (result.msg == "")
                    {
                        var type = _LookupsService.Find(c => c.Code == voucehrM.VoucherType).Select(c => c.LookupNameEn).FirstOrDefault();
                        result.msg = _VoucherService.SaveChanges();
                        voucehrM.VoucherCode = (type.Substring((type.IndexOf('('))) + voucehrM.VoucherId).Replace("(", "").Replace(")", "");
                        _VoucherService.Update(voucehrM);
                        result.msg = _VoucherService.SaveChanges();

                        voucherMId = voucehrM.VoucherId;
                        if (vouceherLines.VoucherLinesD != null)
                        {
                            foreach (var item in vouceherLines.VoucherLinesD)
                            {
                                item.VoucherId = voucherMId;
                                item.PortalId = 0;
                                item.Description = voucehrM.Description;
                                item.CompanyId = 1;
                                item.BranchId = 1;
                                item.CreatedBy = 0;
                                item.CreatedDate = System.DateTime.Now;
                                result.msg = _VoucherLinesService.Insert(item);
                                if (result.msg == "")
                                {
                                    result.msg = _VoucherLinesService.SaveChanges();
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
        public ActionResult Update(VoucherLinesExtended vouceherLines)
        {
            DbResult result = new DbResult();
            if (vouceherLines != null)
            {
                if (vouceherLines.VoucherId != 0)
                {
                    Voucher voucherMDetail = _VoucherService.GetById(vouceherLines.VoucherId);
                    voucherMDetail.ModifiedDate = System.DateTime.Now;
                    voucherMDetail.ModifiedBy = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault());
                    voucherMDetail.VoucherType = vouceherLines.VoucherType;
                    voucherMDetail.TotalDebit = vouceherLines.TotalDebit;
                    voucherMDetail.TotalCredit = vouceherLines.TotalCredit;
                    voucherMDetail.VoucherEntryDate = vouceherLines.VoucherEntryDate;
                    voucherMDetail.Description = vouceherLines.Description;
                    voucherMDetail.VoucherCode = vouceherLines.VoucherCode;
                    voucherMDetail.IsPosted = voucherMDetail.IsPosted;
                    voucherMDetail.PostedDate = voucherMDetail.PostedDate;
                    voucherMDetail.CustomerId = vouceherLines.CustomerId;
                    voucherMDetail.VendorId = vouceherLines.VendorId;

                    if (vouceherLines.VoucherLinesD.Count != 0)
                    {
                        foreach (var i in vouceherLines.VoucherLinesD)
                        {
                            if (i.CreatedDate == null && i.CreatedBy == null)
                            {
                                i.Description = voucherMDetail.Description;

                                i.PortalId = 0;
                                i.CompanyId = 1;
                                i.BranchId = 1;
                                i.CreatedBy = 0;
                                i.CreatedDate = System.DateTime.Now;
                            }
                            i.VoucherId = vouceherLines.VoucherId;
                        }
                        _dbcontext.VoucherLines.UpdateRange(vouceherLines.VoucherLinesD);
                        _dbcontext.SaveChanges();
                    }

                    foreach (var item in vouceherLines.VoucherLinesD)
                    {
                        item.ModifiedDate = System.DateTime.Now;
                        item.ModifiedBy = 1;
                        if (item.IsDeleted == "true")
                        {
                            _dbcontext.VoucherLines.Remove(item);
                        }
                    }
                    _dbcontext.SaveChanges();

                    _dbcontext.Voucher.Update(voucherMDetail);
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
                Voucher obj = _dbcontext.Voucher.Find(id);
                var voucherDList = _dbcontext.VoucherLines.Where(x => x.VoucherId == id).ToList();
                _dbcontext.VoucherLines.RemoveRange(voucherDList);
                _dbcontext.SaveChanges();


                _dbcontext.Voucher.Remove(obj);
                _dbcontext.SaveChanges();
                result.msg = "deleted";
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";


            return Json(new { result = result });
        }

        [HttpPost]
        public async Task<IActionResult> ImportDataAsync(IFormFile File)
        {
            DbResult result = new DbResult();
            List<ImportVoucher> datas = new List<ImportVoucher>();

            string filePath = String.Empty;

            var attachmentfilePath = await FileHandling.UploadExcelFile(_HostEnvironment, File, "voucher_file");
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
                            if (reader.GetValue(0).ToString() == "Date" && reader.GetValue(1).ToString() == "Account Code" && reader.GetValue(2).ToString() == "Account Title" && reader.GetValue(3).ToString() == "Employee Id/Code" && reader.GetValue(4).ToString() == "Employee Title" && reader.GetValue(5).ToString() == "Description" && reader.GetValue(6).ToString() == "Debit" && reader.GetValue(7).ToString() == "Credit" && reader.GetValue(8).ToString() == "Reference" && reader.GetValue(9).ToString() == "Type")
                            {
                            }
                            else
                            {
                                datas.Add(new ImportVoucher
                                {
                                    Date = (reader.GetValue(0) != null ? reader.GetValue(0) : "").ToString(),
                                    AccountCode = (reader.GetValue(1) != null ? reader.GetValue(1) : "").ToString(),
                                    AccountTitle = (reader.GetValue(2) != null ? reader.GetValue(2) : "").ToString(),
                                    EmployeeCode = (reader.GetValue(3) != null ? reader.GetValue(3) : "").ToString(),
                                    EmployeeTitle = (reader.GetValue(4) != null ? reader.GetValue(4) : "").ToString(),
                                    Description = (reader.GetValue(5) != null ? reader.GetValue(5) : "").ToString(),
                                    Debit = Convert.ToDecimal((reader.GetValue(6) != null ? reader.GetValue(6) : 0)),
                                    Credit = Convert.ToDecimal((reader.GetValue(7) != null ? reader.GetValue(7) : 0)),
                                    Reference = (reader.GetValue(8) != null ? reader.GetValue(8) : "").ToString(),
                                    Type = (reader.GetValue(9) != null ? reader.GetValue(9) : "").ToString()
                                });
                            }
                        }
                    }
                }
                foreach (var item in datas.GroupBy(c => c.Description))
                {
                    bool flag = false;
                    foreach (var inneritem in item)
                    {
                        var checkaccount = _AccountsService.dbset().Where(c => c.AccountCode == inneritem.AccountCode).FirstOrDefault();
                        if (checkaccount != null)
                        {

                            List<VoucherLines> lines = _VoucherLinesService.dbset().Where(c => c.AccountId == checkaccount.AccountId && c.Credit == inneritem.Credit && c.Debit == inneritem.Debit && c.Description == inneritem.Description && c.Refno1 == inneritem.Reference && c.EmployeeId.ToString() == inneritem.EmployeeCode).ToList();
                            if (lines.Count() > 0)
                            {

                            }
                            else
                            {
                                //var checkaccount = _AccountsService.dbset().Where(c => c.AccountCode == inneritem.AccountCode).FirstOrDefault();
                                if (checkaccount != null && checkaccount.IsTransactionable == true) //Accounts exist and Is Transactionable
                                {
                                    Voucher voucher = new Voucher();
                                    voucher.CreatedBy = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault());
                                    voucher.CreatedDate = System.DateTime.Now;
                                    voucher.PortalId = 0;
                                    voucher.CompanyId = 1;
                                    voucher.BranchId = 1;
                                    voucher.IsPosted = false;
                                    voucher.VoucherEntryDate = Convert.ToDateTime(inneritem.Date);
                                    voucher.VoucherType = _LookupsService.Find(c => c.LookupNameEn.Contains(inneritem.Type)).Select(c => c.Code).FirstOrDefault();
                                    //voucher.VoucherCode = vouceherLines.VoucherCode;
                                    voucher.Description = inneritem.Description;
                                    voucher.TotalCredit = item.Sum(c => c.Credit);
                                    voucher.TotalDebit = item.Sum(c => c.Debit);
                                    result.msg = _VoucherService.Insert(voucher);
                                    if (result.msg == "")
                                    {
                                        var type = _LookupsService.Find(c => c.Code == voucher.VoucherType).Select(c => c.LookupNameEn).FirstOrDefault();
                                        result.msg = _VoucherService.SaveChanges();
                                        voucher.VoucherCode = (type.Substring((type.IndexOf('('))) + voucher.VoucherId).Replace("(", "").Replace(")", "");
                                        _VoucherService.Update(voucher);
                                        result.msg = _VoucherService.SaveChanges();
                                        flag = true;
                                        foreach (var inner in item)
                                        {
                                            var accountdetails = _AccountsService.dbset().Where(c => c.AccountCode == inner.AccountCode).FirstOrDefault();

                                            VoucherLines line = new VoucherLines();
                                            line.Debit = inner.Debit;
                                            line.Credit = inner.Credit;
                                            line.Refno1 = inner.Reference;
                                            line.AccountId = Convert.ToInt32(accountdetails.AccountId);
                                            line.EmployeeId = Convert.ToInt32(inner.EmployeeCode);
                                            line.VoucherId = voucher.VoucherId;
                                            line.Description = inner.Description;
                                            line.PortalId = 0;
                                            line.CompanyId = 1;
                                            line.BranchId = 1;
                                            line.CreatedBy = Convert.ToInt32(User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault()); ;
                                            line.CreatedDate = System.DateTime.Now;
                                            result.msg = _VoucherLinesService.Insert(line);
                                            if (result.msg == "")
                                            {
                                                result.msg = _VoucherLinesService.SaveChanges();
                                            }
                                        }
                                        result.isError = (result.msg != "" ? true : false);
                                    }
                                }
                                else //Accounts not exist or IsNotTransactionable
                                {

                                }
                            }
                            result.isError = false;
                            result.msg = filePath;

                        }
                        else
                        {
                            result.isError = true;
                            result.msg = "Accounts Used in Vouchers, are not Present in System.";
                        }
                    }
                }
            }
            if (datas == null)
            {
                result.isError = false;
                result.msg = filePath;
            }
            return Json(new { result = result });
        }

        public IActionResult DownloadExcelDocument()
        {
            DbResult result = new DbResult();
            List<Voucher> vouchers = _VoucherService.dbset().IncludeOptimized(c => c.VoucherTypeNavigation).ToList();
            List<VoucherLines> voucherlines = _VoucherLinesService.dbset().IncludeOptimized(c => c.Voucher).IncludeOptimized(c => c.Account).ToList();
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
                worksheet.Name = "Vouchers";
                worksheet.Range["A1"].Text = "Date";
                worksheet.Range["B1"].Text = "Account Code";
                worksheet.Range["C1"].Text = "Account Title";
                worksheet.Range["D1"].Text = "Employee Id/Code";
                worksheet.Range["E1"].Text = "Employee Title";
                worksheet.Range["F1"].Text = "Description";
                worksheet.Range["G1"].Text = "Debit";
                worksheet.Range["H1"].Text = "Credit";
                worksheet.Range["I1"].Text = "Reference";
                worksheet.Range["J1"].Text = "Type";
                count = 1;

                foreach (var item in voucherlines.GroupBy(c => c.VoucherId))
                {
                    foreach (var inneritem in item)
                    {
                        var user = _UserService.dbset().Where(c => c.UserId == inneritem.EmployeeId).Select(c => c.DisplayNameEn).FirstOrDefault();
                        count = count + 1;
                        worksheet.Range["A" + count].Value += (inneritem.Voucher.VoucherEntryDate != null ? Convert.ToDateTime(inneritem.Voucher.VoucherEntryDate).ToString("dd-MMM-yyyy") : "");
                        worksheet.Range["B" + count].Value += (inneritem.Account.AccountCode != null ? inneritem.Account.AccountCode : "");
                        worksheet.Range["C" + count].Value += (inneritem.Account.AccountNameEn != null ? inneritem.Account.AccountNameEn : "");
                        worksheet.Range["D" + count].Value += (inneritem.EmployeeId != null ? inneritem.EmployeeId : 0).ToString();
                        worksheet.Range["E" + count].Value += (inneritem.EmployeeId != null ? user : "Not Found").ToString();
                        worksheet.Range["F" + count].Value += (inneritem.Voucher.Description != null ? inneritem.Voucher.Description : "").ToString();
                        worksheet.Range["G" + count].Value += (inneritem.Debit != null ? inneritem.Debit : 0).ToString();
                        worksheet.Range["H" + count].Value += (inneritem.Credit != null ? inneritem.Credit : 0).ToString();
                        worksheet.Range["I" + count].Value += (inneritem.Refno1 != null ? inneritem.Refno1 : "").ToString();
                        worksheet.Range["J" + count].Value += inneritem.Voucher.VoucherTypeNavigation.LookupNameEn.Substring(inneritem.Voucher.VoucherTypeNavigation.LookupNameEn.IndexOf('(')).Replace("(", "").Replace(")", "").ToString();
                    }
                }
                //Saving the Excel to the MemoryStream 
                MemoryStream stream = new MemoryStream();

                workbook.SaveAs(stream);

                //Set the position as '0'.
                stream.Position = 0;

                //Download the Excel file in the browser
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/excel");

                fileStreamResult.FileDownloadName = "voucher_file.xlsx";

                return fileStreamResult;
            }
        }

        public IActionResult ExcelDocument()
        {
            DbResult result = new DbResult();
            List<Voucher> vouchers = _VoucherService.dbset().IncludeOptimized(c => c.VoucherTypeNavigation).ToList();
            List<VoucherLines> voucherlines = _VoucherLinesService.dbset().IncludeOptimized(c => c.Voucher).IncludeOptimized(c => c.Account).ToList();
            IFormFile file = null;
            UInt32 RowIndex = 1;
            var count = 0;
            string filePath = String.Empty;


            using (MemoryStream mem = new MemoryStream())
            {
                SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(mem, SpreadsheetDocumentType.Workbook);
                var users = _UserService.GetAll();
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
                A1.CellValue = new CellValue("Date");
                A1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(A1);

                Cell B1 = new Cell() { CellReference = "B1" };
                B1.CellValue = new CellValue("Account Code");
                B1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(B1);

                Cell C1 = new Cell() { CellReference = "C1" };
                C1.CellValue = new CellValue("Account Title");
                C1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(C1);

                Cell D1 = new Cell() { CellReference = "D1" };
                D1.CellValue = new CellValue("Employee Id/Code");
                D1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(D1);

                Cell E1 = new Cell() { CellReference = "E1" };
                E1.CellValue = new CellValue("Employee Title");
                E1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(E1);

                Cell F1 = new Cell() { CellReference = "F1" };
                F1.CellValue = new CellValue("Description");
                F1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(F1);

                Cell G1 = new Cell() { CellReference = "G1" };
                G1.CellValue = new CellValue("Debit");
                G1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(G1);

                Cell H1 = new Cell() { CellReference = "H1" };
                H1.CellValue = new CellValue("Credit");
                H1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(H1);

                Cell I1 = new Cell() { CellReference = "I1" };
                I1.CellValue = new CellValue("Reference");
                I1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(I1);

                Cell J1 = new Cell() { CellReference = "J1" };
                J1.CellValue = new CellValue("Type");
                J1.DataType = new EnumValue<CellValues>(CellValues.String);
                row.AppendChild(J1);

                count = 1;
                foreach (var item in voucherlines.GroupBy(c => c.VoucherId))
                {
                    foreach (var inneritem in item)
                    {
                        var user = users.Where(c => c.UserId == inneritem.EmployeeId).Select(c => c.DisplayNameEn).FirstOrDefault();
                        count = count + 1;

                        Row headrow;
                        headrow = new Row() { RowIndex = RowIndex };
                        sheetData.Append(headrow);
                        RowIndex = RowIndex + 1;

                        Cell HeadA = new Cell() { CellReference = "A" + count };
                        HeadA.CellValue = new CellValue((inneritem.Voucher.VoucherEntryDate != null ? Convert.ToDateTime(inneritem.Voucher.VoucherEntryDate).ToString("dd-MMM-yyyy") : ""));
                        HeadA.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(HeadA);

                        Cell headb = new Cell() { CellReference = "B" + count };
                        headb.CellValue = new CellValue((inneritem.Account.AccountCode != null ? inneritem.Account.AccountCode : ""));
                        headb.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headb);

                        Cell headc = new Cell() { CellReference = "C" + count };
                        headc.CellValue = new CellValue((inneritem.Account.AccountNameEn != null ? inneritem.Account.AccountNameEn : ""));
                        headc.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headc);

                        Cell headd = new Cell() { CellReference = "D" + count };
                        headd.CellValue = new CellValue((inneritem.EmployeeId != null ? inneritem.EmployeeId : 0).ToString());
                        headd.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headd);

                        Cell heade = new Cell() { CellReference = "E" + count };
                        heade.CellValue = new CellValue((inneritem.EmployeeId != null ? user : "Not Found").ToString());
                        heade.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(heade);

                        Cell headf = new Cell() { CellReference = "F" + count };
                        headf.CellValue = new CellValue((inneritem.Voucher.Description != null ? inneritem.Voucher.Description : "").ToString());
                        headf.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headf);

                        Cell headg = new Cell() { CellReference = "G" + count };
                        headg.CellValue = new CellValue((inneritem.Debit != null ? inneritem.Debit : 0).ToString());
                        headg.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headg);

                        Cell headh = new Cell() { CellReference = "H" + count };
                        headh.CellValue = new CellValue((inneritem.Credit != null ? inneritem.Credit : 0).ToString());
                        headh.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headh);

                        Cell headi = new Cell() { CellReference = "I" + count };
                        headi.CellValue = new CellValue((inneritem.Refno1 != null ? inneritem.Refno1 : "").ToString());
                        headi.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headi);

                        Cell headj = new Cell() { CellReference = "J" + count };
                        headj.CellValue = new CellValue(inneritem.Voucher.VoucherTypeNavigation.LookupNameEn.Substring(inneritem.Voucher.VoucherTypeNavigation.LookupNameEn.IndexOf('(')).Replace("(", "").Replace(")", "").ToString());
                        headj.DataType = new EnumValue<CellValues>(CellValues.String);
                        headrow.AppendChild(headj);
                    }
                }

                // Append a new worksheet and associate it with the workbook.
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "General Entries"
                };

                sheets.Append(sheet);

                workbookpart.Workbook.Save();
                spreadsheetDocument.Close();

                return File(mem.ToArray(), System.Net.Mime.MediaTypeNames.Application.Octet, "General Entries.xlsx");
            }
        }
    }
}
