using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class RolesService : GenericRepository<Roles>, IRoleService
    {
        public RolesService(ERPonClickContext context) : base(context)
        {

        }
    }
}
