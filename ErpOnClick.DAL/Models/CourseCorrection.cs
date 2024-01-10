using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class CourseCorrection
    {
        public int RequestId { get; set; }
        public int? StudentId { get; set; }
        public int? ClassId { get; set; }
        public string RequestStatus { get; set; }
        public string RequestComments { get; set; }
        public int? TeacherIdBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Lookups RequestStatusNavigation { get; set; }
        public virtual Students Student { get; set; }
    }
}
