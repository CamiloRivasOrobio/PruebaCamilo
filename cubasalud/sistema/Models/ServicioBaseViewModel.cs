using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;

namespace sistema.Models
{
    public class ServicioBaseViewModel
    {
        public int? Id { get; set; }
        public string NombreServicio { get; set; }
        public decimal Precio { get; set; }
        public decimal Precio_2 { get; set; }
        public decimal Precio_3 { get; set; }
        public decimal Precio_4 { get; set; }
        public string Descripcion { get; set; }

        public List<InsumoServicioBaseViewModel> InsumosUtilizados { get; set; }

        public VentaServicio ventaServicio { get; set; } = new VentaServicio();
        public IList<DetalleServicio> DetalleServicios { get; set; }
        public bool Modificar { get; set; }
    }
    public class InsumoServicioBaseViewModel
    {
        public int? Id { get; set; }
        public int ProductoId { get; set; }
        public int UnidadMedidaVentaId { get; set; }
        public decimal CantidadUtilizada { get; set; }
    }
}