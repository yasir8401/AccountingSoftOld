using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Items
    {
        public Items()
        {
            BillsLines = new HashSet<BillsLines>();
            CreditNotesLines = new HashSet<CreditNotesLines>();
            InvoicesLines = new HashSet<InvoicesLines>();
            RefundsLines = new HashSet<RefundsLines>();
        }

        public int ItemId { get; set; }
        public string ItemNameEn { get; set; }
        public string ItemNameAr { get; set; }
        public string ItemCode { get; set; }
        public int? ItemCategoryId { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string Tags { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ItemCategories ItemCategory { get; set; }
        public virtual ICollection<BillsLines> BillsLines { get; set; }
        public virtual ICollection<CreditNotesLines> CreditNotesLines { get; set; }
        public virtual ICollection<InvoicesLines> InvoicesLines { get; set; }
        public virtual ICollection<RefundsLines> RefundsLines { get; set; }
    }
}
