using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;
using Database.Shared.DataBindings;
using Database.Shared.Enumeraciones;

namespace Database.Shared.Data
{
    public class ProductosRepository : IProducto
    {

        private readonly Context _context = null;

        public ProductosRepository(Context context)
        {
            _context = context;
        }

        public void Add(Producto producto, bool saveChanges = true)
        {
            _context.Productos.Add(producto);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }
        public List<Producto> GetList() => _context.Productos.Include(a => a.Viadmin)
        .Where(x => x.Eliminado == false)
        .Where(x => x.NombreProducto == null)
        .ToList();

        public List<Producto> GetListPdf() => _context.Productos.Include(a => a.GrupoTProducto)
                  .Include(a => a.LaboratorioProducto)
                  .OrderBy(a => a.NombreProducto)
                  .Where(a => a.Eliminado == false && a.TipoBodegaId == 2 && a.TipoProductoId == 10)
                  .ToList();

        public IList<ProductoYCodigo> GetListParaCotizacion()
        {
            return _context.Productos
            .Include(a => a.Viadmin)
            .Where(x => x.Eliminado == false)

            .Select(a => new ProductoYCodigo
            {
                CodigoReferencia = a.CodigoReferencia,
                ProductoYCodigoDeBarras = a.GetProductosYCodigoDeBarras
            })
            .ToList();
        }

        public IList<Producto> GetListado()
        {
            return _context.Productos
                    .Where(x => x.Eliminado == false
                    && x.TipoBodegaId == 1
                    && x.TipoProductoId == (int)TipoProductoEnum.Medicamentos).ToList();
        }
        public IList<Producto> GetProductos(int tipoBodega, int tipoProducto, bool eliminados = false)
        {
            return _context.Productos
                .Include(p => p.ProductoEquivalencias).ThenInclude(p => p.UnidadMedidaCompra)
                .Include(p => p.ProductoEquivalencias).ThenInclude(p => p.UnidadMedidaVenta)
                    .Where(x => x.Eliminado == eliminados
                    && x.TipoBodegaId == tipoBodega
                    && x.TipoProductoId == tipoProducto)
                    .ToList();
        }
        public IList<Producto> GetListadoProductos()
        {
            return _context.Productos
            .Include(a => a.PresentacionProducto)
            .Include(a => a.Categoria)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 1).ToList();
        }
        public List<Producto> GetProductos()
        {
            return _context.Productos
            .Include(a => a.PresentacionProducto)
            .Include(a => a.Categoria)
            .Where(a => a.Eliminado == false).ToList();
        }

        public IList<Producto> GetListadoProductosBodega()
        {
            return _context.Productos
            .Include(a => a.PresentacionProducto)
            .Include(a => a.Categoria)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 3).ToList();
        }



        // SELECT *FROM PRODUCTOS WHERE ID = <id>
        public Producto Get(int id, bool includeRelatedEntities = true)
        {
            var productos = _context.Productos.AsQueryable();

            if (includeRelatedEntities)
            {
                productos = productos.Include(a => a.Viadmin);
            }

            return productos
               .Where(a => a.Id == id)
               .SingleOrDefault();
        }

        public Producto GetByName(string producto, bool includeRelatedEntities = true)
        {
            var productos = _context.Productos.AsQueryable();

            if (includeRelatedEntities)
            {
                productos = productos.Include(a => a.Viadmin);
            }

            return productos
               .Where(a => a.NombreProducto == producto)
               .SingleOrDefault();
        }

        public void Update(Producto model, bool saveChanges = true)
        {
            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public PaginacionList<Producto> PaginacionProductosFarmaciaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString)
                || s.LaboratorioProducto.NombreLaboratorioProducto.Contains(searchString));
            }

            if (terapeuticoId != null) productos = productos.Where(a => a.GrupoTProductoId == terapeuticoId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.GrupoTProducto)
            .Include(a => a.LaboratorioProducto)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.TipoProductoId == 10),
            pageNumber ?? 1, pageSize);
        }

        public IList<Producto> FiltrarPorBusquedaYTerapeutico(string searchString, int? terapeuticoId, int tipoBodega)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (terapeuticoId != 0) productos = productos.Where(a => a.GrupoTProductoId == terapeuticoId);

            return productos
            .Include(a => a.GrupoTProducto)
            .Include(a => a.PresentacionProducto)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == tipoBodega && a.TipoProductoId == 10).ToList();
        }

        public IList<Producto> FiltrarPorBusquedaYCategoria(string searchString, int? categoriaId, int tipoBodega)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (categoriaId != 0) productos = productos.Where(a => a.CategoriaId == categoriaId);

            return productos
            .Include(a => a.Categoria)
            .Include(a => a.Marca)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == tipoBodega && a.TipoProductoId == 11).ToList();
        }

        public PaginacionList<Producto> PaginacionProductosFarmaciaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId)
        {

            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (categoriaId != null) productos = productos.Where(a => a.CategoriaId == categoriaId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.Categoria)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.TipoProductoId == 11),

            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProductosClinicaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (terapeuticoId != null) productos = productos.Where(a => a.GrupoTProductoId == terapeuticoId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.GrupoTProducto)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 2 && a.TipoProductoId == 10),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProductosLabMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (terapeuticoId != null) productos = productos.Where(a => a.GrupoTProductoId == terapeuticoId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.GrupoTProducto)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 4 && a.TipoProductoId == 10),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionBodegaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString)
                || s.LaboratorioProducto.NombreLaboratorioProducto.Contains(searchString));
            }

            if (terapeuticoId != null) productos = productos.Where(a => a.GrupoTProductoId == terapeuticoId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.GrupoTProducto)
            .Include(a => a.LaboratorioProducto)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 3 && a.TipoProductoId == 10),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProductosBodegaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId)
        {

            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (categoriaId != null) productos = productos.Where(a => a.CategoriaId == categoriaId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.Categoria)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 3 && a.TipoProductoId == 11),

            pageNumber ?? 1, pageSize);
        }


        public List<Producto> GetInventarioProductos(int tipoBodega
            , int tipoProducto
            , int? categoriaId
            , bool eliminado = false)
        {
            if (categoriaId == null)
                return _context.Productos
                .Include(a => a.Categoria)
                .OrderBy(a => a.NombreProducto)
                .Where(a => a.Eliminado == eliminado
                && a.TipoBodegaId == (int)tipoBodega
                && a.TipoProductoId == (int)tipoProducto)
                .ToList();
            else
                return _context.Productos
                .Include(a => a.Categoria)
                .OrderBy(a => a.NombreProducto)
                .Where(a => a.Eliminado == eliminado
                && a.TipoBodegaId == (int)tipoBodega
                && a.TipoProductoId == (int)tipoProducto
                && a.CategoriaId == (int)categoriaId)
                .ToList();
        }
        public PaginacionList<Producto> PaginacionProductosLabInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId)
        {

            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            if (categoriaId != null) productos = productos.Where(a => a.CategoriaId == categoriaId);

            return PaginacionList<Producto>.CreateAsyncc(productos
            .Include(a => a.Categoria)
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 4 && a.TipoProductoId == 11),

            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProductosFaltantes(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.Stock <= 5 && a.TipoBodegaId == 1),
            pageNumber ?? 1, pageSize);
        }

        public IList<Producto> GetListadoFaltantesFarmacia(string searchString)
        {
            var producto = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                producto = producto.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }

            return producto.Where(x => x.Eliminado == false)
            .Where(a => a.Stock <= 5 && a.TipoBodegaId == 1)
            .ToList();
        }

        public PaginacionList<Producto> PaginacionProductosFaltantesClinica(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.Stock <= 1 && a.TipoBodegaId == 2 && a.TipoProductoId == 10
                || a.Stock <= 5 && a.TipoBodegaId == 2 && a.TipoProductoId == 11),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProductosFaltantesLab(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.Stock <= 1 && a.TipoBodegaId == 4 && a.TipoProductoId == 10
                || a.Stock <= 5 && a.TipoBodegaId == 4 && a.TipoProductoId == 11),
            pageNumber ?? 1, pageSize);
        }

        public IList<Producto> GetListadoFaltantesClinica(string searchString)
        {
            var producto = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                producto = producto.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }

            return producto.Where(x => x.Eliminado == false)
            .Where(a => a.Stock <= 5 && a.TipoBodegaId == 2)
            .ToList();
        }

        public IList<Producto> GetListadoFaltantesLab(string searchString)
        {
            var producto = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                producto = producto.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }

            return producto.Where(x => x.Eliminado == false)
            .Where(a => a.Stock <= 5 && a.TipoBodegaId == 4)
            .ToList();
        }


        public PaginacionList<Producto> PaginacionProductosVencimiento(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            var fecha = (DateTime.Now).AddDays(-4);

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "Nombre_desc":
                    productos = productos.OrderByDescending(s => s.NombreProducto);
                    break;

                default:
                    productos = productos.OrderBy(s => s.NombreProducto);
                    break;
            }

            return PaginacionList<Producto>.CreateAsyncc(productos.Where(a => a.Eliminado == false).Where(a => a.FechaVencimiento > fecha), pageNumber ?? 1, pageSize);
        }


        public Producto GetPorNumeroDeReferencia(string id, bool includeRelatedEntities = true)
        {
            return _context.Productos.Where(a => a.CodigoReferencia == id)
            .Where(a => a.Eliminado == false && a.Stock > 0 && a.TipoBodegaId == 1).SingleOrDefault();
        }

        public IList<Producto> GetPorNumeroDeReferenciaList(string id, bool includeRelatedEntities = true)
        {
            return _context.Productos.Where(a => a.CodigoReferencia == id)
            .Where(a => a.Eliminado == false && a.Stock > 0 && a.TipoBodegaId == 1).ToList();
        }

        public Producto GetPorNumeroDeReferenciaClinica(string id, bool includeRelatedEntities = true)
        {
            return _context.Productos
            .Where(a => a.CodigoReferencia == id && a.Eliminado == false && a.Stock > 0 && a.TipoBodegaId == 2).SingleOrDefault();
        }

        public Producto GetProdutoById(int id)
        {
            return _context.Productos.Where(a => a.Id == id)
            .Where(a => a.Eliminado == false)
            .SingleOrDefault();
        }


        public Producto GetPorNumeroDeReferenciayNombre(string id, bool includeRelatedEntities = true)
        {
            var productos = _context.Productos.AsQueryable();

            if (includeRelatedEntities)
            {
                productos = productos.Include(a => a.Viadmin);
            }

            return productos
               .Where(a => a.CodigoReferencia == id || a.NombreProducto.Contains(id))
               .SingleOrDefault();
        }



        public IList<RetornoProductoPOSClinica> BuscarPorNombreYReferenciaBusquedaAjaxClinica(string searchString)
        {
            var productos = _context.Productos.AsQueryable();
            return productos.Where(s => s.NombreProducto.Contains(searchString)
                            || s.CodigoReferencia.Contains(searchString))
                            .Include(a => a.Viadmin)
                            .Include(a => a.PresentacionProducto)
                            .Include(a => a.GrupoTProducto)
                            .Include(a => a.LaboratorioProducto)
                            .Include(a => a.Categoria)
                            .Include(a => a.Marca)
                            .Include(a => a.Grupo)
                            .Where(a => a.Eliminado == false && a.TipoBodegaId == 2)
                            .Select(a => new RetornoProductoPOSClinica
                            {
                                viadmin = a.Viadmin.NombreViadmin,
                                presentacion = a.PresentacionProducto.PresentProducto,
                                grupoT = a.GrupoTProducto.NombreGrupoT,
                                lab = a.LaboratorioProducto.NombreLaboratorioProducto,
                                categoria = a.Categoria.NombreCategoria,
                                marca = a.Marca.NombreMarca,
                                grupo = a.Grupo.NombreGrupo,
                                nombreProducto = a.NombreProducto,
                                stock = a.Stock.ToString(),
                                codigoReferencia = a.CodigoReferencia,
                                tipoProductoId = (int)a.TipoProductoId,
                                dosis = a.Dosis,
                                precio_5 = a.Precio_5.ToString(),
                                activoYConcentracion = a.ActivoYConcentracion,
                                imagen = a.Imagen
                            })
                            .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Producto GetProductoByTipoBodegaAndNombre(int tipoBodega, string nombre)
        {
            return _context.Productos
            .Where(a => a.TipoBodegaId == tipoBodega && a.NombreProducto == nombre && a.Eliminado == false)
            .SingleOrDefault();
        }


        public PaginacionList<Producto> PaginacionVencidosFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.TipoBodegaId == 1 && a.FechaVencimiento != null && a.FechaVencimiento < DateTime.Now),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProximosAVencerFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            return PaginacionList<Producto>.CreateAsyncc(productos
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.FechaVencimiento != null)
            // .Where(a => EF.Functions.DateDiffDay( DateTime.Now, a.FechaVencimiento.Value) > 0)
            .Where(a => DateTime.Now.DayOfWeek - a.FechaVencimiento.Value.DayOfWeek > 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) >= 0)
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) >= 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) <= 90),
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) <= 90),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionVencidosClinica(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.TipoBodegaId == 2 && a.FechaVencimiento != null && a.FechaVencimiento < DateTime.Now),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionVencidosLab(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.NombreProducto.Contains(searchString) || s.CodigoReferencia.Contains(searchString));
            }


            return PaginacionList<Producto>.CreateAsyncc(productos
            .Where(a => a.Eliminado == false)
            .Where(a => a.TipoBodegaId == 4 && a.FechaVencimiento != null && a.FechaVencimiento < DateTime.Now),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProximosAVencerClinica(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            return PaginacionList<Producto>.CreateAsyncc(productos
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 2 && a.FechaVencimiento != null)
            // .Where(a => EF.Functions.DateDiffDay( DateTime.Now, a.FechaVencimiento.Value) > 0)
            .Where(a => DateTime.Now.DayOfWeek - a.FechaVencimiento.Value.DayOfWeek > 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) >= 0)
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) >= 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) <= 30),
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) <= 30),
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Producto> PaginacionProximosAVencerLab(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var productos = _context.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s =>
                s.NombreProducto.Contains(searchString)
                || s.CodigoReferencia.Contains(searchString))
                ;
            }

            return PaginacionList<Producto>.CreateAsyncc(productos
            .OrderBy(a => a.NombreProducto)
            .Where(a => a.Eliminado == false && a.TipoBodegaId == 4 && a.FechaVencimiento != null)
            // .Where(a => EF.Functions.DateDiffDay( DateTime.Now, a.FechaVencimiento.Value) > 0)
            .Where(a => DateTime.Now.DayOfWeek - a.FechaVencimiento.Value.DayOfWeek > 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) >= 0)
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) >= 0)
            // .Where(a => Math.Abs(EF.Functions.DateDiffDay(a.FechaVencimiento.Value, DateTime.Now)) <= 30),
            .Where(a => Math.Abs((a.FechaVencimiento.Value.DayOfWeek - DateTime.Now.DayOfWeek)) <= 30),
            pageNumber ?? 1, pageSize);
        }

        public int GetTotalMedicamentosFarmacia()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.TipoProductoId == 10);
        }

        public int GetTotalInsumosFarmacia()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.TipoProductoId == 11);
        }

        public int GetTotalMedicamentosClinica()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 2 && a.TipoProductoId == 10);
        }

        public int GetTotalMedicamentosLab()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 4 && a.TipoProductoId == 10);
        }

        public int GetTotalInsumosClinica(int? categoriaId)
        {
            if (categoriaId == null)
                return _context.Productos.Count(a => a.Eliminado == false
                && a.TipoBodegaId == (int)TipoBodegaEnum.Clinica
                && a.TipoProductoId == (int)TipoProductoEnum.InsumosMedicos);
            else
                return _context.Productos.Count(a => a.Eliminado == false
                && a.TipoBodegaId == (int)TipoBodegaEnum.Clinica
                && a.TipoProductoId == (int)TipoProductoEnum.InsumosMedicos
                && a.CategoriaId == (int)categoriaId);
        }


        public int GetTotalInsumosLab()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 4 && a.TipoProductoId == 11);
        }

        public int GetTotalMedicamentosBodega()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 3 && a.TipoProductoId == 10);
        }

        public int GetTotalInsumosBodega()
        {
            return _context.Productos.Count(a => a.Eliminado == false && a.TipoBodegaId == 3 && a.TipoProductoId == 11);
        }

        public IList<Producto> GetProductosLaboratorio(int? laboratorioId = null)
        {
            var productos = _context.Productos
                .Include(a => a.PresentacionProducto)
                .Where(p => !p.Eliminado
                && p.TipoBodegaId == (int)TipoBodegaEnum.Farmacia);

            if (laboratorioId == null)
            {
                return productos
                    .OrderBy(p => p.NombreProducto)
                    .ToList();
            }
            else
            {
                return productos
                    .Where(p => p.LaboratorioProductoId == laboratorioId)
                    .OrderBy(p => p.NombreProducto)
                    .ToList();
            }
        }


        public IList<RetornoProductoPOS> BuscarPorNombreYReferenciaBusquedaAjax(string searchString)
        {
            var productos = _context.Productos.AsQueryable();

            return productos.Where(s => s.NombreProducto.Contains(searchString))
                    .Include(a => a.Viadmin)
                    .Include(a => a.PresentacionProducto)
                    .Include(a => a.GrupoTProducto)
                    .Include(a => a.LaboratorioProducto)
                    .Include(a => a.Categoria)
                    .Include(a => a.Marca)
                    .Include(a => a.Grupo)
                    .Where(a => a.Eliminado == false && a.TipoBodegaId == 1)
                    .Select(a => new RetornoProductoPOS
                    {
                        viadmin = a.Viadmin.NombreViadmin,
                        presentacion = a.PresentacionProducto.PresentProducto,
                        grupoT = a.GrupoTProducto.NombreGrupoT,
                        lab = a.LaboratorioProducto.NombreLaboratorioProducto,
                        categoria = a.Categoria.NombreCategoria,
                        marca = a.Marca.NombreMarca,
                        grupo = a.Grupo.NombreGrupo,
                        nombreProducto = a.NombreProducto,
                        stock = a.Stock.ToString(),
                        codigoReferencia = a.CodigoReferencia,
                        tipoProductoId = (int)a.TipoProductoId,
                        dosis = a.Dosis,
                        precio_5 = a.Precio_5.ToString(),
                        activoYConcentracion = a.ActivoYConcentracion,
                        imagen = a.Imagen
                    })
                    .ToList();
        }

        public IList<Producto> GetMedicamentosFarmaciaList()
        {
            return _context.Productos.Where(a => a.Eliminado == false && a.TipoBodegaId == 1 && a.TipoProductoId == 10).ToList();
        }

        #region Consulta de unidades
        public List<UnidadMedidaCompra> GetUnidadesCompra()
        {
            return _context.UnidadesMedidaCompra.OrderBy(u => u.Nombre).ToList();
        }
        public List<UnidadMedidaVenta> GetUnidadesVenta()
        {
            return _context.UnidadesMedidaVenta.OrderBy(u => u.Nombre).ToList();
        }
        #endregion
        public List<ProductoEquivalencia> GetEquivalenciasProducto(int productoId)
        {
            return _context.ProductosEquivalencias
                .Include(p => p.UnidadMedidaCompra)
                .Include(p => p.UnidadMedidaVenta)
                .Where(p => p.ProductoId == productoId)
                .ToList();
        }
    }

    public class RetornoProductoPOS
    {
        public string nombreProducto { get; set; }
        public string stock { get; set; }
        public string codigoReferencia { get; set; }
        public string viadmin { get; set; }
        public string presentacion { get; set; }
        public string grupoT { get; set; }
        public string lab { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string grupo { get; set; }
        public int tipoProductoId { get; set; }
        public string dosis { get; set; }
        public string precio_5 { get; set; }
        public string activoYConcentracion { get; set; }
        public string imagen { get; set; }

    }

    public class RetornoProductoPOSClinica
    {
        public string nombreProducto { get; set; }
        public string stock { get; set; }
        public string codigoReferencia { get; set; }
        public string viadmin { get; set; }
        public string presentacion { get; set; }
        public string grupoT { get; set; }
        public string lab { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string grupo { get; set; }
        public int tipoProductoId { get; set; }
        public string dosis { get; set; }
        public string precio_5 { get; set; }
        public string activoYConcentracion { get; set; }
        public string imagen { get; set; }

    }
}