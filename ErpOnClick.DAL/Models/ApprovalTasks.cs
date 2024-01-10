using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class ApprovalTasks
    {
        public int ApprovalTaskId { get; set; }
        public string ApprovalTaskNameEn { get; set; }
        public string ApprovalTaskNameAr { get; set; }
        public string ApprovalTaskDescriptionEn { get; set; }
        public string ApprovalTaskDescriptionAr { get; set; }
        public string ApprovalTaskCode { get; set; }
        public string NavigationIds { get; set; }
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
    }
}
