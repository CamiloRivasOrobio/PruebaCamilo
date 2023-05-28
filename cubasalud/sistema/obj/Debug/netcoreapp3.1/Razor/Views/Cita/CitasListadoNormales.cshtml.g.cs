#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7c8bb043a26dd11f9d1cdbde9db1a83656754e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cita_CitasListadoNormales), @"mvc.1.0.view", @"/Views/Cita/CitasListadoNormales.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c8bb043a26dd11f9d1cdbde9db1a83656754e4", @"/Views/Cita/CitasListadoNormales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cita_CitasListadoNormales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ReporteCitasViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
  
    Layout = "_HojaLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de Citas </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE EMISI&#211;N </span>\n\t\t<span> ");
#nullable restore
#line 18 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
          Write(DateTime.Now.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">USUARIO QUE LO EMITE </span>\n\t\t<span> ");
#nullable restore
#line 23 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
          Write(Model.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
	</div>

    <div>
		<span class=""font-weight-bold"">Lugar </span>
		<span> Clínica </span>
	</div>
<br>

        <table class=""table table-bordered"">
                    <thead>
                    <tr>

                            <th style=""background: #1f4724 !important; color: white;"">Fecha</th>
                            <th style=""background: #1f4724 !important; color: white;"">Hora</th>
                            <th style=""background: #1f4724 !important; color: white;"">Especialdad</th>
                            <th style=""background: #1f4724 !important; color: white;"">Doctor</th>
                            <th style=""background: #1f4724 !important; color: white;"">Servicio</th>
                            <th style=""background: #1f4724 !important; color: white;"">Paciente</th>
                            <th style=""background: #1f4724 !important; color: white;"">Número</th>
                            <th style=""background: #1f4724 !important; color: white;"">Asitencia</th>
");
            WriteLiteral(@"                            <th style=""background: #1f4724 !important; color: white;"">Usuario</th>
                            <th style=""background: #1f4724 !important; color: white;"">Menor de edad</th>
                            <th style=""background: #1f4724 !important; color: white;"">Nombre encargado</th>
");
            WriteLiteral("                    </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 52 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                    foreach (var item in Model.Citas)
                        {
                            var cliente = item.Paciente == null ? "" : item.Paciente.Nombre;
                            var telefono = item.Paciente == null ? "" : item.Paciente.Telefono;
                            var celular = item.Paciente == null ? "" : item.Paciente.Celular;
                            var sexo = item.Paciente == null ? "" : item.Paciente.sexoText;
                           
                           var background = "";
                           var color = "";

                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                            if(item.EspecialidadText == "Medicina general")
                           {
                               background = "#2fb9e7";
                               color = "black";
                           }
                           else if(item.EspecialidadText == "Medicina estética")
                           {
                               background = "#A02B4E";
                               color = "white";
                           }
                           else if(item.EspecialidadText == "Ginecología y Obstetricia")
                           {
                               background = "#e660c3";
                               color = "white";
                           }
                           else if(item.EspecialidadText == "Pediatría")
                           {
                               background = "#ffa500";
                               color = "black";
                           }
                           else if(item.EspecialidadText == "Cirugía")
                           {
                               background = "#808080";
                               color = "white";
                           }

                           else if(item.EspecialidadText == "Traumatología")
                           {
                                background = "#000000";
                               color = "white";
                           }

                            else if(item.EspecialidadText == "Medicina interna")
                           {
                                background = "#8B4513";
                               color = "white";
                           }
                           

                            else if(item.EspecialidadText == "Laboratorio clínico")
                           {
                                background = "#008000";
                               color = "white";
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td> ");
#nullable restore
#line 109 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                Write(item.FechaInicio.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td> ");
#nullable restore
#line 110 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                Write(item.FechaInicio.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td");
            BeginWriteAttribute("style", " style=\"", 4866, "\"", 4912, 5);
            WriteAttributeValue("", 4874, "background:", 4874, 11, true);
#nullable restore
#line 111 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
WriteAttributeValue(" ", 4885, background, 4886, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4897, ";", 4897, 1, true);
            WriteAttributeValue(" ", 4898, "color:", 4899, 7, true);
#nullable restore
#line 111 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
WriteAttributeValue(" ", 4905, color, 4906, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 111 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                                                               Write(item.EspecialidadText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 112 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                Write(item.EmpleadoText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td> ");
#nullable restore
#line 113 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                Write(item.ServicioText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td>");
#nullable restore
#line 114 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                               Write(cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 115 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                               Write(telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 116 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                               Write(item.EstadoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 117 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                                Write(item.PersonText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                <td>");
#nullable restore
#line 118 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                               Write(item.EsMenorDeEdadText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 119 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                               Write(item.NombreEncargado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                           </tr>\n");
#nullable restore
#line 121 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cita/CitasListadoNormales.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n        </table>\n\n\n      \n \n\n      \t\n\t\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ReporteCitasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591