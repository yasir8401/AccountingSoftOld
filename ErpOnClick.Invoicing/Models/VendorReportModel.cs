﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Invoicing.Models
{
    public class VendorReportModel
    {
        public int VendorId { get; set; }
        public string Vendor { get; set; }
        public string Account { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }


    }
   
}
