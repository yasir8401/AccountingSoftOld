using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class EmpAttendacesViewModel
    {
        public  IList<ErpOnClick.DAL.Models.EmpAttendance> Attendance { get; set; }
        public  IList<ErpOnClick.DAL.Models.Emp> Emp { get; set; }
    }
}
