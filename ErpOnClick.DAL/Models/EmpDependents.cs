using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpDependents
    {
        public int DependentId { get; set; }
        public int? EmpId { get; set; }
        public string DependentNameEn { get; set; }
        public string DependentNameAr { get; set; }
        public string Dob { get; set; }
        public string GenderId { get; set; }
        public string RelationTypeId { get; set; }
        public string NationalityId { get; set; }
        public string IdNo { get; set; }
        public string IdIssuedFrom { get; set; }
        public string IdIssuedDate { get; set; }
        public string IdIssuedDateH { get; set; }
        public string IdEndDate { get; set; }
        public string IdEndDateH { get; set; }
        public string IdAttachment { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuedFrom { get; set; }
        public string PassportIssuedDate { get; set; }
        public string PassportIssuedDateH { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportExpiryDateH { get; set; }
        public string PassportAttachment { get; set; }
        public string Attachments { get; set; }
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
