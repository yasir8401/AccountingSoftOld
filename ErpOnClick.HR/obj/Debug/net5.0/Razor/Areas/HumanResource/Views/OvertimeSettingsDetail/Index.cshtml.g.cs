#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1479c5d4c1c3ca01a1ec52dadec366a30d0f97bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_OvertimeSettingsDetail_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/OvertimeSettingsDetail/Index.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1479c5d4c1c3ca01a1ec52dadec366a30d0f97bf", @"/Areas/HumanResource/Views/OvertimeSettingsDetail/Index.cshtml")]
    public class Areas_HumanResource_Views_OvertimeSettingsDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
  

    var OvertimesettingsID = Model.OvertimesettingsID;
    OvertimeSettings OvertimesettingsDetails = Model.OvertimesettingsDetails;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<form id=\"frmList\">\r\n    <input type=\"hidden\" id=\"OvertimesettingsID\" name=\"OvertimesettingsID\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 418, "\"", 445, 1);
#nullable restore
#line 18 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
WriteAttributeValue("", 426, OvertimesettingsID, 426, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""card card-default card-outline"">
        <div class=""card-header p-0 border-bottom-0"">
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link""");
            BeginWriteAttribute("onclick", " onclick=\"", 720, "\"", 827, 6);
            WriteAttributeValue("", 730, "window.location", 730, 15, true);
            WriteAttributeValue(" ", 745, "=", 746, 2, true);
            WriteAttributeValue(" ", 747, "getApplicationName()", 748, 21, true);
            WriteAttributeValue(" ", 768, "+\'HumanResource/Overtimesettings/edit/", 769, 39, true);
#nullable restore
#line 24 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
WriteAttributeValue("", 807, OvertimesettingsID, 807, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 826, "\'", 826, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\">");
#nullable restore
#line 24 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
                                                                                                                                                                         Write(SharedLocalizer.GetLocalizedHtmlString("OverTime Settings"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"tabOvertimesettingsDetails-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1077, "\"", 1203, 7);
            WriteAttributeValue("", 1087, "window.location", 1087, 15, true);
            WriteAttributeValue(" ", 1102, "=", 1103, 2, true);
            WriteAttributeValue(" ", 1104, "getApplicationName()", 1105, 21, true);
            WriteAttributeValue(" ", 1125, "+", 1126, 2, true);
            WriteAttributeValue(" ", 1127, "\'HumanResource/OvertimesettingsDetail/Overtimesettings/", 1128, 56, true);
#nullable restore
#line 27 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
WriteAttributeValue("", 1183, OvertimesettingsID, 1183, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1202, "\'", 1202, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\">");
#nullable restore
#line 27 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
                                                                                                                                                                                                                                                   Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 35 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Overtimesettings Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1479c5d4c1c3ca01a1ec52dadec366a30d0f97bf9021", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-plus\"></i> ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
                                           Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1620, "~/HumanResource/OvertimesettingsDetail/edit/Overtimesettings/", 1620, 61, true);
#nullable restore
#line 39 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\OvertimeSettingsDetail\Index.cshtml"
AddHtmlAttributeValue("", 1681, OvertimesettingsID, 1681, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card-body\">\r\n            <div id=\"divList\"></div>\r\n\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#tabOvertimesettingsDetails-tab"").addClass(""nav-link active"");
            BindGrid();
        });
        var applicationName = getApplicationName();


        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'HumanResource/OvertimesettingsDetail/_list',
                data: $('#frmList').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };

    </script>
");
            }
            );
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