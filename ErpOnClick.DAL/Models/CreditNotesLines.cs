using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class CreditNotesLines
    {
        public int LineId { get; set; }
        public int? CreditNoteId { get; set; }
        public int? ItemId { get; set; }
        public string Description { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? TaxRateId { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? LineAmount { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual CreditNotes CreditNote { get; set; }
        public virtual Items Item { get; set; }
        public virtual TaxRates TaxRateNavigation { get; set; }
    }
}
