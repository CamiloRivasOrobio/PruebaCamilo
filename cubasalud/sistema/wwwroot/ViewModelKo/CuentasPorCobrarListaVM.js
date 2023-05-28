var CuentasPorCobrarListaVM = function () {
    var self = this;
    self.cuentasPorCobrar = ko.observableArray();

    self.consultarCuentasPorCobrar = function () {

        self.clearTableCuentasPorCobrar();

        $.ajax({
            method: "POST",
            url: '/CuentasPorCobrar/ConsultarCuentasPorCobrar',
            success: function (data, textStatus) {
                if (data.exitoso) {
                    self.cuentasPorCobrar(data.resultado);
                    self.drawTableCuentasPorCobrar();
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.modificarCuenta = function (value) {
        window.location.href = "/CuentasPorCobrar/Modificar?cuentaId=" + value.id;
    };

    self.clearTableCuentasPorCobrar = function () {
        var table = $("#tabla-cuentas-por-cobrar").DataTable();
        table.clear().draw();

        $("#tabla-cuentas-por-cobrar").dataTable().fnDestroy();
    };
    self.drawTableCuentasPorCobrar = function () {
        $("#tabla-cuentas-por-cobrar").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por página",
                zeroRecords: "No hay registros para mostrar",
                info: "Mostrando página _PAGE_ de _PAGES_",
                infoEmpty: "",
                infoFiltered: "(filtrado de _MAX_ registros totales)",
                paginate: {
                    first: "Primero",
                    last: "Último",
                    previous: "Anterior",
                    next: "Siguiente"
                }
            }
        });
    };

    self.verDetallesCuenta = function (value) {
        window.location.href = "/CuentasPorCobrar/VerDetallesCuenta?cuentaId=" + value.id;
    };
    self.pagarCuenta = function (value) {
        window.location.href = "/CuentasPorCobrar/Pagar?cuentaId=" + value.id;
    };
}

var listaPersonasVM = new CuentasPorCobrarListaVM();
ko.applyBindings(listaPersonasVM);

$(document).ready(function () {
    listaPersonasVM.consultarCuentasPorCobrar();
});