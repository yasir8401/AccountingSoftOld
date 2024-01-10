using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Units
    {
        public Units()
        {
            EmpContracts = new HashSet<EmpContracts>();
            Teams = new HashSet<Teams>();
        }

        public int UnitId { get; set; }
        public string UnitNameEn { get; set; }
        public string UnitNameAr { get; set; }
        public string UnitCode { get; set; }
        public int? UnitHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int DivisionId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int SubSectionId { get; set; }
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
        public virtual SubSections SubSection { get; set; }
        public virtual Emp UnitHeadU { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
    }
}
