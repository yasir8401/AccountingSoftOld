using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Areas.ESS.Models
{
    public partial class EmpAttendanceVM
    {
        public int EmpAttendanceId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public DateTime? PlannedTimeIn { get; set; }
        public DateTime? PlannedTimeOut { get; set; }
        public DateTime? ActualTimeIn { get; set; }
        public DateTime? ActualTimeOut { get; set; }
        public string Note { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsPresent { get; set; }
        public bool? IsPaidLeave { get; set; }
        public bool? IsUnpaidLeave { get; set; }
        public bool? IsShortLeave { get; set; }
        public bool? IsSaved { get; set; }
    }
}
