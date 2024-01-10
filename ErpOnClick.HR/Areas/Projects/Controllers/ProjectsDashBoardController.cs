using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.Projects.Controllers
{
    public class ProjectsDashBoardController : Controller
    {
        [Area("Projects")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
