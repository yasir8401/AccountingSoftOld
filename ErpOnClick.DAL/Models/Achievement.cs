using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Achievement
    {
        public int AchievementId { get; set; }
        public string Year { get; set; }
        public string AwardName { get; set; }
        public string Donor { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? EmpId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? AchievementDate { get; set; }
        public string AchievementTitle { get; set; }
        public string Attachments { get; set; }
        public string Detail { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
