using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Paciente
    {
        public Paciente()
        {
            Venta = new List<Venta>();
            Citas = new List<Citas>();
            Examenes = new List<Examen>();
            PatologiasPaciente = new List<PatologiaPaciente>();
            VacunasPaciente = new List<VacunaPaciente>();
            CuentasPorCobrar = new List<CuentaPorCobrar>();
            PacientesSeguimientosNutricionales = new List<PacienteSeguimientoNutricional>();
            PacientesFasesTratamiento = new List<PacienteFaseTratamiento>();
            PacientesAntecedentesPersonales = new List<PacienteAntecedentePersonal>();
            PacientesSeguimientosNutricionales = new List<PacienteSeguimientoNutricional>();
            PacientesPreguntasRegistro = new List<PacientePreguntaRegistro>();
            PersonasSeguro = new List<PersonaSeguro>();
            PacienteHistorial = new List<PacienteHistorial>();
            PacienteArchivos = new List<PacienteArchivo>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Alias { get; set; }
        public string no_IGGS { get; set; }
        public bool esta_Afiliado { get; set; } = false;
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public bool Eliminado { get; set; }
        public int? SexoId { get; set; }
        public Sexo Sexo { get; set; }
        public int? SeguroEpssId { get; set; }
        public SeguroEpss SeguroEpss { get; set; }
        public string CodigoEPS { get; set; }
        public string Religion { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string ContactoEmergencia { get; set; }
        public string NumeroContactoEmergencia { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string Nacionalidad { get; set; }
        public string PaisResidencia { get; set; }
        public string DepartamentoResidencia { get; set; }
        public string MunicipioResidencia { get; set; }
        public string TipoDeSangre { get; set; }
        public string Email { get; set; }
        public string Contrasennia { get; set; }
        public string Dpi { get; set; }
        public bool? TieneMembresia { get; set; }
        public DateTime? FechaInicioMembresia { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? TipoPacienteId { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
        public int? EstadoPacienteId { get; set; }
        public EstadoPaciente EstadoPaciente { get; set; }
        public DateTime? FechaRetomaServicio { get; set; }
        public string ModalidadAtencion { get; set; } //presencial, virtual
        public string UrlFotografiaPaciente { get; set; }
        public string UrlFirmaRegistro { get; set; }
        public string UrlFirmaPoliticas { get; set; }
        public string UrlFirmaConsentimiento { get; set; }
        public string UrlFirmaTarjetaCredito { get; set; }


        //Información de nacimiento
        public string PesoAlNacer { get; set; }
        public string Talla { get; set; }
        public string CircunferenciaCefalica { get; set; }
        public string TipoParto { get; set; } //normal, cesarea





        //Antecedentes personales y patologicos
        public string AntecedentesPersonalesObservaciones { get; set; }
        public string AntecedentesPersonalesOtros { get; set; }



        //Alergias
        public string AlergiaAnestesiaLocal { get; set; }
        public string AlergiaAspirina { get; set; }
        public string AlergiaPenicilina { get; set; }
        public string AlergiaBarbiturios { get; set; }
        public string AlergiaSulfas { get; set; }
        public string AlergiaCodeina { get; set; }
        public string AlergiaMetales { get; set; }
        public string AlergiaLatex { get; set; }
        public string AlergiaYodo { get; set; }
        public string AlergiaPolen { get; set; }
        public string AlergiaAnimales { get; set; }
        public string AlergiaAlimentos { get; set; }
        public string AlergiaOtros { get; set; }
        public string AlergiaOtrosDescripcion { get; set; }

        //Informacion medica
        public string MedicaUsaLentesContacto { get; set; }
        public string MedicaUsaLentesContactoDescripcion { get; set; }
        public string MedicaArticulacionesArtificiales { get; set; }
        public DateTime? MedicaArticulacionesArtificialesFecha { get; set; }
        public string MedicaArticulacionesArtificialesComplicaciones { get; set; }
        public string MedicaTomaAlendronato { get; set; }
        public DateTime? MedicaTomaAlendronatoFecha { get; set; }
        public string MedicaTratamientoDolorHuesos { get; set; }
        public DateTime? MedicaTratamientoDolorHuesosFechaInicio { get; set; }
        public string MedicaTratamientoDolorHuesosDescripcionCaso { get; set; }
        public string MedicaSustanciasReguladorasDrogas { get; set; }
        public DateTime? MedicaSustanciasReguladorasDrogasFecha { get; set; }
        public string MedicaUsaTabaco { get; set; }
        public string MedicaBebidasAlcoholicas { get; set; }
        public string MedicaBebidasAlcoholicasDescripcion { get; set; }
        //Información dental
        public string DentalSangradoCepillar { get; set; }
        public string DentalDolorFrio { get; set; }
        public string DentalDolorPresionar { get; set; }
        public string DentalObjetosAtorados { get; set; }
        public string DentalBocaSeca { get; set; }
        public string DentalTratamientoPeriondal { get; set; }
        public string DentalTratamientoOrtodoncia { get; set; }
        public string DentalProblemasTratamientoDental { get; set; }
        public string DentalProblemasTratamientoDentalDescripcion { get; set; }
        public string DentalFluoradaAguaDomicilio { get; set; }
        public string DentalBebeAguaFiltrada { get; set; }
        public string DentalDolorOidos { get; set; }
        public string DentalMolestiaRuidoAlto { get; set; }
        public string DentalMolestiaRuidoAltoDescripcion { get; set; }
        public string DentalBrumismo { get; set; }
        public string DentalLesiones { get; set; }
        public string DentalLesionesDescripcion { get; set; }
        public string DentalDentaduraPlacas { get; set; }
        public string DentalDentaduraPlacasDescripcion { get; set; }
        public string DentalActividadesRecreacion { get; set; }
        public string DentalActividadesRecreacionDescripcion { get; set; }
        public string DentalLesionesCabeza { get; set; }
        public string DentalLesionesCabezaDescripcion { get; set; }

        //Análisis facial
        public string FacialPatron { get; set; }
        public string FacialPatronObservaciones { get; set; }
        public string FacialPerfil { get; set; }
        public string FacialPerfilObservaciones { get; set; }
        public string FacialAsimetria { get; set; }
        public string FacialAsimetriaObservaciones { get; set; }
        public string FacialAlturaFacialEquilibrada { get; set; }
        public string FacialAlturaFacialEquilibradaObservaciones { get; set; }
        public string FacialAnchoFacialEquilibrada { get; set; }
        public string FacialAnchoFacialEquilibradaObservaciones { get; set; }
        public string FacialPerfilMaxilar { get; set; }
        public string FacialPerfilMaxilarObservaciones { get; set; }
        public string FacialPerfilMandibular { get; set; }
        public string FacialPerfilMandibularObservaciones { get; set; }
        public string FacialSurcoLabialMenton { get; set; }
        public string FacialSurcoLabialMentonObservaciones { get; set; }
        public string FacialLabiosReposo { get; set; }

        //Análisis funcional
        public string FuncionalActividadComisurial { get; set; }
        public string FuncionalActividadLingual { get; set; }
        public string FuncionalLabioSuperior { get; set; }
        public string FuncionalLabioInferior { get; set; }
        public string FuncionalMasetero { get; set; }
        public string FuncionalMentoniano { get; set; }
        public string FuncionalRespiracion { get; set; }
        public string FuncionalDeglucion { get; set; }

        //Patrón facial - OPCIONES: patron-1,patron-2,patron-3,cara-corta,cara-larga
        public string PatronFacial { get; set; }
        //Caracteristica patron facial
        //OPCIONES: patron-2:   retrusion-mandibular,protrusion-maxilar,
        //                      aumento-afai,afai-disminuida
        //OPCIONES: patron-3:   protrusion-mandibular,retrusion-maxilar,
        //                      aumento-afai,afai-disminuida
        public string CaracteristicaPatronFacial { get; set; }

        //MEDICOS
        //Antecedentes
        public string AntecedentesMedicos { get; set; }
        public string AntecedentesQuirurgicos { get; set; }
        public string AntecedentesTraumaticos { get; set; }
        public string AntecedentesAlergias { get; set; }
        public string AntecedentesVicios { get; set; }
        public string AntecedentesMedicamentos { get; set; }


        //Pediatricos
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }


        //Información de la madre
        public DateTime? MadreFechaNacimiento { get; set; }
        public int? MadreEmbarazos { get; set; }
        public int? MadrePartosNormales { get; set; }
        public int? MadreCesareas { get; set; }
        public int? MadreAbortos { get; set; }
        public int? MadreHijosVivos { get; set; }
        public int? MadreHijosMuertos { get; set; }
        public string MadreComplicaciones { get; set; }

        //Historia medica
        public string HistoriaMedicoPersonal { get; set; }
        public string HistoriaTelefonoMedico { get; set; }
        public string HistoriaEspecialidadMedico { get; set; }
        public bool? HistoriaTratamientoMedico { get; set; }
        public bool? HistoriaSangraMuchoCortarse { get; set; }
        public bool? HistoriaHospitalizado { get; set; }
        public bool? HistoriaOperado { get; set; }
        public bool? HistoriaAlergiaMedicina { get; set; }
        public bool? HistoriaAlergiaComida { get; set; }
        public string HistoriaAlergiaOtros { get; set; }
        public bool? HistoriaProblemaEmocional { get; set; }
        public string HistoriaObservaciones { get; set; }

        public bool Retirado { get; set; }
        public DateTime? FechaRetiro { get; set; }


        //Datos de IGSS
        public string IgssTipoAfiliacion { get; set; }
        public string IgssNumeroAfiliacion { get; set; }
        public int? IgssCantidadDependientes { get; set; }
        public string IgssParentescoDependientes { get; set; }

        //Políticas de pago
        public bool? PoliticasPagoAceptaTerminos { get; set; }

        //Datos de pago
        public string NumeroTarjetaCredito { get; set; }


        public ICollection<PacienteHistorial> PacienteHistorial { get; set; }
        public ICollection<Venta> Venta { get; set; }
        public ICollection<VentaServicio> VentaServicio { get; set; } // no lo estoy usando, ver si es necesario quitar
        public ICollection<PatologiaPaciente> PatologiasPaciente { get; set; }
        public ICollection<VacunaPaciente> VacunasPaciente { get; set; }
        public ICollection<Citas> Citas { get; set; }
        public ICollection<Examen> Examenes { get; set; }
        public ICollection<CuentaPorCobrar> CuentasPorCobrar { get; set; }
        public ICollection<PacienteSeguimientoNutricional> PacientesSeguimientosNutricionales { get; set; }
        public ICollection<PacienteFaseTratamiento> PacientesFasesTratamiento { get; set; }
        public ICollection<PacienteAntecedentePersonal> PacientesAntecedentesPersonales { get; set; }
        public ICollection<PacientePreguntaRegistro> PacientesPreguntasRegistro { get; set; }
        public ICollection<PersonaSeguro> PersonasSeguro { get; set; }
        public ICollection<PacienteArchivo> PacienteArchivos { get; set; }

        public string sexoText
        {
            get { return Sexo == null ? "-" : Sexo.DescripcionSexo.ToString(); }
        }
        public string PacienteConIGSS
        {
            get { return string.IsNullOrEmpty(no_IGGS) ? $"{Nombre} -  afil.: / sin registro" : $"{Nombre} -  afil.: {no_IGGS}"; }
        }
        public string PacienteConCodigoEPS
        {
            get { return string.IsNullOrEmpty(CodigoEPS) ? $" CODIGO EPS: / sin registro" : $"CODIGO EPS: {CodigoEPS}"; }
        }
    }
}