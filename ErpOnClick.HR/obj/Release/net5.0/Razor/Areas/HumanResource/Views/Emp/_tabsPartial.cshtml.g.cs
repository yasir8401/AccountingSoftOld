#pragma checksum "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2d2f9eed2fa3e90afbafd7fb6e0eccb30b975e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HumanResource_Views_Emp__tabsPartial), @"mvc.1.0.view", @"/Areas/HumanResource/Views/Emp/_tabsPartial.cshtml")]
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
#line 2 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
using ErpOnClick.DAL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2d2f9eed2fa3e90afbafd7fb6e0eccb30b975e", @"/Areas/HumanResource/Views/Emp/_tabsPartial.cshtml")]
    public class Areas_HumanResource_Views_Emp__tabsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Emp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
  
    var filePath = NativePaths.GetFilePath(_env);
    var empDetails = @Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--<div class=\"card card-default card-outline col-lg-12\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title mt-1\">\r\n            ");
#nullable restore
#line 19 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Personal Information"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>-->\r\n<!-- tools box -->\r\n<!--<div class=\"card-tools pr-0\">\r\n    <button type=\"submit\" class=\"btn  btn-sm btn-primary\">\r\n        <i class=\"fas fa-save fa-fw\"></i> ");
#nullable restore
#line 24 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <a href=\"~/HumanResource/emp\" type=\"button\" class=\"btn  btn-sm btn-default\">\r\n        <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 27 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                           Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </a>
</div>-->
<!-- /. tools -->
<!--</div>
    <div class=""card-body"">
        <div class=""row"">

            <div class=""col-lg-3 padding-left-0 pl-0 text-left"" style=""background-repeat:no-repeat;background-size: 200px 200px;background-image:url('/adminlte/dist/img/noimage.jpg');text-align: center"" onclick=""uploadimg()"">
");
#nullable restore
#line 36 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                 if (empDetails != null && empDetails.ProfilePic != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img style=\"width:200px;height:200px\" id=\"profilePic\"");
            BeginWriteAttribute("class", " class=\"", 1524, "\"", 1532, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1533, "\"", 1570, 2);
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 1539, filePath, 1539, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 1548, empDetails.ProfilePic, 1548, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"text\" hidden id=\"ProfilePic\" name=\"ProfilePic\"");
            BeginWriteAttribute("value", " value=\"", 1655, "\"", 1710, 1);
#nullable restore
#line 39 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 1663, empDetails!=null?empDetails.ProfilePic: null, 1663, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 40 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img style=\"width: 200px; height: 200px\" id=\"profilePic\"");
            BeginWriteAttribute("class", " class=\"", 1850, "\"", 1858, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"/Erp/adminlte/dist/img/noimage.jpg\" />\r\n");
#nullable restore
#line 44 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <input type=""file"" hidden id=""ProfilePicFile"" name=""ProfilePicFile"" class="""">

            <div class=""col-lg-9"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <div class=""form-group"">
                            <label>");
#nullable restore
#line 53 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"FirstNameEn\" required name=\"FirstNameEn\" class=\"form-control\" value=\"");
#nullable restore
#line 54 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                    Write(empDetails!=null?empDetails.FirstNameEn: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 59 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Fathers Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                            <input type=\"text\" id=\"FatherNameEn\" name=\"FatherNameEn\" class=\"form-control\" value=\"");
#nullable restore
#line 60 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                             Write(empDetails!=null?empDetails.FatherNameEn: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 66 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Grand Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </label>\r\n                            <input type=\"text\" id=\"GrandNameEn\" name=\"GrandNameEn\" class=\"form-control\" value=\"");
#nullable restore
#line 67 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                           Write(empDetails!=null?empDetails.GrandNameEn: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 72 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Family Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                            <input type=\"text\" id=\"FamilyNameEn\" name=\"FamilyNameEn\" class=\"form-control\" value=\"");
#nullable restore
#line 73 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                             Write(empDetails!=null?empDetails.FamilyNameEn: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 78 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("First Name  (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                            <input type=\"text\" id=\"FirstNameAr\" name=\"FirstNameAr\" class=\"form-control\" value=\"");
#nullable restore
#line 79 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                           Write(empDetails!=null?empDetails.FirstNameAr: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 84 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Father Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"FatherNameAr\" name=\"FatherNameAr\" class=\"form-control\" value=\"");
#nullable restore
#line 85 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                             Write(empDetails!=null?empDetails.FatherNameAr: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 90 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Grand Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"GrandNameAr\" name=\"GrandNameAr\" class=\"form-control\" value=\"");
#nullable restore
#line 91 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                           Write(empDetails!=null?empDetails.GrandNameAr: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
#nullable restore
#line 96 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Family Name (Arabic)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"FamilyNameAr\" name=\"FamilyNameAr\" class=\"form-control\" value=\"");
#nullable restore
#line 97 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                             Write(empDetails!=null?empDetails.FamilyNameAr: null);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>-->\r\n");
#nullable restore
#line 105 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
Write(Html.Partial("/Areas/HumanResource/Views/Emp/_generalInfoPartial.cshtml", empDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabGeneralInfo-tab\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5743, "\"", 5784, 3);
            WriteAttributeValue("", 5753, "navigation(\'", 5753, 12, true);
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 5765, empDetails.EmpId, 5765, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5782, "\')", 5782, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-info\"></i> ");
#nullable restore
#line 108 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("General Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEducation-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5994, "\"", 6026, 3);
            WriteAttributeValue("", 6004, "goItem(\'", 6004, 8, true);
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 6012, Model.EmpId, 6012, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6024, "\')", 6024, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 111 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Education"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabAddress-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6231, "\"", 6266, 3);
            WriteAttributeValue("", 6241, "goItemTwo(\'", 6241, 11, true);
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 6252, Model.EmpId, 6252, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6264, "\')", 6264, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-address-book\"></i> ");
#nullable restore
#line 114 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                           Write(SharedLocalizer.GetLocalizedHtmlString("Address"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabBanks-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6475, "\"", 6512, 3);
            WriteAttributeValue("", 6485, "goItemThree(\'", 6485, 13, true);
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 6498, Model.EmpId, 6498, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6510, "\')", 6510, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-building\"></i> ");
#nullable restore
#line 117 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Banks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabDependents-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6720, "\"", 6756, 3);
            WriteAttributeValue("", 6730, "goItemFour(\'", 6730, 12, true);
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 6742, Model.EmpId, 6742, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6754, "\')", 6754, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-users\"></i> ");
#nullable restore
#line 120 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Dependents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabMedicals-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6964, "\"", 7000, 3);
            WriteAttributeValue("", 6974, "goItemFive(\'", 6974, 12, true);
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 6986, Model.EmpId, 6986, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6998, "\')", 6998, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-clinic-medical\"></i> ");
#nullable restore
#line 123 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                               Write(SharedLocalizer.GetLocalizedHtmlString("Medicals"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabVehicles-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7215, "\"", 7250, 3);
            WriteAttributeValue("", 7225, "goItemSix(\'", 7225, 11, true);
#nullable restore
#line 126 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 7236, Model.EmpId, 7236, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7248, "\')", 7248, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-car\"></i> ");
#nullable restore
#line 126 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                   Write(SharedLocalizer.GetLocalizedHtmlString("Vehicles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEmpContract-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7457, "\"", 7494, 3);
            WriteAttributeValue("", 7467, "goItemSeven(\'", 7467, 13, true);
#nullable restore
#line 129 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 7480, Model.EmpId, 7480, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7492, "\')", 7492, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-file-contract\"></i> ");
#nullable restore
#line 129 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("Contracts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEmpShifts-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7710, "\"", 7747, 3);
            WriteAttributeValue("", 7720, "goItemEight(\'", 7720, 13, true);
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 7733, Model.EmpId, 7733, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7745, "\')", 7745, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 132 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("Shifts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEmpExperience-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7955, "\"", 7991, 3);
            WriteAttributeValue("", 7965, "goItemNine(\'", 7965, 12, true);
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 7977, Model.EmpId, 7977, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7989, "\')", 7989, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-clipboard-list\"></i> ");
#nullable restore
#line 135 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                                    Write(SharedLocalizer.GetLocalizedHtmlString("Previous Experience"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabGosiSettings-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8221, "\"", 8256, 3);
            WriteAttributeValue("", 8231, "goItemTen(\'", 8231, 11, true);
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 8242, Model.EmpId, 8242, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8254, "\')", 8254, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-cog\"></i> ");
#nullable restore
#line 138 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("GOSI Settings"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEmpLoans-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8465, "\"", 8503, 3);
            WriteAttributeValue("", 8475, "goItemEleven(\'", 8475, 14, true);
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 8489, Model.EmpId, 8489, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8501, "\')", 8501, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-coins\"></i> ");
#nullable restore
#line 141 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Loans"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n<li class=\"nav-item\">\r\n    <a class=\"nav-link\" id=\"tabEmpAchievements-tab\" data-toggle=\"pill\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8713, "\"", 8751, 3);
            WriteAttributeValue("", 8723, "goItemTwelve(\'", 8723, 14, true);
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
WriteAttributeValue("", 8737, Model.EmpId, 8737, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8749, "\')", 8749, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"javascript:void(0)\"><i class=\"fa fa-medal\"></i> ");
#nullable restore
#line 144 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                                                                                                               Write(SharedLocalizer.GetLocalizedHtmlString("Achievements"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</li>\r\n\r\n\r\n<script>\r\n    var applicationName = getApplicationName();\r\n\r\n\r\n\r\n    function goItem() {\r\n\r\n        window.location = applicationName + \'HumanResource/empeducation/emp/");
#nullable restore
#line 155 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                       Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemTwo() {\r\n\r\n        window.location = applicationName + \'HumanResource/empaddresses/emp/");
#nullable restore
#line 159 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                       Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemThree() {\r\n\r\n        window.location = applicationName + \'HumanResource/empbanks/emp/");
#nullable restore
#line 163 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                   Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemFour() {\r\n\r\n        window.location = applicationName + \'HumanResource/empdependents/emp/");
#nullable restore
#line 167 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                        Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemFive() {\r\n\r\n        window.location = applicationName + \'HumanResource/empmedicals/emp/");
#nullable restore
#line 171 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                      Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemSix() {\r\n\r\n        window.location = applicationName + \'HumanResource/empvehicles/emp/");
#nullable restore
#line 175 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                      Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemSeven() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpContracts/emp/");
#nullable restore
#line 179 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                       Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemEight() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpShifts/emp/");
#nullable restore
#line 183 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                    Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemNine() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpPreviousExp/emp/");
#nullable restore
#line 187 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                         Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n     function goItemTen() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpGosiSettings/emp/");
#nullable restore
#line 191 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                          Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemEleven() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpLoans/emp/");
#nullable restore
#line 195 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                   Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n    function goItemTwelve() {\r\n\r\n        window.location = applicationName + \'HumanResource/EmpAchievement/emp/");
#nullable restore
#line 199 "C:\Users\SGH\OneDrive\Documents\Repo\ErpOnClick(Finance)\ErpOnClick.HR\Areas\HumanResource\Views\Emp\_tabsPartial.cshtml"
                                                                         Write(Model.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    };\r\n\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n");
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