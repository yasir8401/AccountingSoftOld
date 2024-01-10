using ErpOnClick.ErpMain.Models;
using ErpOnClick.DAL.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class ApprovalTaskRouteViewModel
    {
        public ApprovalTasks ApprovalTask { get; set; }
        public IList<ApprovalRouteInherited> ApprovalRoutes { get; set; }


    }
}
