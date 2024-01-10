using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class TrailBalanceReportModel
    {
        public string Code { get; set; }
        public string Head { get; set; }
        public string SubHead { get; set; }
        public string Type { get; set; }
        public string Account { get; set; }
        public decimal? ODebit { get; set; }
        public decimal? OCredit { get; set; }
        public decimal? OTotal { get; set; }
        public decimal? ADebit { get; set; }
        public decimal? ACredit { get; set; }
        public decimal? ATotal { get; set; }
        public decimal? CDebit { get; set; }
        public decimal? CCredit { get; set; }
        public decimal? CTotal { get; set; }
    }
   
}
