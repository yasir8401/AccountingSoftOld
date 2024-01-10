#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4b2141ecfb24a33fbb8434c49df692c1a1d75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_ProfitLoss_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/ProfitLoss/PrintList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
using ErpOnClick.ErpMain.Models.Finance;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4b2141ecfb24a33fbb8434c49df692c1a1d75f", @"/Areas/Finance/Views/ProfitLoss/PrintList.cshtml")]
    public class Areas_Finance_Views_ProfitLoss_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    ProfitLossViewModel profitLossViewModel = Model.profitLossViewModel;
    Company CompanyDetail = Model.CompanyDetail;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <br />

    <table id=""Outline1"" style=""border-collapse: collapse"" bordercolor=""silver"" cellspacing=""0"" cellpadding=""3"" width=""100%"" border=""0"">
        <tbody>
            <tr>
                <td>
                    <h2 class=""ReportTitle text-center"" style=""font-size: 25px ; margin:0px;  "">
                        PROFIT / LOSS STATEMENT
                    </h2>
                    <br>
                    <div class=""table-responsive pb-2 "">
                        <table id=""pltable"" class=""table table-hover table-condensed "">
                            <thead class=""text-sm "">
                                <tr class=""col-lg-12 text-center"">
                                    <th width=""50%"">  </th>
                                    <th width=""10%"">Notes</th>
                                    <th width=""20%""> 2021 <br />-Rupees-</th>
                                    <th width=""20%""> 2020 <br />-Rupees-</th>

                                </tr>
             ");
            WriteLiteral(@"               </thead>
                            <tbody>
                                <tr>
                                    <td class=""text-left""> </td>
                                    <td> </td>
                                    <td> </td>
                                    <td> </td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Revenue </td>
                                    <td></td>
                                    <td class=""b-t b-lr text-center"">");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.Revenue2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-t b-lr text-center\">");
#nullable restore
#line 43 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.Revenue2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Cost of Revenue </td>
                                    <td></td>
                                    <td class=""b-b b-lr text-center"">");
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.CostOfRevenue2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-b b-lr text-center\">");
#nullable restore
#line 49 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.CostOfRevenue2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Gross Profit / (Loss) </td>
                                    <td></td>
                                    <td class=""text-center"">");
#nullable restore
#line 54 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.GrossProfitLoss2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 55 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.GrossProfitLoss2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> General and Administrative Expense</td>
                                    <td></td>
                                    <td class=""b-t b-lr text-center"">");
#nullable restore
#line 72 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.GeneralAndAdministrativeExpense2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-t b-lr text-center\">");
#nullable restore
#line 73 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.GeneralAndAdministrativeExpense2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Operating Expense</td>
                                    <td></td>
                                    <td class=""b-lr text-center"">");
#nullable restore
#line 78 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                            Write(profitLossViewModel.OperatingExpense2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-lr text-center\">");
#nullable restore
#line 79 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                            Write(profitLossViewModel.OperatingExpense2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Selling and Distribution Expense</td>
                                    <td></td>
                                    <td class=""b-b b-lr text-center"">");
#nullable restore
#line 84 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.SellingAndDistributionExpense2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-b b-lr text-center\">");
#nullable restore
#line 85 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                                Write(profitLossViewModel.SellingAndDistributionExpense2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Total Operating Expenses</td>
                                    <td></td>
                                    <td class=""text-center"">");
#nullable restore
#line 90 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.TotalOperatingExpenses2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 91 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.TotalOperatingExpenses2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Finance Cost</td>
                                    <td></td>
                                    <td class=""b-b text-center"">");
#nullable restore
#line 102 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                           Write(profitLossViewModel.FinanceCost2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-b text-center\">");
#nullable restore
#line 103 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                           Write(profitLossViewModel.FinanceCost2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Profit / (loss) Before Taxation</td>
                                    <td></td>
                                    <td class=""text-center"">");
#nullable restore
#line 114 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.ProfitLossBeforeTaxation2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 115 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.ProfitLossBeforeTaxation2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Taxation</td>
                                    <td></td>
                                    <td class=""text-center"">");
#nullable restore
#line 126 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.Taxation2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 127 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                       Write(profitLossViewModel.Taxation2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""> Profit / (loss) After Taxation</td>
                                    <td></td>
                                    <td class=""b-t b-b text-center"">");
#nullable restore
#line 138 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                               Write(profitLossViewModel.ProfitLossAfterTaxation2021);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"b-t b-b text-center\">");
#nullable restore
#line 139 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\ProfitLoss\PrintList.cshtml"
                                                               Write(profitLossViewModel.ProfitLossAfterTaxation2020);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class=""text-left""></td>
                                    <td></td>
                                    <td class=""text-center""></td>
                                    <td></td>
                                </tr>
                                <tr class=""signatrure-table"">
                                    <td style=""display: none;""></td>
                                    <td colspan=""2"" class=""signatrure-section""><span>Chief Executive Officer</span></td>
                                    <td colspan=""2"" class=""signatrure-section""><span>Director</span></td>
          ");
            WriteLiteral(@"                          <td style=""display: none;""></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>

                    <hr style=""border: 1px solid whitesmoke; margin-bottom:5px;"">
                </td>
            </tr>
        </tbody>
    </table>

</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
