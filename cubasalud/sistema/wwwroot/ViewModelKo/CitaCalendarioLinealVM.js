var CitaCalendarioLinealVM = function () {
    var self = this;
}

var calendarioVm = new CitaCalendarioLinealVM();
ko.applyBindings(calendarioVm);

$(document).ready(function () {
    //$('#fechacita').daterangepicker({
    //    timePicker: true,
    //    timePickerIncrement: 30,
    //    singleDatePicker: true,
    //    locale: {
    //        format: 'MM/DD/YYYY'
    //    }
    //});
    $("#fechacita").on("change", function () {
        showLoading();
        window.location.href = "/Cita/CalendarioLineal?buscar=" + $("#fechacita").val();
    });
});

function Eliminar(id, fecha) {
    var option = confirm("¿Está seguro/a que desea eliminar este registro?");

    if (option) {
        var data = {
            "id": parseInt(id),
            "fecha": fecha,

        }

        $.ajax({
            url: "/Cita/EliminarCita/",
            data: data,
            type: 'POST',
            success: function (result) {
                window.location.href = '/Cita/CalendarioLineal?buscar=' + result;

            },
            error: function (error) {
                alert(error);
            }
        });
    }
}

function Finalizar(id, fecha) {
    var option = confirm("¿Está seguro/a que desea finalizar esta cita?");

    if (option) {
        var data = {
            "id": parseInt(id),
            "fecha": fecha,
        }

        $.ajax({
            url: "/Cita/FinalizarCita/",
            data: data,
            type: 'POST',
            success: function (result) {
                window.location.href = '/Cita/CalendarioLineal?buscar=' + result;
            },
            error: function (error) {
                alert(error);
            }
        });
    }
}