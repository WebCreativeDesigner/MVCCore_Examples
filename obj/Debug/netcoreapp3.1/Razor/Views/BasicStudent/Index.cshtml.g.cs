#pragma checksum "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ab0ff31c9f9cb164e02496d13d8c0e0989fa96b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BasicStudent_Index), @"mvc.1.0.view", @"/Views/BasicStudent/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab0ff31c9f9cb164e02496d13d8c0e0989fa96b", @"/Views/BasicStudent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14598adeeb44da5b8951d847046a300c6a861bcd", @"/Views/_ViewImports.cshtml")]
    public class Views_BasicStudent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCCore_Examples.Models.BasicStudent.BasicStudent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 24 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 35 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\General Files\Job Applications\Chess\MVCCore_Examples\MVCCore_Examples\Views\BasicStudent\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCCore_Examples.Models.BasicStudent.BasicStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591