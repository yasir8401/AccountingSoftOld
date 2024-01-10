using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Leaves
    {
        public int LeaveId { get; set; }
        public int? EmpId { get; set; }
        public string LeaveTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? ResumeDate { get; set; }
        public int? Substitute { get; set; }
        public bool? AirTicket { get; set; }
        public int? PaidDays { get; set; }
        public int? UnpaidDays { get; set; }
        public string Reason { get; set; }
        public string AttachmentType { get; set; }
        public string Attachment { get; set; }
        public int? BalDaysBefore { get; set; }
        public int? BalDaysAfter { get; set; }
        public string LeaveStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Lookups AttachmentTypeNavigation { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp Emp { get; set; }
        public virtual Lookups LeaveStatusNavigation { get; set; }
        public virtual Lookups LeaveType { get; set; }
    }
}
