using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.Security.Controllers
{
    public class SecurityDashBoardController : Controller
    {
        [Area("Security")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
