using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class RuleAndRegulations
    {
        public int RuleId { get; set; }
        public string RuleTitle { get; set; }
        public string RuleTitleAr { get; set; }
        public int RuleFineAmount { get; set; }
        public string Description { get; set; }
        public int? CompanyId { get; set; }
        public int? BramchId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CampusId { get; set; }

        public virtual Campus Campus { get; set; }
    }
}
