#pragma checksum "F:\学习\.Net Core\Asp.Net Core\Code\CodeBuild\CodeBuildSolution\src\Manager\Pages\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e48bd541eb1fac8732f71424a7e9eedcec4e3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Manager.Pages.Shared.Pages_Shared__FooterPartial), @"mvc.1.0.view", @"/Pages/Shared/_FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_FooterPartial.cshtml", typeof(Manager.Pages.Shared.Pages_Shared__FooterPartial))]
namespace Manager.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\学习\.Net Core\Asp.Net Core\Code\CodeBuild\CodeBuildSolution\src\Manager\Pages\_ViewImports.cshtml"
using Manager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e48bd541eb1fac8732f71424a7e9eedcec4e3de", @"/Pages/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8f2abfe1dd6d759b31272666a4f95c62aa2c00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 214, true);
            WriteLiteral("<!-- Main Footer -->\r\n<footer class=\"main-footer\">\r\n    <!-- To the right -->\r\n    <div class=\"pull-right hidden-xs\">\r\n        刘 迪\r\n    </div>\r\n    <!-- Default to the left -->\r\n    <strong>Copyright &copy; 2019 - ");
            EndContext();
            BeginContext(339, 35, false);
#line 12 "F:\学习\.Net Core\Asp.Net Core\Code\CodeBuild\CodeBuildSolution\src\Manager\Pages\Shared\_FooterPartial.cshtml"
                               Write(System.DateTime.Now.Year.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(374, 87, true);
            WriteLiteral(" <a href=\"#\" style=\"display:none;\">Liu Di</a>.</strong> All rights reserved.\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
