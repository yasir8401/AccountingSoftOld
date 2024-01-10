using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Departments
    {
        public Departments()
        {
            ApprovalRoutes = new HashSet<ApprovalRoutes>();
            EmpContracts = new HashSet<EmpContracts>();
            Sections = new HashSet<Sections>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentNameEn { get; set; }
        public string DepartmentNameAr { get; set; }
        public string DepartmentCode { get; set; }
        public int? DepartmentHeadUid { get; set; }
        public int? ReportingToUid { get; set; }
        public int DivisionId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp DepartmentHeadU { get; set; }
        public virtual Divisions Division { get; set; }
        public virtual Emp ReportingToU { get; set; }
        public virtual ICollection<ApprovalRoutes> ApprovalRoutes { get; set; }
        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<Sections> Sections { get; set; }
    }
}
