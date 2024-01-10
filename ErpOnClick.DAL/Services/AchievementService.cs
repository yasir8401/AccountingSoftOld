using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Services
{
    public class AchievementService : GenericRepository<Achievement>, IAchievementService
    {
        public AchievementService(ERPonClickContext context) : base(context)
        {

        }
    }
}
