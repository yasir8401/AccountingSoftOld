using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpBanks
    {
        public int EmpBankId { get; set; }
        public int? EmpId { get; set; }
        public string BankId { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountTitle { get; set; }
        public string BankIban { get; set; }
        public string Note { get; set; }
        public int? CompanyId { get; set; }
        public int? BranchId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Emp Emp { get; set; }
    }
}
