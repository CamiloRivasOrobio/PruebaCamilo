using System.ComponentModel.Design;
using System.IO.MemoryMappedFiles;
using System.Linq.Expressions;
using System.Reflection;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using sistema.Models;
using Database.Shared.IRepository;
using Database.Shared.Models;
using Microsoft.AspNetCore.Http;
using sistema.Json;
using Wkhtmltopdf.NetCore;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Rotativa.AspNetCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using Database.Shared.Enumeraciones;

namespace sistema.Controllers
{
    public class CuentasPorCobrarController : Controller
    {
        private readonly ICuentasPorCobrar _cuentasPorCobrarRepository = null;
        private readonly ICajaClinica _cajaClinicaRepository = null;
        private readonly IPacientes _pacientesRepository = null;
        private readonly IEnvio _envioRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly UserManager<User> _userManager = null;

        public CuentasPorCobrarController(ICuentasPorCobrar cuentasPorCobrarRepository
            , ICajaClinica cajaClinicaRepository, IPacientes pacientesRepository
            , IEnvio envioRepository, IEmpleado empleadoRepository, UserManager<User> userManager)
        {
            _cuentasPorCobrarRepository = cuentasPorCobrarRepository;
            _cajaClinicaRepository = cajaClinicaRepository;
            _pacientesRepository = pacientesRepository;
            _envioRepository = envioRepository;
            _empleadoRepository = empleadoRepository;
            _userManager = userManager;
        }

        public IActionResult Pendientes()
        {
            return View();
        }
        public IActionResult Pagadas()
        {
            return View();
        }
        public IActionResult VerDetallesCuenta(int? cuentaId)
        {
            if (cuentaId == null)
                return RedirectToAction("Pendientes");
            var cuenta = _cuentasPorCobrarRepository.Get((int)cuentaId);
            if (cuenta == null)
                return RedirectToAction("Pendientes");

            return View(cuenta);
        }
        public async Task<IActionResult> Pagar(int? cuentaId)
        {
            if (cuentaId == null)
                return RedirectToAction("Pendientes");
            var cuenta = _cuentasPorCobrarRepository.Get((int)cuentaId);
            if (cuenta == null)
                return RedirectToAction("Pendientes");

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var empleadoId = user.EmpleadoId;

            var model = new CuentasPorCobrarPagarViewModel
            {
                //Datos de factura
                EmpleadoId = (int)empleadoId,

                //Datos de cuenta
                CuentaId = cuenta.Id,
                Valor = cuenta.Valor ?? 0,
                Observaciones = cuenta.Observaciones,

                //Datos del paciente
                PacienteId = cuenta.Paciente.Id,
                PacienteNit = cuenta.Paciente.Nit,
                PacienteNombre = cuenta.Paciente.Nombre,
                PacienteDireccion = cuenta.Paciente.Direccion
            };
            model.Init(_cuentasPorCobrarRepository);
            return View(model);
        }
        [HttpPost]
        public JsonResult Pagar(CuentasPorCobrarPagarViewModel model)
        {
            try
            {
                var cajaClinica = _cajaClinicaRepository.ListarCajas();
                if (!cajaClinica.Any(a => a.EstadoCaja == true))
                {
                    return Json(new { Exitoso = false, Message = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!" });
                }

                var paciente = _pacientesRepository.Get(model.PacienteId);
                var cajaAbierta = _cajaClinicaRepository.GetCajaAbierta();

                var empleado = _empleadoRepository.Get(model.EmpleadoId);

                if (empleado == null)
                {
                    return Json(new { Exitoso = false, Message = "¡Codigo de empleado incorrecto.!" });
                }

                var nuevaVenta = new Venta()
                {
                    NoComprobante = model.NoComprobante,
                    Nombres = model.PacienteNombre,
                    Nit = model.PacienteNit,
                    Direccion = model.PacienteDireccion,
                    PacienteId = model.PacienteId,
                    FechaVenta = DateTime.Now,
                    EmpleadoId = model.EmpleadoId,
                    TipoVenta = "clinica",
                    MontoPago = model.Valor,
                    CuentaPorCobrarId = model.CuentaId
                };

                var pago = new Pagos()
                {
                    Venta = nuevaVenta,
                    FormaPagoId = Convert.ToInt32(model.FormaPagoId),
                    Monto = Convert.ToDecimal(model.Valor),
                    MonedaId = model.MonedaId
                };

                _envioRepository.AddPago(pago, false);

                var nuevoDetalleCaja = new DetalleCajaClinica()
                {
                    Venta = nuevaVenta,
                    Descripcion = "Pago de cuenta por cobrar. Cliente: " + model.PacienteNombre,
                    Ingreso = model.Valor,
                    CajaClinica = cajaAbierta
                };

                _cajaClinicaRepository.Add(nuevoDetalleCaja, false);

                var cuenta = _cuentasPorCobrarRepository.Get(model.CuentaId);
                cuenta.Pagada = true;
                cuenta.FechaPagoRealizado = nuevaVenta.FechaVenta;
                _cuentasPorCobrarRepository.Update(cuenta);

                //Generar nueva cuenta para pagar un mes después
                decimal valorCuentaNueva = 0;
                if ((bool)paciente.TieneMembresia && !paciente.Retirado)
                {
                    valorCuentaNueva = (decimal)ValorMembresiaEnum.Membresia;
                }
                else
                {
                    var faseTratamientoActual = _pacientesRepository.GetFaseTratamientoActual(model.PacienteId);
                    if (faseTratamientoActual != null)
                    {
                        valorCuentaNueva = faseTratamientoActual.FaseTratamiento.Valor;
                        var nuevaCuenta = new CuentaPorCobrar
                        {
                            FechaLimitePago = DateTime.Today.AddMonths(1),
                            PacienteId = model.PacienteId,
                            Valor = valorCuentaNueva,
                            Pagada = false,
                            Eliminada = false
                        };
                        _cuentasPorCobrarRepository.Add(nuevaCuenta);
                    }
                }

                TempData["Message"] = "El pago de la cuenta ha sido registrado";
                return Json(new
                {
                    Exitoso = true
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Exitoso = false,
                    Mensaje = "Error al registrar el pago. " + ex.Message
                });
            }
        }
        [HttpPost]
        public JsonResult ConsultarCuentasPorCobrar()
        {
            try
            {
                var resultado = _cuentasPorCobrarRepository.GetList().Where(c => !c.Pagada).ToList();
                return Json(new
                {
                    Exitoso = true,
                    Resultado = resultado
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar cuentas por cobrar. " + ex.Message
                });
            }
        }
        public IActionResult Modificar(int cuentaId)
        {
            var cuenta = _cuentasPorCobrarRepository.Get(cuentaId);
            var model = new CuentasPorCobrarModificarViewModel();
            model.CuentaId = cuenta.Id;
            model.Valor = (decimal)cuenta.Valor;
            model.Observaciones = cuenta.Observaciones;
            return View(model);
        }
        [HttpPost]
        public JsonResult Modificar(CuentasPorCobrarModificarViewModel model)
        {
            try
            {
                var cuenta = _cuentasPorCobrarRepository.Get(model.CuentaId);
                cuenta.Valor = model.Valor;
                cuenta.Observaciones = model.Observaciones;
                _cuentasPorCobrarRepository.Update(cuenta);
                TempData["Message"] = "¡Se ha modificado la cuenta por cobrar!";
                return Json(new
                {
                    Exitoso = true
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Exitoso = false,
                    Mensaje = "Error al modificar cuenta. " + ex.Message
                });
            }
        }

        [HttpPost]
        public JsonResult ConsultarCuentasPagadas()
        {
            try
            {
                var resultado = _cuentasPorCobrarRepository.GetList().Where(c => c.Pagada).ToList();
                return Json(new
                {
                    Exitoso = true,
                    Resultado = resultado
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar cuentas pagadas. " + ex.Message
                });
            }
        }

    }
}

