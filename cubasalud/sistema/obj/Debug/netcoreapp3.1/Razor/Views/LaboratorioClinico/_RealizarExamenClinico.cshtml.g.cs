#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03d979274ac1522a20e40edd8412a06cd3ced1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LaboratorioClinico__RealizarExamenClinico), @"mvc.1.0.view", @"/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03d979274ac1522a20e40edd8412a06cd3ced1a", @"/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_LaboratorioClinico__RealizarExamenClinico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.RealizarExamenLabClinicoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("clienteselect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("medicoreferido"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("clinicareferida"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
  
    decimal subtotal = 0.00m;
    decimal total = 0.00m;
    decimal descuento = 0.00m;
    var todayDate = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link active"" id=""tab-0"" data-toggle=""tab"" href=""#tab-content-0"">
            <span>Datos</span>
        </a>
    </li>
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link"" id=""tab-2"" data-toggle=""tab"" href=""#tab-content-2"">
            <span>Examenes a solicitar</span>
        </a>
    </li>
</ul>


<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""tab-content"">
            <div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <div class=""form-row"">
                            <div class=""col-md-6"">
                                <div class=""position-relative form-group"">
");
#nullable restore
#line 33 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                     if(!ViewBag.MostrarEstado)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <label");
            BeginWriteAttribute("class", " class=\"", 1236, "\"", 1244, 0);
            EndWriteAttribute();
            WriteLiteral(">Seleccione Paciente</label>\n                                        <a href=\"/Pacientes/Nuevo\" target=\"_blank\" class=\"btn btn-primary btn-sm\">Agregar Nuevo</a>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03d979274ac1522a20e40edd8412a06cd3ced1a7410", async() => {
                WriteLiteral("\n                                         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 37 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Examen.PacienteId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaPaciente;

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
            WriteLiteral("\n");
#nullable restore
#line 40 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                    }
                                    else {
                                        var paciente = "";
                                        var edad = 0;
                                        var medico = Model.Examen.Medicos == null ? "// sin referencia" : Model.Examen.Medicos.Nombres;

                                        if(Model.Examen.Paciente.FechaNacimiento != null)
                                        {
                                            edad = todayDate.Year - Model.Examen.Paciente.FechaNacimiento.Value.Year;
                                            if (todayDate.Month < Model.Examen.Paciente.FechaNacimiento.Value.Month || (todayDate.Month == Model.Examen.Paciente.FechaNacimiento.Value.Month && todayDate.Day < Model.Examen.Paciente.FechaNacimiento.Value.Day)) edad--;
                                        }
                                        if(@Model.Examen != null)
                                        {
                                            if(@Model.Examen.Paciente != null)
                                            {
                                                paciente = @Model.Examen.Paciente.Nombre;
                                            }
                                        }

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                   Write(Html.HiddenFor(a => a.Examen.PacienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"container-fluid\" style=\"border-style: ridge ; \">\n                                            <h5>Paciente: ");
#nullable restore
#line 61 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                     Write(paciente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <h5>Edad: ");
#nullable restore
#line 62 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                  Write(edad == 0 ? "/ No hay registro" : edad.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <h5>Núm. Afil.: ");
#nullable restore
#line 63 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                        Write(string.IsNullOrEmpty(Model.Examen.Paciente.no_IGGS) ? " / sin registro" : Model.Examen.Paciente.no_IGGS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <h5>Méd. Referido: ");
#nullable restore
#line 64 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                          Write(medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <h5>Clínica Referida: ");
#nullable restore
#line 65 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                             Write(Model.Examen.ClinicaReferida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <br>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3796, "\"", 3875, 1);
#nullable restore
#line 67 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
WriteAttributeValue("", 3803, Url.Action("GenerarResultados","CrearPDF", new {id = @Model.Examen.Id}), 3803, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Generar Resultados </a>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3971, "\"", 4040, 1);
#nullable restore
#line 68 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
WriteAttributeValue("", 3978, Url.Action("Resumen","CrearPDF", new {id = @Model.Examen.Id}), 3978, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Resumen </a>\n                                            <br>\n                                            <br>\n\n                                        </div>\n");
#nullable restore
#line 73 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \n                                </div>\n                            </div>\n\n");
#nullable restore
#line 87 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                 if(!ViewBag.MostrarEstado)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 5202, "\"", 5210, 0);
            EndWriteAttribute();
            WriteLiteral(">Usuario</label>\n                                            <input type=\"text\" class=\"form-control\" id=\"empleadoid\" value=\"1\"/>\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 5623, "\"", 5631, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombres</label>\n                                            <input type=\"text\" class=\"form-control\" id=\"Nombres\"/>\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 6031, "\"", 6039, 0);
            EndWriteAttribute();
            WriteLiteral(">NIT</label>\n                                            <input type=\"text\" class=\"form-control\" id=\"Nit\"/>\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                    <div class=\"col-md-12\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 6432, "\"", 6440, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion</label>\n                                            <input type=\"text\" class=\"form-control\" id=\"Direccion\"/>\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 6844, "\"", 6852, 0);
            EndWriteAttribute();
            WriteLiteral(">Médico Referido</label>\n");
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03d979274ac1522a20e40edd8412a06cd3ced1a18328", async() => {
                WriteLiteral("\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 121 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Examen.MedicosId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaMedicosDisponibles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\">\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 7557, "\"", 7565, 0);
            EndWriteAttribute();
            WriteLiteral(">Clínica Referida</label>\n");
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03d979274ac1522a20e40edd8412a06cd3ced1a21184", async() => {
                WriteLiteral("\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 131 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Examen.ClinicaId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 132 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaClinicasDisponibles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n                                    </div>\n");
#nullable restore
#line 136 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"


                                }
                              

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 150 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                             if(ViewBag.MostrarEstado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-12\">\n                                    <div class=\"position-relative form-group\">\n                                        <label");
            BeginWriteAttribute("class", " class=\"", 8986, "\"", 8994, 0);
            EndWriteAttribute();
            WriteLiteral(">Cambiar a estado: </label>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03d979274ac1522a20e40edd8412a06cd3ced1a24594", async() => {
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03d979274ac1522a20e40edd8412a06cd3ced1a24895", async() => {
                    WriteLiteral(" -- sin seleccion -- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 155 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Examen.EstadoExamenId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 156 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaEstados;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 161 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                            }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                        <br>\n");
#nullable restore
#line 175 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                         if(ViewBag.MostrarEstado)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""position-relative form-group"">
                                    <button class=""btn btn-primary"" type=""submit"">Guardar</button>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 184 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                    </div>
                </div>
            </div>


            <div class=""tab-pane tabs-animation fade show"" id=""tab-content-2"" role=""tabpanel"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">

                        <div class=""table-responsive"">
                            <table class='table table-hover' id=""tableventa"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Examen</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
                                        <th>  %  </th>
                                        <th>Subtotal</th>
                                        <th>Total</th>
                                        <th>Acciones</th>
                                    </tr>
                              ");
            WriteLiteral("  </thead>\n                                <tbody id=\"contentdetalle\">\n\n");
#nullable restore
#line 211 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                     if(Model.Examen != null)
                                    {
                                        foreach (var item in Model.Examen.DetalleExamenes)
                                        {
                                            subtotal += @item.Subtotal;
                                            total += @item.Total;
                                            descuento += @item.Descuento;

                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n                                                <td>");
#nullable restore
#line 220 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 221 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.ExamenLabClinico.NombreExamen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 222 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 223 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 224 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 225 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 226 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 227 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                               Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>\n");
#nullable restore
#line 229 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                     if(ViewBag.MostrarEstado)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 13239, "\"", 13341, 1);
#nullable restore
#line 232 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
WriteAttributeValue("", 13246, Url.Action("ModificarResultadosExamen","LaboratorioClinico", new {detalleExamenId = @item.Id}), 13246, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\n                                                            Modificar\n                                                        </a>\n");
#nullable restore
#line 235 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\n                                                <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 237 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            </tr>\n");
#nullable restore
#line 239 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"

                                            
                                        } 
                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </tbody>\n                                \n                            </table>\n                        </div>\n\n                        <br/>\n");
#nullable restore
#line 250 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                         if(ViewBag.MostrarEstado)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 265 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                                      
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <div class=\"text-right\" style=\"font-size: 25px;\">\n                                <span>Subtotal:</span> \n                            Q <span id=\"subtotal-venta\">0.00</span> \n                            </div> \n");
            WriteLiteral("                            <div class=\"text-right\"  style=\"font-size: 25px;\">\n                                    <span>Descuento:</span> \n                                    Q <span id=\"descuento-venta\">0.00</span>           \n");
            WriteLiteral("                            </div> \n");
            WriteLiteral("                            <div class=\"text-right\" style=\"font-size: 25px;\">\n                                <span>Total:</span> \n                            Q <span id=\"precio-total-a-pagar\">0.00</span> \n                            </div> \n");
#nullable restore
#line 283 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_RealizarExamenClinico.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.RealizarExamenLabClinicoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
