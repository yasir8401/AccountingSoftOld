using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Major
    {
        public Major()
        {
            AdmissionForms = new HashSet<AdmissionForms>();
            Course = new HashSet<Course>();
            Evaluation = new HashSet<Evaluation>();
            PlanCourses = new HashSet<PlanCourses>();
        }

        public int MajorId { get; set; }
        public string MajorNameEn { get; set; }
        public string MajorNameAr { get; set; }
        public string MajorCode { get; set; }
        public int? MajorTypeId { get; set; }
        public int? PlanLevels { get; set; }
        public int? MaxCoreCourses { get; set; }
        public int? MaxGeneralCourses { get; set; }
        public int CampusId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MajorType MajorType { get; set; }
        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<PlanCourses> PlanCourses { get; set; }
    }
}
