using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Receipts
    {
        public int ReceiptId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptNo { get; set; }
        public int? CustomerId { get; set; }
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
        public virtual Customers Customer { get; set; }
    }
}
