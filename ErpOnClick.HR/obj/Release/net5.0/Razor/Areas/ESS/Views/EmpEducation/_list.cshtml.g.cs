#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc27659990ff7b15e80d38653954e66f9cd94d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpEducation__list), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpEducation/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc27659990ff7b15e80d38653954e66f9cd94d9", @"/Areas/ESS/Views/EmpEducation/_list.cshtml")]
    public class Areas_ESS_Views_EmpEducation__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-block  btn-xs "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
  
    List<EmpEducation> EmpEducationList = Model.EmpEducationList;
    var empId = Model.empId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n                <th>");
#nullable restore
#line 14 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 15 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Degree title"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("University"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("From"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("To"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Attachments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>

                <th width=""30px""></th>
                
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">

                <th>Id </th>
                <th>Degree title </th>
                <th>University </th>
                <th>From </th>
                <th>To </th>
                <th>Attachments </th>
                <th></th>
                

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
             foreach (var item in EmpEducationList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                   Write(item.EmpEducationId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                   Write(item.DegreeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                   Write(item.UniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                   Write(item.FromDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                   Write(item.ToDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                         if (!String.IsNullOrWhiteSpace(item.Attachments))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc27659990ff7b15e80d38653954e66f9cd94d99080", async() => {
                WriteLiteral("DownloadDPF");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1874, "~/Files/", 1874, 8, true);
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
AddHtmlAttributeValue("", 1882, item.Attachments, 1882, 17, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n\r\n                    <td class=\"text-center padding-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc27659990ff7b15e80d38653954e66f9cd94d911114", async() => {
                WriteLiteral("<i class=\"fa fa-search\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2083, "~/ESS/EmpEducation/view/emp/", 2083, 28, true);
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
AddHtmlAttributeValue("", 2111, item.EmpId, 2111, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2122, "/", 2122, 1, true);
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
AddHtmlAttributeValue("", 2123, item.EmpEducationId, 2123, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
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
                    url: applicationName+""ESS/EmpEducation/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName + 'ESS/EmpEducation/emp/");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpEducation\_list.cshtml"
                                                                                     Write(empId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

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
