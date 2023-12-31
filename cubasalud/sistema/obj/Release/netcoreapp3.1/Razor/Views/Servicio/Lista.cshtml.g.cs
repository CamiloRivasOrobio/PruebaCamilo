#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b720c9de774d6b8577e7e66395450e53bc357af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicio_Lista), @"mvc.1.0.view", @"/Views/Servicio/Lista.cshtml")]
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
#line 1 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
using Database.Shared.Paginacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b720c9de774d6b8577e7e66395450e53bc357af", @"/Views/Servicio/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Database.Shared.Models.Servicio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ViewModelKo/ServiciosListaVM.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
  
    ViewData["Title"] = "Lista Servicios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""main-card mb-3 card"">
    <div class=""card-body"">
        <div class=""text-center"">
            <h4><b>Servicios</b></h4>
        </div>
    </div>
</div>

<div class=""main-card mb-3 card"">
    <div class=""card-body"">
        <div class=""form-row"">
            <div class=""col-md-12"">
                <a href=""/Servicio/Nuevo"" class=""btn btn-primary"">Nuevo</a>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"
<div class=""main-card mb-3 card"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table id=""tabla-servicios"">
                <thead>
                    <tr>
                        <th>Nombre Servicio</th>
                        <th>Precio</th>
                        <th>Precio Vip</th>
                        <th>Precio Social</th>
                        <th>Precio IGSS</th>
                        <th>Descripcion</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 51 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 54 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.NombreServicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 55 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 56 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.Precio_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 57 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.Precio_3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 58 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.Precio_4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 59 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1809, "\"", 1872, 1);
#nullable restore
#line 61 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
WriteAttributeValue("", 1816, Url.Action("Modificar","Servicio", new {id = @item.Id}), 1816, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\n                                    Modificar\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2016, "\"", 2078, 1);
#nullable restore
#line 64 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
WriteAttributeValue("", 2023, Url.Action("Eliminar","Servicio", new {id = @item.Id}), 2023, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\n                                    Eliminar\n                                </a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 69 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/Servicio/Lista.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script src=""https://knockoutjs.com/downloads/knockout-3.5.1.js""></script>
<script src=""https://cdn.datatables.net/1.13.4/js/jquery.dataTables.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b720c9de774d6b8577e7e66395450e53bc357af8926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Database.Shared.Models.Servicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
