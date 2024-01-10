using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            VoucherLines = new HashSet<VoucherLines>();
        }

        public int VoucherId { get; set; }
        public DateTime? VoucherEntryDate { get; set; }
        public string VoucherCode { get; set; }
        public string Currency { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public string Description { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? PostedBy { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string VoucherType { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Vendors Vendor { get; set; }
        public virtual Lookups VoucherTypeNavigation { get; set; }
        public virtual ICollection<VoucherLines> VoucherLines { get; set; }
    }
}
