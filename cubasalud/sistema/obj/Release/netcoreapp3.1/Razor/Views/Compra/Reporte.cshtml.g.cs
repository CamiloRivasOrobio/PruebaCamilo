#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8af3349a2a05798bbb717991282fb0d2451094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Reporte), @"mvc.1.0.view", @"/Views/Compra/Reporte.cshtml")]
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
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8af3349a2a05798bbb717991282fb0d2451094", @"/Views/Compra/Reporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Reporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database.Shared.Models.Compra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
  
    Layout = "_HojaLayout";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                                 
    var CostoTotal = 0.0m;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Solicitud </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n    <div>\n\t\t<span class=\"font-weight-bold\">RESPONSABLE</span>\n\t\t<span> ");
#nullable restore
#line 20 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">PROVEEDOR</span>\n\t\t<span> ");
#nullable restore
#line 25 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.Proveedor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE EMISI&#205;ON</span>\n\t\t<span> ");
#nullable restore
#line 30 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.FechaCompra.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                                                                                                         Write(Model.FechaCompra.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA LIMITE</span>\n\t\t<span> ");
#nullable restore
#line 35 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.FechaLimite.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                                                                                                         Write(Model.FechaLimite.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">OBSERVACIONES</span>\n\t\t<span> ");
#nullable restore
#line 40 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n    <br>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">TIPO</span>\n\t\t<span> ");
#nullable restore
#line 46 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
          Write(Model.TipoCompra.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
	</div>

    <table class=""table table-bordered"">
                <thead>
                <tr>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>REF.</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>NOMBRE</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>CANTIDAD</span></th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 58 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                 foreach(var producto in Model.DetalleCompras)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                                                                                                                                                                             
                        decimal cost = producto.Producto.PrecioCosto * producto.Cantidad;

                        CostoTotal = CostoTotal + cost; 


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><span contenteditable>");
#nullable restore
#line 66 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                                             Write(producto.Producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span>");
#nullable restore
#line 67 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                             Write(producto.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span>");
#nullable restore
#line 68 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                             Write(producto.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                    </tr>\n");
#nullable restore
#line 70 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \n                </tbody>\n    </table>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">Costo total</span>\n\t\t<span> Q ");
#nullable restore
#line 77 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/Reporte.cshtml"
            Write(CostoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database.Shared.Models.Compra> Html { get; private set; }
    }
}
#pragma warning restore 1591
