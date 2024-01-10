using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class EmpContractsPackage
    {
        public int EmpContractsPackageId { get; set; }
        public int EmpContractId { get; set; }
        public string AllowanceTypeId { get; set; }
        public decimal Amount { get; set; }

        public virtual EmpContracts EmpContract { get; set; }
    }
}
