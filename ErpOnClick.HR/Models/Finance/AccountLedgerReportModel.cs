using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class AccountLedgerReportModel
    {
        public string Account { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public int Voucher { get; set; }
        public string Type { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
   
}
