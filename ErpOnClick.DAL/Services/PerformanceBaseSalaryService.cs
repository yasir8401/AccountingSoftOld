using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class PerformanceBaseSalaryService : GenericRepository<PerformanceBaseSalary>, IPerformanceBaseSalaryService
    {
        public PerformanceBaseSalaryService(ERPonClickContext context) : base(context)
        {

        }
    }
}
