using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            Banks = new HashSet<Banks>();
            Customers = new HashSet<Customers>();
            FixedAsset = new HashSet<FixedAsset>();
            GeneralEntriesLines = new HashSet<GeneralEntriesLines>();
            InverseParentAccount = new HashSet<Accounts>();
            Vendors = new HashSet<Vendors>();
            VoucherLines = new HashSet<VoucherLines>();
        }

        public int AccountId { get; set; }
        public string AccountNameEn { get; set; }
        public string AccountNameAr { get; set; }
        public string AccountCode { get; set; }
        public int? ParentAccountId { get; set; }
        public int? AccountTypeId { get; set; }
        public int? AccountGroupId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string DefaultType { get; set; }
        public int? AccountLevel { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? ClosingBalance { get; set; }
        public bool? IsTransactionable { get; set; }
        public bool? Status { get; set; }

        public virtual AccountGroups AccountGroup { get; set; }
        public virtual AccountTypes AccountType { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Accounts ParentAccount { get; set; }
        public virtual ICollection<Banks> Banks { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<FixedAsset> FixedAsset { get; set; }
        public virtual ICollection<GeneralEntriesLines> GeneralEntriesLines { get; set; }
        public virtual ICollection<Accounts> InverseParentAccount { get; set; }
        public virtual ICollection<Vendors> Vendors { get; set; }
        public virtual ICollection<VoucherLines> VoucherLines { get; set; }
    }
}
