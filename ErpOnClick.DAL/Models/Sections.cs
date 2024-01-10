using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Sections
    {
        public Sections()
        {
            EmpContracts = new HashSet<EmpContracts>();
            SubSections = new HashSet<SubSections>();
        }

        public int SectionId { get; set; }
        public string SectionNameEn { get; set; }
        public string SectionNameAr { get; set; }
        public string SectionCode { get; set; }
        public int? SectionHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int DivisionId { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Departments Department { get; set; }
        public virtual Emp ReportingToU { get; set; }
        public virtual Emp SectionHeadU { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<SubSections> SubSections { get; set; }
    }
}
