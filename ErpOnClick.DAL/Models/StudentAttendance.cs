using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentAttendance
    {
        public int StudentAttendanceId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string AttendanceType { get; set; }
        public string Note { get; set; }
        public int? AttendancePercent { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Ispresent { get; set; }
        public bool? Islate { get; set; }
        public bool? AbsentWithoutexcuse { get; set; }
        public bool? AbsentWithexcuse { get; set; }

        public virtual Lookups AttendanceTypeNavigation { get; set; }
        public virtual Classes Class { get; set; }
        public virtual Students Student { get; set; }
    }
}
