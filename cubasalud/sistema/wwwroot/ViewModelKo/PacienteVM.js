var PersonasListaVM = function () {
    var itemArchivosPaciente = 1;
    var itemBeneficiarioEps = 1;
    var model = {};
    var self = this;
    self.nombreNuevoBeneficiario = ko.observable();
    self.nitNuevoBeneficiario = ko.observable();
    self.tipoNuevoBeneficiario = ko.observable();
    self.vacunas = ko.observableArray();
    self.antecedentesPersonales = ko.observableArray();
    self.antecedentesFamiliares = ko.observableArray();
    self.preguntasRegistro = ko.observableArray();
    self.beneficiariosEpss = ko.observableArray();
    self.urlFotografiaPaciente = ko.observable();
    self.urlFirmaRegistro = ko.observable();
    self.urlFirmaPoliticas = ko.observable();
    self.urlFirmaConsentimiento = ko.observable();
    self.urlFirmaTarjetaCredito = ko.observable();
    self.archivos = ko.observableArray();
    self.archivosSubidos = ko.observableArray();

    //Archivos
    self.agregarArchivo = function () {
        var archivo = {
            Item: itemArchivosPaciente,
            Nombre: "",
            IdInputFile: "archivo-paciente-" + itemArchivosPaciente
        };
        itemArchivosPaciente++;
        self.archivos.push(archivo);
    };
    self.quitarArchivo = function (value) {
        $(self.archivos()).each(function (idxArchivo, archivo) {
            if (value.Item == archivo.Item) {
                self.archivos.splice(idxArchivo, 1);
            }
        });
    };

    //Beneficiarios EPSS
    self.agregarBeneficiarioEpss = function () {
        if (self.nitNuevoBeneficiario() == undefined || self.nitNuevoBeneficiario() == null || self.nombreNuevoBeneficiario().trim() == '') {
            alert("Escriba un NIT de beneficiario");
            return false;
        }
        if (self.nombreNuevoBeneficiario() == undefined || self.nombreNuevoBeneficiario() == null || self.nombreNuevoBeneficiario().trim() == '') {
            alert("Escriba un nombre de beneficiario");
            return false;
        }
        var beneficiario = new Object();
        beneficiario.Item = itemBeneficiarioEps;
        beneficiario.Name = self.nombreNuevoBeneficiario();
        beneficiario.Tipo = self.tipoNuevoBeneficiario();
        beneficiario.Nit = self.nitNuevoBeneficiario();
        self.beneficiariosEpss.push(beneficiario);
        self.nombreNuevoBeneficiario('');
        self.nitNuevoBeneficiario('');
        itemBeneficiarioEps++;
    };
    self.quitarBeneficiarioEpss = function (value) {
        console.log(value);
        $(self.beneficiariosEpss()).each(function (idxBeneficiario, beneficiario) {
            if (value.Item == beneficiario.Item) {
                self.beneficiariosEpss.splice(idxBeneficiario, 1);
            }
        });
    };

    self.getModel = function () {
        model = {
            "PacienteId": $("#PacienteId").val(),

            "FechaRegistro": $("#FechaRegistro").val(),

            "Nombre": $("#Nombre").val(),
            "Alias": $("#Alias").val(),
            "SexoId": $("#SexoId").val(),
            "FechaNacimiento": $("#FechaNacimiento").val(),
            "Edad": $("#Edad").val(),
            "TipoDeSangre": $("#TipoDeSangre").val(),
            "Telefono": $("#Telefono").val(),
            "Celular": $("#Celular").val(),
            "Email": $("#Email").val(),
            "Contrasennia": $("#Contrasennia").val(),
            "Nit": $("#Nit").val(),
            "Dpi": $("#Dpi").val(),
            "Direccion": $("#Direccion").val(),
            "no_IGGS": $("#no_IGGS").val(),
            "esta_Afiliado": $("#esta_Afiliado").val(),
            "SeguroEpssId": $("#SeguroEpssId").val(),
            "CodigoEPS": $("#CodigoEPS").val(),
            "Religion": $("#Religion").val(),
            "Ocupacion": $("#Ocupacion").val(),
            "EstadoCivil": $("#EstadoCivil").val(),
            "ContactoEmergencia": $("#ContactoEmergencia").val(),
            "NumeroContactoEmergencia": $("#NumeroContactoEmergencia").val(),
            "NombreContactoEmergencia": $("#NombreContactoEmergencia").val(),
            "Nacionalidad": $("#Nacionalidad").val(),
            "PaisResidencia": $("#PaisResidencia").val(),
            "DepartamentoResidencia": $("#DepartamentoResidencia").val(),
            "MunicipioResidencia": $("#PaisResidencia").val(),
            "TipoPacienteId": $("#TipoPacienteId").val(),
            "ModalidadAtencion": $("#ModalidadAtencion").val(),
            "UrlFirmaRegistro": self.urlFirmaRegistro(),
            "UrlFirmaPoliticas": self.urlFirmaPoliticas(),
            "UrlFirmaConsentimiento": self.urlFirmaConsentimiento(),
            "UrlFirmaTarjetaCredito": self.urlFirmaTarjetaCredito(),
            "UrlFotografiaPaciente": self.urlFotografiaPaciente(),

            //Información de nacimiento
            "PesoAlNacer": $("#PesoAlNacer").val(),
            "Talla": $("#Talla").val(),
            "CircunferenciaCefalica": $("#CircunferenciaCefalica").val(),
            "TipoParto": $("#TipoParto").val(),

            //Antecedentes personales y patologicos observaciones
            "AntecedentesPersonalesObservaciones": $("#AntecedentesPersonalesObservaciones").val(),
            "AntecedentesPersonalesOtros": $("#AntecedentesPersonalesOtros").val(),

            //Alergias
            "AlergiaAnestesiaLocal": $("#AlergiaAnestesiaLocal").val(),
            "AlergiaAspirina": $("#AlergiaAspirina").val(),
            "AlergiaPenicilina": $("#AlergiaPenicilina").val(),
            "AlergiaBarbiturios": $("#AlergiaBarbiturios").val(),
            "AlergiaSulfas": $("#AlergiaSulfas").val(),
            "AlergiaCodeina": $("#AlergiaCodeina").val(),
            "AlergiaMetales": $("#AlergiaMetales").val(),
            "AlergiaLatex": $("#AlergiaLatex").val(),
            "AlergiaYodo": $("#AlergiaYodo").val(),
            "AlergiaPolen": $("#AlergiaPolen").val(),
            "AlergiaAnimales": $("#AlergiaAnimales").val(),
            "AlergiaAlimentos": $("#AlergiaAlimentos").val(),
            "AlergiaOtros": $("#AlergiaOtros").val(),
            "AlergiaOtrosDescripcion": $("#AlergiaOtrosDescripcion").val(),

            //Informacion medica
            "MedicaUsaLentesContacto": $("#MedicaUsaLentesContacto").val(),
            "MedicaUsaLentesContactoDescripcion": $("#MedicaUsaLentesContactoDescripcion").val(),
            "MedicaArticulacionesArtificiales": $("#MedicaArticulacionesArtificiales").val(),
            "MedicaArticulacionesArtificialesFecha": $("#MedicaArticulacionesArtificialesFecha").val(),
            "MedicaArticulacionesArtificialesComplicaciones": $("#MedicaArticulacionesArtificialesComplicaciones").val(),
            "MedicaTomaAlendronato": $("#MedicaTomaAlendronato").val(),
            "MedicaTomaAlendronatoFecha": $("#MedicaTomaAlendronatoFecha").val(),
            "MedicaTratamientoDolorHuesos": $("#MedicaTratamientoDolorHuesos").val(),
            "MedicaTratamientoDolorHuesosFechaInicio": $("#MedicaTratamientoDolorHuesosFechaInicio").val(),
            "MedicaTratamientoDolorHuesosDescripcionCaso": $("#MedicaTratamientoDolorHuesosDescripcionCaso").val(),
            "MedicaSustanciasReguladorasDrogas": $("#MedicaSustanciasReguladorasDrogas").val(),
            "MedicaSustanciasReguladorasDrogasFecha": $("#MedicaSustanciasReguladorasDrogasFecha").val(),
            "MedicaUsaTabaco": $("#MedicaUsaTabaco").val(),
            "MedicaBebidasAlcoholicas": $("#MedicaBebidasAlcoholicas").val(),
            "MedicaBebidasAlcoholicasDescripcion": $("#MedicaBebidasAlcoholicasDescripcion").val(),

            //Información dental
            "DentalSangradoCepillar": $("#DentalSangradoCepillar").val(),
            "DentalDolorFrio": $("#DentalDolorFrio").val(),
            "DentalDolorPresionar": $("#DentalDolorPresionar").val(),
            "DentalObjetosAtorados": $("#DentalObjetosAtorados").val(),
            "DentalBocaSeca": $("#DentalBocaSeca").val(),
            "DentalTratamientoPeriondal": $("#DentalTratamientoPeriondal").val(),
            "DentalTratamientoOrtodoncia": $("#DentalTratamientoOrtodoncia").val(),
            "DentalProblemasTratamientoDental": $("#DentalProblemasTratamientoDental").val(),
            "DentalProblemasTratamientoDentalDescripcion": $("#DentalProblemasTratamientoDentalDescripcion").val(),
            "DentalFluoradaAguaDomicilio": $("#DentalFluoradaAguaDomicilio").val(),
            "DentalBebeAguaFiltrada": $("#DentalBebeAguaFiltrada").val(),
            "DentalDolorOidos": $("#DentalDolorOidos").val(),
            "DentalMolestiaRuidoAlto": $("#DentalMolestiaRuidoAlto").val(),
            "DentalMolestiaRuidoAltoDescripcion": $("#DentalMolestiaRuidoAltoDescripcion").val(),
            "DentalBrumismo": $("#DentalBrumismo").val(),
            "DentalLesiones": $("#DentalLesiones").val(),
            "DentalLesionesDescripcion": $("#DentalLesionesDescripcion").val(),
            "DentalDentaduraPlacas": $("#DentalDentaduraPlacas").val(),
            "DentalDentaduraPlacasDescripcion": $("#DentalDentaduraPlacasDescripcion").val(),
            "DentalActividadesRecreacion": $("#DentalActividadesRecreacion").val(),
            "DentalActividadesRecreacionDescripcion": $("#DentalActividadesRecreacionDescripcion").val(),
            "DentalLesionesCabeza": $("#DentalLesionesCabeza").val(),
            "DentalLesionesCabezaDescripcion": $("#DentalLesionesCabezaDescripcion").val(),

            //Análisis facial
            "FacialPatron": $("#FacialPatron").val(),
            "FacialPatronObservaciones": $("#FacialPatronObservaciones").val(),
            "FacialPerfil": $("#FacialPerfil").val(),
            "FacialPerfilObservaciones": $("#FacialPerfilObservaciones").val(),
            "FacialAsimetria": $("#FacialAsimetria").val(),
            "FacialAsimetriaObservaciones": $("#FacialAsimetriaObservaciones").val(),
            "FacialAlturaFacialEquilibrada": $("#FacialAlturaFacialEquilibrada").val(),
            "FacialAlturaFacialEquilibradaObservaciones": $("#FacialAlturaFacialEquilibradaObservaciones").val(),
            "FacialAnchoFacialEquilibrada": $("#FacialAnchoFacialEquilibrada").val(),
            "FacialAnchoFacialEquilibradaObservaciones": $("#FacialAnchoFacialEquilibradaObservaciones").val(),
            "FacialPerfilMaxilar": $("#FacialPerfilMaxilar").val(),
            "FacialPerfilMaxilarObservaciones": $("#FacialPerfilMaxilarObservaciones").val(),
            "FacialPerfilMandibular": $("#FacialPerfilMandibular").val(),
            "FacialPerfilMandibularObservaciones": $("#FacialPerfilMandibularObservaciones").val(),
            "FacialSurcoLabialMenton": $("#FacialSurcoLabialMenton").val(),
            "FacialSurcoLabialMentonObservaciones": $("#FacialSurcoLabialMentonObservaciones").val(),
            "FacialLabiosReposo": $("#FacialLabiosReposo").val(),

            //Análisis funcional
            "FuncionalActividadComisurial": $("#FuncionalActividadComisurial").val(),
            "FuncionalActividadLingual": $("#FuncionalActividadLingual").val(),
            "FuncionalLabioSuperior": $("#FuncionalLabioSuperior").val(),
            "FuncionalLabioInferior": $("#FuncionalLabioInferior").val(),
            "FuncionalMasetero": $("#FuncionalMasetero").val(),
            "FuncionalMentoniano": $("#FuncionalMentoniano").val(),
            "FuncionalRespiracion": $("#FuncionalRespiracion").val(),
            "FuncionalDeglucion": $("#FuncionalDeglucion").val(),

            //Patrón facial
            "PatronFacial": $("#PatronFacial").val(),
            "CaracteristicaPatronFacial": $("#CaracteristicaPatronFacial").val(),

            //MEDICOS
            //Antecedentes
            "AntecedentesMedicos": $("#AntecedentesMedicos").val(),
            "AntecedentesQuirurgicos": $("#AntecedentesQuirurgicos").val(),
            "AntecedentesTraumaticos": $("#AntecedentesTraumaticos").val(),
            "AntecedentesAlergias": $("#AntecedentesAlergias").val(),
            "AntecedentesVicios": $("#AntecedentesVicios").val(),
            "AntecedentesMedicamentos": $("#AntecedentesMedicamentos").val(),


            //Pediatricos
            "NombrePadre": $("#NombrePadre").val(),
            "NombreMadre": $("#NombreMadre").val(),

            //Información de la madre
            "MadreFechaNacimiento": $("#MadreFechaNacimiento").val(),
            "MadreEmbarazos": $("#MadreEmbarazos").val(),
            "MadrePartosNormales": $("#MadrePartosNormales").val(),
            "MadreCesareas": $("#MadreCesareas").val(),
            "MadreAbortos": $("#MadreAbortos").val(),
            "MadreHijosMuertos": $("#MadreHijosMuertos").val(),
            "MadreComplicaciones": $("#MadreComplicaciones").val(),

            //Historia medica
            "HistoriaMedicoPersonal": $("#HistoriaMedicoPersonal").val(),
            "HistoriaTelefonoMedico": $("#HistoriaTelefonoMedico").val(),
            "HistoriaEspecialidadMedico": $("#HistoriaEspecialidadMedico").val(),
            "HistoriaTratamientoMedico": $("#HistoriaTratamientoMedico").val(),
            "HistoriaSangraMuchoCortarse": $("#HistoriaSangraMuchoCortarse").val(),
            "HistoriaHospitalizado": $("#HistoriaHospitalizado").val(),
            "HistoriaOperado": $("#HistoriaOperado").val(),
            "HistoriaAlergiaMedicina": $("#HistoriaAlergiaMedicina").val(),
            "HistoriaAlergiaComida": $("#HistoriaAlergiaComida").val(),
            "HistoriaAlergiaOtros": $("#HistoriaAlergiaOtros").val(),
            "HistoriaProblemaEmocional": $("#HistoriaProblemaEmocional").val(),
            "HistoriaObservaciones": $("#HistoriaObservaciones").val(),

            //Datos de IGSS
            "IgssTipoAfiliacion": $("#IgssTipoAfiliacion").val(),
            "IgssNumeroAfiliacion": $("#IgssNumeroAfiliacion").val(),
            "IgssCantidadDependientes": $("#IgssCantidadDependientes").val(),
            "IgssParentescoDependientes": $("#IgssParentescoDependientes").val(),

            //Politicas de pago
            "PoliticasPagoAceptaTerminos": $("#PoliticasPagoAceptaTerminos").val(),

            //Datos de pago
            "NumeroTarjetaCredito": $("#NumeroTarjetaCredito").val(),

            //Antecedentes
            "AntecedentesPersonalesViewModel": self.antecedentesPersonales(),

            //Vacunas
            "VacunasPacienteViewModel": self.vacunas(),

            //Beneficiarios EPSS
            "BeneficiariosEpssPacienteViewModel": self.beneficiariosEpss(),

            //Antecedentes familiares
            "PatologiasPacienteViewModel": self.antecedentesFamiliares(),

            //archivosSubidos
            "ArchivosSubidos": self.archivosSubidos()
        };
    };

    self.registrarPaciente = function () {
        if (confirm("¿Desea registrar este nuevo paciente?")) {

            var formDataArchivos = new FormData();

            //Firma registro
            document.getElementById("firma-registro").toBlob(function (blobFirmaRegistro) {
                formDataArchivos.append("Archivos", blobFirmaRegistro, "FirmaRegistro");
                //Firma politicas
                document.getElementById("firma-politicas").toBlob(function (blobFirmaPoliticas) {
                    formDataArchivos.append("Archivos", blobFirmaPoliticas, "FirmaPoliticas");
                    //Firma consentimiento
                    document.getElementById("firma-consentimiento").toBlob(function (blobFirmaConsentimiento) {
                        formDataArchivos.append("Archivos", blobFirmaConsentimiento, "FirmaConsentimiento");
                        //Firma tarjeta de credito
                        document.getElementById("firma-tarjeta-credito").toBlob(function (blobFirmaTarjetaCredito) {
                            formDataArchivos.append("Archivos", blobFirmaTarjetaCredito, "FirmaTarjetaCredito");
                            //Archivos
                            $(self.archivos()).each(function (idx, value) {
                                if (value.Nombre != null && value.Nombre != undefined && value.Nombre.trim() != '') {
                                    formDataArchivos.append("Archivos", $("#archivo-paciente-" + value.Item).get(0).files[0], value.Nombre);
                                }
                            });

                            //Fotografia del paciente
                            if ($("#fotografia-paciente").get(0).files[0] != undefined
                                && $("#fotografia-paciente").get(0).files[0] != null)
                                formDataArchivos.append("Archivos", $("#fotografia-paciente").get(0).files[0], "FotografiaPaciente");

                            //Subir archivos y registrar paciente
                            formDataArchivos.append("Directorio", directorioArchivos);

                            $("#div-loading").show();
                            $.ajax({
                                type: "POST",
                                url: "/Files/UploadFiles",
                                dataType: "json",
                                contentType: false,
                                processData: false,
                                data: formDataArchivos,
                                success: function (data) {
                                    $(data.archivos).each(function (idx, archivo) {
                                        if (archivo.nombreArchivo == "FirmaRegistro")
                                            self.urlFirmaRegistro(archivo.urlArchivo);
                                        else if (archivo.nombreArchivo == "FirmaPoliticas")
                                            self.urlFirmaPoliticas(archivo.urlArchivo);
                                        else if (archivo.nombreArchivo == "FirmaConsentimiento")
                                            self.urlFirmaConsentimiento(archivo.urlArchivo);
                                        else if (archivo.nombreArchivo == "FirmaTarjetaCredito")
                                            self.urlFirmaTarjetaCredito(archivo.urlArchivo);
                                        else if (archivo.nombreArchivo == "FotografiaPaciente")
                                            self.urlFotografiaPaciente(archivo.urlArchivo);
                                        else {
                                            self.archivosSubidos.push({
                                                NombreArchivo: archivo.nombreArchivo,
                                                UrlArchivo: archivo.urlArchivo
                                            });
                                        }
                                    });
                                    //Registrar paciente
                                    self.getModel();
                                    $.ajax({
                                        method: "POST",
                                        url: '/Pacientes/Nuevo',
                                        data: model,
                                        success: function (data) {
                                            if (data.exitoso) {
                                                window.location.href = "/Pacientes/Informacion?pacienteId=" + data.pacienteId;
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
                            });
                        });
                    });
                });
            });
        }
    };


    self.cancelarRegistroPaciente = function () {
        if (confirm("¿Desea cancelar el registro del paciente?")) {
            window.location.href = "/Pacientes/Lista";
        }
    };
    self.editarPaciente = function () {
        self.getModel();
        $.ajax({
            method: "POST",
            url: '/Pacientes/Modificar',
            data: model,
            success: function (data, textStatus) {
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
    };
    self.cancelarEdicionPaciente = function () {
        if (confirm("¿Desea cancelar la edición del paciente?")) {
            window.location.href = "/Pacientes/Lista";
        }
    };

    self.consultarVacunas = function () {
        self.clearTableVacunas();

        $.ajax({
            method: "POST",
            url: '/Pacientes/ConsultarVacunas',
            data: {
                pacienteId: pacienteId == '' ? null : pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.vacunas(dataResult.Resultado);
                    self.drawTableVacunas();
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarAntecedentesPersonales = function () {
        self.clearTableAntecedentesPersonales();

        $.ajax({
            method: "POST",
            url: '/Pacientes/ConsultarAntecedentesPersonales',
            data: {
                pacienteId: pacienteId == '' ? null : pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.antecedentesPersonales(dataResult.Resultado);
                    self.drawTableAntecedentesPersonales();
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarBeneficiariosEpss = function () {

        if (pacienteId != '') {

            $.ajax({
                method: "POST",
                url: '/Pacientes/ConsultarPersonasSeguro',
                data: {
                    pacienteId: pacienteId
                },
                traditional: true,
                success: function (data, textStatus) {
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        self.beneficiariosEpss(dataResult.Resultado);
                    }
                    else
                        alert(dataResult.Mensaje);
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }

    };
    self.consultarAntecedentesFamiliares = function () {
        self.clearTableAntecedentesFamiliares();

        $.ajax({
            method: "POST",
            url: '/Pacientes/ConsultarAntecedentesFamiliares',
            data: {
                pacienteId: pacienteId == '' ? null : pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.antecedentesFamiliares(dataResult.Resultado);
                    self.drawTableAntecedentesFamiliares();
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarPreguntasRegistro = function () {
        self.clearTablePreguntasRegistro();

        $.ajax({
            method: "POST",
            url: '/Pacientes/ConsultarPreguntasRegistro',
            data: {
                pacienteId: pacienteId == '' ? null : pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.preguntasRegistro(dataResult.Resultado);
                    self.drawTablePreguntasRegistro();
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    self.clearTableVacunas = function () {
        var table = $("#tabla-vacunas").DataTable();
        table.clear().draw();

        $("#tabla-vacunas").dataTable().fnDestroy();
    };
    self.drawTableVacunas = function () {
        $("#tabla-vacunas").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.clearTableAntecedentesPersonales = function () {
        var table = $("#tabla-antecedentes-personales").DataTable();
        table.clear().draw();

        $("#tabla-antecedentes-personales").dataTable().fnDestroy();
    };
    self.drawTableAntecedentesPersonales = function () {
        $("#tabla-antecedentes-personales").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.clearTableAntecedentesFamiliares = function () {
        var table = $("#tabla-antecedentes-familiares").DataTable();
        table.clear().draw();

        $("#tabla-antecedentes-familiares").dataTable().fnDestroy();
    };
    self.drawTableAntecedentesFamiliares = function () {
        $("#tabla-antecedentes-familiares").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                //search: "Buscar: ",
                //lengthMenu: "Mostrar _MENU_ registros por página",
                zeroRecords: "No hay registros para mostrar",
                info: "",
                //info: "Mostrando página _PAGE_ de _PAGES_",
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
    self.clearTablePreguntasRegistro = function () {
        var table = $("#tabla-preguntas-registro").DataTable();
        table.clear().draw();

        $("#tabla-preguntas-registro").dataTable().fnDestroy();
    };
    self.drawTablePreguntasRegistro = function () {
        $("#tabla-preguntas-registro").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por página",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.drawTableAnalisisFacial = function () {
        $("#tabla-analisis-facial").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
                //info: "Mostrando p&aacute;gina _PAGE_ de _PAGES_",
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
    self.drawTableAlergias = function () {
        $("#tabla-alergias").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.drawTableInformacionMedica = function () {
        $("#tabla-informacion-medica").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.drawTableInformacionDental = function () {
        $("#tabla-informacion-dental").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
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
    self.drawTableAnalisisFuncional = function () {
        $("#tabla-analisis-funcional").DataTable({
            searching: false,
            ordering: false,
            paging: false,
            language: {
                search: "Buscar: ",
                lengthMenu: "Mostrar _MENU_ registros por p&aacute;gina",
                zeroRecords: "No hay registros para mostrar",
                info: "",
                //info: "Mostrando p&aacute;gina _PAGE_ de _PAGES_",
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
    listaPersonasVM.consultarVacunas();
    listaPersonasVM.consultarAntecedentesPersonales();
    listaPersonasVM.consultarAntecedentesFamiliares();
    listaPersonasVM.consultarPreguntasRegistro();
    listaPersonasVM.consultarBeneficiariosEpss();
    listaPersonasVM.drawTableAnalisisFacial();
    listaPersonasVM.drawTableAlergias();
    listaPersonasVM.drawTableInformacionMedica();
    listaPersonasVM.drawTableInformacionDental();
    listaPersonasVM.drawTableAnalisisFuncional();

    //Firmas
    renderFirma('firma-registro');
    renderFirma('firma-consentimiento');
    renderFirma('firma-politicas');
    renderFirma('firma-tarjeta-credito');
});

function getEdad() {
    let hoy = new Date();
    let fechaNacimiento = new Date($("#FechaNacimiento").val());
    let edad = hoy.getFullYear() - fechaNacimiento.getFullYear();
    let diferenciaMeses = hoy.getMonth() - fechaNacimiento.getMonth();
    if (
        diferenciaMeses < 0 ||
        (diferenciaMeses === 0 && hoy.getDate() < fechaNacimiento.getDate())
    ) {
        edad--;
    }
    $("#Edad").val(edad);
}


function renderFirma(idCanvas) {
    let miCanvas = document.querySelector('#' + idCanvas);
    let lineas = [];
    let correccionX = 0;
    let correccionY = 0;
    let pintarLinea = false;
    // Marca el nuevo punto
    let nuevaPosicionX = 0;
    let nuevaPosicionY = 0;

    let posicion = miCanvas.getBoundingClientRect()
    correccionX = posicion.x;
    correccionY = posicion.y;

    miCanvas.width = 900;
    miCanvas.height = 300;

    // Eventos raton
    //Empezar dibujo
    miCanvas.addEventListener('mousedown', function () {
        pintarLinea = true;
        lineas.push([]);
    }, false);
    //Dibujar linea
    miCanvas.addEventListener('mousemove', function (event) {
        event.preventDefault();
        if (pintarLinea) {
            let ctx = miCanvas.getContext('2d')
            // Estilos de linea
            ctx.lineJoin = ctx.lineCap = 'round';
            ctx.lineWidth = 3;
            // Color de la linea
            ctx.strokeStyle = '#000000';
            // Marca el nuevo punto
            if (event.changedTouches == undefined) {
                // Versión ratón
                nuevaPosicionX = event.layerX;
                nuevaPosicionY = event.layerY;
            } else {
                // Versión touch, pantalla tactil
                nuevaPosicionX = event.changedTouches[0].pageX - correccionX;
                nuevaPosicionY = event.changedTouches[0].pageY - correccionY;
            }
            //Guardar linea
            lineas[lineas.length - 1].push({
                x: nuevaPosicionX,
                y: nuevaPosicionY
            });
            // Redibuja todas las lineas guardadas
            ctx.beginPath();
            lineas.forEach(function (segmento) {
                ctx.moveTo(segmento[0].x, segmento[0].y);
                segmento.forEach(function (punto, index) {
                    ctx.lineTo(punto.x, punto.y);
                });
            });
            ctx.stroke();
        }
    }, false);
    miCanvas.addEventListener('mouseup', function () {
        pintarLinea = false;
        //Guardar linea
        lineas[lineas.length - 1].push({
            x: nuevaPosicionX,
            y: nuevaPosicionY
        });
    }, false);

    // Eventos pantallas táctiles
    //Empezar dibujo
    miCanvas.addEventListener('touchstart', function () {
        pintarLinea = true;
        lineas.push([]);
    }, false);
    //Dibujar linea
    miCanvas.addEventListener('touchmove', function (event) {
        event.preventDefault();
        if (pintarLinea) {
            let ctx = miCanvas.getContext('2d')
            // Estilos de linea
            ctx.lineJoin = ctx.lineCap = 'round';
            ctx.lineWidth = 3;
            // Color de la linea
            ctx.strokeStyle = '#000000';
            // Marca el nuevo punto
            if (event.changedTouches == undefined) {
                // Versión ratón
                nuevaPosicionX = event.layerX;
                nuevaPosicionY = event.layerY;
            } else {
                // Versión touch, pantalla tactil
                nuevaPosicionX = event.changedTouches[0].pageX - correccionX;
                nuevaPosicionY = event.changedTouches[0].pageY - correccionY;
            }
            // Guarda la linea
            lineas[lineas.length - 1].push({
                x: nuevaPosicionX,
                y: nuevaPosicionY
            });
            // Redibuja todas las lineas guardadas
            ctx.beginPath();
            lineas.forEach(function (segmento) {
                ctx.moveTo(segmento[0].x, segmento[0].y);
                segmento.forEach(function (punto, index) {
                    ctx.lineTo(punto.x, punto.y);
                });
            });
            ctx.stroke();
        }
    }, false);
}