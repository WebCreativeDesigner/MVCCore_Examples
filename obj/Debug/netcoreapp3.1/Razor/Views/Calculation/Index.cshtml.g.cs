#pragma checksum "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296ce64f6d1398bf05803855f93df05569c27f1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculation_Index), @"mvc.1.0.view", @"/Views/Calculation/Index.cshtml")]
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
#line 1 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\_ViewImports.cshtml"
using MVCCore_Examples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\_ViewImports.cshtml"
using MVCCore_Examples.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\_ViewImports.cshtml"
using MVCCore_Examples.Models.NthFibonacci;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296ce64f6d1398bf05803855f93df05569c27f1a", @"/Views/Calculation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14598adeeb44da5b8951d847046a300c6a861bcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalculatedDataModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- This controller is used the IEnumerable<CalculatedDataModel which was created by the interface and the repository -->\r\n");
#nullable restore
#line 3 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
  
    ViewData["Title"] = "Calculation Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">Calculation building Web apps with ASP.NET Core</a>.</p>\r\n    <div>");
#nullable restore
#line 10 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
    Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n    -->\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296ce64f6d1398bf05803855f93df05569c27f1a4466", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296ce64f6d1398bf05803855f93df05569c27f1a5497", async() => {
                WriteLiteral(@"
    <div id=""divCalculationSummary"" style=""display:none; border:dotted"">
        Calculation Summary is: <br />
        Y = (m*Specific Raw data value x) + C <br />
        A = 1 / Specific Raw Data value x <br />
        B = A + Y <br />
        b = B / RawData X array.Count() <br />
        Calculated = X + b <br />
    </div>
    <center>
        <button id=""btnShowHide"" onclick=""ShowHide()"">Show Calculation</button>
        <input type=""button"" value=""Export to Excel""");
                BeginWriteAttribute("onclick", " onclick=\"", 1046, "\"", 1107, 3);
                WriteAttributeValue("", 1056, "location.href=\'", 1056, 15, true);
#nullable restore
#line 29 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
WriteAttributeValue("", 1071, Url.Action("Excel", "Calculation"), 1071, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1106, "\'", 1106, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"button\" value=\"Export to CSV\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1163, "\"", 1222, 3);
                WriteAttributeValue("", 1173, "location.href=\'", 1173, 15, true);
#nullable restore
#line 30 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
WriteAttributeValue("", 1188, Url.Action("CSV", "Calculation"), 1188, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1221, "\'", 1221, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />
    </center>
    <br />
    <br />

    <table id=""example"" class=""table table-bordered table-responsive table-hover"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">RawData</th>
            <th scope=""col"">m</th>
            <th scope=""col"">c</th>
            <th scope=""col"">Calculated</th>
        </tr>
        <tbody>
");
#nullable restore
#line 44 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
             foreach (var element in Model)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <!-- <p>Html.DisplayFor(m => element)</p> -->\r\n                    <td>");
#nullable restore
#line 49 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
                   Write(element.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
                   Write(element.RawData);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
                   Write(element.m);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
                   Write(element.c);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
                   Write(element.Calculated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\Calculation\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CalculatedDataModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
