using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Campus
    {
        public Campus()
        {
            AcademicYears = new HashSet<AcademicYears>();
            AdmissionForms = new HashSet<AdmissionForms>();
            MajorType = new HashSet<MajorType>();
            RuleAndRegulations = new HashSet<RuleAndRegulations>();
        }

        public int CampusId { get; set; }
        public string CampusNameEn { get; set; }
        public string CampusNameAr { get; set; }
        public string CampusCode { get; set; }
        public int? BuildingId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Buildings Building { get; set; }
        public virtual ICollection<AcademicYears> AcademicYears { get; set; }
        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<MajorType> MajorType { get; set; }
        public virtual ICollection<RuleAndRegulations> RuleAndRegulations { get; set; }
    }
}
