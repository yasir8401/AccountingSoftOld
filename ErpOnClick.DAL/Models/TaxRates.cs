using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class TaxRates
    {
        public TaxRates()
        {
            Bills = new HashSet<Bills>();
            BillsLines = new HashSet<BillsLines>();
            CreditNotes = new HashSet<CreditNotes>();
            CreditNotesLines = new HashSet<CreditNotesLines>();
            FeeVouchersLines = new HashSet<FeeVouchersLines>();
            Invoices = new HashSet<Invoices>();
            InvoicesLines = new HashSet<InvoicesLines>();
            Refunds = new HashSet<Refunds>();
            RefundsLines = new HashSet<RefundsLines>();
        }

        public int TaxRateId { get; set; }
        public string TaxRateNameEn { get; set; }
        public string TaxRateNameAr { get; set; }
        public decimal? TaxPercent { get; set; }
        public bool? IsDefault { get; set; }
        public string ActiveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<Bills> Bills { get; set; }
        public virtual ICollection<BillsLines> BillsLines { get; set; }
        public virtual ICollection<CreditNotes> CreditNotes { get; set; }
        public virtual ICollection<CreditNotesLines> CreditNotesLines { get; set; }
        public virtual ICollection<FeeVouchersLines> FeeVouchersLines { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<InvoicesLines> InvoicesLines { get; set; }
        public virtual ICollection<Refunds> Refunds { get; set; }
        public virtual ICollection<RefundsLines> RefundsLines { get; set; }
    }
}
