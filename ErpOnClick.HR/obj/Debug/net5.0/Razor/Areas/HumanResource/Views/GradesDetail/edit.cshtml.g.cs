#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c44a396015cfee3bd578ce7543a564260eae9307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_GradesDetail_edit), @"mvc.1.0.view", @"/Areas/HumanResource/Views/GradesDetail/edit.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44a396015cfee3bd578ce7543a564260eae9307", @"/Areas/HumanResource/Views/GradesDetail/edit.cshtml")]
    public class Areas_HumanResource_Views_GradesDetail_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
  
    IList<Branch> branchList = Model.branchList;
    IList<Company> companyList = Model.companyList;
    IList<Grades1> GradesList = Model.gradeList;


    IList<Lookups> allowanceTypeList = Model.allowanceTypeList;
    var GradesId = Model.gradeID;
    Grades1 GradesDetails = Model.gradeDetails;

    GradesDetail GradesDetailDetails = Model.GradesDetailDetails;
    bool isEdit = (GradesDetailDetails != null);



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<form id=\"frmEdit\" role=\"form\" enctype=\"multipart/form-data\">\r\n    <input type=\"hidden\" id=\"ACTION_TYPE\" name=\"ACTION_TYPE\"");
            BeginWriteAttribute("value", " value=\"", 670, "\"", 707, 1);
#nullable restore
#line 24 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 678, isEdit ? "update" : "save", 678, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"GradeDetailId\" name=\"GradeDetailId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 798, "\"", 876, 1);
#nullable restore
#line 25 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 806, GradesDetailDetails != null ? GradesDetailDetails.GradeDetailId : 0, 806, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                                                                                                                                 Write(isEdit ? "readonly" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min=""3"" maxlength=""3"">

    <div class=""card card-default card-outline col-lg-8"">
        <div class=""card-header p-0 border-bottom-0"">
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link""");
            BeginWriteAttribute("onclick", " onclick=\"", 1208, "\"", 1296, 7);
            WriteAttributeValue("", 1218, "window.location", 1218, 15, true);
            WriteAttributeValue(" ", 1233, "=", 1234, 2, true);
            WriteAttributeValue(" ", 1235, "getApplicationName()", 1236, 21, true);
            WriteAttributeValue(" ", 1256, "+", 1257, 2, true);
            WriteAttributeValue(" ", 1258, "\'HumanResource/Grades/edit/", 1259, 28, true);
#nullable restore
#line 31 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 1286, GradesId, 1286, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1295, "\'", 1295, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\">");
#nullable restore
#line 31 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                                                                                                                      Write(SharedLocalizer.GetLocalizedHtmlString("Grades"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" id=\"tabGradeDetails-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1526, "\"", 1635, 7);
            WriteAttributeValue("", 1536, "window.location", 1536, 15, true);
            WriteAttributeValue(" ", 1551, "=", 1552, 2, true);
            WriteAttributeValue(" ", 1553, "getApplicationName()", 1554, 21, true);
            WriteAttributeValue(" ", 1574, "+", 1575, 2, true);
            WriteAttributeValue(" ", 1576, "\'HumanResource/GradesDetail/grade/", 1577, 35, true);
#nullable restore
#line 35 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 1611, GradesDetails.GradeId, 1611, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1633, ".\'", 1633, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\">");
#nullable restore
#line 35 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                                                                                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Grade Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 43 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c44a396015cfee3bd578ce7543a564260eae930710498", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 51 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2243, "~/HumanResource/GradesDetail/Grade/", 2243, 35, true);
#nullable restore
#line 50 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
AddHtmlAttributeValue("", 2278, GradesId, 2278, 9, false);

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
            WriteLiteral("\r\n            </div>\r\n            <!-- /. tools -->\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 61 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Allowance Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"AllowanceTypeId\" name=\"AllowanceTypeId\" class=\"form-control\">\r\n\r\n");
#nullable restore
#line 64 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                             foreach (var item in allowanceTypeList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3029, "\"", 3047, 1);
#nullable restore
#line 66 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 3037, item.Code, 3037, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                       Write(GradesDetailDetails != null && GradesDetailDetails.AllowanceTypeId == item.Code ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 67 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                               Write(item.LookupNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 69 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 75 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Range From"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                        <input type=\"number\" id=\"RangeFrom\" name=\"RangeFrom\" min=\"0\" max=\"100\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3666, "\"", 3738, 1);
#nullable restore
#line 77 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 3674, GradesDetailDetails!=null?GradesDetailDetails.RangeFrom: null, 3674, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 82 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Range To"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                        <input type=\"number\" id=\"RangeTo\" name=\"RangeTo\" min=\"0\" max=\"100\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4085, "\"", 4155, 1);
#nullable restore
#line 84 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 4093, GradesDetailDetails!=null?GradesDetailDetails.RangeTo: null, 4093, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\" hidden>\r\n                    <div class=\"form-group\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 4332, "\"", 4340, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <label class=\"col-md-12\">");
#nullable restore
#line 90 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                Write(SharedLocalizer.GetLocalizedHtmlString("IsEnable"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <select id=\"IsEnable\" name=\"IsEnable\" class=\"form-control\" required>\r\n\r\n                                <option value=\"True\" ");
#nullable restore
#line 93 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                 Write(GradesDetailDetails != null && GradesDetailDetails.IsEnable != null ? (Convert.ToBoolean(GradesDetailDetails.IsEnable) ? "selected" : "") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Enable</option>\r\n                                <option value=\"False\" ");
#nullable restore
#line 94 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                  Write(GradesDetailDetails != null && GradesDetailDetails.IsEnable != null ? (Convert.ToBoolean(GradesDetailDetails.IsEnable) ? "" : "selected") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">Not</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 "" hidden>
                    <div class=""form-group"">
                        <label>");
#nullable restore
#line 101 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Grade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        <select id=\"GradeId\" name=\"GradeId\" class=\"form-control\">\r\n");
#nullable restore
#line 103 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                             foreach (var item in GradesList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 5510, "\"", 5531, 1);
#nullable restore
#line 105 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
WriteAttributeValue("", 5518, item.GradeId, 5518, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 105 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                          Write(GradesDetailDetails != null && GradesDetailDetails.GradeId == item.GradeId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 106 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                               Write(item.GradeNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </option>\r\n");
#nullable restore
#line 108 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            WriteLiteral("</form>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(function () {

            $(""#tabGradeDetails-tab"").addClass(""nav-link active"");


        });

        var applicationName = getApplicationName();

        $('#frmEdit').on('submit', function (e) {
            e.preventDefault();
            var actionType = $('#ACTION_TYPE').val();

            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {

                    var params = $('#frmEdit').serialize();
                    var formEl = document.forms.frmEdit;
                    var formData = new FormData(formEl);


                    $.ajax({
                        url: applicationName +""HumanResource/GradesDetail/"" + actionType,
                        type: ""POST"",
                        data: formData ? formData : params,
                        async: false,
                        cache: false,
                        contentType: f");
                WriteLiteral(@"alse,
                        processData: false,
                        success: function (data) {
                            if (data.result.isError != true) {
                                showMsg('Saved !', 'Record has been saved !', 'success');
                                setTimeout(function () {
                                    window.location = applicationName + 'HumanResource/GradesDetail/grade/");
#nullable restore
#line 201 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\GradesDetail\edit.cshtml"
                                                                                                     Write(GradesId);

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
