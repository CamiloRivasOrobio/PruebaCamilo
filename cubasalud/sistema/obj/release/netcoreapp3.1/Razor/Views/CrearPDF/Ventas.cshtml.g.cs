#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1edd348de65f1e3a1665e0fc79df977c2d634a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_Ventas), @"mvc.1.0.view", @"/Views/CrearPDF/Ventas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1edd348de65f1e3a1665e0fc79df977c2d634a3f", @"/Views/CrearPDF/Ventas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_Ventas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Venta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
  

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<img width=\"40\"");
            BeginWriteAttribute("src", "  src=\"", 129, "\"", 136, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 137, "\"", 143, 0);
            EndWriteAttribute();
            WriteLiteral(">\n<div class=\"text-right\" style=\"font-size: 12px;\">\n    <label");
            BeginWriteAttribute("class", " class=\"", 206, "\"", 214, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 13 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                                                         Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> &nbsp; &nbsp;
    <br/>   
</div>

            <div class=""table-responsive table-sm"">
                    <table class=""mb-0 table table-hover "">
                        <thead>
                        <tr>
                            <th>Fecha</th>
                            <th>Venta #</th>
                            <th>Vendedor</th>
                            <th>Nombre</th>
                            <th>Nit</th>
                            <th>Forma de Pago</th>
                            <th>Total</th>
                            <th>Monto Pagado</th>
                            <th>Vuelto</th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 33 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                            foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 36 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                           Write(item.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 37 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                           Write(item.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 39 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                           Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                           Write(item.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n");
#nullable restore
#line 42 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                                 if(item.Pagos.Count() > 0)
                                {
                                     foreach (var pago in item.Pagos)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 46 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                                     Write(pago.FormaPago.NombreFormaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Q ");
#nullable restore
#line 46 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                                                                         Write(pago.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 47 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                               \n                            </td>\n                            <td>Q ");
#nullable restore
#line 51 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                             Write(item.DetalleVenta.Sum(a => a.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>Q ");
#nullable restore
#line 52 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                             Write(item.MontoPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>Q ");
#nullable restore
#line 53 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                             Write(item.Vuelto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                           \n                        </tr>\n");
#nullable restore
#line 57 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/Ventas.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.Venta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
