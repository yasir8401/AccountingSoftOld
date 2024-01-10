using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models
{
    public class GeneralLinesExtended
    {
        public List<GeneralEntriesLinesInheritance> GeneralEntriesLinesD { get; set; }

        public int GeneralEntryId { get; set; }
        public DateTime? GeneralEntryDate { get; set; }
        public string GeneralEntryNo { get; set; }
        public string Currency { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public string Note { get; set; }



    }
}
