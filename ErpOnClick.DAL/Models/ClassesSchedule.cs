using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ClassesSchedule
    {
        public int ClassScheduleId { get; set; }
        public int ClassId { get; set; }
        public bool? Sat { get; set; }
        public bool? Sun { get; set; }
        public bool? Mon { get; set; }
        public bool? Tue { get; set; }
        public bool? Wed { get; set; }
        public bool? Thu { get; set; }
        public bool? Fri { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? RoomId { get; set; }
        public int? FacultyEmpId { get; set; }
        public string ActiveStatus { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Classes Class { get; set; }
        public virtual Rooms Room { get; set; }
    }
}
