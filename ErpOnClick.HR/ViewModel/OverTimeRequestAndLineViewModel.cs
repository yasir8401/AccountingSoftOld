using ErpOnClick.DAL.Models;
using ErpOnClick.ErpMain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class OverTimeRequestAndLineViewModel
    {
        public OvertimeRequests OverTimeRequest { get; set; }
        public IList<OverTimeRequestLineInheritied> OvertimeRequestsLines { get; set; }

    }
}
