var ConsultaVM = function () {
    var itemExamenLaboratorio = 1;
    var itemRangoSaludable = 1;
    var model = {};

    var self = this;
    self.caracteristicasDentales = ko.observableArray();
    self.servicios = ko.observableArray();
    self.servicioSeleccionado = ko.observable();
    self.servicioSeleccionadoDiente = ko.observable();
    self.precios = ko.observableArray();
    self.preciosDiente = ko.observableArray();
    self.precioSeleccionado = ko.observable();
    self.precioSeleccionadoDiente = ko.observable();
    self.serviciosAgregadosConsulta = ko.observableArray();
    self.seguimientosNutricionales = ko.observableArray();
    self.examenesLaboratorio = ko.observableArray();
    self.rangosSaludables = ko.observableArray();
    self.vacunas = ko.observableArray();
    self.dienteSeleccionado = ko.observable(0);
    self.verDiente1 = ko.observable(false);
    self.verDiente2 = ko.observable(false);
    self.verDiente3 = ko.observable(false);
    self.verDiente4 = ko.observable(false);
    self.verDiente5 = ko.observable(false);
    self.verDiente6 = ko.observable(false);
    self.verDiente7 = ko.observable(false);
    self.verDiente8 = ko.observable(false);
    self.verDiente9 = ko.observable(false);
    self.verDiente10 = ko.observable(false);
    self.verDiente11 = ko.observable(false);
    self.verDiente12 = ko.observable(false);
    self.verDiente13 = ko.observable(false);
    self.verDiente14 = ko.observable(false);
    self.verDiente15 = ko.observable(false);
    self.verDiente16 = ko.observable(false);
    self.verDiente17 = ko.observable(false);
    self.verDiente18 = ko.observable(false);
    self.verDiente19 = ko.observable(false);
    self.verDiente20 = ko.observable(false);
    self.verDiente21 = ko.observable(false);
    self.verDiente22 = ko.observable(false);
    self.verDiente23 = ko.observable(false);
    self.verDiente24 = ko.observable(false);
    self.verDiente25 = ko.observable(false);
    self.verDiente26 = ko.observable(false);
    self.verDiente27 = ko.observable(false);
    self.verDiente28 = ko.observable(false);
    self.verDiente29 = ko.observable(false);
    self.verDiente30 = ko.observable(false);
    self.verDiente31 = ko.observable(false);
    self.verDiente32 = ko.observable(false);
    self.serviciosAgregadosDiente1 = ko.observableArray();
    self.serviciosAgregadosDiente2 = ko.observableArray();
    self.serviciosAgregadosDiente3 = ko.observableArray();
    self.serviciosAgregadosDiente4 = ko.observableArray();
    self.serviciosAgregadosDiente5 = ko.observableArray();
    self.serviciosAgregadosDiente6 = ko.observableArray();
    self.serviciosAgregadosDiente7 = ko.observableArray();
    self.serviciosAgregadosDiente8 = ko.observableArray();
    self.serviciosAgregadosDiente9 = ko.observableArray();
    self.serviciosAgregadosDiente10 = ko.observableArray();
    self.serviciosAgregadosDiente11 = ko.observableArray();
    self.serviciosAgregadosDiente12 = ko.observableArray();
    self.serviciosAgregadosDiente13 = ko.observableArray();
    self.serviciosAgregadosDiente14 = ko.observableArray();
    self.serviciosAgregadosDiente15 = ko.observableArray();
    self.serviciosAgregadosDiente16 = ko.observableArray();
    self.serviciosAgregadosDiente17 = ko.observableArray();
    self.serviciosAgregadosDiente18 = ko.observableArray();
    self.serviciosAgregadosDiente19 = ko.observableArray();
    self.serviciosAgregadosDiente20 = ko.observableArray();
    self.serviciosAgregadosDiente21 = ko.observableArray();
    self.serviciosAgregadosDiente22 = ko.observableArray();
    self.serviciosAgregadosDiente23 = ko.observableArray();
    self.serviciosAgregadosDiente24 = ko.observableArray();
    self.serviciosAgregadosDiente25 = ko.observableArray();
    self.serviciosAgregadosDiente26 = ko.observableArray();
    self.serviciosAgregadosDiente27 = ko.observableArray();
    self.serviciosAgregadosDiente28 = ko.observableArray();
    self.serviciosAgregadosDiente29 = ko.observableArray();
    self.serviciosAgregadosDiente30 = ko.observableArray();
    self.serviciosAgregadosDiente31 = ko.observableArray();
    self.serviciosAgregadosDiente32 = ko.observableArray();

    self.ocultarServiciosDientes = function () {
        self.verDiente1(false);
        self.verDiente2(false);
        self.verDiente3(false);
        self.verDiente4(false);
        self.verDiente5(false);
        self.verDiente6(false);
        self.verDiente7(false);
        self.verDiente8(false);
        self.verDiente9(false);
        self.verDiente10(false);
        self.verDiente11(false);
        self.verDiente12(false);
        self.verDiente13(false);
        self.verDiente14(false);
        self.verDiente15(false);
        self.verDiente16(false);
        self.verDiente17(false);
        self.verDiente18(false);
        self.verDiente19(false);
        self.verDiente20(false);
        self.verDiente21(false);
        self.verDiente22(false);
        self.verDiente23(false);
        self.verDiente24(false);
        self.verDiente25(false);
        self.verDiente26(false);
        self.verDiente27(false);
        self.verDiente28(false);
        self.verDiente29(false);
        self.verDiente30(false);
        self.verDiente31(false);
        self.verDiente32(false);
        $("#caracteristicas-diente-1").hide();
        $("#caracteristicas-diente-2").hide();
        $("#caracteristicas-diente-3").hide();
        $("#caracteristicas-diente-4").hide();
        $("#caracteristicas-diente-5").hide();
        $("#caracteristicas-diente-6").hide();
        $("#caracteristicas-diente-7").hide();
        $("#caracteristicas-diente-8").hide();
        $("#caracteristicas-diente-9").hide();
        $("#caracteristicas-diente-10").hide();
        $("#caracteristicas-diente-11").hide();
        $("#caracteristicas-diente-12").hide();
        $("#caracteristicas-diente-13").hide();
        $("#caracteristicas-diente-14").hide();
        $("#caracteristicas-diente-15").hide();
        $("#caracteristicas-diente-16").hide();
        $("#caracteristicas-diente-17").hide();
        $("#caracteristicas-diente-18").hide();
        $("#caracteristicas-diente-19").hide();
        $("#caracteristicas-diente-20").hide();
        $("#caracteristicas-diente-21").hide();
        $("#caracteristicas-diente-22").hide();
        $("#caracteristicas-diente-23").hide();
        $("#caracteristicas-diente-24").hide();
        $("#caracteristicas-diente-25").hide();
        $("#caracteristicas-diente-26").hide();
        $("#caracteristicas-diente-27").hide();
        $("#caracteristicas-diente-28").hide();
        $("#caracteristicas-diente-29").hide();
        $("#caracteristicas-diente-30").hide();
        $("#caracteristicas-diente-31").hide();
        $("#caracteristicas-diente-32").hide();
    };
    self.verServiciosDiente1 = function () {
        self.ocultarServiciosDientes();
        self.verDiente1(true);
        self.dienteSeleccionado(1);
        $("#caracteristicas-diente-1").show();
    };
    self.verServiciosDiente2 = function () {
        self.ocultarServiciosDientes();
        self.verDiente2(true);
        self.dienteSeleccionado(2);
        $("#caracteristicas-diente-2").show();
    };
    self.verServiciosDiente3 = function () {
        self.ocultarServiciosDientes();
        self.verDiente3(true);
        self.dienteSeleccionado(3);
        $("#caracteristicas-diente-3").show();
    };
    self.verServiciosDiente4 = function () {
        self.ocultarServiciosDientes();
        self.verDiente4(true);
        self.dienteSeleccionado(4);
        $("#caracteristicas-diente-4").show();
    };
    self.verServiciosDiente5 = function () {
        self.ocultarServiciosDientes();
        self.verDiente5(true);
        self.dienteSeleccionado(5);
        $("#caracteristicas-diente-5").show();
    };
    self.verServiciosDiente6 = function () {
        self.ocultarServiciosDientes();
        self.verDiente6(true);
        self.dienteSeleccionado(6);
        $("#caracteristicas-diente-6").show();
    };
    self.verServiciosDiente7 = function () {
        self.ocultarServiciosDientes();
        self.verDiente7(true);
        self.dienteSeleccionado(7);
        $("#caracteristicas-diente-7").show();
    };
    self.verServiciosDiente8 = function () {
        self.ocultarServiciosDientes();
        self.verDiente8(true);
        self.dienteSeleccionado(8);
        $("#caracteristicas-diente-8").show();
    };
    self.verServiciosDiente9 = function () {
        self.ocultarServiciosDientes();
        self.verDiente9(true);
        self.dienteSeleccionado(9);
        $("#caracteristicas-diente-9").show();
    };
    self.verServiciosDiente10 = function () {
        self.ocultarServiciosDientes();
        self.verDiente10(true);
        self.dienteSeleccionado(10);
        $("#caracteristicas-diente-10").show();
    };
    self.verServiciosDiente11 = function () {
        self.ocultarServiciosDientes();
        self.verDiente11(true);
        self.dienteSeleccionado(11);
        $("#caracteristicas-diente-11").show();
    };
    self.verServiciosDiente12 = function () {
        self.ocultarServiciosDientes();
        self.verDiente12(true);
        self.dienteSeleccionado(12);
        $("#caracteristicas-diente-12").show();
    };
    self.verServiciosDiente13 = function () {
        self.ocultarServiciosDientes();
        self.verDiente13(true);
        self.dienteSeleccionado(13);
        $("#caracteristicas-diente-13").show();
    };
    self.verServiciosDiente14 = function () {
        self.ocultarServiciosDientes();
        self.verDiente14(true);
        self.dienteSeleccionado(14);
        $("#caracteristicas-diente-14").show();
    };
    self.verServiciosDiente15 = function () {
        self.ocultarServiciosDientes();
        self.verDiente15(true);
        self.dienteSeleccionado(15);
        $("#caracteristicas-diente-15").show();
    };
    self.verServiciosDiente16 = function () {
        self.ocultarServiciosDientes();
        self.verDiente16(true);
        self.dienteSeleccionado(16);
        $("#caracteristicas-diente-16").show();
    };
    self.verServiciosDiente17 = function () {
        self.ocultarServiciosDientes();
        self.verDiente17(true);
        self.dienteSeleccionado(17);
        $("#caracteristicas-diente-17").show();
    };
    self.verServiciosDiente18 = function () {
        self.ocultarServiciosDientes();
        self.verDiente18(true);
        self.dienteSeleccionado(18);
        $("#caracteristicas-diente-18").show();
    };
    self.verServiciosDiente19 = function () {
        self.ocultarServiciosDientes();
        self.verDiente19(true);
        self.dienteSeleccionado(19);
        $("#caracteristicas-diente-19").show();
    };
    self.verServiciosDiente20 = function () {
        self.ocultarServiciosDientes();
        self.verDiente20(true);
        self.dienteSeleccionado(20);
        $("#caracteristicas-diente-20").show();
    };
    self.verServiciosDiente21 = function () {
        self.ocultarServiciosDientes();
        self.verDiente21(true);
        self.dienteSeleccionado(21);
        $("#caracteristicas-diente-21").show();
    };
    self.verServiciosDiente22 = function () {
        self.ocultarServiciosDientes();
        self.verDiente22(true);
        self.dienteSeleccionado(22);
        $("#caracteristicas-diente-22").show();
    };
    self.verServiciosDiente23 = function () {
        self.ocultarServiciosDientes();
        self.verDiente23(true);
        self.dienteSeleccionado(23);
        $("#caracteristicas-diente-23").show();
    };
    self.verServiciosDiente24 = function () {
        self.ocultarServiciosDientes();
        self.verDiente24(true);
        self.dienteSeleccionado(24);
        $("#caracteristicas-diente-24").show();
    };
    self.verServiciosDiente25 = function () {
        self.ocultarServiciosDientes();
        self.verDiente25(true);
        self.dienteSeleccionado(25);
        $("#caracteristicas-diente-25").show();
    };
    self.verServiciosDiente26 = function () {
        self.ocultarServiciosDientes();
        self.verDiente26(true);
        self.dienteSeleccionado(26);
        $("#caracteristicas-diente-26").show();
    };
    self.verServiciosDiente27 = function () {
        self.ocultarServiciosDientes();
        self.verDiente27(true);
        self.dienteSeleccionado(27);
        $("#caracteristicas-diente-27").show();
    };
    self.verServiciosDiente28 = function () {
        self.ocultarServiciosDientes();
        self.verDiente28(true);
        self.dienteSeleccionado(28);
        $("#caracteristicas-diente-28").show();
    };
    self.verServiciosDiente29 = function () {
        self.ocultarServiciosDientes();
        self.verDiente29(true);
        self.dienteSeleccionado(29);
        $("#caracteristicas-diente-29").show();
    };
    self.verServiciosDiente30 = function () {
        self.ocultarServiciosDientes();
        self.verDiente30(true);
        self.dienteSeleccionado(30);
        $("#caracteristicas-diente-30").show();
    };
    self.verServiciosDiente31 = function () {
        self.ocultarServiciosDientes();
        self.verDiente31(true);
        self.dienteSeleccionado(31);
        $("#caracteristicas-diente-31").show();
    };
    self.verServiciosDiente32 = function () {
        self.ocultarServiciosDientes();
        self.verDiente32(true);
        self.dienteSeleccionado(32);
        $("#caracteristicas-diente-32").show();
    };

    self.consultarServiciosAgregadosConsulta = function () {
        self.serviciosAgregadosConsulta([]);
        self.serviciosAgregadosDiente1([]);
        self.serviciosAgregadosDiente2([]);
        self.serviciosAgregadosDiente3([]);
        self.serviciosAgregadosDiente4([]);
        self.serviciosAgregadosDiente5([]);
        self.serviciosAgregadosDiente6([]);
        self.serviciosAgregadosDiente7([]);
        self.serviciosAgregadosDiente8([]);
        self.serviciosAgregadosDiente9([]);
        self.serviciosAgregadosDiente10([]);
        self.serviciosAgregadosDiente11([]);
        self.serviciosAgregadosDiente12([]);
        self.serviciosAgregadosDiente13([]);
        self.serviciosAgregadosDiente14([]);
        self.serviciosAgregadosDiente15([]);
        self.serviciosAgregadosDiente16([]);
        self.serviciosAgregadosDiente17([]);
        self.serviciosAgregadosDiente18([]);
        self.serviciosAgregadosDiente19([]);
        self.serviciosAgregadosDiente20([]);
        self.serviciosAgregadosDiente21([]);
        self.serviciosAgregadosDiente22([]);
        self.serviciosAgregadosDiente23([]);
        self.serviciosAgregadosDiente24([]);
        self.serviciosAgregadosDiente25([]);
        self.serviciosAgregadosDiente26([]);
        self.serviciosAgregadosDiente27([]);
        self.serviciosAgregadosDiente28([]);
        self.serviciosAgregadosDiente29([]);
        self.serviciosAgregadosDiente30([]);
        self.serviciosAgregadosDiente31([]);
        self.serviciosAgregadosDiente32([]);

        if (idConsulta != '') {
            $.ajax({
                method: "POST",
                url: '/Consultas/ConsultarServiciosAgregadosConsulta',
                data: {
                    consultaId: idConsulta
                },
                success: function (data, textStatus) {
                    var dataResult = JSON.parse(data);
                    if (dataResult.Exitoso) {
                        $(dataResult.Resultado).each(function (idx, vl) {
                            switch (vl.NumeroDiente) {
                                case 1: self.serviciosAgregadosDiente1.push(vl); break;
                                case 2: self.serviciosAgregadosDiente2.push(vl); break;
                                case 3: self.serviciosAgregadosDiente3.push(vl); break;
                                case 4: self.serviciosAgregadosDiente4.push(vl); break;
                                case 5: self.serviciosAgregadosDiente5.push(vl); break;
                                case 6: self.serviciosAgregadosDiente6.push(vl); break;
                                case 7: self.serviciosAgregadosDiente7.push(vl); break;
                                case 8: self.serviciosAgregadosDiente8.push(vl); break;
                                case 9: self.serviciosAgregadosDiente9.push(vl); break;
                                case 10: self.serviciosAgregadosDiente10.push(vl); break;
                                case 11: self.serviciosAgregadosDiente11.push(vl); break;
                                case 12: self.serviciosAgregadosDiente12.push(vl); break;
                                case 13: self.serviciosAgregadosDiente13.push(vl); break;
                                case 14: self.serviciosAgregadosDiente14.push(vl); break;
                                case 15: self.serviciosAgregadosDiente15.push(vl); break;
                                case 16: self.serviciosAgregadosDiente16.push(vl); break;
                                case 17: self.serviciosAgregadosDiente17.push(vl); break;
                                case 18: self.serviciosAgregadosDiente18.push(vl); break;
                                case 19: self.serviciosAgregadosDiente19.push(vl); break;
                                case 20: self.serviciosAgregadosDiente20.push(vl); break;
                                case 21: self.serviciosAgregadosDiente21.push(vl); break;
                                case 22: self.serviciosAgregadosDient22.push(vl); break;
                                case 23: self.serviciosAgregadosDiente23.push(vl); break;
                                case 24: self.serviciosAgregadosDiente24.push(vl); break;
                                case 25: self.serviciosAgregadosDiente25.push(vl); break;
                                case 26: self.serviciosAgregadosDiente26.push(vl); break;
                                case 27: self.serviciosAgregadosDiente27.push(vl); break;
                                case 28: self.serviciosAgregadosDiente28.push(vl); break;
                                case 29: self.serviciosAgregadosDiente29.push(vl); break;
                                case 30: self.serviciosAgregadosDiente30.push(vl); break;
                                case 31: self.serviciosAgregadosDiente31.push(vl); break;
                                case 32: self.serviciosAgregadosDiente32.push(vl); break;
                                default:
                                    self.serviciosAgregadosConsulta.push(vl);
                                    break;
                            }
                        });
                    }
                    else
                        alert(data.Mensaje);
                },
                error: function (data) {
                    alert(data.error);
                }
            });
        }
    };
    self.consultarCaracteristicasDentales = function () {
        $.ajax({
            method: "POST",
            url: '/Consultas/ConsultarCaracteristicasDentales',
            data: {
                consultaId: idConsulta == '' ? null : idConsulta
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.caracteristicasDentales(dataResult.Resultado);
                }
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarVacunasPaciente = function () {
        $.ajax({
            method: "POST",
            url: '/Consultas/ConsultarVacunasPaciente',
            data: {
                pacienteId: pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    self.vacunas(dataResult.Resultado);
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarExamenesLaboratorio = function () {
        $.ajax({
            method: "POST",
            url: '/Consultas/ConsultarSeguimientosNutricionalesPaciente',
            data: {
                pacienteId: pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    $(dataResult.Resultado).each(function (idx, vl) {
                        if (vl.Fecha != null)
                            vl.Fecha = moment(vl.Fecha).format('YYYY-MM-DD');
                    });
                    self.examenesLaboratorio(dataResult.Resultado);
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarSeguimientosNutricionales = function () {
        $.ajax({
            method: "POST",
            url: '/Consultas/ConsultarSeguimientosNutricionalesPaciente',
            data: {
                pacienteId: pacienteId
            },
            traditional: true,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso) {
                    $(dataResult.Resultado).each(function (idx, vl) {
                        if (vl.Fecha != null)
                            vl.Fecha = moment(vl.Fecha).format('YYYY-MM-DD');
                    });
                    self.seguimientosNutricionales(dataResult.Resultado);
                }
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarServicios = function () {
        $.ajax({
            method: "POST",
            "dataType": "json",
            "contentType": "application/json",
            url: '/Consultas/ConsultarServicios',
            traditional: true,
            success: function (data, textStatus) {
                if (data.exitoso)
                    self.servicios(data.resultado);
                else
                    alert(data.mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };
    self.consultarPrecios = function () {
        self.precios([]);

        var precio = new Object();
        precio.Id = self.servicioSeleccionado().id;
        precio.Precio = self.servicioSeleccionado().precio;
        self.precios.push(precio);

        var precio2 = new Object();
        precio2.Id = self.servicioSeleccionado().id;
        precio2.Precio = self.servicioSeleccionado().precio_2;
        self.precios.push(precio2);

        var precio3 = new Object();
        precio3.Id = self.servicioSeleccionado().id;
        precio3.Precio = self.servicioSeleccionado().precio_3;
        self.precios.push(precio3);

        var precio4 = new Object();
        precio4.Id = self.servicioSeleccionado().id;
        precio4.Precio = self.servicioSeleccionado().precio_4;
        self.precios.push(precio4);
    };
    self.consultarPreciosDiente = function () {
        self.preciosDiente([]);

        var precio = new Object();
        precio.Id = self.servicioSeleccionadoDiente().id;
        precio.Precio = self.servicioSeleccionadoDiente().precio;
        self.preciosDiente.push(precio);

        var precio2 = new Object();
        precio2.Id = self.servicioSeleccionado().id;
        precio2.Precio = self.servicioSeleccionadoDiente().precio_2;
        self.preciosDiente.push(precio2);

        var precio3 = new Object();
        precio3.Id = self.servicioSeleccionadoDiente().id;
        precio3.Precio = self.servicioSeleccionadoDiente().precio_3;
        self.preciosDiente.push(precio3);

        var precio4 = new Object();
        precio4.Id = self.servicioSeleccionadoDiente().id;
        precio4.Precio = self.servicioSeleccionadoDiente().precio_4;
        self.preciosDiente.push(precio4);
    };

    self.agregarServicioConsulta = function () {
        var servicioAgregado = new Object();
        servicioAgregado.ConsultaId = idConsulta == '' ? null : idConsulta;
        servicioAgregado.ServicioId = self.servicioSeleccionado().id;
        servicioAgregado.NombreServicio = self.servicioSeleccionado().nombreServicio;
        servicioAgregado.Precio = self.precioSeleccionado().Precio;
        servicioAgregado.Nuevo = true;
        servicioAgregado.NumeroDiente = null;
        self.serviciosAgregadosConsulta.push(servicioAgregado);
    };
    self.quitarServicioConsulta = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosConsulta()).each(function (idx, vl) {
            if (vl.Id != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosConsulta(servicios);
    };
    self.agregarServicioDiente = function () {

        var diente = self.dienteSeleccionado();

        var servicioAgregado = new Object();
        servicioAgregado.ConsultaId = idConsulta == '' ? null : idConsulta;
        servicioAgregado.ServicioId = self.servicioSeleccionadoDiente().id;
        servicioAgregado.NombreServicio = self.servicioSeleccionadoDiente().nombreServicio;
        servicioAgregado.Precio = self.precioSeleccionadoDiente().Precio;
        servicioAgregado.NumeroDiente = diente;
        servicioAgregado.Nuevo = true;

        switch (diente) {
            case 1:
                self.serviciosAgregadosDiente1.push(servicioAgregado);
                break;
            case 2:
                self.serviciosAgregadosDiente2.push(servicioAgregado);
                break;
            case 3:
                self.serviciosAgregadosDiente3.push(servicioAgregado);
                break;
            case 4:
                self.serviciosAgregadosDiente4.push(servicioAgregado);
                break;
            case 5:
                self.serviciosAgregadosDiente5.push(servicioAgregado);
                break;
            case 6:
                self.serviciosAgregadosDiente6.push(servicioAgregado);
                break;
            case 7:
                self.serviciosAgregadosDiente7.push(servicioAgregado);
                break;
            case 8:
                self.serviciosAgregadosDiente8.push(servicioAgregado);
                break;
            case 9:
                self.serviciosAgregadosDiente9.push(servicioAgregado);
                break;
            case 10:
                self.serviciosAgregadosDiente10.push(servicioAgregado);
                break;
            case 11:
                self.serviciosAgregadosDiente11.push(servicioAgregado);
                break;
            case 12:
                self.serviciosAgregadosDiente12.push(servicioAgregado);
                break;
            case 13:
                self.serviciosAgregadosDiente13.push(servicioAgregado);
                break;
            case 14:
                self.serviciosAgregadosDiente14.push(servicioAgregado);
                break;
            case 15:
                self.serviciosAgregadosDiente15.push(servicioAgregado);
                break;
            case 16:
                self.serviciosAgregadosDiente16.push(servicioAgregado);
                break;
            case 17:
                self.serviciosAgregadosDiente17.push(servicioAgregado);
                break;
            case 18:
                self.serviciosAgregadosDiente18.push(servicioAgregado);
                break;
            case 19:
                self.serviciosAgregadosDiente19.push(servicioAgregado);
                break;
            case 20:
                self.serviciosAgregadosDiente20.push(servicioAgregado);
                break;
            case 21:
                self.serviciosAgregadosDiente21.push(servicioAgregado);
                break;
            case 22:
                self.serviciosAgregadosDiente22.push(servicioAgregado);
                break;
            case 23:
                self.serviciosAgregadosDiente23.push(servicioAgregado);
                break;
            case 24:
                self.serviciosAgregadosDiente24.push(servicioAgregado);
                break;
            case 25:
                self.serviciosAgregadosDiente25.push(servicioAgregado);
                break;
            case 26:
                self.serviciosAgregadosDiente26.push(servicioAgregado);
                break;
            case 27:
                self.serviciosAgregadosDiente27.push(servicioAgregado);
                break;
            case 28:
                self.serviciosAgregadosDiente28.push(servicioAgregado);
                break;
            case 29:
                self.serviciosAgregadosDiente29.push(servicioAgregado);
                break;
            case 30:
                self.serviciosAgregadosDiente30.push(servicioAgregado);
                break;
            case 31:
                self.serviciosAgregadosDiente31.push(servicioAgregado);
                break;
            case 32:
                self.serviciosAgregadosDiente32.push(servicioAgregado);
                break;
        }


    };
    self.quitarServicioDiente1 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente1()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente1(servicios);
    };
    self.quitarServicioDiente2 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente2()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente2(servicios);
    };
    self.quitarServicioDiente3 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente3()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente3(servicios);
    };
    self.quitarServicioDiente4 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente4()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente4(servicios);
    };
    self.quitarServicioDiente5 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente5()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente5(servicios);
    };
    self.quitarServicioDiente6 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente6()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente6(servicios);
    };
    self.quitarServicioDiente7 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente7()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente7(servicios);
    };
    self.quitarServicioDiente8 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente8()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente8(servicios);
    };
    self.quitarServicioDiente9 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente9()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente9(servicios);
    };
    self.quitarServicioDiente10 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente10()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente10(servicios);
    };
    self.quitarServicioDiente11 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente11()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente11(servicios);
    };
    self.quitarServicioDiente12 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente12()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente12(servicios);
    };
    self.quitarServicioDiente13 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente13()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente13(servicios);
    };
    self.quitarServicioDiente14 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente14()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente14(servicios);
    };
    self.quitarServicioDiente15 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente15()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente15(servicios);
    };
    self.quitarServicioDiente16 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente16()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente16(servicios);
    };
    self.quitarServicioDiente17 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente17()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente17(servicios);
    };
    self.quitarServicioDiente18 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente18()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente18(servicios);
    };
    self.quitarServicioDiente19 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente19()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente19(servicios);
    };
    self.quitarServicioDiente20 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente20()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente20(servicios);
    };
    self.quitarServicioDiente21 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente21()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente21(servicios);
    };
    self.quitarServicioDiente22 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente22()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente22(servicios);
    };
    self.quitarServicioDiente23 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente23()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente23(servicios);
    };
    self.quitarServicioDiente24 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente24()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente24(servicios);
    };
    self.quitarServicioDiente25 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente25()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente25(servicios);
    };
    self.quitarServicioDiente26 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente26()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente26(servicios);
    };
    self.quitarServicioDiente27 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente27()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente27(servicios);
    };
    self.quitarServicioDiente28 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente28()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente28(servicios);
    };
    self.quitarServicioDiente29 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente29()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente29(servicios);
    };
    self.quitarServicioDiente30 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente30()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente30(servicios);
    };
    self.quitarServicioDiente31 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente31()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente31(servicios);
    };
    self.quitarServicioDiente32 = function (value) {
        var servicios = new Array();
        $(self.serviciosAgregadosDiente32()).each(function (idx, vl) {
            if (vl.ServicioId != value.ServicioId && vl.Precio != value.Precio) {
                servicios.push(vl);
            }
        });
        self.serviciosAgregadosDiente32(servicios);
    };

    self.agregarSeguimientoNutricional = function () {
        var seguimiento = new Object();
        seguimiento.Fecha = new Date();
        seguimiento.Peso = null;
        seguimiento.IMC = null;
        seguimiento.PGC = null;
        seguimiento.Cuello = null;
        seguimiento.Busto = null;
        seguimiento.CinturaAbdomen = null;
        seguimiento.Cadera = null;
        seguimiento.Muslo = null;
        seguimiento.Brazo = null;
        seguimiento.Munneca = null;
        self.seguimientosNutricionales.push(seguimiento);
    };
    self.agregarExamenesLaboratorio = function () {
        var examen = new Object();
        examen.Id = null;
        examen.Item = itemExamenLaboratorio;
        examen.Fecha = moment().format('YYYY-MM-DD');
        examen.GlucosaPre = null;
        examen.GlucosaPos = null;
        examen.HemoglobinaGlicosilada = null;
        examen.CurvaGlucosa = null;
        examen.ColesterolTotal = null;
        examen.Trigliceridos = null;
        examen.PerfilLipidico = null;
        examen.Creatinina = null;
        examen.AcidoUrico = null;
        examen.Hemoglobina = null;
        examen.T3 = null;
        examen.T4 = null;
        examen.ExamenHeces = null;
        examen.ExamenOrina = null;
        examen.Otros = null;
        examen.UrlResultados = null;
        self.examenesLaboratorio.push(examen);
        itemExamenLaboratorio++;
    };
    self.quitarExamenLaboratorio = function (value) {
        $(self.examenesLaboratorio()).each(function (index, examen) {
            if (examen.Item == value.Item) {
                self.examenesLaboratorio.splice(index, 1);
            }
        });
    };
    self.agregarRangoSaludable = function () {
        var rango = new Object();
        rango.Id = null;
        rango.Item = itemRangoSaludable;
        rango.Fecha = moment().format('YYYY-MM-DD');
        rango.IMC = null;
        rango.Peso = null;
        rango.PorcentajeGrasaCorporal = null;
        self.rangosSaludables.push(rango);
        itemRangoSaludable++;
    };
    self.quitarRangoSaludable = function (value) {
        $(self.rangosSaludables()).each(function (index, rango) {
            if (value.Item == rango.Item) {
                self.rangosSaludables.splice(index, 1);
            }
        });
    };

    self.obtenerServiciosConsulta = function () {
        $(self.serviciosAgregadosDiente1()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente2()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente3()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente4()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente5()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente6()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente7()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente8()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente9()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente10()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente11()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente12()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente13()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente14()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente15()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente16()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente17()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente18()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente19()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente20()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente21()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente22()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente23()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente24()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente25()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente26()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente27()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente28()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente29()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente30()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente31()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
        $(self.serviciosAgregadosDiente32()).each(function (idx, vl) {
            self.serviciosAgregadosConsulta.push(vl);
        });
    };

    self.getModel = function () {
        model = {
            "CitaId": $("#CitaId").val(),
            "PacienteId": pacienteId,
            "ConsultaId": $("#ConsultaId").val(),

            "CaracteristicasDientes": self.caracteristicasDentales(),
            "ServiciosAgregados": self.serviciosAgregadosConsulta(),
            "SeguimientosNutricionales": self.seguimientosNutricionales(),
            "RangosSaludables": self.rangosSaludables(),
            "VacunasPaciente": self.vacunas(),
            //ExamenesLaboratorio
            "ExamenesLaboratorio": self.examenesLaboratorio(),

            "TipoConsulta": $("#TipoConsulta").val(),
            "FaseTratamientoId": $("#FaseTratamientoId").val(),
            "TipoReferencia": $("#TipoReferencia").val(),
            "MedicoReferido": $("#MedicoReferido").val(),
            "EstadoPagoId": $("#EstadoPagoId").val(),
            "FechaYHoraInicio": $("#FechaYHoraInicio").val(),
            "FechaProximaConsulta": $("#FechaProximaConsulta").val(),
            "FechaUltimaRadiografiaDental": $("#FechaUltimaRadiografiaDental").val(),
            "ObservacionesAdicionales": $("#ObservacionesAdicionales").val(),
            "CostoConsulta": $("#CostoConsulta").val(),
            "CuentasPorCobrar": $("#CuentasPorCobrar").val(),
            "BebeBebidasAlcoholicas": $('input:radio[name=BebeBebidasAlcoholicas]:checked').val(),
            "AlcoholUltimas24Horas": $("#AlcoholUltimas24Horas").val(),
            "AlcoholSemanal": $("#AlcoholSemanal").val(),

            //Estetica
            "Metabolismo": $("#Metabolismo").val(),
            "Grasa": $("#Grasa").val(),
            "IMC": $("#IMC").val(),
            "Agua": $("#Agua").val(),
            "Obesidad": $("#Obesidad").val(),
            "ContornoBrazos": $("#ContornoBrazos").val(),
            "ContornoBusto": $("#ContornoBusto").val(),
            "ContornoAbdomen": $("#ContornoAbdomen").val(),
            "ContornoCadera": $("#ContornoCadera").val(),
            "ContornoPiernas": $("#ContornoPiernas").val(),
            "Estatura": $("#Estatura").val(),

            //Examen fisico
            "ExamenFisicoTemperatura": $("#ExamenFisicoTemperatura").val(),
            "ExamenFisicoFrecuenciaRespiratoria": $("#ExamenFisicoFrecuenciaRespiratoria").val(),
            "ExamenFisicoFrecuenciaCardiaca": $("#ExamenFisicoFrecuenciaCardiaca").val(),
            "ExamenFisicoSaturacionOxigeno": $("#ExamenFisicoSaturacionOxigeno").val(),
            "ExamenFisicoPresionArterial": $("#ExamenFisicoPresionArterial").val(),
            "ExamenFisicoGlucosa": $("#ExamenFisicoGlucosa").val(),
            "ExamenFisicoPeso": $("#ExamenFisicoPeso").val(),
            "ExamenFisicoTalla": $("#ExamenFisicoTalla").val(),
            "ExamenFisicoIMC": $("#ExamenFisicoIMC").val(),
            "ExamenFisicoObservaciones": $("#ExamenFisicoObservaciones").val(),

            //URlfiles
            "UrlFiles": $("#UrlFiles").val(),

            //Historia
            "HistoriaProblema": $("#HistoriaProblema").val(),
            "Sintomas": $("#Sintomas").val(),
            "Diagnostico": $("#Diagnostico").val(),

            //Mujeres
            "EstaEmbarazada": $('input:radio[name=EstaEmbarazada]:checked').val(),
            "NumeroSemanasEmbarazo": $("#NumeroSemanasEmbarazo").val(),
            "TomaPildorasAnticonceptivas": $('input:radio[name=TomaPildorasAnticonceptivas]:checked').val(),
            "EstaAmamantando": $('input:radio[name=EstaAmamantando]:checked').val(),

            //Area terapeutica
            "TerapeuticoDatosGenerales": $("#TerapeuticoDatosGenerales").val(),
            "TerapeuticoActividadesDiarias": $("#TerapeuticoActividadesDiarias").val(),
            "TerapeuticoConQuienVive": $("#TerapeuticoConQuienVive").val(),
            "TerapeuticoHabitosAlimenticios": $("#TerapeuticoHabitosAlimenticios").val(),
            "TerapeuticoEjercicio": $("#TerapeuticoEjercicio").val(),
            "TerapeuticoFinesSemana": $("#TerapeuticoFinesSemana").val(),
            "TerapeuticoHistoriaMedica": $("#TerapeuticoHistoriaMedica").val(),
            "TerapeuticoHistoriaPeso": $("#TerapeuticoHistoriaPeso").val()
        };
    };
    self.registrarConsulta = function () {
        if (confirm("¿Desea guardar la consulta?")) {

            //Guardar los archivos correspondientes
            var formDataArchivos = new FormData();
            //Resultados de laboratorios
            $(self.examenesLaboratorio()).each(function (idx, examen) {
                if ($("#resultados-laboratorio-" + examen.Item).get(0).files[0] != null
                    && $("#resultados-laboratorio-" + examen.Item).get(0).files[0] != undefined) {
                    formDataArchivos.append("Archivos", $("#resultados-laboratorio-" + examen.Item).get(0).files[0], "ResultadosLaboratorio" + examen.Item);
                }
            });

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
                        $(self.examenesLaboratorio()).each(function (idxExamen, examen) {
                            if (examen.Item == parseInt(archivo.nombreArchivo.replace("ResultadosLaboratorio", ""))) {
                                examen.UrlResultados = archivo.urlArchivo;
                            }
                        });
                    });
                    //Registrar consulta
                    self.obtenerServiciosConsulta();
                    self.getModel();

                    $.ajax({
                        method: "POST",
                        url: '/Consultas/IniciarConsulta',
                        data: model,
                        success: function (data, textStatus) {
                            var dataResult = JSON.parse(data);
                            if (dataResult.Exitoso)
                                window.location.href = "/Consultas/Informacion/" + dataResult.ConsultaId;
                            else {
                                $("#div-loading").hide();
                                alert(dataResult.Mensaje);
                            }
                        },
                        error: function (data) {
                            $("#div-loading").hide();
                            alert(data.error);
                        }
                    });
                }
            });





        }
    };


    self.editarConsulta = function () {
        self.obtenerServiciosConsulta();
        self.getModel();

        $.ajax({
            method: "POST",
            url: '/Consultas/EditarConsulta',
            data: model,
            success: function (data, textStatus) {
                var dataResult = JSON.parse(data);
                if (dataResult.Exitoso)
                    window.location.href = "/Consultas/Informacion/" + dataResult.ConsultaId;
                else
                    alert(dataResult.Mensaje);
            },
            error: function (data) {
                alert(data.error);
            }
        });
    };

    self.actualizarVista = function () {
        //Inicia Cálculo de IMC
        var peso = 0.0;
        var estatura = 0.0;
        try { peso = parseFloat($("#Peso").val()) } catch { peso = 0.0 }
        try { estatura = parseFloat($("#Estatura").val()) } catch { estatura = 0.0 }
        var imc = 0.0;
        if (estatura > 0 && peso > 0) {
            imc = peso / (estatura * estatura);
            $("#IMC").val(imc.toString() + " kg/m2");
        } else {
            $("#IMC").val("");
        }
        //Finaliza cálculo de IMC
    };
}

var consultaVm = new ConsultaVM();
ko.applyBindings(consultaVm);

$(document).ready(function () {
    $("#tabs").tabs();
    consultaVm.consultarServiciosAgregadosConsulta();
    consultaVm.consultarCaracteristicasDentales();
    consultaVm.consultarServicios();
    consultaVm.consultarVacunasPaciente();
    consultaVm.consultarSeguimientosNutricionales();
});