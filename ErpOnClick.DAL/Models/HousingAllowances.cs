using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class HousingAllowances
    {
        public HousingAllowances()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int HousingAllowanceId { get; set; }
        public string HousingAllowanceNameEn { get; set; }
        public string HousingAllowanceNameAr { get; set; }
        public string HousingAllowanceCode { get; set; }
        public string HousingPaymentTypeId { get; set; }
        public decimal? AllowanceRate { get; set; }
        public bool? IsFixedAmount { get; set; }
        public decimal? FixedAmount { get; set; }
        public bool? DistributeWithSalary { get; set; }
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
