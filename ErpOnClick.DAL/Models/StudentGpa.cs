using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentGpa
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public double? Sgpa { get; set; }
        public double? Cgpa { get; set; }
        public int? MajorId { get; set; }
        public bool? ShowGpa { get; set; }
        public int? Semester { get; set; }
        public int? AcademicCalenderId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
