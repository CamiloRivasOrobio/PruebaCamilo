using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using Database.Shared.DataBindings;
using Database.Shared.Data;
using Database.Shared.Enumeraciones;

namespace Database.Shared.IRepository
{
    public interface IProducto
    {
        public void Add(Producto producto, bool saveChanges = true);
        public List<Producto> GetList();
        IList<Producto> GetProductos(int tipoBodega, int tipoProducto, bool eliminados = false);
        public List<Producto> GetListPdf();
        public IList<Producto> GetListado();
        public IList<Producto> GetListadoFaltantesFarmacia(string searchString);
        public IList<Producto> GetListadoFaltantesClinica(string searchString);
        public Producto Get(int id, bool includeRelatedEntities = true);
        public Producto GetPorNumeroDeReferencia(string id, bool includeRelatedEntities = true);
        public IList<Producto> GetPorNumeroDeReferenciaList(string id, bool includeRelatedEntities = true);

        public Producto GetPorNumeroDeReferenciayNombre(string id, bool includeRelatedEntities = true);
        public IList<RetornoProductoPOS> BuscarPorNombreYReferenciaBusquedaAjax(string searchString);
        public void Update(Producto producto, bool saveChanges = true);
        public void SaveChanges();
        public PaginacionList<Producto> PaginacionProductosFarmaciaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public PaginacionList<Producto> PaginacionProductosFarmaciaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);
        public PaginacionList<Producto> PaginacionProductosClinicaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public List<Producto> GetInventarioProductos(int tipoBodega, int tipoProducto, int? categoriaId, bool eliminado = false);
        PaginacionList<Producto> PaginacionBodegaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public PaginacionList<Producto> PaginacionProductosFaltantes(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProductosVencimiento(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public IList<ProductoYCodigo> GetListParaCotizacion();
        public Producto GetProdutoById(int id);
        public Producto GetProductoByTipoBodegaAndNombre(int tipoBodega, string nombre);
        public Producto GetPorNumeroDeReferenciaClinica(string id, bool includeRelatedEntities = true);
        public IList<RetornoProductoPOSClinica> BuscarPorNombreYReferenciaBusquedaAjaxClinica(string searchString);
        public IList<Producto> GetListadoProductos();
        public List<Producto> GetProductos();
        IList<Producto> GetListadoProductosBodega();
        public IList<Producto> FiltrarPorBusquedaYTerapeutico(string searchString, int? terapeuticoId, int tipoBodega);
        public IList<Producto> FiltrarPorBusquedaYCategoria(string searchString, int? categoriaId, int tipoBodega);
        public PaginacionList<Producto> PaginacionProductosFaltantesClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionVencidosFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProximosAVencerFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionVencidosClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProximosAVencerClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        Producto GetByName(string producto, bool includeRelatedEntities = true);
        int GetTotalMedicamentosFarmacia();
        int GetTotalInsumosFarmacia();

        int GetTotalMedicamentosClinica();
        public int GetTotalInsumosClinica(int? categoriaId);

        int GetTotalMedicamentosBodega();
        int GetTotalInsumosBodega();
        IList<Producto> GetProductosLaboratorio(int? laboratorioId = null);

        PaginacionList<Producto> PaginacionProductosBodegaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);

        IList<Producto> GetMedicamentosFarmaciaList();


        PaginacionList<Producto> PaginacionProductosLabMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        int GetTotalMedicamentosLab();
        PaginacionList<Producto> PaginacionProductosLabInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);
        int GetTotalInsumosLab();
        PaginacionList<Producto> PaginacionProductosFaltantesLab(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<Producto> PaginacionVencidosLab(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<Producto> PaginacionProximosAVencerLab(string sortOrder, string searchString, int? pageNumber, int pageSize);
        IList<Producto> GetListadoFaltantesLab(string searchString);

        #region Consulta de unidades
        List<UnidadMedidaCompra> GetUnidadesCompra();
        List<UnidadMedidaVenta> GetUnidadesVenta();
        #endregion
        List<ProductoEquivalencia> GetEquivalenciasProducto(int productoId);
    }
}