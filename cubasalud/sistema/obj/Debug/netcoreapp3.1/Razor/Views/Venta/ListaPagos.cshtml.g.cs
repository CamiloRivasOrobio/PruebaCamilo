#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8978461e7b7704e4bce6e36cb50d815d8c4839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_ListaPagos), @"mvc.1.0.view", @"/Views/Venta/ListaPagos.cshtml")]
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
#nullable restore
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
using Database.Shared.Paginacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8978461e7b7704e4bce6e36cb50d815d8c4839", @"/Views/Venta/ListaPagos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_ListaPagos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginacionList<Database.Shared.Models.Venta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListaPagos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
  
    ViewData["Title"] = "Lista Pagos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br/>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8978461e7b7704e4bce6e36cb50d815d8c48394989", async() => {
                WriteLiteral(@"
    <div class=""col-md-12"">
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <input type=""submit"" value=""Buscar"" class=""btn btn-success""></input>
            </div>
            <input type=""text"" name=""buscar""");
                BeginWriteAttribute("value", " value=\"", 482, "\"", 516, 1);
#nullable restore
#line 16 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
WriteAttributeValue("", 490, ViewData["CurrentFilter"], 490, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Buscar cuenta...\">\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br/>
<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                    <table class=""mb-0 table table-hover "">
                        <thead>
                        <tr>
                           <th>Fecha</th> 
                           <th>Codigo Cliente</th>
                           <th>Tipo Cliente</th>
                            <th>Paciente</th>
                            <th>Nit</th>
                            <th>Forma de Pago</th>
                            <th>Acciones</th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 41 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                           Write(item.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 42 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 43 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                           Write(item.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 44 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                           Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 45 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                           Write(item.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n");
#nullable restore
#line 47 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                                 if(item.Pagos.Count() > 0)
                                {
                                     foreach (var pago in item.Pagos)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>");
#nullable restore
#line 51 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                                     Write(pago.FormaPago.NombreFormaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Q ");
#nullable restore
#line 51 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                                                                         Write(pago.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 52 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                               
                            </td>

                            <td> 
                                <a  class=""btn btn-primary"">
                                    Ver detalles
                                </a>
                                <a class=""btn btn-danger"">
                                    <i class=""fas fa-file-pdf""></i> Recibo
                                </a> 
                            </td>
                        </tr>
");
#nullable restore
#line 66 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 74 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8978461e7b7704e4bce6e36cb50d815d8c483912307", async() => {
                WriteLiteral("\n    Anterior\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3086, "btn", 3086, 3, true);
            AddHtmlAttributeValue(" ", 3089, "btn-danger", 3090, 11, true);
            AddHtmlAttributeValue(" ", 3100, "btn-sm", 3101, 7, true);
#nullable restore
#line 83 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
AddHtmlAttributeValue(" ", 3107, prevDisabled, 3108, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8978461e7b7704e4bce6e36cb50d815d8c483916570", async() => {
                WriteLiteral("\n    Siguiente\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3334, "btn", 3334, 3, true);
            AddHtmlAttributeValue(" ", 3337, "btn-danger", 3338, 11, true);
            AddHtmlAttributeValue(" ", 3348, "btn-sm", 3349, 7, true);
#nullable restore
#line 90 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/ListaPagos.cshtml"
AddHtmlAttributeValue(" ", 3355, nextDisabled, 3356, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginacionList<Database.Shared.Models.Venta>> Html { get; private set; }
    }
}
#pragma warning restore 1591