#pragma checksum "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cca215b6be65e96d3a3787d925590165b316cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cca215b6be65e96d3a3787d925590165b316cf4", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(89, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(97, 18, false);
#line 8 "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml"
  Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(115, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(123, 131, true);
            WriteLiteral("    <form method=\"post\" asp-controller=\"Account\" asp-action=\"LogOff\">\r\n        <input type=\"submit\" value=\"Выход\" />\r\n    </form>\r\n");
            EndContext();
#line 13 "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(266, 132, true);
            WriteLiteral("    <a asp-controller=\"Account\" asp-action=\"Login\">Вход</a>\r\n    <a asp-controller=\"Account\" asp-action=\"Register\">Регистрация</a>\r\n");
            EndContext();
#line 18 "C:\Users\silve\source\repos\Hospital\Hospital\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
