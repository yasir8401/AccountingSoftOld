using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PayrunM
    {
        public PayrunM()
        {
            PayrunD = new HashSet<PayrunD>();
        }

        public int PayrunId { get; set; }
        public int YearId { get; set; }
        public int MonthId { get; set; }
        public decimal? TotalEarning { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? NetTotal { get; set; }
        public string Note { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedBy { get; set; }
        public string GlBatchId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<PayrunD> PayrunD { get; set; }
    }
}
