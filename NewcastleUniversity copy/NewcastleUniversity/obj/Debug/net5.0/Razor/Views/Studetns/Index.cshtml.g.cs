#pragma checksum "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24327955c68b3a582fe94d64bfc34c914cacea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studetns_Index), @"mvc.1.0.view", @"/Views/Studetns/Index.cshtml")]
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
#line 1 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\_ViewImports.cshtml"
using NewcastleUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\_ViewImports.cshtml"
using NewcastleUniversity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b24327955c68b3a582fe94d64bfc34c914cacea4", @"/Views/Studetns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d782ab2f3946f64964d20de1c3e1ab091a7c33a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Studetns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
  
    var Students = (List<StudentModel>)ViewData["Students"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>This is Students Index</h1>

<table class""table"">
    <thead class=""thead-ligh"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Full Name</th>
            <th>Email</th>

        </tr>
    </thead>

    <tbody>
        
       

");
#nullable restore
#line 23 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
         foreach (var student in Students)
        
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
           Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
           Write(student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
           Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td><button class=\"btn\"><a");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 616, 2);
            WriteAttributeValue("", 587, "/studetns/details/", 587, 18, true);
#nullable restore
#line 30 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
WriteAttributeValue("", 605, student.Id, 605, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">details</a></button></td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n\r\n       \r\n         \r\n\r\n        </tbody>\r\n\r\n\r\n    </table>\r\n\r\n");
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
