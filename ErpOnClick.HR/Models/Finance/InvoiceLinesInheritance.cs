using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class InvoiceLinesInheritance : InvoicesLines
    {

        [NotMapped]
        public decimal? TaxPercent { get; set; }
        [NotMapped]
        public string IsDeleted { get; set; }
    }
}
