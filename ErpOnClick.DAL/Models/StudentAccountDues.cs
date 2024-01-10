using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentAccountDues
    {
        public int Id { get; set; }
        public int StdId { get; set; }
        public int? AcademicYear { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Attachment { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? CreditHoursPerTermThisAcademicYear { get; set; }
        public double? AmountPaid { get; set; }
        public double? RemainingAmount { get; set; }
        public string PaidType { get; set; }
        public bool PaidStatus { get; set; }

        public virtual Students Std { get; set; }
    }
}
