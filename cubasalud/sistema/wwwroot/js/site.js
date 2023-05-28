//Configuraciones del sistema
let configuracionNombreEstablecimiento;

var directorioArchivos = "/ArchivosPacientes/";

$(".enlace-redirigir").on("click", function () {
    showLoading();
    setInterval(function () {
        hideLoading();
    }, 3000);
});

$('.select2bs4').select2({
    theme: 'bootstrap4',
    tags: true,
});

function mensajeEmergente(mensaje) {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-center",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "100",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "show",
        "hideMethod": "hide"
    };
    toastr.success(mensaje);
}

function showLoading() {
    $("#div-loading").show();
}

function hideLoading() {
    $("#div-loading").hide();
}

function clearDataTable(tablaId) {
    var table = $("#" + tablaId).DataTable();
    table.clear().draw();

    $("#" + tablaId).dataTable().fnDestroy();
}
function drawDataTable(tablaId) {
    $("#" + tablaId).DataTable({
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
}
function setConfiguracionesSistema() {
    $("#configuracion-nombre-establecimiento").text(configuracionNombreEstablecimiento + " - REDOWL SOFTWARE");
}
function getConfiguracionesSistema() {
    configuracionNombreEstablecimiento = "Redowl software";
    setConfiguracionesSistema();
    //$.ajax({
    //    method: "POST",
    //    url: '/Grabaciones/Modificar',
    //    success: function (data, textStatus) {
    //        if (data.exitoso) {
    //            window.location.href = "/Grabaciones/Lista";
    //        }
    //        else {
    //            $("#div-loading").hide();
    //            alert(data.mensaje);
    //        }
    //    },
    //    error: function (data) {
    //        $("#div-loading").hide();
    //        alert(data.error);
    //    }
    //});
}

getConfiguracionesSistema();