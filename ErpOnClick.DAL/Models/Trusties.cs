using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Trusties
    {
        public int TrustId { get; set; }
        public string TrustName { get; set; }
        public string Description { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModfiedBy { get; set; }
    }
}
