var CompraVM = function () {
    var model = {};
    var itemProductosComprados = 1;
    var self = this;
    self.laboratorios = ko.observableArray();
    self.laboratorioSeleccionado = ko.observable();
    self.productosRegistrados = ko.observableArray();
    self.productoRegistradoSeleccionado = ko.observable();
    self.productosComprados = ko.observableArray();
    self.totalCompra = ko.observable((0).toFixed(2));

    self.consultarLaboratorios = function () {
        $("#div-loading").show();
        $.ajax({
            method: "POST",
            url: '/Compra/ConsultarLaboratorios',
            success: function (data) {
                $("#div-loading").hide();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.laboratorios.push({ Id: null, NombreLaboratorioProducto: "Todos" });
                    $(dataResult.Laboratorios).each(function (idx, vl) {
                        self.laboratorios.push(vl);
                    });
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.laboratorioSeleccionado.subscribe(function (value) {
        self.consultarProductosRegistrados();
    });
    self.consultarProductosRegistrados = function () {
        $("#div-loading").show();
        $.ajax({
            method: "POST",
            url: '/Compra/ConsultarProductosRegistrados',
            data: {
                laboratorioId: self.laboratorioSeleccionado().Id
            },
            success: function (data) {
                $("#div-loading").hide();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.productosRegistrados(dataResult.ProductosRegistrados);
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };

    self.consultarUnidadesVenta = function (noItem, productoId, unidadCompraId) {
        $("#div-loading").show();
        $.ajax({
            method: "POST",
            url: '/Compra/ConsultarUnidadesVentaProducto',
            data: {
                productoId: productoId,
                unidadCompraId: unidadCompraId
            },
            success: function (data) {
                $("#div-loading").hide();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    $(self.productosComprados()).each(function (idx, vl1) {
                        vl1.UnidadesVenta = [];
                        $(dataResult.UnidadesVenta).each(function (idx, unidad) {
                            vl1.UnidadesVenta.push(unidad.Id);
                        });
                    });
                    $(dataResult.UnidadesVenta).each(function (idx, vl) {
                        var unidadVenta = `<div class="form-row">
                                                <div class="col-md-6">
                                            <b>${vl.NombreUnidad}</b> (${vl.Equivalencia})
                                       </div>
                                       <div class="col-md-6">
                                               Precio general:
                                            <input type="text" class="form-control"
                                                    value="0" id="item-${noItem}-precio-unidad-${vl.Id}"/>
                                               Precio especial:
                                            <input type="text" class="form-control"
                                                    value="0" id="item-${noItem}-precio-2-unidad-${vl.Id}"/>
                                       </div>
                                             </div>`;
                        $("#unidades-venta-item-" + noItem).append(unidadVenta);
                    });
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.agregarProductoCompra = function () {
        $("#div-loading").show();
        $.ajax({
            method: "POST",
            url: '/Compra/ConsultarUnidadesCompraProducto',
            data: {
                productoId: self.productoRegistradoSeleccionado().Id
            },
            success: function (data) {
                $("#div-loading").hide();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    var productoComprado = {
                        Item: itemProductosComprados,
                        ProductoId: self.productoRegistradoSeleccionado().Id,
                        NombreProducto: self.productoRegistradoSeleccionado().NombreProducto,
                        Cantidad: ko.observable(0),
                        PrecioCompra: ko.observable(0),
                        Total: ko.observable(0)
                    };
                    self.productosComprados.push(productoComprado);

                    $(dataResult.UnidadesCompra).each(function (idx, vl) {
                        $("#unidad-compra-item-" + itemProductosComprados).append("<option value='" +
                            vl.Id +
                            "'>" +
                            vl.NombreUnidad +
                            "</option>");
                    });
                    self.consultarUnidadesVenta(itemProductosComprados,
                        self.productoRegistradoSeleccionado().Id,
                        $("#unidad-compra-item-" + itemProductosComprados).val());
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });

        itemProductosComprados++;
        mensajeEmergente("Producto agregado");
    };
    self.calcularPrecios = function (value) {
        var cantidad = 0;
        var precioCompra = 0;
        cantidad = parseFloat(value.Cantidad());
        precioCompra = parseFloat(value.PrecioCompra());
        value.Total((cantidad * precioCompra).toFixed(2));

        var totalCompra = 0;
        $(self.productosComprados()).each(function (idx, vl) {
            totalCompra += parseFloat(vl.Total());
        });
        self.totalCompra(totalCompra.toFixed(2));
    };

    self.getModel = function () {
        $(self.productosComprados()).each(function (idx, vl) {
            var unidadesMedidaVenta = [];
            $(vl.UnidadesVenta).each(function (idx1, unidadId) {
                unidadesMedidaVenta.push({
                    Id: unidadId,
                    Precio: $(`#item-${vl.Item}-precio-unidad-${unidadId}`).val(),
                    Precio_2: $(`#item-${vl.Item}-precio-2-unidad-${unidadId}`).val()
                });
            });
            vl.UnidadMedidaCompra = { Id: $("#unidad-compra-item-" + vl.Item).val() };
            vl.UnidadesMedidaVenta = unidadesMedidaVenta;
        });
        model = {
            "CompraId": $("#CompraId").val(),
            "EncabezadoNoComprobante": $("#EncabezadoNoComprobante").val(),
            "EncabezadoEmpleadoId": $("#EncabezadoEmpleadoId").val(),
            "EncabezadoProveedor": $("#EncabezadoProveedor").val(),
            "EncabezadoFechaLimite": $("#EncabezadoFechaLimite").val(),
            "EncabezadoObservacion": $("#EncabezadoObservacion").val(),
            "EncabezadoTipoCompraId": $("#EncabezadoTipoCompraId").val(),

            //Detalles
            "ProductosComprados": self.productosComprados()
        };
    };

    self.guardarComoCompra = function () {
        if (confirm("¿Desea registrar esta COMPRA?")) {

            self.getModel();

            $.ajax({
                method: "POST",
                url: '/Compra/GuardarComoCompra',
                data: model,
                success: function (data) {
                    window.location.href = "/Compra/Modificar/" + data;
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };
    self.guardarComoPedido = function () {
        if (confirm("¿Desea registrar este PEDIDO?")) {

            self.getModel();

            $.ajax({
                method: "POST",
                url: '/Compra/GuardarComoPedido',
                data: model,
                success: function (data) {
                    window.location.href = "/Compra/Modificar/" + data;
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };

    self.cancelarRegistroCompra = function () {
        if (confirm("¿Desea cancelar el registro de la compra?")) {
            window.location.href = "/Compra/ListaTodas";
        }
    };
}

var compraVM = new CompraVM();
ko.applyBindings(compraVM);

$(document).ready(function () {
    $("#tabs").tabs();
    $('.select2bs4').select2({
        theme: 'bootstrap4',
        tags: true,
    });
    $('#fechalimite').daterangepicker({
        timePicker: true,
        singleDatePicker: true,
        locale: {
            format: 'MM/DD/YYYY hh:mm A'
        }
    });

    compraVM.consultarLaboratorios();

    $(".unidad-compra-producto").on("change", function () {
        var noItem = $(this.id).replace("unidad-compra-item", "");
        var productoId = $("#producto-id-item-" + noItem).val();
        compraVM.consultarUnidadesVenta(noItem, productoId, $(this).val());
    });
});

function ModificarCompra(id) {

    var productoDetalleTabla = new Array();
    var productosEnBaseDeDatos = new Array();

    // $.each($("#tablecompra tbody tr td.nuevos"), function() {
    //     ids_insertados.push({
    //         "Ids": $(this).html(),
    //     });
    // });

    $.each($("#tablecompra tbody tr td.nuevo-detalle"), function () {
        productoDetalleTabla.push({
            "Ids": parseInt($(this).parent().find("td").eq(0).html()),
            "Cantidad": parseInt($(this).parent().find("td").eq(2).find("input").val()),
            "Precio": parseInt($(this).parent().find("td").eq(3).find("input").val()),
            "Total": parseInt($(this).parent().find("td").eq(4).html()),
        });
    });

    $.each($("#tablecompra tbody tr td.idProd"), function () {

        productosEnBaseDeDatos.push({
            "Id": parseInt($(this).html()),
            "ProductoId": parseInt($(this).parent().find("td").eq(6).html()),
            "Cantidad": parseInt($(this).parent().find("td").eq(2).find("input").val()),
            "Precio": parseInt($(this).parent().find("td").eq(3).find("input").val()),
            "Total": parseInt($(this).parent().find("td").eq(4).html()),
        });
    });

    var datos = {
        "encabezado": {
            "CompraId": id,
            "Proveedor": $("#proveedorselect option:selected").text(),
            "NoComprobante": document.getElementById('nocomprobante').value,
            "EmpleadoId": parseInt(document.getElementById('empleadocompraid').value),
            "FechaLimite": document.getElementById('fechalimite').value,
            "Observacion": document.getElementById('observacion').value,
            "TipoCompraId": document.getElementById('tipolistaselect').value,
        },
        //listas
        "nuevos": productoDetalleTabla,
        "detalle": productosEnBaseDeDatos,
    };

    console.log(datos);

    $.ajax({
        method: "POST",
        data: JSON.stringify(datos),
        "dataType": "json",
        "contentType": "application/json",
        url: '/Compra/ModificarCompra',
        traditional: true,
        success: function (data, textStatus) {

            alert("OK");
        },
        error: function (data) {
            alert(data.error);
        }
    });

}

function CambiarAComprado(compraId) {
    var datos = { "compraId": compraId };

    $.ajax({
        method: "POST",
        data: datos,
        // dataType: "json",
        // contentType: "application/json",
        url: '/Compra/CambiarAComprado/',
        traditional: true,
        success: function (data) {
            alert("OK")
        },
        error: function (data) {
            console.log(data);
        }
    });
}