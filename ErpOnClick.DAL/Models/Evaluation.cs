using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Evaluation
    {
        public int EvaluationId { get; set; }
        public int? ClassId { get; set; }
        public int AcademicYearId { get; set; }
        public int MajorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CourseId { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Course Course { get; set; }
        public virtual Major Major { get; set; }
    }
}
