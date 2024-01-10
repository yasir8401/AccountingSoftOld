using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ApprovalRoutes
    {
        public ApprovalRoutes()
        {
            ApprovalRoutesDetail = new HashSet<ApprovalRoutesDetail>();
        }

        public int ApprovalRouteId { get; set; }
        public int ApprovalTaskId { get; set; }
        public int? SeqId { get; set; }
        public int? UserId { get; set; }
        public bool? IsDepartment { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Departments Department { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ApprovalRoutesDetail> ApprovalRoutesDetail { get; set; }
    }
}
