#pragma checksum "C:\Users\Abbas\Downloads\AppWithTemplate\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d42dfa96479c1ba6a59b96638da030e858d203e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\Abbas\Downloads\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abbas\Downloads\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abbas\Downloads\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abbas\Downloads\AppWithTemplate\Views\_ViewImports.cshtml"
using AppWithTemplate.AppCode.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d42dfa96479c1ba6a59b96638da030e858d203e", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7607f547d554f4788da46f14860a4e636228fd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abbas\Downloads\AppWithTemplate\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Organi Shop</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <span>Shop</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-5"">
                <div class=""sidebar"">
                    <div class=""sidebar-item"">
                        <h4>Department</h4>
                        <ul>
                            <li><a href=""#"">Fresh Meat</a></li>
                            <li><a href=""#"">Vegetables</a></li>
                            <li><a href=""#"">Fruit ");
            WriteLiteral(@"& Nut Gifts</a></li>
                            <li><a href=""#"">Fresh Berries</a></li>
                            <li><a href=""#"">Ocean Foods</a></li>
                            <li><a href=""#"">Butter & Eggs</a></li>
                            <li><a href=""#"">Fastfood</a></li>
                            <li><a href=""#"">Fresh Onion</a></li>
                            <li><a href=""#"">Papayaya & Crisps</a></li>
                            <li><a href=""#"">Oatmeal</a></li>
                        </ul>
                    </div>
                    <div class=""sidebar-item"">
                        <h4>Price</h4>
                        <div class=""price-range-wrap"">
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content"" data-min=""10"" data-max=""540"">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui");
            WriteLiteral(@"-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
                            <div class=""range-slider"">
                                <div class=""price-input"">
                                    <input type=""text"" id=""minamount"">
                                    <input type=""text"" id=""maxamount"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""sidebar-item sidebar-item-color--option"">
                        <h4>Colors</h4>
                        <div class=""sidebar-item-color sidebar-item-color--white"">
                            <label for=""white"">
                                White
                                <input type=""radio"" id=""white"">
                            </label>
                        </div>
               ");
            WriteLiteral(@"         <div class=""sidebar-item-color sidebar-item-color--gray"">
                            <label for=""gray"">
                                Gray
                                <input type=""radio"" id=""gray"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--red"">
                            <label for=""red"">
                                Red
                                <input type=""radio"" id=""red"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--black"">
                            <label for=""black"">
                                Black
                                <input type=""radio"" id=""black"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--blue"">
                            <label for=""blue"">");
            WriteLiteral(@"
                                Blue
                                <input type=""radio"" id=""blue"">
                            </label>
                        </div>
                        <div class=""sidebar-item-color sidebar-item-color--green"">
                            <label for=""green"">
                                Green
                                <input type=""radio"" id=""green"">
                            </label>
                        </div>
                    </div>
                    <div class=""sidebar-item"">
                        <h4>Popular Size</h4>
                        <div class=""sidebar-item-size"">
                            <label for=""large"">
                                Large
                                <input type=""radio"" id=""large"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""medium"">
                                Me");
            WriteLiteral(@"dium
                                <input type=""radio"" id=""medium"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""small"">
                                Small
                                <input type=""radio"" id=""small"">
                            </label>
                        </div>
                        <div class=""sidebar-item-size"">
                            <label for=""tiny"">
                                Tiny
                                <input type=""radio"" id=""tiny"">
                            </label>
                        </div>
                    </div>
                    <div class=""sidebar-item"">
                        <div class=""latest-product-text"">
                            <h4>Latest Products</h4>
                            <div class=""latest-product-slider owl-carousel"">
                                <div class=""latest-prdouct");
            WriteLiteral(@"-slider-item"">
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6480, "\"", 6486, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7092, "\"", 7098, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7704, "\"", 7710, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                </div>
                                <div class=""latest-prdouct-slider-item"">
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8430, "\"", 8436, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9042, "\"", 9048, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product-item"">
                                        <div class=""latest-product-item-pic"">
                                            <img src=""assets/img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9654, "\"", 9660, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product-item-text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 col-md-7"">
                <div class=""product-discount"">
                    <div class=""section-title product-discount-title"">
                        <h2>Sale Off</h2>
                    </div>
                    <div class=""row"">
                        <div class=""product-discount-slider owl-carousel"">
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
             ");
            WriteLiteral(@"                       <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-1.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
           ");
            WriteLiteral(@"                         </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-2.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                    ");
            WriteLiteral(@"                    <span>Vegetables</span>
                                        <h5><a href=""#"">Vegetables’package</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-3.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li>");
            WriteLiteral(@"<a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Mixed Fruitss</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-4.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
   ");
            WriteLiteral(@"                                         <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-disco");
            WriteLiteral(@"unt-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-5.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
                                        <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
               ");
            WriteLiteral(@"                 </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""product-discount-item"">
                                    <div class=""product-discount-item-pic set-bg"" data-setbg=""assets/img/product/discount/pd-6.jpg"">
                                        <div class=""product-discount-percent"">-20%</div>
                                        <ul class=""product-item-pic-hover"">
                                            <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""product-discount-item-text"">
                                        <span>Dried Fruit</span>
  ");
            WriteLiteral(@"                                      <h5><a href=""#"">Raisin’n’nuts</a></h5>
                                        <div class=""product-item-price"">$30.00 <span>$36.00</span></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""filter-item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-5"">
                            <div class=""filter-sort"">
                                <span>Sort By</span>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d42dfa96479c1ba6a59b96638da030e858d203e24045", async() => {
                WriteLiteral("Default");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d42dfa96479c1ba6a59b96638da030e858d203e25242", async() => {
                WriteLiteral("Default");
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
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""filter-found"">
                                <h6><span>16</span> Products found</h6>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-3"">
                            <div class=""filter-option"">
                                <span class=""icon_grid-2x2""></span>
                                <span class=""icon_ul""></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                   
                </div>
                <div class=""product-pagination"">
                    <a href=""#"">1</a>
                    <a href=""#"">2</a>
                    <a href=""#"">3</a>
                    <a href=""#""><i class=""fa");
            WriteLiteral(" fa-long-arrow-right\"></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
