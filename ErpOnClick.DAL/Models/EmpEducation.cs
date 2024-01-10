using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpEducation
    {
        public int EmpEducationId { get; set; }
        public int? EmpId { get; set; }
        public string DegreeId { get; set; }
        public string DegreeName { get; set; }
        public string UniversityName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Detail { get; set; }
        public string Attachments { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string AssessmentAssignmentId { get; set; }
        public string GpaTypeCodeId { get; set; }
        public string StudyTypeCodeId { get; set; }
        public string College { get; set; }
        public string ScientificDegreeDate { get; set; }
        public string GraduateYear { get; set; }
        public string CityId { get; set; }
        public string CountryId { get; set; }
        public bool? CulturalAttache { get; set; }

        public virtual Lookups Degree { get; set; }
    }
}
