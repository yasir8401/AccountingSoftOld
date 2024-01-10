using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class ImportVoucher
    {
        public string Date { get; set; }
        public string AccountCode { get; set; }
        public string AccountTitle { get; set; }

        public string EmployeeCode { get; set; }
        public string EmployeeTitle { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
    }
}
