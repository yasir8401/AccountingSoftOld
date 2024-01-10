using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AbsentProfiles
    {
        public AbsentProfiles()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int AbsentProfileId { get; set; }
        public string AbsentProfileNameEn { get; set; }
        public string AbsentProfileNameAr { get; set; }
        public string AbsentProfileCode { get; set; }
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
