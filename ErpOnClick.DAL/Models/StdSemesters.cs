using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StdSemesters
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AcademicYearId { get; set; }
        public string StudentStatus { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Students Student { get; set; }
        public virtual Lookups StudentStatusNavigation { get; set; }
    }
}
