#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f94e465e35f6cf4774c6d0e583324a6523f2e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas_ModificarExamenFisico), @"mvc.1.0.view", @"/Views/Consultas/ModificarExamenFisico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f94e465e35f6cf4774c6d0e583324a6523f2e8", @"/Views/Consultas/ModificarExamenFisico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultas_ModificarExamenFisico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ExamenFisicoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Consultas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Informacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModificarExamenFisico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
  
    ViewData["Title"] = "Editar Examen Fisico";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28f94e465e35f6cf4774c6d0e583324a6523f2e85542", async() => {
                WriteLiteral("\n\n    <div class=\"main-card mb-3 card\">\n        <div class=\"card-body\">\n\n            <div class=\"form-row\">\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 437, "\"", 445, 0);
                EndWriteAttribute();
                WriteLiteral(">Temperatura</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 19 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.Temperatura, new {@class="form-control", @placeholder="Temperatura"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 20 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.Temperatura, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 966, "\"", 974, 0);
                EndWriteAttribute();
                WriteLiteral(">Frecuencia Cardiaca</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 27 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.FrecuenciaCardiaca, new {@class="form-control", @placeholder="Frecuencia Cardiaca"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 28 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.FrecuenciaCardiaca, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 1525, "\"", 1533, 0);
                EndWriteAttribute();
                WriteLiteral(">Frecuencia Respiratoria </label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.FrecuenciaRespiratoria, new {@class="form-control", @placeholder="Frecuencia Respiratoria"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 39 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.FrecuenciaRespiratoria, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 2277, "\"", 2285, 0);
                EndWriteAttribute();
                WriteLiteral(">Saturación de oxígeno</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 46 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.SaturacionDeOxigeno, new {@class="form-control", @placeholder="Saturación de oxígeno"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 47 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.SaturacionDeOxigeno, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 2842, "\"", 2850, 0);
                EndWriteAttribute();
                WriteLiteral(">Presión arterial brazo derecho</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 54 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.PresionArterialBrazoDerecho, new {@class="form-control", @placeholder="Presión arterial brazo derecho"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 55 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.PresionArterialBrazoDerecho, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 3441, "\"", 3449, 0);
                EndWriteAttribute();
                WriteLiteral(">Presión arterial brazo izquierdo</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 62 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.PresionArterialBrazoIzquierdo, new {@class="form-control", @placeholder="Presión arterial brazo izquierdo"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 63 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.PresionArterialBrazoIzquierdo, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-6\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 4048, "\"", 4056, 0);
                EndWriteAttribute();
                WriteLiteral(">Presión arterial brazo derecho</label>\n                        ");
#nullable restore
#line 69 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextBoxFor(a => a.ExamenFisico.PresionArterialBrazoDerecho, new {@class="form-control", @placeholder="Presión arterial brazo derecho"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 70 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.PresionArterialBrazoDerecho, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n\n\n                 <div class=\"col-12\">\n                    <div class=\"position-relative form-group\"><label");
                BeginWriteAttribute("class", " class=\"", 4556, "\"", 4564, 0);
                EndWriteAttribute();
                WriteLiteral(">Observaciones o texto adicional</label>\n                        ");
#nullable restore
#line 77 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.TextAreaFor(a => a.ExamenFisico.Observaciones, new {@class="form-control", @placeholder="Observaciones o texto adicional"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 78 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                   Write(Html.ValidationMessageFor(a => a.ExamenFisico.Observaciones, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>


            <div class=""col-md-12"">
                <div class=""position-relative form-group"">
                    <button type=""submit"" class=""btn btn-primary text-white"">Guardar</button>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28f94e465e35f6cf4774c6d0e583324a6523f2e815269", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-consultaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Consultas/ModificarExamenFisico.cshtml"
                                                                                     WriteLiteral(Model.ConsultaId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["consultaId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-consultaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["consultaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n            </div>\n        </div>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ExamenFisicoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
