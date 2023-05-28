using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;
using Database.Shared.Models;

namespace sistema.Models
{
    public class ExamenesRealizadosViewModel
    { 
        public int ExamenNumero {get;set;}
        public string Paciente {get;set;}
        public DateTime FechaRealizacion {get;set;}
        public string MedicoReferido {get;set;}
        public string ClinicaReferida {get;set;}
        public string Estado {get;set;}
        public string UsuarioSolicita {get;set;}
        public string UsuarioIngreso {get;set;}

    }
}