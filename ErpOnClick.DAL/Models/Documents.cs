using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Documents
    {
        public int DocId { get; set; }
        public string DocNameEn { get; set; }
        public string DocNameAr { get; set; }
        public string DocOwnerType { get; set; }
        public int? DocOwnerId { get; set; }
        public string DocFile { get; set; }
        public string DocDesc { get; set; }
        public string DocIssuedFrom { get; set; }
        public DateTime? DocIssuedDate { get; set; }
        public DateTime? DocIssuedDateH { get; set; }
        public DateTime? DocEndDate { get; set; }
        public DateTime? DocEndDateH { get; set; }
        public string TitleEnInDoc { get; set; }
        public string TitleArInDoc { get; set; }
        public string DocType { get; set; }
        public int? RefId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Lookups DocIssuedFromNavigation { get; set; }
        public virtual Lookups DocOwnerTypeNavigation { get; set; }
        public virtual Lookups DocTypeNavigation { get; set; }
    }
}
