using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Divisions
    {
        public Divisions()
        {
            Departments = new HashSet<Departments>();
            EmpContracts = new HashSet<EmpContracts>();
        }

        public int DivisionId { get; set; }
        public string DivisionNameEn { get; set; }
        public string DivisionNameAr { get; set; }
        public string DivisionCode { get; set; }
        public int DivisionHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp DivisionHeadU { get; set; }
        public virtual Emp ReportingToU { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
    }
}
