#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7641e33ee1d25849617583bb80854076accb78f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_JobOffers__list), @"mvc.1.0.view", @"/Areas/HumanResource/Views/JobOffers/_list.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7641e33ee1d25849617583bb80854076accb78f6", @"/Areas/HumanResource/Views/JobOffers/_list.cshtml")]
    public class Areas_HumanResource_Views_JobOffers__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
  
    var filePath = NativePaths.GetFilePath(_env);
    List<Emp> empList = Model.EmpList;
    List<JobOffers> JobOffersList = Model.JobOffersList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \" style=\"display:none\">\r\n        <thead class=\"text-sm\">\r\n            <tr>\r\n");
            WriteLiteral("                <th>");
#nullable restore
#line 22 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Candidate Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th width=\"100px\">");
#nullable restore
#line 23 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Job Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th width=\"100px\">");
#nullable restore
#line 24 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Expected Joining Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 25 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Total Salary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 26 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Manager Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th width=\"30px\"></th>\r\n                <th width=\"30px\"></th>\r\n                <th width=\"30px\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tfoot style=\"display:table-row-group\">\r\n            <tr class=\"text-center\">\r\n");
            WriteLiteral(@"                <th>Candidate Name</th>
                <th width=""100px"">Job Title</th>
                <th width=""100px"">Expected Joining Date</th>
                <th>Total Salary</th>
                <th>Manager Name</th>
                <th></th>
                <th></th>
                <th></th>

            </tr>
        </tfoot>
        <tbody>
");
#nullable restore
#line 47 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
             foreach (var item in JobOffersList)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td>");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
               Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"left\">");
#nullable restore
#line 52 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                             Write(item.FirstNameEn + " " + item.FatherNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"left\">");
#nullable restore
#line 53 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                            Write(Convert.ToDateTime(item.ExpectingJoiningDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"left\">");
#nullable restore
#line 54 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                             Write(item.TotalSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td align=\"left\">");
#nullable restore
#line 55 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
                             Write(item.ReportingManager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td class=\"text-center padding-5\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2266, "\"", 2273, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2274, "\"", 2315, 3);
            WriteAttributeValue("", 2284, "printProposal(", 2284, 14, true);
#nullable restore
#line 58 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
WriteAttributeValue("", 2298, item.JobOfferId, 2298, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2314, ")", 2314, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-block  btn-xs \"><i class=\"fa fa-print\"></i></a>\r\n                </td>\r\n                <td class=\"text-center padding-5\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7641e33ee1d25849617583bb80854076accb78f69905", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2497, "~/HumanResource/JobOffers/edit/", 2497, 31, true);
#nullable restore
#line 61 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
AddHtmlAttributeValue("", 2528, item.JobOfferId, 2528, 16, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center padding-5\">\r\n                    <a href=\"javascript:void(0)\" class=\"btn btn-default btn-block btn-xs \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2786, "\"", 2826, 3);
            WriteAttributeValue("", 2796, "deleteItem(\'", 2796, 12, true);
#nullable restore
#line 64 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
WriteAttributeValue("", 2808, item.JobOfferId, 2808, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2824, "\')", 2824, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times text-danger\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\JobOffers\_list.cshtml"
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
                    url: applicationName + ""HumanResource/JobOffers/delete"",
                    async: false,
                    type: ""POST"",
                    data: { id },
                    success: function (data) {
                        if (data.result.isError != true) {
                            showMsg('Deleted !', 'Record has been deleted !', 'success');
                            setTimeout(function () {
                                window.location = applicationName + 'HumanResource/JobOffers';
                            }, 500);
                   ");
            WriteLiteral(@"     }
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
    };

    function printProposal(id) {
        $.ajax({
            url: applicationName + ""HumanResource/JobOffers/PrintProposal"",
            async: false,
            type: ""POST"",
            data: { JobOfferId: id },
            success: function (data) {
                window.open(""http://109.73.162.9:5050/JobOffers/SAMPLE_OFFER.docx"");
                //console.log(data);
                //var blob = new Blob([data], { type: ""application/vnd.openxmlformats-officedocument.wordprocessingml.document"" });
                //debugger;
                //var fileURL = URL.createObjectURL(blob)");
            WriteLiteral(";\r\n                window.open(fileURL);\r\n            }\r\n        });\r\n    };\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment _env { get; private set; }
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
