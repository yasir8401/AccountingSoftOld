using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Visitor
    {
        public int VisitorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public string Ipaddress { get; set; }
    }
}
