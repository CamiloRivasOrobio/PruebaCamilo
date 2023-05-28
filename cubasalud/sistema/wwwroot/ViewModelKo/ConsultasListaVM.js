var ConsultasListaVM = function () {
    var self = this;

    self.drawTableConsultas = function () {
        $("#tabla-consultas").DataTable({
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

}

var consultaListaVm = new ConsultasListaVM();
ko.applyBindings(consultaListaVm);

$(document).ready(function () {
    consultaListaVm.drawTableConsultas();
});