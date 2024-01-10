using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
            QuestionOptions = new HashSet<QuestionOptions>();
        }

        public int QuestionId { get; set; }
        public string QuestionEn { get; set; }
        public string QuestionAr { get; set; }
        public string CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string CategoryName { get; set; }
        public string QuestionType { get; set; }

        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<QuestionOptions> QuestionOptions { get; set; }
    }
}
