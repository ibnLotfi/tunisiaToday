#pragma checksum "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0a7b2c098e488f94d6e33307a0ac4d7dd994fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Lecture), @"mvc.1.0.view", @"/Views/Article/Lecture.cshtml")]
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
#line 1 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\_ViewImports.cshtml"
using tunisiaToday;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\_ViewImports.cshtml"
using tunisiaToday.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0a7b2c098e488f94d6e33307a0ac4d7dd994fe", @"/Views/Article/Lecture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91248fd585a77dc3437d9a0909952f0abcb30d27", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Lecture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tunisiaToday.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
  
    ViewData["Title"] = "Lecture";
 Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:60px\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">\r\n\r\n        </div>\r\n\r\n        <div class=\"col-8\">\r\n            ");
#nullable restore
#line 20 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
        Write(new HtmlString(@Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"col-2\">\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tunisiaToday.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
