using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpMedicals
    {
        public int EmpMedicalId { get; set; }
        public int? EmpId { get; set; }
        public string MedicalCardNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string MedicalCompanyId { get; set; }
        public string MedicalClassId { get; set; }
        public string BloodGroupId { get; set; }
        public string Note { get; set; }
        public bool? SpecialNeeds { get; set; }
        public string SpecialNeed { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
