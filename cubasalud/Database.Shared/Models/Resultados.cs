using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Resultados
    {

        public Resultados()
        {
        }

        public int Id { get; set; }
        public int? DatosExamenesLabClinicoId {get;set;}
        public int? DetalleExamenId {get;set;}
        public string ValorResultado {get;set;}

        public DatosExamenesLabClinico  DatosExamenesLabClinico {get;set;}
        public DetalleExamen DetalleExamen {get;set;}


    }
}