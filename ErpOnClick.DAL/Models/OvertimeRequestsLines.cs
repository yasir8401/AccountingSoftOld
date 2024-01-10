using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class OvertimeRequestsLines
    {
        public int LineId { get; set; }
        public int? OvertimeRequestId { get; set; }
        public int? EmpId { get; set; }
        public TimeSpan? TimeFrom { get; set; }
        public TimeSpan? TimeTo { get; set; }
        public int? OtHours { get; set; }
        public string Remarks { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public decimal? OtAmount { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Emp Emp { get; set; }
        public virtual OvertimeRequests OvertimeRequest { get; set; }
    }
}
