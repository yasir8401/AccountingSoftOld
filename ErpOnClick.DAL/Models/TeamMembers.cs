using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class TeamMembers
    {
        public int TeamMemberId { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ProgressPercent { get; set; }
        public string Comments { get; set; }
        public string StatusId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp Emp { get; set; }
        public virtual Projects Project { get; set; }
        public virtual Lookups Status { get; set; }
        public virtual Tasks Task { get; set; }
    }
}
