using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class PayGroupsService : GenericRepository<PayGroups>, IPayGroupsService
    {
        public PayGroupsService(ERPonClickContext context) : base(context)
        {

        }

    }
}
