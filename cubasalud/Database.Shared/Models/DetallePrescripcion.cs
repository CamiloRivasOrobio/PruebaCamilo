using System;
using Database.Shared.Models;

namespace Database.Shared.Models
{
    public class DetallePrescripcion
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public string Medicine { get; set; }
        public string Qty { get; set; }
        public string Indications { get; set; }
        public int PrescripcionId { get; set; }
        public Prescripcion Prescripcion { get; set; }
    }
}
