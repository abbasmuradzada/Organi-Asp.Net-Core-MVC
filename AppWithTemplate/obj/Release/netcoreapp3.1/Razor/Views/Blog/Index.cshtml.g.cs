#pragma checksum "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12166e3576c0b3ab752224485714efda5c9ef06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12166e3576c0b3ab752224485714efda5c9ef06c", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a197cb20f5317ca5b21caf43196a3b59434a2cc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Paylaşımlar";

    //Model.Remove(null);



#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Blog</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <span>Blog</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5"">
                <div class=""blog-sidebar"">
                    <div class=""blog-sidebar-search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12166e3576c0b3ab752224485714efda5c9ef06c5715", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog-sidebar-item"">
                        <h4>Categories</h4>
                        <ul>
                            <li><a href=""#"">All</a></li>
                            <li><a href=""#"">Beauty (20)</a></li>
                            <li><a href=""#"">Food (5)</a></li>
                            <li><a href=""#"">Life Style (9)</a></li>
                            <li><a href=""#"">Travel (10)</a></li>
                        </ul>
                    </div>
                    <div class=""blog-sidebar-item"">
                        <h4>Recent News</h4>
                        <div class=""blog-sidebar-recent"">
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2049, "\"", 2055, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>09 Kinds Of Vegetables<br /> Protect The Liver</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2636, "\"", 2642, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>Tips You To Balance<br /> Nutrition Meal Day</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog-sidebar-recent-item"">
                                <div class=""blog-sidebar-recent-item-pic"">
                                    <img src=""assets/img/blog/sidebar/sr-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3221, "\"", 3227, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-sidebar-recent-item-text"">
                                    <h6>4 Principles Help You Lose <br />Weight With Vegetables</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""blog-sidebar-item"">
                        <h4>Search By</h4>
                        <div class=""blog-sidebar-item-tags"">
                            <a href=""#"">Apple</a>
                            <a href=""#"">Beauty</a>
                            <a href=""#"">Vegetables</a>
                            <a href=""#"">Fruit</a>
                            <a href=""#"">Healthy Food</a>
                            <a href=""#"">Lifestyle</a>
                        </div>
                    </div>
                </div>
            </div>
            <div cl");
            WriteLiteral("ass=\"col-lg-8 col-md-7\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 97 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                            <div class=\"blog-item\">\r\n                                <div class=\"blog-item-pic\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 4606, "\"", 4643, 2);
            WriteAttributeValue("", 4612, "assets/img/blog/", 4612, 16, true);
#nullable restore
#line 102 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4628, item.PhotoLink, 4628, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4644, "\"", 4650, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"blog-item-text\">\r\n                                    <ul>\r\n                                        <li><i class=\"fa fa-calendar-o\"></i> ");
#nullable restore
#line 106 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                                                                        Write(item.PublishedDate?.ToString("MMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li>\r\n                                    </ul>\r\n                                    <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12166e3576c0b3ab752224485714efda5c9ef06c12738", async() => {
#nullable restore
#line 109 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 111 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                                   Write(Html.Raw(item.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12166e3576c0b3ab752224485714efda5c9ef06c15605", async() => {
                WriteLiteral("\r\n                                        READ MORE\r\n                                        <span class=\"arrow_right\"></span>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 120 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <div class=""col-lg-12"">
                        <div class=""product-pagination blog-pagination"">
                            <a href=""#"">1</a>
                            <a href=""#"">2</a>
                            <a href=""#"">3</a>
                            <a href=""#""><i class=""fa fa-long-arrow-right""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
