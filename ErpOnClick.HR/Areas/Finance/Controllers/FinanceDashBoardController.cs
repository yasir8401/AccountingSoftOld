using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace ErpOnClick.ErpMain.Areas.Finance.Controllers
{
    [Area("Finance")]
    [Authorize]
    public class FinanceDashBoardController : Controller
    {
        private readonly ILogger<FinanceDashBoardController> _logger;
        private ICustomersService _CustomerService;
        private IVendorsService _VendorService;
        private IAccountTypesService _AccountTypesService;
        private IAccountsService _AccountsService;
        private IGeneralEntriesLinesService _GeneralEntriesLinesService;
        private IItemsService _ItemsService;
        private IItemCategoriesService _ItemCategoriesService;

        private dynamic expObj;
        public FinanceDashBoardController(ILogger<FinanceDashBoardController> logger, IItemCategoriesService ItemCategoriesService, IItemsService ItemsService, IGeneralEntriesLinesService GeneralEntriesLinesService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, ICustomersService CustomersService, IVendorsService VendorsService)
        {
            _logger = logger;
            _CustomerService = CustomersService;
            _VendorService = VendorsService;
            _AccountTypesService = AccountTypesService;
            _AccountsService = AccountsService;
            _GeneralEntriesLinesService = GeneralEntriesLinesService;
            _ItemsService = ItemsService;
            _ItemCategoriesService = ItemCategoriesService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            DashboardViewModel viewModel = new DashboardViewModel();

            List<Customers> customers = _CustomerService.GetAll().ToList();
            List<Vendors> vendors = _VendorService.GetAll().ToList();
            List<AccountTypes> accountTypes = _AccountTypesService.GetAll().ToList();
            List<Accounts> accounts = _AccountsService.GetAll().ToList();
            List<IGrouping<Accounts, GeneralEntriesLines>> generalEntriesList = _GeneralEntriesLinesService.dbset().IncludeOptimized(x => x.Account).AsEnumerable().GroupBy(x => x.Account).ToList();
            List<ItemCategories> itemCategories = _ItemCategoriesService.GetAll().ToList();
            List<Items> items = _ItemsService.GetAll().ToList();

            viewModel.Build(customers, vendors, accountTypes, accounts, itemCategories, items, generalEntriesList);

            expObj.dashboardViewModel = viewModel;

            return PartialView(expObj);
        }
    }
}
