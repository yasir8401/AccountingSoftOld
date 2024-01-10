using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Navigations
    {
        public Navigations()
        {
            ActivityLog = new HashSet<ActivityLog>();
            Privileges = new HashSet<Privileges>();
        }

        public int NavigationId { get; set; }
        public string NavigationNameEn { get; set; }
        public string NavigationNameAr { get; set; }
        public int? ParentNavigationId { get; set; }
        public int? ModuleId { get; set; }
        public int? DisplayOrder { get; set; }
        public string NavUrl { get; set; }
        public string NavIcon { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDisable { get; set; }
        public string IsDeleted { get; set; }
        public bool? HasChild { get; set; }
        public string ShowInAnotherWindow { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Modules Module { get; set; }
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
    }
}
