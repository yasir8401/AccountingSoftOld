using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel.HumanResource
{
    public class PayRunViewModel
    {
        public EmpAttendanceReportViewModel empDetails { get; set; }
        public PayrunD payRund { get; set; }
    }
}
