var PacienteRegistrarRetiroVM = function () {
    var self = this;
    self.faseNueva = ko.observable();
    self.verRequisitosMantenimiento1 = ko.observable(false);
    self.aceptaTerminosMantenimiento1 = ko.observable(false);


    self.registrarRetiro = function () {

        if (confirm("¿Desea registrar el retiro de este paciente?")) {
            $.ajax({
                method: "POST",
                url: '/Pacientes/RegistrarRetiro',
                data: {
                    "PacienteId": $("#PacienteId").val(),
                    "MotivoRetiro": $("#MotivoRetiro").val()
                },
                success: function (data) {
                    if (data.exitoso) {
                        window.location.href = "/Pacientes/Lista";
                    }
                    else
                        alert(data.mensaje);
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };
    self.cancelarRetiroPaciente = function () {
        if (confirm("¿Desea cancelar el registro de retiro?")) {
            window.location.href = "/Pacientes/Lista";
        }
    };
}

var registrarRetiroPacienteVM = new PacienteRegistrarRetiroVM();
ko.applyBindings(registrarRetiroPacienteVM);

$(document).ready(function () {

});