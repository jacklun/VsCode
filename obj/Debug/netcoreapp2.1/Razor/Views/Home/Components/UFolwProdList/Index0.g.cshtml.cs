#pragma checksum "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c7f7b5c0afced150ab07d55d604327532608cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_UFolwProdList_Index0), @"mvc.1.0.view", @"/Views/Home/Components/UFolwProdList/Index0.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/UFolwProdList/Index0.cshtml", typeof(AspNetCore.Views_Home_Components_UFolwProdList_Index0))]
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
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\_ViewImports.cshtml"
using WebEditor;

#line default
#line hidden
#line 2 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\_ViewImports.cshtml"
using WebEditor.Models;

#line default
#line hidden
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
using WebEditor.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c7f7b5c0afced150ab07d55d604327532608cf7", @"/Views/Home/Components/UFolwProdList/Index0.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d171ce1015461db1adf8362fcb9ea95002117292", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_UFolwProdList_Index0 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/iboot.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 5 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
     foreach (Product item in Model)
    {

#line default
#line hidden
            BeginContext(117, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 131, "\"", 171, 2);
            WriteAttributeValue("", 138, "/Products/ProductList?id=", 138, 25, true);
#line 7 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
WriteAttributeValue("", 163, item.id, 163, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(172, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(175, 9, false);
#line 7 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
                                                    Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(184, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(188, 21, false);
#line 7 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
                                                                 Write(ViewBag.UserSessionId);

#line default
#line hidden
            EndContext();
            BeginContext(209, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 8 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
    }

#line default
#line hidden
            BeginContext(228, 156, true);
            WriteLiteral("</div>\r\n<div comment=\"超出则滚动条style=\'overflow-y: scroll;\'\">\r\n    <div class=\"iboot-controller clear\"></div>\r\n</div>\r\n\r\n\r\n<button id=\"loadmore\">加载更多</button>\r\n");
            EndContext();
            BeginContext(384, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbad2b158674443a8a5cece3bc8d3a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(439, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(441, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252eb291012f4970955c3b4477dc325d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(479, 161, true);
            WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        var num=6;\r\n        var base_height = 200;\r\n        \r\n        function getImgList(len) {\r\n            var random = [];\r\n");
            EndContext();
#line 25 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
             foreach (Product item in Model)
            {
                

#line default
#line hidden
            BeginContext(723, 19, true);
            WriteLiteral("random.push({src: \'");
            EndContext();
            BeginContext(743, 14, false);
#line 27 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
                                    Write(item.image_url);

#line default
#line hidden
            EndContext();
            BeginContext(757, 4, true);
            WriteLiteral("\'});");
            EndContext();
#line 27 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\UFolwProdList\Index0.cshtml"
                                                                   
            }

#line default
#line hidden
            BeginContext(785, 1591, true);
            WriteLiteral(@"            /*
            random.push({src: '/images/Products/banner1.png'})
            random.push({src: '/images/Products/banner2.png'})
            random.push({src: '/images/Products/banner3.png'})
            random.push({src: '/images/Products/banner1.png'})
            random.push({src: '/images/Products/banner2.png'})
            random.push({src: '/images/Products/banner3.png'})
            random.push({src: '/images/Products/banner1.png'})
            random.push({src: '/images/Products/banner2.png'})
            random.push({src: '/images/Products/banner3.png'})
            shuffle(random)
            for(var i=0; i<len; i++) {
                //random.push({src: 'https://picsum.photos/' + Srr(100, 900) + '/' + Srr(100, 900)})
                //random.push({src: '/images/Products/banner1.png'})
            }
            */
            alert(random.length);
            return random
        }
        var iboot = new Iboot($('.iboot-controller'), {
            list: getImgList(n");
            WriteLiteral(@"um),
            baseHeight: base_height,
            template: function(dom){
                dom.addClass('some')
                return dom
            },
            beforeLoad: function () {
                console.log('beforeLoad')
            },
            afterLoad: function () {
                console.log('afterLoad')
            }
        })
        $(window).resize(function () {
            iboot.resize()
        })
        $('#loadmore').click(function () {
            iboot.loadMore(getImgList(num))
        })
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591