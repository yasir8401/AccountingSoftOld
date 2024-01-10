using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;


namespace ErpOnClick.ErpMain.Areas.ESS.Controllers
{

    [Area("ESS")]
    [Authorize]
    public class BaseController : Controller
    {
        public int GetEmployeeId()
        {

            var claimsPrincipal = new ClaimsPrincipal(User.Identity);
            string empId = claimsPrincipal.Claims.Where(c => c.Type == "EmployeeId")
                           .Select(c => c.Value).SingleOrDefault();

            return empId != null ? Convert.ToInt32(empId) : 0;

        }
    }
}
