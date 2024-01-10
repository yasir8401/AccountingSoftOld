using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentUsers
    {
        public StudentUsers()
        {
            AdmissionForms = new HashSet<AdmissionForms>();
            AdmissionFormsAttachments = new HashSet<AdmissionFormsAttachments>();
            AdmissionFormsEducations = new HashSet<AdmissionFormsEducations>();
            Answers = new HashSet<Answers>();
            StudentAttachments = new HashSet<StudentAttachments>();
            StudentEducations = new HashSet<StudentEducations>();
        }

        public int StudentUserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string StudentCode { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? _2facode { get; set; }

        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<AdmissionFormsAttachments> AdmissionFormsAttachments { get; set; }
        public virtual ICollection<AdmissionFormsEducations> AdmissionFormsEducations { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<StudentAttachments> StudentAttachments { get; set; }
        public virtual ICollection<StudentEducations> StudentEducations { get; set; }
    }
}
