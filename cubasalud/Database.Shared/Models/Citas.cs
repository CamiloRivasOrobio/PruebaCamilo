using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Citas
    {
        public Citas()
        {
            Consultas = new List<Consulta>();
        }

        public int Id { get; set; }

        // public int? TipoEspecialidadId {get;set;}
        public int? EspecialidadId { get; set; }
        public int? PacienteId { get; set; }
        public int? ServicioId { get; set; }
        public int? EmpleadoId { get; set; }
        public int? UserId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Motivo { get; set; }
        public int? Edad { get; set; }
        public string NombreEncargado { get; set; }
        public bool Eliminado { get; set; }
        public bool Finalizada { get; set; }
        public bool EsMenorDeEdad { get; set; }
        public string EstadoCita { get; set; }
        public string NombreMedicoTemporal { get; set; }

        public string CodigoDeCita { get; set; }
        public string CodigoAutorizacion { get; set; }
        public bool? Bloqueada { get; set; }

        // public TipoEspecialidad TipoEspecialidad {get;set;}
        public Especialidad Especialidad { get; set; }
        public Paciente Paciente { get; set; }
        public Servicio Servicio { get; set; } // duda
        public Empleado Empleado { get; set; }
        public User User { get; set; }

        public ICollection<Consulta> Consultas { get; set; }



        public string EspecialidadText
        {
            get { return Especialidad == null ? "Sín Asignar" : Especialidad.NombreEspecialidad.ToString(); }
        }
        public string ClienteText
        {
            get { return Paciente == null ? "Sin Asignar" : Paciente.Nombre.ToString(); }
        }

        public string PersonText
        {
            get { return User == null || User.Persona == null ? "Sin Asignar" : User.Persona.NombreYApellidos; }
        }

        public string EmpleadoText
        {
            get { return Empleado == null ? "Sin Asignar" : Empleado.NombreYApellidos; }
        }

        public string ServicioText
        {
            get { return Servicio == null ? "Sin Asignar" : Servicio.NombreServicio; }
        }


        public string EsMenorDeEdadText
        {
            get { return EsMenorDeEdad ? "Si" : "No"; }
        }
    }
}