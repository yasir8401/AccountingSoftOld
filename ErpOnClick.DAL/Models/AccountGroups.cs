using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class AccountGroups
    {
        public AccountGroups()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int AccountGroupId { get; set; }
        public string AccountGroupNameEn { get; set; }
        public string AccountGroupNameAr { get; set; }
        public string AccountGroupCode { get; set; }
        public int? ParentAccountGroupId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
