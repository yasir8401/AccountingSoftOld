using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ApprovalRoutesDetail
    {
        public int RouteDetailId { get; set; }
        public int ApprovalRouteId { get; set; }
        public int? SeqId { get; set; }
        public string ApprovalTaskId { get; set; }
        public int? ApproverUserId { get; set; }
        public bool? IsDepartment { get; set; }
        public int? DepartmentId { get; set; }
        public int? RequestedBy { get; set; }
        public string RecordId { get; set; }
        public string RecordName { get; set; }
        public string ApprovalStatus { get; set; }
        public string RecordNotes { get; set; }
        public string ApproverNotes { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ApprovalRoutes ApprovalRoute { get; set; }
    }
}
