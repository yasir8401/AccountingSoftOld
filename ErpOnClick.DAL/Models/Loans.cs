using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Loans
    {
        public int LoanId { get; set; }
        public int? EmpId { get; set; }
        public string LoanTypeId { get; set; }
        public decimal? LoanAmount { get; set; }
        public int? NoOfInstallments { get; set; }
        public decimal? DeductAmount { get; set; }
        public DateTime? DateStart { get; set; }
        public string Reason { get; set; }
        public string AttachmentType { get; set; }
        public string Attachment { get; set; }
        public string LoanStatus { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Lookups AttachmentTypeNavigation { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Emp Emp { get; set; }
        public virtual Lookups LoanStatusNavigation { get; set; }
        public virtual Lookups LoanType { get; set; }
    }
}
