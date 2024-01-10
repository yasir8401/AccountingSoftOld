#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf21bda899dd0c8167006d23bfdd9e808f9db160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Bills_print), @"mvc.1.0.view", @"/Areas/Finance/Views/Bills/print.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf21bda899dd0c8167006d23bfdd9e808f9db160", @"/Areas/Finance/Views/Bills/print.cshtml")]
    public class Areas_Finance_Views_Bills_print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
  
    Layout = "_LayoutReport";
    Bills BillMDetails = Model.billMDetail;
    Company CompanyDetail = Model.CompanyDetail;
    List<BillsLines> BillDList = Model.billDList;
    //List<ErpOnClick.DAL.Models.Items> ItemsList = Model.ItemsList;
    //List<Branch> BranchDetails = Model.branchList;
    List<Vendors> VendorsDetails = Model.vendorsList;
    //List<TaxRates> TaxList = Model.TaxList;
    decimal billamount = 0;
    decimal totalvat = 0;
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <br />
    <table id=""Outline1"" style=""border-collapse: collapse"" bordercolor=""silver"" cellspacing=""0"" cellpadding=""3"" width=""100%"" border=""0"">
        <tbody>
            <tr>
                <td>
                    <h2 class=""ReportTitle text-center"" style=""font-size: 25px ; margin:0px;  "">
                        BILL
                    </h2>
                    <h4 class=""text-center"" style=""margin:5px 0px 0px 0px; font-weight:500""> </h4><br>

                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>


                        </thead>
                        <tbody>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <td width=""50%"">Bill To / <span style=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;"">فاتورة إلى</span> </td>
                                <td colspan=""2"">Bill / <span styl");
            WriteLiteral(@"e=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;"">الفاتورة</span></td>
                                <td colspan=""2"">Due / <span style=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;""> المستحق</span></td>
                            </tr>
                            <tr class=""ItemColor text-center"">
                                <td rowspan=""2"" class=""text-left"">
                                    Vendor Id: ");
#nullable restore
#line 40 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                          Write(BillMDetails.VendorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <h3 style=\"margin:0px; text-transform:uppercase\">");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                                                                Write(BillMDetails.Vendor.VendorNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <br>\r\n\r\n                                </td>\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2281, "\"", 2290, 0);
            EndWriteAttribute();
            WriteLiteral(">Date / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">تاريخ</span></th>\r\n                                \r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2455, "\"", 2464, 0);
            EndWriteAttribute();
            WriteLiteral(">Bill # / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">رقم</span></th>\r\n\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2597, "\"", 2606, 0);
            EndWriteAttribute();
            WriteLiteral(">Amt. / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">إجمالي </span></th>\r\n                                \r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2773, "\"", 2782, 0);
            EndWriteAttribute();
            WriteLiteral(">Date / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">تاريخ</span></th>\r\n\r\n                            </tr>\r\n                            <tr class=\"ItemColor\">\r\n\r\n                                <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 3004, "\"", 3013, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 57 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(Convert.ToDateTime(BillMDetails.BillDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 60 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(BillMDetails.BillNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 63 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(BillMDetails.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                                   Write(BillMDetails.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 3527, "\"", 3536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 66 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(Convert.ToDateTime(BillMDetails.DueDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>

                            </tr>
                        </tbody>
                    </table>
                    <br>
                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>
                            <tr class=""Grid_HeaderStyle Grid_HeaderStyle_Arabic"">
                                <th width=""30px"">رقم</th>
                                <th>الوصف</th>

                                <th width=""60px"">مبلغ الفاتورة</th>
                                <th width=""40px"">ضريبة</th>
                                <th width=""40px"">قيمة الضريبة</th>
                                <th width=""40px"">إجمالي</th>
                            </tr>
                            <tr class=""Grid_HeaderStyle"">
                                <th>Sr#</th>
                                <th>Description</th>


                                <");
            WriteLiteral("th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 4667, "\"", 4676, 0);
            EndWriteAttribute();
            WriteLiteral(">Bill Amt.</th>\r\n                                <th>VAT (%)</th>\r\n                                <th>VAT Amt.</th>\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 4830, "\"", 4839, 0);
            EndWriteAttribute();
            WriteLiteral(">Total (SAR)</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 96 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                             foreach (var item in BillDList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"ItemColor text-center\">\r\n                            <td class=\"text-center\">1</td>\r\n                            <td class=\"text-left\" width=\"200px\">");
#nullable restore
#line 100 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 102 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                           Write(item.ItemPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 103 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               
                                if(item.ItemPrice != 0)
                                {
                                    billamount += Convert.ToDecimal(item.ItemPrice);
                                }
                                else
                                {
                                    billamount += 0;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-center\">");
#nullable restore
#line 113 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                               Write(BillMDetails.TaxRate.TaxPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 115 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                   
                                    var per= (item.LineAmount * BillMDetails.TaxRate.TaxPercent) / 100;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 118 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                           Write(per);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n");
#nullable restore
#line 121 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               
                                totalvat += Convert.ToDecimal(per);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td>");
#nullable restore
#line 125 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                   
                                var sum = item.LineAmount + per;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                                ");
#nullable restore
#line 129 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                           Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 130 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               
                                total += Convert.ToDecimal(sum);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 134 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                        <thead>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <th colspan=""2"" class=""text-left""></th>

                                <th>");
#nullable restore
#line 140 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(billamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th></th>\r\n                                <th>");
#nullable restore
#line 142 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(totalvat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 143 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr");
            BeginWriteAttribute("class", " class=\"", 7158, "\"", 7166, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <td colspan=""7"" style=""text-align:left"">
                                    <small style=""text-transform:capitalize"">
                                        <b>Amount in words: </b>
                                        one
                                        Only
                                        <br>
                                        (All amount in Saudi Riyal)
                                    </small>
                                </td>

                            </tr>
                        </thead>
                    </table>






                    <br>
                    <h4 style=""margin:10px 0px 5px 0px"">Further Description:</h4>
                    <div id=""FurtherDescription"" style=""font-size:13px"">
                        ");
#nullable restore
#line 168 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                   Write(BillMDetails.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <br><br>
                    <hr style=""border: 1px solid whitesmoke; margin-bottom:5px;"">
                    <table width=""100%"" style=""font-size:15px"">
                        <tbody>
                            <tr>
                                <td style=""text-align:left; line-height:1; vertical-align:top"" width=""50%"">
                                    <h4 style=""margin:0px 0px 5px 0px"">Bank Detail</h4>
                                    ");
#nullable restore
#line 177 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                               Write(CompanyDetail.BankDetailEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
            WriteLiteral(@"
                                </td>

                                <td style=""text-align:right;font-family: tahoma;line-height: 1; vertical-align:top;"" id=""tdPrint"">
                                    <div dir=""rtl"">
                                        <h4 style=""margin:0px 0px 5px 0px"">تفاصيل البنك</h4>
                                        ");
#nullable restore
#line 183 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Bills\print.cshtml"
                                   Write(CompanyDetail.BankDetailAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("     \r\n");
            WriteLiteral(@"
                                    </div>

                                </td>

                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</div>");
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
