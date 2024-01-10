using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.Inventory.Controllers
{
    public class InventoryDashBoardController : Controller
    {
        [Area("Inventory")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
