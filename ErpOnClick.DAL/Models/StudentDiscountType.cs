using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class StudentDiscountType
    {
        public int StudentDiscountTypeId { get; set; }
        public string StudentDiscountTypeNameEn { get; set; }
        public string StudentDiscountTypeNameAr { get; set; }
        public string StudentDiscountTypeCode { get; set; }
        public bool? IsPercentage { get; set; }
        public decimal? Value { get; set; }
        public DateTime? ValidTill { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
