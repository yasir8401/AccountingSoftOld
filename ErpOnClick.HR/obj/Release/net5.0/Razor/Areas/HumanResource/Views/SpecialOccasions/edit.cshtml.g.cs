#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265d2d6db2fb97a6d3b33dac9917104c619a7251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_SpecialOccasions_edit), @"mvc.1.0.view", @"/Areas/HumanResource/Views/SpecialOccasions/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265d2d6db2fb97a6d3b33dac9917104c619a7251", @"/Areas/HumanResource/Views/SpecialOccasions/edit.cshtml")]
    public class Areas_HumanResource_Views_SpecialOccasions_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/HumanResource/SpecialOccasions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
  



    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;


    IList<OvertimeSettings> overtimeSettingList = Model.overtimeSettingList;

    SpecialOccasions SpecialOccasionDetails = Model.SpecialOccasionDetails;
    bool isEdit = (SpecialOccasionDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 534, "\"", 571, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 542, isEdit ? "update" : "save", 542, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SpecialOccasionId\" name=\"SpecialOccasionId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 670, "\"", 758, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 678, SpecialOccasionDetails != null ? SpecialOccasionDetails.SpecialOccasionId : 0, 678, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                                                                                                                                                   Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 889, "\"", 969, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 897, SpecialOccasionDetails != null ? SpecialOccasionDetails.CompanyId : 0, 897, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1049, "\"", 1128, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 1057, SpecialOccasionDetails != null ? SpecialOccasionDetails.BranchId : 0, 1057, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265d2d6db2fb97a6d3b33dac9917104c619a72518670", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 49 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"SpecialOccasionNameEn\" name=\"SpecialOccasionNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2293, "\"", 2383, 1);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 2301, SpecialOccasionDetails!=null?SpecialOccasionDetails.SpecialOccasionNameEn: null, 2301, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Name Arabic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"SpecialOccasionNameAr\" name=\"SpecialOccasionNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2748, "\"", 2838, 1);
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 2756, SpecialOccasionDetails!=null?SpecialOccasionDetails.SpecialOccasionNameAr: null, 2756, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Code"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"SpecialOccasionCode\" name=\"SpecialOccasionCode\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3192, "\"", 3280, 1);
#nullable restore
#line 62 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 3200, SpecialOccasionDetails!=null?SpecialOccasionDetails.SpecialOccasionCode: null, 3200, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Total Days"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" id=\"TotalDays\" name=\"TotalDays\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3622, "\"", 3700, 1);
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 3630, SpecialOccasionDetails!=null?SpecialOccasionDetails.TotalDays: null, 3630, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("From Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"FromDate\" name=\"FromDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4048, "\"", 4214, 1);
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 4056, SpecialOccasionDetails != null && SpecialOccasionDetails.FromDate !=null ? Convert.ToDateTime(SpecialOccasionDetails.FromDate).ToString("dd-MMM-yyyy") : "", 4056, 158, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("To Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"ToDate\" name=\"ToDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4547, "\"", 4709, 1);
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 4555, SpecialOccasionDetails != null && SpecialOccasionDetails.ToDate !=null ? Convert.ToDateTime(SpecialOccasionDetails.ToDate).ToString("dd-MMM-yyyy") : "", 4555, 154, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Overtime Setting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"OvertimeSettingId\" name=\"OvertimeSettingId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                             foreach (var item in overtimeSettingList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5201, "\"", 5232, 1);
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 5209, item.OvertimeSettingId, 5209, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                                    Write(SpecialOccasionDetails != null && SpecialOccasionDetails.OvertimeSettingId == item.OvertimeSettingId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                               Write(item.OvertimeSettingNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 94 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class=""card card-default card-outline col-lg-8"" style=""display:none"">
        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 105 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n\r\n\r\n\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 6420, "\"", 6443, 1);
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 6428, item.CompanyId, 6428, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                            Write(SpecialOccasionDetails != null && SpecialOccasionDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 122 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 133 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 7293, "\"", 7315, 1);
#nullable restore
#line 137 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
WriteAttributeValue("", 7301, item.BranchId, 7301, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 137 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                                               Write(SpecialOccasionDetails != null && SpecialOccasionDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 140 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SpecialOccasions\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {

        });
        var applicationName = getApplicationName();

        $('#CompanyId').change(function () {

            var id = $('#CompanyId').val();

            $.ajax({
                url: applicationName + ""Ajax/BranchCascading"",
                async: false,
                type: ""POST"",
                data: { id: id },
                success: function (data) {

                    var item = '';

                    $.each(data.result, function (i, product) {

                        item += ""<option value='"" + product.branchId + ""'>"" + product.branchNameEn + ""</option>"";
                    });

                    $(""#BranchId"").html(item);

                }
            });

        });
        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes',");
                WriteLiteral(@" 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName + ""HumanResource/SpecialOccasions/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName + 'HumanResource/SpecialOccasions';
                                }, 500);
                            }
                            else if (data.result.msg != '') {
                                showMsg('Save Failed !', data.result.msg, 'error');
                            }
                ");
                WriteLiteral(@"            else {
                                showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                            }
                        }
                    });
                }
            });




        });

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
