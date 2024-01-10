using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AcademicYears
    {
        public AcademicYears()
        {
            AdmissionForms = new HashSet<AdmissionForms>();
            Calendar = new HashSet<Calendar>();
            Classes = new HashSet<Classes>();
            Evaluation = new HashSet<Evaluation>();
            ExceptionsClassCapacity = new HashSet<ExceptionsClassCapacity>();
            ExceptionsCourses = new HashSet<ExceptionsCourses>();
            StdEnroll = new HashSet<StdEnroll>();
            StdLetters = new HashSet<StdLetters>();
            StdSemesters = new HashSet<StdSemesters>();
        }

        public int AcademicYearId { get; set; }
        public int Year { get; set; }
        public int SemesterId { get; set; }
        public int CampusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ActiveStatus { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Campus Campus { get; set; }
        public virtual Semesters Semester { get; set; }
        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<Calendar> Calendar { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<ExceptionsClassCapacity> ExceptionsClassCapacity { get; set; }
        public virtual ICollection<ExceptionsCourses> ExceptionsCourses { get; set; }
        public virtual ICollection<StdEnroll> StdEnroll { get; set; }
        public virtual ICollection<StdLetters> StdLetters { get; set; }
        public virtual ICollection<StdSemesters> StdSemesters { get; set; }
    }
}
