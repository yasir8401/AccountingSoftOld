using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class VoucherLinesExtended
    {
        public List<VoucherLinesInheritance> VoucherLinesD { get; set; }

        public int VoucherId { get; set; }
        public DateTime? VoucherEntryDate { get; set; }
        public string VoucherCode { get; set; }
        public string Currency { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public string Description { get; set; }
        public string VoucherType { get; set; }
        public int CustomerId { get; set; }
        public int VendorId { get; set; }



    }
}
