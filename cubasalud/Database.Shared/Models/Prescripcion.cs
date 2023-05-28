using System;
using Database.Shared.Models;
using System.Collections.Generic;

namespace Database.Shared.Models
{
    public class Prescripcion
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public Consulta Consulta { get; set; }
        public DateTime NextDate { get; set; }

        public List<DetallePrescripcion> DetallePrescripcion { get; set; }
    }
}
