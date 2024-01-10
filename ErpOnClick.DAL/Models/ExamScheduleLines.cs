using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ExamScheduleLines
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? Date { get; set; }
        public string Day { get; set; }
        public int ExamScheduleId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ExamSchedule ExamSchedule { get; set; }
    }
}
