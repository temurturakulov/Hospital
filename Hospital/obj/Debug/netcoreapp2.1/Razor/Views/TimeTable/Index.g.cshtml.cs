#pragma checksum "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9c0c085dd636e43213664d18707de0d77cc850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeTable_Index), @"mvc.1.0.view", @"/Views/TimeTable/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimeTable/Index.cshtml", typeof(AspNetCore.Views_TimeTable_Index))]
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
#line 1 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9c0c085dd636e43213664d18707de0d77cc850", @"/Views/TimeTable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hospital.Models.TimeTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TimeTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Specialty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TableCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
  
    ViewData["Title"] = "Расписание работы";

#line default
#line hidden
            BeginContext(224, 436, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78977eefc662427e911fb7ff43d083b6", async() => {
                BeginContext(230, 423, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(660, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(662, 3858, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d357ee0925e42488e3954394e6b9ecf", async() => {
                BeginContext(668, 73, true);
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg navbar-dark bg-dark\">\r\n        ");
                EndContext();
                BeginContext(741, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120f0d0cf13e4b7a98d116c1536eb7f0", async() => {
                    BeginContext(806, 7, true);
                    WriteLiteral("Главная");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(817, 428, true);
                WriteLiteral(@"
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbar1"" aria-controls=""navbar1"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbar1"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    ");
                EndContext();
                BeginContext(1245, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d775e85884404700adda053125c0ebc4", async() => {
                    BeginContext(1311, 55, true);
                    WriteLiteral("Расписание врачей<span class=\"sr-only\">(current)</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1370, 93, true);
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item active\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1463, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6a2e57676d4aad93cd5547accf6caf", async() => {
                    BeginContext(1525, 4, true);
                    WriteLiteral("Роли");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1533, 93, true);
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item active\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1626, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1251b0168ea4f299ac79eb93e2a1a37", async() => {
                    BeginContext(1692, 19, true);
                    WriteLiteral("Специальности врача");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1715, 93, true);
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item active\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1808, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874b38a7ab1c40a3af5919ed1c642734", async() => {
                    BeginContext(1870, 12, true);
                    WriteLiteral("Пользователи");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1886, 93, true);
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item active\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1979, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4b2ddf6d604c339385b472dc5a194a", async() => {
                    BeginContext(2042, 7, true);
                    WriteLiteral("Доктора");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2053, 737, true);
                WriteLiteral(@"
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown1"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Dropdown</a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown1"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </li>
            </ul>

        </div>
    </nav>
    <h2>");
                EndContext();
                BeginContext(2791, 17, false);
#line 54 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(2808, 9, true);
                WriteLiteral("</h2>\r\n\r\n");
                EndContext();
#line 56 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
     if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
    {

#line default
#line hidden
                BeginContext(2885, 11, true);
                WriteLiteral("        <p>");
                EndContext();
                BeginContext(2896, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2874b8d6141e4f19acb85c827741ea6b", async() => {
                    BeginContext(2951, 19, true);
                    WriteLiteral("Добавить расписание");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2974, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(2982, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2990, 216, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16e3bdbae0c14a70890dd481dc3c2f88", async() => {
                    BeginContext(3061, 44, true);
                    WriteLiteral("\r\n\r\n            <input type=\"text\" name=\"Id\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3105, "\"", 3126, 1);
#line 62 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
WriteAttributeValue("", 3113, Context.User, 3113, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3127, 72, true);
                    WriteLiteral(" hidden>\r\n            <input type=\"submit\" value=\"send\" />\r\n\r\n\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3206, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"

    }

#line default
#line hidden
                BeginContext(3217, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3224, 18, false);
#line 70 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3242, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3249, 22, false);
#line 71 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3271, 7, true);
                WriteLiteral(";\r\n    ");
                EndContext();
                BeginContext(3279, 39, false);
#line 72 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.HasClaim(ClaimTypes.Role, "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3318, 7, true);
                WriteLiteral(";\r\n    ");
                EndContext();
                BeginContext(3326, 21, false);
#line 73 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("User"));

#line default
#line hidden
                EndContext();
                BeginContext(3347, 7, true);
                WriteLiteral(";\r\n    ");
                EndContext();
                BeginContext(3355, 23, false);
#line 74 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("Doctor"));

#line default
#line hidden
                EndContext();
                BeginContext(3378, 357, true);
                WriteLiteral(@";


    <table class=""table"" align=""center"" border=""1"" cellpadding=""4"">
        <thead>
            <tr><th>Специальность</th>
            <tr><th>ФИО</th>
            <tr><th>Понедельник</th>
            <tr><th>Вторник</th>
            <tr><th>Среда</th>
            <tr><th>Четверг</th>
            <tr><th>Пятница</th>
        </thead>


");
                EndContext();
#line 89 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
         foreach (var table in Model)
        {

#line default
#line hidden
                BeginContext(3785, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(3824, 31, false);
#line 92 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.DoctorId.UserId.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(3855, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(3883, 32, false);
#line 93 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.DoctorId.UserId.SecondName);

#line default
#line hidden
                EndContext();
                BeginContext(3915, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(3943, 30, false);
#line 94 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.DoctorId.UserId.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(3973, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
                BeginContext(4001, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4040, 31, false);
#line 98 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.DoctorId.SpecialtyId.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4071, 64, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4136, 12, false);
#line 101 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.Monday);

#line default
#line hidden
                EndContext();
                BeginContext(4148, 64, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4213, 13, false);
#line 104 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.Tuesday);

#line default
#line hidden
                EndContext();
                BeginContext(4226, 64, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4291, 14, false);
#line 107 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.Thirsday);

#line default
#line hidden
                EndContext();
                BeginContext(4305, 64, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4370, 15, false);
#line 110 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.Wednesday);

#line default
#line hidden
                EndContext();
                BeginContext(4385, 64, true);
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4450, 12, false);
#line 113 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
               Write(table.Friday);

#line default
#line hidden
                EndContext();
                BeginContext(4462, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 115 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(4499, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hospital.Models.TimeTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
