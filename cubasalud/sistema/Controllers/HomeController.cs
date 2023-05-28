using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using farmamest.Models;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Database.Shared.Models;
using Wkhtmltopdf.NetCore;
using Microsoft.AspNetCore.Authorization;
using Database.Shared.Enumeraciones;
using sistema.Models;

namespace sistema.Controllers

{

    [Authorize(Roles = "Administrador, Supervisor, Vendedor, Mensajero")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPacientes _pacientesRepository = null;
        private readonly IConsultas _consultasRepository = null;


        public HomeController(ILogger<HomeController> logger, IPacientes pacientesRepository
            , IConsultas consultasRepository)//, IGeneratePdf generatePdf)
        {
            _logger = logger;
            _pacientesRepository = pacientesRepository;
            _consultasRepository = consultasRepository;
            // _generatePdf = generatePdf;

        }
        public IActionResult Index()
        {

            return View();
            // return await _generatePdf.GetPdf("Views/Home/Index.cshtml", "Hello World");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public JsonResult ConsultarPacientesCumpleannios()
        {
            try
            {
                var pacientes = _pacientesRepository.GetList().Where(p => p.FechaNacimiento != null
                    && Convert.ToDateTime(p.FechaNacimiento).Month >= DateTime.Today.Month).ToList();

                var pacientesCumpleannios = new List<Paciente>();

                if (pacientes != null && pacientes.Count > 0)
                {
                    foreach (var paciente in pacientes)
                    {
                        if (Convert.ToDateTime(paciente.FechaNacimiento).Month >
                            DateTime.Today.Month)
                        {
                            pacientesCumpleannios.Add(paciente);
                        }
                        else
                        {
                            if (Convert.ToDateTime(paciente.FechaNacimiento).Day >=
                                DateTime.Today.Day)
                            {
                                pacientesCumpleannios.Add(paciente);
                            }
                        }
                    }
                }

                return Json(new { Exitoso = true, Resultado = pacientesCumpleannios });
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar cumpleaños de pacientes" + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult ConsultarPacientesAplicablesMembresia()
        {
            try
            {
                var consultas = _consultasRepository.ListaConsultas()
                    .Where(c => c.FaseTratamientoId == (int)FaseTratamientoEnum.Mantenimiento1
                        && (DateTime.Today - c.FechaYHoraInicioConsulta).TotalDays >= 365)
                    .ToList();
                var pacientes = new List<Paciente>();

                foreach (var consulta in consultas)
                {
                    pacientes.Add(consulta.Citas.Paciente);
                }

                var pacientesAplicables = pacientes.Distinct().ToList();

                return Json(new { Exitoso = true, Resultado = pacientesAplicables });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar pacientes aplicables para membresía. "
                    + ex.Message
                });
            }
        }
        [HttpPost]
        public JsonResult ConsultarPacientesRetiradosContactar()
        {
            try
            {
                var pacientesContactar = new List<HomePacientesContactarViewModel>();
                var pacientesRetirados = _pacientesRepository.GetList()
                    .Where(p => p.EstadoPacienteId == (int)EstadoPacienteEnum.Inactivo)
                    .ToList();
                foreach (var paciente in pacientesRetirados)
                {
                    var historial = _pacientesRepository.GetHistorial(paciente.Id)
                        .OrderByDescending(h => h.Fecha)
                        .FirstOrDefault();
                    if (historial.AccionPacienteId == (int)AccionPacienteEnum.Retiro
                        && (bool)historial.VolverAContactar)
                    {
                        var fechaRetiro = historial.Fecha == null ? "" :
                                Convert.ToDateTime(historial.Fecha).ToString("yyyy/MM/dd");
                        var fechaContacto = historial.FechaContacto == null ? "" :
                                Convert.ToDateTime(historial.FechaContacto).ToString("yyyy/MM/dd");
                        pacientesContactar.Add(new HomePacientesContactarViewModel
                        {
                            PacienteId = paciente.Id,
                            PacienteNombre = paciente.Nombre,
                            FechaRetiro = fechaRetiro,
                            FechaContacto = fechaContacto
                        });
                    }
                }

                return Json(new { Exitoso = true, Resultado = pacientesContactar });
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar pacientes por contactar. " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult ConsultarPacientesAniversario()
        {
            try
            {
                var pacientesAniversario = new List<HomePacientesAniversarioViewModel>();
                var fasesTratamiento = _pacientesRepository.GetFasesTratamientoPacientes()
                    .Where(f => f.FechaInicioFase.Date == DateTime.Today.AddYears(-1).Date);

                foreach (var fase in fasesTratamiento)
                {
                    pacientesAniversario.Add(new HomePacientesAniversarioViewModel
                    {
                        PacienteId = fase.Paciente.Id,
                        PacienteNombre = fase.Paciente.Nombre,
                        FaseNombre = fase.FaseTratamiento.NombreFase,
                        FaseFechaInicio = fase.FechaInicioFase.ToString("yyyy/MM/dd")
                    });
                }
                return Json(new { Exitoso = true, Resultado = pacientesAniversario });
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar aniversario de pacientes. " + ex.Message });
            }
        }
    }
}