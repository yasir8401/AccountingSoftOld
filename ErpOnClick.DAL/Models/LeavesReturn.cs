using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class LeavesReturn
    {
        public int RecId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? JoiningDateActual { get; set; }
        public int? PaidDays { get; set; }
        public int? Balance { get; set; }
        public string Reason { get; set; }
        public int? EarlyDays { get; set; }
        public int? LateDays { get; set; }
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
