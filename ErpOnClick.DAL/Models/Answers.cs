using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Answers
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime Date { get; set; }
        public int QuizId { get; set; }
        public int StdId { get; set; }
        public string Survey { get; set; }
        public string CategoryName { get; set; }

        public virtual QuestionOptions Option { get; set; }
        public virtual Questions Question { get; set; }
        public virtual StudentUsers Std { get; set; }
    }
}
