#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c20cb15b88d48d2a565523520015d36ded3e3465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetAll), @"mvc.1.0.view", @"/Views/Account/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/GetAll.cshtml", typeof(AspNetCore.Views_Account_GetAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c20cb15b88d48d2a565523520015d36ded3e3465", @"/Views/Account/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/user.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1452, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">

        <div class=""col-md-12"">

            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""height:1000px"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Manage users
                        </span>
                    </div>

                    <div class=""portlet-body"">

                        <div class=""table-toolbar"">

                            <div class=""col-md-2 col-sm-12 col-xs-12 pull-left"">
                                <a class=""btn btn-success"" target=""_blank"" href=""/Account/add"" id=""btn-add"">Create new</a>

                            </div>

                        </div>
                    </div>
                </div>

                <div class=""table-responsive col-md-12 table-responsive"">
                    ");
            WriteLiteral(@"<table class=""table table-bordered table-hover table-striped "">
                        <thead>
                            <tr class=""text-center"">

                                <td>Username</td>
                                <td>Email</td>
                                <td>Utilities</td>

                            </tr>
                        </thead>
                        <tbody id=""table-content"">
");
            EndContext();
#line 43 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1598, 100, true);
            WriteLiteral("                                <tr class=\"text-center\">\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(1699, 13, false);
#line 47 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1712, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1760, 10, false);
#line 48 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 210, true);
            WriteLiteral("</td>\r\n\r\n                                    <td class=\"text-center\">\r\n\r\n                                        <a class=\"btn default btn-xs purple update\" data-toggle=\"modal\" href=\"#modal-add\" data-username=\"");
            EndContext();
            BeginContext(1981, 13, false);
#line 52 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                                                                                                                                    Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 168, true);
            WriteLiteral("\" title=\"Update\"> <span class=\"glyphicon glyphicon-edit\"></span></a>\r\n\r\n                                        <a class=\"btn default btn-xs red delete\" data-username=\"");
            EndContext();
            BeginContext(2163, 13, false);
#line 54 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                                                                                           Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2176, 158, true);
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\" title=\"Delete\"></span></a>\r\n\r\n                                    </td>\r\n\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 60 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Account\GetAll.cshtml"
                            }

#line default
#line hidden
            BeginContext(2365, 765, true);
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
                <div class=""pagination"" id=""pagination"">
                </div>
            </div>

        </div>

    </div>

</div>
<!--Modal arear-->

<div class=""modal-area"">

    <div class=""modal fade"" id=""modal-add"" tabindex=""-1"" role=""columnheader"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                    <h4 class=""modal-title"">Update User </h4>
                    <p hidden id=""hid-UserId""></p>
                </div>
                ");
            EndContext();
            BeginContext(3130, 593, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef854dee2cc94c0480fd0bdcada75209", async() => {
                BeginContext(3169, 547, true);
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label for=""txt-CourseName"">Email</label>
                        <input type=""text"" class=""form-control"" id=""txt-Email"" name=""Email"" style=""color:mediumvioletred"">
                    </div>
                    <div class=""form-group"">
                        <label for=""txt-Image"">UserName</label>
                        <input type=""text"" class=""form-control"" id=""txt-UserName"" name=""UserName"">
                    </div>
                   

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3723, 355, true);
            WriteLiteral(@"
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn default"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn blue"" id=""btn-save"">Save</button>
                </div>
            </div>
        </div>
    </div>
    <!--Kết thúc Modal thêm, update-->

</div>
");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(4094, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4100, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e6575c506ae49abaa7f7f889d7712fa", async() => {
                    BeginContext(4127, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4144, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(4151, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591