using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Database.Shared;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using sistema.Models;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Database.Shared.Models;
using System.Web;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using sistema.Json;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using Database.Shared.Enumeraciones;

namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
    public class ServicioController : Controller
    {
        private readonly IServicio _servicioRepository = null;
        private readonly IProducto _productosRepository = null;


        // private string _dir;

        public ServicioController(IServicio servicioRepository, IProducto productosRepository)
        {
            _servicioRepository = servicioRepository;
            _productosRepository = productosRepository;
        }

        public IActionResult Lista()
        {
            var lista = _servicioRepository.GetListaServicios().ToList();

            return View(lista);
        }
        [HttpPost]
        public JsonResult ConsultarInsumosExistentes()
        {
            try
            {
                var tipoBodega = (int)TipoBodegaEnum.Clinica;
                var tipoProducto = (int)TipoProductoEnum.InsumosMedicos;
                var resultado = _productosRepository.GetProductos(tipoBodega, tipoProducto)
                .ToList();

                return Json(new { Exitoso = true, Resultado = resultado });
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar insumos. " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult ConsultarUnidadesVentaInsumo(int productoId)
        {
            try
            {
                var tipoBodega = (int)TipoBodegaEnum.Clinica;
                var tipoProducto = (int)TipoProductoEnum.InsumosMedicos;
                var producto = _productosRepository.GetProductos(tipoBodega, tipoProducto)
                    .Where(p => p.Id == productoId)
                    .FirstOrDefault();

                return Json(new { Exitoso = true, Resultado = producto.ProductoEquivalencias });
            }
            catch (Exception ex)
            {
                return Json(new { Exitoso = false, Mensaje = "Error al consultar unidades de venta. " + ex.Message });
            }
        }
        public IActionResult Nuevo()
        {
            // var cargarCategorias = _categoryRepository.ListarCategorias();
            var modelo = new ServicioBaseViewModel();
            return View(modelo);
        }

        [HttpPost]
        public string Nuevo(ServicioBaseViewModel model)
        {
            try
            {
                var servicio = new Servicio
                {
                    NombreServicio = model.NombreServicio,
                    Precio = model.Precio,
                    Precio_2 = model.Precio_2,
                    Precio_3 = model.Precio_3,
                    Precio_4 = model.Precio_4,
                    Descripcion = model.Descripcion
                };

                if (model.InsumosUtilizados != null && model.InsumosUtilizados.Count > 0)
                {
                    foreach (var insumo in model.InsumosUtilizados)
                    {
                        var insumoServicio = new ServicioInsumo
                        {
                            ProductoId = insumo.ProductoId,
                            UnidadMedidaVentaId = insumo.UnidadMedidaVentaId,
                            CantidadUtilizada = insumo.CantidadUtilizada
                        };
                        servicio.ServiciosInsumos.Add(insumoServicio);
                    }
                }

                _servicioRepository.Add(servicio);
                TempData["Message"] = "¡El servicio se ha guardado con exito.!";

                return JsonSerializer.Serialize(new { Exitoso = true, ServicioId = servicio.Id });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new { Exitoso = false, Mensaje = "Error al guardar servicio. " + ex.Message });
            }
        }

        public IActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var servicio = _servicioRepository.Get((int)id);

            if (servicio == null)
            {
                return StatusCode(404);
            }

            var modelo = new ServicioBaseViewModel
            {
                Id = servicio.Id,
                NombreServicio = servicio.NombreServicio,
                Precio = servicio.Precio,
                Precio_2 = servicio.Precio_2,
                Precio_3 = servicio.Precio_3,
                Precio_4 = servicio.Precio_4,
                Descripcion = servicio.Descripcion
            };

            return View(modelo);
        }

        [HttpPost]
        public string Modificar(ServicioBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var servicio = _servicioRepository.Get((int)model.Id);

                servicio.NombreServicio = model.NombreServicio;
                servicio.Precio = model.Precio;
                servicio.Precio_2 = model.Precio_2;
                servicio.Precio_3 = model.Precio_3;
                servicio.Precio_4 = model.Precio_4;
                servicio.Descripcion = model.Descripcion;

                _servicioRepository.Update(servicio);
                TempData["Message"] = "¡El servicio se ha modificado con exito.!";
                return JsonSerializer.Serialize(new { Exitoso = true });
            }

            return JsonSerializer.Serialize(new { Exitoso = false, Mensaje = "Asegúrese de diligenciar los campos obligatorios" });
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _servicioRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;

            _servicioRepository.Update(model);
            TempData["Message"] = "¡El Servicio se ha eliminado con exito.!";

            return RedirectToAction("Lista");
        }

        public JsonResult RetornarServicios(string id)
        {
            var servicioBuscado = _servicioRepository.Get(Convert.ToInt16(id));

            if (servicioBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }

            var objetos = new { id = servicioBuscado.Id, nombreServicio = servicioBuscado.NombreServicio, precio = servicioBuscado.Precio };

            return Json(objetos);
        }

        public JsonResult RetornarServiciosPorNombre(string nombre)
        {
            var servicioBuscado = _servicioRepository.GetNombre(nombre);

            if (servicioBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }

            return Json(servicioBuscado);
        }

    }
}