#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d1291dad53308f87531541c7c9bf369f87f99a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Receipts__list), @"mvc.1.0.view", @"/Areas/Finance/Views/Receipts/_list.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d1291dad53308f87531541c7c9bf369f87f99a", @"/Areas/Finance/Views/Receipts/_list.cshtml")]
    public class Areas_Finance_Views_Receipts__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
  
    List<Receipts> ReceiptIdList = Model.receiptsMList;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm \">\r\n            <tr class=\"col-lg-12\">\r\n                <th style=\"width:20px\">");
#nullable restore
#line 14 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 15 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n                <th style=\"width:25px\">");
#nullable restore
#line 20 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"width:25px\">");
#nullable restore
#line 21 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th style=""width:20px"">ID</th>
                <th>Customer</th>
                <th>Date</th>
                <th>Amount</th>


                <td></td>
                <td></td>
            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 37 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
             foreach (var item in ReceiptIdList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td style=\"width:20px\">");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                       Write(item.ReceiptId != 0 ? item.ReceiptId : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                      Write(item.Customer != null && item.Customer.CustomerNameEn != null ? item.Customer.CustomerNameEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                    Write(item.ReceiptDate != null ? Convert.ToDateTime(item.ReceiptDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 44 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
                                       Write(item.Amount != 0 ? item.Amount : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    <td class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1885, "\"", 1947, 3);
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
WriteAttributeValue("", 1892, Url.Content("~"), 1892, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1909, "/Finance/Receipts/edit/", 1909, 23, true);
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
WriteAttributeValue("", 1932, item.ReceiptId, 1932, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-block  btn-xs \"><i class=\"fa fa-edit\"></i></a>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2191, "\"", 2230, 3);
            WriteAttributeValue("", 2201, "deleteItem(\'", 2201, 12, true);
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
WriteAttributeValue("", 2213, item.ReceiptId, 2213, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2228, "\')", 2228, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times text-danger\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Receipts\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<script>
    $(function () {
        $('#AccRli').addClass(""menu-open"");
        $('#AccPli').removeClass(""menu-open"");
        $('#Accli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");

        _initDatatable('#dtList');
    });

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {

                $.ajax({
                    url: getApplicationName() + ""Finance/Receipts/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = ge");
            WriteLiteral(@"tApplicationName() + 'Finance/Receipts';
                            }, 500);
                        }
                        else if (data.result.msg != '') {
                            showMsg('Delete Failed !', data.result.msg, 'error');
                        }
                        else {
                            showMsg('Delete Failed !', 'Something went wrong. Try again', 'error');
                        }
                    }
                });
            }
        });
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
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
