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

namespace ErpOnClick.Invoicing.Areas.FN.Controllers
{
    [Area("FN")]
    [Authorize]
    public class FixedAssetController : Controller
    {
        private readonly ILogger<FixedAssetController> _logger;
        private IAccountsService _AccountsService;
        private IFixedAssetService _FixedAssetService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private ILookupsService _LookupService;


        private dynamic expObj;
        public FixedAssetController(ILogger<FixedAssetController> logger, ILookupsService LookupTypesService, ICompanyService CompanyService, IBranchService BranchService, IFixedAssetService FixedAssetService, IAccountsService AccountsService)
        {
            _logger = logger;
            _AccountsService = AccountsService;
            _LookupService = LookupTypesService;

            _FixedAssetService = FixedAssetService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            var lookupList = _LookupService.GetAll();
            expObj.AssetType = lookupList.Where(x => x.LookupTypeId == LookupTypList.AssetType_036).ToList();

            return View(expObj);
        }

        public IActionResult _list(DateTime PurchaseDateFrom, DateTime PurchaseDateTo, string AssetType, DateTime WarrantyDateFrom, DateTime WarrantyDateTo)
        {
            string purchaseDateFrom = PurchaseDateFrom.ToString("yyyy-MM-dd");
            string purchaseDateTo = PurchaseDateTo.ToString("yyyy-MM-dd");
            string warrantyDateFrom = WarrantyDateFrom.ToString("yyyy-MM-dd");
            string warrantyDateTo = WarrantyDateTo.ToString("yyyy-MM-dd");
            expObj.FixedAssetIdList = _FixedAssetService.dbset()
                .Include(c => c.Account)
                .Include(c=>c.AssetType)
                .Where(c => (c.AssetTypeId == AssetType || AssetType == null)
                && (purchaseDateFrom != "0001-01-01" && c.PurchaseDate >= Convert.ToDateTime(purchaseDateFrom) || purchaseDateFrom == "0001-01-01")
                && (purchaseDateTo != "0001-01-01" && c.PurchaseDate <= Convert.ToDateTime(purchaseDateTo) || purchaseDateTo == "0001-01-01")
                && (warrantyDateFrom != "0001-01-01" && c.WarrantyExpiry >= Convert.ToDateTime(warrantyDateFrom) || warrantyDateFrom == "0001-01-01")
                && (warrantyDateTo != "0001-01-01" && c.WarrantyExpiry <= Convert.ToDateTime(warrantyDateTo) || warrantyDateTo == "0001-01-01"))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(DateTime PurchaseDateFrom, DateTime PurchaseDateTo, string AssetType, DateTime WarrantyDateFrom, DateTime WarrantyDateTo)
        {
            string purchaseDateFrom = PurchaseDateFrom.ToString("yyyy-MM-dd");
            string purchaseDateTo = PurchaseDateTo.ToString("yyyy-MM-dd");
            string warrantyDateFrom = WarrantyDateFrom.ToString("yyyy-MM-dd");
            string warrantyDateTo = WarrantyDateTo.ToString("yyyy-MM-dd");

            expObj.PurchaseDateFrom = PurchaseDateFrom.ToString("yyyy-MM-dd");
            expObj.PurchaseDateTo = PurchaseDateTo.ToString("yyyy-MM-dd");
            if (AssetType == null)
            {
                expObj.AssetType = "All";
            }
            else
            {
                expObj.AssetType = AssetType;
            }
            expObj.WarrantyDateFrom = WarrantyDateFrom.ToString("yyyy-MM-dd");
            expObj.WarrantyDateTo = WarrantyDateTo.ToString("yyyy-MM-dd");

            expObj.FixedAssetIdList = _FixedAssetService.dbset()
                .Include(c => c.Account)
                .Include(c=>c.AssetType)
                .Where(c => (c.AssetTypeId == AssetType || AssetType == null)
                && (purchaseDateFrom != "0001-01-01" && c.PurchaseDate >= Convert.ToDateTime(purchaseDateFrom) || purchaseDateFrom == "0001-01-01")
                && (purchaseDateTo != "0001-01-01" && c.PurchaseDate <= Convert.ToDateTime(purchaseDateTo) || purchaseDateTo == "0001-01-01")
                && (warrantyDateFrom != "0001-01-01" && c.WarrantyExpiry >= Convert.ToDateTime(warrantyDateFrom) || warrantyDateFrom == "0001-01-01")
                && (warrantyDateTo != "0001-01-01" && c.WarrantyExpiry <= Convert.ToDateTime(warrantyDateTo) || warrantyDateTo == "0001-01-01"))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetById(1);
            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            var lookupList = _LookupService.GetAll();
            expObj.DepreciationMethod = lookupList.Where(x => x.LookupTypeId == LookupTypList.DepreciationMethod_034).ToList();
            expObj.AverageMethod = lookupList.Where(x => x.LookupTypeId == LookupTypList.AverageMethod_035).ToList();
            expObj.AssetType = lookupList.Where(x => x.LookupTypeId == LookupTypList.AssetType_036).ToList();
            expObj.IdDetail = _FixedAssetService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.AccountList = _AccountsService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(FixedAsset postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.CreatedDate = System.DateTime.Now;
                postedData.CreatedBy = 1;
                postedData.PortalId = 0;

                result.msg = _FixedAssetService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _FixedAssetService.SaveChanges();
                    result.scalerVal = postedData.FixedAssetId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(FixedAsset postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _FixedAssetService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _FixedAssetService.SaveChanges();
                    result.scalerVal = postedData.FixedAssetId;
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
                _FixedAssetService.Delete(id);
                result.msg = _FixedAssetService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }
    }
}
