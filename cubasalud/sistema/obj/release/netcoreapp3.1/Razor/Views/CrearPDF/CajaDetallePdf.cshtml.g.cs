#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1263f1f7a4ae04b2f97d4e8e5076627a150f0285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_CajaDetallePdf), @"mvc.1.0.view", @"/Views/CrearPDF/CajaDetallePdf.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1263f1f7a4ae04b2f97d4e8e5076627a150f0285", @"/Views/CrearPDF/CajaDetallePdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_CajaDetallePdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FuncionesCaja.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
   

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;
decimal totalVenta = 0.00m;

decimal totalVentaServ = 0.00m;

decimal totalCompra = 0.00m;

decimal totalIngreso = 0.00m;

decimal totalEgreso = 0.00m;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n                <img width=\"40\"  src=\"/assets/images/farmamestlogo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 329, "\"", 335, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                       <div class=\"text-right\" style=\"font-size: 12px;\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 445, "\"", 453, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 22 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                                                 Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> &nbsp; &nbsp;
                            <br/>   
                        </div>
              <div class=""form-row"">
    <div class=""col-md-12"">
                <h4>Ventas</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">

                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Cliente</th>
                                        <th>Vendedor</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 44 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Venta != null))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 47 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Venta.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 49 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                 if (String.IsNullOrEmpty(item.Venta.NoComprobante))



                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 55 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 61 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                     Write(item.Venta.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 62 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 65 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 66 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Venta.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 67 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Venta.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 68 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 70 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                        totalVenta += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                 

                    </div>
                </div>
                <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 82 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(totalVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div> 
          
    </div>
</div>


<div class=""form-row"">
    <div class=""col-md-12"">
                <h4>Compras</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                 
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>Fecha Compra</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Proveedor</th>
                                        <th>Vendedor</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 108 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Compra != null))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 111 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Compra.FechaCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 113 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                 if (String.IsNullOrEmpty(item.Compra.NoComprobante))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 116 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 119 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                     Write(item.Compra.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 120 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 123 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 124 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Compra.Proveedor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 125 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Compra.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 126 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 128 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                        totalCompra += item.Gasto;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                  

                    </div>
                </div>
                     <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 138 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(totalCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
    </div>
</div>

<div class=""form-row"">
    <div class=""col-md-12"">
                <h4>Venta de Servicios</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
            
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Cliente</th>
                                        <th>Vendedor</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 162 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.VentaServicio != null))



                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 168 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.VentaServicio.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 170 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                 if (String.IsNullOrEmpty(item.VentaServicio.NoComprobante))



                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 176 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 182 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                                     Write(item.VentaServicio.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 183 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 186 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 187 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.VentaServicio.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 188 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.VentaServicio.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 189 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 191 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                        totalVentaServ += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>

                    </div>
                </div>
                 <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 202 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(totalVentaServ);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
    </div>
</div>

<div class=""form-row"">
    <div class=""col-md-6"">
                <h4>Ingresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>Fecha Ingreso</th>
                                        <th>Descripción</th>
                                        <th>Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 221 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Ingreso != 0.00m && a.Venta==null && a.VentaServicio==null))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 224 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 225 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 226 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 228 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                        totalIngreso += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 239 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(totalIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
    </div>
     <div class=""col-md-6"">
                <h4>Egresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                            <table class=""table "">
                                <thead>
                                    <tr>
                                        <th>Fecha Egreso</th>
                                        <th>Descripción</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 256 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Gasto != 0.00m && a.Compra == null))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 259 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 260 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 261 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 263 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"

                                        totalEgreso += item.Gasto;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 274 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(totalEgreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n    </div>\n</div>\n\n\n");
#nullable restore
#line 280 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
  

    decimal sumaing = totalVenta + totalVentaServ + totalIngreso;
    decimal sumaeg = totalCompra + totalEgreso;
    decimal res = sumaing - sumaeg + Model.Caja.MontoApertura;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"form-row\">\n    <div class=\"col-md-12\">\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Monto Apertura:</span>\n                    Q <span>");
#nullable restore
#line 291 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(Model.Caja.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Egresos:</span>\n                    Q <span>");
#nullable restore
#line 295 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(sumaeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Ingresos</span>\n                    Q <span>");
#nullable restore
#line 299 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(sumaing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Cierre:</span>\n                    Q <span>");
#nullable restore
#line 303 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CajaDetallePdf.cshtml"
                       Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1263f1f7a4ae04b2f97d4e8e5076627a150f028528940", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CajaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
