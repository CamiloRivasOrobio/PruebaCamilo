#pragma checksum "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CuentasPorCobrarReciboPagoPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd7c2bda9b3dcf1bd9f2cc7d4f48521e219335dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_CuentasPorCobrarReciboPagoPDF), @"mvc.1.0.view", @"/Views/CrearPDF/CuentasPorCobrarReciboPagoPDF.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd7c2bda9b3dcf1bd9f2cc7d4f48521e219335dd", @"/Views/CrearPDF/CuentasPorCobrarReciboPagoPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_CuentasPorCobrarReciboPagoPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database.Shared.Models.Venta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CuentasPorCobrarReciboPagoPDF.cshtml"
  
    Layout = "_HojaLayout";
    DateTime fecha = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"form-row\">\r\n    <div class=\"col-md-12\">\r\n        <center><img width=\"150\" src=\"/assets/images/logo-redowl.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 229, "\"", 235, 0);
            EndWriteAttribute();
            WriteLiteral(@"></center>
    </div>
</div>
<div class=""form-row"">
    <div class=""col-md-12"">
        <center><h5>Recibo de pago de cuenta</h5></center>
        <hr />
    </div>
</div>
<div class=""form-row"">
    <div class=""col-md-12"">
        <center><b>Fecha y hora de emisión:</b> ");
#nullable restore
#line 20 "/home/ubuntu/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/CuentasPorCobrarReciboPagoPDF.cshtml"
                                           Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>\r\n        <hr />\r\n    </div>\r\n</div>\n\n\n\n");
            DefineSection("css", async() => {
                WriteLiteral(@"
<link rel=""preconnect"" href=""https://fonts.gstatic.com"">
<link href=""https://fonts.googleapis.com/css2?family=VT323&display=swap"" rel=""stylesheet"">
<link href=""https://fonts.googleapis.com/css?family=Libre+Barcode+128|VT323"" rel=""stylesheet"">
<style>

    * {
        margin: 0;
        box-sizing: border-box;
        font-family: 'VT323', monospace;
");
                WriteLiteral(@" color: #1f1f1f;
        font-size: 20px;
    }

    tr {
        page-break-inside: avoid !important;
        page-break-after: auto !important;
    }

    .table thead tr th, .table tbody tr td {
        border: none;
    }

    .container {
    }

    .bold {
        font-weight: bold;
    }

    .center {
        text-align: center;
    }

    .receipt {
        width: 64mm;
");
                WriteLiteral(" height: 100%;\n");
                WriteLiteral(" ");
                WriteLiteral(" ");
                WriteLiteral(@"
    }

    .logo {
        text-align: center;
        padding: 20px;
        font-size: 1.5em;
    }

    .barcode {
        font-family: ""Libre Barcode 128"", cursive;
        font-size: 42px;
        text-align: center;
    }

    .address {
        text-align: center;
        margin-bottom: 10px;
    }

    .transactionDetails {
        display: flex;
        justify-content: space-between;
        margin: 0 5px 5px;
    }

        .transactionDetails .detail {
            text-transform: uppercase;
        }

    .centerItem {
        display: flex;
        justify-content: center;
        margin-bottom: 8px;
    }

    .survey {
        text-align: center;
        margin-bottom: 12px;
    }

        .survey .surveyID {
            font-size: 20px;
        }

    .paymentDetails {
        display: flex;
        justify-content: space-between;
        margin: 0 auto;
        width: 150px;
    }

    .creditDetails {
        margin: 10px auto;
        width: 230px;
        font-size: 14px;
        text-tra");
                WriteLiteral(@"nsform: uppercase;
    }

    .receiptBarcode {
        margin: 10px 0;
        text-align: center;
    }

    .returnPolicy {
        margin: 10px 20px;
        width: 220px;
        display: flex;
        justify-content: space-between;
    }

    .coupons {
        margin-top: 20px;
    }

    .tripSummary {
        margin: auto;
        width: 255px;
    }

        .tripSummary .item {
            display: flex;
            justify-content: space-between;
            margin: auto;
            width: 220px;
        }

    .feedback {
        margin: 20px auto;
    }

        .feedback h3.clickBait {
            font-size: 30px;
            font-weight: bold;
            text-align: center;
            margin: 10px 0;
        }

        .feedback h4.web {
            font-size: 20px;
            font-weight: bold;
            text-align: center;
            margin: 10px 0;
        }

        .feedback .break {
            text-align: center;
            font-size: 18px;
            font-weight: bold;
      ");
                WriteLiteral(@"      margin: 10px 0;
        }

    .couponContainer {
        border-top: 1px dashed #1f1f1f;
        margin-bottom: 20px;
    }

        .couponContainer .discount {
            font-size: 35px;
            text-align: center;
            margin-bottom: 10px;
        }

        .couponContainer .discountDetails {
            font-size: 20px;
            text-align: center;
            margin-bottom: 15px;
        }

        .couponContainer .barcode {
            margin: 10px 0 0;
        }

        .couponContainer .legal {
            font-size: 12px;
            margin-bottom: 12px;
        }

        .couponContainer .barcodeID {
            margin-bottom: 8px;
        }

        .couponContainer .expiration {
            display: flex;
            justify-content: space-between;
            margin: 10px;
        }

        .couponContainer .couponBottom {
            font-size: 13px;
            text-align: center;
        }
</style>
");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database.Shared.Models.Venta> Html { get; private set; }
    }
}
#pragma warning restore 1591