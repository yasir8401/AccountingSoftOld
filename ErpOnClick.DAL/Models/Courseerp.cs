using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Courseerp
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public int? CourseIssuer { get; set; }
        public DateTime? CourseDate { get; set; }
        public string CourseDuration { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
