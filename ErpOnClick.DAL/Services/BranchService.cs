using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class BranchService : GenericRepository<Branch>, IBranchService
    {
        public BranchService(ERPonClickContext context) : base(context)
        {

        }
    }

    public class BranchViewService : GenericRepository<BranchView>, IBranchViewService
    {
        public BranchViewService(ERPonClickContext context) : base(context)
        {

        }
    }
}
