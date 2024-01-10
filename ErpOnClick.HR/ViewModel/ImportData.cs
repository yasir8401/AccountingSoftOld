using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.ViewModel
{
    public class ImportData
    {
        public List<importData> IData { get; set; }


    }

    public class importData
    {
        public int AccountId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Nature { get; set; }
        public string Type { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsTransactionable { get; set; }
    }
}
