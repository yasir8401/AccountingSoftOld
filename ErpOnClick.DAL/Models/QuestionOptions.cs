using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class QuestionOptions
    {
        public QuestionOptions()
        {
            Answers = new HashSet<Answers>();
        }

        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public int OptionSeq { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Questions Question { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
