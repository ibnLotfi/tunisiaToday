#pragma checksum "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2119d28aaab2a42b97f480519166a0e7b54cac13"
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
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2119d28aaab2a42b97f480519166a0e7b54cac13", @"/Views/Article/Lecture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91248fd585a77dc3437d9a0909952f0abcb30d27", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Lecture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tunisiaToday.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
  
    ViewData["Title"] = "Lecture";
 Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\" style=\"margin-top:60px\">\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n\r\n            </div>\r\n\r\n            <div class=\"col-8\">\r\n\r\n                <h3>");
#nullable restore
#line 21 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                 if (!(DateTime.Compare(Model.Maj, new DateTime(0001, 01, 01, 0, 0, 0)) == 0))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"font-size:0.7em;color:grey\">Publié le ");
#nullable restore
#line 24 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                                                               Write(Model.DatePublication);

#line default
#line hidden
#nullable disable
            WriteLiteral(", mis à jour le ");
#nullable restore
#line 24 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                                                                                                     Write(Model.Maj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"font-size:0.7em;color:grey\">Publié le ");
#nullable restore
#line 28 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                                                               Write(Model.DatePublication);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n            <div class=\"col-2\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-2\">\r\n\r\n            </div>\r\n\r\n            <div class=\"col-8\">\r\n\r\n                ");
#nullable restore
#line 46 "C:\Users\issam.benmabrouck\source\repos\tunisiaToday\tunisiaToday\Views\Article\Lecture.cshtml"
            Write(new HtmlString(@Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <div class=\"col-2\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
