#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f7d92ae66b2b58c14d214b61cda5eff30b510e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Receipts_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/Receipts/PrintList.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f7d92ae66b2b58c14d214b61cda5eff30b510e", @"/Areas/Finance/Views/Receipts/PrintList.cshtml")]
    public class Areas_Finance_Views_Receipts_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    List<Receipts> ReceiptsMDetails = Model.receiptsList;
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
                        RECEIPTS
                    </h2>
                    <br>

                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>


                        </thead>
                        <tbody>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <td width=""33%""><i class=""fa fa-filter""></i>Receipt Date From </td>
                                <td width=""33%""><i class=""fa fa-filter""></i>Customer </td>
                                <td width=""33%""><i class=""fa fa-filter""></i>Receipt Date To </td>

          ");
            WriteLiteral("                  </tr>\r\n\r\n                            <tr class=\"ItemColor text-center\">\r\n\r\n                                <td width=\"33%\"");
            BeginWriteAttribute("nowrap", " nowrap=\"", 1341, "\"", 1350, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 36 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                               Write(Model.ReceiptsDateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td width=\"33%\">\r\n                                    ");
#nullable restore
#line 39 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                               Write(Model.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td width=\"33%\">\r\n                                    ");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                               Write(Model.ReceiptsDateTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </td>

                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <br />

                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>
");
            WriteLiteral(@"                            <tr class=""Grid_HeaderStyle"">
                                <th style=""width:20px"">Id</th>
                                <th>Date</th>
                                <th>Receipt #</th>
                                <th>Customer</th>
                                <th>Amount</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 72 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                             if (ReceiptsMDetails.Count() > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                 foreach (var item in ReceiptsMDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"ItemColor text-center\">\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 77 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                                            Write(item.ReceiptId != 0 ? item.ReceiptId :  0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 78 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                                            Write(item.ReceiptDate != null ? Convert.ToDateTime(item.ReceiptDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 79 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                                            Write(item.ReceiptNo != null ? item.ReceiptNo : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 80 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                                            Write(item.Customer != null && item.Customer.CustomerNameEn != null ? item.Customer.CustomerNameEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-right\">");
#nullable restore
#line 81 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                                           Write(item.Amount != 0 ? item.Amount : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 83 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"ItemColor text-center\">\r\n                                    <td colspan=\"5\" class=\"text-center\">Sorry! No Data Found</td>\r\n                                </tr>\r\n");
#nullable restore
#line 90 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\PrintList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <br>
                    <br><br>
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
