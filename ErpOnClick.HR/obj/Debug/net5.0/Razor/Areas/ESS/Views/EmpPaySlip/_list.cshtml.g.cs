#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfdcc69af2e5c35a6bd2e17f1c1d2fc1b310f877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpPaySlip__list), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpPaySlip/_list.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
using ErpOnClick.ErpMain.Areas.ESS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfdcc69af2e5c35a6bd2e17f1c1d2fc1b310f877", @"/Areas/ESS/Views/EmpPaySlip/_list.cshtml")]
    public class Areas_ESS_Views_EmpPaySlip__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
  

    var PaySlipDate = Model.PaySlipDate;
    List<PayrunPayslip> PaySlipDetails = Model.PaySlipDetails;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    thead th {
        text-align: center !important;
        font-size: 12px !important;
        vertical-align: bottom;
        white-space: nowrap;
        background-color: #efefef;
        color: #45547d;
        padding: 10px 0px;
    }

    tbody td {
        padding: 0px;
    }

        tbody td .form-control {
            padding: 1px;
            border: 0px !important;
            margin: 0px;
            font-size: 13px;
            text-align: center;
            background-color: transparent;
        }
</style>
<div class=""table-responsive pb-2 "">
    <table id=""dtList"" class=""table table-hover table-condensed"" style=""display:none;width:100%"">
        <thead class=""text-sm"">
            <tr>
                <th width=""150px"">");
#nullable restore
#line 44 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("Allowance Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th hidden></th>\r\n                <th>");
#nullable restore
#line 46 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Allowance Discription"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 47 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Earning"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 48 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Deduction"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 53 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
             foreach (var item in PaySlipDetails.OrderBy(x => x.EmpPayrunId))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n");
            WriteLiteral("                    <td><input disabled type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1835, "\"", 1902, 1);
#nullable restore
#line 58 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
WriteAttributeValue("", 1843, item.AllowanceTypeId!=null ? item.AllowanceTypeId : null, 1843, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AllowanceTypeId\" id=\"AllowanceTypeId\" class=\"form-control\" /></td>\r\n                    <td hidden><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2027, "\"", 2127, 1);
#nullable restore
#line 59 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
WriteAttributeValue("", 2035, item.CreatedDate!=null ?Convert.ToDateTime(item.CreatedDate).ToString("dd-MMM-yyyy") : "", 2035, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CreatedDate\" id=\"CreatedDate\" class=\"form-control DatePicker\" /></td>\r\n                    <td>  <input disabled type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2259, "\"", 2318, 1);
#nullable restore
#line 60 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
WriteAttributeValue("", 2267, item.Description!=null ? item.Description : null, 2267, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Description\" id=\"Description\" class=\"form-control\" /></td>\r\n                    <td>  <input disabled type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2441, "\"", 2516, 1);
#nullable restore
#line 61 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
WriteAttributeValue("", 2449, item.Earning!=null ? Math.Round((decimal)item.Earning, 2) : null, 2449, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Earning\" id=\"Earning\" class=\"form-control\" /></td>\r\n                    <td>  <input disabled type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2631, "\"", 2710, 1);
#nullable restore
#line 62 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
WriteAttributeValue("", 2639, item.Deduction!=null ? Math.Round((decimal)item.Deduction, 2) : null, 2639, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Deduction\" id=\"Deduction\" class=\"form-control\" /></td>\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot style=\"display: table-row-group; background-color: #efefef;\">\r\n            <tr class=\"text-center\">\r\n                <th colspan=\"2\" style=\"text-align:center\">Total:  </th>\r\n                <th>");
#nullable restore
#line 69 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
               Write(Math.Round((decimal)PaySlipDetails.Sum(x => x.Earning), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 70 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
               Write(Math.Round((decimal)PaySlipDetails.Sum(x => x.Deduction), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
        </tfoot>
        <tfoot style=""display: table-row-group; background-color: #efefef;"">
            <tr class=""text-center"">
                <th colspan=""2"" style=""text-align:center"">Total Salary:  </th>
                <th colspan=""2"" style=""text-align:center"">");
#nullable restore
#line 76 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpPaySlip\_list.cshtml"
                                                     Write(Math.Round((decimal)(PaySlipDetails.Sum(x => x.Earning) - PaySlipDetails.Sum(x => x.Deduction)), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>
                
            </tr>
        </tfoot>
    </table>
</div>



<script>
    $(function () {
        _initDatatableWithFooter('#dtList');
        //initDatePicker();

        $('#dtList').show();


    });
    var applicationName = getApplicationName();

</script>
");
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
