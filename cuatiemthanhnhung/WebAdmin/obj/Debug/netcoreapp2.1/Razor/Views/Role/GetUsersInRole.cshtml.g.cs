#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Role\GetUsersInRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead2c007c0388de629bf6a0f7e30fc74bf8a8c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_GetUsersInRole), @"mvc.1.0.view", @"/Views/Role/GetUsersInRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/GetUsersInRole.cshtml", typeof(AspNetCore.Views_Role_GetUsersInRole))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead2c007c0388de629bf6a0f7e30fc74bf8a8c9c", @"/Views/Role/GetUsersInRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_GetUsersInRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Role\GetUsersInRole.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(92, 67, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(160, 13, false);
#line 7 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Role\GetUsersInRole.cshtml"
                                      Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(173, 107, true);
            WriteLiteral("</span> \r\n        </td>\r\n        <td>\r\n            <a class=\"btn default btn-xs red remove\" data-username=\"");
            EndContext();
            BeginContext(281, 13, false);
#line 10 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Role\GetUsersInRole.cshtml"
                                                               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(294, 102, true);
            WriteLiteral("\" title=\"Remove user\"> <span class=\"glyphicon glyphicon-minus\"></span></a>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 13 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Role\GetUsersInRole.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
