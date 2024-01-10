using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Modules
    {
        public Modules()
        {
            ActivityLog = new HashSet<ActivityLog>();
            Navigations = new HashSet<Navigations>();
        }

        public int ModuleId { get; set; }
        public string ModuleNameEn { get; set; }
        public string ModuleNameAr { get; set; }
        public string ModuleCode { get; set; }
        public int? ParentModuleId { get; set; }
        public int? DisplayOrder { get; set; }
        public string ModuleUrl { get; set; }
        public string ModuleIcon { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDisable { get; set; }
        public string IsDeleted { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<Navigations> Navigations { get; set; }
    }
}
