using System.Runtime.CompilerServices;
using Database.Shared.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using System;
using Database.Shared.Paginacion;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema.Models
{
    public class ConsultasViewModel
    {
        public int? CitaId { get; set; }
        public int? ConsultaId { get; set; }
        public bool PrimeraConsulta { get; set; }
        public int? PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Servicio { get; set; }
        public int? EstadoPagoId { get; set; } = 2;
        public int? FaseTratamientoId { get; set; }
        public string MedicoAsignado { get; set; }
        public DateTime? FechaYHoraInicio { get; set; }
        public DateTime? FechaProximaConsulta { get; set; }
        //Paciente
        public string PacienteNombre { get; set; }
        public string PacienteNit { get; set; }
        public string PacienteDireccion { get; set; }
        public string PacienteAlias { get; set; }
        public string PacienteSexo { get; set; }
        public string PacienteFechaNacimiento { get; set; }
        public string PacienteEdad { get; set; }
        public string PacienteTelefono { get; set; }
        public string PacienteCelular { get; set; }
        public string PacienteMedicos { get; set; }
        public string PacienteQuirurgicos { get; set; }
        public string PacienteTraumaticos { get; set; }
        public string PacienteAlergias { get; set; }
        public string PacienteVicios { get; set; }
        public string PacienteMedicamentos { get; set; }

        public string ObservacionesAdicionales { get; set; }
        public decimal? CostoConsulta { get; set; }
        public decimal? CuentasPorCobrar { get; set; }
        public string UrlFiles { get; set; }
        public string TipoConsulta { get; set; } // puede ser Primera consulta, Reconsulta, Observacion
        public string TipoReferencia { get; set; } // hospital regional, medico particular
        public string MedicoReferido { get; set; } // el medico al que se refire

        //Historia
        public int? HistoriaId { get; set; }
        public string HistoriaProblema { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }

        //Ginecologico
        public string ExamenGinecologico { get; set; }

        //Neurologico
        public string ExamenNeurologico { get; set; }

        //Sistemas
        public string SistemaCardiopulmonar { get; set; }
        public string SistemaOsteoarticular { get; set; }
        public string SistemaHematologico { get; set; }

        //Sección solo para mujeres
        public string EstaEmbarazada { get; set; }
        public string NumeroSemanasEmbarazo { get; set; }
        public string TomaPildorasAnticonceptivas { get; set; }
        public string EstaAmamantando { get; set; }

        //Bebidas Alcoholicas
        public string BebeBebidasAlcoholicas { get; set; }
        public string AlcoholUltimas24Horas { get; set; }
        public string AlcoholSemanal { get; set; }

        //Dental
        public DateTime? FechaUltimaRadiografiaDental { get; set; }

        //Estetico
        public string Metabolismo { get; set; }
        public string Grasa { get; set; }
        public string IMC { get; set; }
        public string Agua { get; set; }
        public string Obesidad { get; set; }
        public string ContornoBrazos { get; set; }
        public string ContornoBusto { get; set; }
        public string ContornoAbdomen { get; set; }
        public string ContornoCadera { get; set; }
        public string ContornoPiernas { get; set; }
        public string Estatura { get; set; }

        public SelectList EstadosPagosLista { get; set; }
        public SelectList ServiciosSelectListItems { get; set; }
        public SelectList FasesTratamientoSelectListItems { get; set; }




        public void Init(ICitas citaRepository, IServicio _serviciosRepository, IPacientes _pacientesRepository)
        {
            ServiciosSelectListItems = new SelectList(_serviciosRepository.GetListaServicios(), "Id", "NombreServicio");
            EstadosPagosLista = new SelectList(citaRepository.EstadoPagosConsultasLista(), "Id", "Estado", 2);
            FasesTratamientoSelectListItems = new SelectList(_pacientesRepository.GetFasesTratamiento(), "Id", "NombreFase");
        }

        public DateTime? FechaUltimaConsulta { get; set; }
        public string MotivoUltimaConsulta { get; set; }

        //Examen físico
        public int? ExamenFisicoId { get; set; }
        public string ExamenFisicoTemperatura { get; set; }
        public string ExamenFisicoFrecuenciaRespiratoria { get; set; }
        public string ExamenFisicoFrecuenciaCardiaca { get; set; }
        public string ExamenFisicoSaturacionOxigeno { get; set; }
        public string ExamenFisicoPresionArterialBrazoDerecho { get; set; }
        public string ExamenFisicoPresionArterialBrazoIzquierdo { get; set; }
        public string ExamenFisicoPeso { get; set; }
        public string ExamenFisicoTalla { get; set; }
        public string ExamenFisicoIMC { get; set; }
        public string ExamenFisicoObservaciones { get; set; }
        public string ExamenFisicoGlucosa { get; set; }

        //Area terapeutica
        public string TerapeuticoDatosGenerales { get; set; }
        public string TerapeuticoActividadesDiarias { get; set; }
        public string TerapeuticoConQuienVive { get; set; }
        public string TerapeuticoHabitosAlimenticios { get; set; }
        public string TerapeuticoEjercicio { get; set; }
        public string TerapeuticoFinesSemana { get; set; }
        public string TerapeuticoHistoriaMedica { get; set; }
        public string TerapeuticoHistoriaPeso { get; set; }
        public List<HistoricoObservacionesTerapeuticoConsultaViewModel> TerapeuticoHistoricoObservaciones { get; set; }
        public string TerapeuticoObservaciones { get; set; }



        public List<ServicioAgregadoConsulta> ServiciosAgregados { get; set; }
        public List<CaracteristicasDiente> CaracteristicasDientes { get; set; }
        public List<SeguimientoNutricionalConsulta> SeguimientosNutricionales { get; set; }
        public List<VacunaPacienteConsulta> VacunasPaciente { get; set; }
        public List<RangoSaludableConsultaViewModel> RangosSaludables { get; set; }
        public List<RangoSaludableConsultaViewModel> RangosSaludablesHistorico { get; set; }
        //Examenes de laboratorio
        public List<ResultadoExamenLaboratorioConsultaViewModel> ExamenesLaboratorio { get; set; }
    }

    public class ServicioAgregadoConsulta
    {
        public int? Id { get; set; }
        public int? ConsultaId { get; set; }
        public int? ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public int? NumeroDiente { get; set; }
        public decimal? Precio { get; set; }
    }
    public class CaracteristicasDiente
    {
        public int NumeroDiente { get; set; }
        public bool Percusiones_VerticalMas { get; set; }
        public bool Percusiones_HorizontalMas { get; set; }
        public bool Percusiones_VerticalMenos { get; set; }
        public bool Percusiones_HorizontalMenos { get; set; }
        public bool Dolor_Localizado { get; set; }
        public bool Dolor_Fugaz { get; set; }
        public bool Dolor_Persistente { get; set; }
        public bool Dolor_Referido { get; set; }
        public bool Dolor_Espontaneo { get; set; }
        public bool Estimulo_Frio { get; set; }
        public bool Estimulo_Calor { get; set; }
        public bool Estimulo_DulceAcido { get; set; }
        public bool Estimulo_Masticacion { get; set; }
        public bool Estimulo_Otro { get; set; }
        public bool TermicaFrio_Positiva { get; set; }
        public bool TermicaFrio_Negativa { get; set; }
        public bool TermicaFrio_Localizada { get; set; }
        public bool TermicaFrio_Fugaz { get; set; }
        public bool TermicaFrio_Incrementa { get; set; }
        public bool TermicaFrio_Referida { get; set; }
        public bool TermicaFrio_Irradiado { get; set; }
        public bool TermicaFrio_Persistente { get; set; }
        public bool TermicaFrio_Decrece { get; set; }
        public bool TermicaCalor_Positiva { get; set; }
        public bool TermicaCalor_Negativa { get; set; }
        public bool TermicaCalor_Localizada { get; set; }
        public bool TermicaCalor_Fugaz { get; set; }
        public bool TermicaCalor_Incrementa { get; set; }
        public bool TermicaCalor_Referida { get; set; }
        public bool TermicaCalor_Irradiado { get; set; }
        public bool TermicaCalor_Persistente { get; set; }
        public bool TermicaCalor_Decrece { get; set; }
        public bool Diagnostico_ManchaBlanca { get; set; }
        public bool Diagnostico_Caries { get; set; }
        public bool Diagnostico_Traumatismo { get; set; }
        public bool Diagnostico_Abfraccion { get; set; }
        public bool Diagnostico_Atricion { get; set; }
        public bool Diagnostico_Erosion { get; set; }
        public bool Diagnostico_Restauracion { get; set; }
        public bool Diagnostico_Ajustada { get; set; }
        public bool Diagnostico_Desajustada { get; set; }
        public bool Diagnostico_PulpaSana { get; set; }
        public bool Diagnostico_PulpitisReversible { get; set; }
        public bool Diagnostico_PulpitisIrreversible { get; set; }
        public bool Diagnostico_NecrosisPulpar { get; set; }
    }
    public class SeguimientoNutricionalConsulta
    {
        public int? Id { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Nuevo { get; set; }
        public decimal? Peso { get; set; }
        public decimal? IMC { get; set; }
        public decimal? PGC { get; set; }
        public decimal? Cuello { get; set; }
        public decimal? Busto { get; set; }
        public decimal? CinturaAbdomen { get; set; }
        public decimal? Cadera { get; set; }
        public decimal? Muslo { get; set; }
        public decimal? Brazo { get; set; }
        public decimal? Munneca { get; set; }
    }
    public class VacunaPacienteConsulta
    {
        public int? VacunaPacienteId { get; set; }
        public int? VacunaId { get; set; }
        public string NombreVacuna { get; set; }
        public bool? Primera { get; set; }
        public DateTime? FechaPrimera { get; set; }
        public bool? Segunda { get; set; }
        public DateTime? FechaSegunda { get; set; }
        public bool? Tercera { get; set; }
        public DateTime? FechaTercera { get; set; }
        public bool? PrimerRefuerzo { get; set; }
        public DateTime? FechaPrimerRefuerzo { get; set; }
        public bool? SegundoRefuerzo { get; set; }
        public DateTime? FechaSegundoRefuerzo { get; set; }
    }
    public class HistoricoObservacionesTerapeuticoConsultaViewModel
    {
        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }
    }
    public class ResultadoExamenLaboratorioConsultaViewModel
    {
        public int? Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string GlucosaPre { get; set; }
        public string GlucosaPos { get; set; }
        public string HemoglobinaGlicosilada { get; set; }
        public string CurvaGlucosa { get; set; }
        public string ColesterolTotal { get; set; }
        public string Trigliceridos { get; set; }
        public string PerfilLipidico { get; set; }
        public string Creatinina { get; set; }
        public string AcidoUrico { get; set; }
        public string Hemoglobina { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string ExamenHeces { get; set; }
        public string ExamenOrina { get; set; }
        public string Otros { get; set; }
        public string UrlResultados { get; set; }
    }
    public class RangoSaludableConsultaViewModel
    {
        public int? Id { get; set; }
        public int? PacienteId { get; set; }
        public DateTime? Fecha { get; set; }
        public string IMC { get; set; }
        public string Peso { get; set; }
        public string PorcentajeGrasaCorporal { get; set; }
    }
}