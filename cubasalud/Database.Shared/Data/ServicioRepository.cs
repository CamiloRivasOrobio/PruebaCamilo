using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;


namespace Database.Shared.Data
{
    public class ServicioRepository : IServicio
    {
        private readonly Context _context = null;

        public ServicioRepository(Context context)
        {
            _context = context;
        }

        public void Add(Servicio servicio, bool saveChanges = true)
        {
            _context.Servicios.Add(servicio);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public IList<Servicio> GetListaServicios()
        {
            return _context.Servicios
                .Where(a => a.Eliminado == false)
                .OrderBy(a => a.NombreServicio)
                .ToList();
        }

        public List<ListadoServiciosIdYNombres> GetList()
        {
            return _context.Servicios
                .Where(a => a.Eliminado == false)
                .Select(a => new ListadoServiciosIdYNombres
                {
                    Id = a.Id,
                    NombreServicio = a.NombreServicio
                })
                .OrderBy(a => a.NombreServicio)
                .ToList();
        }

        public IList<Servicio> BuscarPorNombreBusquedaAjax(string searchString)
        {
            return _context.Servicios.Where(s => s.NombreServicio.Contains(searchString))
                            .Where(a => a.Eliminado == false)
                            .ToList();
        }


        // SELECT *FROM PRODUCTOS WHERE ID = <id>
        public Servicio Get(int id, bool includeRelatedEntities = true)
        {
            var servicios = _context.Servicios.AsQueryable();

            return servicios
               .Where(a => a.Id == id)
               .SingleOrDefault();
        }

        public Servicio GetNombre(string nombre, bool includeRelatedEntities = true)
        {
            var servicios = _context.Servicios.AsQueryable();


            return servicios
               .Where(a => a.NombreServicio == nombre)
               .SingleOrDefault();

        }



        public void Update(Servicio model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }

        }
        public void ActualizarInventarioVentaServicio(int servicioId)
        {
            var insumos = _context.ServiciosInsumos
                .Where(s => s.ServicioId == servicioId)
                .ToList();
            if (insumos != null && insumos.Count > 0)
            {
                foreach (var insumo in insumos)
                {
                    var inventarioProducto = _context.ProductosInventario
                        .Where(p => p.ProductoId == insumo.ProductoId
                            && p.Stock > 0)
                        .FirstOrDefault();

                    var equivalencia = _context.ProductosEquivalencias
                        .Include(p => p.UnidadMedidaVenta)
                        .Include(p => p.UnidadMedidaCompra)
                        .Where(e => e.ProductoId == insumo.ProductoId
                               && e.UnidadMedidaCompraId == inventarioProducto.UnidadMedidaCompraId)
                        .FirstOrDefault();

                    var cantidadVentaExistente = equivalencia.CantidadEquivalenteDestino * inventarioProducto.Stock;

                    cantidadVentaExistente -= insumo.CantidadUtilizada;

                    var saldoStock = cantidadVentaExistente / equivalencia.CantidadEquivalenteDestino;

                    inventarioProducto.Stock = saldoStock;

                    _context.Entry(inventarioProducto).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
        }

    }

    public class ListadoServiciosIdYNombres
    {
        public int Id { get; set; }
        public string NombreServicio { get; set; }
    }
}