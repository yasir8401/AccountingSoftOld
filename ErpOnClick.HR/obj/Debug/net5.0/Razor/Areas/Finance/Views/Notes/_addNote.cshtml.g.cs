#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4563ad9b6ee65612b6ca30d069b63dd80802bd47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Notes__addNote), @"mvc.1.0.view", @"/Areas/Finance/Views/Notes/_addNote.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
using ErpOnClick.ErpMain.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4563ad9b6ee65612b6ca30d069b63dd80802bd47", @"/Areas/Finance/Views/Notes/_addNote.cshtml")]
    public class Areas_Finance_Views_Notes__addNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""_addNote"" tabindex=""-1"" role=""dialog"" aria-labelledby=""_addNoteLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <form id=""formAddNote"" role=""form"">

                <div class=""modal-header "" style=""background-color:#dbefef"">
                    <h2 class=""card-title"">
                        ");
#nullable restore
#line 12 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Notes Form"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h2>
                    <!-- tools box -->
                    <div class=""card-tools"">
                        <button type=""submit"" id=""formsubmit"" class=""btn  btn-sm btn-primary pull-right"">
                            <i class=""fas fa-save fa-fw""></i>  ");
#nullable restore
#line 17 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                                                          Write(SharedLocalizer.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"btn  btn-sm btn-default pull-right\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                            <i class=\"fas fa-arrow-left fa-fw\"></i> ");
#nullable restore
#line 20 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                                                               Write(SharedLocalizer.GetLocalizedHtmlString("Return"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                        <div class=""clearfix""></div>

                    </div>
                </div>

                <div class=""modal-body"" id=""formAttachmentdiv"">
                    <div class=""col-md-12"">
                        <div class=""card card-default card-outline"">

                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <div class=""form-group"">
                                            <label>");
#nullable restore
#line 35 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                                              Write(SharedLocalizer.GetLocalizedHtmlString("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 1888, "\"", 1893, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""NoteTitle"" class=""form-control"" required>
                                        </div>
                                    </div>

                                    <div class=""col-sm-6"">
                                        <div class=""form-group"">
                                            <label>");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                                              Write(SharedLocalizer.GetLocalizedHtmlString("Parent Note"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <select id=""NotesParents"" name=""ParentNoteId"" class=""form-control"">
                                            </select>
                                        </div>
                                    </div>
");
            WriteLiteral("                                    <div class=\"col-sm-12\">\r\n                                        <div class=\"form-group\">\r\n                                            <label>");
#nullable restore
#line 55 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Notes\_addNote.cshtml"
                                              Write(SharedLocalizer.GetLocalizedHtmlString("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            <textarea");
            BeginWriteAttribute("id", " id=\"", 3311, "\"", 3316, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""NoteDescription"" class=""form-control "" style=""border:none"" placeholder=""Enter Description here..."" required></textarea>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>");
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
