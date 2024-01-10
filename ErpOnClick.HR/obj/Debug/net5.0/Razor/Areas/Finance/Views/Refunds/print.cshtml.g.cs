#pragma checksum "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af1947bab4af2ae029fe4798925f6e2b88b2f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Finance_Views_Refunds_print), @"mvc.1.0.view", @"/Areas/Finance/Views/Refunds/print.cshtml")]
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
#line 1 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
using ErpOnClick.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af1947bab4af2ae029fe4798925f6e2b88b2f16", @"/Areas/Finance/Views/Refunds/print.cshtml")]
    public class Areas_Finance_Views_Refunds_print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
  
    Layout = "_LayoutReport";
    Refunds RefundMDetails = Model.refundMDetail;
    Company CompanyDetail = Model.CompanyDetail;
    List<RefundsLines> RefundDList = Model.refundDList;
    //List<ErpOnClick.DAL.Models.Items> ItemsList = Model.ItemsList;
    //List<Branch> BranchDetails = Model.branchList;
    List<Vendors> VendorsDetails = Model.vendorsList;
    //List<TaxRates> TaxList = Model.TaxList;
    decimal billamount = 0;
    decimal totalvat = 0;
    decimal total = 0;
    int count = 0;

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
                        REFUND
                    </h2>
                    <h4 class=""text-center"" style=""margin:5px 0px 0px 0px; font-weight:500""> ");
            WriteLiteral(@"</h4><br>

                    <table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""0"" id=""DataGrid1"" style=""width: 100%;  "" class=""tblDetail"">
                        <thead>


                        </thead>
                        <tbody>
                            <tr class=""Grid_HeaderStyle text-center"">
                                <td width=""50%"">Refund To / <span style=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;"">فاتورة إلى</span> </td>
                                <td colspan=""2"">Refund / <span style=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;"">الفاتورة</span></td>
                                <td colspan=""2"">Due / <span style=""letter-spacing:normal !important;font-size: 13px;font-family: tahoma;""> المستحق</span></td>
                            </tr>
                            <tr class=""ItemColor text-center"">
                                <td rowspan=""2"" class=""text-left"">
                                    V");
            WriteLiteral("endor Id: ");
#nullable restore
#line 41 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                          Write(RefundMDetails.VendorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <h3 style=\"margin:0px; text-transform:uppercase\">");
#nullable restore
#line 42 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                                                                Write(RefundMDetails.Vendor.VendorNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <br>\r\n\r\n                                </td>\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2355, "\"", 2364, 0);
            EndWriteAttribute();
            WriteLiteral(">Date / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">تاريخ</span></th>\r\n\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2497, "\"", 2506, 0);
            EndWriteAttribute();
            WriteLiteral(">RN # / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">رقم</span></th>\r\n\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2637, "\"", 2646, 0);
            EndWriteAttribute();
            WriteLiteral(">Amt. / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">إجمالي </span></th>\r\n\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 2781, "\"", 2790, 0);
            EndWriteAttribute();
            WriteLiteral(">Date / <span style=\"letter-spacing:normal !important;font-family: tahoma;\">تاريخ</span></th>\r\n\r\n                            </tr>\r\n                            <tr class=\"ItemColor\">\r\n\r\n                                <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 3012, "\"", 3021, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 58 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(Convert.ToDateTime(RefundMDetails.RefundDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 61 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(RefundMDetails.RefundNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 64 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(RefundMDetails.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                                     Write(RefundMDetails.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 3547, "\"", 3556, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 67 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(Convert.ToDateTime(RefundMDetails.DueDate).ToString("dd-MMM-yyyy"));

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
            BeginWriteAttribute("nowrap", " nowrap=\"", 4689, "\"", 4698, 0);
            EndWriteAttribute();
            WriteLiteral(">Bill Amt.</th>\r\n                                <th>VAT (%)</th>\r\n                                <th>VAT Amt.</th>\r\n                                <th");
            BeginWriteAttribute("nowrap", " nowrap=\"", 4852, "\"", 4861, 0);
            EndWriteAttribute();
            WriteLiteral(">Total (SAR)</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 97 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                             foreach (var item in RefundDList)
                            {
                                count = count + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"ItemColor text-center\">\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 101 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-left\" width=\"200px\">");
#nullable restore
#line 102 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>");
#nullable restore
#line 104 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                   Write(item.ItemPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 105 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                      
                                        if (item.ItemPrice != 0)
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
            WriteLiteral("                                    <td class=\"text-center\">");
#nullable restore
#line 115 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                                       Write(RefundMDetails.TaxRate.TaxPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 117 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                          
                                            var per = (item.LineAmount * RefundMDetails.TaxRate.TaxPercent) / 100;
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 120 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                   Write(per);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n");
#nullable restore
#line 123 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                      
                                        totalvat += Convert.ToDecimal(per);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <td>\r\n");
#nullable restore
#line 128 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                          
                                            var sum = item.LineAmount + per;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 132 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 134 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                  
                                    total += Convert.ToDecimal(sum);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 138 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        <thead>\r\n                            <tr class=\"Grid_HeaderStyle text-center\">\r\n                                <th colspan=\"2\" class=\"text-left\"></th>\r\n\r\n                                <th>");
#nullable restore
#line 144 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(billamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th></th>\r\n                                <th>");
#nullable restore
#line 146 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(totalvat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 147 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                               Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n                            <tr");
            BeginWriteAttribute("class", " class=\"", 7511, "\"", 7519, 0);
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
#line 172 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                   Write(RefundMDetails.Note);

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
#line 181 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
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
#line 187 "C:\Nayel Solutions Projects\Source Code\ErpOnClick(Finance)\ErpOnClick.HR\Areas\Finance\Views\Refunds\print.cshtml"
                                   Write(CompanyDetail.BankDetailAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
