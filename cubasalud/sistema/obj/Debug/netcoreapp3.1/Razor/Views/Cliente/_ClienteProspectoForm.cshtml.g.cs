#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cliente/_ClienteProspectoForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e45f1ef7fc8452e730bd32f5ea8d135ca9e139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente__ClienteProspectoForm), @"mvc.1.0.view", @"/Views/Cliente/_ClienteProspectoForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e45f1ef7fc8452e730bd32f5ea8d135ca9e139", @"/Views/Cliente/_ClienteProspectoForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente__ClienteProspectoForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ClienteProspectoViewModel>
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
                    <center><h2><b>Nuevo cliente (prospecto)</b></h2></center>
                </div>
");
            WriteLiteral(@"            </div>
            <div class=""form-row"">
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Nombre</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Nombre"" />
");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Teléfono</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Teléfono"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Estado</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Estado"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Tipificación</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Tipificación"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative");
            WriteLiteral(@" form-group"">
                        <label>Activo</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Activo"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Tipo de paciente</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Tipo de paciente"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Modalidad de atención</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Modalidad de atención"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Religión</label><br>
                        <input type=""t");
            WriteLiteral(@"ext"" class=""form-control"" placeholder=""Religión"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Estado civil</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Estado civil"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Ocupación</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Ocupación"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Dirección</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Dirección"" />
                    </div>
                </div>
                <div class=""");
            WriteLiteral(@"col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Sexo</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Sexo"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Nacionalidad</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Nacionalidad"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>País de residencia</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""País de residencia"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Tipo de sangre</l");
            WriteLiteral(@"abel><br>
                        <input type=""text"" class=""form-control"" placeholder=""Tipo de sangre"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>NIT</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""NIT"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>DPI</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""DPI"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Departamento</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Departamento"" />
                    </div>
                </div");
            WriteLiteral(@">
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Municipio</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Municipio"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Contacto de emergencia</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Contacto de emergencia"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
                        <label>Email</label><br>
                        <input type=""text"" class=""form-control"" placeholder=""Email"" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""position-relative form-group"">
              ");
            WriteLiteral("          <label>Contraseña</label><br>\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Contraseña\" />\n                    </div>\n                </div>\n\n\n\n");
            WriteLiteral("\n");
            WriteLiteral(@"            </div>
            <div class=""form-row"">
                <div class=""col-md-12"">
                    <div class=""main-card mb-3 card"">
                        <div class=""card-header"">
                            <i class=""header-icon lnr-license icon-gradient bg-plum-plate""> </i>Información de cliente
                            <div class=""btn-actions-pane-right"">
                                <div class=""nav"">
                                    <a data-toggle=""tab"" href=""#tab-eg2-0""
                                       class=""btn-pill btn-wide mr-1 ml-1 active btn btn-outline-alternate btn-sm"">General</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-1""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Dental</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-2""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Médico</a>
  ");
            WriteLiteral(@"                                  <a data-toggle=""tab"" href=""#tab-eg2-3""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Pediátricos</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-4""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Ginecológicos</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-5""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Neurológicos</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-6""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Patológico</a>
                                    <a data-toggle=""tab"" href=""#tab-eg2-7""
                                       class=""btn-pill btn-wide mr-1 ml-1 btn btn-outline-alternate btn-sm"">Nutricional</a>
                             ");
            WriteLiteral(@"   </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""tab-eg2-0"" role=""tabpanel"">
                                    General
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-1"" role=""tabpanel"">
                                    Dental
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-2"" role=""tabpanel"">
                                    Médico
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-3"" role=""tabpanel"">
                                    Pediátricos
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-4"" role=""tabpanel"">
                                    Ginecológicos
                         ");
            WriteLiteral(@"       </div>
                                <div class=""tab-pane"" id=""tab-eg2-5"" role=""tabpanel"">
                                    Neurológicos
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-6"" role=""tabpanel"">
                                    Patológico
                                </div>
                                <div class=""tab-pane"" id=""tab-eg2-7"" role=""tabpanel"">

                                    <h4><b>Seguimiento nutricional</b></h4><br>
                                    <div class=""table-responsive"">
                                        <table class=""mb-0 table table-hover "">
                                            <thead>
                                                <tr>
                                                    <td rowspan=""2""><b>Datos</b></td>
                                                    <td colspan=""6""><center><b>Fechas</b></center></td>
                                                </tr>
 ");
            WriteLiteral(@"                                               <tr>
                                                    <td>2023</td>
                                                    <td>2024</td>
                                                    <td>2025</td>
                                                    <td>2026</td>
                                                    <td>2027</td>
                                                    <td>2028</td>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td><b>Peso</b></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""for");
            WriteLiteral(@"m-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>IMC</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
          ");
            WriteLiteral(@"                                          <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>PGC</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                  ");
            WriteLiteral(@"                  <td>Cuello</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>Busto</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""");
            WriteLiteral(@"/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>Cintura/Abdomen</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
        ");
            WriteLiteral(@"                                            <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>Cadera</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                 ");
            WriteLiteral(@"               </tr>
                                                <tr>
                                                    <td>Muslo</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>Brazo</td>
                                                    <td><input type=""text"" class=""form-cont");
            WriteLiteral(@"rol""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td>Muñeca</td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
             ");
            WriteLiteral(@"                                       <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                            </tbody>
                                        </table><br><br>
                                    </div>
                                    <h4><b>Resultado de exámenes de laboratorio</b></h4><br>
                                    <div class=""table-responsive"">
                                        <table class=""mb-0 table table-hover "">
                                            <thead>
                                                <tr>
                                                    <td><b>Examen</b></td>
                                                    <td><center><b>1°</b></center></td>
             ");
            WriteLiteral(@"                                       <td><center><b>2°</b></center></td>
                                                    <td><center><b>3°</b></center></td>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td><b>Glucosa Pre</b></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Glucosa Post</b></td>
                                                    <td><input type=""tex");
            WriteLiteral(@"t"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Hemoglobina Glicosilada</b></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                    <td><input type=""text"" class=""form-control""/></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
      ");
            WriteLiteral(@"                  </div>
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
");
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ClienteProspectoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591