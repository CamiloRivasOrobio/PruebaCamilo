var CuentaPagarVM = function () {
    var model = {};
    var self = this;
    self.getModel = function () {
        model = {
            //Datos de factura
            "NoComprobante": $("#NoComprobante").val(),
            "EmpleadoId": $("#EmpleadoId").val(),

            //Datos de cuenta
            "CuentaId": $("#CuentaId").val(),
            "Valor": $("#Valor").val(),
            "Observaciones": $("#Observaciones").val(),

            //Datos del paciente
            "PacienteId": $("#PacienteId").val(),

            //Datos de pago
            "FormaPagoId": $("#FormaPagoId").val(),
            "MonedaId": $("#MonedaId").val()
        };
    };

    self.pagarCuenta = function () {

        if (confirm("¿Desea registrar el pago de esta cuenta?")) {
            $("#div-loading").show();
            self.getModel();

            $.ajax({
                method: "POST",
                url: '/CuentasPorCobrar/Pagar',
                data: model,
                success: function (data) {
                    if (data.exitoso) {
                        window.location.href = "/CuentasPorCobrar/Pagadas";
                    }
                    else {
                        $("#div-loading").hide();
                        alert(data.mensaje);
                    }
                },
                error: function (data) {
                    $("#div-loading").hide();
                    alert(data.error);
                }
            });
        }
    };
}

var cuentaPagarVm = new CuentaPagarVM();
ko.applyBindings(cuentaPagarVm);

$(document).ready(function () {

});