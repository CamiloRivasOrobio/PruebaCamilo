#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59f06fd958167b64ce385cee2fa72567bf74eea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_VerRecepcion), @"mvc.1.0.view", @"/Views/Compra/VerRecepcion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59f06fd958167b64ce385cee2fa72567bf74eea7", @"/Views/Compra/VerRecepcion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_VerRecepcion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CompraBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
  

  decimal suma= 0.00m;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"form-row\">\n    <div class=\"col-md-12\">\n\n        ");
#nullable restore
#line 11 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
   Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form\">\n            <div class=\"col-md-12\">\n\n                    <a");
            BeginWriteAttribute("href", " href=\"", 262, "\"", 351, 1);
#nullable restore
#line 16 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
WriteAttributeValue("", 269, Url.Action("ValidarProductosInventario","Compra", new {id = @Model.Recepcion.Id}), 269, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning"">
                                    Validar
                    </a>
                    <br/> <br/>
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">

                        <fieldset disabled>
                            <div class=""form-row"">
                                <div class=""col-md-12"">
                                    <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 809, "\"", 817, 0);
            EndWriteAttribute();
            WriteLiteral(">No.\n                                            Comprobante</label>\n");
            WriteLiteral("                                        ");
#nullable restore
#line 29 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.TextBoxFor(a => a.Recepcion.Compra.NoComprobante, new
                                                                   {@class="form-control",@id="nocomprobante", @placeholder="No. Comprobante"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        ");
#nullable restore
#line 31 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.ValidationMessageFor(a => a.Recepcion.Compra.NoComprobante, "", new { @class =
                                                                       "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""form-row"">
                                 <div class=""col-md-6"">
                                    <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 1762, "\"", 1770, 0);
            EndWriteAttribute();
            WriteLiteral(">Proveedor</label>\n");
            WriteLiteral("                                        ");
#nullable restore
#line 41 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.TextBoxFor(a => a.Recepcion.Compra.Proveedor.Nombre, new
                                                                   {@class="form-control",@id="nombrevendedor",
                                                                       @placeholder="Proveedor"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        ");
#nullable restore
#line 44 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.ValidationMessageFor(a => a.Recepcion.Compra.Proveedor.Nombre, "", new { @class =
                                                                       "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </div>\n                                <div class=\"col-md-6\">\n                                    <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 2649, "\"", 2657, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre\n                                            Vendedor</label>\n");
            WriteLiteral("                                        ");
#nullable restore
#line 52 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.TextBoxFor(a => a.Recepcion.Compra.NombreVendedor, new
                                                                   {@class="form-control",@id="nombrevendedor",
                                                                       @placeholder="Nombre Vendedor"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        ");
#nullable restore
#line 55 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.ValidationMessageFor(a => a.Recepcion.Compra.NombreVendedor, "", new { @class =
                                                                       "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""col-md-6"">
                                    <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 3674, "\"", 3682, 0);
            EndWriteAttribute();
            WriteLiteral(">Fecha Limite</label>\n");
            WriteLiteral("                                        ");
#nullable restore
#line 64 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.TextBoxFor(a => a.Recepcion.Compra.FechaLimite, new
                                                                   {type="date",@class="form-control",@id="fechalimite",
                                                                       @placeholder="Nombres"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        ");
#nullable restore
#line 67 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.ValidationMessageFor(a => a.Recepcion.Compra.FechaLimite, "", new { @class =
                                                                       "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </div>\n                                <div class=\"col-md-6\">\n                                    <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 4561, "\"", 4569, 0);
            EndWriteAttribute();
            WriteLiteral(">Fecha\n                                            Recepcion</label>\n");
            WriteLiteral("                                        ");
#nullable restore
#line 75 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.TextBoxFor(a => a.Recepcion.Compra.FechaRecepcion, new
                                                                   {type="date", @class="form-control",@id="fecharecepcion",
                                                                       @placeholder="Direccion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        ");
#nullable restore
#line 78 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                   Write(Html.ValidationMessageFor(a => a.Recepcion.Compra.FechaRecepcion, "", new { @class =
                                                                       "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                       
                        <br/>

                        <div class=""table-responsive"">
                            <table class='table'>
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Nombre Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio Costo</th>
                                        <th>Total</th>
                                    </tr>
                                </thead>
                                <tbody>
                                   
");
#nullable restore
#line 100 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                         foreach (var item in Model.Recepcion.Compra.DetalleCompras)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                                <td>");
#nullable restore
#line 103 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                               Write(item.Producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 104 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                               Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 105 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 106 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                               Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 107 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                               Write(item.PrecioTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 109 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                                 if (item.Compra.Estado == false)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td> <button type=\"button\" class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", "\n                                                            onclick=\"", 6926, "\"", 7028, 3);
            WriteAttributeValue("", 6996, "eliminarFilaC(this,", 6996, 19, true);
#nullable restore
#line 112 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
WriteAttributeValue("", 7015, item.Precio, 7015, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7027, ")", 7027, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Quitar</button></td>\n");
#nullable restore
#line 113 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 114 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            </tr>\n");
#nullable restore
#line 116 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                            suma+=item.PrecioTotal;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    

                                </tbody>

                            </table>


                        </div>

                        <br />
                        <div class=""text-right"" style=""font-size: 25px;"">
                            <span>Total:</span>
                            Q <span id=""precio-total-c"">");
#nullable restore
#line 130 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/VerRecepcion.cshtml"
                                                   Write(suma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n\n\n\n\n\n\n                    </div>\n\n\n\n\n\n\n\n\n\n\n\n\n                </div>\n            </div>\n        </div>\n\n\n\n\n\n\n\n\n\n\n        <div class=\"main-card mb-3 card\">\n\n\n        </div>\n\n\n    </div>\n\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CompraBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
