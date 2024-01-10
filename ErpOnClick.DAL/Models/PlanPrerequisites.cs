using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PlanPrerequisites
    {
        public int PlanPrerequisiteId { get; set; }
        public int PlanCourseId { get; set; }
        public int? MajorId { get; set; }
        public int CourseId { get; set; }
        public int? PlanLevel { get; set; }
        public int? Seq { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string DepartmentId { get; set; }

        public virtual PlanCourses PlanCourse { get; set; }
    }
}
