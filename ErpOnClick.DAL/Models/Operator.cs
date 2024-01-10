using System;
using System.Collections.Generic;

namespace ErpOnClick.DAL.Models
{
    public partial class Operator
    {
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
