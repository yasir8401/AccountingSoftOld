#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db694b305ee5a54e722c705298c3565dc997f9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_AccountLedger_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/AccountLedger/PrintList.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db694b305ee5a54e722c705298c3565dc997f9b", @"/Areas/Finance/Views/AccountLedger/PrintList.cshtml")]
    public class Areas_Finance_Views_AccountLedger_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    List<AccountLedgerReportModel> listReportAccountLedger = Model.listReportAccountLedger;
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
                        Account Ledger
                    </h2>
                    <br>
                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>
                            <tr class=""Grid_HeaderStyle"">
                                <th align=""center"" width=""100px""> Date</th>
                                <th align=""center""> Account</th>
                                <th align=""center""> Voucher</th>
                                <th align=""center""> Account Code</th>
                                <th align=""center""> Description</th>
                                <");
            WriteLiteral(@"th align=""center""> Type</th>
                                <th align=""center""> Debit </th>
                                <th align=""center""> Credit </th>
                                <th align=""center""> Balance</th>

                            </tr>
                        </thead>
");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 37 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                 foreach (var item in listReportAccountLedger)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"ItemColor text-center\">\r\n                                    <td align=\"center\" width=\"100px\"> ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                                  Write(item.CreatedDate != null ? Convert.ToDateTime(item.CreatedDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"left\"> ");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                  Write(item.Account != null ? item.Account : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"center\">\r\n");
#nullable restore
#line 43 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                         if (item.Voucher != 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\'", 2306, "\'", 2366, 3);
#nullable restore
#line 45 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
WriteAttributeValue("", 2313, Url.Content("~/"), 2313, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2331, "Finance/Vouchers/Edit/", 2331, 22, true);
#nullable restore
#line 45 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
WriteAttributeValue("", 2353, item.Voucher, 2353, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                                                                       Write(item.Voucher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 46 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n\r\n                                    <td align=\"left\"> ");
#nullable restore
#line 49 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                  Write(item.AccountCode != null ? item.AccountCode : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"center\"> ");
#nullable restore
#line 50 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                    Write(item.Description != null ? item.Description : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"center\"> ");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                    Write(item.Type != null ? item.Type : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"right\"> ");
#nullable restore
#line 52 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                   Write(item.Debit != 0 ? String.Format("{0:.00}",item.Debit) : "0");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"right\"> ");
#nullable restore
#line 53 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                   Write(item.Credit != 0 ? String.Format("{0:.00}",item.Credit) : "0");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td align=\"right\"> ");
#nullable restore
#line 54 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                   Write(item.Balance != 0 ? String.Format("{0:.00}",item.Balance) : "0");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                </tr>\r\n");
#nullable restore
#line 56 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                            <tfoot>
                                <tr class=""Grid_HeaderStyle"">
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td align=""center"">Total</td>
                                    <td align=""center"">");
#nullable restore
#line 67 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                   Write(String.Format("{0:.00}", listReportAccountLedger.Sum(x => x.Debit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td align=\"center\">");
#nullable restore
#line 68 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\AccountLedger\PrintList.cshtml"
                                                   Write(String.Format("{0:.00}", listReportAccountLedger.Sum(x => x.Credit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td align=\"center\"></td>\r\n                                </tr>\r\n                            </tfoot>\r\n");
            WriteLiteral("                    </table>\r\n                    <br>\r\n                    <br><br>\r\n                    <hr style=\"border: 1px solid whitesmoke; margin-bottom:5px;\">\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n</div>");
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