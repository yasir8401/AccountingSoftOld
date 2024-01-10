using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentEducations
    {
        public int StudentEducationId { get; set; }
        public int StudentId { get; set; }
        public int StudentUserId { get; set; }
        public string CurrentQualificationId { get; set; }
        public string DegreeName { get; set; }
        public string Major { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public int? StartMonth { get; set; }
        public int? StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public string Grade { get; set; }
        public string Attachment { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string HighSchoolMajor { get; set; }
        public string NameOfHighSchool { get; set; }
        public int? PassedYear { get; set; }
        public string GradeInHighSchool { get; set; }
        public string QudaratGrade { get; set; }
        public string TahsiliGrade { get; set; }
        public string UniversityNameTransfer { get; set; }
        public string MajorTransfer { get; set; }
        public string GradeTransfer { get; set; }
        public string DiplomaUniversityName { get; set; }
        public string DiplomaMajor { get; set; }
        public string DiplomaGrade { get; set; }
        public DateTime? DateOfGraduate { get; set; }

        public virtual Students Student { get; set; }
        public virtual StudentUsers StudentUser { get; set; }
    }
}
