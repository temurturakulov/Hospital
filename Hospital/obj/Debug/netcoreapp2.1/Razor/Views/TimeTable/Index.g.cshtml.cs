#pragma checksum "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1cfe533f091b7f72dbca1d5351894c10442b4b1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cfe533f091b7f72dbca1d5351894c10442b4b1", @"/Views/TimeTable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hospital.Models.TimeTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TableCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TimeTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(224, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(231, 17, false);
#line 9 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
 if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
{

#line default
#line hidden
            BeginContext(317, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(324, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42bb03e9c40e4121b41667f49ccce37c", async() => {
                BeginContext(379, 19, true);
                WriteLiteral("Добавить расписание");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(402, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(410, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(414, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a1d50ef14bc46d198e7f65895d2733d", async() => {
                BeginContext(485, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
         foreach (var table in Model)
        {

#line default
#line hidden
                BeginContext(537, 16, true);
                WriteLiteral("            <td>");
                EndContext();
                BeginContext(554, 30, false);
#line 18 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.DoctorId.UserId.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(584, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 19 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(602, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"

}

#line default
#line hidden
            BeginContext(622, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(625, 18, false);
#line 25 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(643, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(646, 22, false);
#line 26 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(668, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            BeginContext(672, 39, false);
#line 27 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.HasClaim(ClaimTypes.Role, "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(711, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            BeginContext(715, 21, false);
#line 28 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("User"));

#line default
#line hidden
            EndContext();
            BeginContext(736, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            BeginContext(740, 23, false);
#line 29 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
Write(User.IsInRole("Doctor"));

#line default
#line hidden
            EndContext();
            BeginContext(763, 317, true);
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
#line 44 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
     foreach (var table in Model)
    {

#line default
#line hidden
            BeginContext(1122, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1153, 31, false);
#line 47 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.DoctorId.UserId.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1208, 32, false);
#line 48 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.DoctorId.UserId.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1264, 30, false);
#line 49 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.DoctorId.UserId.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
            BeginContext(1318, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1349, 31, false);
#line 53 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.DoctorId.SpecialtyId.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1433, 12, false);
#line 56 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.Monday);

#line default
#line hidden
            EndContext();
            BeginContext(1445, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1498, 13, false);
#line 59 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.Tuesday);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1564, 14, false);
#line 62 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.Thirsday);

#line default
#line hidden
            EndContext();
            BeginContext(1578, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1631, 15, false);
#line 65 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.Wednesday);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1699, 12, false);
#line 68 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
           Write(table.Friday);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\silve\source\repos\Hospital\Hospital\Views\TimeTable\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1740, 9, true);
            WriteLiteral("</table> ");
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
