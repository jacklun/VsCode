#pragma checksum "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9452607e64e0d52779888bfb3453e99709419cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_ProductDetails_Index), @"mvc.1.0.view", @"/Views/Home/Components/ProductDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/ProductDetails/Index.cshtml", typeof(AspNetCore.Views_Home_Components_ProductDetails_Index))]
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
#line 1 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\ProductDetails\Index.cshtml"
using WebEditor.ViewComponents;

#line default
#line hidden
#line 2 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\ProductDetails\Index.cshtml"
using WebEditor.ViewModels;

#line default
#line hidden
#line 3 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\ProductDetails\Index.cshtml"
using System.Collections;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9452607e64e0d52779888bfb3453e99709419cb1", @"/Views/Home/Components/ProductDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d171ce1015461db1adf8362fcb9ea95002117292", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 6 "C:\MyProjects\VsCode-Insiders\Workspaces\WebEditor\Views\Home\Components\ProductDetails\Index.cshtml"
      
        /*
        foreach(DictionaryEntry item in Model.Propertys)
        {
            <li>[@item.Key]: @item.Value</li>
        }
        */
    

#line default
#line hidden
            BeginContext(283, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
