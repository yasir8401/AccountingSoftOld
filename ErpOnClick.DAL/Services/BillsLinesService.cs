using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class BillsLinesService : GenericRepository<BillsLines>, IBillsLinesService
    {
        public BillsLinesService(ERPonClickContext context) : base(context)
        {

        }
    }
}
