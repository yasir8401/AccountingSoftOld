using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class EmpContractsService : GenericRepository<EmpContracts>, IEmpContractsService
    {
        public EmpContractsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
