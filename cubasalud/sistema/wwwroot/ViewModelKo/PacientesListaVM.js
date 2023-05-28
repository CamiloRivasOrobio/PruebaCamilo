var PersonasListaVM = function () {
    var self = this;

    self.drawTablePacientes = function () {
        $("#tabla-pacientes").DataTable({
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

var listaPersonasVM = new PersonasListaVM();
ko.applyBindings(listaPersonasVM);

$(document).ready(function () {
    listaPersonasVM.drawTablePacientes();
});