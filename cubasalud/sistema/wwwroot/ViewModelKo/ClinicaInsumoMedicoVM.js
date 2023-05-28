var ClinicaInsumoMedicoVM = function () {
    let itemEquivalencia = 1;
    var model = {};

    var self = this;
    self.unidadesCompra = ko.observableArray();
    self.unidadesVenta = ko.observableArray();
    self.equivalenciasProducto = ko.observableArray();
    self.unidadMedidaCompraSeleccionada = ko.observable();
    self.unidadMedidaVentaSeleccionada = ko.observable();
    //Categoria
    self.categorias = ko.observableArray();
    self.categoriaSeleccionada = ko.observable();
    self.nombreNuevaCategoria = ko.observable();
    //Marca
    self.marcas = ko.observableArray();
    self.marcaSeleccionada = ko.observable();
    self.nombreNuevaMarca = ko.observable();
    //Grupo
    self.gruposT = ko.observableArray();
    self.grupoTSeleccionado = ko.observable();
    self.nombreNuevoGrupoT = ko.observable();
    //Presentación
    self.presentaciones = ko.observableArray();
    self.presentacionSeleccionada = ko.observable();
    self.nombreNuevaPresentacion = ko.observable();

    self.seleccionarUnidadCompra = function (value) {
        $(".unidad-compra").removeClass("unidad-seleccionada");
        $("#unidad-compra-" + value.Id).addClass("unidad-seleccionada");
        self.unidadMedidaCompraSeleccionada(value);
    };
    self.seleccionarUnidadVenta = function (value) {
        $(".unidad-venta").removeClass("unidad-seleccionada");
        $("#unidad-venta-" + value.Id).addClass("unidad-seleccionada");
        self.unidadMedidaVentaSeleccionada(value);
    };

    self.consultarUnidadesCompra = function () {
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarUnidadesCompra',
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.unidadesCompra(dataResult.Resultado);
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarUnidadesVenta = function () {
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarUnidadesVenta',
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso)
                    self.unidadesVenta(dataResult.Resultado);
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    //Categorias
    self.consultarCategorias = function () {
        showLoading();
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarCategorias',
            success: function (data, textStatus) {
                hideLoading();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.categorias(dataResult.Resultado);
                }
                else {
                    alert(dataResult.Mensaje);
                }
            },
            error: function (data) {
                hideLoading();
                alert(data.error);
            }
        });
    };
    self.registrarNuevaCategoria = function () {
        if (confirm("¿Desea agregar esta nueva categoría?")) {
            showLoading();
            $.ajax({
                method: "POST",
                url: '/Categoria/NuevaCategoriaProducto',
                data: {
                    NombreCategoria: self.nombreNuevaCategoria()
                },
                success: function (data, textStatus) {
                    hideLoading();
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        self.nombreNuevaCategoria(null);
                        self.consultarCategorias();
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

    //Grupos T
    self.consultarGruposT = function () {
        showLoading();
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarGruposT',
            success: function (data, textStatus) {
                hideLoading();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.gruposT(dataResult.Resultado);
                }
                else {
                    alert(dataResult.Mensaje);
                }
            },
            error: function (data) {
                hideLoading();
                alert(data.error);
            }
        });
    };
    self.registrarNuevoGrupoT = function () {
        if (confirm("¿Desea agregar este nuevo grupo terapéutico?")) {
            showLoading();
            $.ajax({
                method: "POST",
                url: '/Categoria/NuevoGrupoT',
                data: {
                    NombreGrupoT: self.nombreNuevoGrupoT()
                },
                success: function (data, textStatus) {
                    hideLoading();
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        self.nombreNuevoGrupoT(null);
                        self.consultarGruposT();
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

    //Marcas
    self.consultarMarcas = function () {
        showLoading();
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarMarcas',
            success: function (data, textStatus) {
                hideLoading();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.marcas(dataResult.Resultado);
                }
                else {
                    alert(dataResult.Mensaje);
                }
            },
            error: function (data) {
                hideLoading();
                alert(data.error);
            }
        });
    };
    self.registrarNuevaMarca = function () {
        if (confirm("¿Desea agregar esta nueva marca?")) {
            showLoading();
            $.ajax({
                method: "POST",
                url: '/Categoria/NuevaMarcaProducto',
                data: {
                    NombreMarca: self.nombreNuevaMarca()
                },
                success: function (data, textStatus) {
                    hideLoading();
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        self.nombreNuevaMarca(null);
                        self.consultarMarcas();
                    }
                    else
                        alert(dataResult.Mensaje);
                },
                error: function (data) {
                    hideLoading();
                    alert(data.error);
                }
            });
        }
    };

    //Presentaciones
    self.consultarPresentaciones = function () {
        showLoading();
        $.ajax({
            method: "POST",
            url: '/Productos/ConsultarPresentaciones',
            success: function (data, textStatus) {
                hideLoading();
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.presentaciones(dataResult.Resultado);
                }
                else {
                    alert(dataResult.Mensaje);
                }
            },
            error: function (data) {
                hideLoading();
                alert(data.error);
            }
        });
    };
    self.registrarNuevaPresentacion = function () {
        if (confirm("¿Desea agregar esta nueva presentación?")) {
            showLoading();
            $.ajax({
                method: "POST",
                url: '/Categoria/NuevaPresentacionProducto',
                data: {
                    NombrePresentacion: self.nombreNuevaPresentacion()
                },
                success: function (data, textStatus) {
                    hideLoading();
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        self.nombreNuevaPresentacion(null);
                        self.consultarPresentaciones();
                    }
                    else
                        alert(dataResult.Mensaje);
                },
                error: function (data) {
                    hideLoading();
                    alert(data.error);
                }
            });
        }
    };

    self.agregarEquivalencia = function () {
        if (self.unidadMedidaCompraSeleccionada() == null || self.unidadMedidaCompraSeleccionada() == undefined) {
            alert("Seleccione una unidad de compra");
            return false;
        }
        if (self.unidadMedidaVentaSeleccionada() == null || self.unidadMedidaVentaSeleccionada() == undefined) {
            alert("Seleccione una unidad de venta");
            return false;
        }
        var equivalencia = new Object();
        equivalencia.Item = itemEquivalencia;
        equivalencia.Id = null;
        equivalencia.ProductoId = null;
        equivalencia.UnidadMedidaCompraId = self.unidadMedidaCompraSeleccionada().Id;
        equivalencia.UnidadMedidaCompraNombre = self.unidadMedidaCompraSeleccionada().Nombre;
        equivalencia.PrecioUnidadCompra = 0;
        equivalencia.UnidadMedidaVentaId = self.unidadMedidaVentaSeleccionada().Id;
        equivalencia.UnidadMedidaVentaNombre = self.unidadMedidaVentaSeleccionada().Nombre;
        equivalencia.CantidadEquivalente = 0;
        equivalencia.PrecioUnidadVenta = 0;
        equivalencia.PrecioUnidadVenta_1 = 0;
        self.equivalenciasProducto.push(equivalencia);
        itemEquivalencia++;
    };
    self.quitarEquivalencia = function (value) {
        $(self.equivalenciasProducto()).each(function (idx, equivalencia) {
            if (equivalencia.Item == value.Item) {
                self.equivalenciasProducto.splice(idx, 1);
            }
        });
    };

    self.getModel = function () {
        model = {
            "Id": $("#Id").val(),
            "CodigoReferencia": $("#CodigoReferencia").val(),
            "Nombre": $("#Nombre").val(),
            "Precio": $("#Precio").val(),
            "Precio_2": $("#Precio_2").val(),
            "Stock": $("#Stock").val(),
            "CategoriaId": self.categoriaSeleccionada().Id,
            "MarcaId": self.marcaSeleccionada().Id,
            "GrupoId": self.grupoTSeleccionado().Id,
            "PresentacionId": self.presentacionSeleccionada().Id,
            "UrlImagen": $("#UrlImagen").val(),
            "FechaVencimiento": $("#FechaVencimiento").val(),
            "Descripcion": $("#Descripcion").val(),

            "Equivalencias": self.equivalenciasProducto()
        };
    };

    self.registrarProducto = function () {
        showLoading();
        self.getModel();

        $.ajax({
            method: "POST",
            url: '/Productos/ClinicaInsumosMedicosNuevo',
            data: model,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso)
                    window.location.href = "/Productos/ClinicaInsumosMedicos/";
                else {
                    hideLoading();
                    alert(dataResult.Mensaje);
                }
            },
            error: function (data) {
                hideLoading();
                alert(data.error);
            }
        });
    };
    self.editarProducto = function () {
        self.getModel();

        $.ajax({
            method: "POST",
            url: '/Productos/ClinicaInsumosMedicosModificar',
            data: model,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso)
                    window.location.href = "/Productos/InsumosMedicosClinica/";
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    self.cancelarRegistroProducto = function () {
        if (confirm("¿Desea cancelar el registro de este insumo?")) {
            window.location.href = "/Productos/InsumosMedicosClinica/";
        }
    };
    self.cancelarEdicionProducto = function () {
        if (confirm("¿Desea cancelar la edición de este insumo?")) {
            window.location.href = "/Productos/InsumosMedicosClinica/";
        }
    };
}

var insumoVM = new ClinicaInsumoMedicoVM();
ko.applyBindings(insumoVM);

$(document).ready(function () {
    insumoVM.consultarUnidadesCompra();
    insumoVM.consultarUnidadesVenta();

    insumoVM.consultarCategorias();
    insumoVM.consultarMarcas();
    insumoVM.consultarGruposT();
    insumoVM.consultarPresentaciones();
});