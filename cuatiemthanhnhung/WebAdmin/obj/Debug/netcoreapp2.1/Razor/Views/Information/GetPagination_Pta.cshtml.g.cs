#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10326b4380ea117e06d1543f84b1cf3642483bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Information_GetPagination_Pta), @"mvc.1.0.view", @"/Views/Information/GetPagination_Pta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Information/GetPagination_Pta.cshtml", typeof(AspNetCore.Views_Information_GetPagination_Pta))]
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
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
using SharedObjects;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10326b4380ea117e06d1543f84b1cf3642483bf6", @"/Views/Information/GetPagination_Pta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Information_GetPagination_Pta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedObject.ValueObjects.VInformation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
                        
    Layout = null;

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
 foreach (var item in Model)
{

    string dateDisplay = DateTimeService.FormatDateTime((DateTime)@item.DateCreated);




#line default
#line hidden
            BeginContext(245, 53, true);
            WriteLiteral("    <tr class=\"text-center\" style=\"text-align:center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 298, "\"", 325, 2);
            WriteAttributeValue("", 303, "tr-", 303, 3, true);
#line 15 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
WriteAttributeValue("", 306, item.InformationId, 306, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 39, true);
            WriteLiteral(">\r\n      \r\n        <td>\r\n\r\n            ");
            EndContext();
            BeginContext(366, 11, false);
#line 19 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(dateDisplay);

#line default
#line hidden
            EndContext();
            BeginContext(377, 31, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>");
            EndContext();
            BeginContext(409, 15, false);
#line 22 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(item.OfficeName);

#line default
#line hidden
            EndContext();
            BeginContext(424, 37, true);
            WriteLiteral("</td>\r\n\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(462, 11, false);
#line 26 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(item.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(473, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(517, 10, false);
#line 29 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(527, 44, true);
            WriteLiteral("\r\n        </td> \r\n        <td>\r\n            ");
            EndContext();
            BeginContext(572, 12, false);
#line 32 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(584, 45, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(630, 13, false);
#line 36 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
       Write(item.Position);

#line default
#line hidden
            EndContext();
            BeginContext(643, 81, true);
            WriteLiteral("\r\n        </td>\r\n\r\n\r\n\r\n        <td class=\"text-center\">\r\n            <a data-id=\"");
            EndContext();
            BeginContext(725, 18, false);
#line 42 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
                   Write(item.InformationId);

#line default
#line hidden
            EndContext();
            BeginContext(743, 224, true);
            WriteLiteral("\" class=\"btn default btn-xs purple update\" data-toggle=\"modal\" href=\"#modal-add\"> <span class=\"glyphicon glyphicon-edit\" title=\"Cập nhật trạng thái\"></span></a>\r\n            <a class=\"btn default btn-xs red delete\" data-id=\"");
            EndContext();
            BeginContext(968, 18, false);
#line 43 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
                                                         Write(item.InformationId);

#line default
#line hidden
            EndContext();
            BeginContext(986, 83, true);
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span></a>\r\n        </td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 47 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Information\GetPagination_Pta.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedObject.ValueObjects.VInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591