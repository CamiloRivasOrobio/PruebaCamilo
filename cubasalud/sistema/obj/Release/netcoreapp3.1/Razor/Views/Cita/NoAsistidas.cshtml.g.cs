#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc7cd71201887d02d192dfb15b5d1bbdf08359b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cita_NoAsistidas), @"mvc.1.0.view", @"/Views/Cita/NoAsistidas.cshtml")]
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
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
using Database.Shared.Paginacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc7cd71201887d02d192dfb15b5d1bbdf08359b", @"/Views/Cita/NoAsistidas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cita_NoAsistidas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginacionList<Database.Shared.Models.Citas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NoAsistidas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReprogramarCita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
  
    ViewData["Title"] = "Citas - No asistidas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"main-card mb-3 card\">\n    <div class=\"card-body form-row\">\n        <div class=\"text-center col-md-12\">\n            <h4><b>Citas - No asistidas</b></h4>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc7cd71201887d02d192dfb15b5d1bbdf08359b6192", async() => {
                WriteLiteral(@"
    <div class=""col-md-12"">
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <input type=""submit"" value=""Buscar"" class=""btn btn-success""></input>
            </div>
            <input type=""text"" name=""buscar""");
                BeginWriteAttribute("value", " value=\"", 684, "\"", 718, 1);
#nullable restore
#line 24 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
WriteAttributeValue("", 692, ViewData["CurrentFilter"], 692, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"\n                   placeholder=\"Buscar por nombre o por especialidad...\">\n        </div>\n    </div>\n");
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

<br />

<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""mb-0 table table-hover "">
                    <thead>
                        <tr>

                            <th>Fecha</th>
                            <th>Hora</th>
                            <th>Especialdad</th>
                            <th>Doctor</th>
                            <th>Servicio</th>
                            <th>Paciente</th>
                            <th>Número</th>
                            <th>Asistencia</th>
                            <th>Observaciones</th>
                            <th>Usuario</th>
                            <th>Menor de edad</th>
                            <th>Nombre encargado</th>
                            <th>Acciones</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 57 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                         foreach (var item in Model)
                        {
                            var cliente = item.Paciente == null ? "" : item.Paciente.Nombre;
                            var telefono = item.Paciente == null ? "" : item.Paciente.Telefono;
                            var celular = item.Paciente == null ? "" : item.Paciente.Celular;
                            var sexo = item.Paciente == null ? "" : item.Paciente.sexoText;


                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                                                                                             

                            var background = "";
                            var color = "";

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                             if (item.EspecialidadText == "Medicina general")
                            {
                                background = "#2fb9e7";
                                color = "black";
                            }
                            else if (item.EspecialidadText == "Medicina estética")
                            {
                                background = "#A02B4E";
                                color = "white";
                            }
                            else if (item.EspecialidadText == "Ginecología y Obstetricia")
                            {
                                background = "#e660c3";
                                color = "white";
                            }
                            else if (item.EspecialidadText == "Pediatría")
                            {
                                background = "#ffa500";
                                color = "black";
                            }
                            else if (item.EspecialidadText == "Cirugía")
                            {
                                background = "#808080";
                                color = "white";
                            }

                            else if (item.EspecialidadText == "Traumatología")
                            {
                                background = "#000000";
                                color = "white";
                            }

                            else if (item.EspecialidadText == "Medicina interna")
                            {
                                background = "#8B4513";
                                color = "white";
                            }


                            else if (item.EspecialidadText == "Laboratorio clínico")
                            {
                                background = "#008000";
                                color = "white";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td> ");
#nullable restore
#line 118 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                Write(item.FechaInicio.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td> ");
#nullable restore
#line 119 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                Write(item.FechaInicio.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td");
            BeginWriteAttribute("style", " style=\"", 4874, "\"", 4920, 5);
            WriteAttributeValue("", 4882, "background:", 4882, 11, true);
#nullable restore
#line 120 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
WriteAttributeValue(" ", 4893, background, 4894, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4905, ";", 4905, 1, true);
            WriteAttributeValue(" ", 4906, "color:", 4907, 7, true);
#nullable restore
#line 120 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
WriteAttributeValue(" ", 4913, color, 4914, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 120 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                                                               Write(item.EspecialidadText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 121 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                Write(item.EmpleadoText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td> ");
#nullable restore
#line 122 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                Write(item.ServicioText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td>");
#nullable restore
#line 123 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 124 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 125 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(item.EstadoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 126 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(item.Motivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 127 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                Write(item.PersonText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td>");
#nullable restore
#line 128 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(item.EsMenorDeEdadText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 129 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                               Write(item.NombreEncargado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
            WriteLiteral("                                <td>\n                                    <div class=\"col-md-12 p-1\">\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5729, "\"", 5789, 1);
#nullable restore
#line 134 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
WriteAttributeValue("", 5736, Url.Action("EditarCita","Cita", new {id = @item.Id}), 5736, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                       class=""btn btn-warning btn-sm col-md-12"">
                                            Modificar
                                        </a>
                                    </div>
                                    <div class=""col-md-12 p-1"">
                                        <a class=""btn btn-danger text-white col-md-12""");
            BeginWriteAttribute("onclick", " onclick=\"", 6164, "\"", 6192, 3);
            WriteAttributeValue("", 6174, "Eliminar(", 6174, 9, true);
#nullable restore
#line 140 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
WriteAttributeValue("", 6183, item.Id, 6183, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6191, ")", 6191, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                            Eliminar\n                                        </a>\n                                    </div>\n                                    <div class=\"col-md-12 p-1\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc7cd71201887d02d192dfb15b5d1bbdf08359b19070", async() => {
                WriteLiteral("\n                                            Reprogramar\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-citaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["citaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-citaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["citaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n\n                                </td>\n                            </tr>\n");
#nullable restore
#line 152 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n\n        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 161 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc7cd71201887d02d192dfb15b5d1bbdf08359b22489", async() => {
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
#line 168 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                     WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 168 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                                                                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 169 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7238, "btn", 7238, 3, true);
            AddHtmlAttributeValue(" ", 7241, "btn-danger", 7242, 11, true);
            AddHtmlAttributeValue(" ", 7252, "btn-sm", 7253, 7, true);
#nullable restore
#line 169 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
AddHtmlAttributeValue(" ", 7259, prevDisabled, 7260, 13, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc7cd71201887d02d192dfb15b5d1bbdf08359b26853", async() => {
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
#line 172 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                     WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 172 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                                                                                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 173 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7478, "btn", 7478, 3, true);
            AddHtmlAttributeValue(" ", 7481, "btn-danger", 7482, 11, true);
            AddHtmlAttributeValue(" ", 7492, "btn-sm", 7493, 7, true);
#nullable restore
#line 173 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/NoAsistidas.cshtml"
AddHtmlAttributeValue(" ", 7499, nextDisabled, 7500, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    function Eliminar(id){
        var option = confirm(""¿Está seguro/a que desea eliminar este registro?"");

        if(option)
        {

            var data = {""id"" : parseInt(id)}

            $.ajax({
                url: ""/Cita/EliminarCita/"",
                data: data ,
                type: 'POST',
                success: function (result) {
                    window.location.href = '/Cita/Lista';
                },
                error: function (error) {
                    alert(error);
                }
            });
        }
    }

    function Finalizar(id){
        var option = confirm(""¿Está seguro/a que desea finalizar esta cita?"");

        if(option)
        {

            var data = {""id"" : parseInt(id)}

            $.ajax({
                url: ""/Cita/FinalizarCita/"",
                data: data ,
                type: 'POST',
                success: function (result) {
                    window.location.href = '/Cita/Lista';
                },
                error: f");
                WriteLiteral("unction (error) {\n                    alert(error);\n                }\n            });\n        }\n    }\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginacionList<Database.Shared.Models.Citas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
