using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Tasks
    {
        public Tasks()
        {
            TeamMembers = new HashSet<TeamMembers>();
        }

        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDetail { get; set; }
        public string TaskTypeId { get; set; }
        public int? ProjectId { get; set; }
        public int? AssignedToEmpId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public int? TaskProgressPercent { get; set; }
        public string TaskStatusId { get; set; }
        public int? ParentTaskId { get; set; }
        public int? RelatedTaskId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp AssignedToEmp { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Projects Project { get; set; }
        public virtual Lookups TaskStatus { get; set; }
        public virtual Lookups TaskType { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
    }
}
