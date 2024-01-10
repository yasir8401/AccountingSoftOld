using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Shifts
    {
        public Shifts()
        {
            EmpShifts = new HashSet<EmpShifts>();
        }

        public int ShiftId { get; set; }
        public string ShiftNameEn { get; set; }
        public string ShiftNameAr { get; set; }
        public string Location { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public TimeSpan? LateDeductionStartFrom { get; set; }
        public TimeSpan? MarkAbsentAfter { get; set; }
        public decimal? DeductionPerMinute { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<EmpShifts> EmpShifts { get; set; }
    }
}
