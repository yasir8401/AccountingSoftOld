#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\Profile\_empDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fccc72627f5579b5d46c1085535b2279eaf2144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_Profile__empDetailPartial), @"mvc.1.0.view", @"/Areas/ESS/Views/Profile/_empDetailPartial.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\Profile\_empDetailPartial.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\Profile\_empDetailPartial.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fccc72627f5579b5d46c1085535b2279eaf2144", @"/Areas/ESS/Views/Profile/_empDetailPartial.cshtml")]
    public class Areas_ESS_Views_Profile__empDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card card-default card-outline col-lg-10\" id=\"searchEmp\">\r\n\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title col-md-3\">\r\n            ");
#nullable restore
#line 8 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\Profile\_empDetailPartial.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Emp Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </h2>
        <div class=""col-md-6"">
            <div class=""row"">
                <input type=""text"" id=""empCode"" name=""empCode"" placeholder=""Emp Code"" class=""form-control col-md-6"" />
                <button id=""btnEmpSearch"" style=""margin-left:10px"" type=""button"" class=""btn  btn-sm btn-primary col-sm-5"">
                    <i class=""fas fa-search fa-fw""></i> ");
#nullable restore
#line 14 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\Profile\_empDetailPartial.cshtml"
                                                   Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <div class=\'card-body\' id=\"searchEmpCardBody\" style=\"display:none\">\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
