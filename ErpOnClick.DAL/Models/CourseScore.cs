using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class CourseScore
    {
        public CourseScore()
        {
            Course = new HashSet<Course>();
        }

        public int CourseScoreId { get; set; }
        public string CalculateIn { get; set; }
        public decimal? OutOf { get; set; }
        public decimal? MinPassScore { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
