using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class GosiSettings
    {
        public GosiSettings()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int GosiSettingId { get; set; }
        public string GosiSettingNameEn { get; set; }
        public string GosiSettingNameAr { get; set; }
        public string GosiSettingCode { get; set; }
        public decimal? CompanySharePercent { get; set; }
        public decimal? CompanyShareMaxValue { get; set; }
        public decimal? EmpSharePercent { get; set; }
        public decimal? EmpShareMaxValue { get; set; }
        public string AllowanceTypeIds { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
    }
}
