#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "209127f9e36d6bab259b455d59b5c60dae576151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta__VentaClinicaForm), @"mvc.1.0.view", @"/Views/Venta/_VentaClinicaForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209127f9e36d6bab259b455d59b5c60dae576151", @"/Views/Venta/_VentaClinicaForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta__VentaClinicaForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.VentaClinicaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4 selectcliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("clienteselect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Nuevo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link active"" id=""tab-0"" data-toggle=""tab"" href=""#tab-content-0"">
            <span>Datos de la venta</span>
        </a>
    </li>
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link"" id=""tab-2"" data-toggle=""tab"" href=""#tab-content-2"">
            <span>Detalle de la venta</span>
        </a>
    </li>
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link"" id=""tab-3"" data-toggle=""tab"" href=""#tab-content-3"">
            <span>Agregar Productos</span>
        </a>
    </li>
");
            WriteLiteral(@"</ul>


<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""tab-content"">
            <div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
                <div class=""form"">
                    <div class=""col-md-12"">
                        <div class=""main-card mb-3 card"">
                            <div class=""card-body"">
");
            WriteLiteral("                                <div class=\"form-row\">\n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 1545, "\"", 1553, 0);
            EndWriteAttribute();
            WriteLiteral(">No.\n                                                Comprobante</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 42 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.NoComprobante, new
                                                                           {@class="form-control",@id="nocomprobante", @placeholder="No. Comprobante" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 44 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.NoComprobante, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 2437, "\"", 2445, 0);
            EndWriteAttribute();
            WriteLiteral(">Codigo Del Vendedor</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 51 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.EmpleadoId, new
                                                                           {@class="form-control",@id="empleadoid", @placeholder="Codigo Empleado"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 53 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.EmpleadoId, "", new { @class =
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
                                        <label>Cliente</label>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209127f9e36d6bab259b455d59b5c60dae5761519359", async() => {
                WriteLiteral("\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 63 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Venta.PacienteId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaClientes;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    \n                                    </div>\n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 3829, "\"", 3837, 0);
            EndWriteAttribute();
            WriteLiteral(">Nit</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 70 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.Nit, new {@class="form-control",@id="Nit",
                                                                               @placeholder="Nit"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 72 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.Nit, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-row"">
                                    <div class=""col-md-12"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 4717, "\"", 4725, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 81 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.Direccion, new
                                                                           {@class="form-control",@id="direccion", @placeholder="Direccion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 83 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.Direccion, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



            </div>




            <div class=""tab-pane tabs-animation fade show "" id=""tab-content-2"" role=""tabpanel"">

                <div class=""main-card mb-3 card"">

                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class='table table-hover' id=""tableventa"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Nombre Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
                                        <th>  %  </th>
                                        <th>Descuento</t");
            WriteLiteral(@"h>
                                        <th>Subtotal</th>
                                        <th>Total</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody id=""contentdetalle"">

");
#nullable restore
#line 122 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                      if(Model.Venta != null)
                                    {
                                        foreach (var item in Model.Venta.DetalleVenta)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                        <td>");
#nullable restore
#line 127 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(item.Producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 128 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 129 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 130 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 131 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td><button  type=\"button\"  class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7358, "\"", 7399, 3);
            WriteAttributeValue("", 7368, "eliminarFila(this,", 7368, 18, true);
#nullable restore
#line 132 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
WriteAttributeValue("", 7386, item.Precio, 7386, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7398, ")", 7398, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Quitar</button></td>\n                                        <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 133 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"
                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 135 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/_VentaClinicaForm.cshtml"

                                    }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                                
                            </table>


                        </div>

                            <br/>
                            

                            <div class=""text-right"" style=""font-size: 25px;"">
                                <span>Subtotal:</span> 
                            Q <span id=""subtotal-venta"">0.00</span> 
                            </div> 

                            <div class=""text-right""  style=""font-size: 25px;"">
                                 <span>Descuento:</span> 
                                 Q <span id=""descuento-venta"">0.00</span>           
");
            WriteLiteral(@"                            </div> 

                            <div class=""text-right"" style=""font-size: 25px;"">
                                <span>Total:</span> 
                            Q <span id=""precio-total-a-pagar"">0.00</span> 
                            </div> 


");
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n\n                <div class=\"tab-pane tabs-animation fade show \" id=\"tab-content-3\" role=\"tabpanel\">\n                                                <br />\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209127f9e36d6bab259b455d59b5c60dae57615120499", async() => {
                WriteLiteral(@"
                                <div class=""col-md-12"">
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <input value=""Buscar"" class=""btn btn-success"" onclick=""FiltrarProductos(document.getElementById('buscarfiltro').value)""></input>
                                        </div>
                                        <input type=""text"" name=""buscar"" id=""buscarfiltro"" class=""form-control""
                                            placeholder=""Buscar Producto..."">
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <br />

                        <div class=""main-card mb-6 card"">
                                <div class=""container-fluid"">
                                    <div class=""card-body my-gallery"" itemscope itemtype=""http://schema.org/ImageGallery"">
                                        <div class=""card-deck-wrapper"">
                                            <div class=""card-deck"">
                                                <div class=""row"" id=""listafiltro"" style=""width: 100%""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                        </div>
                </div>

            </div>
        </div>

    </div>

    


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.VentaClinicaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
