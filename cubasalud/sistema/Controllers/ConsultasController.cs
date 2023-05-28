using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Xml.Xsl;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Net.Http;
using System.IO.Enumeration;
using System.Runtime.Serialization.Json;
// using System.Xml.Xsl.Runtime;
using System.Threading.Tasks.Sources;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Buffers;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Diagnostics;
//using System.Xml.Xsl.Runtime;
using System.Reflection.PortableExecutable;
using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net;
using System.Linq.Expressions;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Reflection;
using System.Security.Authentication;
using System.Security.AccessControl;
using System;
using Microsoft.AspNetCore.Mvc;
using Database.Shared.IRepository;
using sistema.Models;
using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Wkhtmltopdf.NetCore;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;
using System.Globalization;
using ClosedXML.Excel;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
    public class ConsultasController : Controller
    {
        private readonly ICitas _citasRepository = null;
        private readonly IServicio _serviciosRepository = null;
        private readonly IConsultas _consultasRepository = null;
        private readonly IPacientes _pacientesRepository = null;

        public ConsultasController(ICitas citasRepository, IConsultas consultasRepository, IServicio serviciosRepository,
        IPacientes pacientesRepository)
        {
            _citasRepository = citasRepository;
            _consultasRepository = consultasRepository;
            _serviciosRepository = serviciosRepository;
            _pacientesRepository = pacientesRepository;
        }
        public IActionResult Index()
        {
            var consultas = new List<Consulta>();
            consultas = (List<Consulta>)_consultasRepository.ListaConsultas();
            return View(consultas);
        }
        public IActionResult IniciarConsulta(int? citaId)
        {

            if (citaId == null) return StatusCode(400);
            var cita = _citasRepository.GetCita((int)citaId);
            if (cita == null) return StatusCode(404);


            var consultasPaciente = _consultasRepository.ListaConsultas()
                .Where(c => c.Citas.PacienteId == cita.PacienteId);
            var ultimaConsulta = _consultasRepository.GetUltimaConsultaPaciente(cita.PacienteId);

            var model = new ConsultasViewModel()
            {
                CitaId = (int)citaId,
                PacienteId = cita.PacienteId,
                Nombres = cita.ClienteText,
                Servicio = cita.ServicioText,
                MedicoAsignado = cita.EmpleadoText,
                FechaYHoraInicio = DateTime.Now,
                CostoConsulta = cita.Servicio == null ? 0 : cita.Servicio.Precio,

                PacienteNombre = cita.Paciente.Nombre,
                PacienteNit = cita.Paciente.Nit,
                PacienteFechaNacimiento = cita.Paciente.FechaNacimiento == null ? "" :
                                            cita.Paciente.FechaNacimiento.ToString(),
                PacienteDireccion = cita.Paciente.Direccion,
                PacienteAlias = cita.Paciente.Alias,
                PacienteSexo = cita.Paciente.Sexo.DescripcionSexo,
                PacienteEdad = cita.Paciente.Edad == null ? "-" : cita.Paciente.Edad.ToString(),
                PacienteTelefono = cita.Paciente.Telefono,
                PacienteCelular = cita.Paciente.Celular,
                PacienteMedicos = cita.Paciente.AntecedentesMedicos,
                PacienteQuirurgicos = cita.Paciente.AntecedentesQuirurgicos,
                PacienteTraumaticos = cita.Paciente.AntecedentesTraumaticos,
                PacienteAlergias = cita.Paciente.AntecedentesAlergias,
                PacienteVicios = cita.Paciente.AntecedentesVicios,
                PacienteMedicamentos = cita.Paciente.AntecedentesMedicamentos,

                SeguimientosNutricionales = new List<SeguimientoNutricionalConsulta>(),
                VacunasPaciente = new List<VacunaPacienteConsulta>()
            };

            if (ultimaConsulta == null)
            {
                model.FechaUltimaConsulta = null;
                model.MotivoUltimaConsulta = null;
            }
            else
            {
                model.FechaUltimaConsulta = ultimaConsulta.FechaYHoraInicioConsulta;
                model.MotivoUltimaConsulta = ultimaConsulta.Citas.Motivo;
            }

            //Utilizado en caso de requerirse datos de la primera consulta del paciente
            var primeraConsulta = consultasPaciente
                .OrderBy(c => c.FechaYHoraInicioConsulta)
                .FirstOrDefault();
            if (primeraConsulta == null)
            {
                model.PrimeraConsulta = true;
            }
            else
            {
                model.PrimeraConsulta = false;

                model.TerapeuticoDatosGenerales = primeraConsulta.TerapeuticoDatosGenerales;
                model.TerapeuticoActividadesDiarias = primeraConsulta.TerapeuticoActividadesDiarias;
                model.TerapeuticoConQuienVive = primeraConsulta.TerapeuticoConQuienVive;
                model.TerapeuticoHabitosAlimenticios = primeraConsulta.TerapeuticoHabitosAlimenticios;
                model.TerapeuticoEjercicio = primeraConsulta.TerapeuticoEjercicio;
                model.TerapeuticoFinesSemana = primeraConsulta.TerapeuticoFinesSemana;
                model.TerapeuticoHistoriaMedica = primeraConsulta.TerapeuticoHistoriaMedica;
                model.TerapeuticoHistoriaPeso = primeraConsulta.TerapeuticoHistoriaPeso;

                model.TerapeuticoHistoricoObservaciones = new List<HistoricoObservacionesTerapeuticoConsultaViewModel>();

                foreach (var consultaPaciente in consultasPaciente)
                {
                    model.TerapeuticoHistoricoObservaciones.Add(new HistoricoObservacionesTerapeuticoConsultaViewModel
                    {
                        Fecha = consultaPaciente.FechaYHoraInicioConsulta,
                        Observaciones = consultaPaciente.TerapeuticoObservaciones
                    });
                }
            }

            //Rangos saludables
            var rangos = _pacientesRepository.GetRangosSaludablesPaciente((int)cita.PacienteId)
                .OrderBy(r => r.Fecha);
            if (rangos != null)
            {
                foreach (var rangoPaciente in rangos)
                {
                    model.RangosSaludablesHistorico.Add(new RangoSaludableConsultaViewModel
                    {
                        Id = rangoPaciente.Id,
                        Fecha = rangoPaciente.Fecha,
                        IMC = rangoPaciente.IMC,
                        Peso = rangoPaciente.Peso,
                        PorcentajeGrasaCorporal = rangoPaciente.PorcentajeGrasaCorporal
                    });
                }
            }

            model.Init(_citasRepository, _serviciosRepository, _pacientesRepository);

            ViewBag.PacienteId = cita.PacienteId;

            return View(model);
        }
        [HttpPost]
        public JsonResult ConsultarServicios()
        {
            IList<Servicio> resultado;

            try
            {
                resultado = _serviciosRepository.GetListaServicios();
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar servicios: " + ex.Message });
            }

            return Json(new { Exitoso = true, Resultado = resultado });
        }
        [HttpPost]
        public string IniciarConsulta(ConsultasViewModel model)
        {
            try
            {
                var historia = new Historia()
                {
                    HistoriaProblema = model.HistoriaProblema == null ? "--- Historia del problema ---" : model.HistoriaProblema,
                    Sintomas = model.Sintomas == null ? "--- Sintomas ---" : model.Sintomas,
                    Diagnostico = model.Diagnostico == null ? "--- Diagnostico ---" : model.Diagnostico
                };
                var examenFisico = new ExamenFisico()
                {
                    Temperatura = model.ExamenFisicoTemperatura == null ?
                         "--- Temperatura ---" : model.ExamenFisicoTemperatura,
                    FrecuenciaRespiratoria = model.ExamenFisicoFrecuenciaRespiratoria == null ?
                        "--- FrecuenciaRespiratoria ---" : model.ExamenFisicoFrecuenciaRespiratoria,
                    FrecuenciaCardiaca = model.ExamenFisicoFrecuenciaCardiaca == null ?
                        "--- Frecuencia Cardiaca ---" : model.ExamenFisicoFrecuenciaCardiaca,
                    SaturacionDeOxigeno = model.ExamenFisicoSaturacionOxigeno == null ?
                        "--- Saturacion De Oxigeno ---" : model.ExamenFisicoSaturacionOxigeno,
                    PresionArterialBrazoDerecho = model.ExamenFisicoPresionArterialBrazoDerecho == null ?
                        "--- Presion Arterial Brazo Derecho ---" : model.ExamenFisicoPresionArterialBrazoDerecho,
                    PresionArterialBrazoIzquierdo = model.ExamenFisicoPresionArterialBrazoIzquierdo == null ?
                        "--- Presion Arterial Brazo Derecho ---" : model.ExamenFisicoPresionArterialBrazoIzquierdo,
                    Observaciones = model.ExamenFisicoObservaciones == null ?
                        "--- Observaciones o texto adicional ---" : model.ExamenFisicoObservaciones,
                    Peso = model.ExamenFisicoPeso == null ?
                        "--- Peso ---" : model.ExamenFisicoPeso,
                    Talla = model.ExamenFisicoTalla == null ?
                        "--- Talla ---" : model.ExamenFisicoTalla,
                    Glucosa = model.ExamenFisicoGlucosa == null ?
                        "--- Glucosa ---" : model.ExamenFisicoGlucosa,
                    IMC = model.ExamenFisicoIMC == null ?
                        "--- Glucosa ---" : model.ExamenFisicoIMC
                };
                var numeroSemanasEmbarazo = 0;
                try { numeroSemanasEmbarazo = Convert.ToInt32(model.NumeroSemanasEmbarazo); } catch { numeroSemanasEmbarazo = 0; }
                var consulta = new Consulta
                {
                    //General
                    CitasId = model.CitaId,
                    ObservacionesAdicionales = model.ObservacionesAdicionales,
                    FechaYHoraInicioConsulta = (DateTime)model.FechaYHoraInicio,
                    FechaProximaConsulta = model.FechaProximaConsulta,
                    UrlFiles = model.UrlFiles,
                    EstadoPagoConsultaId = (int)model.EstadoPagoId,
                    TipoConsulta = model.TipoConsulta,
                    TipoReferencia = model.TipoReferencia,
                    MedicoReferido = model.MedicoReferido,
                    CostoConsulta = (decimal)model.CostoConsulta,
                    FaseTratamientoId = model.FaseTratamientoId,

                    Historia = historia,
                    ExamenFisico = examenFisico,

                    //Estetico
                    Estetico_Metabolismo = model.Metabolismo,
                    Estetico_Grasa = model.Grasa,
                    Estetico_Agua = model.Agua,
                    Estetico_IMC = model.IMC,
                    Estetico_Obesidad = model.Obesidad,
                    Estetico_ContornoBrazos = model.ContornoBrazos,
                    Estetico_ContornoBusto = model.ContornoBusto,
                    Estetico_ContornoAbdomen = model.ContornoAbdomen,
                    Estetico_ContornoCadera = model.ContornoCadera,
                    Estetico_ContornoPiernas = model.ContornoPiernas,
                    Estetico_Estatura = model.Estatura,

                    //Sección solo para mujeres
                    EstaEmbarazada = model.EstaEmbarazada,
                    NumeroSemanasEmbarazo = numeroSemanasEmbarazo,
                    TomaPildorasAnticonceptivas = model.TomaPildorasAnticonceptivas,
                    EstaAmamantando = model.EstaAmamantando,

                    //Bebidas Alcoholicas
                    BebeBebidasAlcoholicas = model.BebeBebidasAlcoholicas,
                    AlcoholUltimas24Horas = model.AlcoholUltimas24Horas,
                    AlcoholSemanal = model.AlcoholSemanal,

                    //Dental
                    FechaUltimaRadiografiaDental = model.FechaUltimaRadiografiaDental,

                    //Neurologico
                    ExamenNeurologico = model.ExamenNeurologico,

                    //Ginecologico
                    ExamenGinecologico = model.ExamenGinecologico,

                    //Sistemas
                    SistemaCardiopulmonar = model.SistemaCardiopulmonar,
                    SistemaOsteoarticular = model.SistemaOsteoarticular,
                    SistemaHematologico = model.SistemaHematologico,

                    //Area terapeutica
                    TerapeuticoDatosGenerales = model.TerapeuticoDatosGenerales,
                    TerapeuticoActividadesDiarias = model.TerapeuticoActividadesDiarias,
                    TerapeuticoConQuienVive = model.TerapeuticoConQuienVive,
                    TerapeuticoHabitosAlimenticios = model.TerapeuticoHabitosAlimenticios,
                    TerapeuticoEjercicio = model.TerapeuticoEjercicio,
                    TerapeuticoFinesSemana = model.TerapeuticoFinesSemana,
                    TerapeuticoHistoriaMedica = model.TerapeuticoHistoriaMedica,
                    TerapeuticoHistoriaPeso = model.TerapeuticoHistoriaPeso
                };

                //Servicios
                var servicios = new List<ConsultaServicio>();
                if (model.ServiciosAgregados != null && model.ServiciosAgregados.Count > 0)
                {
                    foreach (var servicioAg in model.ServiciosAgregados)
                    {
                        servicios.Add(new ConsultaServicio
                        {
                            ServicioId = (int)servicioAg.ServicioId,
                            NumeroDiente = servicioAg.NumeroDiente,
                            Precio = servicioAg.Precio
                        });

                        _serviciosRepository.ActualizarInventarioVentaServicio((int)servicioAg.ServicioId);
                    }
                }
                consulta.ConsultasServicios = servicios;

                //Caracteristicas dentales
                var caracteristicas = new List<ConsultaCaracteristicaDental>();
                foreach (var caracteristica in model.CaracteristicasDientes)
                {
                    caracteristicas.Add(new ConsultaCaracteristicaDental
                    {
                        NumeroDiente = caracteristica.NumeroDiente,
                        Percusiones_VerticalMas = caracteristica.Percusiones_VerticalMas,
                        Percusiones_HorizontalMas = caracteristica.Percusiones_HorizontalMas,
                        Percusiones_VerticalMenos = caracteristica.Percusiones_VerticalMenos,
                        Percusiones_HorizontalMenos = caracteristica.Percusiones_HorizontalMenos,
                        Dolor_Localizado = caracteristica.Dolor_Localizado,
                        Dolor_Fugaz = caracteristica.Dolor_Fugaz,
                        Dolor_Persistente = caracteristica.Dolor_Persistente,
                        Dolor_Referido = caracteristica.Dolor_Referido,
                        Dolor_Espontaneo = caracteristica.Dolor_Espontaneo,
                        Estimulo_Frio = caracteristica.Estimulo_Frio,
                        Estimulo_Calor = caracteristica.Estimulo_Calor,
                        Estimulo_DulceAcido = caracteristica.Estimulo_DulceAcido,
                        Estimulo_Masticacion = caracteristica.Estimulo_Masticacion,
                        Estimulo_Otro = caracteristica.Estimulo_Otro,
                        TermicaFrio_Positiva = caracteristica.TermicaFrio_Positiva,
                        TermicaFrio_Negativa = caracteristica.TermicaFrio_Negativa,
                        TermicaFrio_Localizada = caracteristica.TermicaFrio_Localizada,
                        TermicaFrio_Fugaz = caracteristica.TermicaFrio_Fugaz,
                        TermicaFrio_Incrementa = caracteristica.TermicaFrio_Incrementa,
                        TermicaFrio_Referida = caracteristica.TermicaFrio_Referida,
                        TermicaFrio_Irradiado = caracteristica.TermicaFrio_Irradiado,
                        TermicaFrio_Persistente = caracteristica.TermicaFrio_Persistente,
                        TermicaFrio_Decrece = caracteristica.TermicaFrio_Decrece,
                        TermicaCalor_Positiva = caracteristica.TermicaCalor_Positiva,
                        TermicaCalor_Negativa = caracteristica.TermicaCalor_Negativa,
                        TermicaCalor_Localizada = caracteristica.TermicaCalor_Localizada,
                        TermicaCalor_Fugaz = caracteristica.TermicaCalor_Fugaz,
                        TermicaCalor_Incrementa = caracteristica.TermicaCalor_Incrementa,
                        TermicaCalor_Referida = caracteristica.TermicaCalor_Referida,
                        TermicaCalor_Irradiado = caracteristica.TermicaCalor_Irradiado,
                        TermicaCalor_Persistente = caracteristica.TermicaCalor_Persistente,
                        TermicaCalor_Decrece = caracteristica.TermicaCalor_Decrece,
                        Diagnostico_ManchaBlanca = caracteristica.Diagnostico_ManchaBlanca,
                        Diagnostico_Caries = caracteristica.Diagnostico_Caries,
                        Diagnostico_Traumatismo = caracteristica.Diagnostico_Traumatismo,
                        Diagnostico_Abfraccion = caracteristica.Diagnostico_Abfraccion,
                        Diagnostico_Atricion = caracteristica.Diagnostico_Atricion,
                        Diagnostico_Erosion = caracteristica.Diagnostico_Erosion,
                        Diagnostico_Restauracion = caracteristica.Diagnostico_Restauracion,
                        Diagnostico_Ajustada = caracteristica.Diagnostico_Ajustada,
                        Diagnostico_Desajustada = caracteristica.Diagnostico_Desajustada,
                        Diagnostico_PulpaSana = caracteristica.Diagnostico_PulpaSana,
                        Diagnostico_PulpitisReversible = caracteristica.Diagnostico_PulpitisReversible,
                        Diagnostico_PulpitisIrreversible = caracteristica.Diagnostico_PulpitisIrreversible,
                        Diagnostico_NecrosisPulpar = caracteristica.Diagnostico_NecrosisPulpar
                    });
                }
                consulta.ConsultasCaracteristicasDentales = caracteristicas;

                //Seguimientos nutricionales
                if (model.SeguimientosNutricionales != null
                 && model.SeguimientosNutricionales.Count > 0)
                {
                    foreach (var seguimiento in model.SeguimientosNutricionales)
                    {
                        var seguimientoConsulta = new PacienteSeguimientoNutricional
                        {
                            PacienteId = model.PacienteId,
                            Fecha = seguimiento.Fecha,
                            Peso = seguimiento.Peso,
                            IMC = seguimiento.IMC,
                            PGC = seguimiento.PGC,
                            Cuello = seguimiento.Cuello,
                            Busto = seguimiento.Busto,
                            CinturaAbdomen = seguimiento.CinturaAbdomen,
                            Cadera = seguimiento.Cadera,
                            Muslo = seguimiento.Muslo,
                            Brazo = seguimiento.Brazo,
                            Muñeca = seguimiento.Munneca,
                        };
                        if (seguimiento.Id != 0)
                        {
                            seguimientoConsulta.Id = (int)seguimiento.Id;
                            _pacientesRepository.UpdateSeguimientoNutricional(seguimientoConsulta);
                        }
                        else
                        {
                            _pacientesRepository.AddSeguimientoNutricional(seguimientoConsulta);
                        }
                    }
                }

                //Resultados examenes laboratorio
                if (model.ExamenesLaboratorio != null
                 && model.ExamenesLaboratorio.Count > 0)
                {
                    foreach (var examen in model.ExamenesLaboratorio)
                    {
                        var examenLaboratorioConsulta = new PacienteResultadoExamenLaboratorio
                        {
                            PacienteId = model.PacienteId,
                            Fecha = examen.Fecha,
                            GlucosaPre = examen.GlucosaPre,
                            GlucosaPos = examen.GlucosaPos,
                            HemoglobinaGlicosilada = examen.HemoglobinaGlicosilada,
                            CurvaGlucosa = examen.CurvaGlucosa,
                            ColesterolTotal = examen.ColesterolTotal,
                            Trigliceridos = examen.Trigliceridos,
                            PerfilLipidico = examen.PerfilLipidico,
                            Creatinina = examen.Creatinina,
                            AcidoUrico = examen.AcidoUrico,
                            Hemoglobina = examen.Hemoglobina,
                            T3 = examen.T3,
                            T4 = examen.T4,
                            ExamenHeces = examen.ExamenHeces,
                            ExamenOrina = examen.ExamenOrina,
                            Otros = examen.Otros,
                            UrlResultados = examen.UrlResultados
                        };
                        if (examen.Id != null)
                        {
                            examenLaboratorioConsulta.Id = (int)examen.Id;
                            _pacientesRepository.UpdateResultadoExamenLaboratorio(examenLaboratorioConsulta);
                        }
                        else
                        {
                            _pacientesRepository.AddResultadoExamenLaboratorio(examenLaboratorioConsulta);
                        }
                    }
                }

                //Vacunas paciente
                var vacunasAgregadas = new List<VacunaPaciente>();
                foreach (var vacuna in model.VacunasPaciente)
                {
                    var vacunaPaciente = new VacunaPaciente
                    {
                        PacienteId = (int)model.PacienteId,
                        VacunaId = (int)vacuna.VacunaId,
                        Primera = (bool)vacuna.Primera,
                        FechaPrimera = vacuna.FechaPrimera,
                        Segunda = (bool)vacuna.Segunda,
                        FechaSegunda = vacuna.FechaSegunda,
                        Tercera = (bool)vacuna.Tercera,
                        FechaTercera = vacuna.FechaTercera,
                        PrimerRefuerzo = (bool)vacuna.PrimerRefuerzo,
                        FechaPrimerRefuerzo = vacuna.FechaPrimerRefuerzo,
                        SegundoRefuerzo = (bool)vacuna.SegundoRefuerzo,
                        FechaSegundoRefuerzo = vacuna.FechaSegundoRefuerzo
                    };
                    vacunasAgregadas.Add(vacunaPaciente);
                }
                var listaVacunasExistentes = _pacientesRepository.GetVacunasPaciente((int)model.PacienteId);
                if (listaVacunasExistentes == null || listaVacunasExistentes.Count == 0)
                {
                    var paciente = _pacientesRepository.Get((int)model.PacienteId);
                    paciente.VacunasPaciente = vacunasAgregadas;
                    _pacientesRepository.Update(paciente);
                }




                //Actualizar estado de cita
                var ncita = _citasRepository.GetCita((int)model.CitaId);
                ncita.Finalizada = true;
                _citasRepository.Update(ncita);

                //Agenda automatica de proxima cita
                var proximaCita = new Citas
                {
                    PacienteId = model.PacienteId,
                    FechaInicio = new DateTime(Convert.ToDateTime(model.FechaProximaConsulta).Year,
                    Convert.ToDateTime(model.FechaProximaConsulta).Month, Convert.ToDateTime(model.FechaProximaConsulta).Day),
                    FechaFinal = new DateTime(Convert.ToDateTime(model.FechaProximaConsulta).Year,
                    Convert.ToDateTime(model.FechaProximaConsulta).Month, Convert.ToDateTime(model.FechaProximaConsulta).Day),
                    Eliminado = false,
                    Finalizada = false,
                    EstadoCita = "normal",
                    Bloqueada = false
                };
                _citasRepository.Add(proximaCita);

                //Registro de consulta
                var idConsultaRegistrada = _consultasRepository.AddConsulta(consulta);
                TempData["Message"] = "¡La consulta se ha guardado con éxito.!";
                return JsonSerializer.Serialize(new { Exitoso = true, ConsultaId = idConsultaRegistrada });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new { Exitoso = false, Mensaje = "Error al registrar consulta. " + ex.Message });
            }
        }
        public IActionResult Informacion(int? id)
        {
            if (id == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)id);
            if (consulta == null) return StatusCode(400);

            var model = new InfoConsultaViewModel();
            model.Consulta = consulta;

            var cita = _citasRepository.GetCita((int)consulta.CitasId);

            model.Paciente = cita.Paciente;

            return View(model);
        }
        [HttpPost]
        public JsonResult ConsultarInformacion(int consultaId)
        {
            var consulta = _consultasRepository.GetConsulta(consultaId);
            return Json(new { Exitoso = true, Resultado = consulta });
        }
        [HttpPost]
        public string ConsultarVacunasPaciente(int pacienteId)
        {
            var listaVacunas = new List<VacunaPacienteConsulta>();
            var vacunasPaciente = _pacientesRepository.GetVacunasPaciente(pacienteId);


            var vacunas = _pacientesRepository.GetVacunas();

            if (vacunasPaciente == null || vacunasPaciente.Count == 0)
            {
                foreach (var vacuna in vacunas)
                {
                    var vacunaConsulta = new VacunaPacienteConsulta
                    {
                        VacunaId = vacuna.Id,
                        NombreVacuna = vacuna.Nombre,
                        Primera = false,
                        FechaPrimera = new DateTime(),
                        Segunda = false,
                        FechaSegunda = new DateTime(),
                        Tercera = false,
                        FechaTercera = new DateTime(),
                        PrimerRefuerzo = false,
                        FechaPrimerRefuerzo = new DateTime(),
                        SegundoRefuerzo = false,
                        FechaSegundoRefuerzo = new DateTime()
                    };
                    listaVacunas.Add(vacunaConsulta);
                }
            }
            else
            {
                foreach (var vacuna in vacunas)
                {
                    var existe = vacunasPaciente
                        .Where(v => v.VacunaId == vacuna.Id)
                        .FirstOrDefault();
                    if (existe == null)
                    {
                        var vacunaConsulta = new VacunaPacienteConsulta
                        {
                            VacunaId = vacuna.Id,
                            NombreVacuna = vacuna.Nombre
                        };
                        listaVacunas.Add(vacunaConsulta);
                    }
                    else
                    {
                        var vacunaConsulta = new VacunaPacienteConsulta
                        {
                            VacunaPacienteId = existe.Id,
                            VacunaId = existe.VacunaId,
                            NombreVacuna = existe.Vacuna.Nombre,
                            Primera = existe.Primera,
                            FechaPrimera = existe.FechaPrimera,
                            Segunda = existe.Segunda,
                            FechaSegunda = existe.FechaSegunda,
                            Tercera = existe.Tercera,
                            FechaTercera = existe.FechaTercera,
                            PrimerRefuerzo = existe.PrimerRefuerzo,
                            FechaPrimerRefuerzo = existe.FechaPrimerRefuerzo,
                            SegundoRefuerzo = existe.SegundoRefuerzo,
                            FechaSegundoRefuerzo = existe.FechaSegundoRefuerzo
                        };
                        listaVacunas.Add(vacunaConsulta);
                    }
                }
            }
            return JsonSerializer.Serialize(new { Exitoso = true, Resultado = listaVacunas });
        }
        [HttpPost]
        public string ConsultarCaracteristicasDentales(int? consultaId)
        {
            var listaCaracteristicas = new List<CaracteristicasDiente>();
            if (consultaId == null)
            {
                for (int i = 1; i <= 32; i++)
                {
                    var caracteristica = new CaracteristicasDiente
                    {
                        NumeroDiente = i
                    };
                    listaCaracteristicas.Add(caracteristica);
                }
            }
            else
            {
                var caracteristicasDentalesConsulta = _consultasRepository.GetCaracteristicasDentales(consultaId);
                foreach (var caracteristica in caracteristicasDentalesConsulta)
                {
                    var caracteristicaConsulta = new CaracteristicasDiente
                    {
                        NumeroDiente = (int)caracteristica.NumeroDiente,
                        Percusiones_VerticalMas = caracteristica.Percusiones_VerticalMas,
                        Percusiones_HorizontalMas = caracteristica.Percusiones_HorizontalMas,
                        Percusiones_VerticalMenos = caracteristica.Percusiones_VerticalMenos,
                        Percusiones_HorizontalMenos = caracteristica.Percusiones_HorizontalMenos,
                        Dolor_Localizado = caracteristica.Dolor_Localizado,
                        Dolor_Fugaz = caracteristica.Dolor_Fugaz,
                        Dolor_Persistente = caracteristica.Dolor_Persistente,
                        Dolor_Referido = caracteristica.Dolor_Referido,
                        Dolor_Espontaneo = caracteristica.Dolor_Espontaneo,
                        Estimulo_Frio = caracteristica.Estimulo_Frio,
                        Estimulo_Calor = caracteristica.Estimulo_Calor,
                        Estimulo_DulceAcido = caracteristica.Estimulo_DulceAcido,
                        Estimulo_Masticacion = caracteristica.Estimulo_Masticacion,
                        Estimulo_Otro = caracteristica.Estimulo_Otro,
                        TermicaFrio_Positiva = caracteristica.TermicaFrio_Positiva,
                        TermicaFrio_Negativa = caracteristica.TermicaFrio_Negativa,
                        TermicaFrio_Localizada = caracteristica.TermicaFrio_Localizada,
                        TermicaFrio_Fugaz = caracteristica.TermicaFrio_Fugaz,
                        TermicaFrio_Incrementa = caracteristica.TermicaFrio_Incrementa,
                        TermicaFrio_Referida = caracteristica.TermicaFrio_Referida,
                        TermicaFrio_Irradiado = caracteristica.TermicaFrio_Irradiado,
                        TermicaFrio_Persistente = caracteristica.TermicaFrio_Persistente,
                        TermicaFrio_Decrece = caracteristica.TermicaFrio_Decrece,
                        TermicaCalor_Positiva = caracteristica.TermicaCalor_Positiva,
                        TermicaCalor_Negativa = caracteristica.TermicaCalor_Negativa,
                        TermicaCalor_Localizada = caracteristica.TermicaCalor_Localizada,
                        TermicaCalor_Fugaz = caracteristica.TermicaCalor_Fugaz,
                        TermicaCalor_Incrementa = caracteristica.TermicaCalor_Incrementa,
                        TermicaCalor_Referida = caracteristica.TermicaCalor_Referida,
                        TermicaCalor_Irradiado = caracteristica.TermicaCalor_Irradiado,
                        TermicaCalor_Persistente = caracteristica.TermicaCalor_Persistente,
                        TermicaCalor_Decrece = caracteristica.TermicaCalor_Decrece,
                        Diagnostico_ManchaBlanca = caracteristica.Diagnostico_ManchaBlanca,
                        Diagnostico_Caries = caracteristica.Diagnostico_Caries,
                        Diagnostico_Traumatismo = caracteristica.Diagnostico_Traumatismo,
                        Diagnostico_Abfraccion = caracteristica.Diagnostico_Abfraccion,
                        Diagnostico_Atricion = caracteristica.Diagnostico_Atricion,
                        Diagnostico_Erosion = caracteristica.Diagnostico_Erosion,
                        Diagnostico_Restauracion = caracteristica.Diagnostico_Restauracion,
                        Diagnostico_Ajustada = caracteristica.Diagnostico_Ajustada,
                        Diagnostico_Desajustada = caracteristica.Diagnostico_Desajustada,
                        Diagnostico_PulpaSana = caracteristica.Diagnostico_PulpaSana,
                        Diagnostico_PulpitisReversible = caracteristica.Diagnostico_PulpitisReversible,
                        Diagnostico_PulpitisIrreversible = caracteristica.Diagnostico_PulpitisIrreversible,
                        Diagnostico_NecrosisPulpar = caracteristica.Diagnostico_NecrosisPulpar
                    };
                    listaCaracteristicas.Add(caracteristicaConsulta);
                }
            }
            return JsonSerializer.Serialize(new { Exitoso = true, Resultado = listaCaracteristicas });
        }
        [HttpPost]
        public string ConsultarSeguimientosNutricionalesPaciente(int pacienteId)
        {
            var listaSeguimientos = new List<SeguimientoNutricionalConsulta>();
            var seguimientosPaciente = _pacientesRepository.GetSeguimientosNutricionalesPaciente(pacienteId);
            if (seguimientosPaciente != null && seguimientosPaciente.Count > 0)
            {
                foreach (var seguimiento in seguimientosPaciente)
                {
                    var seguimientoConsulta = new SeguimientoNutricionalConsulta
                    {
                        Id = seguimiento.Id,
                        Fecha = seguimiento.Fecha,
                        Nuevo = false,
                        Peso = seguimiento.Peso,
                        IMC = seguimiento.IMC,
                        PGC = seguimiento.PGC,
                        Cuello = seguimiento.Cuello,
                        Busto = seguimiento.Busto,
                        CinturaAbdomen = seguimiento.CinturaAbdomen,
                        Cadera = seguimiento.Cadera,
                        Muslo = seguimiento.Muslo,
                        Brazo = seguimiento.Brazo,
                        Munneca = seguimiento.Muñeca
                    };

                    listaSeguimientos.Add(seguimientoConsulta);
                }
            }
            return JsonSerializer.Serialize(new { Exitoso = true, Resultado = listaSeguimientos });
        }
        [HttpPost]
        public string ConsultarServiciosAgregadosConsulta(int consultaId)
        {
            var listaServicios = new List<ServicioAgregadoConsulta>();

            var serviciosConsulta = _consultasRepository.GetServiciosAgregados(consultaId);
            foreach (var servicio in serviciosConsulta)
            {
                var servicioConsulta = new ServicioAgregadoConsulta
                {
                    Id = servicio.Id,
                    ConsultaId = servicio.ConsultaId,
                    ServicioId = servicio.ServicioId,
                    NombreServicio = servicio.Servicio.NombreServicio,
                    NumeroDiente = servicio.NumeroDiente,
                    Precio = (decimal)servicio.Precio
                };
                listaServicios.Add(servicioConsulta);
            }
            return JsonSerializer.Serialize(new { Exitoso = true, Resultado = listaServicios });
        }
        public IActionResult EditarConsulta(int? id)
        {
            if (id == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)id);
            if (consulta == null) return StatusCode(400);

            var model = new ConsultasViewModel();
            model.CitaId = consulta.CitasId;
            model.ConsultaId = consulta.Id;
            model.PacienteId = consulta.Citas.Paciente.Id;
            model.PacienteNombre = consulta.Citas.Paciente.Nombre;
            model.PacienteNit = consulta.Citas.Paciente.Nit;
            model.PacienteDireccion = consulta.Citas.Paciente.Direccion;
            model.PacienteAlias = consulta.Citas.Paciente.Alias;
            model.PacienteSexo = consulta.Citas.Paciente.sexoText;
            model.PacienteFechaNacimiento = consulta.Citas.Paciente.FechaNacimiento == null ? "" :
                ((DateTime)consulta.Citas.Paciente.FechaNacimiento).ToShortDateString();
            model.PacienteEdad = consulta.Citas.Paciente.Edad == null ? "" :
                ((int)consulta.Citas.Paciente.Edad).ToString();
            model.PacienteTelefono = consulta.Citas.Paciente.Telefono;
            model.PacienteCelular = consulta.Citas.Paciente.Celular;
            model.PacienteMedicos = consulta.Citas.Paciente.AntecedentesMedicos;
            model.PacienteQuirurgicos = consulta.Citas.Paciente.AntecedentesQuirurgicos;
            model.PacienteTraumaticos = consulta.Citas.Paciente.AntecedentesTraumaticos;
            model.PacienteAlergias = consulta.Citas.Paciente.AntecedentesAlergias;
            model.PacienteVicios = consulta.Citas.Paciente.AntecedentesVicios;
            model.PacienteMedicamentos = consulta.Citas.Paciente.AntecedentesMedicamentos;
            model.FechaYHoraInicio = consulta.FechaYHoraInicioConsulta;
            model.FechaProximaConsulta = consulta.FechaProximaConsulta;

            model.ObservacionesAdicionales = consulta.ObservacionesAdicionales;
            model.CostoConsulta = consulta.CostoConsulta;
            model.FaseTratamientoId = consulta.FaseTratamientoId;
            model.UrlFiles = consulta.UrlFiles;
            model.TipoConsulta = consulta.TipoConsulta;
            model.TipoReferencia = consulta.TipoReferencia;
            model.MedicoReferido = consulta.MedicoReferido;
            model.EstadoPagoId = consulta.EstadoPagoConsultaId;

            //Historia
            model.HistoriaId = consulta.HistoriaId;
            model.HistoriaProblema = consulta.Historia.HistoriaProblema;
            model.Sintomas = consulta.Historia.Sintomas;
            model.Diagnostico = consulta.Historia.Diagnostico;

            //Ginecologico
            model.ExamenGinecologico = consulta.ExamenGinecologico;

            //Neurologico
            model.ExamenNeurologico = consulta.ExamenNeurologico;

            //Examen fisico
            model.ExamenFisicoId = consulta.ExamenFisicoId;
            model.ExamenFisicoTemperatura = consulta.ExamenFisico.Temperatura;
            model.ExamenFisicoFrecuenciaRespiratoria = consulta.ExamenFisico.FrecuenciaRespiratoria;
            model.ExamenFisicoFrecuenciaCardiaca = consulta.ExamenFisico.FrecuenciaCardiaca;
            model.ExamenFisicoSaturacionOxigeno = consulta.ExamenFisico.SaturacionDeOxigeno;
            model.ExamenFisicoPresionArterialBrazoDerecho = consulta.ExamenFisico.PresionArterialBrazoDerecho;
            model.ExamenFisicoPresionArterialBrazoIzquierdo = consulta.ExamenFisico.PresionArterialBrazoIzquierdo;
            model.ExamenFisicoPeso = consulta.ExamenFisico.Peso;
            model.ExamenFisicoTalla = consulta.ExamenFisico.Talla;
            model.ExamenFisicoIMC = consulta.ExamenFisico.IMC;
            model.ExamenFisicoGlucosa = consulta.ExamenFisico.Glucosa;
            model.ExamenFisicoObservaciones = consulta.ExamenFisico.Observaciones;


            //Sección solo para mujeres
            model.EstaEmbarazada = consulta.EstaEmbarazada;
            model.NumeroSemanasEmbarazo = consulta.NumeroSemanasEmbarazo == null ? "" :
             ((int)consulta.NumeroSemanasEmbarazo).ToString();
            model.TomaPildorasAnticonceptivas = consulta.TomaPildorasAnticonceptivas;
            model.EstaAmamantando = consulta.EstaAmamantando;

            //Bebidas Alcoholicas
            model.BebeBebidasAlcoholicas = consulta.BebeBebidasAlcoholicas;
            model.AlcoholUltimas24Horas = consulta.AlcoholUltimas24Horas;
            model.AlcoholSemanal = consulta.AlcoholSemanal;

            //Dental
            model.FechaUltimaRadiografiaDental = consulta.FechaUltimaRadiografiaDental;

            //Estetico
            model.Metabolismo = consulta.Estetico_Metabolismo;
            model.Grasa = consulta.Estetico_Grasa;
            model.IMC = consulta.Estetico_IMC;
            model.Agua = consulta.Estetico_Agua;
            model.Obesidad = consulta.Estetico_Obesidad;
            model.ContornoBrazos = consulta.Estetico_ContornoBrazos;
            model.ContornoBusto = consulta.Estetico_ContornoBusto;
            model.ContornoAbdomen = consulta.Estetico_ContornoAbdomen;
            model.ContornoCadera = consulta.Estetico_ContornoCadera;
            model.ContornoPiernas = consulta.Estetico_ContornoPiernas;
            model.Estatura = consulta.Estetico_Estatura;

            //SIstemas
            model.SistemaCardiopulmonar = consulta.SistemaCardiopulmonar;
            model.SistemaOsteoarticular = consulta.SistemaOsteoarticular;
            model.SistemaHematologico = consulta.SistemaHematologico;

            //Area terapeutica
            model.TerapeuticoDatosGenerales = consulta.TerapeuticoDatosGenerales;
            model.TerapeuticoActividadesDiarias = consulta.TerapeuticoActividadesDiarias;
            model.TerapeuticoConQuienVive = consulta.TerapeuticoConQuienVive;
            model.TerapeuticoHabitosAlimenticios = consulta.TerapeuticoHabitosAlimenticios;
            model.TerapeuticoEjercicio = consulta.TerapeuticoEjercicio;
            model.TerapeuticoFinesSemana = consulta.TerapeuticoFinesSemana;
            model.TerapeuticoHistoriaMedica = consulta.TerapeuticoHistoriaMedica;
            model.TerapeuticoHistoriaPeso = consulta.TerapeuticoHistoriaPeso;

            ViewBag.ConsultaId = id;
            ViewBag.PacienteId = model.PacienteId;

            model.Init(_citasRepository, _serviciosRepository, _pacientesRepository);
            return View(model);
        }
        [HttpPost]
        public string EditarConsulta(ConsultasViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var consultaEditada = _consultasRepository.GetConsulta((int)model.ConsultaId);

                    consultaEditada.ObservacionesAdicionales = model.ObservacionesAdicionales;
                    consultaEditada.FechaYHoraInicioConsulta = (DateTime)model.FechaYHoraInicio;
                    consultaEditada.FechaProximaConsulta = model.FechaProximaConsulta ?? null;
                    consultaEditada.UrlFiles = model.UrlFiles;
                    consultaEditada.EstadoPagoConsultaId = (int)model.EstadoPagoId;
                    consultaEditada.TipoConsulta = model.TipoConsulta;
                    consultaEditada.TipoReferencia = model.TipoReferencia;
                    consultaEditada.MedicoReferido = model.MedicoReferido;
                    consultaEditada.CostoConsulta = (decimal)model.CostoConsulta;
                    consultaEditada.FaseTratamientoId = model.FaseTratamientoId;


                    //Historia
                    consultaEditada.Historia.HistoriaProblema = model.HistoriaProblema == null ? "--- Historia del problema ---" : model.HistoriaProblema;
                    consultaEditada.Historia.Sintomas = model.Sintomas == null ? "--- Sintomas ---" : model.Sintomas;
                    consultaEditada.Historia.Diagnostico = model.Diagnostico == null ? "--- Diagnostico ---" : model.Diagnostico;

                    //Examen físico
                    consultaEditada.ExamenFisico.Temperatura = model.ExamenFisicoTemperatura == null ?
                             "--- Temperatura ---" : model.ExamenFisicoTemperatura;
                    consultaEditada.ExamenFisico.FrecuenciaRespiratoria = model.ExamenFisicoFrecuenciaRespiratoria == null ?
                            "--- FrecuenciaRespiratoria ---" : model.ExamenFisicoFrecuenciaRespiratoria;
                    consultaEditada.ExamenFisico.FrecuenciaCardiaca = model.ExamenFisicoFrecuenciaCardiaca == null ?
                            "--- Frecuencia Cardiaca ---" : model.ExamenFisicoFrecuenciaCardiaca;
                    consultaEditada.ExamenFisico.SaturacionDeOxigeno = model.ExamenFisicoSaturacionOxigeno == null ?
                            "--- Saturacion De Oxigeno ---" : model.ExamenFisicoSaturacionOxigeno;
                    consultaEditada.ExamenFisico.PresionArterialBrazoDerecho = model.ExamenFisicoPresionArterialBrazoDerecho == null ?
                            "--- Presion Arterial Brazo Derecho ---" : model.ExamenFisicoPresionArterialBrazoDerecho;
                    consultaEditada.ExamenFisico.PresionArterialBrazoIzquierdo = model.ExamenFisicoPresionArterialBrazoIzquierdo == null ?
                            "--- Presion Arterial Brazo Derecho ---" : model.ExamenFisicoPresionArterialBrazoIzquierdo;
                    consultaEditada.ExamenFisico.Observaciones = model.ExamenFisicoObservaciones == null ?
                            "--- Observaciones o texto adicional ---" : model.ExamenFisicoObservaciones;
                    consultaEditada.ExamenFisico.Peso = model.ExamenFisicoPeso == null ?
                            "--- Peso ---" : model.ExamenFisicoPeso;
                    consultaEditada.ExamenFisico.Talla = model.ExamenFisicoTalla == null ?
                            "--- Talla ---" : model.ExamenFisicoTalla;
                    consultaEditada.ExamenFisico.Glucosa = model.ExamenFisicoGlucosa == null ?
                            "--- Glucosa ---" : model.ExamenFisicoGlucosa;
                    consultaEditada.ExamenFisico.IMC = model.ExamenFisicoIMC == null ?
                            "--- Glucosa ---" : model.ExamenFisicoIMC;


                    //Estetico
                    consultaEditada.Estetico_Metabolismo = model.Metabolismo;
                    consultaEditada.Estetico_Grasa = model.Grasa;
                    consultaEditada.Estetico_Agua = model.Agua;
                    consultaEditada.Estetico_IMC = model.IMC;
                    consultaEditada.Estetico_Obesidad = model.Obesidad;
                    consultaEditada.Estetico_ContornoBrazos = model.ContornoBrazos;
                    consultaEditada.Estetico_ContornoBusto = model.ContornoBusto;
                    consultaEditada.Estetico_ContornoAbdomen = model.ContornoAbdomen;
                    consultaEditada.Estetico_ContornoCadera = model.ContornoCadera;
                    consultaEditada.Estetico_ContornoPiernas = model.ContornoPiernas;
                    consultaEditada.Estetico_Estatura = model.Estatura;

                    //Sección solo para mujeres
                    consultaEditada.EstaEmbarazada = model.EstaEmbarazada;
                    var numeroSemanasEmbarazo = 0;
                    try { numeroSemanasEmbarazo = Convert.ToInt32(model.NumeroSemanasEmbarazo); } catch { numeroSemanasEmbarazo = 0; }
                    consultaEditada.NumeroSemanasEmbarazo = numeroSemanasEmbarazo;
                    consultaEditada.TomaPildorasAnticonceptivas = model.TomaPildorasAnticonceptivas;
                    consultaEditada.EstaAmamantando = model.EstaAmamantando;


                    //Bebidas Alcoholicas
                    consultaEditada.BebeBebidasAlcoholicas = model.BebeBebidasAlcoholicas;
                    consultaEditada.AlcoholUltimas24Horas = model.AlcoholUltimas24Horas;
                    consultaEditada.AlcoholSemanal = model.AlcoholSemanal;

                    //Dental
                    consultaEditada.FechaUltimaRadiografiaDental = model.FechaUltimaRadiografiaDental;

                    //Neurologico
                    consultaEditada.ExamenNeurologico = model.ExamenNeurologico;

                    //Ginecologico
                    consultaEditada.ExamenGinecologico = model.ExamenGinecologico;

                    //Sistemas
                    consultaEditada.SistemaCardiopulmonar = model.SistemaCardiopulmonar;
                    consultaEditada.SistemaOsteoarticular = model.SistemaOsteoarticular;
                    consultaEditada.SistemaHematologico = model.SistemaHematologico;

                    //Area terapeutica
                    consultaEditada.TerapeuticoDatosGenerales = model.TerapeuticoDatosGenerales;
                    consultaEditada.TerapeuticoActividadesDiarias = model.TerapeuticoActividadesDiarias;
                    consultaEditada.TerapeuticoConQuienVive = model.TerapeuticoConQuienVive;
                    consultaEditada.TerapeuticoHabitosAlimenticios = model.TerapeuticoHabitosAlimenticios;
                    consultaEditada.TerapeuticoEjercicio = model.TerapeuticoEjercicio;
                    consultaEditada.TerapeuticoFinesSemana = model.TerapeuticoFinesSemana;
                    consultaEditada.TerapeuticoHistoriaMedica = model.TerapeuticoHistoriaMedica;
                    consultaEditada.TerapeuticoHistoriaPeso = model.TerapeuticoHistoriaPeso;

                    //Servicios agregados consulta
                    var servicios = new List<ConsultaServicio>();
                    if (model.ServiciosAgregados != null
                     && model.ServiciosAgregados.Count > 0)
                    {
                        foreach (var servicioAg in model.ServiciosAgregados)
                        {
                            servicios.Add(new ConsultaServicio
                            {
                                ConsultaId = (int)servicioAg.ConsultaId,
                                ServicioId = (int)servicioAg.ServicioId,
                                NumeroDiente = servicioAg.NumeroDiente,
                                Precio = servicioAg.Precio
                            });
                        }
                    }
                    consultaEditada.ConsultasServicios = servicios;


                    //Caracteristicas dentales
                    var caracteristicas = new List<ConsultaCaracteristicaDental>();
                    foreach (var caracteristica in model.CaracteristicasDientes)
                    {
                        caracteristicas.Add(new ConsultaCaracteristicaDental
                        {
                            NumeroDiente = caracteristica.NumeroDiente,
                            Percusiones_VerticalMas = caracteristica.Percusiones_VerticalMas,
                            Percusiones_HorizontalMas = caracteristica.Percusiones_HorizontalMas,
                            Percusiones_VerticalMenos = caracteristica.Percusiones_VerticalMenos,
                            Percusiones_HorizontalMenos = caracteristica.Percusiones_HorizontalMenos,
                            Dolor_Localizado = caracteristica.Dolor_Localizado,
                            Dolor_Fugaz = caracteristica.Dolor_Fugaz,
                            Dolor_Persistente = caracteristica.Dolor_Persistente,
                            Dolor_Referido = caracteristica.Dolor_Referido,
                            Dolor_Espontaneo = caracteristica.Dolor_Espontaneo,
                            Estimulo_Frio = caracteristica.Estimulo_Frio,
                            Estimulo_Calor = caracteristica.Estimulo_Calor,
                            Estimulo_DulceAcido = caracteristica.Estimulo_DulceAcido,
                            Estimulo_Masticacion = caracteristica.Estimulo_Masticacion,
                            Estimulo_Otro = caracteristica.Estimulo_Otro,
                            TermicaFrio_Positiva = caracteristica.TermicaFrio_Positiva,
                            TermicaFrio_Negativa = caracteristica.TermicaFrio_Negativa,
                            TermicaFrio_Localizada = caracteristica.TermicaFrio_Localizada,
                            TermicaFrio_Fugaz = caracteristica.TermicaFrio_Fugaz,
                            TermicaFrio_Incrementa = caracteristica.TermicaFrio_Incrementa,
                            TermicaFrio_Referida = caracteristica.TermicaFrio_Referida,
                            TermicaFrio_Irradiado = caracteristica.TermicaFrio_Irradiado,
                            TermicaFrio_Persistente = caracteristica.TermicaFrio_Persistente,
                            TermicaFrio_Decrece = caracteristica.TermicaFrio_Decrece,
                            TermicaCalor_Positiva = caracteristica.TermicaCalor_Positiva,
                            TermicaCalor_Negativa = caracteristica.TermicaCalor_Negativa,
                            TermicaCalor_Localizada = caracteristica.TermicaCalor_Localizada,
                            TermicaCalor_Fugaz = caracteristica.TermicaCalor_Fugaz,
                            TermicaCalor_Incrementa = caracteristica.TermicaCalor_Incrementa,
                            TermicaCalor_Referida = caracteristica.TermicaCalor_Referida,
                            TermicaCalor_Irradiado = caracteristica.TermicaCalor_Irradiado,
                            TermicaCalor_Persistente = caracteristica.TermicaCalor_Persistente,
                            TermicaCalor_Decrece = caracteristica.TermicaCalor_Decrece,
                            Diagnostico_ManchaBlanca = caracteristica.Diagnostico_ManchaBlanca,
                            Diagnostico_Caries = caracteristica.Diagnostico_Caries,
                            Diagnostico_Traumatismo = caracteristica.Diagnostico_Traumatismo,
                            Diagnostico_Abfraccion = caracteristica.Diagnostico_Abfraccion,
                            Diagnostico_Atricion = caracteristica.Diagnostico_Atricion,
                            Diagnostico_Erosion = caracteristica.Diagnostico_Erosion,
                            Diagnostico_Restauracion = caracteristica.Diagnostico_Restauracion,
                            Diagnostico_Ajustada = caracteristica.Diagnostico_Ajustada,
                            Diagnostico_Desajustada = caracteristica.Diagnostico_Desajustada,
                            Diagnostico_PulpaSana = caracteristica.Diagnostico_PulpaSana,
                            Diagnostico_PulpitisReversible = caracteristica.Diagnostico_PulpitisReversible,
                            Diagnostico_PulpitisIrreversible = caracteristica.Diagnostico_PulpitisIrreversible,
                            Diagnostico_NecrosisPulpar = caracteristica.Diagnostico_NecrosisPulpar
                        });
                    }
                    consultaEditada.ConsultasCaracteristicasDentales = caracteristicas;


                    //Seguimientos nutricionales
                    if (model.SeguimientosNutricionales != null
                     && model.SeguimientosNutricionales.Count > 0)
                    {
                        foreach (var seguimiento in model.SeguimientosNutricionales)
                        {
                            var seguimientoConsulta = new PacienteSeguimientoNutricional
                            {
                                PacienteId = model.PacienteId,
                                Fecha = seguimiento.Fecha,
                                Peso = seguimiento.Peso,
                                IMC = seguimiento.IMC,
                                PGC = seguimiento.PGC,
                                Cuello = seguimiento.Cuello,
                                Busto = seguimiento.Busto,
                                CinturaAbdomen = seguimiento.CinturaAbdomen,
                                Cadera = seguimiento.Cadera,
                                Muslo = seguimiento.Muslo,
                                Brazo = seguimiento.Brazo,
                                Muñeca = seguimiento.Munneca,
                            };
                            if (seguimiento.Id != null)
                            {
                                seguimientoConsulta.Id = (int)seguimiento.Id;
                            }
                            if (seguimientoConsulta.Id == 0)
                            {
                                _pacientesRepository.AddSeguimientoNutricional(seguimientoConsulta);
                            }
                            else
                            {
                                _pacientesRepository.UpdateSeguimientoNutricional(seguimientoConsulta);
                            }
                        }
                    }


                    //Vacunas paciente
                    foreach (var vacuna in model.VacunasPaciente)
                    {
                        var vacunaPaciente = new VacunaPaciente
                        {
                            Id = vacuna.VacunaPacienteId,
                            PacienteId = (int)model.PacienteId,
                            VacunaId = (int)vacuna.VacunaId,
                            Primera = (bool)vacuna.Primera,
                            FechaPrimera = vacuna.FechaPrimera,
                            Segunda = (bool)vacuna.Segunda,
                            FechaSegunda = vacuna.FechaSegunda,
                            Tercera = (bool)vacuna.Tercera,
                            FechaTercera = vacuna.FechaTercera,
                            PrimerRefuerzo = (bool)vacuna.PrimerRefuerzo,
                            FechaPrimerRefuerzo = vacuna.FechaPrimerRefuerzo,
                            SegundoRefuerzo = (bool)vacuna.SegundoRefuerzo,
                            FechaSegundoRefuerzo = vacuna.FechaSegundoRefuerzo
                        };
                        _pacientesRepository.UpdateVacuna(vacunaPaciente);
                    }


                    _consultasRepository.Update(consultaEditada);
                    TempData["Message"] = "¡La consulta se ha guardado con éxito.!";
                    return JsonSerializer.Serialize(new { Exitoso = true, ConsultaId = consultaEditada.Id });
                }
                catch (Exception ex)
                {
                    return JsonSerializer.Serialize(new { Exitoso = false, Mensaje = "Error al editar consulta. " + ex.Message });
                }
            }

            return JsonSerializer.Serialize(new { Exitoso = false, Mensaje = "Asegúrese de diligenciar los campos obligatorios" });
        }

        public IActionResult CrearExamenFisico(int? consultaId)
        {
            if (consultaId == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)consultaId);
            if (consulta == null) return StatusCode(400);

            var examenFisico = new ExamenFisico()
            {
                Temperatura = "--- Temperatura ---",
                FrecuenciaRespiratoria = "--- FrecuenciaRespiratoria ---",
                FrecuenciaCardiaca = "--- Frecuencia Cardiaca ---",
                SaturacionDeOxigeno = "--- Saturacion De Oxigeno ---",
                PresionArterialBrazoDerecho = "--- Presion Arterial Brazo Derecho ---",
                PresionArterialBrazoIzquierdo = "--- Presion Arterial Brazo Izquierdo ---",
                Observaciones = "--- Observaciones o texto adicional ---",
            };

            consulta.ExamenFisico = examenFisico;
            _consultasRepository.Update(consulta);

            return RedirectToAction("Informacion", new { id = consulta.Id });
        }

        [HttpPost]
        public JsonResult GuardarPrescripcion([FromBody] ViewPrescriptionModel model)
        {
            Prescripcion prescripcion = new Prescripcion()
            {
                ConsultaId = model.ConsultaId,
                NextDate = model.NextDate,
            };

            _consultasRepository.AddPrescipcion(prescripcion);

            foreach (var item in model.Prescriptions)
            {
                DetallePrescripcion detallePrescripcion = new DetallePrescripcion()
                {
                    Item = item.Item,
                    Medicine = item.Medicine,
                    Qty = item.Qty,
                    Indications = item.Indications,
                    PrescripcionId = prescripcion.Id
                };
                _consultasRepository.AddDetallePrescipcion(detallePrescripcion);
            }


            return Json(prescripcion.Id);
            /*
            return new ViewAsPdf("Views/Consultas/Prescripcion.cshtml",model){
                PageMargins = new Margins(5,5,5,5),
                PageOrientation = Orientation.Portrait,
                PageSize = Size.Letter,
                PageHeight = 150,
                PageWidth = 100
            };*/
        }

        public ActionResult Prescripcion(int prescripcionId)
        {
            _consultasRepository.UpdateTablePrescription();
            var prescripcion = _consultasRepository.GetPrescripcion(prescripcionId);

            ViewPrescriptionModel model = new ViewPrescriptionModel()
            {
                Nombre = prescripcion.Consulta.Citas.Paciente.Nombre,
                Edad = prescripcion.Consulta.Citas.Paciente.Edad == null ? 0 :
                    (int)prescripcion.Consulta.Citas.Paciente.Edad,
                Direccion = prescripcion.Consulta.Citas.Paciente.Direccion,
                NextDate = prescripcion.NextDate,
                Prescriptions = prescripcion.DetallePrescripcion
            };

            /* ViewPrescriptionModel model = new ViewPrescriptionModel(){
                Nombre =" Hever Polanco ",
                Edad = 24,
                Direccion = "Guatemala",
                NextDate = DateTime.Now.AddDays(3),
                Prescriptions = prescripcion.DetallePrescripcion
            }; */
            string footer = "--footer-center \"Próxima Cita: " + model.NextDate.ToString("dd/MM/yyyy") + "  \"" +
                                         " --footer-line --footer-font-size \"12\" --footer-spacing 2 --footer-font-name \"calibri light\"";

            return new ViewAsPdf("Views/Consultas/Prescripcion.cshtml", model)
            {
                PageOrientation = Orientation.Portrait,
                PageSize = Size.Letter,
                CustomSwitches = footer
            };
        }
        public IActionResult GenerarVenta(int id)
        {
            return RedirectToAction("NuevaVentaClinica", "Venta", new { idConsulta = id });
        }
    }
}