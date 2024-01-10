using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StdLetters
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AcademicYearId { get; set; }
        public string StdLetterTypeId { get; set; }
        public string WarningName { get; set; }
        public DateTime? LetterDate { get; set; }
        public string Remarks { get; set; }
        public string Location { get; set; }
        public string Attachment { get; set; }
        public string ApprovalStatusId { get; set; }
        public DateTime? ApprovalStatusDate { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AcademicYears AcademicYear { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Lookups StdLetterType { get; set; }
        public virtual Students Student { get; set; }
    }
}
