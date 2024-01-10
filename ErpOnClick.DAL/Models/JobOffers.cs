using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class JobOffers
    {
        public int JobOfferId { get; set; }
        public string FirstNameEn { get; set; }
        public string FatherNameEn { get; set; }
        public string GrandNameEn { get; set; }
        public string FamilyNameEn { get; set; }
        public string FirstNameAr { get; set; }
        public string FatherNameAr { get; set; }
        public string GrandNameAr { get; set; }
        public string FamilyNameAr { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string GenderId { get; set; }
        public string MaritalStatusId { get; set; }
        public string NationalityId { get; set; }
        public string JobTitle { get; set; }
        public DateTime? ExpectingJoiningDate { get; set; }
        public string Department { get; set; }
        public string EmployementType { get; set; }
        public int? ProbationPeriod { get; set; }
        public string ReportingManager { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? HousingAllowance { get; set; }
        public decimal? TransportationAllowance { get; set; }
        public decimal? TicketAllowance { get; set; }
        public decimal? GosiDeduction { get; set; }
        public decimal? SanedDeduction { get; set; }
        public decimal? TotalSalary { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Bonus { get; set; }
    }
}
