using ErpOnClick.DAL.Interfaces;
using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public static class LogDetails
    {

        //public static string GetIP()
        //{
        //    string strHostName = "";
        //    strHostName = System.Net.Dns.GetHostName();

        //    IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

        //    IPAddress[] addr = ipEntry.AddressList;

        //    return addr[addr.Length - 1].ToString();

        //}
        public static void LogData(IActivityLogService activityLogService, ActivityLog data)
        {
            if (data != null)
            {
               var result =  activityLogService.Insert(data);
                result = activityLogService.SaveChanges();
            }
        }
    }
}
