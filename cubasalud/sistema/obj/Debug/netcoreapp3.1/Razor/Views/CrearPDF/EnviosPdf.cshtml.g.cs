#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47072f03cc8cf9e0e339290789f94a4fd0e2c9f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_EnviosPdf), @"mvc.1.0.view", @"/Views/CrearPDF/EnviosPdf.cshtml")]
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
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47072f03cc8cf9e0e339290789f94a4fd0e2c9f1", @"/Views/CrearPDF/EnviosPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_EnviosPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Envio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
   

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;



#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n                <img width=\"40\"  src=\"/assets/images/farmamestlogo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 187, "\"", 193, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                       <div class=\"text-right\" style=\"font-size: 12px;\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 303, "\"", 311, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 14 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                                                                                 Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> &nbsp; &nbsp;
                            <br/>   
                        </div>
             
                    <table class=""table"">
                        <thead>
                        <tr>
                            <th>Ruta #</th>
                            <th>Nombre Piloto</th>
                            <th>Fecha y Hora de entrega</th>
                            <th>Direccion Exacta</th>
                            <th>Estado</th>
                           

                            
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 32 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 35 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                           Write(item.RutaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 36 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                           Write(item.NombrePiloto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 37 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                           Write(item.FechaEntrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                           Write(item.DireccionExacta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 39 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                           Write(item.EstadosEnvio.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                           \n                        </tr>\n");
#nullable restore
#line 42 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/EnviosPdf.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.Envio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
