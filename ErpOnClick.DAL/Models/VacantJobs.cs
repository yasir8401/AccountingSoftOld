using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class VacantJobs
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string JobStatusId { get; set; }
        public string JobDepartmentId { get; set; }
        public string JobTypeId { get; set; }
        public string CountryId { get; set; }
        public string CityId { get; set; }
        public int? SalaryRangeStart { get; set; }
        public int? SalaryRangeEnd { get; set; }
        public bool? Publish { get; set; }
        public string EmailTo { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Lookups JobDepartment { get; set; }
        public virtual Lookups JobStatus { get; set; }
        public virtual Lookups JobType { get; set; }
    }
}
