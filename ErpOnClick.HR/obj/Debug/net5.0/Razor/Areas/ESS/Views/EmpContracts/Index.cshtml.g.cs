#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dbadbce6fa8d4c1ff4e51267eab7f9f753ae375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpContracts_Index), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpContracts/Index.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dbadbce6fa8d4c1ff4e51267eab7f9f753ae375", @"/Areas/ESS/Views/EmpContracts/Index.cshtml")]
    public class Areas_ESS_Views_EmpContracts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
  

    var empId = Model.empId;
    Emp empDetails = Model.empDetails;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<form id=\"frmList\">\r\n    <input type=\"hidden\" id=\"EmpId\" name=\"EmpId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 327, "\"", 341, 1);
#nullable restore
#line 18 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
WriteAttributeValue("", 335, empId, 335, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""card card-default card-outline"">
        <div class=""card-header p-0 border-bottom-0"">
            <div class=""card"" style=""background-color: #496b6a"">
            </div>
            <ul class=""nav nav-tabs"" id=""custom-content-below-tab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link"" onclick=""navigation()"" href=""javascript:void(0)""><i class=""fa fa-info""></i> ");
#nullable restore
#line 26 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
                                                                                                               Write(SharedLocalizer.GetLocalizedHtmlString("General Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n                ");
#nullable restore
#line 28 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
           Write(Html.Partial("/Areas/ESS/Views/Profile/_tabsPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n\r\n\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">\r\n                ");
#nullable restore
#line 35 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpContracts\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Employee Contracts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <!-- tools box -->\r\n");
            WriteLiteral("            <!-- /. tools -->\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card-body\">\r\n            <div id=\"divList\"></div>\r\n\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            //$(""#tabEmpContract-tab"").addClass(""nav-link active"");
            $(""#tabEmpContract-tab"").css(""background-color"", ""#496b6a"");
            $(""#tabEmpContract-tab"").css(""color"", ""white"");
            BindGrid();
        });
        var applicationName = getApplicationName();


        function BindGrid() {

            var test = $('#frmSearch').serialize();

            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName +'ESS/EmpContracts/_list',
                data: $('#frmList').serialize(),
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };
        function navigation() {
            window.location = applicationName + 'ESS/Profile/Index';
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
