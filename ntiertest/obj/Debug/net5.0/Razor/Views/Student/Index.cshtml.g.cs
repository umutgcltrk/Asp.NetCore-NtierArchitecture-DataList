#pragma checksum "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7982aabcfee038e878dfd6803e8770ced79def8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\_ViewImports.cshtml"
using ntiertest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\_ViewImports.cshtml"
using ntiertest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7982aabcfee038e878dfd6803e8770ced79def8c", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2c1d227c1b60f23453dcca5058018e20154e4a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <h3 class=""display-4"">Öğrenciler Listesi</h3>

    <table class=""table"">
        <tr>
            <th scope=""col"">Öğreci ID</th>
            <th scope=""col"">Öğreci Adı</th>
            <th scope=""col"">Öğreci No'su</th>
            <th scope=""col"">Öğreci Sınıfı</th>
        </tr>
");
#nullable restore
#line 12 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td scope=\"row\">");
#nullable restore
#line 14 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
                       Write(item.StudentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
           Write(item.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
           Write(item.StudentNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
           Write(item.StudentClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\gcltr\source\repos\ntiertest\ntiertest\Views\Student\Index.cshtml"
        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
