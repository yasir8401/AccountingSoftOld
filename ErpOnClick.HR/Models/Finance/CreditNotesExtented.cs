using ErpOnClick.Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class CreditNotesExtented
    {
        public List<CreditNotesLinesInheritance> CreditNotesD { get; set; }
        //public InvoiceM InvoiceM { get; set; }

        public int CreditNoteId { get; set; }
        public string CreditNoteNo { get; set; }

        public int CustomerId { get; set; }
        //public bool? IsInternationalCust { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreditNoteDate { get; set; }
        public string Note { get; set; }
        //public string Currency { get; set; }
        //public decimal? DiscountPer { get; set; }

        //public string RefNo { get; set; }

        public decimal TaxRateId { get; set; }
        public decimal? TotalTax { get; set; }

        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }


    }
}
