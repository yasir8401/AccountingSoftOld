using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class PerformanceBaseSalary
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryMonth { get; set; }
        public int? SalaryYear { get; set; }
        public DateTime? Date { get; set; }
        public decimal? ReferenceBasedCommission { get; set; }
        public decimal? DemoCommission { get; set; }
        public decimal? SaleCommision { get; set; }
        public decimal? _500Commission { get; set; }
        public decimal? ZeroPaid { get; set; }
        public decimal? GiftAmount { get; set; }
        public decimal? RecurringAmount { get; set; }
        public decimal? MonthlyBonus { get; set; }
        public decimal? EarnedSalary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? OvertimeHours { get; set; }
        public decimal? OvertimeTotalMoney { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
