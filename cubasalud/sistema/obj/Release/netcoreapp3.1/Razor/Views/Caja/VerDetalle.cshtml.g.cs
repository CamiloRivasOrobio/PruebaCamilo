#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d025758ce129277618816227defd203cd83cdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caja_VerDetalle), @"mvc.1.0.view", @"/Views/Caja/VerDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d025758ce129277618816227defd203cd83cdf", @"/Views/Caja/VerDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Caja_VerDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaBaseViewModel>
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
  

    decimal totalVenta = 0.00m;

    decimal totalVentaServ = 0.00m;

    decimal totalCompra = 0.00m;

    decimal totalIngreso = 0.00m;

    decimal totalEgreso = 0.00m;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 19 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""form-row"">
        <div class=""col-md-12"">

            <div class=""col-md-6"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">

                        <button type=""button"" class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 619, "\"", 659, 3);
            WriteAttributeValue("", 629, "GuardarIngreso(", 629, 15, true);
#nullable restore
#line 28 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 644, Model.Caja.Id, 644, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 658, ")", 658, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Nuevo Ingreso</button>\n                        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 753, "\"", 792, 3);
            WriteAttributeValue("", 763, "GuardarEgreso(", 763, 14, true);
#nullable restore
#line 29 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 777, Model.Caja.Id, 777, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 791, ")", 791, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Nuevo Egreso</button>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 842, "\"", 904, 1);
#nullable restore
#line 30 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 849, Url.Action("Cerrar","Caja", new {id = @Model.Caja.Id}), 849, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                            class=\"btn btn-primary text-left\">\n                            Cerrar caja\n                        </a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1134, 1);
#nullable restore
#line 34 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 1071, Url.Action("ReporteDetalle","Caja", new {id = @Model.Caja.Id}), 1071, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""btn btn-primary text-left"">
                            Generar PDF
                        </a>
                    </div>
                </div>

            </div>
        </div>
    </div>



<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Ventas</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th># Venta</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Cliente</th>
                                        <th>Ven");
            WriteLiteral("dedor</th>\n                                        <th>Monto Pagado</th>\n\n                                    </tr>\n                                </thead>\n                                <tbody>\n");
#nullable restore
#line 69 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas
                                    .Where(a => a.Venta != null).OrderByDescending(a=>a.Venta.FechaVenta))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 73 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Venta.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 74 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Venta.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 76 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                 if (String.IsNullOrEmpty(item.Venta.NoComprobante))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 79 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 85 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                     Write(item.Venta.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 86 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 89 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 91 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                 if(item.Venta.Clientes != null)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                               Write(item.Venta.Clientes.Nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                                               
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 96 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Venta.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 97 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 99 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                        totalVenta += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 111 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(totalVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div> 
            </div>

        </div>
    </div>
</div>


<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Compras</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
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
#line 141 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Compra != null).OrderByDescending(a=>a.Compra.FechaCompra))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 144 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Compra.FechaCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 146 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                 if (String.IsNullOrEmpty(item.Compra.NoComprobante))



                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 152 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 158 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                                     Write(item.Compra.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 159 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 162 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 163 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Compra.Proveedor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 164 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Compra.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 165 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 167 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                        totalCompra += item.Gasto;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                     <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 179 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(totalCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n\n        </div>\n    </div>\n</div>\n\n");
            WriteLiteral(@"
<div class=""form-row"">
    <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Ingresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Ingreso</th>
                                        <th>Descripción</th>
                                        <th>Total</th>
                                        <th>Acciones</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 276 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Ingreso != 0.00m && a.Venta==null && a.VentaServicio==null).OrderByDescending(a=>a.Fecha))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 279 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 280 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 281 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n                                                <a  class=\"btn btn-danger text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 11496, "\"", 11531, 3);
            WriteAttributeValue("", 11506, "eliminarDetalle(", 11506, 16, true);
#nullable restore
#line 283 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 11522, item.Id, 11522, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11530, ")", 11530, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                                    Quitar\n                                                </a>\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 288 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"

                                        totalIngreso += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 300 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(totalIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>

        </div>
    </div>
     <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Egresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th>Descripción</th>
                                        <th>Total</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 323 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                     foreach (var item in Model.Caja.DetalleCajas.Where(a => a.Gasto != 0.00m && a.Compra == null).OrderByDescending(a=>a.Fecha))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 326 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 327 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 328 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n                                                <a class=\"btn btn-danger text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 13625, "\"", 13660, 3);
            WriteAttributeValue("", 13635, "eliminarDetalle(", 13635, 16, true);
#nullable restore
#line 330 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
WriteAttributeValue("", 13651, item.Id, 13651, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13659, ")", 13659, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                                    Quitar\n                                                </a>\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 335 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                                        totalEgreso += item.Gasto;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 345 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(totalEgreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n\n        </div>\n    </div>\n</div>\n\n\n");
#nullable restore
#line 354 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
  

    decimal sumaing = totalVenta + totalVentaServ + totalIngreso;
    decimal sumaeg = totalCompra + totalEgreso;
    decimal res = sumaing - sumaeg + Model.Caja.MontoApertura;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""text-right"" style=""font-size: 17px;"">
                    <span>Monto Apertura:</span>
                    Q <span>");
#nullable restore
#line 367 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(Model.Caja.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Egresos:</span>\n                    Q <span>");
#nullable restore
#line 371 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(sumaeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Ingresos</span>\n                    Q <span>");
#nullable restore
#line 375 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(sumaing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Cierre:</span>\n                    Q <span>");
#nullable restore
#line 379 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/VerDetalle.cshtml"
                       Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d025758ce129277618816227defd203cd83cdf29203", async() => {
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
                WriteLiteral(@"

<script>
    function eliminarDetalle(id)
    {
        var datos = {""detalleId"" : id}

        if(confirm('¿Está seguro/a que desea eliminar este registro? Los cambios no se podrán revertir.'))
        {
            $.ajax({
                method: ""POST"",
                data: datos,
");
                WriteLiteral(@"                url: '/Caja/EliminarDetalle',
                traditional: true,

                success: function(data, textStatus) {
                    window.location.reload()
                },

                error: function(data) {
                    alert(data.error);
                }
            });
        }
    }
</script>
");
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
