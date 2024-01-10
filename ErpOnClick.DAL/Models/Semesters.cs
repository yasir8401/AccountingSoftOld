using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Semesters
    {
        public Semesters()
        {
            AcademicYears = new HashSet<AcademicYears>();
        }

        public int SemesterId { get; set; }
        public string SemesterNameEn { get; set; }
        public string SemesterNameAr { get; set; }
        public string SemesterCode { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<AcademicYears> AcademicYears { get; set; }
    }
}
