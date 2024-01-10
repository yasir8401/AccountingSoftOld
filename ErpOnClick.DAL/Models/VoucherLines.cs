using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class VoucherLines
    {
        public int LineId { get; set; }
        public int? VoucherId { get; set; }
        public int? AccountId { get; set; }
        public int? EmployeeId { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Refno1 { get; set; }
        public string Refno2 { get; set; }
        public string Refno3 { get; set; }
        public DateTime? Date { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
