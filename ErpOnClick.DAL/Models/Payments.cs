using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentNo { get; set; }
        public int? VendorId { get; set; }
        public int? DestinationAccount { get; set; }
        public string RefNo { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public int? RecipientAccount { get; set; }
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

        public virtual Branch Branch { get; set; }
        public virtual Vendors Vendor { get; set; }
    }
}
