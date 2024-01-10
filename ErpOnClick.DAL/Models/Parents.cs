using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Parents
    {
        public int ParentId { get; set; }
        public int? StudentId { get; set; }
        public string ParentNameEn { get; set; }
        public string ParentNameAr { get; set; }
        public string NationalityId { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime? NationalIdentityIssuedDate { get; set; }
        public DateTime? NationalIdentityIssuedDateHijri { get; set; }
        public DateTime? NationalIdentityExpiryDate { get; set; }
        public DateTime? NationalIdentityExpiryDateHijri { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuedFrom { get; set; }
        public DateTime? PassportIssuedDate { get; set; }
        public DateTime? PassportIssuedDateHijri { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public DateTime? PassportExpiryDateHijri { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlaceId { get; set; }
        public string GenderId { get; set; }
        public string RelationshipId { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string JobTitle { get; set; }
        public string EmployerName { get; set; }
        public string ProfileSummary { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Company Company { get; set; }
    }
}
