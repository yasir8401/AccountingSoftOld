using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StdEnroll
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AcademicYearId { get; set; }
        public int CourseId { get; set; }
        public decimal? CourseFee { get; set; }
        public int? DiscountId { get; set; }
        public int? ClassId { get; set; }
        public string CourseEnrollStatusId { get; set; }
        public decimal? TotalPercentageEarned { get; set; }
        public decimal? TotalObtainedMarks { get; set; }
        public string GradeLetter { get; set; }
        public int? TotalCreditsEarned { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Classes Class { get; set; }
        public virtual Course Course { get; set; }
        public virtual Lookups CourseEnrollStatus { get; set; }
        public virtual Students Student { get; set; }
    }
}
