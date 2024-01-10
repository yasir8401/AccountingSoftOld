using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.HumanResource.Controllers
{
    public class HRDashBoardController : Controller
    {
        [Area("HumanResource")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
