#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a0d47e7f9f28b80f24c0c1bef3a7b7f853f57e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpAchievement_edit), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpAchievement/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a0d47e7f9f28b80f24c0c1bef3a7b7f853f57e", @"/Areas/ESS/Views/EmpAchievement/edit.cshtml")]
    public class Areas_ESS_Views_EmpAchievement_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;

    var empId = Model.empId;


    Emp empDetails = Model.empDetails;
    Achievement EmpAchievementDetails = Model.EmpAchievementDetails;
    bool isEdit = (EmpAchievementDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 617, "\"", 654, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 625, isEdit ? "update" : "save", 625, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"AchievementId\" name=\"AchievementId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 745, "\"", 827, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 753, EmpAchievementDetails != null ? EmpAchievementDetails.AchievementId : 0, 753, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                                                                                                     Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 958, "\"", 1036, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 966, EmpAchievementDetails != null ? EmpAchievementDetails.CompanyId : 0, 966, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1115, "\"", 1192, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 1123, EmpAchievementDetails != null ? EmpAchievementDetails.BranchId : 0, 1123, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

    <div class=""card card-default card-outline col-lg-12"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link""");
            BeginWriteAttribute("onclick", " onclick=\"", 1561, "\"", 1591, 3);
            WriteAttributeValue("", 1571, "navigation(\'", 1571, 12, true);
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 1583, empId, 1583, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1589, "\')", 1589, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-info\"></i> ");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("General Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n\r\n                ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Employee Achievement Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n");
            WriteLiteral("<div class=\"card-tools\">\r\n    <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n        <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a0d47e7f9f28b80f24c0c1bef3a7b7f853f57e10394", async() => {
                WriteLiteral("\r\n        <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 51 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                           Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2264, "~/ESS/EmpAchievement/emp/", 2264, 25, true);
#nullable restore
#line 50 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
AddHtmlAttributeValue("", 2289, empId, 2289, 6, false);

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
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("</div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-4 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\">\r\n");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2940, "\"", 2959, 1);
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 2948, item.EmpId, 2948, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>\r\n                                    ");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Acheivement/Training Course Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"AwardName\" name=\"AwardName\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3565, "\"", 3641, 1);
#nullable restore
#line 75 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 3573, EmpAchievementDetails!=null?EmpAchievementDetails.AwardName: null, 3573, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Donor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Donor\" name=\"Donor\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3959, "\"", 4031, 1);
#nullable restore
#line 81 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 3967, EmpAchievementDetails!=null?EmpAchievementDetails.Donor: null, 3967, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Year"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select name=\"Year\" id=\"Year\" class=\"form-control\" required>\r\n                            <option></option>\r\n");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                             for (int i = DateTime.Now.Year; i > 1970; i--)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 4550, "\"", 4560, 1);
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 4558, i, 4558, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                               Write(EmpAchievementDetails != null && EmpAchievementDetails.Year == i.ToString() ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Awarded Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"AchievementDate\" name=\"AchievementDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 5090, "\"", 5267, 1);
#nullable restore
#line 99 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 5098, EmpAchievementDetails != null && EmpAchievementDetails.AchievementDate !=null ? Convert.ToDateTime(EmpAchievementDetails.AchievementDate).ToString("dd-MMM-yyyy") : "", 5098, 169, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 104 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Attachment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 105 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                         if (EmpAchievementDetails != null && EmpAchievementDetails.Attachments != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a0d47e7f9f28b80f24c0c1bef3a7b7f853f57e21402", async() => {
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                        Write(SharedLocalizer.GetLocalizedHtmlString("DownloadPDF"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5673, "~/Files/", 5673, 8, true);
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
AddHtmlAttributeValue("", 5681, EmpAchievementDetails.Attachments, 5681, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <input type=\"text\" hidden");
            BeginWriteAttribute("value", " value=\"", 5842, "\"", 5918, 1);
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 5850, EmpAchievementDetails!=null?EmpAchievementDetails.Attachments: "", 5850, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Attachments\" name=\"Attachments\" class=\"form-control\">\r\n");
#nullable restore
#line 109 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"file\" id=\"AttachmentFile\" name=\"AttachmentFile\" class=\"form-control\">\r\n");
#nullable restore
#line 113 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    <hr>\r\n                </div>\r\n                <div class=\"col-md-12 card-header\">\r\n                    <label>");
#nullable restore
#line 121 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                      Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <textarea required id=\"Detail\" rows=\"4\" name=\"Detail\"\r\n                              style=\"width: 100%; height: 80px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;\">");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                                                                           Write(EmpAchievementDetails != null? EmpAchievementDetails.Detail : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                </div>
            </div>
        </div>

    </div>

    <div class=""card card-default card-outline col-lg-12"" style=""display:none"">

        <div class=""card-header"">
            <h2 class=""card-title"">
                ");
#nullable restore
#line 134 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 142 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 145 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7644, "\"", 7667, 1);
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 7652, item.CompanyId, 7652, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                            Write(EmpAchievementDetails != null && EmpAchievementDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 148 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 150 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 156 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 8515, "\"", 8537, 1);
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
WriteAttributeValue("", 8523, item.BranchId, 8523, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                               Write(EmpAchievementDetails != null && EmpAchievementDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 164 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 166 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        var applicationName = getApplicationName();

        $(function () {
            $(""#tabEmpAchievements-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabEmpAchievements-tab"").css(""color"", ""white"");
            //$(""#tabDependents-tab"").addClass(""nav-link active"");
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
                });");
                WriteLiteral(@"

            });


        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);

                    $.ajax({
                        url: applicationName +""ESS/EmpAchievement/"" + actionType,
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.result.isError !");
                WriteLiteral(@"= true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName + 'ESS/EmpAchievement/emp/");
#nullable restore
#line 243 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                                                           Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                                }, 500);
                            }
                            else if (data.result.msg != '') {
                                showMsg('Save Failed !', data.result.msg, 'error');
                            }
                            else {
                                showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                            }
                        }
                    });
                }
            });




        });
        function navigation() {
            window.location = applicationName +'ESS/emp/edit/");
#nullable restore
#line 262 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAchievement\edit.cshtml"
                                                        Write(empId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        };\r\n\r\n    </script>\r\n\r\n");
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
