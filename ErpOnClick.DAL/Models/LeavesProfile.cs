using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class LeavesProfile
    {
        public int LeavesProfileId { get; set; }
        public int TotalSickLeaves { get; set; }
        public int TotalEmergencyLeaves { get; set; }
        public int TotalMaternityLeaves { get; set; }
        public int TotalBusinessLeaves { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? TotalMarriageLeaves { get; set; }
        public int? TotalExaminationLeaves { get; set; }
        public int? TotalEducationalLeaves { get; set; }
        public int? TotalPaternityLeaves { get; set; }
        public int? TotalSpecialLeaves { get; set; }
    }
}
