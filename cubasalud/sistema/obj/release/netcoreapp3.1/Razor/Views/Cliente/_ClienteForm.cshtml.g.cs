#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c57573a75114b01b214fd59c1ee79d8a6bf65ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente__ClienteForm), @"mvc.1.0.view", @"/Views/Cliente/_ClienteForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c57573a75114b01b214fd59c1ee79d8a6bf65ae", @"/Views/Cliente/_ClienteForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente__ClienteForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ClientesBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""form-row"">

                <div class=""col-md-12"">
                    <div class=""position-relative form-group"">
                        <label");
            BeginWriteAttribute("class", " class=\"", 377, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombres</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 15 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Clientes.Nombre, new {@class="form-control",
                                       @placeholder="Nombre Cliente"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 17 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Clientes.Nombre, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <div class=\"form-row\">\n                <div class=\"col-md-4\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 1003, "\"", 1011, 0);
            EndWriteAttribute();
            WriteLiteral(">Teléfono</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 25 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Clientes.Telefono, new{ type="number", @class="form-control",
                                       @placeholder="Telefono"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 29 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Clientes.Telefono, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-md-4\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 1769, "\"", 1777, 0);
            EndWriteAttribute();
            WriteLiteral(">Celular</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 36 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Clientes.Celular, new{ type="number", @class="form-control",
                                       @placeholder="Celular"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 40 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Clientes.Celular, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-4\">\n                    <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", "  class=\"", 2509, "\"", 2518, 0);
            EndWriteAttribute();
            WriteLiteral(">Nit</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 46 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Clientes.Nit, new {type="number", @class="form-control",
                                       @placeholder="Nit"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 48 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Clientes.Nit, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                \n                <div class=\"col-md-12\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 3098, "\"", 3106, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion</label>\n\n");
            WriteLiteral("                        ");
#nullable restore
#line 58 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Clientes.Direccion, new{ @class="form-control",
                                       @placeholder="Direccion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 60 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Clientes.Direccion, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                </div>
                <div class=""form-row"">
                    </div>
                    <div class=""col-md-12"">
                        <div class=""position-relative form-group"">
                            <button class=""btn btn-primary"">Guardar</button>
                        </div>
                    </div>
                </div>
");
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ClientesBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
