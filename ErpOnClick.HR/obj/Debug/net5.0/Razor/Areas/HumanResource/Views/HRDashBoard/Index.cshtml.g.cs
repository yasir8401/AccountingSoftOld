#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\HRDashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0796b3882a625f6bf242c8c481fc637acd00a35e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_HRDashBoard_Index), @"mvc.1.0.view", @"/Areas/HumanResource/Views/HRDashBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0796b3882a625f6bf242c8c481fc637acd00a35e", @"/Areas/HumanResource/Views/HRDashBoard/Index.cshtml")]
    public class Areas_HumanResource_Views_HRDashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div id=""main"" role=""main"">

    <!-- #MAIN CONTENT -->
    <div>
        <div class=""outer-block"">

            <div class=""items colBG"">
                <h4>Salaries</h4>
                <div class=""clearfix margin-5""></div>
                <div style=""height:350px"">
                    <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 385, "\"", 393, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 452, "\"", 460, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartAging"" width=""399"" height=""350"" class=""chartjs-render-monitor"" style=""display: block; width: 399px; height: 350px;""></canvas>
                </div>
            </div>

            <div class=""items colSM"">
                <a href=""/Admin/Customers""><h4>Employees</h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Total Customers"">
                        55
                        <small><br>50 Active | 5 Non-Active</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 1379, "\"", 1387, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 1446, "\"", 1454, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartCustomers"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>



            <div class=""items colBG"">
                <h4>Attendance</h4>
                <div class=""clearfix margin-5""></div>
                <div style=""height:350px"">
                    <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 2000, "\"", 2008, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 2067, "\"", 2075, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartGeneralEntries"" style=""display: block; width: 399px; height: 350px;"" width=""399"" height=""350"" class=""chartjs-render-monitor""></canvas>
                </div>
            </div>

            <div class=""items colSM"">

                <a href=""/Admin/Vendors""><h4>Profile</h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Total Vendors"">
                        1
                        <small><br>1 Active | 0 Non-Active</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 2997, "\"", 3005, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 3064, "\"", 3072, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartVendors"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>






            <div class=""items colBG"">
                <h4>Documents</h4>
                <div class=""clearfix margin-5""></div>
                <div style=""height:340px"">
                    <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 3621, "\"", 3629, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 3688, "\"", 3696, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                    <canvas id=""chartServices"" width=""399"" height=""340"" class=""chartjs-render-monitor"" style=""display: block; width: 399px; height: 340px;""></canvas>
                </div>
            </div>

            <div class=""items colSM"">

                <a href=""/demo_erp/reports/rpttimesheet""><h4>Timesheets <small>Oct-2020</small></h4></a>
                <div class=""pull-left "" style=""width:50%"">

                    <div class=""margin-top-25"">&nbsp;</div>
                    <h1 class=""text-center "" style=""line-height:30px"" title=""Submitted Timesheets"">
                        0
                        <small title=""Pending Timesheets""><br>2 Pending</small>
                    </h1>
                </div>
                <div class=""pull-right "" style=""width:50%"">

                    <div style=""height:140px"">
                        <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 4675, "\"", 4683, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 4742, "\"", 4750, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                        <canvas id=""chartTimesheet"" width=""200"" height=""140"" class=""chartjs-render-monitor"" style=""display: block; width: 200px; height: 140px;""></canvas>
                    </div>
                </div>
            </div>



        </div>


        <style type=""text/css"">

            /* Chart.js */
            ");
            WriteLiteral(@"@keyframes chartjs-render-animation {
                from {
                    opacity: .99
                }

                to {
                    opacity: 1
                }
            }

            .chartjs-render-monitor {
                animation: chartjs-render-animation 1ms
            }

            .chartjs-size-monitor, .chartjs-size-monitor-expand, .chartjs-size-monitor-shrink {
                position: absolute;
                direction: ltr;
                left: 0;
                top: 0;
                right: 0;
                bottom: 0;
                overflow: hidden;
                pointer-events: none;
                visibility: hidden;
                z-index: -1
            }

                .chartjs-size-monitor-expand > div {
                    position: absolute;
                    width: 1000000px;
                    height: 1000000px;
                    left: 0;
                    top: 0
                }

                .cha");
            WriteLiteral(@"rtjs-size-monitor-shrink > div {
                    position: absolute;
                    width: 200%;
                    height: 200%;
                    left: 0;
                    top: 0
                }
        </style>





        <style>

            body {
                background-color: #e5e5e5 !important;
            }

            .colSM {
                height: 200px;
            }

            .colBG {
                height: 415px;
            }

            ");
            WriteLiteral(@"@media only screen and (min-device-width: 768px) {
                .outer-block {
                    -moz-column-count: 3;
                    -webkit-column-count: 3;
                    column-count: 3;
                    -moz-column-gap: 1em;
                    -webkit-column-gap: 1em;
                    column-gap: 1em;
                }
            }

            .items {
                display: inline-block;
                margin: 0 0 1em;
                width: 100%;
                background-color: #FFF;
                padding: 10px 10px;
            }

                .items h4 {
                    font-size: 1.3em;
                    font-weight: 600;
                    color: #519494;
                    border-bottom: 2px solid whitesmoke;
                    padding-bottom: 10px;
                }

                .items h1 {
                    font-size: 5em;
                    font-weight: 500;
                    color: #9a9a9a;
                }

");
            WriteLiteral(@"                .items .align-text-bottom {
                }

            .pull-left {
                float: left !important;
            }

            .pull-right {
                float: right !important;
            }

            .margin-top-25 {
                margin-top: 25px !important
            }

            h1 small {
                font-size: 18px;
                font-weight: 300;
                letter-spacing: -1px;
            }
        </style>



    </div>
    <!-- end row -->
    <!-- END #MAIN CONTENT -->

</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            initChartGeneralEntries();
            initChartServices();
            initChartVendors();
            initChartCustomers();
            initChartAging();
            initChartTimesheet();
        })


        function initChartGeneralEntries() {
            var ctx = document.getElementById('chartGeneralEntries').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'line',

                // The data for our dataset
                data: {
                    labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'Octuber', 'November', 'December'],
                    datasets: [{
                        label: 'GeneralEntries',
                        backgroundColor: '#6bafae',
                        borderColor: '#519494',
                        data: [0, 10, 5, 2, 20, 30, 45, 50, 55, 45,");
                WriteLiteral(@" 65, 50, 75, 90]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartServices() {
            var ctx = document.getElementById('chartServices').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'pie',

                // The data for our dataset
                data: {
                    labels: ['ID Card', 'Passport', 'Contract', 'Birth Certificate', 'Insurance'],
                    datasets: [{
                        label: 'Sales',
                        backgroundColor: ['#519494', '#6bafae', '#519494', '#cbe2eb', '#6bafae'],
                        //backgroundColor: ['#5D9CEC','#48CFAD','#A0D468','#6bafae','#ffe500'],
                        borderColor: 'white',
                        data: [20, 15, 1");
                WriteLiteral(@"5, 20, 35]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartVendors() {
            var ctx = document.getElementById('chartVendors').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Active', 'Non-Active'],
                    datasets: [{
                        label: 'Status',
                        backgroundColor: ['#6bafae', '#cbe2eb'],
                        borderColor: 'white',
                        data: [1, 0]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
      ");
                WriteLiteral(@"          }
            });

        }



        function initChartCustomers() {
            var ctx = document.getElementById('chartCustomers').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Active', 'Non-Active'],
                    datasets: [{
                        label: 'Status',
                        backgroundColor: ['#6bafae', '#cbe2eb'],
                        borderColor: 'white',
                        data: [50, 5]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }


        function initChartTimesheet() {
            var ctx = document.getElementById('chartTimesheet').getContext('2d');
            v");
                WriteLiteral(@"ar chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'doughnut',

                // The data for our dataset
                data: {
                    labels: ['Submitted', 'Pending'],
                    datasets: [{
                        label: 'Pending',
                        backgroundColor: ['#6bafae', '#cbe2eb'],
                        borderColor: 'white',
                        data: [0, 2]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }



        function initChartAging() {
            var ctx = document.getElementById('chartAging').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'bar',

                // The data for our dataset
                data: {
     ");
                WriteLiteral(@"               labels: ['0 Days', '15 Days', '30 Days', '45 Days', '60 Days', '90 Days', '120 Days'],
                    datasets: [{
                        label: 'Due',
                        backgroundColor: ['#519494', '#519494', '#6bafae', '#519494', '#6bafae', '#86cac9', '#a2e6e6', '#dbffff'],
                        data: [1500, 2000, 13000, 25000, 35000, 7000, 20000, 10000]
                    }]
                },

                // Configuration options go here
                options: {
                    maintainAspectRatio: false,
                }
            });

        }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
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
