using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class OvertimeSettingsDetail
    {
        public int OvertimeSettingDetailId { get; set; }
        public int OvertimeSettingId { get; set; }
        public string AllowanceTypeId { get; set; }
        public bool? IsEnable { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual OvertimeSettings OvertimeSetting { get; set; }
    }
}
