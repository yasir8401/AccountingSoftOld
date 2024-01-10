using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpContracts
    {
        public EmpContracts()
        {
            EmpContractsPackage = new HashSet<EmpContractsPackage>();
        }

        public int EmpContractId { get; set; }
        public int? EmpId { get; set; }
        public int? ContractPeriodMonths { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? JoiningDateHijri { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ExpiryDateHijri { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public string ContractStatus { get; set; }
        public DateTime? ContactInactiveDate { get; set; }
        public int? DivisionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? SubSectionId { get; set; }
        public int? UnitId { get; set; }
        public int? TeamId { get; set; }
        public int? GradeId { get; set; }
        public int? GosiId { get; set; }
        public int? VacationProfileId { get; set; }
        public int? AbsentProfileId { get; set; }
        public int? TicketProfileId { get; set; }
        public int? HousingAllowanceId { get; set; }
        public int? PayGroupId { get; set; }
        public string Notes { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? TotalPaidLeavesPerMonth { get; set; }
        public int? TotalHalfLeavesPerMonth { get; set; }
        public int? ThreshHoldSalary { get; set; }
        public decimal? TotalExamptSalaryFromPreviousEmployer { get; set; }
        public decimal? TaxAlreadyDeduct { get; set; }
        public int? TotalAnnualLeavesPerYear { get; set; }

        public virtual AbsentProfiles AbsentProfile { get; set; }
        public virtual Departments Department { get; set; }
        public virtual Divisions Division { get; set; }
        public virtual Emp Emp { get; set; }
        public virtual GosiSettings Gosi { get; set; }
        public virtual Grades1 Grade { get; set; }
        public virtual HousingAllowances HousingAllowance { get; set; }
        public virtual PayGroups PayGroup { get; set; }
        public virtual Sections Section { get; set; }
        public virtual SubSections SubSection { get; set; }
        public virtual Teams Team { get; set; }
        public virtual AirTicketProfiles TicketProfile { get; set; }
        public virtual Units Unit { get; set; }
        public virtual ICollection<EmpContractsPackage> EmpContractsPackage { get; set; }
    }
}
