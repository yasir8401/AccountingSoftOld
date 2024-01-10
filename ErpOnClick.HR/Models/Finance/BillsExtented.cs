using ErpOnClick.Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class BillsExtented
    {
        public List<BillsLinesInheritance> BillD { get; set; }
        //public InvoiceM InvoiceM { get; set; }

        public int BillId { get; set; }
        public string BillNo { get; set; }

        public int VendorId { get; set; }
        //public bool? IsInternationalCust { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? BillDate { get; set; }
        public string Note { get; set; }
        //public string Currency { get; set; }
        //public decimal? DiscountPer { get; set; }

        //public string RefNo { get; set; }

        public decimal TaxRateId { get; set; }
        public decimal? TotalTax { get; set; }

        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public int LineId { get; set; }



    }
}
