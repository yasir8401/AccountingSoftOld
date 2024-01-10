using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class GeneralEntriesLines
    {
        public int LineId { get; set; }
        public int? GeneralEntryId { get; set; }
        public int? AccountId { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual GeneralEntries GeneralEntry { get; set; }
    }
}
