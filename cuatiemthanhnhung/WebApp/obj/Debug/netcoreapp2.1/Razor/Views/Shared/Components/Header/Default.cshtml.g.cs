#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b430ffecb2f4ce08e11e04774ce7ef9d76ff3cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b430ffecb2f4ce08e11e04774ce7ef9d76ff3cce", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedObject.ValueObjects.VInformation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 522, true);
            WriteLiteral(@"    <div class=""py-1 bg-primary"">
        <div class=""container"">
            <div class=""row no-gutters d-flex align-items-start align-items-center px-md-0"">
                <div class=""col-lg-12 d-block"">
                    <div class=""row d-flex"">
                        <div class=""col-md pr-4 d-flex topper align-items-center"">
                            <div class=""icon mr-2 d-flex justify-content-center align-items-center""><span class=""icon-phone2""></span></div>
                            <span class=""text"">");
            EndContext();
            BeginContext(569, 12, false);
#line 9 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                          Write(Model.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(581, 314, true);
            WriteLiteral(@"</span>
                        </div>
                        <div class=""col-md pr-4 d-flex topper align-items-center"">
                            <div class=""icon mr-2 d-flex justify-content-center align-items-center""><span class=""icon-paper-plane""></span></div>
                            <span class=""text"">");
            EndContext();
            BeginContext(896, 11, false);
#line 13 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Shared\Components\Header\Default.cshtml"
                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(907, 338, true);
            WriteLiteral(@"</span>
                        </div>
                        <div class=""col-md-5 pr-4 d-flex topper align-items-center text-lg-right"">
                            <span class=""text"">Giao h??ng trong ng??y</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedObject.ValueObjects.VInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
