#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd4981f1e89fd1b76667c8f1cb83da3e1060b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_FixedAsset_PrintList), @"mvc.1.0.view", @"/Areas/Finance/Views/FixedAsset/PrintList.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd4981f1e89fd1b76667c8f1cb83da3e1060b9a", @"/Areas/Finance/Views/FixedAsset/PrintList.cshtml")]
    public class Areas_Finance_Views_FixedAsset_PrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
  
    Layout = "_LayoutReport";
    List<FixedAsset> FixedAsset = Model.FixedAssetIdList;
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
                        FIXED ASSET
                    </h2>
                    <br>
                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>


                        </thead>
                        <tbody>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <td><i class=""fa fa-filter""></i>Purchase Date From </td>
                                <td><i class=""fa fa-filter""></i>Purchase Date To </td>
                                <td><i class=""fa fa-filter""></i>Asset </td>
                                <td><i class=""fa fa-filter""></i>Warran");
            WriteLiteral("ty Date From </td>\n                                <td><i class=\"fa fa-filter\"></i>Warranty Date To </td>\n                            </tr>\n\n                            <tr class=\"ItemColor text-center\">\n\n                                <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 1439, "\"", 1448, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                    ");
#nullable restore
#line 37 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                               Write(Model.PurchaseDateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                               Write(Model.PurchaseDateTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 44 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                               Write(Model.AssetType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                               Write(Model.WarrantyDateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 52 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                               Write(Model.WarrantyDateTo);

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
                                <th style=""width:20px"">Fixed Asset Id</th>

                                <th>Name</th>
                                <th>Asset Type</th>
                                <th>Purchase Date</th>
                                <th>Warranty Date</th>
                                <th>Purchase Price </th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 85 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                             if (FixedAsset.Count() > 0)
                            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                 foreach (var item in FixedAsset)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"ItemColor text-center\">\n                    <td class=\"text-center\">");
#nullable restore
#line 90 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(item.FixedAssetId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-center\">");
#nullable restore
#line 91 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(item.FixedAssetEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-center\">");
#nullable restore
#line 92 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(item.AssetType.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-center\">");
#nullable restore
#line 93 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(Convert.ToDateTime(item.PurchaseDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                    <td class=\"text-center\">");
#nullable restore
#line 95 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(Convert.ToDateTime(item.WarrantyExpiry).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"text-center\">");
#nullable restore
#line 96 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                                       Write(item.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>");
#nullable restore
#line 97 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
                       }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"ItemColor text-center\">\n                    <td colspan=\"6\" class=\"text-center\">Sorry! No Data Found.</td>\n                </tr>");
#nullable restore
#line 102 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\FixedAsset\PrintList.cshtml"
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