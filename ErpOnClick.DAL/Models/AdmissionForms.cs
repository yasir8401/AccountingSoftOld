using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AdmissionForms
    {
        public AdmissionForms()
        {
            AddmissionFormsRemarks = new HashSet<AddmissionFormsRemarks>();
            AdmissionFormsAttachments = new HashSet<AdmissionFormsAttachments>();
            AdmissionFormsEducations = new HashSet<AdmissionFormsEducations>();
        }

        public int AdmissionFormId { get; set; }
        public int? CampusId { get; set; }
        public int? MajorTypeId { get; set; }
        public int? MajorId { get; set; }
        public int AcademicYearId { get; set; }
        public int StudentUserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FirstNameAr { get; set; }
        public string MiddleNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string CurrentQualificationId { get; set; }
        public int? AdvisorId { get; set; }
        public string NationalityId { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime? NationalIdentityIssuedDate { get; set; }
        public string NationalIdentityIssuedDateHijri { get; set; }
        public DateTime? NationalIdentityExpiryDate { get; set; }
        public string NationalIdentityExpiryDateHijri { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuedFrom { get; set; }
        public DateTime? PassportIssuedDate { get; set; }
        public string PassportIssuedDateHijri { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string PassportExpiryDateHijri { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateHijgri { get; set; }
        public string BirthPlaceId { get; set; }
        public string GenderId { get; set; }
        public string MaritalStatusId { get; set; }
        public int? NoOfChildrens { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string SponsorName { get; set; }
        public string SponsorRelationship { get; set; }
        public string SponsorMobileNo { get; set; }
        public string SponsorPhoneNo { get; set; }
        public string SponsorEmail { get; set; }
        public string SponsorNotes { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyRelationship { get; set; }
        public string EmergencyMobileNo { get; set; }
        public string EmergencyPhoneNo { get; set; }
        public string MotherName { get; set; }
        public string MotherMobileNo { get; set; }
        public string FamilyMembersNo { get; set; }
        public bool? FatherAlive { get; set; }
        public string WithWhomStudentsLive { get; set; }
        public bool? MotherAlive { get; set; }
        public string StdOrderAmongSiblings { get; set; }
        public string FatherQualification { get; set; }
        public string MotherQualification { get; set; }
        public bool? HasFatherIncome { get; set; }
        public string FamilyMonthlyIncomeRange { get; set; }
        public string HasParentSocialCase { get; set; }
        public string FatherIncomeSource { get; set; }
        public bool? DoesFatherWork { get; set; }
        public string FahterWorkingSector { get; set; }
        public bool? DoesMotherWork { get; set; }
        public string MotherWorkingSector { get; set; }
        public string HousingType { get; set; }
        public string Transportation { get; set; }
        public string ChronicDieses { get; set; }
        public string ChronicDiesesFamilyHistory { get; set; }
        public string WorkingPlace { get; set; }
        public string Sector { get; set; }
        public string JobTitle { get; set; }
        public string AnySpecialCaseForCommittee { get; set; }
        public string ProfilePic { get; set; }
        public string AdmissionFormStatus { get; set; }
        public DateTime? AdmittedDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string PlaceOfIssue { get; set; }
        public string IdType { get; set; }
        public DateTime? JobDate { get; set; }
        public string LastJob { get; set; }
        public string DepartmentId { get; set; }
        public string HowDoYouKnowAboutTheCollege { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string FamilyName { get; set; }
        public string FatherNameAr { get; set; }
        public string GrandFatherNameAr { get; set; }
        public string FamilyNameAr { get; set; }
        public int? BatchNo { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Lookups AdmissionFormStatusNavigation { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual Major Major { get; set; }
        public virtual MajorType MajorType { get; set; }
        public virtual StudentUsers StudentUser { get; set; }
        public virtual ICollection<AddmissionFormsRemarks> AddmissionFormsRemarks { get; set; }
        public virtual ICollection<AdmissionFormsAttachments> AdmissionFormsAttachments { get; set; }
        public virtual ICollection<AdmissionFormsEducations> AdmissionFormsEducations { get; set; }
    }
}
