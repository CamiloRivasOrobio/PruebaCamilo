#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7507ff5accea71431bcb7c57bd389ffe0dc8a1d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrasladosBodegaAFarmacia_Reporte), @"mvc.1.0.view", @"/Views/TrasladosBodegaAFarmacia/Reporte.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#nullable restore
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7507ff5accea71431bcb7c57bd389ffe0dc8a1d9", @"/Views/TrasladosBodegaAFarmacia/Reporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_TrasladosBodegaAFarmacia_Reporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.TrasladosBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
  
    Layout = "_HojaLayout";
    var PrecioTotal = 0.0m;
    var CostoTotal = 0.0m;

    var personaEnviado = Model.TrasladosProductos.ResponsableEnviado == null ? "" : Model.TrasladosProductos.ResponsableEnviadoText;
    var personaRecibido = Model.TrasladosProductos.ResponsableRecibido == null ? "" : Model.TrasladosProductos.ResponsableRecibidoText;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de Envío </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n    <div>\n\t\t<span class=\"font-weight-bold\">Traslado # </span>\n\t\t<span> ");
#nullable restore
#line 24 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(Model.TrasladosProductos.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE ENV&#205;O</span>\n\t\t<span> ");
#nullable restore
#line 29 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(Model.TrasladosProductos.FechaTraslado.Value.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                                                                                                                    Write(Model.TrasladosProductos.FechaTraslado.Value.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">RESPONSABLE</span>\n\t\t<span> ");
#nullable restore
#line 34 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(personaEnviado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">OBSERVACIONES</span>\n\t\t<span> ");
#nullable restore
#line 39 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(Model.TrasladosProductos.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n   \n\n    <br>\n\n     <div>\n\t\t<span class=\"font-weight-bold\">ESTADO</span>\n\t\t<span> ");
#nullable restore
#line 48 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(Model.TrasladosProductos.EstadoTraslados.DescripcionEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n     <div>\n\t\t<span class=\"font-weight-bold\">RESPONSABLE RECIBIDO</span>\n\t\t<span> ");
#nullable restore
#line 53 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(personaRecibido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n     <div>\n\t\t<span class=\"font-weight-bold\">TOTAL ITEMS</span>\n\t\t<span> ");
#nullable restore
#line 57 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
          Write(Model.TrasladosProductos.DetalleTrasladoProductos.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
	</div>
        <div>
		<span class=""font-weight-bold"">TIPO TRASLADO</span>
	<span> BODEGA A FARMACIA</span>
	</div>
    <table class=""table table-bordered"">
                <thead>
                <tr>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Nombre Producto</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Presentación</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Cantidad</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Precio</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Costo</span></th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 74 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                 foreach(var producto in Model.TrasladosProductos.DetalleTrasladoProductos)
                    {
                        var presentacion = producto.Producto.PresentacionProducto == null ? "// sin asignar " : producto.Producto.PresentacionProducto.PresentProducto;
                        decimal tot = producto.Producto.Precio_5 * producto.Cantidad;
                        decimal cost = producto.Producto.PrecioCosto * producto.Cantidad;

                        PrecioTotal = PrecioTotal + tot;
                        CostoTotal = CostoTotal + cost; 


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><span contenteditable>");
#nullable restore
#line 84 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                             Write(producto.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span contenteditable>");
#nullable restore
#line 85 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                             Write(presentacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span contenteditable>");
#nullable restore
#line 86 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                             Write(producto.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span data-prefix>");
#nullable restore
#line 87 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                         Write(producto.Producto.Precio_5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span data-prefix>");
#nullable restore
#line 88 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                                         Write(producto.Producto.PrecioCosto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                    </tr>\n");
#nullable restore
#line 90 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n    </table>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">Total</span>\n\t\t<span> Q ");
#nullable restore
#line 96 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
            Write(PrecioTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n     <div>\n\t\t<span class=\"font-weight-bold\">Costo total</span>\n\t\t<span> Q ");
#nullable restore
#line 100 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/Reporte.cshtml"
            Write(CostoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\n\n      \n \n\n      \t\n\t\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.TrasladosBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
