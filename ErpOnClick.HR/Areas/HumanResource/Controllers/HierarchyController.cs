using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ErpOnClick.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ErpOnClick.ErpMain.Areas.Organisation.Controllers
{
    [Area("HumanResource")]

    public class HierarchyController : Controller
    {
        private readonly ILogger<HierarchyController> _logger;
        private ICompanyService companyService;
        private IBranchService branchService;
        private IDivisionsService _DivisionService;
  

        private dynamic expObj;

        public HierarchyController(ILogger<HierarchyController> logger, ICompanyService companyService, IBranchService branchService, IDivisionsService divisionService)
        {
            _logger = logger;
            this.companyService = companyService;
            this.branchService = branchService;
            _DivisionService = divisionService;

            expObj = new ExpandoObject();

        }

        public IActionResult Index()
        {
            expObj.companyService = companyService.dbset()
                .Include(x=>x.Branch)
                .Include(x => x.Divisions)
                .Include(x => x.Departments)
                .Include(x => x.Sections)
                .Include(x => x.SubSections)
                .Include(x => x.Units)
                .Include(x => x.Teams)
                .ToList();

            //expObj.DivisionList = _DivisionService.dbset().Include(x => x.DivisionHeadU).Include(x => x.ReportingToU).Include(b => b.Branch).Include(c => c.Company).ToList();

            return View(expObj);
        }
    }
}
