#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302b097a4ff7c273515bb0a8ea433bd3e1859732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_OverTimeRequest__list), @"mvc.1.0.view", @"/Areas/ESS/Views/OverTimeRequest/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302b097a4ff7c273515bb0a8ea433bd3e1859732", @"/Areas/ESS/Views/OverTimeRequest/_list.cshtml")]
    public class Areas_ESS_Views_OverTimeRequest__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-block  btn-xs "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
  
    List<OvertimeRequests> OverTimeRequestList = Model.OverTimeRequestList;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n                <th width=\"10px\"> ");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Request No"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("OverTime Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Approval Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Approval Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("Note"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>

                <th width=""30px""></th>
              
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">
                <th width=""10px""> Id </th>
                <th> Request No </th>
                <th> OverTime Date </th>
                <th> Approval Status </th>
                <th> Approval Date </th>
                <th> Note </th>
                <th></th>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
             foreach (var item in OverTimeRequestList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td> ");
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                    Write(item.OvertimeRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                    Write(item.OvertimeRequestNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                    Write(item.OvertimeDate != null ? Convert.ToDateTime(item.OvertimeDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"center\">\r\n");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                         if (item.RequestStatusNavigation != null && item.RequestStatusNavigation.LookupNameEn == "Rejected")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth p-1 badge badge-danger mb-0\">Rejected</label>\r\n");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"

                        }
                        else if (item.RequestStatusNavigation != null && item.RequestStatusNavigation.LookupNameEn == "Approved")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth p-1 badge badge-success mb-0\">Approved</label>\r\n");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                        }
                        else if (item.RequestStatusNavigation != null && item.RequestStatusNavigation.LookupNameEn == "Pending")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth p-1 badge badge-warning mb-0\">Pending</label>\r\n");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                        }
                        else
                        {

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                    Write(item.ApprovalDate != null ? Convert.ToDateTime(item.ApprovalDate).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"left\"> ");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
                                 Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n\r\n                    <td class=\"text-center padding-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302b097a4ff7c273515bb0a8ea433bd3e185973210686", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3015, "~/ESS/OverTimeRequest/edit/", 3015, 27, true);
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
AddHtmlAttributeValue("", 3042, item.OvertimeRequestId, 3042, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\OverTimeRequest\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<script>
    $(function () {
        _initDatatable('#dtList');
        $('#dtList').show();
    });
    var applicationName = getApplicationName();

    function deleteItem(id) {
        confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
            if (result.value == true) {

                $.ajax({
                    url: applicationName + ""ESS/OverTimeRequest/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName + 'ESS/OverTimeRequest';
                            }, 500);
                        }
         ");
            WriteLiteral(@"               else if (data.result.msg != '') {
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
