#pragma checksum "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694f51341313595fa74ea1588800906ed7795393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Details), @"mvc.1.0.view", @"/Views/Eventos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Details.cshtml", typeof(AspNetCore.Views_Eventos_Details))]
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
#line 1 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
using Eventos.IO.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694f51341313595fa74ea1588800906ed7795393", @"/Views/Eventos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed2f5fbd5c0d8f3b6e092331453a5bf55dccddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
  
    ViewData["Title"] = Model.Nome;

#line default
#line hidden
            BeginContext(112, 35, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h2>");
            EndContext();
            BeginContext(148, 17, false);
#line 9 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(165, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(181, 20, false);
#line 10 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
   Write(Model.DescricaoCurta);

#line default
#line hidden
            EndContext();
            BeginContext(201, 92, true);
            WriteLiteral("</h4>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(294, 46, false);
#line 16 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoLonga));

#line default
#line hidden
            EndContext();
            BeginContext(340, 123, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Quando:</b><br />\r\n            ");
            EndContext();
            BeginContext(464, 36, false);
#line 22 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
       Write(Model.DataInicio.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(500, 5, true);
            WriteLiteral(" até ");
            EndContext();
            BeginContext(506, 33, false);
#line 22 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                                                 Write(Model.DataFim.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(539, 94, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Valor:</b><br />\r\n");
            EndContext();
#line 27 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
              
                if (Model.Gratuito)
                {
                    

#line default
#line hidden
            BeginContext(726, 28, false);
#line 30 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayName("Gratuito"));

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                                                 
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(837, 37, false);
#line 34 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                                                          
                }
            

#line default
#line hidden
            BeginContext(910, 101, true);
            WriteLiteral("        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Tipo de Evento:</b><br />\r\n");
            EndContext();
#line 41 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               var categoria = new CatagoriaViewModel().ListarCategorias().FirstOrDefault(c => c.Id == Model.CategoriaId);
                

#line default
#line hidden
            BeginContext(1152, 24, false);
#line 42 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
           Write(Html.Raw(categoria.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 113, true);
            WriteLiteral("        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Orgazinado por:</b><br />\r\n            ");
            EndContext();
            BeginContext(1307, 43, false);
#line 48 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 93, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <b>Onde?</b><br />\r\n");
            EndContext();
#line 53 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
              
                if (Model.Online)
                {
                    

#line default
#line hidden
            BeginContext(1534, 26, false);
#line 56 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayName("Online"));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                                               
                }
                else
                {

#line default
#line hidden
            BeginContext(1622, 23, true);
            WriteLiteral("                    <b>");
            EndContext();
            BeginContext(1646, 55, false);
#line 60 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(1729, 51, false);
#line 61 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(1834, 51, false);
#line 63 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(1913, 47, false);
#line 64 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(2014, 51, false);
#line 66 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(2093, 47, false);
#line 67 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(2194, 56, false);
#line 69 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(2278, 52, false);
#line 70 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(2384, 51, false);
#line 72 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2435, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(2463, 47, false);
#line 73 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(2564, 48, false);
#line 75 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(2640, 44, false);
#line 76 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 51, true);
            WriteLiteral("                    <br />\r\n                    <b>");
            EndContext();
            BeginContext(2738, 51, false);
#line 78 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                  Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2789, 7, true);
            WriteLiteral(":</b>\r\n");
            EndContext();
            BeginContext(2817, 47, false);
#line 79 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
#line 79 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Details.cshtml"
                                                                    
                }
            

#line default
#line hidden
            BeginContext(2900, 132, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <a href=\"javascript:history.go(-1)\" class=\"btn btn-info\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
