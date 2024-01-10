using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class AccountsService : GenericRepository<Accounts>, IAccountsService
    {
        public AccountsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
