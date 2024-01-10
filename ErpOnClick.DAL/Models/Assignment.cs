using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            Submissions = new HashSet<Submissions>();
        }

        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string TitleAr { get; set; }
        public string Description { get; set; }
        public bool? AllowResubmitting { get; set; }
        public bool? AllowLatesubmission { get; set; }
        public DateTime DueDate { get; set; }
        public string MaterialType { get; set; }
        public int CourseId { get; set; }
        public string TutorialLink { get; set; }
        public string Attachment { get; set; }
        public int? AcademicYearId { get; set; }
        public int TeacherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public DateTime? AssignmentViewDate { get; set; }

        public virtual ICollection<Submissions> Submissions { get; set; }
    }
}
