#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06755d28f56d4e795f58dcc1f2ffb170f00f7a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Vendors_Index), @"mvc.1.0.view", @"/Areas/Finance/Views/Vendors/Index.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06755d28f56d4e795f58dcc1f2ffb170f00f7a9f", @"/Areas/Finance/Views/Vendors/Index.cshtml")]
    public class Areas_Finance_Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Finance/Vendors/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
   List<Accounts> Accounts = Model.Accounts;
    List<Lookups> ActiveStatus = Model.ActiveStatus; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\n    Lookup Setup\n");
            }
            );
            WriteLiteral("\n\n<div class=\"card card-default card-outline\">\n\n    <div class=\"card-header\">\n        <h2 class=\"card-title\">\n            ");
#nullable restore
#line 18 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Vendors"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h2>\n        <!-- tools box -->\n        <div class=\"card-tools\">\n            <a id=\"printList\"");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 523, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fa fa-print fa-fw\"></i>");
#nullable restore
#line 22 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06755d28f56d4e795f58dcc1f2ffb170f00f7a9f5866", async() => {
                WriteLiteral("\n                <i class=\"fas fa-plus\"></i> ");
#nullable restore
#line 25 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                       Write(SharedLocalizer.GetLocalizedHtmlString("Add New"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <!-- /. tools -->
    </div>

    <div class=""card-footer pb-0 pt-2 text-sm"">
        <form id=""frmSearch"">
            <div class=""row"">
                <div class=""col-sm-3"">
                    <div class=""form-group "">
                        <label>");
#nullable restore
#line 36 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Chart of Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <select name=\"AccountId\" id=\"AccountId\" class=\"form-control input-sm text-sm select2\">\n                            <option");
            BeginWriteAttribute("value", " value=\"", 1354, "\"", 1362, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\n");
#nullable restore
#line 39 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                             foreach (var head in Accounts.Where(c => c.AccountLevel == 1))
                            {
                                foreach (var subhead in Accounts.Where(c => c.AccountLevel == 2 && c.ParentAccountId == head.AccountId))
                                {
                                    foreach (var subsubhead in Accounts.Where(c => c.AccountLevel == 3 && c.ParentAccountId == subhead.AccountId))
                                    {
                                        foreach (var lowerhead in Accounts.Where(c => c.AccountLevel == 4 && c.ParentAccountId == subsubhead.AccountId))
                                        {
                                            foreach (var transactionable in Accounts.Where(c => c.AccountLevel == 5 && c.ParentAccountId == lowerhead.AccountId))
                                            {
                                                if (transactionable.IsTransactionable == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <option");
            BeginWriteAttribute("value", " value=\"", 2462, "\"", 2496, 1);
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 2470, transactionable.AccountId, 2470, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                                                                          Write(transactionable.AccountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                                                                                                        Write(transactionable.AccountNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</option>\n");
#nullable restore
#line 52 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                                }
                                            }
                                        }
                                    }
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\n                    </div>\n                </div>\n                <div class=\"col-sm-3\">\n                    <div class=\"form-group \">\n                        <label>");
#nullable restore
#line 63 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        <select name=\"Status\" id=\"Status\" class=\"form-control input-sm text-sm \">\n                            <option");
            BeginWriteAttribute("value", " value=\"", 3200, "\"", 3208, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\n");
#nullable restore
#line 66 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                             foreach (var item in ActiveStatus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3356, "\"", 3374, 1);
#nullable restore
#line 68 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 3364, item.Code, 3364, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 68 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                                                       Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 69 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Vendors\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div style=""display:none"">
                    <button type=""submit"" class=""btn btn-default btn-block"">Refresh</button>
                </div>
            </div>
        </form>
    </div>
    <div class=""card-body"">
        <div id=""divList""></div>

    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('#AccPli').addClass(""menu-open"");
            $('#AccRli').removeClass(""menu-open"");
            $('#Accli').removeClass(""menu-open"");
            $('#Setupli').removeClass(""menu-open"");

            $('#frmSearch button').click();
        });

        $('#frmSearch').find('input, select').change(() => {
            $('#frmSearch button').click();
        });

        $('#frmSearch').submit(function (e) {
            e.preventDefault();
            BindGrid();

        });


        function BindGrid() {

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: getApplicationName() + 'Finance/Vendors/_list',
                data: $('#frmSearch').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        }

        $('#printList').click(func");
                WriteLiteral(@"tion (e) {
            var AccountId = $('#AccountId').val();
            var Status = $('#Status').val();
            window.open(getApplicationName() + ""Finance/Vendors/PrintList?AccountId="" + AccountId + ""&Status="" + Status, ""_blank"");
        });
    </script>
");
            }
            );
            WriteLiteral("\n");
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
