using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Applications
    {
        public int ApplicationId { get; set; }
        public int? ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DegreeId { get; set; }
        public int? VacantJobId { get; set; }
        public string JobDepartmentId { get; set; }
        public decimal? ExpectedSalary { get; set; }
        public decimal? ExpectedExtra { get; set; }
        public decimal? ProposedSalary { get; set; }
        public decimal? ProposedExtra { get; set; }
        public DateTime? Availability { get; set; }
        public string ApplicationSummary { get; set; }
        public string ApplicationSourceType { get; set; }
        public string CvAttachment { get; set; }
        public string CoverNote { get; set; }
        public string ApplicationStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
