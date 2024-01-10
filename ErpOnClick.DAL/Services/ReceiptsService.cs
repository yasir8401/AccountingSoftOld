using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class ReceiptsService : GenericRepository<Receipts>, IReceiptsService
    {
        public ReceiptsService(ERPonClickContext context) : base(context)
        {

        }
    }
}
