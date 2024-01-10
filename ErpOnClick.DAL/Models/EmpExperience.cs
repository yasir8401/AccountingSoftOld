using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpExperience
    {
        public int EmpExperienceId { get; set; }
        public int EmpId { get; set; }
        public string JobTitle { get; set; }
        public string EducationalInstitue { get; set; }
        public string WorkLocation { get; set; }
        public string College { get; set; }
        public string AcademicSection { get; set; }
        public string JobRank { get; set; }
        public DateTime? DateOfRank { get; set; }
        public DateTime? DateOfBeginningWork { get; set; }
        public DateTime? DateOfEndWork { get; set; }
        public string GeneralSpecialization { get; set; }
        public string Subspecialty { get; set; }
        public string TypeOfContract { get; set; }
        public string AcademicRank { get; set; }
        public string FunctionalStatus { get; set; }
        public string FunctionalType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
