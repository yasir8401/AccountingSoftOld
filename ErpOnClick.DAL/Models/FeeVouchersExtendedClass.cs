using ErpOnClick.Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ErpOnClick.DAL.Models
{
    public class FeeVouchersExtendedClass
    {
        public List<FeesLinesInhereted> InvoiceD { get; set; }
        

        public int FeeVoucherId { get; set; }
        public string FeeVoucherNo { get; set; }

        public int StudentId { get; set; }
        
    
        public DateTime? FeeVoucherDate { get; set; }
        public string Note { get; set; }
        

        public decimal TaxRateId { get; set; }
        public decimal? TotalTax { get; set; }

        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public string StdFeeType { get; set; }
        public string PaymentMode { get; set; }
        public int? BankId { get; set; }
        public string ChequeNo { get; set; }
        public string BankAccountNo { get; set; }
        public decimal? Amount { get; set; }


    }
}
