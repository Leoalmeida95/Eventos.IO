#pragma checksum "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Shared\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d537385e01bf6b1a91fae2b8df717445859ff81e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AccessDenied), @"mvc.1.0.view", @"/Views/Shared/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AccessDenied.cshtml", typeof(AspNetCore.Views_Shared_AccessDenied))]
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
#line 1 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site;

#line default
#line hidden
#line 2 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d537385e01bf6b1a91fae2b8df717445859ff81e", @"/Views/Shared/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed2f5fbd5c0d8f3b6e092331453a5bf55dccddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Shared\AccessDenied.cshtml"
  
    ViewData["Title"] = "Acesso negado!";

#line default
#line hidden
            BeginContext(73, 128, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Acesso negado.</h1>\r\n<h2 class=\"text-danger\">Você não tem permissão para acessar essa página.</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Shared\AccessDenied.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(231, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(284, 15, false);
#line 12 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Shared\AccessDenied.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(299, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Shared\AccessDenied.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
