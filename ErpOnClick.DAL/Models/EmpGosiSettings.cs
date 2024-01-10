using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpGosiSettings
    {
        public int GosiSettingsId { get; set; }
        public int? EmpId { get; set; }
        public string JoiningDate { get; set; }
        public string GosiSettingCode { get; set; }
        public string GosiSettingNameEn { get; set; }
        public string GosiSettingNameAr { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
