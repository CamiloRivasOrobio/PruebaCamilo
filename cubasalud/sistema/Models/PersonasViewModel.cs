using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using Database.Shared.Data;
using System;

namespace sistema.Models
{
    public class PersonasViewModel
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string TipoRedSocial { get; set; }
        public int SexoId { get; set; }
        public SelectList SexoSelectListItems { get; set; }
        public int? TipificacionComunicacionId { get; set; }
        public SelectList TipificacionComunicacionSelectListItems { get; set; }
        public string Email { get; set; }
        public DateTime FechaContacto { get; set; }
        public bool TomaServicio { get; set; }
        public string MotivoNoTomarServicio { get; set; }

        public void Init(IPersonas personasRepository)
        {
            SexoSelectListItems = new SelectList(personasRepository.GetSexosList(), "Id", "DescripcionSexo");
            TipificacionComunicacionSelectListItems = new SelectList(personasRepository.GetTipificacionesComunicacion(),
                "Id", "NombreTipificacion");
        }
    }
}