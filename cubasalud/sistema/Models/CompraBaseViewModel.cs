using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using Database.Shared.Data;
using System;

namespace sistema.Models
{
    public class CompraBaseViewModel
    {
        public int? CompraId { get; set; }
        public bool EstadoCompra { get; set; }

        //Encabezado
        public string EncabezadoNoComprobante { get; set; }
        public int EncabezadoEmpleadoId { get; set; }
        public string EncabezadoProveedor { get; set; }
        public SelectList ListaProveedores { get; set; }
        public DateTime EncabezadoFechaLimite { get; set; }
        public string EncabezadoObservacion { get; set; }
        public int EncabezadoTipoCompraId { get; set; }
        public SelectList ListaTipoCompra { get; set; }

        //Detalles
        public List<ProductoCompradoViewModel> ProductosComprados { get; set; }

        public void Init(IProveedor proveedorRepository, ICompra compraRepository)
        {
            ListaProveedores = new SelectList(proveedorRepository.GetList(), "Nombre", "Nombre");
            ListaTipoCompra = new SelectList(compraRepository.TipoCompraLista(), "Id", "Tipo");
        }


        //Campos pendientes normalización
        public SelectList ListaEmpleados { get; set; }
        public Recepcion Recepcion { get; set; } = new Recepcion();


    }
    public class ProductoCompradoViewModel
    {
        public int? Id { get; set; }
        public int ProductoId { get; set; }
        public UnidadMedidaCompraViewModel UnidadMedidaCompra { get; set; }
        public List<UnidadMedidaVentaCompraViewModel> UnidadesMedidaVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Total { get; set; }
        public bool Nuevo { get; set; }
    }
    public class UnidadMedidaVentaCompraViewModel
    {
        public int Id { get; set; }
        public string NombreUnidad { get; set; }
        public string Equivalencia { get; set; }
        public decimal Precio { get; set; }
        public decimal Precio_2 { get; set; }
    }

    public class UnidadMedidaCompraViewModel
    {
        public int Id { get; set; }
        public string NombreUnidad { get; set; }
        public string Abreviatura { get; set; }
    }
}