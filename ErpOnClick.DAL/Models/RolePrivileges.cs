using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class RolePrivileges
    {
        public int RolePrivilegeId { get; set; }
        public int? RoleId { get; set; }
        public int PrivilegeId { get; set; }
        public DateTime? FromDate { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Privileges Privilege { get; set; }
        public virtual Roles Role { get; set; }
    }
}
