using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public static class NativePaths
    {
        public static  string GetFilePath(IHostingEnvironment _env = null)
        {
                    string path = "";
            if (_env != null && _env.IsProduction())
            {
                path = "http://185.247.119.175:88/Files/";
            }
            else if (_env != null && _env.IsDevelopment())
            {
                path = "http://localhost:81/Files/";
            }
            else
            {
                path = "/Files/";
            }

            return path;
        }
    }
}
