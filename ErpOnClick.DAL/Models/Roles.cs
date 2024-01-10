using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolePrivileges = new HashSet<RolePrivileges>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleId { get; set; }
        public string RoleNameEn { get; set; }
        public string RoleNameAr { get; set; }
        public string RoleDescriptionEn { get; set; }
        public string RoleDescriptionAr { get; set; }
        public string RoleCode { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<RolePrivileges> RolePrivileges { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
