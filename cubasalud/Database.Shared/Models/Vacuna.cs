using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Vacuna
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
    }
}