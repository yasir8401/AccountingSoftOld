#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85179916038a6a56beb4c2c85ea38a7aeb22e651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_ExpClaimsRequest_edit), @"mvc.1.0.view", @"/Areas/ESS/Views/ExpClaimsRequest/edit.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
using ErpOnClick.ErpMain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85179916038a6a56beb4c2c85ea38a7aeb22e651", @"/Areas/ESS/Views/ExpClaimsRequest/edit.cshtml")]
    public class Areas_ESS_Views_ExpClaimsRequest_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ESS/ExpClaimsRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> employeesList = Model.employeesList;

    List<Lookups> RequestStatus = Model.RequestStatus;
    List<Lookups> RequestType = Model.RequestType;


    ExpClaims ExpClaim = Model.ExpClaimDetails;
    bool isEdit = (ExpClaim != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 635, "\"", 672, 1);
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 643, isEdit ? "update" : "save", 643, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"RecId\" name=\"RecId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 747, "\"", 795, 1);
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 755, ExpClaim != null ? ExpClaim.RecId : 0, 755, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                                                   Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 926, "\"", 978, 1);
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 934, ExpClaim != null ? ExpClaim.CompanyId : 0, 934, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1057, "\"", 1108, 1);
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 1065, ExpClaim != null ? ExpClaim.BranchId : 0, 1065, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 31 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Expense Claim Request Detail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\" ");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                  Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "hidden" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save Expense Claim Request"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <a id=\"postBtn\" ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                            Write(!isEdit ? "hidden" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn  btn-sm btn-success\" ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                        Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "hidden" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Submit For Approval"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85179916038a6a56beb4c2c85ea38a7aeb22e65110566", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
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
#line 52 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" required ");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                  Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "disabled" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                            <option selected></option>\r\n");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                             foreach (var item in employeesList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2914, "\"", 2933, 1);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 2922, item.EmpId, 2922, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\" ");
#nullable restore
#line 65 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                        Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "" : "hidden");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                        <label>");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Request Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"RequestStatus\" name=\"RequestStatus\" class=\"form-control\" required disabled>\r\n                            <option selected></option>\r\n");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                             foreach (var item in RequestStatus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3749, "\"", 3767, 1);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 3757, item.Code, 3757, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                       Write(ExpClaim != null && ExpClaim.RequestStatus == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" ");
#nullable restore
#line 81 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                       Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "disabled" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" id=\"SpentAt\" name=\"SpentAt\" class=\"form-control\" value=\"");
#nullable restore
#line 81 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                                                                                                       Write(ExpClaim!=null?ExpClaim.SpentAt: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Spent Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"text\" ");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                       Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "disabled" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" id=\"SpentOn\" name=\"SpentOn\" class=\"form-control DatePicker\" value=\"");
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                                                                                                                  Write(ExpClaim!=null?ExpClaim.SpentOn: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input type=\"number\" ");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                         Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "disabled" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"0\" id=\"Amount\" name=\"Amount\" class=\"form-control\" value=\"");
#nullable restore
#line 93 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                                                                                                               Write(ExpClaim!=null?ExpClaim.Amount: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Attachment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 99 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                         if (ExpClaim != null && ExpClaim.Attachment != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85179916038a6a56beb4c2c85ea38a7aeb22e65122827", async() => {
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("DownloadPDF"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5741, "~/Files/", 5741, 8, true);
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
AddHtmlAttributeValue("", 5749, ExpClaim.Attachment, 5749, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <input type=\"text\" id=\"Attachment\" name=\"Attachment\"");
            BeginWriteAttribute("value", " value=\"", 5923, "\"", 5951, 1);
#nullable restore
#line 102 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 5931, ExpClaim.Attachment, 5931, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n");
#nullable restore
#line 103 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"file\" id=\"FileToUpload\" name=\"FileToUpload\" class=\"form-control\">\r\n");
#nullable restore
#line 107 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 119 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body p-2\">\r\n            <textarea rows=\"3\" ");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                           Write(ExpClaim != null && ExpClaim.RequestStatus != null ? "disabled" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" id=\"Reason\" name=\"Reason\" class=\"form-control \"  placeholder=\"Enter Reason here...\">");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                                                                                                                                                       Write(ExpClaim != null ? ExpClaim.Reason : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-default card-outline col-lg-8\" style=\"display:none\">\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 130 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7628, "\"", 7651, 1);
#nullable restore
#line 143 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 7636, item.CompanyId, 7636, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 143 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                            Write(ExpClaim != null && ExpClaim.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 152 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n                            <option></option>\r\n");
#nullable restore
#line 155 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                             if (isEdit)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                 foreach (var item in branchList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 8473, "\"", 8495, 1);
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
WriteAttributeValue("", 8481, item.BranchId, 8481, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                                               Write(ExpClaim != null && ExpClaim.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                   Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\ExpClaimsRequest\edit.cshtml"
                                 
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


        });


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('C");
                WriteLiteral(@"onfirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);

                    $.ajax({
                        url: applicationName + ""ESS/ExpClaimsRequest/"" + actionType,
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.locat");
                WriteLiteral(@"ion = applicationName + 'ESS/ExpClaimsRequest';
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

        $('#postBtn').click(function () {


            confirmAction('Confirm ?', 'Are you sure you want to Post  ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {
                    var id = $('#RecId').val();

                    $.ajax({
                        url: applicationName + ""ESS/ExpClaimsRequest/Post"",
                        async: false,
                        type: """);
                WriteLiteral(@"POST"",
                        data: { id: id },
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been Posted !', 'success');
                                setTimeout(function () {
                                    debugger;
                                    var id = data.result.scalerVal;
                                    window.location = applicationName + 'ESS/ExpClaimsRequest/Edit?id=' + id;
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

    ");
                WriteLiteral("            }\r\n            });\r\n\r\n\r\n\r\n\r\n        });\r\n\r\n    </script>\r\n\r\n");
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
