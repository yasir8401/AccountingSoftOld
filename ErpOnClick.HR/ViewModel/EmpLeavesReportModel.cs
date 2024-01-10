using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class EmpLeavesReportModel
    {
        public int EmployeeId { get; set; }
        public int Total { get; set; }
        public int Used { get; set; }
        public int Balance { get; set; }
        public string Employee { get; set; }
        public int Annual { get; set; }
        public int Sick { get; set; }
        public int Special { get; set; }
        public int Emergency { get; set; }
        public int Business { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}
