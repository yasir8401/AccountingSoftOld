using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Grades
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AcademicYearId { get; set; }
        public int CourseId { get; set; }
        public string F1Title { get; set; }
        public decimal? F1Per { get; set; }
        public decimal? F1GMarks { get; set; }
        public string F2Title { get; set; }
        public decimal? F2Per { get; set; }
        public decimal? F2GMarks { get; set; }
        public string F3Title { get; set; }
        public decimal? F3Per { get; set; }
        public decimal? F3GMarks { get; set; }
        public string F4Title { get; set; }
        public decimal? F4Per { get; set; }
        public decimal? F4GMarks { get; set; }
        public string F5Title { get; set; }
        public decimal? F5Per { get; set; }
        public decimal? F5GMarks { get; set; }
        public string F6Title { get; set; }
        public decimal? F6Per { get; set; }
        public decimal? F6GMarks { get; set; }
        public string F7Title { get; set; }
        public decimal? F7Per { get; set; }
        public decimal? F7GMarks { get; set; }
        public string F8Title { get; set; }
        public decimal? F8Per { get; set; }
        public decimal? F8GMarks { get; set; }
        public string F9Title { get; set; }
        public decimal? F9Per { get; set; }
        public decimal? F9GMarks { get; set; }
        public string F10Title { get; set; }
        public decimal? F10Per { get; set; }
        public decimal? F10GMarks { get; set; }
        public decimal? TotalPer { get; set; }
        public decimal? TotalGMarks { get; set; }
        public string Grade { get; set; }
        public double? GradePoints { get; set; }
        public string PendingGradeTypeId { get; set; }
        public string Remarks { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
