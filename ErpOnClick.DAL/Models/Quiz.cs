using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Quiz
    {
        public int QuizId { get; set; }
        public int ClassId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? QuizNumber { get; set; }
        public string QuizTitle { get; set; }
        public string QuizType { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Lookups QuizTypeNavigation { get; set; }
    }
}
