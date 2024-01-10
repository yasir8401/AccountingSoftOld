using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class AccountGroupsService : GenericRepository<AccountGroups>, IAccountGroupsService
    {
        public AccountGroupsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
