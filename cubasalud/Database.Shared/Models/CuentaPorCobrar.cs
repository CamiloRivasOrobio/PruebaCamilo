using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class CuentaPorCobrar
    {
        public int Id {get; set;}
        public int? PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime? FechaLimitePago { get; set; }
        public decimal? Valor { get; set; }
        public bool Pagada { get; set; }
        public DateTime? FechaPagoRealizado { get; set; }
        public string Observaciones { get; set; }
        public bool Eliminada { get; set; }

        public string NombrePacienteText {
            get { return Paciente == null || Paciente.Nombre == null ? "-" : Paciente.Nombre; }
        }
        public string DiasRestantesPagoText {
            get { return "Días"; }
        }
        public string PagadaText {
            get { return Pagada ? "Sí" : "No"; }
        }
    }
}