using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class CreditNotes
    {
        public CreditNotes()
        {
            CreditNotesLines = new HashSet<CreditNotesLines>();
        }

        public int CreditNoteId { get; set; }
        public DateTime? CreditNoteDate { get; set; }
        public string CreditNoteNo { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DueDate { get; set; }
        public string RefNo { get; set; }
        public string Currency { get; set; }
        public int? TaxRateId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? DiscountPer { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Total { get; set; }
        public string Note { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedBy { get; set; }
        public string GlBatchId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual TaxRates TaxRate { get; set; }
        public virtual ICollection<CreditNotesLines> CreditNotesLines { get; set; }
    }
}
