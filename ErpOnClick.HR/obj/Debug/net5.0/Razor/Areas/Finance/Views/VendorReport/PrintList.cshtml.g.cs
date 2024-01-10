#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f34fe568118125ed3c6f5764ff4449df6321db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_VendorReport_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/VendorReport/PrintList.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f34fe568118125ed3c6f5764ff4449df6321db6", @"/Areas/Finance/Views/VendorReport/PrintList.cshtml")]
    public class Areas_Finance_Views_VendorReport_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    List<VendorReportModel> listReportVendor = Model.listReportVendor;
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
                        Vendor Report
                    </h2>
                    <br>
                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>
                            <tr class=""Grid_HeaderStyle"">
                                <th align=""left""> Date</th>
                                <th align=""left""> Account</th>
                                <th align=""right""> Debit </th>
                                <th align=""right""> Credit </th>
                                <th align=""right""> Balance</th>

                            </tr>
                        </th");
            WriteLiteral("ead>\r\n");
            WriteLiteral("                                <tbody>\r\n\r\n");
#nullable restore
#line 34 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                     foreach (var item in listReportVendor)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"ItemColor text-center\">\r\n                                            <td align=\"left\" width=\"100px\"> ");
#nullable restore
#line 38 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                                        Write(Convert.ToDateTime(item.CreatedDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td align=\"left\"> ");
#nullable restore
#line 39 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                         Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td align=\"right\"> ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                           Write(String.Format("{0:.00}",item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td align=\"right\"> ");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                           Write(String.Format("{0:.00}",item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td align=\"right\"> ");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                           Write(String.Format("{0:.00}",item.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 44 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                                <tfoot>
                                    <tr class=""Grid_HeaderStyle"">
                                        <td align=""right"" colspan=""2"">Total</td>

                                        <td align=""right"">");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                      Write(String.Format("{0:.00}", listReportVendor.Sum(x => x.Debit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td align=\"right\">");
#nullable restore
#line 52 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\VendorReport\PrintList.cshtml"
                                                      Write(String.Format("{0:.00}", listReportVendor.Sum(x => x.Credit)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td align=\"right\"></td>\r\n                                    </tr>\r\n                                </tfoot>\r\n");
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
