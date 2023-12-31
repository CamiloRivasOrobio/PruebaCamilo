#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee1dd5f20d49658bf6a9e8d6f6b727065616638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicio__ServicioForm), @"mvc.1.0.view", @"/Views/Servicio/_ServicioForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee1dd5f20d49658bf6a9e8d6f6b727065616638", @"/Views/Servicio/_ServicioForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio__ServicioForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ServicioBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""main-card mb-3 card"">
    <div class=""card-body"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <h5><b>Informaci&oacute;n general</b></h5>
                        <hr />
                    </div>
                    <div class=""col-md-12"">
                        <label>Nombre del servicio</label>
                        ");
#nullable restore
#line 14 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.TextBoxFor(a => a.NombreServicio, new {@class="form-control",
                        @placeholder="Nombre del servicio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"col-md-12\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 750, "\"", 758, 0);
            EndWriteAttribute();
            WriteLiteral(">Descripcion</label>\n                        ");
#nullable restore
#line 19 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.TextAreaFor(a => a.Descripcion,5,500 ,htmlAttributes : new {
                        @class="form-control ", @placeholder="Descripcion", @style="max-width:100% !important;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <h5><b>Insumos utilizados</b></h5>
                        <hr />
                    </div>
                    <div class=""col-md-3"">
                        <label>Insumo</label>
                        <select class=""form-control"" data-bind=""options:insumos,
                                    optionsText:'nombreProducto',
                                    value:insumoSeleccionado""></select>
                    </div>
                    <div class=""col-md-3"">
                        <label>Unidad de venta</label>
                        <select class=""form-control"" data-bind=""options:unidadesVentaInsumo,
                                    optionsText:'nombre',
                                    value:unidadVentaSeleccionada""></select>");
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-3"">
                        <label>Cantidad utilizada</label>
                        <input class=""form-control"" data-bind=""value:cantidadUtilizadaInsumo"" />
                    </div>
                    <div class=""col-md-3"">
                        <br />
                        <input type=""button"" class=""btn btn-primary"" data-bind=""click: agregarInsumo"" value=""Agregar"">
                    </div>
                </div>
                <div class=""col-md-12"">
                    <br />
                    <table class=""table-hover table"">
                        <thead>
                            <tr>
                                <th><b>Nombre del insumo</b></th>
                                <th><b>Unidad de venta</b></th>
                                <th><b>Cantidad utilizada</b></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
    ");
            WriteLiteral(@"                        <!--ko foreach: insumosUtilizados-->
                            <tr>
                                <td data-bind=""text: NombreInsumo""></td>
                                <td data-bind=""text: UnidadMedidaVentaNombre""></td>
                                <td data-bind=""text: CantidadUtilizada""></td>
                                <td><button class=""btn btn-danger"" data-bind=""click:$root.quitarInsumoUtilizado"">Quitar</button></td>
                            </tr>
                            <!--/ko-->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <h5><b>Precios</b></h5>
                        <hr />
                    </div>
                    <div class=""col-md-6"">
                        <div class=""position-relative form-");
            WriteLiteral("group\">\n                            <label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 4119, "\"", 4127, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio Normal</label>\n                            ");
#nullable restore
#line 89 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.TextBoxFor(a => a.Precio, new{ @class="form-control",@placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"col-md-6\">\n                        <div class=\"position-relative form-group\">\n                            <label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 4485, "\"", 4493, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio Vip</label>\n                            ");
#nullable restore
#line 95 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.TextBoxFor(a => a.Precio_2, new{ @class="form-control",@placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"col-md-6\">\n                        <div class=\"position-relative form-group\">\n                            <label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 4850, "\"", 4858, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio Social</label>\n                            ");
#nullable restore
#line 101 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.TextBoxFor(a => a.Precio_3, new{ @class="form-control", @placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"col-md-6\">\n                        <div class=\"position-relative form-group\">\n                            <label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 5219, "\"", 5227, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio IGSS</label>\n                            ");
#nullable restore
#line 107 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.TextBoxFor(a => a.Precio_4, new{ @class="form-control", @placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ServicioBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
