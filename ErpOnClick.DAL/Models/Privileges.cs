using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Privileges
    {
        public Privileges()
        {
            RolePrivileges = new HashSet<RolePrivileges>();
            UserPrivileges = new HashSet<UserPrivileges>();
        }

        public int PrivilegeId { get; set; }
        public string PrivilegeNameEn { get; set; }
        public string PrivilegeNameAr { get; set; }
        public string PrivilegeDescriptionEn { get; set; }
        public string PrivilegeDescriptionAr { get; set; }
        public string PrivilegeCode { get; set; }
        public int? ModuleId { get; set; }
        public int NavigationId { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Navigations Navigation { get; set; }
        public virtual ICollection<RolePrivileges> RolePrivileges { get; set; }
        public virtual ICollection<UserPrivileges> UserPrivileges { get; set; }
    }
}
