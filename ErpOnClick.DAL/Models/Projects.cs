using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Tasks = new HashSet<Tasks>();
            TeamMembers = new HashSet<TeamMembers>();
        }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDetail { get; set; }
        public string ProjectTypeId { get; set; }
        public int? ProjectManagerEmpId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public int? ProjectProgressPercent { get; set; }
        public string ProjectStatusId { get; set; }
        public int? ParentProjectId { get; set; }
        public int? RelatedProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp ProjectManagerEmp { get; set; }
        public virtual Lookups ProjectStatus { get; set; }
        public virtual Lookups ProjectType { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<TeamMembers> TeamMembers { get; set; }
    }
}
