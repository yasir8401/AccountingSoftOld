using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class UserPrivileges
    {
        public int UserPrivilegeId { get; set; }
        public int? UserId { get; set; }
        public int PrivilegeId { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Privileges Privilege { get; set; }
        public virtual Users User { get; set; }
    }
}
