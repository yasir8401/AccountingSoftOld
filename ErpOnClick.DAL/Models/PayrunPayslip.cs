using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PayrunPayslip
    {
        public int PayslipId { get; set; }
        public int EmpPayrunId { get; set; }
        public string AllowanceTypeId { get; set; }
        public string Description { get; set; }
        public decimal? Earning { get; set; }
        public decimal? Deduction { get; set; }
        public string Remarks { get; set; }
        public bool? IsPosted { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Lookups AllowanceType { get; set; }
    }
}
