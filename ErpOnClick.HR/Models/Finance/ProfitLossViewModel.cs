using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.ErpMain.Models.Finance
{
    public class ProfitLossViewModel
    {
        public decimal? Revenue2021 { get; set; }
        public decimal? Revenue2020 { get; set; }
        public decimal? CostOfRevenue2021 { get; set; }
        public decimal? CostOfRevenue2020 { get; set; }
        public decimal? GrossProfitLoss2021 { get; set; }
        public decimal? GrossProfitLoss2020 { get; set; }
        public decimal? GeneralAndAdministrativeExpense2021 { get; set; }
        public decimal? GeneralAndAdministrativeExpense2020 { get; set; }
        public decimal? OperatingExpense2021 { get; set; }
        public decimal? OperatingExpense2020 { get; set; }
        public decimal? SellingAndDistributionExpense2021 { get; set; }
        public decimal? SellingAndDistributionExpense2020 { get; set; }
        public decimal? TotalOperatingExpenses2021 { get; set; }
        public decimal? TotalOperatingExpenses2020 { get; set; }
        public decimal? FinanceCost2021 { get; set; }
        public decimal? FinanceCost2020 { get; set; }
        public decimal? Taxation2021 { get; set; }
        public decimal? Taxation2020 { get; set; }
        public decimal? ProfitLossBeforeTaxation2021 { get; set; }
        public decimal? ProfitLossBeforeTaxation2020 { get; set; }
        public decimal? ProfitLossAfterTaxation2021 { get; set; }
        public decimal? ProfitLossAfterTaxation2020 { get; set; }
    }
}
