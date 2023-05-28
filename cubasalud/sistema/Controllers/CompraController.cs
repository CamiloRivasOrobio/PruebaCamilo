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
using sistema.Json;
using System.Net;
using Database.Shared.Paginacion;
using Microsoft.AspNetCore.Authorization;
using Wkhtmltopdf.NetCore;
using System.Text.Json;

namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Supervisor")]
    public class CompraController : Controller
    {


        private readonly ICompra _compraRepository = null;
        private readonly IProveedor _proveedorRepository = null;
        private readonly IProducto _productoRepository = null;
        private readonly ICaja _cajaRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly IGeneratePdf _generatePdf = null;
        private readonly IDespegablesProducto _categoriaRepository = null;

        public CompraController(ICompra compraRepository, IProveedor proveedorRepository, IProducto productoRepository,
            ICaja cajaRepository, IEmpleado empleadoRepository, IGeneratePdf generatepdf, IDespegablesProducto categoriaRepository)
        {
            _compraRepository = compraRepository;
            _proveedorRepository = proveedorRepository;
            _productoRepository = productoRepository;
            _cajaRepository = cajaRepository;
            _empleadoRepository = empleadoRepository;
            _generatePdf = generatepdf;
            _categoriaRepository = categoriaRepository;
        }

        // public IActionResult Lista()
        // {
        //     var lista = _compraRepository.GetList();
        //     return View(lista);
        // }

        public IActionResult Nuevo()
        {
            var modelo = new CompraBaseViewModel();
            modelo.Init(_proveedorRepository, _compraRepository);
            modelo.EncabezadoFechaLimite = DateTime.Now;

            return View(modelo);
        }
        [HttpPost]
        public string ConsultarProductosRegistrados(int? laboratorioId)
        {
            try
            {
                var listaProductosRegistrados = new List<object>();
                var productos = new List<Producto>();
                if (laboratorioId == null)
                    productos = (List<Producto>)_productoRepository.GetProductos();
                else
                    productos = (List<Producto>)_productoRepository.GetProductosLaboratorio((int)laboratorioId);

                foreach (var producto in productos)
                {
                    var productoRegistrado = new
                    {
                        Id = producto.Id,
                        NombreProducto = producto.NombreProducto
                    };
                    listaProductosRegistrados.Add(productoRegistrado);
                }

                return JsonSerializer.Serialize(new
                {
                    Exitoso = true,
                    ProductosRegistrados = listaProductosRegistrados
                });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar productos. " + ex.Message
                });
            }
        }
        [HttpPost]
        public string ConsultarUnidadesCompraProducto(int productoId)
        {
            try
            {
                var listaUnidades = new List<object>();
                var equivalencias = _productoRepository.GetEquivalenciasProducto(productoId);
                foreach (var equivalencia in equivalencias)
                {
                    var unidadBd = new UnidadMedidaCompraViewModel
                    {
                        Id = (int)equivalencia.UnidadMedidaCompraId,
                        NombreUnidad = equivalencia.UnidadMedidaCompra.Nombre,
                        Abreviatura = equivalencia.UnidadMedidaCompra.Abreviatura
                    };
                    listaUnidades.Add(unidadBd);
                }

                return JsonSerializer.Serialize(new
                {
                    Exitoso = true,
                    UnidadesCompra = listaUnidades
                });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar unidades. " + ex.Message
                });
            }
        }
        [HttpPost]
        public string ConsultarUnidadesVentaProducto(int productoId, int unidadCompraId)
        {
            try
            {
                var listaUnidades = new List<object>();
                var equivalencias = _productoRepository.GetEquivalenciasProducto(productoId)
                    .Where(p => p.UnidadMedidaCompraId == unidadCompraId);
                foreach (var equivalencia in equivalencias)
                {
                    var unidadBd = new UnidadMedidaVentaCompraViewModel
                    {
                        Id = (int)equivalencia.UnidadMedidaVentaId,
                        NombreUnidad = $"{equivalencia.UnidadMedidaVenta.Nombre} ({equivalencia.UnidadMedidaVenta.Abreviatura})",
                        Equivalencia = $"1 {equivalencia.UnidadMedidaCompra.Nombre} =" +
                        $" {equivalencia.CantidadEquivalenteDestino} {equivalencia.UnidadMedidaVenta.Nombre}"
                    };
                    listaUnidades.Add(unidadBd);
                }

                return JsonSerializer.Serialize(new
                {
                    Exitoso = true,
                    UnidadesVenta = listaUnidades
                });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar unidades. " + ex.Message
                });
            }
        }
        [HttpPost]
        public string ConsultarLaboratorios()
        {
            try
            {
                var listaLaboratorios = new List<object>();
                var laboratorios = _categoriaRepository.ListaLaboratorioProducto();
                foreach (var laboratorio in laboratorios)
                {
                    var laboratorioBd = new
                    {
                        Id = laboratorio.Id,
                        NombreLaboratorioProducto = laboratorio.NombreLaboratorioProducto
                    };
                    listaLaboratorios.Add(laboratorioBd);
                }


                return JsonSerializer.Serialize(new
                {
                    Exitoso = true,
                    Laboratorios = listaLaboratorios
                });
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new
                {
                    Exitoso = false,
                    Mensaje = "Error al consultar laboratorios. " + ex.Message
                });
            }
        }
        [HttpPost]
        public JsonResult GuardarComoPedido(CompraBaseViewModel model)
        {
            try
            {
                var fecha = DateTime.Now;

                var prov = _proveedorRepository.GetProveedorPorNombre(model.EncabezadoProveedor);

                if (prov == null)
                {

                    var nuevoProveedor = new Proveedor()
                    {
                        Nombre = model.EncabezadoProveedor,
                        BancoId = 1
                    };

                    var nuevaCompra = new Compra()
                    {
                        Proveedor = nuevoProveedor,
                        NoComprobante = model.EncabezadoNoComprobante,
                        EmpleadoId = model.EncabezadoEmpleadoId,
                        FechaLimite = Convert.ToDateTime(model.EncabezadoFechaLimite),
                        FechaRecepcion = DateTime.Now,
                        FechaCompra = fecha,
                        Observaciones = model.EncabezadoObservacion,
                        TipoCompraId = model.EncabezadoTipoCompraId
                    };

                    if (model.ProductosComprados != null)
                    {
                        foreach (var item in model.ProductosComprados)
                        {
                            var detalleCompra = new DetalleCompra()
                            {
                                Compra = nuevaCompra,
                                ProductoId = Convert.ToInt32(item.ProductoId),
                                UnidadMedidaCompraId = item.UnidadMedidaCompra.Id,
                                Cantidad = Convert.ToInt32(item.Cantidad),
                                Precio = Convert.ToDecimal(item.PrecioCompra),
                                PrecioTotal = Convert.ToDecimal(item.Total)
                            };

                            _compraRepository.Add(detalleCompra, false);
                        }
                    }


                    _compraRepository.saveChanges();

                    TempData["Message"] = "¡Se ha guardado la compra con éxito.!";

                    return Json(nuevaCompra.Id);
                }
                else
                {

                    var compra = new Compra()
                    {
                        Proveedor = prov,
                        NoComprobante = model.EncabezadoNoComprobante,
                        EmpleadoId = model.EncabezadoEmpleadoId,
                        FechaLimite = Convert.ToDateTime(model.EncabezadoFechaLimite),
                        FechaRecepcion = DateTime.Now,
                        FechaCompra = fecha,
                        TipoCompraId = model.EncabezadoTipoCompraId
                    };


                    foreach (var item in model.ProductosComprados)
                    {
                        var detalleCompra = new DetalleCompra()
                        {
                            Compra = compra,
                            ProductoId = Convert.ToInt32(item.ProductoId),
                            UnidadMedidaCompraId = item.UnidadMedidaCompra.Id,
                            Cantidad = Convert.ToInt32(item.Cantidad),
                            Precio = Convert.ToDecimal(item.PrecioCompra),
                            PrecioTotal = Convert.ToDecimal(item.Total)
                        };

                        _compraRepository.Add(detalleCompra, false);

                    }

                    _compraRepository.saveChanges();

                    TempData["Message"] = "¡Se ha guardado la compra con éxito.!";

                    return Json(compra.Id);
                }
            }
            catch (Exception ex)
            {
                return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor. " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult GuardarComoCompra(CompraBaseViewModel model)
        {
            try
            {
                var fecha = DateTime.Now;

                var prov = _proveedorRepository.GetProveedorPorNombre(model.EncabezadoProveedor);

                if (prov == null)
                {
                    var nuevoProveedor = new Proveedor()
                    {
                        Nombre = model.EncabezadoProveedor,
                        BancoId = 1,
                    };

                    var nuevaCompra = new Compra()
                    {
                        Proveedor = nuevoProveedor,
                        NoComprobante = model.EncabezadoNoComprobante,
                        EmpleadoId = model.EncabezadoEmpleadoId,
                        FechaLimite = Convert.ToDateTime(model.EncabezadoFechaLimite),
                        FechaRecepcion = DateTime.Now,
                        FechaCompra = fecha,
                        Observaciones = model.EncabezadoObservacion,
                        TipoCompraId = model.EncabezadoTipoCompraId,
                        Estado = true,
                    };

                    var recepcion = new Recepcion()
                    {
                        Compra = nuevaCompra,
                        EstadoRecepcionId = 1,
                    };

                    _compraRepository.Add(recepcion, false);

                    foreach (var item in model.ProductosComprados)
                    {
                        var detalleCompra = new DetalleCompra()
                        {
                            Compra = nuevaCompra,
                            ProductoId = Convert.ToInt32(item.ProductoId),
                            UnidadMedidaCompraId = item.UnidadMedidaCompra.Id,
                            Cantidad = Convert.ToInt32(item.Cantidad),
                            Precio = Convert.ToDecimal(item.PrecioCompra),
                            PrecioTotal = Convert.ToDecimal(item.Total)
                        };

                        _compraRepository.Add(detalleCompra, false);

                    }

                    _compraRepository.saveChanges();

                    TempData["Message"] = "¡Se ha guardado la compra con éxito.!";

                    return Json(nuevaCompra.Id);
                }
                else
                {

                    var compra = new Compra()
                    {
                        Proveedor = prov,
                        NoComprobante = model.EncabezadoNoComprobante,
                        EmpleadoId = model.EncabezadoEmpleadoId,
                        FechaLimite = Convert.ToDateTime(model.EncabezadoFechaLimite),
                        FechaRecepcion = DateTime.Now,
                        FechaCompra = fecha,
                        TipoCompraId = model.EncabezadoTipoCompraId,
                        Estado = true
                    };

                    var recepcion = new Recepcion()
                    {
                        Compra = compra,
                        EstadoRecepcionId = 1,
                    };

                    _compraRepository.Add(recepcion, false);


                    foreach (var item in model.ProductosComprados)
                    {
                        var detalleCompra = new DetalleCompra()
                        {
                            Compra = compra,
                            ProductoId = Convert.ToInt32(item.ProductoId),
                            UnidadMedidaCompraId = item.UnidadMedidaCompra.Id,
                            Cantidad = Convert.ToInt32(item.Cantidad),
                            Precio = Convert.ToDecimal(item.PrecioCompra),
                            PrecioTotal = Convert.ToDecimal(item.Total),
                        };

                        _compraRepository.Add(detalleCompra, false);

                    }

                    _compraRepository.saveChanges();

                    TempData["Message"] = "¡Se ha guardado la compra con éxito.!";

                    return Json(compra.Id);
                }
            }
            catch (Exception ex)
            {
                return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor. " + ex.Message });
            }
        }


        // public JsonResult GuardarCom([FromBody] List<DetalleBinding> detalle,
        // string nocomprobante, string proveedor, string nombrevendedor, string fechalimite,
        // string fecharecepcion, string nombreproveedor, string empleadoid)
        // {
        //     var fecha = DateTime.Now;

        //     if (ModelState.IsValid)
        //     {
        //         // cargar lista de todas las cajas
        //         var cajita = _cajaRepository.ListarCajas();

        //         // verificar si hay cajas abiertas, una por una, si te acordas del Any()
        //         // otra manera seria hacerlo con una bandera, pero el any te hace el trabajo.
        //         if (!cajita.Any(a => a.EstadoCaja == true))
        //         {
        //             TempData["Message"] = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!";
        //             return Json("");
        //         }

        //         var prov = _proveedorRepository.GetProveedorPorNombre(nombreproveedor);
        //         var cajaAbierta = _cajaRepository.GetCajaAbierta();
        //         var empleado = _empleadoRepository.Get(Convert.ToInt16(empleadoid));

        //         if (empleado == null)
        //         {
        //             return new JsonErrorResult(new { message = "Codigo de empleado invalido." });
        //         }


        //         if (prov == null)
        //         {

        //             var nuevoProveedor = new Proveedor()
        //             {
        //                 Nombre = nombreproveedor,
        //                 BancoId = 1,

        //             };

        //             var nuevaCompra = new Compra()
        //             {
        //                 Proveedor = nuevoProveedor,
        //                 NoComprobante = nocomprobante,
        //                 NombreVendedor = nombrevendedor,
        //                 FechaLimite = Convert.ToDateTime(fechalimite),
        //                 FechaRecepcion = Convert.ToDateTime(fecharecepcion),
        //                 EmpleadoId = Convert.ToInt16(empleadoid),
        //                 FechaCompra=fecha,
        //             };

        //             var nuevoDetalleCaja = new DetalleCaja()
        //             {
        //                 Compra = nuevaCompra,
        //                 Descripcion = "Compra a Proveedor: " + nuevoProveedor.Nombre,
        //                 Gasto = detalle.Sum(a => Convert.ToDecimal(a.Total)),
        //                 Caja = cajaAbierta
        //             };

        //             _cajaRepository.Add(nuevoDetalleCaja, false);

        //             foreach (var item in detalle)
        //             {
        //                 var detalleCompra = new DetalleCompra()
        //                 {
        //                     Compra = nuevaCompra,
        //                     ProductoId = Convert.ToInt32(item.ProductoId),
        //                     Cantidad = Convert.ToInt32(item.Cantidad),
        //                     Precio = Convert.ToDecimal(item.PrecioCosto),
        //                     PrecioTotal = Convert.ToDecimal(item.Total),
        //                 };

        //                 _compraRepository.Add(detalleCompra, false);

        //             }

        //             _compraRepository.saveChanges();

        //             TempData["Message"] = "¡Se Guardado la compra con éxito.!";

        //             return Json(nuevaCompra.Id);


        //         }
        //         else
        //         {

        //             var compra = new Compra()
        //             {
        //                 ProveedorId = Convert.ToInt32(proveedor),
        //                 NoComprobante = nocomprobante,
        //                 NombreVendedor = nombrevendedor,
        //                 FechaLimite = Convert.ToDateTime(fechalimite),
        //                 FechaRecepcion = Convert.ToDateTime(fecharecepcion),
        //                 EmpleadoId = Convert.ToInt16(empleadoid),
        //                 FechaCompra=fecha,
        //             };

        //             var nuevoDetalleCaja = new DetalleCaja()
        //             {
        //                 Compra = compra,
        //                 Descripcion = "Compra a Proveedor: " + prov.Nombre,
        //                 Gasto = detalle.Sum(a => Convert.ToDecimal(a.Total)),
        //                 Caja = cajaAbierta
        //             };

        //             _cajaRepository.Add(nuevoDetalleCaja, false);

        //             foreach (var item in detalle)
        //             {
        //                 var detalleCompra = new DetalleCompra()
        //                 {
        //                     Compra = compra, // listo pero y el id, Ef? solito lo reconoce y lo mete oooo
        //                     ProductoId = Convert.ToInt32(item.ProductoId),
        //                     Cantidad = Convert.ToInt32(item.Cantidad),
        //                     Precio = Convert.ToDecimal(item.PrecioCosto),
        //                     PrecioTotal = Convert.ToDecimal(item.Total),
        //                 };

        //                 _compraRepository.Add(detalleCompra, false);

        //             }

        //             _compraRepository.saveChanges();

        //             TempData["Message"] = "¡Se Guardado la compra con éxito.!";

        //             return Json(compra.Id);

        //         }
        //     }

        //     return Json("Ha ocurrido un error");


        // }



        public IActionResult ListaTodas(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            // ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            // ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _compraRepository.PaginacionCompras(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult ListaPeticiones(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            // ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            // ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _compraRepository.PaginacionComprasPeticion(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }


        public IActionResult ListaComprados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            // ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            // ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _compraRepository.PaginacionComprasComprados(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult ListaRecepciones(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            // ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            // ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _compraRepository.PaginacionRecepciones(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            // var detalle = _compraRepository.GetDetalle((int)id);
            var compra = _compraRepository.Get((int)id);

            if (compra == null)
            {
                return StatusCode(404);
            }

            var modelo = new CompraBaseViewModel
            {
                CompraId = compra.Id,
                EstadoCompra = compra.Estado,

                //Encabezado
                EncabezadoNoComprobante = compra.NoComprobante,
                EncabezadoEmpleadoId = compra.EmpleadoId,
                EncabezadoProveedor = compra.Proveedor.Nombre,
                EncabezadoFechaLimite = compra.FechaLimite
            };

            modelo.Init(_proveedorRepository, _compraRepository);

            return View(modelo);
        }

        //public JsonResult ModificarCompra([FromBody] CompraModel det)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var listadoEnBd = _compraRepository.GetDetalle(det.encabezado.CompraId);

        //        foreach (var item in listadoEnBd)
        //        {
        //            bool flag = false;

        //            foreach (var ins in det.detalle)
        //            {
        //                if (item.Id == ins.Id)
        //                {
        //                    flag = true;
        //                    break;
        //                }
        //            }

        //            if (!flag)
        //            {
        //                _compraRepository.Delete(item.Id, false);
        //            }
        //        }

        //        var prov = _proveedorRepository.GetProveedorPorNombre(det.encabezado.Proveedor);

        //        if (prov == null)
        //        {
        //            var nuevoProveedor = new Proveedor()
        //            {
        //                Nombre = det.encabezado.Proveedor,
        //                BancoId = 1,
        //            };

        //            var nuevaCompra = _compraRepository.Get(det.encabezado.CompraId, false);
        //            nuevaCompra.NoComprobante = det.encabezado.NoComprobante;
        //            nuevaCompra.Proveedor = nuevoProveedor;
        //            nuevaCompra.EmpleadoId = det.encabezado.EmpleadoId;
        //            nuevaCompra.FechaLimite = det.encabezado.FechaLimite;
        //            nuevaCompra.Observaciones = det.encabezado.Observacion;
        //            nuevaCompra.TipoCompraId = det.encabezado.TipoCompraId;


        //            _compraRepository.Update(nuevaCompra, false);

        //            foreach (var item in det.nuevos)
        //            {

        //                var nuevodetalle = new DetalleCompra()
        //                {
        //                    CompraId = det.encabezado.CompraId,
        //                    ProductoId = Convert.ToInt32(item.Ids),
        //                    Cantidad = Convert.ToInt32(item.Cantidad),
        //                    Precio = Convert.ToDecimal(item.Precio),
        //                    PrecioTotal = Convert.ToDecimal(item.Total),
        //                };

        //                _compraRepository.Add(nuevodetalle, false);

        //            }

        //            foreach (var item in det.detalle)
        //            {
        //                var detalleCompra = _compraRepository.GetDetalleC(item.Id);
        //                detalleCompra.Cantidad = item.Cantidad;
        //                detalleCompra.Precio = item.Precio;
        //                detalleCompra.PrecioTotal = item.Total;

        //                _compraRepository.Update(detalleCompra, false);

        //            }

        //            _compraRepository.saveChanges();
        //            TempData["Message"] = "¡Se modifico la compra con éxito.!";
        //            return Json("OK");

        //        }
        //        else
        //        {
        //            var compra = _compraRepository.Get(det.encabezado.CompraId, false);
        //            compra.NoComprobante = det.encabezado.NoComprobante;
        //            compra.Proveedor = prov;
        //            compra.EmpleadoId = det.encabezado.EmpleadoId;
        //            compra.FechaLimite = det.encabezado.FechaLimite;
        //            compra.Observaciones = det.encabezado.Observacion;
        //            compra.TipoCompraId = det.encabezado.TipoCompraId;


        //            _compraRepository.Update(compra, false);


        //            foreach (var item in det.nuevos)
        //            {

        //                var nuevodetalle = new DetalleCompra()
        //                {
        //                    Compra = compra,
        //                    ProductoId = Convert.ToInt32(item.Ids),
        //                    Cantidad = Convert.ToInt32(item.Cantidad),
        //                    Precio = Convert.ToDecimal(item.Precio),
        //                    PrecioTotal = Convert.ToDecimal(item.Total),
        //                };

        //                _compraRepository.Add(nuevodetalle, false);
        //            }

        //            foreach (var item in det.detalle)
        //            {
        //                var detalleCompra = _compraRepository.GetDetalleC(item.Id);
        //                detalleCompra.Cantidad = item.Cantidad;
        //                detalleCompra.Precio = item.Precio;
        //                detalleCompra.PrecioTotal = item.Total;

        //                _compraRepository.Update(detalleCompra, false);
        //            }

        //            _compraRepository.saveChanges();
        //            TempData["Message"] = "¡Se modifico la compra con éxito.!";
        //            return Json("OK");
        //        }
        //    }

        //    return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });
        //}

        // cuando el usuario solo guardo la compra y desea cambiarlo a comprado
        public JsonResult CambiarAComprado(int? compraId)
        {
            if (compraId == null) return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });

            var compra = _compraRepository.Get((int)compraId, false);

            if (compra == null) return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });

            var recepcion = new Recepcion()
            {
                Compra = compra,
                EstadoRecepcionId = 1,
            };

            _compraRepository.Add(recepcion, false);


            // // hay que sumar los productos a inventario
            // foreach (var item in compra.DetalleCompras)
            // {
            //     //restar al inventario
            //     var producto = _productoRepository.Get(item.ProductoId);
            //     producto.Stock += item.Cantidad;

            //     _productoRepository.Update(producto, false);
            // }

            // marcar la compra como true , o sea "Comprado"
            compra.Estado = true;
            _compraRepository.Update(compra, false);

            _compraRepository.saveChanges();
            TempData["Message"] = "¡Se modifico la compra con éxito.!";

            return Json("OK");

        }

        public IActionResult VerRecepcion(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            // var detalle = _compraRepository.GetDetalle((int)id);
            var recepcion = _compraRepository.GetRecepcion((int)id);

            if (recepcion == null)
            {
                return StatusCode(404);
            }

            var modelo = new CompraBaseViewModel()
            {
                Recepcion = recepcion,
            };

            modelo.Init(_proveedorRepository, _compraRepository);

            return View(modelo);
        }

        public IActionResult ReporteComprasFechas()
        {
            var model = new CompraBaseViewModel() { };
            // model.Init(_empleadoRepository);

            return View(model);
        }

        public IActionResult ValidarProductosInventario(int? id)
        {

            if (id == null)
            {

                return BadRequest("request is incorrect");
            }

            var recepcion = _compraRepository.GetRecepcion((int)id);

            if (recepcion.EstadoRecepcionId == 3)
            {
                TempData["Message"] = "¡Este registro ya ha sido validado.!";
                return RedirectToAction("VerRecepcion", new { id = id });
            }

            if (recepcion == null)
            {
                return StatusCode(404);
            }

            foreach (var item in recepcion.Compra.DetalleCompras)
            {
                item.Producto.Stock += item.Cantidad;

                _productoRepository.Update(item.Producto, false);
            }


            recepcion.EstadoRecepcionId = 3;

            _compraRepository.Update(recepcion, false);

            _productoRepository.SaveChanges();

            TempData["Message"] = "¡Se actualizó el inventario con éxito.!";
            return RedirectToAction("VerRecepcion", new { id = id });
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public async Task<IActionResult> Reporte(int? CompraId)
        {
            if (CompraId == null) return StatusCode(400);

            var compra = _compraRepository.Get((int)CompraId);

            if (compra == null) return StatusCode(404);

            // var user = _userManager.GetUserAsync(HttpContext.User);
            // var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;

            return await _generatePdf.GetPdf("Views/Compra/Reporte.cshtml", compra);
        }

        public JsonResult IngresarProductosAInventario(int? recepcionId)
        {
            if (recepcionId == null) return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });

            var recepcion = _compraRepository.GetRecepcion((int)recepcionId);

            if (recepcion == null) return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });

            foreach (var item in recepcion.Compra.DetalleCompras)
            {
                //sumar al inventario
                var producto = _productoRepository.Get(item.ProductoId);
                producto.Stock += item.Cantidad;

                _productoRepository.Update(producto, false);
            }

            recepcion.EstadoRecepcionId = 2;

            _compraRepository.Update(recepcion, false);
            _compraRepository.saveChanges();

            TempData["Message"] = "Los productos se han sumado al inventario con éxito :)";

            return Json("OK");
        }



    }




    public class IdsBinding
    {
        public string Ids { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
