using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class BranchView
    {
        public int BranchId { get; set; }
        public string BranchNameEn { get; set; }
        public string BranchNameAr { get; set; }
        public string BranchEmail { get; set; }
        public string BranchPhone { get; set; }
        public string BranchAddressEn { get; set; }
        public string BranchAddressAr { get; set; }
        public bool? IsEnable { get; set; }
        public int? CompanyId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string CoNameEn { get; set; }
        public string CoNameAr { get; set; }
        public string CoEmail { get; set; }
        public string CoPhone { get; set; }
        public string CoWebsite { get; set; }
        public string CoAddressEn { get; set; }
        public string CoAddressAr { get; set; }
        public string CrNo { get; set; }
        public string VatNo { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string BankDetailEn { get; set; }
        public string BankDetailAr { get; set; }
        public int? FiscalYearStartMonth { get; set; }
        public string FiscalYearIsBasedOn { get; set; }
    }
}
