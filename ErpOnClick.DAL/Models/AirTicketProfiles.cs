using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AirTicketProfiles
    {
        public AirTicketProfiles()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int AirTicketProfileId { get; set; }
        public string AirTicketProfileNameEn { get; set; }
        public string AirTicketProfileNameAr { get; set; }
        public string AirTicketProfileCode { get; set; }
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
