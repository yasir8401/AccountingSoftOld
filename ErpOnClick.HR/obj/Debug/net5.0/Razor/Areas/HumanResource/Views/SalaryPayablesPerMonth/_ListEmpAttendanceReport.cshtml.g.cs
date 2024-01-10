#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b28afe598e42b3e5db5a54a82270b22af283a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_SalaryPayablesPerMonth__ListEmpAttendanceReport), @"mvc.1.0.view", @"/Areas/HumanResource/Views/SalaryPayablesPerMonth/_ListEmpAttendanceReport.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
using ErpOnClick.ErpMain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
using ErpOnClick.ErpMain.ViewModel.HumanResource;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b28afe598e42b3e5db5a54a82270b22af283a9", @"/Areas/HumanResource/Views/SalaryPayablesPerMonth/_ListEmpAttendanceReport.cshtml")]
    public class Areas_HumanResource_Views_SalaryPayablesPerMonth__ListEmpAttendanceReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
   
    DateTime date = Model.date;
    List<EmpAttendanceReportViewModel> empAttendanceReportViewModel = Model.empAttendanceReportViewModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div >
    <table id=""dtList""  class=""table table-hover table-condensed"">
        <thead class=""text-sm"">
            <tr>
                <th>Sr.No</th>
                <th>Emp Id</th>
                <th>Name</th>
                <th>CNIC</th>
                <th>NTN</th>
                <th>DOB</th>
                <th>Joining Date</th>
                <th>Leaving Date</th>
                <th>Joiner/Leaver</th>
                <th>office Location</th>
                <th>Department</th>
                <th>Shift</th>
                <th>Designation</th>
                <th>Emp Type</th>
                <th>Wage Group</th>
                <th>Benf Name</th>
                <th>Customer Ref</th>
                <th>Bank No</th>
                <th>Bank Code</th>
                <th>Bank Name</th>
                <th>Bank Branch</th>
                <th>Bank Currency</th>
");
#nullable restore
#line 37 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                 for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
                {
                    DateTime dt = new DateTime(date.Year, date.Month, i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <th>");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                         Write(dt.ToString("dd-MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <th>Tardies</th>
                <th>Short Leaves</th>
                <th>Absents</th>
                <th>Paid Leave</th>
                <th>Unpaid Leave</th>
                <th>Presents</th>
                <th>Total Days</th>
                <th>Deducted Days</th>
                <th>Salary Month</th>
            </tr>
        </thead>
        <tfoot style=""display:table-row-group"">
            <tr class=""text-center"">

                <th>Sr.No</th>
                <th>Emp Id</th>
                <th>Name</th>
                <th>CNIC</th>
                <th>NTN</th>
                <th>DOB</th>
                <th>Joining Date</th>
                <th>Leaving Date</th>
                <th>Joiner/Leaver</th>
                <th>office Location</th>
                <th>Department</th>
                <th>Shift</th>
                <th>Designation</th>
                <th>Emp Type</th>
                <th>Wage Group</th>
                <th>Benf Name</th>
  ");
            WriteLiteral("              <th>Customer Ref</th>\r\n                <th>Bank No</th>\r\n                <th>Bank Code</th>\r\n                <th>Bank Name</th>\r\n                <th>Bank Branch</th>\r\n                <th>Bank Currency</th>\r\n");
#nullable restore
#line 78 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                 for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
                {
                    DateTime dt = new DateTime(date.Year, date.Month, i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>");
#nullable restore
#line 81 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(dt.ToString("dd-MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 82 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <th>Tardies</th>
                <th>Short Leaves</th>
                <th>Absents</th>
                <th>Paid Leave</th>
                <th>Unpaid Leave</th>
                <th>Presents</th>
                <th>Total Days</th>
                <th>Deducted Days</th>
                <th>Salary Month</th>


            </tr>
        </tfoot>
        <tbody>

");
#nullable restore
#line 98 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
             foreach (var item in empAttendanceReportViewModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td> ");
#nullable restore
#line 101 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 102 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.EmpCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 103 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 104 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.EmpCNIC);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 105 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.NTN);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 106 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                     Write(item.DOB !=null ? item.DOB.Value.ToShortDateString():"" );

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 107 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                     Write(item.JoiningDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 108 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.LeavingDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 109 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.JoinerLeaver);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 110 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.OfficeLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 111 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 112 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.Shift);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 113 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 114 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.EmpType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 115 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.WageGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 116 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.BeneficiaryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 117 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.CustomerRef);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 118 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.BankAccountNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 119 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.BankCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 120 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 121 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.BankBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 122 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    Write(item.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n");
#nullable restore
#line 124 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                     foreach (var days in item.ListMonthAttendancePresentAbsent)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 126 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                       Write(days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 127 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 128 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.Tardies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.ShortLeaves);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 130 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.Absents);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 131 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.PaidLeaves);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 132 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.UnpaidLeaves);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 133 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.Presents);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 134 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.TotalDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 135 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.DeductedDays);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 136 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
                   Write(item.SalaryMonth.ToString("MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 138 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\SalaryPayablesPerMonth\_ListEmpAttendanceReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<script>\r\n    var applicationName = getApplicationName();\r\n\r\n    $(function () {\r\n\r\n        _initDatatable(\'#dtList\');\r\n        $(\'#dtList\').show();\r\n    });\r\n    \r\n</script>");
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
