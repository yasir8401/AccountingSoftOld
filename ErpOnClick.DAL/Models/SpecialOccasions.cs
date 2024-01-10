using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class SpecialOccasions
    {
        public int SpecialOccasionId { get; set; }
        public string SpecialOccasionNameEn { get; set; }
        public string SpecialOccasionNameAr { get; set; }
        public string SpecialOccasionCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalDays { get; set; }
        public int? OvertimeSettingId { get; set; }
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
