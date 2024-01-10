using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PayGroups
    {
        public PayGroups()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int PayGroupId { get; set; }
        public string PayGroupNameEn { get; set; }
        public string PayGroupNameAr { get; set; }
        public string PayGroupCode { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
    }
}
