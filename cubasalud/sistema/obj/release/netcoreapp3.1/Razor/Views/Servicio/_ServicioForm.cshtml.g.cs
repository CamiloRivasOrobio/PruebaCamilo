#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ddd09cf225d6169305f3691c1101da38d09f26"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ddd09cf225d6169305f3691c1101da38d09f26", @"/Views/Servicio/_ServicioForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio__ServicioForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ServicioBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""form-row"">

                <div class=""col-md-6"">
                    <div class=""position-relative form-group""><label for=""exampleEmail11""");
            BeginWriteAttribute("class", " class=\"", 370, "\"", 378, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre\n                            Servicio</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 13 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Servicio.NombreServicio, new {@class="form-control",
                                       @placeholder="Nombre Servicio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 15 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Servicio.NombreServicio, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1003, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio 1</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 21 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Servicio.Precio, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 25 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Servicio.Precio, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n                <div class=\"form-row\">\n                    <div class=\"col-md-12\">\n                        <div class=\"position-relative form-group\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 1840, "\"", 1848, 0);
            EndWriteAttribute();
            WriteLiteral(">Descripcion</label>\n");
            WriteLiteral("                            ");
#nullable restore
#line 34 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.TextAreaFor(a => a.Servicio.Descripcion,5,500 ,htmlAttributes : new {
                                               @class="form-control ", @placeholder="Descripcion", @style="max-width:100% !important;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            ");
#nullable restore
#line 38 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/_ServicioForm.cshtml"
                       Write(Html.ValidationMessageFor(a => a.Servicio.Descripcion, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""position-relative form-group"">
                            <button class=""btn btn-primary"">Guardar</button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>");
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
