#pragma checksum "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd90bdf990cf190c7ea4db713f4626ab40163fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd90bdf990cf190c7ea4db713f4626ab40163fab", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a197cb20f5317ca5b21caf43196a3b59434a2cc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""blog-details-hero set-bg"" data-setbg=""assets/img/blog/details/details-hero.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""blog-details-hero-text"">
                    <h2>The Moment You Need To Remove Garlic From The Menu</h2>
                    <ul>
                        <li>By Michael Scofield</li>
                        <li>January 14, 2019</li>
                        <li>8 Comments</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""blog-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5 order-md-1 order-2"">
                <div class=""blog-sidebar"">
                    <div class=""blog-sidebar-search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd90bdf990cf190c7ea4db713f4626ab40163fab4996", async() => {
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
            BeginWriteAttribute("alt", " alt=\"", 2088, "\"", 2094, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 2675, "\"", 2681, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 3260, "\"", 3266, 0);
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
            WriteLiteral("ass=\"col-lg-8 col-md-7 order-md-1 order-1\">\r\n                <div class=\"blog-details-text\">\r\n                    <img src=\"assets/img/blog/details/details-pic.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4455, "\"", 4461, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p>
                        Sed porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet
                        dui. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Mauris blandit
                        aliquet elit, eget tincidunt nibh pulvinar a. Vivamus magna justo, lacinia eget consectetur
                        sed, convallis at tellus. Sed porttitor lectus nibh. Donec sollicitudin molestie malesuada.
                        Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Proin eget tortor risus.
                        Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis
                        quis ac lectus. Donec sollicitudin molestie malesuada. Nulla quis lorem ut libero malesuada
                        feugiat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem.
                    </p>
                    <h3>
                        The corn");
            WriteLiteral(@"er window forms a place within a place that is a resting point within the large
                        space.
                    </h3>
                    <p>
                        The study area is located at the back with a view of the vast nature. Together with the other
                        buildings, a congruent story has been managed in which the whole has a reinforcing effect on
                        the components. The use of materials seeks connection to the main house, the adjacent
                        stables
                    </p>
                </div>
                <div class=""blog-details-content"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""blog-details-author"">
                                <div class=""blog-details-author-pic"">
                                    <img src=""assets/img/blog/details/details-author.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6444, "\"", 6450, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog-details-author-text"">
                                    <h6>Michael Scofield</h6>
                                    <span>Admin</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""blog-details-widget"">
                                <ul>
                                    <li><span>Categories:</span> Food</li>
                                    <li><span>Tags:</span> All, Trending, Cooking, Healthy Food, Life Style</li>
                                </ul>
                                <div class=""blog-details-social"">
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-google");
            WriteLiteral(@"-plus""></i></a>
                                    <a href=""#""><i class=""fa fa-linkedin""></i></a>
                                    <a href=""#""><i class=""fa fa-envelope""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""related-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title related-blog-title"">
                    <h2>Post You May Like</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8418, "\"", 8424, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9198, "\"", 9204, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog-item"">
                    <div class=""blog-item-pic"">
                        <img src=""assets/img/blog/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9980, "\"", 9986, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-item-text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
