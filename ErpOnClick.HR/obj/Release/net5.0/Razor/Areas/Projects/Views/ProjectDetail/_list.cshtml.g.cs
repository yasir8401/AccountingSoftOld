#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7216b5ba04711ac61ccece0ce84a96cc6d6c2bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Projects_Views_ProjectDetail__list), @"mvc.1.0.view", @"/Areas/Projects/Views/ProjectDetail/_list.cshtml")]
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
#line 1 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
using ErpOnClick.ErpMain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7216b5ba04711ac61ccece0ce84a96cc6d6c2bbc", @"/Areas/Projects/Views/ProjectDetail/_list.cshtml")]
    public class Areas_Projects_Views_ProjectDetail__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
  
    List<ProjectDetailListingViewModel> projectDetailListing = Model.projectDetailListing;
    var filePath = NativePaths.GetFilePath(_env);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    ul {
        list-style-type: none;
        padding: 0px
    }
</style>

<div class=""table-responsive pb-2 "">
    <table id=""dtList"" class=""table table-hover table-condensed "" style=""display:none"">
        <thead class=""text-sm"">
            <tr>
                <th>");
#nullable restore
#line 23 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Team Members"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 25 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Progress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 26 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Plan Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tfoot style=\"display:table-row-group\">\r\n            <tr class=\"text-center\">\r\n                <th>");
#nullable restore
#line 32 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th>");
#nullable restore
#line 33 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Team Members"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Progress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("Plan Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </tfoot>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
             foreach (var item in projectDetailListing)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n\r\n                    <td width=\"200px\" align=\"left\">\r\n                        <ul style=\"list-style-type:none;\">\r\n                            <li>");
#nullable restore
#line 47 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                           Write(item.Project.ProjectTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li style=\"color:black;font-size:10px\">");
#nullable restore
#line 48 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                                              Write(item.ProjectType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </td>
                    <td width=""350px"">
                        <ul style=""display:inline-flex; white-space:nowrap"">
                            <li>
                                <img style=""height: 48px;  width: 47px;"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2282, "\"", 2398, 9);
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2290, item.ProjectManager.FirstNameEn, 2290, 32, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("  ", 2322, item.ProjectManager.FatherNameEn, 2324, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2357, "(He", 2358, 4, true);
            WriteAttributeValue(" ", 2361, "is", 2362, 3, true);
            WriteAttributeValue(" ", 2364, "Project", 2365, 8, true);
            WriteAttributeValue(" ", 2372, "Manager", 2373, 8, true);
            WriteAttributeValue(" ", 2380, "for", 2381, 4, true);
            WriteAttributeValue(" ", 2384, "this", 2385, 5, true);
            WriteAttributeValue(" ", 2389, "project)", 2390, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle elevation-2\"");
            BeginWriteAttribute("src", " src=\"", 2430, "\"", 2476, 2);
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2436, filePath, 2436, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2445, item.ProjectManager.ProfilePic, 2445, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </li>\r\n");
#nullable restore
#line 56 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                             foreach (var member in item.TeamMembersList)
                            {
                                if (member.EmpId != item.ProjectManager.EmpId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <img style=\"height: 48px; width: 47px;\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 2879, "\"", 2928, 2);
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2887, member.FirstNameEn, 2887, 19, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("  ", 2906, member.FatherNameEn, 2908, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle elevation-2\"");
            BeginWriteAttribute("src", " src=\"", 2960, "\"", 2993, 2);
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2966, filePath, 2966, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 2975, member.ProfilePic, 2975, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </li>\r\n");
#nullable restore
#line 63 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 69 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                          Write(item.Project.ProjectProgressPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (%)</label>\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar progress-bar-green\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3412, "\"", 3464, 1);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue("", 3428, item.Project.ProjectProgressPercent, 3428, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 3503, "\"", 3555, 3);
            WriteAttributeValue("", 3511, "width:", 3511, 6, true);
#nullable restore
#line 71 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
WriteAttributeValue(" ", 3517, item.Project.ProjectProgressPercent, 3518, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3554, "%", 3554, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <ul>\r\n                            <li>\r\n");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                 if (item.Status == "New")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"badge badge-danger\">New</label>\r\n");
#nullable restore
#line 81 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }
                                else if (item.Status == "Pending")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"badge badge-warning\">Pending</label>\r\n");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label class=\"badge badge-success\">Completed</label>\r\n");
#nullable restore
#line 89 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 92 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                              
                                var days = (item.DaysBehidSchedule != null ? Int32.Parse(item.DaysBehidSchedule.Split('.')[0]) : 0);
                                if (days > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"text-danger\">");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                                       Write(days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Days - ");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                                                    Write(item.DaysBehidSchedule.Split('.')[1].Split(':')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Months , Behind Schedule To Start</li>\r\n");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 100 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                   Write(days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Days - 0 Months  Behind Schedule To Start</li>\r\n");
#nullable restore
#line 101 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </td>\r\n                    <td width=\"150px\">\r\n                        <ul>\r\n                            <li>Start: ");
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                   Write(item.Project.PlanDateFrom != null ? Convert.ToDateTime(item.Project.PlanDateFrom).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                            <li>End: ");
#nullable restore
#line 109 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
                                 Write(item.Project.PlanDateTo != null ? Convert.ToDateTime(item.Project.PlanDateTo).ToString("dd-MMM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        </ul>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Projects\Views\ProjectDetail\_list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<script>\r\n    $(function () {\r\n        $(\'[data-toggle=\"tooltip\"]\').tooltip()\r\n        _initDatatable(\'#dtList\');\r\n        $(\'#dtList\').show();\r\n    });\r\n\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment _env { get; private set; }
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
