#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/NuevaVentaUnificada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043368ccbff6f4da38365f5f04f5954c95f57473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_NuevaVentaUnificada), @"mvc.1.0.view", @"/Views/Venta/NuevaVentaUnificada.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043368ccbff6f4da38365f5f04f5954c95f57473", @"/Views/Venta/NuevaVentaUnificada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_NuevaVentaUnificada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/NuevaVentaUnificada.cshtml"
  
    ViewData["Title"] = "Nueva Venta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Venta/NuevaVentaUnificada.cshtml"
Write(await Html.PartialAsync("_VentaUnificadaForm"));

#line default
#line hidden
#nullable disable
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
