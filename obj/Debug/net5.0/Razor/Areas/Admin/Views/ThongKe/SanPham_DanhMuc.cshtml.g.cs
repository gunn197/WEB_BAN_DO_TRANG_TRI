#pragma checksum "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a27dfdd8fab2d5626e9f19cb8d19a87c558792e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_SanPham_DanhMuc), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/SanPham_DanhMuc.cshtml")]
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
#line 1 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a27dfdd8fab2d5626e9f19cb8d19a87c558792e", @"/Areas/Admin/Views/ThongKe/SanPham_DanhMuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d71792b181dc18fbc076ed99ae8066af3109e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThongKe_SanPham_DanhMuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
  
    ViewData["Title"] = "Thống kê sản phẩm";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
  
    var list_dmsp = (SortedList<string, int>)ViewBag.ListDMSP; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   -
<div class=""card"">
    <div class=""card-body"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h5>Số lượng sản phẩm trong danh mục </h5>

        </div>
        <div class=""m-t-30"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Tên danh mục sản phẩm</th>
                            <th>Số lượng</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
                         if (list_dmsp != null)
                        {
                            foreach (var item in list_dmsp)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 35 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
                                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
                                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 42 "D:\framework_IS220.M11_10-15bdcb4b494840688ec757454d9bcfb0854b61be\Areas\Admin\Views\ThongKe\SanPham_DanhMuc.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
