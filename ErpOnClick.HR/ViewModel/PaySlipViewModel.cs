using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class PaySlipViewModel
    {
        public PayrunD PayRunD { get; set; }
        public List<PayrunPayslip> payrunPayslipsList { get; set; }
      
    }
}
