﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Invoicing.Models
{
    public class AccountLedgerReportModel
    {
        public string Account { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
   
}
