#pragma checksum "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137e6e6c8e39cc3504dd30db39b49f3735247135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137e6e6c8e39cc3504dd30db39b49f3735247135", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a197cb20f5317ca5b21caf43196a3b59434a2cc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Contact Us</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <span>Contact Us</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""contact spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-3 col-sm-6 text-center"">
                <div class=""contact-widget"">
                    <span class=""icon_phone""></span>
                    <h4>Phone</h4>
                    <p>+01-3-8888-6868</p>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 text-center"">
                <div cla");
            WriteLiteral(@"ss=""contact-widget"">
                    <span class=""icon_pin_alt""></span>
                    <h4>Address</h4>
                    <p>60-49 Road 11378 New York</p>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 text-center"">
                <div class=""contact-widget"">
                    <span class=""icon_clock_alt""></span>
                    <h4>Open time</h4>
                    <p>10:00 am to 23:00 pm</p>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 text-center"">
                <div class=""contact-widget"">
                    <span class=""icon_mail_alt""></span>
                    <h4>Email</h4>
                    <p><a href=""https://colorlib.com/cdn-cgi/l/email-protection"" class=""-cf_email-"" data-cfemail=""462e232a2a290625292a29342a2f246825292b"">[email&#160;protected]</a></p>
                </div>
            </div>
        </div>
    </div>
</section>


<div class=""map"">
    <ifra");
            WriteLiteral(@"me src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d49116.39176087041!2d-86.41867791216099!3d39.69977417971648!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x886ca48c841038a1%3A0x70cfba96bf847f0!2sPlainfield%2C%20IN%2C%20USA!5e0!3m2!1sen!2sbd!4v1586106673811!5m2!1sen!2sbd"" height=""500"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2426, "\"", 2444, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
    <div class=""map-inside"">
        <i class=""icon_pin""></i>
        <div class=""inside-widget"">
            <h4>New York</h4>
            <ul>
                <li>Phone: +12-345-6789</li>
                <li>Add: 16 Creek Ave. Farmingdale, NY</li>
            </ul>
        </div>
    </div>
</div>


<div class=""contact-form spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""contact-form-title"">
                    <h2>Leave Message</h2>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137e6e6c8e39cc3504dd30db39b49f37352471358649", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
             if (!string.IsNullOrWhiteSpace(ViewBag.Message))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-6 col-md-6\">\r\n                        <div class=\"alert alert-info\">\r\n                            ");
#nullable restore
#line 90 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
                       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 94 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-6 col-md-6\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "137e6e6c8e39cc3504dd30db39b49f373524713510064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 97 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GivenName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "137e6e6c8e39cc3504dd30db39b49f373524713511754", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 100 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-12 text-center\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137e6e6c8e39cc3504dd30db39b49f373524713513445", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 103 "C:\Users\User\source\repos\P408\IntroWebMvcSolution\AppWithTemplate\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"site-btn\">SEND MESSAGE</button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591