using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Submissions
    {
        public int SubmissionId { get; set; }
        public int? AssingmentId { get; set; }
        public string Attachment { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int StudentId { get; set; }
        public int? QuizId { get; set; }
        public string SubmissionStatus { get; set; }
        public string AssignmentStatus { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? BranchId { get; set; }
        public int? CompanyId { get; set; }

        public virtual Assignment Assingment { get; set; }
    }
}
