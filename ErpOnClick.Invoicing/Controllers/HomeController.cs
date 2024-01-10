using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ErpOnClick.Invoicing.Models;
using Microsoft.AspNetCore.Authorization;
using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace ErpOnClick.Invoicing.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICustomersService _CustomerService;
        private IVendorsService _VendorService;
        private IAccountTypesService _AccountTypesService;
        private IAccountsService _AccountsService;
        private IGeneralEntriesLinesService _GeneralEntriesLinesService;
        private IItemsService _ItemsService;
        private IItemCategoriesService _ItemCategoriesService;

        private dynamic expObj;
        public HomeController(ILogger<HomeController> logger, IItemCategoriesService ItemCategoriesService, IItemsService ItemsService, IGeneralEntriesLinesService GeneralEntriesLinesService, IAccountsService AccountsService, IAccountTypesService AccountTypesService, ICustomersService CustomersService, IVendorsService VendorsService)
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
            List<IGrouping<Accounts, GeneralEntriesLines>> generalEntriesList = _GeneralEntriesLinesService.dbset().Include(x => x.Account).AsEnumerable().GroupBy(x => x.Account).ToList();
            List<ItemCategories> itemCategories = _ItemCategoriesService.GetAll().ToList();
            List<Items> items = _ItemsService.GetAll().ToList();

            viewModel.Build(customers,vendors,accountTypes,accounts,generalEntriesList,itemCategories,items);

            expObj.dashboardViewModel = viewModel;

            return View(expObj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
