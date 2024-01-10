using ErpOnClick.DAL.Models;
using ErpOnClick.DAL.Services;
using ErpOnClick.ErpMain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class EmpContractAndPackagesViewModel
    {
        public EmpContracts EmpContract  { get; set; }
        public IList<EmpContractPackageInheritied> EmpContractPackagesList { get; set; }


    }
}
