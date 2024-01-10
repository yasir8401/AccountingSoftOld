using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class MajorType
    {
        public MajorType()
        {
            AdmissionForms = new HashSet<AdmissionForms>();
            Major = new HashSet<Major>();
        }

        public int MajorTypeId { get; set; }
        public string MajorTypeNameEn { get; set; }
        public string MajorTypeNameAr { get; set; }
        public string MajorTypeCode { get; set; }
        public int CampusId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Campus Campus { get; set; }
        public virtual ICollection<AdmissionForms> AdmissionForms { get; set; }
        public virtual ICollection<Major> Major { get; set; }
    }
}
