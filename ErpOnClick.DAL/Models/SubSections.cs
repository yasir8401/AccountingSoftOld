using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class SubSections
    {
        public SubSections()
        {
            EmpContracts = new HashSet<EmpContracts>();
            Units = new HashSet<Units>();
        }

        public int SubSectionId { get; set; }
        public string SubSectionNameEn { get; set; }
        public string SubSectionNameAr { get; set; }
        public string SubSectionCode { get; set; }
        public int? SubSectionHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int DivisionId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
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
        public virtual Sections Section { get; set; }
        public virtual Emp SubSectionHeadU { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<Units> Units { get; set; }
    }
}
