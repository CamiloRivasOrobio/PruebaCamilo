#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cotizacion/Backup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b917eda445edad82bdbe391b04a71f8854b8c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cotizacion_Backup), @"mvc.1.0.view", @"/Views/Cotizacion/Backup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b917eda445edad82bdbe391b04a71f8854b8c3", @"/Views/Cotizacion/Backup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cotizacion_Backup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""app-page-title"">
    <div class=""page-title-wrapper"">

        <div class=""page-title-heading"">
            <div class=""page-title-icon"">
                <i class=""pe-7s-graph text-success"">
                </i>
            </div>
            <div>Reporte de Cotizaciones
                <div class=""page-title-subheading"">Cotizaciones
                </div>
            </div>

        </div>
    </div>
</div>



<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">
          
                <div class=""form-row"">
                    <div class=""col-md-6"">
                         <a");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 762, 1);
#nullable restore
#line 28 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cotizacion/Backup.cshtml"
WriteAttributeValue("", 716, Url.Action("CotizacionesListaPdf","CrearPDF"), 716, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\n                                    Generar Pdf Cotizaciones\n                                </a>\n                    </div>\n                    <div class=\"col-md-6\">\n                         <a");
            BeginWriteAttribute("href", " href=\"", 983, "\"", 1041, 1);
#nullable restore
#line 33 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Cotizacion/Backup.cshtml"
WriteAttributeValue("", 990, Url.Action("DetalleCotizacionListaPdf","CrearPDF"), 990, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">
                                    Generar Pdf Detalles Cotizacion
                                </a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591