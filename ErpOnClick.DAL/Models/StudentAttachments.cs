using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentAttachments
    {
        public int StudentAttachmentId { get; set; }
        public int StudentId { get; set; }
        public int StudentUserId { get; set; }
        public string AdmissionDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDetail { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Attachment { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Students Student { get; set; }
        public virtual StudentUsers StudentUser { get; set; }
    }
}
