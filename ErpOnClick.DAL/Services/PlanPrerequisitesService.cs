using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class PlanPrerequisitesService : GenericRepository<PlanPrerequisites>, IPlanPrerequisitesService
    {
        public PlanPrerequisitesService(ERPonClickContext context) : base(context)
        {

        }
    }
}
