using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Consulta
    {
        public Consulta()
        {
            ConsultasCaracteristicasDentales = new List<ConsultaCaracteristicaDental>();
            ConsultasServicios = new List<ConsultaServicio>();
        }
        public int Id { get; set; }
        public int? CitasId { get; set; }
        public int? HistoriaId { get; set; }
        public int? ExamenFisicoId { get; set; }
        public string ObservacionesAdicionales { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoConsulta { get; set; }
        public DateTime FechaYHoraInicioConsulta { get; set; }
        public DateTime? FechaProximaConsulta { get; set; }
        public bool Archivado { get; set; }
        public int EstadoPagoConsultaId { get; set; }
        public EstadoPagoConsulta EstadoPagoConsulta { get; set; }
        public int? FaseTratamientoId { get; set; }
        public FaseTratamiento FaseTratamiento { get; set; }
        public string UrlFiles { get; set; }
        public string ExamenGinecologico { get; set; }
        public string ExamenNeurologico { get; set; }
        public string SistemaCardiopulmonar { get; set; }
        public string SistemaOsteoarticular { get; set; }
        public string SistemaHematologico { get; set; }
        public string TipoConsulta { get; set; } // puede ser Primera consulta, Reconsulta, Observacion
        public string TipoReferencia { get; set; } // hospital regional, medico particular
        public string MedicoReferido { get; set; } // el medico al que se refire

        // public Historia Historia {get;set;}
        public Citas Citas { get; set; }
        public Historia Historia { get; set; }
        public ExamenFisico ExamenFisico { get; set; }

        //Sección solo para mujeres
        public string EstaEmbarazada { get; set; }
        public int? NumeroSemanasEmbarazo { get; set; }
        public string TomaPildorasAnticonceptivas { get; set; }
        public string EstaAmamantando { get; set; }

        //Bebidas Alcoholicas
        public string BebeBebidasAlcoholicas { get; set; }
        public string AlcoholUltimas24Horas { get; set; }
        public string AlcoholSemanal { get; set; }

        //Dental
        public DateTime? FechaUltimaRadiografiaDental { get; set; }

        //Caracteristicas dentales
        public ICollection<ConsultaCaracteristicaDental> ConsultasCaracteristicasDentales { get; set; }

        //Estetico
        public string Estetico_Metabolismo { get; set; }
        public string Estetico_Grasa { get; set; }
        public string Estetico_IMC { get; set; }
        public string Estetico_Agua { get; set; }
        public string Estetico_Obesidad { get; set; }
        public string Estetico_ContornoBrazos { get; set; }
        public string Estetico_ContornoBusto { get; set; }
        public string Estetico_ContornoAbdomen { get; set; }
        public string Estetico_ContornoCadera { get; set; }
        public string Estetico_ContornoPiernas { get; set; }
        public string Estetico_Estatura { get; set; }

        //Area terapeutica
        public string TerapeuticoDatosGenerales { get; set; }
        public string TerapeuticoActividadesDiarias { get; set; }
        public string TerapeuticoConQuienVive { get; set; }
        public string TerapeuticoHabitosAlimenticios { get; set; }
        public string TerapeuticoEjercicio { get; set; }
        public string TerapeuticoFinesSemana { get; set; }
        public string TerapeuticoHistoriaMedica { get; set; }
        public string TerapeuticoHistoriaPeso { get; set; }
        public string TerapeuticoObservaciones { get; set; }

        //Servicios
        public ICollection<ConsultaServicio> ConsultasServicios { get; set; }

    }

}