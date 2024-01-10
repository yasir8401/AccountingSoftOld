using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class ChartOfAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Parent { get; set; }
        public string DefaultType { get; set; }
        public string AccountType { get; set; }
        public string IsTransactionable { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? Balance { get; set; }
        public string Status { get; set; }
    }
}
