using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ExamSchedule
    {
        public ExamSchedule()
        {
            ExamScheduleLines = new HashSet<ExamScheduleLines>();
        }

        public int Id { get; set; }
        public int? CampusId { get; set; }
        public int? AcademicYearId { get; set; }
        public int? MajorTypeId { get; set; }
        public int? MajorId { get; set; }
        public int? LevelId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ExamType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ExamScheduleLines> ExamScheduleLines { get; set; }
    }
}
