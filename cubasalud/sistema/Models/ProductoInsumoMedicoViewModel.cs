using Database.Shared.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace sistema.Models
{
    public class ProductoInsumoMedicoViewModel
    {
        public int? Id { get; set; }
        public string CodigoReferencia { get; set; }
        public string Nombre { get; set; }
        public List<EquivalenciaProductoInsumoMedicoViewModel> Equivalencias { get; set; }
        public int? CategoriaId { get; set; }
        public SelectList CategoriasSelectListItems { get; set; }
        public int? MarcaId { get; set; }
        public SelectList MarcaSelectListItems { get; set; }
        public int? GrupoId { get; set; }
        public SelectList GruposSelectListItems { get; set; }
        public int? PresentacionId { get; set; }
        public SelectList PresentacionSelectListItems { get; set; }
        public string UrlImagen { get; set; }
        public string Descripcion { get; set; }

        public void Init(IDespegablesProducto categoriaRepository)
        {
            CategoriasSelectListItems = new SelectList(categoriaRepository.ListaCategorias(), "Id", "NombreCategoria");
            MarcaSelectListItems = new SelectList(categoriaRepository.ListaMarcas(), "Id", "NombreMarca");
            GruposSelectListItems = new SelectList(categoriaRepository.ListaGrupos(), "Id", "NombreGrupo");
            PresentacionSelectListItems = new SelectList(categoriaRepository.ListarPresentacion(), "Id", "PresentProducto");
        }
    }
    public class EquivalenciaProductoInsumoMedicoViewModel
    {
        public int? Id { get; set; }
        public int? ProductoId { get; set; }
        public int UnidadMedidaCompraId { get; set; }
        public int UnidadMedidaCompraNombre { get; set; }
        public decimal PrecioUnidadCompra { get; set; }
        public int UnidadMedidaVentaId { get; set; }
        public int UnidadMedidaVentaNombre { get; set; }
        public decimal CantidadEquivalente { get; set; }
        public decimal PrecioUnidadVenta { get; set; }
        public decimal PrecioUnidadVenta_1 { get; set; }
    }
}
