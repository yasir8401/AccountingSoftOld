using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Models
{
    public class DbResult
    {
        public bool isError { get; set; }
        public string msg { get; set; }

        public object scalerVal { get; set; }

    }
}


