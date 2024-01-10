using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Teams
    {
        public Teams()
        {
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int TeamId { get; set; }
        public string TeamEn { get; set; }
        public string TeamAr { get; set; }
        public string TeamCode { get; set; }
        public int? TeamHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int DivisionId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int SubSectionId { get; set; }
        public int UnitId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp ReportingToU { get; set; }
        public virtual Emp TeamHeadU { get; set; }
        public virtual Units Unit { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
    }
}
