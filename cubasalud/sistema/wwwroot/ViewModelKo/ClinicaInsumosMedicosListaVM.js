var ClinicaInsumosVM = function () {
    var self = this;
};

var clinicaListaVm = new ClinicaInsumosVM();
ko.applyBindings(clinicaListaVm);

$(document).ready(function () {
    drawDataTable("tabla-clinica-insumos");
});