#pragma checksum "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\Shared\_HelpLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db51961401d7e90ee493eec866628f5d95f42a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Help_Views_Shared__HelpLayout), @"mvc.1.0.view", @"/Areas/Help/Views/Shared/_HelpLayout.cshtml")]
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
#line 1 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\_ViewImports.cshtml"
using TutorialApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db51961401d7e90ee493eec866628f5d95f42a9d", @"/Areas/Help/Views/Shared/_HelpLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d801d411f860ccbb41ec02f4694e116a6273d9c", @"/Areas/Help/Views/_ViewImports.cshtml")]
    public class Areas_Help_Views_Shared__HelpLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\Shared\_HelpLayout.cshtml"
   
    Layout = "_Layout";

    string ActiveNav(string controller) 
    {
        string currentController = ViewContext.RouteData.Values["Controller"].ToString();
        return(controller == currentController) ? "active" : "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <h2>Help Page</h2>\r\n");
            }
            );
            WriteLiteral("<nav class=\"nav nav-tabs mt-4 mb-4\">\r\n    <a class=\"nav-item nav-link\" ");
#nullable restore
#line 15 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\Shared\_HelpLayout.cshtml"
                            Write(ActiveNav("Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" asp-controller=\"Home\" asp-action=\"Index\" asp-area=\"Help\">Home</a>\r\n    <a class=\"nav-item nav-link\" ");
#nullable restore
#line 16 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\Shared\_HelpLayout.cshtml"
                            Write(ActiveNav("Tutorial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  asp-controller=\"Tutorial\" asp-action=\"Index\" asp-area=\"Help\" asp-route-id=\"Page1\">Tutorial</a>\r\n</nav>\r\n\r\n");
#nullable restore
#line 19 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TutorialApplication\TutorialApplication\TutorialApplication\Areas\Help\Views\Shared\_HelpLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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