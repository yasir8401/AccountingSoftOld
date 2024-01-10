using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PayrunD
    {
        public int EmpPayrunId { get; set; }
        public int PayrunId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? Earning { get; set; }
        public decimal? Deduction { get; set; }
        public string BankAccount { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? DifferAmount { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? SalaryMonth { get; set; }
        public int? SalaryYear { get; set; }
        public DateTime? SalaryDate { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? HousingAllowance { get; set; }
        public decimal? TransportAllowance { get; set; }
        public decimal? FoodAllowance { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? LeavePayAllowance { get; set; }
        public decimal? IndemnityAllowance { get; set; }
        public decimal? MedicalAllowance { get; set; }
        public decimal? IncrementAllowance { get; set; }
        public decimal? EobiEmployerContribution { get; set; }
        public decimal? PessiEmployerContribution { get; set; }
        public decimal? GroupInsuranceEmployerContribution { get; set; }
        public decimal? TotalBasicSalary { get; set; }
        public decimal? ReferenceCommision { get; set; }
        public decimal? DemoCommission { get; set; }
        public decimal? SaleCommision { get; set; }
        public decimal? _500Commision { get; set; }
        public decimal? ZeroPaid { get; set; }
        public decimal? GiftAmount { get; set; }
        public decimal? RecurringCommision { get; set; }
        public decimal? MonthlyBonus { get; set; }
        public decimal? EarnedSalary { get; set; }
        public int? Tardies { get; set; }
        public int? Shortleaves { get; set; }
        public int? Absents { get; set; }
        public int? PaidLeaves { get; set; }
        public int? UnpaidLeaves { get; set; }
        public int? Presents { get; set; }
        public int? TotalDays { get; set; }
        public int? DeductedDays { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? OtherDeductions { get; set; }
        public decimal? AbscentFine { get; set; }
        public int? UnpaidDays { get; set; }
        public decimal? SalaryPerDayCalculation { get; set; }
        public decimal? PerDay { get; set; }
        public decimal? SalaryDedeuction { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? Additions { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? ThresholdSalary { get; set; }
        public decimal? NetSalaryPaBeforeTax { get; set; }
        public decimal? Vat15 { get; set; }
        public decimal? PreviouslyEarnedSalaryCommulative { get; set; }
        public decimal? TotalEstimatedSalaryFty { get; set; }
        public decimal? ExemptSalaryFromPrviousEmplopyer { get; set; }
        public decimal? TotalEstimatedExamptSalary { get; set; }
        public decimal? AnnualTaxLiability { get; set; }
        public decimal? TaxAlreadyDeduct { get; set; }
        public decimal? RemainingTaxLiability { get; set; }
        public decimal? NoOfMonthRemaining { get; set; }
        public decimal? TaxPaForTheMonth { get; set; }
        public decimal? NetPayableSalaryAfterTax { get; set; }
        public decimal? NetPayableSalaryAfterTaxAndStatuaryDeduction { get; set; }
        public decimal? PreviousPayableSalary { get; set; }
        public decimal? TotalPayableThisMonthAndPrevious { get; set; }
        public decimal? SalaryCheck { get; set; }
        public decimal? SalaryHeldThisMonth { get; set; }
        public decimal? FinalPaymentForThisMonth { get; set; }
        public decimal? AnnualTaxableSalary { get; set; }
        public decimal? OvertimeAmount { get; set; }
        public decimal? LoanDeduction { get; set; }

        public virtual Emp Emp { get; set; }
        public virtual PayrunM Payrun { get; set; }
    }
}
