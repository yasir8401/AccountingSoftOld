using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Grades1
    {
        public Grades1()
        {
            EmpContracts = new HashSet<EmpContracts>();
            GradesDetail = new HashSet<GradesDetail>();
        }

        public int GradeId { get; set; }
        public string GradeNameEn { get; set; }
        public string GradeNameAr { get; set; }
        public string GradeCode { get; set; }
        public string ContractStatus { get; set; }
        public int? FamilyDependencies { get; set; }
        public int? ContractDurationMonths { get; set; }
        public int? YearlyVacationDays { get; set; }
        public bool? OtEligibility { get; set; }
        public bool? LoanEligibility { get; set; }
        public bool? VehicleEligibility { get; set; }
        public bool? ComissionEligibility { get; set; }
        public bool? BusinessTripExternal { get; set; }
        public bool? BusinessTripInternal { get; set; }
        public decimal? IncrementPercentage { get; set; }
        public int? MedicalInsuranceCategory { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<EmpContracts> EmpContracts { get; set; }
        public virtual ICollection<GradesDetail> GradesDetail { get; set; }
    }
}
