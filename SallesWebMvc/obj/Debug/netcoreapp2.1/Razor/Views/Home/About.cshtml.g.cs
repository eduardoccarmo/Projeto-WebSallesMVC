#pragma checksum "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64b71bdc04bdabd67385d4b82fca8a2ceb25c31f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\_ViewImports.cshtml"
using SallesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\_ViewImports.cshtml"
using SallesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b71bdc04bdabd67385d4b82fca8a2ceb25c31f", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c133fc5a2174abf951c3484b533785c9c9faeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre a aplicação: ";

#line default
#line hidden
            BeginContext(55, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(60, 17, false);
#line 4 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(77, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(89, 19, false);
#line 5 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 39, true);
            WriteLiteral("</h3>\r\n\r\n<p> <strong> Aluno: </strong> ");
            EndContext();
            BeginContext(148, 17, false);
#line 7 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml"
                         Write(ViewData["Aluno"]);

#line default
#line hidden
            EndContext();
            BeginContext(165, 114, true);
            WriteLiteral("</p>\r\n\r\n<address>\r\n    <p>\r\n        <strong>\r\n            E-mail: <a href=\"carloseduardocastrodocarmo@gmail.com\"> ");
            EndContext();
            BeginContext(280, 17, false);
#line 12 "C:\Users\eduar\Documents\Curso Nélio Alves (C# OOP)\Projeto\SallesWebMvc\SallesWebMvc\Views\Home\About.cshtml"
                                                               Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(297, 51, true);
            WriteLiteral("</a>\r\n        </strong>\r\n    </p>\r\n    \r\n</address>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
