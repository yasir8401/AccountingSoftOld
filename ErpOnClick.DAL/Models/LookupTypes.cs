using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class LookupTypes
    {
        public LookupTypes()
        {
            Lookups = new HashSet<Lookups>();
        }

        public string LookupTypeId { get; set; }
        public string LookupTypeNameEn { get; set; }
        public string LookupTypeNameAr { get; set; }
        public bool? ActiveStatus { get; set; }
        public bool? Locked { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Lookups> Lookups { get; set; }
    }
}
