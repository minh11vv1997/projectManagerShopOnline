#pragma checksum "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee6315357ef42a2a1b1fbeb81eca704315086f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Product.cshtml", typeof(AspNetCore.Views_Product_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee6315357ef42a2a1b1fbeb81eca704315086f8", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdfc00b4acb27bf5f36fd09e3255c63eaaaa109", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObject.ValueObjects.VCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 1604, true);
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">

        <div class=""col-md-12"">

            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""height:1500px"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Qu???n l?? s???n ph???m
                        </span>
                    </div>

                    <div class=""portlet-body"">
                        <div class=""table-toolbar"">
                            <div class=""col-md-1 col-sm-12 col-xs-12 pull-left"">
                                <a class=""btn btn-success"" href=""#modal-add"" data-toggle=""modal"" id=""btn-add"">T???o m???i</a>

                            </div>
                            <div class=""col-md-1 col-sm-12 col-xs-12 pull-left"">
                                <a class=""btn btn-success""  id=""btn-exportEx"">Xu???t excel</a>

  ");
            WriteLiteral(@"                          </div>
                            <div class="" col-md-10 pull-right"">

                                <div class=""form-group col-md-6 col-md-2 col-xs-12"">
                                    <input type=""text"" class=""form-control"" id=""filter-KeyWord"" name=""KeyWord"" placeholder=""T??? kh??a"">
                                </div>
                                <div class=""form-group col-md-6 col-md-2 col-xs-12"">
                                    <select id=""filter-CategoryId"" class=""form-control"">

                                        ");
            EndContext();
            BeginContext(1708, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f3278448d548959fa3a16a61951b50", async() => {
                BeginContext(1725, 6, true);
                WriteLiteral("T???t c???");
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
            BeginContext(1740, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(1855, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(1899, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac12c96a84014eb580a5c626568f5144", async() => {
                BeginContext(1933, 17, false);
#line 41 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                                                        Write(item.CategoryName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 41 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                               WriteLiteral(item.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1959, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2004, 1776, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                                <div class=""btn-group col-md-2 col-xs-12"">
                                    <button id=""btn-search"" class=""btn blue"">
                                        <i class=""icon-magnifier""></i>
                                    </button>

                                    <button id=""btn-unsearch"" class=""btn blue-chambray"">
                                        <i class=""fa fa-undo""></i>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""table-responsive col-md-12"">
                    <table class=""table table-bordered table-hover table-striped table-responsive"">
                        <thead>
                            <tr class=""text-center"">
                                <td>STT</td>
");
            WriteLiteral(@"                                <td>Ng??y t???o</td>
                                <td >T??n s???n ph???m</td>
                                <td >Danh m???c</td>
                                <td >Gi??</td>
                                <td width=""10%"">H??nh ???nh</td>
                                <td>Tr???ng th??i</td>
                                <td width=""15%"">T??c v???</td>
                            </tr>
                        </thead>
                        <tbody id=""table-content"">
                        </tbody>
                    </table>
                    <div class=""pagination"" id=""pagination"">

                    </div>
                </div>

            </div>



        </div>

    </div>
</div>

");
            EndContext();
            BeginContext(3797, 28, true);
            WriteLiteral("\r\n<div class=\"modal-area\">\r\n");
            EndContext();
            BeginContext(3853, 462, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""modal-add"" tabindex=""-1"" role=""columnheader"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                    <h4 class=""modal-title"">Th??m m???i, c???p nh???t ??a ph????ng ti???n </h4>

                </div>
                ");
            EndContext();
            BeginContext(4315, 3017, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9271b1b35a704520affba3e5b7d576f8", async() => {
                BeginContext(4354, 586, true);
                WriteLiteral(@"
                    <p hidden id=""hid-id""></p>
                    <div class=""form-group col-md-6"">
                        <label for=""txt-ProductName"">T??n s???n ph???m</label>
                        <input type=""text"" class=""form-control"" id=""txt-ProductName"" name=""ProductName"" style=""color:mediumvioletred"">
                    </div>
                    <div class=""form-group col-md-6"">
                        <label for=""select-Status"">Tr???ng th??i</label>
                        <select id=""select-Status"" class=""form-control"" name=""Status"">
                            ");
                EndContext();
                BeginContext(4940, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb4ee6687de64b71aab629ee00cef67c", async() => {
                    BeginContext(4957, 15, true);
                    WriteLiteral("Ch???n tr???ng th??i");
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
                BeginContext(4981, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(5011, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d28db632794dc282bccdb12e070e44", async() => {
                    BeginContext(5029, 16, true);
                    WriteLiteral("S???n ph???m n???i b???t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                BeginContext(5054, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(5084, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b80542c2d7422bbc68aa73b341d8b6", async() => {
                    BeginContext(5102, 15, true);
                    WriteLiteral("S???n ph???m th?????ng");
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
                BeginContext(5126, 321, true);
                WriteLiteral(@"
                        </select>

                    </div>

                    <div class=""form-group col-md-6"">
                        <label for=""select-CategoryId"">Danh m???c</label>
                        <select id=""select-CategoryId"" class=""form-control"" name=""CategoryId"">
                            ");
                EndContext();
                BeginContext(5447, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7732efa6b64e74ac57ce825da88144", async() => {
                    BeginContext(5464, 22, true);
                    WriteLiteral("Ch???n danh m???c s???n ph???m");
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
                BeginContext(5495, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 123 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(5586, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(5618, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d248b029acb4953960bf418a257ac46", async() => {
                    BeginContext(5652, 17, false);
#line 125 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                                            Write(item.CategoryName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 125 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                                   WriteLiteral(item.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5678, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 126 "D:\Project_NetCore_2020\Project\cuatiemthanhnhung\WebAdmin\Views\Product\Product.cshtml"
                            }

#line default
#line hidden
                BeginContext(5711, 1614, true);
                WriteLiteral(@"
                        </select>
                    </div>


                    <div class=""form-group col-md-6"">
                        <label for=""txt-SeoTittle"">Ti??u ????? Seo</label>
                        <input type=""text"" class=""form-control"" id=""txt-SeoTittle"" name=""SeoTittle"">
                    </div>
                    <div class=""form-group col-md-6"">
                        <label for=""txt-Image"">H??nh ???nh</label>
                        <input type=""text"" class=""form-control"" id=""txt-Image"" name=""Image"">
                    </div>

                    <div class=""form-group col-md-6"">
                        <label for=""txt-Price"">Gi?? s???n ph???m</label>
                        <input type=""number"" class=""form-control"" id=""txt-Price"" name=""Price"">
                    </div>
                    <div class=""form-group col-md-12"">
                        <label for=""txt-Summary"">T??m t???t</label>
                        <textarea class=""form-control"" id=""txt-Summary"" name=""Summar");
                WriteLiteral(@"y""></textarea>
                    </div>
                    <div class=""form-group col-md-12"">
                        <label for=""txt-SeoDescription"">M?? t??? Seo</label>
                        <textarea class=""form-control"" id=""txt-SeoDescription"" name=""SeoDescription""></textarea>
                    </div>
                    <div class=""form-group col-md-12"">
                        <label for=""txt-Detail"">Chi ti???t s???n ph???m</label>
                        <textarea class=""form-control"" id=""txt-Detail"" name=""Detail""></textarea>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7332, 308, true);
            WriteLiteral(@"
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn default"" data-dismiss=""modal"">????ng</button>
                    <button type=""button"" class=""btn blue"" id=""btn-save"">C???p nh???t</button>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
            BeginContext(7677, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(7705, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7711, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0da157706934ffa96934c50dd773401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7750, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(7755, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObject.ValueObjects.VCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
