using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class GeneralEntries
    {
        public GeneralEntries()
        {
            GeneralEntriesLines = new HashSet<GeneralEntriesLines>();
        }

        public int GeneralEntryId { get; set; }
        public DateTime? GeneralEntryDate { get; set; }
        public string GeneralEntryNo { get; set; }
        public string Currency { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public string Note { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<GeneralEntriesLines> GeneralEntriesLines { get; set; }
    }
}
