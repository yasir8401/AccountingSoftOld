using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string Comments1 { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? CommentedBy { get; set; }
        public string DocType { get; set; }
        public int? RefId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Lookups DocTypeNavigation { get; set; }
    }
}
