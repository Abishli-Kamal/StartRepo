#pragma checksum "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc481f72a1cae3061bc6436ed3e4c3c33cd622be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\_ViewImports.cshtml"
using StarTapBootstarp.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc481f72a1cae3061bc6436ed3e4c3c33cd622be", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b44e488c41734b644e50a7fe1a4b45e7212f9a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc481f72a1cae3061bc6436ed3e4c3c33cd622be4339", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc481f72a1cae3061bc6436ed3e4c3c33cd622be4780", async() => {
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
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <title>Document</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc481f72a1cae3061bc6436ed3e4c3c33cd622be7235", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav>\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-7 mt-3\">\r\n                        <div class=\"logo\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1061, "\"", 1068, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <h2>");
#nullable restore
#line 25 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml"
                               Write(layoutservis.GetDatas().Result.FirstOrDefault(s=>s.Key=="logo").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-5 navtext mt-3\">\r\n                        <ul>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1400, "\"", 1407, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml"
                                      Write(layoutservis.GetDatas().Result.FirstOrDefault(s => s.Key == "PORTFOLIO").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1533, "\"", 1540, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml"
                                      Write(layoutservis.GetDatas().Result.FirstOrDefault(s => s.Key == "ABOUT").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 1662, "\"", 1669, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml"
                                      Write(layoutservis.GetDatas().Result.FirstOrDefault(s => s.Key == "CONTACT").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    ");
#nullable restore
#line 40 "C:\Users\tu7ldxfzy\Desktop\StarTapBootstarp\StarTapBootstarp\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <footer>
        <section id=""footertop"">
            <div class=""conatiner"">
                <div class=""row w-100 justify-content-center "">
                    <div class=""location w-25 mt-5  col-lg-4 "">

                        <div class=""title"">
                            <h2>LOCATION</h2>
                        </div>
                        <div class=""description"">
                            <div>2215 John Daniel Drive</div>
                            <div>Clark, MO 65243</div>
                        </div>

                    </div>
                    <div class=""social w-25  mt-5 col-lg-4 "">
                        <h2>AROUND THE WEB</h2>
                        <div class=""icons d-flex w-50 "">
                            <div class=""icon rounded-circle  border border-light"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 2774, "\"", 2781, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fa-brands fa-facebook mt-3""></i>
                                </a>
                            </div>
                            <div class=""icon rounded-circle  border border-light"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 3057, "\"", 3064, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fa-brands fa-twitter mt-3""></i>
                                </a>
                            </div>
                            <div class=""icon rounded-circle  border border-light"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 3339, "\"", 3346, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fa-brands fa-linkedin mt-3""></i>
                                </a>
                            </div>
                            <div class=""icon rounded-circle border border-light"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 3621, "\"", 3628, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fa-solid fa-basketball mt-3""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""freelancer w-25  mt-5  col-lg-4"">
                        <div class=""title"">
                            <h2>ABOUT FREELANCER</h2>
                        </div>
                        <div class=""info"">
                            Freelance is a free to use, MIT licensed Bootstrap theme created by <a");
                BeginWriteAttribute("href", " href=\"", 4188, "\"", 4195, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                Start
                                Bootstrap .
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""footerends"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""footerend text-center mt-5"">
                        <div class=""info"">
                            <span class=""mt-3"">Copyright ?? Your Website 2022</span>
                        </div>

                    </div>
                </div>
            </div>

        </section>

    </footer>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc481f72a1cae3061bc6436ed3e4c3c33cd622be14165", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LayoutServices layoutservis { get; private set; }
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
