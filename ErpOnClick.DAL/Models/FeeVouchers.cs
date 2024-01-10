using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class FeeVouchers
    {
        public FeeVouchers()
        {
            FeeVouchersLines = new HashSet<FeeVouchersLines>();
        }

        public int FeeVoucherId { get; set; }
        public DateTime? FeeVoucherDate { get; set; }
        public string FeeVoucherNo { get; set; }
        public int? StudentId { get; set; }
        public string RefNo { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public int? TaxRateId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? DiscountPer { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Total { get; set; }
        public string StdFeeType { get; set; }
        public string PaymentMode { get; set; }
        public int? BankId { get; set; }
        public string ChequeNo { get; set; }
        public string BankAccountNo { get; set; }
        public string Note { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedBy { get; set; }
        public string GlBatchId { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Banks Bank { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Students Student { get; set; }
        public virtual ICollection<FeeVouchersLines> FeeVouchersLines { get; set; }
    }
}
