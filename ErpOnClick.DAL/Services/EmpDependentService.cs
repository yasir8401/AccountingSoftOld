using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class EmpDependentService : GenericRepository<EmpDependents>,IEmpDependentsService
    {
        public EmpDependentService(ERPonClickContext context) : base(context)
        {

        }
    }
}
