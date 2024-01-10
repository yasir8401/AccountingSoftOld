using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AppConfig
    {
        public int ConfigId { get; set; }
        public string ConfigName { get; set; }
        public string Description { get; set; }
        public string ConfigVal { get; set; }
        public string ConfigType { get; set; }
        public bool? IsActive { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
    }
}
