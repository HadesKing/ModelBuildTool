#pragma checksum "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Pages\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d7988035e8e1d69a07ef562e52f9172f5f78fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Manager.Pages.Shared.Pages_Shared__MenuPartial), @"mvc.1.0.view", @"/Pages/Shared/_MenuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_MenuPartial.cshtml", typeof(Manager.Pages.Shared.Pages_Shared__MenuPartial))]
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
#line 1 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Pages\_ViewImports.cshtml"
using Manager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d7988035e8e1d69a07ef562e52f9172f5f78fc", @"/Pages/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8f2abfe1dd6d759b31272666a4f95c62aa2c00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 605, true);
            WriteLiteral(@"
    <ul class=""sidebar-menu"" data-widget=""tree"">
        <li class=""header"">Menu</li>
        <!-- Optionally, you can add icons to the links -->
        <li class=""treeview active"">
            <a href=""#"">
                <i class=""fa fa-edit""></i> <span>Code Builder</span>
                <span class=""pull-right-container"">
                    <i class=""fa fa-angle-left pull-right""></i>
                </span>
            </a>
            <ul class=""treeview-menu"">
                <li class=""active""><a href=""ModelBuilder/Index""><i class=""fa fa-circle-o""></i> Model Builder</a></li>
");
            EndContext();
            BeginContext(804, 34, true);
            WriteLiteral("            </ul>\r\n        </li>\r\n");
            EndContext();
            BeginContext(1484, 9, true);
            WriteLiteral("    </ul>");
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
