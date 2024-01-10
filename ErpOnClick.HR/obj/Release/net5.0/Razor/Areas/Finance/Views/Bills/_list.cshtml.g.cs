#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3492d3b64db852b3816dbbbc0495e24d32d727ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Bills__list), @"mvc.1.0.view", @"/Areas/Finance/Views/Bills/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3492d3b64db852b3816dbbbc0495e24d32d727ca", @"/Areas/Finance/Views/Bills/_list.cshtml")]
    public class Areas_Finance_Views_Bills__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
   List<Bills> BillMDetails = Model.billMList; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-responsive pb-2 \">\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\n        <thead class=\"text-sm\">\n            <tr class=\"col-lg-12\">\n                <th style=\"width:20px\">");
#nullable restore
#line 11 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 12 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Vendor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 13 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Due Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th style=\"width:25px\">");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th style=\"width:25px\">");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th style=""width:20px"">Id</th>
                <th>Vendor</th>
                <th>Date</th>
                <th>Due Date</th>
                <th>Amount</th>
                <td></td>
                <td></td>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
             foreach (var item in BillMDetails)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"text-center\">\n    <td style=\"width:20px\">");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                       Write(item.BillId != 0 ? item.BillId : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-left\">");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                      Write(item.Vendor != null && item.Vendor.VendorNameEn != null ? item.Vendor.VendorNameEn : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
    Write(item.BillDate != null ? Convert.ToDateTime(item.BillDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
    Write(item.DueDate != null ? Convert.ToDateTime(item.DueDate).ToString("dd-MMM-yyyy") : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-right\">");
#nullable restore
#line 41 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
                       Write(item.Total != 0 ? item.Total : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td class=\"text-center padding-5\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 1901, "\"", 1957, 3);
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
WriteAttributeValue("", 1908, Url.Content("~/"), 1908, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1926, "Finance/Bills/edit/", 1926, 19, true);
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
WriteAttributeValue("", 1945, item.BillId, 1945, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-block  btn-xs \"><i class=\"fa fa-edit\"></i></a>\n    </td>\n    <td class=\"text-center padding-5\">\n        <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2160, "\"", 2196, 3);
            WriteAttributeValue("", 2170, "deleteItem(\'", 2170, 12, true);
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
WriteAttributeValue("", 2182, item.BillId, 2182, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2194, "\')", 2194, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times text-danger\"></i></a>\n    </td>\n</tr>\n");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\_list.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    $(function () {
        $('#AccPli').addClass(""menu-open"");
        $('#AccRli').removeClass(""menu-open"");
        $('#Accli').removeClass(""menu-open"");
        $('#Setupli').removeClass(""menu-open"");

        _initDatatable('#dtList');
    });

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {
                $.ajax({
                    url: getApplicationName() + ""Finance/Bills/Delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError == true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = '/Finance/Bills';
                 ");
            WriteLiteral(@"           }, 500);
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