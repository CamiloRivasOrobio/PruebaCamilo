#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/Account/Nueva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd86e80e62cdb42d26215add1c2418e609d29f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Nueva), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Nueva.cshtml")]
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
#line 1 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/_ViewImports.cshtml"
using sistema.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/_ViewImports.cshtml"
using sistema.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using sistema.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abd86e80e62cdb42d26215add1c2418e609d29f0", @"/Areas/Identity/Pages/Account/Nueva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2947d87b04e371b09d1192120c8ef0e6c47a37de", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2054a10e98ff7493bc95723e9b770a0005720643", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Nueva : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/Account/Nueva.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n ");
#nullable restore
#line 8 "/root/farmaciaSistema_Farmamest/sistema/Areas/Identity/Pages/Account/Nueva.cshtml"
Write(await Html.PartialAsync("Register"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Nueva> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Nueva> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Nueva>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Nueva Model => ViewData.Model;
    }
}
#pragma warning restore 1591
