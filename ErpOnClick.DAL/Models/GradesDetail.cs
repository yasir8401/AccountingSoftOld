using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class GradesDetail
    {
        public int GradeDetailId { get; set; }
        public int GradeId { get; set; }
        public string AllowanceTypeId { get; set; }
        public decimal? RangeFrom { get; set; }
        public decimal? RangeTo { get; set; }
        public bool? IsEnable { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Grades1 Grade { get; set; }
    }
}
