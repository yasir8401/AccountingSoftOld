using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class ApplicationsService : GenericRepository<Applications>, IApplicationsService
    {
        public ApplicationsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
