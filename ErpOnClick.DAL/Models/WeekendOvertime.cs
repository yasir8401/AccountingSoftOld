using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class WeekendOvertime
    {
        public int RecId { get; set; }
        public int? EmpId { get; set; }
        public string Assignment { get; set; }
        public string JobTitle { get; set; }
        public int? TotalDays { get; set; }
        public int? TotalHours { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ApprovalStatus { get; set; }
        public string ApprovalDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? AssignedBy { get; set; }

        public virtual Lookups ApprovalStatusNavigation { get; set; }
        public virtual Emp AssignedByNavigation { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
