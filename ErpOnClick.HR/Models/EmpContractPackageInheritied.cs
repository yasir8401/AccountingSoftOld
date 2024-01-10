using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class EmpContractPackageInheritied: ErpOnClick.DAL.Models.EmpContractsPackage
    {
        [NotMapped]
        public string IsDeleted { get; set; }
    }
}
