#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355aa4ad9758b7b55dd0f239e19af159e30b3ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ESS_Views_EmpAttendances_Index), @"mvc.1.0.view", @"/Areas/ESS/Views/EmpAttendances/Index.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
using ErpOnClick.ErpMain.Areas.ESS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355aa4ad9758b7b55dd0f239e19af159e30b3ae4", @"/Areas/ESS/Views/EmpAttendances/Index.cshtml")]
    public class Areas_ESS_Views_EmpAttendances_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
  

    DateTime? date = Model.attendanceDate;
    List<EmpAttendance> employeecheck = Model.employeecheck;
    var attendancechek = (employeecheck.Count != 0 ? employeecheck.FirstOrDefault().IsSaved : false);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TabName", async() => {
                WriteLiteral("\r\n    Vacant jobs Setup\r\n");
            }
            );
            WriteLiteral(@"<style>
    .ui-datepicker-calendar {
        display: none;
    }

    .text {
        display: inline-block;
        padding: 0.5em 1em;
        min-width: 20em;
        line-height: 1.2em;
        background: #84ceeb;
        position: relative;
    }
</style>
<input type=""hidden"" name=""attendancechek"" id=""attendancechek""");
            BeginWriteAttribute("value", " value=\"", 757, "\"", 780, 1);
#nullable restore
#line 31 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
WriteAttributeValue("", 765, attendancechek, 765, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n<div class=\"card card-default card-outline\">\r\n\r\n    <div class=\"card-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <h2 class=\"card-title\">\r\n                    ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Emp Attendances"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n\r\n            <div class=\"col-md-3\">\r\n");
            WriteLiteral("                <input type=\"month\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1400, "\"", 1474, 1);
#nullable restore
#line 46 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
WriteAttributeValue("", 1408, date!=null ? date.Value.Year+"-"+date.Value.ToString("MM") : "", 1408, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"AttendanceDate\" name=\"AttendanceDate\" />\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <button class=\"btn  btn-sm btn-primary\" onclick=\"searchByDate()\">");
#nullable restore
#line 49 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
                                                                            Write(SharedLocalizer.GetLocalizedHtmlString("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                <a id=\"printAtten\"");
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-default btn-sm\"><i class=\"fa fa-print fa-fw\"></i>");
#nullable restore
#line 50 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\ESS\Views\EmpAttendances\Index.cshtml"
                                                                                                                      Write(SharedLocalizer.GetLocalizedHtmlString("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- /. tools -->\r\n    </div>\r\n    <div class=\"card-body\">\r\n\r\n        <div id=\"divList\"></div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            BindGrid();

            //$(""#AttendanceDate"").calendarsPicker({
            //    onShow: $.calendarsPicker.monthOnly,
            //    showTrigger: '#calImg'
            //});

            //$('#AttendanceDate').datepicker({
            //    changeMonth: true,
            //    changeYear: true,
            //    showButtonPanel: true,
            //    dateFormat: 'MM yy',
            //    onClose: function (dateText, inst) {
            //        $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));
            //    }
            //});

            //console.log(attendancechek);
            //if (attendancechek == false) {
            //    $('#AttendanceCheck').show();

            //}
        });
        var applicationName = getApplicationName();

        function getEmployees() {
            var attendaceDate = $('#AttendanceDate').val();

            $.ajax({
                url: applic");
                WriteLiteral(@"ationName + ""ESS/EmpAttendances/GetEmployees"",
                async: false,
                type: ""POST"",
                data: { date: attendaceDate },
                success: function (data) {
                    window.location = applicationName + 'ESS/EmpAttendances?attendanceDate=' + attendaceDate;
                }
            });
        };
        function searchByDate() {
            //var date = $('#AttendanceDate').val();
            debugger;
            var attendaceDate = $('#AttendanceDate').val();

            //if (date == """") {
            if (attendaceDate == """") {
                showMsg('Enter !', '!Date First');
            }
            else {

                $.ajax({
                    url: applicationName + ""ESS/EmpAttendances/_list"",
                    async: false,
                    type: ""POST"",
                    data: { date: attendaceDate },
                    success: function (data) {
                        window.location = applicationName ");
                WriteLiteral(@"+ 'ESS/EmpAttendances?attendanceDate=' + attendaceDate;
                    }
                });

                //    BindGrid(date);
            }


        }

        function BindGrid(date) {
            date = (date == null ? $('#AttendanceDate').val() : date);
            $('#divList').html('<h5 class=""margin-0""><p><i class=""fa fa-spinner fa-spin fa-fw""></i> Please wait while data is loading...</p></h5>');
            $.ajax({
                url: applicationName + 'ESS/empattendances/_list',
                data: { date: date },
                success: function (data) {
                    $('#divList').html(data);
                }
            })
        };


        function saveAttendace() {
            confirmAction('Confirm ?', 'Are you sure you want to save changes ?', 'info', 'Yes', 'No').then(function (result) {
                if (result.value == true) {


                    var empAttendancesList = new Array();

                    $(""#dtList tbody TR"").each(");
                WriteLiteral(@"function () {

                        var row = $(this);
                        var EmpAttendance = {};

                        if (row.find(""#AllowanceTypeId"").val() != """") {

                            var IsPresent = ""IsPaidLeave-"" + row.find('#EmpId').val();
                            console.log(row.find(""#IsPresent"").is(':checked'));
                            console.log(row.find(""#IsPaidLeave"").is(':checked'));
                            console.log(row.find(""#IsUnpaidLeave"").is(':checked'));
                            console.log(row.find(""#IsShortLeave"").is(':checked'));
                            EmpAttendance.EmpAttendanceId = parseInt(row.find(""#EmpAttendanceId"").val());
                            EmpAttendance.EmpId = parseInt(row.find('#EmpId').val());
                            EmpAttendance.AttendanceDate = ($(""#AttendanceDate"").val() == """" ? null : $(""#AttendanceDate"").val());
                            EmpAttendance.CreatedDate = ($(""#CreatedDate"").val() == """" ? n");
                WriteLiteral(@"ull : $(""#CreatedDate"").val());
                            EmpAttendance.TimeIn = (row.find(""#TimeIn"").val() == """" ? null : row.find(""#TimeIn"").val());
                            EmpAttendance.Note = (row.find(""#Note"").val() == """" ? null : row.find(""#Note"").val());
                            EmpAttendance.TimeOut = (row.find(""#TimeOut"").val());
                            EmpAttendance.IsPresent = (row.find(""#IsPresent"").is(':checked') == true ? true : false);
                            EmpAttendance.IsPaidLeave = (row.find(""#IsPaidLeave"").is(':checked') == true ? true : false);
                            EmpAttendance.IsUnpaidLeave = (row.find(""#IsUnpaidLeave"").is(':checked') == true ? true : false);
                            EmpAttendance.IsShortLeave = (row.find(""#IsShortLeave"").is(':checked') == true ? true : false);

                            empAttendancesList.push(EmpAttendance);
                        }


                    });
                    var attendaceDate = $('#Atten");
                WriteLiteral(@"danceDate').val();
                    $.ajax({
                        url: applicationName + ""ESS/EmpAttendances/save"",
                        data: { postedData: empAttendancesList },
                        async: false,
                        type: 'POST',

                        success: function (data) {

                            if (data.monthcheck == 1) {
                                showMsg('Failed !', 'Kindly mark the current month attendance !', 'error');

                            }
                            else {
                                if (data.result.isError != true) {
                                    showMsg('Saved !', 'Record has been saved !', 'success');
                                    setTimeout(function () {
                                        window.location = applicationName + 'ESS/EmpAttendances?attendanceDate=' + attendaceDate;
                                    }, 500);
                                }
                          ");
                WriteLiteral(@"      else if (data.result.msg != '') {
                                    showMsg('Save Failed !', data.result.msg, 'error');
                                }
                                else {
                                    showMsg('Save Failed !', 'Something went wrong. Try again', 'error');
                                }
                            }
                        }
                    });
                }
            });

        }

        $('#printAtten').click(function (e) {
            debugger;
            var attendaceDate = $('#AttendanceDate').val();
            /*window.open(getApplicationName() + ""ESS/EmpAttendances/PrintAttendance?attendanceDate="" + attendaceDate, ""_blank"");*/
            window.open(getApplicationName() + ""ESS/EmpAttendances/PrintAttendance/"" + attendaceDate, ""_blank"");
            
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
