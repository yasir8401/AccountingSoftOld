#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006c25e42557f44d4259b7615435a4e986007af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_Emp__generalInfoPartial), @"mvc.1.0.view", @"/Areas/HumanResource/Views/Emp/_generalInfoPartial.cshtml")]
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
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006c25e42557f44d4259b7615435a4e986007af8", @"/Areas/HumanResource/Views/Emp/_generalInfoPartial.cshtml")]
    public class Areas_HumanResource_Views_Emp__generalInfoPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Emp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/HumanResource/emp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 9 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
  

    var filePath = NativePaths.GetFilePath(_env);

    Emp empDetails = @Model;
    bool isEdit = (empDetails != null);
    var envName = hostingEnv.EnvironmentName;
    string path = "";
    if (envName == "Production")
    {
        path = @Url.Content(@"C:\inetpub\wwwroot\ErpOnClick\Files");

    }
    else if (envName == "Development")
    {
        path = @Url.Content(@"C:/Hamza Nayel/NayelSourceCodes/ErpOnClick/Files");
        //path = @"C:\Hamza Nayel\NayelSourceCodes\ErpOnClick\Files";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <div class=\"card card-default card-outline col-lg-12\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title mt-1\">\r\n                ");
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Personal Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n            <div class=\"card-tools pr-0\">\r\n                <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n                    <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 43 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "006c25e42557f44d4259b7615435a4e986007af86647", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 46 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
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
            WriteLiteral(@"
            </div>
            <!-- /. tools -->
        </div>
        <div class=""card-body"">
            <div class=""row"">

                <div class=""col-lg-3 padding-left-0 pl-0 text-left"" style=""background-repeat:no-repeat;background-size: 200px 200px;background-image:url('/adminlte/dist/img/noimage.jpg');text-align: center"" onclick=""uploadimg()"">
");
#nullable restore
#line 55 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                     if (empDetails != null && empDetails.ProfilePic != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img style=\"width:200px;height:200px\" id=\"profilePic\"");
            BeginWriteAttribute("class", " class=\"", 2674, "\"", 2682, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2683, "\"", 2720, 2);
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 2689, filePath, 2689, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 2698, empDetails.ProfilePic, 2698, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"text\" hidden id=\"ProfilePic\" name=\"ProfilePic\"");
            BeginWriteAttribute("value", " value=\"", 2809, "\"", 2864, 1);
#nullable restore
#line 58 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 2817, empDetails!=null?empDetails.ProfilePic: null, 2817, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img style=\"width: 200px; height: 200px\" id=\"profilePic\"");
            BeginWriteAttribute("class", " class=\"", 3020, "\"", 3028, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"/Erp/adminlte/dist/img/noimage.jpg\" />\r\n");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <input type=\"file\" hidden id=\"ProfilePicFile\" name=\"ProfilePicFile\"");
            BeginWriteAttribute("class", " class=\"", 3207, "\"", 3215, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div class=\"col-lg-9\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <input type=\"text\" id=\"FirstNameEn\" required name=\"FirstNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3620, "\"", 3676, 1);
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 3628, empDetails!=null?empDetails.FirstNameEn: null, 3628, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Fathers Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                                <input type=\"text\" id=\"FatherNameEn\" name=\"FatherNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4064, "\"", 4121, 1);
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 4072, empDetails!=null?empDetails.FatherNameEn: null, 4072, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Grand Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </label>\r\n                                <input type=\"text\" id=\"GrandNameEn\" name=\"GrandNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4508, "\"", 4564, 1);
#nullable restore
#line 86 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 4516, empDetails!=null?empDetails.GrandNameEn: null, 4516, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Family Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                                <input type=\"text\" id=\"FamilyNameEn\" name=\"FamilyNameEn\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4951, "\"", 5008, 1);
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 4959, empDetails!=null?empDetails.FamilyNameEn: null, 4959, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("First Name  (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                                <input type=\"text\" id=\"FirstNameAr\" name=\"FirstNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5402, "\"", 5458, 1);
#nullable restore
#line 98 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 5410, empDetails!=null?empDetails.FirstNameAr: null, 5410, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 103 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Father Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <input type=\"text\" id=\"FatherNameAr\" name=\"FatherNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5853, "\"", 5910, 1);
#nullable restore
#line 104 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 5861, empDetails!=null?empDetails.FatherNameAr: null, 5861, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 109 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Grand Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <input type=\"text\" id=\"GrandNameAr\" name=\"GrandNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6302, "\"", 6358, 1);
#nullable restore
#line 110 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 6310, empDetails!=null?empDetails.GrandNameAr: null, 6310, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-3\">\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 115 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
                                  Write(SharedLocalizer.GetLocalizedHtmlString("Family Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                <input type=\"text\" id=\"FamilyNameAr\" name=\"FamilyNameAr\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6753, "\"", 6810, 1);
#nullable restore
#line 116 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_generalInfoPartial.cshtml"
WriteAttributeValue("", 6761, empDetails!=null?empDetails.FamilyNameAr: null, 6761, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment _env { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emp> Html { get; private set; }
    }
}
#pragma warning restore 1591
