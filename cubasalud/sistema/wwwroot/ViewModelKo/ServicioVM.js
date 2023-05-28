var ServicioVM = function () {
    let itemInsumoAgregado = 1;
    var model = {};
    var self = this;
    self.insumos = ko.observableArray();
    self.productoEquivalencias = ko.observableArray();
    self.unidadesVentaInsumo = ko.observableArray();
    self.insumosUtilizados = ko.observableArray();
    self.insumoSeleccionado = ko.observable();
    self.unidadVentaSeleccionada = ko.observable();
    self.cantidadUtilizadaInsumo = ko.observable();

    self.consultarInsumos = function () {
        $.ajax({
            method: "POST",
            url: '/Servicio/ConsultarInsumosExistentes',
            success: function (data, textStatus) {
                if (data.exitoso) {
                    self.insumos(data.resultado);
                    self.consultarUnidadesVentaInsumo(self.insumoSeleccionado().id);
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    self.consultarUnidadesVentaInsumo = function (productoId) {
        $.ajax({
            method: "POST",
            url: '/Servicio/ConsultarUnidadesVentaInsumo',
            data: {
                "productoId": productoId
            },
            success: function (data, textStatus) {
                if (data.exitoso) {
                    self.productoEquivalencias(data.resultado);
                    self.unidadesVentaInsumo([]);
                    $(data.resultado).each(function (idx, vl) {
                        self.unidadesVentaInsumo.push(vl.unidadMedidaVenta);
                    });
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    self.insumoSeleccionado.subscribe(function (value) {
        self.consultarUnidadesVentaInsumo(value.id);
    });

    self.agregarInsumo = function () {
        var insumoAgregado = new Object();
        insumoAgregado.Item = itemInsumoAgregado;
        insumoAgregado.ProductoId = self.insumoSeleccionado().id;
        insumoAgregado.NombreInsumo = self.insumoSeleccionado().nombreProducto;
        insumoAgregado.UnidadMedidaVentaId = self.unidadVentaSeleccionada().id;
        insumoAgregado.UnidadMedidaVentaNombre = self.unidadVentaSeleccionada().nombre;
        insumoAgregado.CantidadUtilizada = self.cantidadUtilizadaInsumo();

        self.insumosUtilizados.push(insumoAgregado);
        itemInsumoAgregado++;
    };
    self.quitarInsumoUtilizado = function (value) {
        $(self.insumosUtilizados()).each(function (idxInsumo, insumo) {
            if (insumo.Item == value.Item) {
                console.log("Cumple condición");
                self.insumosUtilizados.splice(idxInsumo, 1);
            }
        });
    };

    self.getModel = function () {
        model = {
            "Id": $("#Id").val(),
            "NombreServicio": $("#NombreServicio").val(),
            "Precio": $("#Precio").val(),
            "Precio_2": $("#Precio_2").val(),
            "Precio_3": $("#Precio_3").val(),
            "Precio_4": $("#Precio_4").val(),
            "Descripcion": $("#Descripcion").val(),

            "InsumosUtilizados": self.insumosUtilizados()
        };
    };
    self.registrarServicio = function () {
        if (confirm("¿Desea registrar este nuevo servicio?")) {
            self.getModel();
            $.ajax({
                method: "POST",
                url: '/Servicio/Nuevo',
                data: model,
                success: function (data, textStatus) {
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        window.location.href = "/Servicio/Lista";
                    }
                    else
                        alert(dataResult.Mensaje);
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };
    self.cancelarRegistroServicio = function () {
        if (confirm("¿Desea cancelar el registro del servicio?")) {
            window.location.href = "/Servicio/Lista";
        }
    };
    self.editar = function () {
        if (confirm("¿Desea editar este servicio?")) {
            self.getModel();
            $.ajax({
                method: "POST",
                url: '/Servicio/Modificar',
                data: model,
                success: function (data, textStatus) {
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        window.location.href = "/Servicio/Lista";
                    }
                    else
                        alert(dataResult.Mensaje);
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };
    self.cancelarEdicionServicio = function () {
        if (confirm("¿Desea cancelar la edición del servicio?")) {
            window.location.href = "/Servicio/Lista";
        }
    };
}

var servicioVm = new ServicioVM();
ko.applyBindings(servicioVm);

$(document).ready(function () {
    servicioVm.consultarInsumos();
});