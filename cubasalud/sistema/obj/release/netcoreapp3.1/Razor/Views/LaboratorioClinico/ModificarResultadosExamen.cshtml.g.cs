#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39ab929a00f6fc69b72ae3cdb137cc63b746956f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LaboratorioClinico_ModificarResultadosExamen), @"mvc.1.0.view", @"/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ab929a00f6fc69b72ae3cdb137cc63b746956f", @"/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_LaboratorioClinico_ModificarResultadosExamen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ModificarResultadosExamen>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LaboratorioClinico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModificarResultadosExamen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
  
    ViewData["Title"] = "Modificar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n ");
#nullable restore
#line 6 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39ab929a00f6fc69b72ae3cdb137cc63b746956f4807", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 10 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
Write(Html.HiddenFor(a => a.ExamenId));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n    ");
#nullable restore
#line 11 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
Write(Html.HiddenFor(a => a.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 12 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
Write(Html.HiddenFor(a => a.DetalleExamen.ExamenLabClinicoId));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""form-row"">
                <div class=""col-12"">
                     <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 690, "\"", 698, 0);
                EndWriteAttribute();
                WriteLiteral(">Resultado</label>\n");
                WriteLiteral("                        ");
#nullable restore
#line 22 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
                   Write(Html.TextBoxFor(a => a.DetalleExamen.Resultado, new {@class="form-control",
                                       @placeholder="Resultados"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 24 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/ModificarResultadosExamen.cshtml"
                   Write(Html.ValidationMessageFor(a => a.DetalleExamen.Resultado, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""col-md-12"">
                <div class=""position-relative form-group"">
                    <button class=""btn btn-primary""> Guardar </button>
                </div>
            </div>

            </div>

            </div>
        </div>




");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ModificarResultadosExamen> Html { get; private set; }
    }
}
#pragma warning restore 1591
