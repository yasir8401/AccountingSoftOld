#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "870c1ba1c6707f99f3fc1a731e7d9803d31ce6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_EmpLeavesReport__list), @"mvc.1.0.view", @"/Areas/HumanResource/Views/EmpLeavesReport/_list.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
using ErpOnClick.ErpMain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870c1ba1c6707f99f3fc1a731e7d9803d31ce6c0", @"/Areas/HumanResource/Views/EmpLeavesReport/_list.cshtml")]
    public class Areas_HumanResource_Views_EmpLeavesReport__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Report.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
  
    List<Leaves> leaveList = Model.leaveList;


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "870c1ba1c6707f99f3fc1a731e7d9803d31ce6c04429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"table-responsive pb-2 \">\r\n    <table id=\"dtList\" class=\"table table-hover table-condensed \">\r\n        <thead class=\"text-sm\">\r\n            <tr class=\"col-lg-12\">\r\n                <th width=\"10px\"> ");
#nullable restore
#line 15 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th align=\"left\"> ");
#nullable restore
#line 16 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th> ");
#nullable restore
#line 18 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("From"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 19 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("To"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 20 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 21 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr>
                <th width=""10px""> Id</th>
                <th align=""left""> Employee</th>

                <th> From</th>
                <th> To</th>
                <th>Type</th>
                <th>Status</th>
            </tr>
        </tfoot>
        <tbody>

");
#nullable restore
#line 37 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
             foreach (var item in leaveList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\" text-center\">\r\n                    <td>");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                   Write(item.LeaveId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"left\"> ");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                                  Write(item.Emp !=null ? item.Emp.FirstNameEn + " " + item.Emp.FatherNameEn + " " + item.Emp.GrandNameEn + " " + item.Emp.FamilyNameEn :"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                    Write(item.DateFrom != null ? Convert.ToDateTime(item.DateFrom).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                    Write(item.DateTo != null ? Convert.ToDateTime(item.DateTo).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                    Write(item.LeaveType !=null ? item.LeaveType.LookupNameEn :"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"right\">\r\n");
#nullable restore
#line 46 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                         if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Rejected")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth badge badge-danger\">Rejected</label>\r\n");
#nullable restore
#line 49 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"

                        }
                        else if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Approved")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth badge badge-success\">Approved</label>\r\n");
#nullable restore
#line 54 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                        }
                        else if (item.LeaveStatusNavigation != null && item.LeaveStatusNavigation.LookupNameEn == "Pending")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"btnwidth badge badge-warning\">Pending</label>\r\n");
#nullable restore
#line 58 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
                        }
                        else
                        {

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\EmpLeavesReport\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<script>\r\n    $(function () {\r\n        _initDatatable(\'#dtList\');\r\n    });\r\n</script>");
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