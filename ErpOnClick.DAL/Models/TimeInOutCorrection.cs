using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class TimeInOutCorrection
    {
        public int RecId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public TimeSpan? TimeFrom { get; set; }
        public TimeSpan? TimeTo { get; set; }
        public string Reason { get; set; }
        public string RequestStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Attachment { get; set; }
        public string RequestDate { get; set; }
        public TimeSpan? OldTimeFrom { get; set; }
        public TimeSpan? OldTimeTo { get; set; }

        public virtual Emp Emp { get; set; }
        public virtual Lookups RequestStatusNavigation { get; set; }
    }
}
