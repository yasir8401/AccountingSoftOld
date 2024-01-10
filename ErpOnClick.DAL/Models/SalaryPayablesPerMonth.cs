using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class SalaryPayablesPerMonth
    {
        public int PayableId { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? OtherDeduction { get; set; }
        public decimal? AbsentFine { get; set; }
        public int? UnpaidDays { get; set; }
        public decimal? SalaryPerDayCalculation { get; set; }
        public decimal? PerDay { get; set; }
        public decimal? UnpaidDaysDeduction { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? Additions { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? ThreshHoldSalary { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryMonth { get; set; }
        public int? SalaryYear { get; set; }
        public DateTime? SalaryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? ModifiedDate { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public decimal? LoadDeductionThisMonth { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
