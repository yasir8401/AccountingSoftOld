#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5677ef7c1d4b952e3058081259ead69cdc2c8120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpVehicles_view), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpVehicles/view.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5677ef7c1d4b952e3058081259ead69cdc2c8120", @"/Areas/ESS/Views/EmpVehicles/view.cshtml")]
    public class Areas_ESS_Views_EmpVehicles_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Emp> empList = Model.empList;
    var empId = Model.empId;
    Emp empDetails = Model.empDetails;

    EmpVehicles EmpVehiclesDetails = Model.EmpVehiclesDetails;
    bool isEdit = (EmpVehiclesDetails != null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 570, "\"", 607, 1);
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 578, isEdit ? "update" : "save", 578, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"EmpVehicleId\" name=\"EmpVehicleId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 696, "\"", 771, 1);
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 704, EmpVehiclesDetails != null ? EmpVehiclesDetails.EmpVehicleId : 0, 704, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                                                                                                                            Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" min=\"3\" maxlength=\"3\">\r\n    <input type=\"hidden\" id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 902, "\"", 974, 1);
#nullable restore
#line 21 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 910, EmpVehiclesDetails != null ? EmpVehiclesDetails.CompanyId : 0, 910, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"hidden\" id=\"BranchId\" name=\"BranchId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1053, "\"", 1124, 1);
#nullable restore
#line 22 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 1061, EmpVehiclesDetails != null ? EmpVehiclesDetails.BranchId : 0, 1061, 63, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 1493, "\"", 1523, 3);
            WriteAttributeValue("", 1503, "navigation(\'", 1503, 12, true);
#nullable restore
#line 30 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 1515, empId, 1515, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1521, "\')", 1521, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-info\"></i> ");
#nullable restore
#line 30 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("General Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n                ");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 37 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools\">\r\n               \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5677ef7c1d4b952e3058081259ead69cdc2c81209291", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i>");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                      Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2059, "~/ESS/EmpVehicles/emp/", 2059, 22, true);
#nullable restore
#line 42 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
AddHtmlAttributeValue("", 2081, empId, 2081, 6, false);

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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"EmpId\" name=\"EmpId\" class=\"form-control\" disabled>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                             foreach (var item in empList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2802, "\"", 2821, 1);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 2810, item.EmpId, 2810, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                        Write(EmpVehiclesDetails != null && EmpVehiclesDetails.EmpId == item.EmpId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                Write(item.FirstNameEn + " " + item.FatherNameEn + " " + item.GrandNameEn + " " + item.FamilyNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Plate No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"PlateNo\" name=\"PlateNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3488, "\"", 3556, 1);
#nullable restore
#line 68 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 3496, EmpVehiclesDetails!=null?EmpVehiclesDetails.PlateNo: null, 3496, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Asset No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"AssetNo\" name=\"AssetNo\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3890, "\"", 3958, 1);
#nullable restore
#line 74 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 3898, EmpVehiclesDetails!=null?EmpVehiclesDetails.AssetNo: null, 3898, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Issued Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"RegistrationIssueDate\" name=\"RegistrationIssueDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4334, "\"", 4514, 1);
#nullable restore
#line 80 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 4342, EmpVehiclesDetails != null && EmpVehiclesDetails.RegistrationIssueDate !=null ? Convert.ToDateTime(EmpVehiclesDetails.RegistrationIssueDate).ToString("dd-MMM-yyyy") : "", 4342, 172, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("End Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <input disabled type=\"text\" id=\"RegistrationEndDate\" name=\"RegistrationEndDate\" class=\"form-control DatePicker\"");
            BeginWriteAttribute("value", " value=\"", 4885, "\"", 5061, 1);
#nullable restore
#line 87 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 4893, EmpVehiclesDetails != null && EmpVehiclesDetails.RegistrationEndDate !=null ? Convert.ToDateTime(EmpVehiclesDetails.RegistrationEndDate).ToString("dd-MMM-yyyy") : "", 4893, 168, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                    </div>
                </div>

            </div>
        </div>

    </div>

    <div class=""card card-outline card-outline col-lg-12"">
        <div class=""card-header"">
            <h3 class=""card-title"">
                ");
#nullable restore
#line 100 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Note"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h3>

        </div>
        <!-- /.card-header -->
        <div class=""card-body pad"">
            <div class=""mb-3"">
                <textarea id=""Note"" class=""summersetclass"" rows=""8"" name=""Note"" disabled
                          style=""width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                                                                                                        Write(EmpVehiclesDetails != null? EmpVehiclesDetails.Note : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"card card-outline card-outline col-lg-12\">\r\n        <div class=\"card-header\">\r\n            <h3 class=\"card-title\">\r\n                ");
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Vehicle Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h3>

        </div>
        <!-- /.card-header -->
        <div class=""card-body pad"">
            <div class=""mb-3"">
                <textarea id=""VehicleDescription"" class=""summersetclass"" rows=""8"" required name=""VehicleDescription"" disabled
                          style=""width: 100%; height: 200px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;"">");
#nullable restore
#line 124 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                                                                                                        Write(EmpVehiclesDetails != null? EmpVehiclesDetails.VehicleDescription : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card card-default card-outline col-lg-12\" style=\"display:none\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 133 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Organization Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Company"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"CompanyId\" name=\"CompanyId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                             foreach (var item in companyList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7351, "\"", 7374, 1);
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 7359, item.CompanyId, 7359, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 146 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                            Write(EmpVehiclesDetails != null && EmpVehiclesDetails.CompanyId == item.CompanyId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 147 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                               Write(item.CoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 149 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6 \">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 155 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"BranchId\" name=\"BranchId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 158 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                             foreach (var item in branchList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 8086, "\"", 8108, 1);
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
WriteAttributeValue("", 8094, item.BranchId, 8094, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 160 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                                                           Write(EmpVehiclesDetails != null && EmpVehiclesDetails.BranchId == item.BranchId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 161 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                               Write(item.BranchNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {
            //$(""#tabVehicles-tab"").addClass(""nav-link active"");
            $(""#tabVehicles-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabVehicles-tab"").css(""color"", ""white"");


        });
        var applicationName = getApplicationName();


        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    $.ajax({
                        url: applicationName +""ESS/EmpVehicles/"" + actionType,
                        async: false,
                        type: ""POST"",
                        data: params,
                        success: function (data) {
                            if (data.result.isError !");
                WriteLiteral("= true) {\r\n                                showMsg(\'Saved !\', \'Record has been saved !\', \'success\');\r\n                                setTimeout(function () {\r\n                                    window.location = applicationName +\'ESS/EmpVehicles/emp/");
#nullable restore
#line 209 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpVehicles\view.cshtml"
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
            window.location = applicationName +'ESS/Profile/Index'
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
