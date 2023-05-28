var GrabacionVM = function () {
    var self = this;
    var model = {};

    self.getModel = function () {
        model = {
            "GrabacionId": $("#GrabacionId").val(),
            "Numero": $("#Numero").val(),
            "Nombre": $("#Nombre").val(),
            "Categoria": $("#Categoria").val(),
            "PalabraClave": $("#PalabraClave").val()
        };
    };
    self.registrarGrabacion = function () {
        if (confirm("�Desea registrar esta grabaci�n?")) {
            $("#div-loading").show();
            self.getModel();
            $.ajax({
                method: "POST",
                url: '/Grabaciones/Nueva',
                data: model,
                success: function (data, textStatus) {
                    if (data.exitoso) {
                        window.location.href = "/Grabaciones/Lista";
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
    self.cancelarRegistrarGrabacion = function () {
        if (confirm("�Desea cancelar el registro de esta grabaci�n?")) {
            window.location.href = "/Grabaciones/Lista";
        }
    };
    self.editarGrabacion = function () {
        if (confirm("�Desea editar esta grabaci�n?")) {
            $("#div-loading").show();
            self.getModel();
            $.ajax({
                method: "POST",
                url: '/Grabaciones/Modificar',
                data: model,
                success: function (data, textStatus) {
                    if (data.exitoso) {
                        window.location.href = "/Grabaciones/Lista";
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
    self.cancelarEditarGrabacion = function () {
        if (confirm("�Desea cancelar la edici�n de esta grabaci�n?")) {
            window.location.href = "/Grabaciones/Lista";
        }
    };
}

var grabacionVm = new GrabacionVM();
ko.applyBindings(grabacionVm);

$(document).ready(function () {

});