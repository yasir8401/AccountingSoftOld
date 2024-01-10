﻿using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.Invoicing.Models
{
    public class CreditNotesLinesInheritance : CreditNotesLines
    {
        [NotMapped]
        public decimal? TaxPercent { get; set; }
        [NotMapped]
        public string IsDeleted { get; set; }
    }
}