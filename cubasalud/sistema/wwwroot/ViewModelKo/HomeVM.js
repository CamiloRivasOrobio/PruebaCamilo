var HomeVM = function () {
    var self = this;
    self.cuentasPendientes = ko.observableArray();
    self.pacientesCumpleannios = ko.observableArray();
    self.pacientesAplicablesMembresia = ko.observableArray();
    self.pacientesContacto = ko.observableArray();
    self.pacientesAniversario = ko.observableArray();

    //Consultas dashboard
    self.consultarCuentasPendientes = function () {
        $("#div-loading").show();
        self.clearTableCuentasPendientes();

        $.ajax({
            method: "POST",
            url: '/CuentasPorCobrar/ConsultarCuentasPorCobrar',
            success: function (data, textStatus) {
                $("#div-loading").hide();
                if (data.exitoso) {
                    var cuentasPendientesProximoPago = new Array();
                    var fechaActual = moment();
                    $(data.resultado).each(function (idx, vl) {
                        var diferencia = moment(vl.fechaLimitePago).diff(fechaActual, 'day');
                        if (diferencia >= 0 && diferencia <= 3) {
                            cuentasPendientesProximoPago.push(vl);
                        }
                    });
                    self.cuentasPendientes(cuentasPendientesProximoPago);
                    self.drawTableCuentasPendientes();
                }
                else {
                    alert(data.mensaje);
                }
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.consultarPacientesCumpleannios = function () {
        $("#div-loading").show();
        self.clearTablePacientesCumpleannios();

        $.ajax({
            method: "POST",
            url: '/Home/ConsultarPacientesCumpleannios',
            success: function (data, textStatus) {
                $("#div-loading").hide();
                if (data.exitoso) {
                    self.pacientesCumpleannios(data.resultado);
                    self.drawTablePacientesCumpleannios();
                }
                else {
                    alert(data.mensaje);
                }
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.consultarPacientesAplicablesMembresia = function () {
        $("#div-loading").show();
        self.clearTablePacientesAplicablesMembresia();

        $.ajax({
            method: "POST",
            url: '/Home/ConsultarPacientesAplicablesMembresia',
            success: function (data) {
                $("#div-loading").hide();
                if (data.exitoso) {
                    self.pacientesAplicablesMembresia(data.resultado);
                    self.drawTablePacientesAplicablesMembresia();
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.consultarPacientesContacto = function () {
        $("#div-loading").show();
        self.clearTablePacientesContacto();

        $.ajax({
            method: "POST",
            url: '/Home/ConsultarPacientesRetiradosContactar',
            success: function (data) {
                $("#div-loading").hide();
                if (data.exitoso) {
                    self.pacientesContacto(data.resultado);
                    self.drawTablePacientesContacto();
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.consultarPacientesAniversario = function () {
        $("#div-loading").show();
        self.clearTablePacientesAniversario();

        $.ajax({
            method: "POST",
            url: '/Home/ConsultarPacientesAniversario',
            success: function (data) {
                $("#div-loading").hide();
                if (data.exitoso) {
                    self.pacientesAniversario(data.resultado);
                    self.drawTablePacientesAniversario();
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                $("#div-loading").hide();
                alert(data.error);
            }
        });
    };
    self.aplicarMembresia = function (value) {
        $("#div-loading").show();
        window.location.href = "/Pacientes/AplicarMembresia?pacienteId=" + value.id;
    };

    //Tables
    self.clearTableCuentasPendientes = function () {
        var table = $("#tabla-cuentas-pendientes").DataTable();
        table.clear().draw();

        $("#tabla-cuentas-pendientes").dataTable().fnDestroy();
    };
    self.drawTableCuentasPendientes = function () {
        $("#tabla-cuentas-pendientes").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            lengthMenu: [
                [5, 10, 25, 50, -1],
                ['5', '10', '25', '50', 'Todos']
            ],
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
    self.clearTablePacientesCumpleannios = function () {
        var table = $("#tabla-pacientes-cumpleannios").DataTable();
        table.clear().draw();

        $("#tabla-pacientes-cumpleannios").dataTable().fnDestroy();
    };
    self.drawTablePacientesCumpleannios = function () {
        $("#tabla-pacientes-cumpleannios").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            lengthMenu: [
                [5, 10, 25, 50, -1],
                ['5', '10', '25', '50', 'Todos']
            ],
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
    self.clearTablePacientesAplicablesMembresia = function () {
        var table = $("#tabla-pacientes-aplicables-membresia").DataTable();
        table.clear().draw();

        $("#tabla-pacientes-aplicables-membresia").dataTable().fnDestroy();
    };
    self.drawTablePacientesAplicablesMembresia = function () {
        $("#tabla-pacientes-aplicables-membresia").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            lengthMenu: [
                [5, 10, 25, 50, -1],
                ['5', '10', '25', '50', 'Todos']
            ],
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
    self.clearTablePacientesAniversario = function () {
        var table = $("#tabla-pacientes-aniversario").DataTable();
        table.clear().draw();

        $("#tabla-pacientes-aniversario").dataTable().fnDestroy();
    };
    self.drawTablePacientesAniversario = function () {
        $("#tabla-pacientes-aniversario").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            lengthMenu: [
                [5, 10, 25, 50, -1],
                ['5', '10', '25', '50', 'Todos']
            ],
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
    self.clearTablePacientesContacto = function () {
        var table = $("#tabla-pacientes-contacto").DataTable();
        table.clear().draw();

        $("#tabla-pacientes-contacto").dataTable().fnDestroy();
    };
    self.drawTablePacientesContacto = function () {
        $("#tabla-pacientes-contacto").DataTable({
            searching: true,
            ordering: true,
            paging: true,
            lengthMenu: [
                [5, 10, 25, 50, -1],
                ['5', '10', '25', '50', 'Todos']
            ],
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
}


var homeVM = new HomeVM();
ko.applyBindings(homeVM);

$(document).ready(function () {
    homeVM.consultarPacientesCumpleannios();
    homeVM.consultarPacientesAplicablesMembresia();
    homeVM.consultarPacientesAniversario();
    homeVM.consultarPacientesContacto();
    homeVM.consultarCuentasPendientes();
});