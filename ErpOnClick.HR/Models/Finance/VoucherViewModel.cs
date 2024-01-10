using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models.Finance
{
    public class VoucherViewModel
    {
        public Voucher voucher { get; set; }
        public string CreatedByName { get; set; }
        public string ApprovedByName { get; set; }
        public string ApprovedDate { get; set; }

    }
}
