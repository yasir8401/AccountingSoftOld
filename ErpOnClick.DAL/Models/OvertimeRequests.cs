using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class OvertimeRequests
    {
        public OvertimeRequests()
        {
            OvertimeRequestsLines = new HashSet<OvertimeRequestsLines>();
        }

        public int OvertimeRequestId { get; set; }
        public string OvertimeRequestNo { get; set; }
        public DateTime? OvertimeDate { get; set; }
        public string Note { get; set; }
        public bool? ApprovalStatus { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string RequestStatus { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Lookups RequestStatusNavigation { get; set; }
        public virtual ICollection<OvertimeRequestsLines> OvertimeRequestsLines { get; set; }
    }
}
