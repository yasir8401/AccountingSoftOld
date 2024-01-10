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

namespace ErpOnClick.ErpMain.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly ILogger<ItemsController> _logger;
        private IItemsService _ItemsService;
        private IItemCategoriesService _ItemCategoriesService;
        private IBranchService _BranchService;
        private ICompanyService _CompanyService;
        private IUserService _UserService;

        private dynamic expObj;
        public ItemsController(IUserService UserService,ILogger<ItemsController> logger, ICompanyService CompanyService, IBranchService BranchService, IItemsService ItemsService, IItemCategoriesService ItemCategoriesService)
        {
            _UserService = UserService;
            _logger = logger;
            _ItemsService = ItemsService;
            _ItemCategoriesService = ItemCategoriesService;
            _BranchService = BranchService;
            _CompanyService = CompanyService;
            expObj = new ExpandoObject();
        }


        public IActionResult Index()
        {
            expObj.ItemsIdList = _ItemCategoriesService.GetAll();
            return View(expObj);
        }

        public IActionResult _list(int ItemCategoryId)
        {
            expObj.ItemsCategories = _ItemCategoriesService.GetAll();

            expObj.ItemsIdList = _ItemsService.dbset()
                .Include(x=>x.ItemCategory)
                .Where(c => (ItemCategoryId != 0 && c.ItemCategoryId == ItemCategoryId || ItemCategoryId == 0))
                .ToList();
            return PartialView(expObj);
        }

        public IActionResult PrintList(int ItemCategoryId)
        {
            expObj.ItemsCategories = _ItemCategoriesService.GetAll();

            if (ItemCategoryId == 0)
            {
                expObj.ItemCategory = "All";

            }
            else
            {
                expObj.ItemCategory = _ItemCategoriesService.GetById(ItemCategoryId).ItemCategoryNameEn;
            }

            expObj.ItemsIdList = _ItemsService.dbset()
                .Include(x=>x.ItemCategory)
                .Where(c => (ItemCategoryId != 0 && c.ItemCategoryId == ItemCategoryId || ItemCategoryId == 0))
                .ToList();
            expObj.CompanyDetail = _CompanyService.GetById(2);

            return PartialView(expObj);
        }


        public IActionResult edit(int id)
        {
            expObj.IdDetail = _ItemsService.GetById(id);
            if (expObj.IdDetail != null)
            {
                int compnayid = Convert.ToInt32(expObj.IdDetail.CompanyId);
                expObj.branchList = _BranchService.Find(c => c.CompanyId == compnayid).ToList();
            }
            else
            {
                expObj.branchList = _BranchService.GetAll();
            }
            expObj.ItemCategories = _ItemCategoriesService.GetAll();
            expObj.CompanyDetail = _CompanyService.GetAll();
            return View(expObj);
        }


        [HttpPost]
        public ActionResult save(Items postedData)
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

                result.msg = _ItemsService.Insert(postedData);
                if (result.msg == "")
                {
                    result.msg = _ItemsService.SaveChanges();
                    result.scalerVal = postedData.ItemId;
                }
                result.isError = (result.msg != "" ? true : false);
            }
            return Json(new { result = result });
        }

        [HttpPost]
        public ActionResult update(Items postedData)
        {
            DbResult result = new DbResult();
            if (ModelState.IsValid)
            {
                postedData.ModifiedDate = System.DateTime.Now;
                postedData.ModifiedBy = 1;

                result.msg = _ItemsService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _ItemsService.SaveChanges();
                    result.scalerVal = postedData.ItemId;
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
                _ItemsService.Delete(id);
                result.msg = _ItemsService.SaveChanges();
                result.isError = (result.msg != "" ? true : false);
            }
            else
                result.msg = "Id is null";
            return Json(new { result = result });
        }

    }
}
