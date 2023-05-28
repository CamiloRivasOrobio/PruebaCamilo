using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Database.Shared.Models
{
    public class Sucursal
    {

        public Sucursal()
        {
        }
        public int Id { get; set; }
        public string NombreSucursal { get; set; }
        public bool Eliminado {get; set;} = false;
        
    }
}