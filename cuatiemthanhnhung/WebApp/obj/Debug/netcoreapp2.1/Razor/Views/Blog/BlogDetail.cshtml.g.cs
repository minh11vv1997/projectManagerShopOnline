#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a477c8c4b99707e26481b2f145ad5779edf46dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogDetail.cshtml", typeof(AspNetCore.Views_Blog_BlogDetail))]
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
#line 6 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
using SharedObject.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a477c8c4b99707e26481b2f145ad5779edf46dd", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedObject.ValueObjects.VBlog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Asset/images/person_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-5 bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
   var blogdetail = (List<SharedObject.ValueObjects.VBlogDetail>)ViewBag.BlogDetail;
    var categories = (List<SharedObject.ValueObjects.VBlogCategory>)ViewBag.Category;
    var recentblogs = (List<SharedObject.ValueObjects.VBlog>)ViewBag.RecentBlog; 

#line default
#line hidden
            BeginContext(293, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(325, 35, true);
            WriteLiteral("\n\n<div class=\"hero-wrap hero-bread\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 360, "\"", 408, 4);
            WriteAttributeValue("", 368, "background-image:", 368, 17, true);
            WriteAttributeValue(" ", 385, "url(", 386, 5, true);
#line 9 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 390, Model.BlogImage, 390, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 406, ");", 406, 2, true);
            EndWriteAttribute();
            BeginContext(409, 325, true);
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""/kien-thuc"">Kiến thức</a></span> </p>
                <h1 class=""mb-0 bread"">");
            EndContext();
            BeginContext(735, 12, false);
#line 14 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                  Write(Model.Tittle);

#line default
#line hidden
            EndContext();
            BeginContext(747, 208, true);
            WriteLiteral("</h1>\n            </div>\n        </div>\n    </div>\n</div>\n\n<section class=\"ftco-section ftco-degree-bg\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8 ftco-animate\">\n\n");
            EndContext();
#line 25 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                 foreach (var item in blogdetail)
                {

#line default
#line hidden
            BeginContext(1023, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(1032, 11, false);
#line 27 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
   Write(item.Number);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(1046, 11, false);
#line 27 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                 Write(item.Tittle);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 7, true);
            WriteLiteral(" </h2>\n");
            EndContext();
            BeginContext(1085, 22, false);
#line 28 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
               Write(Html.Raw(item.Content));

#line default
#line hidden
            EndContext();
#line 28 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                           }

#line default
#line hidden
            BeginContext(1109, 172, true);
            WriteLiteral("\n\n\n\n               \n\n                <div class=\"about-author d-flex p-4 bg-light\">\n                    <div class=\"bio align-self-md-center mr-4\">\n                        ");
            EndContext();
            BeginContext(1281, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "726422b70cc349f0b7c33f44433a0a64", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 717, true);
            WriteLiteral(@"
                    </div>
                    <div class=""desc align-self-md-center"">
                        <h3>Lance Smith</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>


                <div class=""pt-5 mt-5"">
                    <h3 class=""mb-5"">6 Comments</h3>
                    <ul class=""comment-list"">
                        <li class=""comment"">
                            <div class=""vcard bio"">
                                ");
            EndContext();
            BeginContext(2084, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac014daa64904b8b98dc3f82fd949532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(2147, 771, true);
            WriteLiteral(@"
                            </div>
                            <div class=""comment-body"">
                                <h3>John Doe</h3>
                                <div class=""meta"">June 27, 2018 at 2:21pm</div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur quidem laborum necessitatibus, ipsam impedit vitae autem, eum officia, fugiat saepe enim sapiente iste iure! Quam voluptas earum impedit necessitatibus, nihil?</p>

                            </div>
                        </li>


                    </ul>
                    <!-- END comment-list -->

                    <div class=""comment-form-wrap pt-5"">
                        <h3 class=""mb-5"">Leave a comment</h3>
                        ");
            EndContext();
            BeginContext(2918, 1260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "485556ca520040d787345e7151eba867", async() => {
                BeginContext(2956, 1215, true);
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""name"">Name *</label>
                                <input type=""text"" class=""form-control"" id=""name"">
                            </div>
                            <div class=""form-group"">
                                <label for=""email"">Email *</label>
                                <input type=""email"" class=""form-control"" id=""email"">
                            </div>
                            <div class=""form-group"">
                                <label for=""website"">Website</label>
                                <input type=""url"" class=""form-control"" id=""website"">
                            </div>

                            <div class=""form-group"">
                                <label for=""message"">Message</label>
                                <textarea name="""" id=""message"" cols=""30"" rows=""10"" class=""form-control""></textarea>
                            </div>
                            <di");
                WriteLiteral("v class=\"form-group\">\n                                <input type=\"submit\" value=\"Post Comment\" class=\"btn py-3 px-4 btn-primary\">\n                            </div>\n\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4178, 207, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div> <!-- .col-md-8 -->\n            <div class=\"col-lg-4 sidebar ftco-animate\">\n                <div class=\"sidebar-box\">\n                    ");
            EndContext();
            BeginContext(4385, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "912506f9f1d048b8b077d62a2df3c95e", async() => {
                BeginContext(4422, 264, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <span class=""icon ion-ios-search""></span>
                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4693, 179, true);
            WriteLiteral("\n                </div>\n                <div class=\"sidebar-box ftco-animate\">\n                    <h3 class=\"heading\">Categories</h3>\n                    <ul class=\"categories\">\n");
            EndContext();
#line 105 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                         foreach (var item in categories)
                        {

#line default
#line hidden
            BeginContext(4956, 37, true);
            WriteLiteral("            <li><a href=\"/kien-thuc\">");
            EndContext();
            BeginContext(4994, 17, false);
#line 107 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                Write(item.BlogCateName);

#line default
#line hidden
            EndContext();
            BeginContext(5011, 11, true);
            WriteLiteral(" </a></li>\n");
            EndContext();
#line 108 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
}

#line default
#line hidden
            BeginContext(5024, 164, true);
            WriteLiteral("\n\n                    </ul>\n                </div>\n\n                <div class=\"sidebar-box ftco-animate\">\n                    <h3 class=\"heading\">Recent Blog</h3>\n");
            EndContext();
#line 116 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                     foreach (var item in recentblogs)
                    {
                        string url = $"/chi-tiet-bai-viet/{item.KeyCode}/{item.SeoTittle.ToAscii()}";

#line default
#line hidden
            BeginContext(5367, 79, true);
            WriteLiteral("        <div class=\"block-21 mb-4 d-flex\">\n            <a class=\"blog-img mr-4\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5446, "\"", 5493, 4);
            WriteAttributeValue("", 5454, "background-image:", 5454, 17, true);
            WriteAttributeValue(" ", 5471, "url(", 5472, 5, true);
#line 120 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5476, item.BlogImage, 5476, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 5491, ");", 5491, 2, true);
            EndWriteAttribute();
            BeginContext(5494, 77, true);
            WriteLiteral("></a>\n            <div class=\"text\">\n                <h3 class=\"heading-1\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5571, "\"", 5582, 1);
#line 122 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
WriteAttributeValue("", 5578, url, 5578, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5583, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5585, 11, false);
#line 122 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                                Write(item.Tittle);

#line default
#line hidden
            EndContext();
            BeginContext(5596, 118, true);
            WriteLiteral("</a></h3>\n                <div class=\"meta\">\n                    <div><a href=\"#\"><span class=\"icon-calendar\"></span> ");
            EndContext();
            BeginContext(5715, 16, false);
#line 124 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                                                    Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(5731, 82, true);
            WriteLiteral("</a></div>\n                    <div><a href=\"#\"><span class=\"icon-person\"></span> ");
            EndContext();
            BeginContext(5814, 13, false);
#line 125 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                                                                  Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5827, 149, true);
            WriteLiteral("</a></div>\n                    <div><a href=\"#\"><span class=\"icon-chat\"></span> 19</a></div>\n                </div>\n            </div>\n        </div>");
            EndContext();
#line 129 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
              }

#line default
#line hidden
            BeginContext(5978, 159, true);
            WriteLiteral("\n\n                </div>\n\n\n\n                <div class=\"sidebar-box ftco-animate\">\n                    <h3 class=\"heading\">Tóm tắt</h3>\n                    <p>");
            EndContext();
            BeginContext(6138, 13, false);
#line 138 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebApp\Views\Blog\BlogDetail.cshtml"
                  Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(6151, 103, true);
            WriteLiteral("!</p>\n                </div>\n            </div>\n\n        </div>\n    </div>\n</section> <!-- .section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedObject.ValueObjects.VBlog> Html { get; private set; }
    }
}
#pragma warning restore 1591