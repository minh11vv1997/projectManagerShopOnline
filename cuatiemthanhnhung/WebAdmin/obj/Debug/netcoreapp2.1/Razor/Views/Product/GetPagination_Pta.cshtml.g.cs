#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c301087d3fe3c42479b380acf860b18b07e07f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetPagination_Pta), @"mvc.1.0.view", @"/Views/Product/GetPagination_Pta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetPagination_Pta.cshtml", typeof(AspNetCore.Views_Product_GetPagination_Pta))]
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
#line 1 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\_ViewImports.cshtml"
using WebAdmin;

#line default
#line hidden
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\_ViewImports.cshtml"
using WebAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c301087d3fe3c42479b380acf860b18b07e07f7", @"/Views/Product/GetPagination_Pta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetPagination_Pta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedObject.ValueObjects.VProduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
  

    Layout = null;

#line default
#line hidden
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(124, 53, true);
            WriteLiteral("    <tr class=\"text-center\" style=\"text-align:center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 177, "\"", 200, 2);
            WriteAttributeValue("", 182, "tr-", 182, 3, true);
#line 11 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
WriteAttributeValue("", 185, item.ProductId, 185, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 15, true);
            WriteLiteral(">\r\n        <td>");
            EndContext();
            BeginContext(217, 7, false);
#line 12 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
       Write(item.rc);

#line default
#line hidden
            EndContext();
            BeginContext(224, 21, true);
            WriteLiteral("</td>\r\n        <td>\r\n");
            EndContext();
#line 14 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
              
                string format = "dd/MM/yyyy HH:mm";
                DateTime date = (DateTime)@item.DateCreated;
                string dateDisplay = date.ToString(format);
            

#line default
#line hidden
            BeginContext(452, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(465, 11, false);
#line 19 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
       Write(dateDisplay);

#line default
#line hidden
            EndContext();
            BeginContext(476, 47, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-left\">");
            EndContext();
            BeginContext(524, 16, false);
#line 21 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
                         Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(540, 37, true);
            WriteLiteral("</td>\r\n        <td class=\"text-left\">");
            EndContext();
            BeginContext(578, 17, false);
#line 22 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
                         Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(595, 37, true);
            WriteLiteral("</td>\r\n        <td class=\"text-left\">");
            EndContext();
            BeginContext(633, 10, false);
#line 23 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
                         Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(643, 60, true);
            WriteLiteral("</td>\r\n        <td>\r\n            <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 703, "\"", 720, 1);
#line 25 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
WriteAttributeValue("", 709, item.Image, 709, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(721, 68, true);
            WriteLiteral(" style=\"height:80px; width:100%\" />\r\n        </td>\r\n\r\n        <td>\r\n");
            EndContext();
#line 29 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
              
                string status = item.Status ==1 ? "Sản phẩm nổi bật" : "Sản phẩm thường";
            

#line default
#line hidden
            BeginContext(912, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(925, 6, false);
#line 32 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
       Write(status);

#line default
#line hidden
            EndContext();
            BeginContext(931, 79, true);
            WriteLiteral("\r\n\r\n        </td>\r\n\r\n        <td class=\"text-center\">\r\n            <a data-id=\"");
            EndContext();
            BeginContext(1011, 14, false);
#line 37 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 224, true);
            WriteLiteral("\" class=\"btn default btn-xs purple update\" data-toggle=\"modal\" href=\"#modal-add\"> <span class=\"glyphicon glyphicon-edit\" title=\"Cập nhật trạng thái\"></span></a>\r\n            <a class=\"btn default btn-xs red delete\" data-id=\"");
            EndContext();
            BeginContext(1250, 14, false);
#line 38 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
                                                         Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 83, true);
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span></a>\r\n        </td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 42 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\GetPagination_Pta.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedObject.ValueObjects.VProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591