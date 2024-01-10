using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class OvertimeSettings
    {
        public OvertimeSettings()
        {
            NationalHolidays = new HashSet<NationalHolidays>();
            SpecialOccasions = new HashSet<SpecialOccasions>();
        }

        public int OvertimeSettingId { get; set; }
        public string OvertimeSettingNameEn { get; set; }
        public string OvertimeSettingNameAr { get; set; }
        public string OvertimeSettingCode { get; set; }
        public decimal? CalculationPercentage { get; set; }
        public string AllowanceTypeIds { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<NationalHolidays> NationalHolidays { get; set; }
        public virtual ICollection<SpecialOccasions> SpecialOccasions { get; set; }
    }
}
