#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Blog\WriteBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833849572576ba5216b3c5d74c95b8acb463d23c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_WriteBlog), @"mvc.1.0.view", @"/Views/Blog/WriteBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/WriteBlog.cshtml", typeof(AspNetCore.Views_Blog_WriteBlog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833849572576ba5216b3c5d74c95b8acb463d23c", @"/Views/Blog/WriteBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_WriteBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObject.ValueObjects.VBlogCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("select-BlogCateId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BlogCateId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/WriteBlog.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Blog\WriteBlog.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(114, 404, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">

        <div class=""col-md-12"">

            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""min-height:1000px"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-9"">
                        <span class=""caption-subject font-green-sharp bold uppercase"" id=""span-title"">
");
            EndContext();
            BeginContext(580, 1175, true);
            WriteLiteral(@"                        </span>
                    </div>

                    <div class=""portlet-body"">
                        <div class=""table-toolbar"">

                            <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">

                                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                                    <button style=""font-size:90%"" title=""Th??m kh??a h???c li??n quan"" type=""button"" class=""btn btn-success"" id=""btn-addTag""><span class=""glyphicon glyphicon-plus""></span></button>
                                    <button  id=""btn-saveBlog"" type=""button"" class=""btn btn-success"">L??u b??i vi???t</button>
                                    <button title=""L??m m???i"" type=""button"" class=""btn btn-success hidden-xs"" id=""btn-refresh"">
                                        <span class=""glyphicon glyphicon-repeat
"" style=""font-size:90%""></span> 
                                    </button>
                                </div>

            ");
            WriteLiteral("                </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(1755, 3628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba19301a5b7479f833c00b5c44a634c", async() => {
                BeginContext(1794, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(1837, 50, true);
                WriteLiteral("                        <p hidden id=\"hid-BlogId\">");
                EndContext();
                BeginContext(1888, 14, false);
#line 45 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Blog\WriteBlog.cshtml"
                                             Write(ViewBag.BlogId);

#line default
#line hidden
                EndContext();
                BeginContext(1902, 1465, true);
                WriteLiteral(@"</p>

                        <div class=""form-group col-md-4 col-xs-12"">
                            <label for=""txt-Tittle"">T??n b??i vi???t</label>
                            <input type=""text"" class=""form-control"" id=""txt-Tittle"" name=""Tittle"" style=""color:mediumvioletred"">
                        </div>




                        <div class=""form-group col-md-4 col-xs-12"">
                            <label for=""txt-BlogImage"">H??nh ???nh</label>
                            <input type=""text"" class=""form-control"" id=""txt-BlogImage"" name=""BlogImage"">
                        </div>
                        <div class=""form-group col-md-4 col-xs-12"">
                            <label for=""txt-BackGround"">H??nh n???n</label>
                            <input type=""text"" value=""0"" class=""form-control"" id=""txt-BackGround"" name=""BackGround"">
                        </div>
                        <div class=""form-group col-md-4 col-xs-12"">
                            <label for=""txt-Seen"">L?????t xem</l");
                WriteLiteral(@"abel>
                            <input type=""number"" value=""0"" class=""form-control"" id=""txt-Seen"" name=""Seen"">
                        </div>


                        <div class=""form-group col-md-4 col-xs-12"">
                            <label for=""select-Status"">B??i vi???t l???p tr??nh hay ngo???i ng???</label>
                            <select class=""form-control"" id=""select-Status"" name=""Status"">
                                ");
                EndContext();
                BeginContext(3367, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17338775067c4c6199529e9ff4b7c7b9", async() => {
                    BeginContext(3384, 18, true);
                    WriteLiteral("Ch???n lo???i b??i vi???t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3411, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3445, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2211040998c4493c9e1d404115750ed1", async() => {
                    BeginContext(3472, 16, true);
                    WriteLiteral("B??i vi???t n???i b???t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3497, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3531, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f31e1e66c1f849fb86fa168bc9a9f80b", async() => {
                    BeginContext(3549, 21, true);
                    WriteLiteral("B??i vi???t th??ng th?????ng");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3579, 243, true);
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"form-group col-md-4 col-xs-12\">\r\n                            <label for=\"select-Status\">Th??? lo???i</label>\r\n                            ");
                EndContext();
                BeginContext(3822, 276, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9985b505321d430da9d5fc4f1e5775f9", async() => {
                    BeginContext(3966, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(4000, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e00ff6af1354408387271f97f5b43357", async() => {
                        BeginContext(4026, 22, true);
                        WriteLiteral("Ch???n th??? lo???i b??i vi???t");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4057, 32, true);
                    WriteLiteral("\r\n\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 79 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Blog\WriteBlog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model,"BlogCateId","BlogCateName"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4098, 1278, true);
                WriteLiteral(@"
                        </div>

                        <div class=""form-group col-md-12 col-xs-12"">
                            <label for=""txt-Summary"">T??m t???t n???i dung</label>
                            <textarea rows=""5"" placeholder=""M?? t??? Seo"" class=""form-control"" id=""txt-Summary"" name=""Summary""></textarea>

                        </div>
                        <div class=""form-group col-md-12 col-xs-12"">
                            <label for=""txt-SeoTittle"">Ti??u ????? Seo</label>
                            <input type=""text"" class=""form-control"" id=""txt-SeoTittle"" name=""SeoTittle"">
                        </div>

                        <div class=""form-group col-md-12 col-xs-12"">
                            <label for=""txt-SeoDescription"">M?? t??? Seo</label>
                            <textarea rows=""5"" placeholder=""M?? t??? Seo"" class=""form-control"" id=""txt-SeoDescription"" name=""SeoDescription""></textarea>

                        </div>

                        <div class=""col-md-12""");
                WriteLiteral(">\r\n                            <label for=\"select-Status\">Danh s??ch kh??a h???c li??n quan</label>\r\n                            <div class=\"tagcloud\" id=\"tagcloud\">\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5383, 126, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"modal-area\">\r\n\r\n\r\n</div>\r\n");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(5525, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5533, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44deb1684b984458bb228c4d95688c9c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5574, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObject.ValueObjects.VBlogCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
