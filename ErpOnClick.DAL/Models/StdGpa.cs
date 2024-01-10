using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StdGpa
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public double? Sgpa { get; set; }
        public double? Cgpa { get; set; }
        public int? MajorId { get; set; }
        public bool? ShowGpa { get; set; }
        public int? Semester { get; set; }
        public int? AcademicCalenderId { get; set; }
        public int? CampusId { get; set; }
        public string SStatus { get; set; }
        public string TStatus { get; set; }
        public double? TermGradePoint { get; set; }
        public int? SeqNo { get; set; }
        public double? TermDeficiency { get; set; }
        public double? TermEarned { get; set; }
        public double? CDeficiency { get; set; }
        public double? CEarned { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
