#pragma checksum "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Index), @"mvc.1.0.view", @"/Views/Sanpham/Index.cshtml")]
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
#line 1 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb3", @"/Views/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<doan.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sanpham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
  
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;
    ViewData["Title"] = "Index" + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/slider/bg/background2.png"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">Cửa hàng Decor Stis</h1>
                        <ul>
                            <li>
                                <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Danh sách sản phẩm</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <!--<div class=""col-lg-2 order-lg-1 order-2 pt-10 pt-lg-0"">
                        <!--<div class=""sidebar-area"">
      ");
            WriteLiteral(@"          <div class=""widgets-searchbox mb-3"">
                    <input id=""giasanpham"" name=""giasanpham"" class=""form-control"" type=""text"" placeholder=""Tìm kiếm theo giá"">
                    <div class=""widgets-searchbox-btn"">
                        <i class=""pe-7s-search""></i>
                    </div>-->
                <!--");
            WriteLiteral("-->\r\n                <!--<!--</div>-->\r\n                <!--");
            WriteLiteral(@"-->
                <!--</div>-->
                <!--</div>-->
                <div class=""col-lg-1 order-lg-1 order-2 pt-10 pt-lg-0""></div>
                <div class=""col-lg-11 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                                <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class=""list-view"" role=""presentation"">
                                        <a class=""active"" id=""list-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
         ");
            WriteLiteral(@"                                   <i class=""fa fa-th-list""></i>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class=""page-count"">
                                <span>Trang này có ");
#nullable restore
#line 276 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm</span>\r\n                            </li>\r\n                            <li class=\"short\">\r\n");
            WriteLiteral(@"                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"" id=""gia1"">
");
#nullable restore
#line 293 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)

                                {
                                    var stt = 0;

                                    foreach (var item in Model)

                                    {
                                        string url = $"/{item.MaSp}.html";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-lg-4 col-sm-6"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 17794, "\"", 17805, 1);
#nullable restore
#line 307 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 17801, url, 17801, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 308 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                          
                                                            string temp = item.MaSp + ".jpg";
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 18100, "\"", 18118, 2);
            WriteAttributeValue("", 18106, "/Image/", 18106, 7, true);
#nullable restore
#line 311 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 18113, temp, 18113, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 18119, "\"", 18135, 1);
#nullable restore
#line 311 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 18125, item.MoTa, 18125, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
");
#nullable restore
#line 316 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                  
                                                                    stt += 1;
                                                                    var id_add = "add_cart" + @stt.ToString();
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb313464", async() => {
                WriteLiteral("\r\n                                                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 18964, "\"", 19018, 3);
                WriteAttributeValue("", 18974, "document.getElementById(\'", 18974, 25, true);
#nullable restore
#line 321 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 18999, id_add, 18999, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 19006, "\').submit();", 19006, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                        <i class=\"pe-7s-cart\"></i>\r\n                                                                    </a>\r\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 18815, "/GioHang/Add_cart?product_id=", 18815, 29, true);
#nullable restore
#line 320 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 18844, item.MaSp, 18844, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 320 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 18874, id_add, 18874, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                            </li>

                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb317222", async() => {
#nullable restore
#line 331 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                                            Write(item.TenSp);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price text-danger\">");
#nullable restore
#line 333 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                                                    </div>\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 347 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""tab-pane fade show active"" id=""list-view"" role=""tabpanel"" aria-labelledby=""list-view-tab"">
                            <div class=""product-list-view with-sidebar row"">
");
#nullable restore
#line 355 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    var stt = 0;
                                    foreach (var item in Model)

                                    {
                                        string url = $"/{item.MaSp}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-12 pt-6"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 21911, "\"", 21922, 1);
#nullable restore
#line 365 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 21918, url, 21918, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 366 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                          
                                                            string temp = item.MaSp + ".jpg";
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 22217, "\"", 22235, 2);
            WriteAttributeValue("", 22223, "/Image/", 22223, 7, true);
#nullable restore
#line 369 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 22230, temp, 22230, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 22236, "\"", 22253, 1);
#nullable restore
#line 369 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue(" ", 22242, item.MoTa, 22243, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
");
#nullable restore
#line 374 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                  
                                                                    stt += 1;
                                                                    var id_add = "add_cart2" + @stt.ToString();
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb323451", async() => {
                WriteLiteral("\r\n                                                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 23083, "\"", 23137, 3);
                WriteAttributeValue("", 23093, "document.getElementById(\'", 23093, 25, true);
#nullable restore
#line 379 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 23118, id_add, 23118, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 23125, "\').submit();", 23125, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                        <i class=\"pe-7s-cart\"></i>\r\n                                                                    </a>\r\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 22934, "/GioHang/Add_cart?product_id=", 22934, 29, true);
#nullable restore
#line 378 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 22963, item.MaSp, 22963, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 378 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 22993, id_add, 22993, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                            </li>

                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content align-self-center"">
                                                    <a class=""product-name pb-2""");
            BeginWriteAttribute("href", " href=\"", 23813, "\"", 23824, 1);
#nullable restore
#line 389 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 23820, url, 23820, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 389 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                                           Write(item.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></a>\r\n                                                    <div class=\"price-box pb-1\">\r\n                                                        <span class=\"new-price text-danger\">");
#nullable restore
#line 391 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                                                    </div>\r\n");
            WriteLiteral("                                                    <p class=\"short-desc mb-0\">");
#nullable restore
#line 402 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                                                          Write(item.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 406 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"pagination-area pt-10\">\r\n                        <ul class=\"pagination justify-content-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e661dcdb38e4ce5a6b38dd54fd65439ed51ebb329695", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 414 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 414 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Views\Sanpham\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {


            $(""#giasanpham"").keyup(function () {
                var strkeyword = $('#giasanpham').val();
                $.ajax({
                    url: '/Searchtheogia/Searchgia/',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { giasanpham: strkeyword },
                    async: true,
                    success: function (results) {
                        $(""#gia1"").html("""");
                        $(""#gia1"").html(results);

                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<doan.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
