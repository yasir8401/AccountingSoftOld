using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AccountTypes
    {
        public AccountTypes()
        {
            Accounts = new HashSet<Accounts>();
            InverseParentAccountType = new HashSet<AccountTypes>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeNameEn { get; set; }
        public string AccountTypeNameAr { get; set; }
        public string AccountTypeCode { get; set; }
        public int? ParentAccountTypeId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AccountTypes ParentAccountType { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<AccountTypes> InverseParentAccountType { get; set; }
    }
}
