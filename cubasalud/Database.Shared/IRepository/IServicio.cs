using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using Database.Shared.Data;

namespace Database.Shared.IRepository
{
    public interface IServicio
    {
        public void Add(Servicio servicio, bool saveChanges = true);
        public List<ListadoServiciosIdYNombres> GetList();
        public Servicio GetNombre(string nombre, bool includeRelatedEntities = true);
        public IList<Servicio> BuscarPorNombreBusquedaAjax(string searchString);
        public Servicio Get(int id, bool includeRelatedEntities = true);
        public void Update(Servicio servicio, bool saveChanges = true);
        public IList<Servicio> GetListaServicios();
        public void ActualizarInventarioVentaServicio(int servicioId);
    }
}