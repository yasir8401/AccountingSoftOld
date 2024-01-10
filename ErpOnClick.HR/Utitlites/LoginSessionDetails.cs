using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Utitlites
{
    public class LoginSessionDetails
    {
        public static int GetLoginUserId(HttpContext httpContext)
        {
            return (httpContext.User.FindFirst(ClaimTypes.Name).Value != null ? Int32.Parse(httpContext.User.FindFirst(ClaimTypes.Name).Value) : 0);
        }
        public static int GetLoginUserName(HttpContext httpContext)
        {
            return (httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value != null ? Int32.Parse(httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value) : 0);
        }
        public static string  GetUserIp(HttpContext httpContext)
        {
            return (httpContext.Connection.RemoteIpAddress.ToString());
        }
    }
}
