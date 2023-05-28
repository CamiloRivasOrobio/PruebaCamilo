using System;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Database.Shared.IRepository;
using Database.Shared.Data;

namespace Database.Shared
{
    public partial class Context : IdentityDbContext<IdentityUser>
    {
        // EmpleadoRepository repo = null;
        // public Empleado emp => repo.Get(1);
        public string ConnectionString { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            // repo = new EmpleadoRepository(this);
            // this.Database.EnsureCreated();
            // this.Database.EnsureCreated();
        }
        public DbSet<ConfiguracionSistema> ConfiguracionesSistema { get; set; }
        public DbSet<AccionPaciente> AccionesPaciente { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PacienteHistorial> PacientesHistorial { get; set; }
        public DbSet<PacienteArchivo> PacienteArchivos { get; set; }
        public DbSet<EstadoPaciente> EstadosPaciente { get; set; }
        public DbSet<TipoPaciente> TiposPacientes { get; set; }
        public DbSet<PacienteSeguimientoNutricional> PacientesSeguimientosNutricionales { get; set; }
        public DbSet<PacienteRangoSaludable> PacientesRangosSaludables { get; set; }
        public DbSet<PacienteResultadoExamenLaboratorio> PacientesResultadosExamenesLaboratorio { get; set; }
        public DbSet<PacienteAntecedentePersonal> PacientesAntecedentesPersonales { get; set; }
        public DbSet<AntecedentePersonal> AntecedentesPersonales { get; set; }
        public DbSet<PacientePreguntaRegistro> PacientesPreguntasRegistro { get; set; }
        public DbSet<PreguntaRegistro> PreguntasRegistro { get; set; }
        public DbSet<SeguroEpss> SegurosEpss { get; set; }
        public DbSet<CuentaPorCobrar> CuentasPorCobrar { get; set; }
        public DbSet<TipoPatologia> TipoPatologias { get; set; }
        public DbSet<PatologiaPaciente> PatologiasPacientes { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoInventario> ProductosInventario { get; set; }
        public DbSet<UnidadMedidaCompra> UnidadesMedidaCompra { get; set; }
        public DbSet<UnidadMedidaVenta> UnidadesMedidaVenta { get; set; }
        public DbSet<ProductoEquivalencia> ProductosEquivalencias { get; set; }
        public DbSet<ViaAdministracions> ViaAdministracions { get; set; }
        public DbSet<Viadmin> viadmins { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<PresentacionProducto> PresentacionProductos { get; set; }
        public DbSet<GrupoTProducto> GrupoTProductos { get; set; }
        public DbSet<LaboratorioProducto> LaboratorioProductos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<TipoCompra> TipoCompra { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Recepcion> Recepciones { get; set; }
        public DbSet<EstadoRecepcion> EstadoRecepciones { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ServicioInsumo> ServiciosInsumos { get; set; }
        public DbSet<VentaServicio> VentaServicios { get; set; }
        public DbSet<DetalleServicio> DetalleServicios { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<EstadosEnvio> EstadosEnvio { get; set; }
        public DbSet<DetalleEnvio> DetalleEnvios { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<DetalleCaja> DetalleCajas { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<CategoriaGasto> CategoriasGastos { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<FormaPago> FormaPagos { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<DetalleCotizacion> DetalleCotizaciones { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Citas> Citass { get; set; }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<ConsultaServicio> ConsultasServicios { get; set; }
        public DbSet<ConsultaCaracteristicaDental> ConsultasCaracteristicasDentales { get; set; }
        public DbSet<EstadoPagoConsulta> EstadoPagoConsultas { get; set; }
        public DbSet<Prescripcion> Prescripciones { get; set; }
        public DbSet<DetallePrescripcion> DetallePrescripcion { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<ExamenFisico> ExamenFisico { get; set; }


        public DbSet<TipoEspecialidad> TipoEspecialidads { get; set; }
        public DbSet<Especialidad> Especialidads { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<TrasladosProductos> TrasladosProductos { get; set; }
        public DbSet<EstadoTraslados> EstadoTraslados { get; set; }
        public DbSet<DetalleTrasladoProductos> DetalleTrasladoProductos { get; set; }
        public DbSet<TipoBodega> TipoBodegas { get; set; }
        public DbSet<CajaClinica> CajaClinicas { get; set; }
        public DbSet<DetalleCajaClinica> DetalleCajaClinicas { get; set; }


        // laboratorio clinico

        public DbSet<CategoriaLabClinico> CategoriaLabClinicos { get; set; }
        public DbSet<ExamenLabClinico> ExamenLabClinicos { get; set; }
        public DbSet<DatosExamenesLabClinico> DatosExamenesLabClinicos { get; set; }
        public DbSet<DetalleExamen> DetalleExamenes { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<VentasLab> VentasLabs { get; set; }
        public DbSet<EstadoExamen> EstadoExamenes { get; set; }
        public DbSet<DetalleCajaLab> DetalleCajaLab { get; set; }
        public DbSet<CajaLab> CajaLab { get; set; }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Resultados> Resultados { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<VacunaPaciente> VacunasPacientes { get; set; }
        public DbSet<PersonaSeguro> PersonasSeguro { get; set; }
        //Personas
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipificacionComunicacion> TipificacionesComunicacion { get; set; }
        public DbSet<FaseTratamiento> FasesTratamiento { get; set; }
        public DbSet<PacienteFaseTratamiento> PacientesFasesTratamiento { get; set; }
        public DbSet<Grabacion> Grabaciones { get; set; }
        // public DbSet<Role> Roles { get; set; }
        // public DbSet<IdentityUser> IdentityUsers {get;set;}
        //Repositorio de archivos
        public DbSet<RepositorioCarpeta> RepositorioCarpetas { get; set; }
        public DbSet<RepositorioArchivo> RepositorioArchivos { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfiguracionSistema>().ToTable("ConfiguracionesSistema");
            modelBuilder.Entity<AccionPaciente>().ToTable("AccionesPaciente");
            modelBuilder.Entity<Paciente>().ToTable("Pacientes");
            modelBuilder.Entity<PacienteHistorial>().ToTable("PacientesHistorial");
            modelBuilder.Entity<PacienteArchivo>().ToTable("PacientesArchivos");
            modelBuilder.Entity<EstadoPaciente>().ToTable("EstadosPaciente");
            modelBuilder.Entity<TipoPaciente>().ToTable("TiposPacientes");
            modelBuilder.Entity<PacienteSeguimientoNutricional>().ToTable("PacientesSeguimientosNutricionales");
            modelBuilder.Entity<PacienteRangoSaludable>().ToTable("PacientesRangosSaludables");
            modelBuilder.Entity<PacienteResultadoExamenLaboratorio>().ToTable("PacientesResultadosExamenesLaboratorio");
            modelBuilder.Entity<PacienteAntecedentePersonal>().ToTable("PacientesAntecedentesPersonales");
            modelBuilder.Entity<AntecedentePersonal>().ToTable("AntecedentesPersonales");
            modelBuilder.Entity<PacientePreguntaRegistro>().ToTable("PacientesPreguntasRegistro");
            modelBuilder.Entity<PreguntaRegistro>().ToTable("PreguntasRegistro");
            modelBuilder.Entity<SeguroEpss>().ToTable("SegurosEpss");
            modelBuilder.Entity<CuentaPorCobrar>().ToTable("CuentasPorCobrar");
            modelBuilder.Entity<TipoPatologia>().ToTable("TipoPatologias");
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<ProductoInventario>().ToTable("ProductosInventario");
            modelBuilder.Entity<UnidadMedidaCompra>().ToTable("UnidadesMedidaCompra");
            modelBuilder.Entity<UnidadMedidaVenta>().ToTable("UnidadesMedidaVenta");
            modelBuilder.Entity<ProductoEquivalencia>().ToTable("ProductosEquivalencias");
            modelBuilder.Entity<ViaAdministracions>().ToTable("ViaAdministracion");
            modelBuilder.Entity<Viadmin>().ToTable("Viadmin");
            modelBuilder.Entity<TipoProducto>().ToTable("TipoProductos");
            modelBuilder.Entity<PresentacionProducto>().ToTable("PresentacionProductos");
            modelBuilder.Entity<LaboratorioProducto>().ToTable("LaboratorioProductos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Marca>().ToTable("Marcas");
            modelBuilder.Entity<Venta>().ToTable("Ventas");
            modelBuilder.Entity<DetalleVenta>().ToTable("DetalleVentas");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<Compra>().ToTable("Compras");
            modelBuilder.Entity<DetalleCompra>().ToTable("DetalleCompras");
            modelBuilder.Entity<Recepcion>().ToTable("Recepciones");
            modelBuilder.Entity<EstadoRecepcion>().ToTable("EstadoRecepciones");
            modelBuilder.Entity<Servicio>().ToTable("Servicios");
            modelBuilder.Entity<ServicioInsumo>().ToTable("ServiciosInsumos");
            modelBuilder.Entity<VentaServicio>().ToTable("VentaServicios");
            modelBuilder.Entity<DetalleServicio>().ToTable("DetalleServicios");
            modelBuilder.Entity<Banco>().ToTable("Bancos");
            modelBuilder.Entity<Envio>().ToTable("Envios");
            modelBuilder.Entity<EstadosEnvio>().ToTable("EstadosEnvio");
            modelBuilder.Entity<DetalleEnvio>().ToTable("DetalleEnvios");
            modelBuilder.Entity<Ruta>().ToTable("Rutas");
            modelBuilder.Entity<Caja>().ToTable("Cajas");
            modelBuilder.Entity<DetalleCaja>().ToTable("DetalleCaja");
            modelBuilder.Entity<Gasto>().ToTable("Gastos");
            modelBuilder.Entity<CategoriaGasto>().ToTable("CategoriasGastos");
            modelBuilder.Entity<Pagos>().ToTable("Pagos");
            modelBuilder.Entity<FormaPago>().ToTable("FormaPagos");
            modelBuilder.Entity<Moneda>().ToTable("Monedas");
            modelBuilder.Entity<Cotizacion>().ToTable("Cotizaciones");
            modelBuilder.Entity<DetalleCotizacion>().ToTable("DetalleCotizaciones");
            modelBuilder.Entity<Cita>().ToTable("Citas");
            modelBuilder.Entity<Citas>().ToTable("Citass");
            modelBuilder.Entity<TipoEspecialidad>().ToTable("TipoEspecialidad");
            modelBuilder.Entity<Especialidad>().ToTable("Especialidad");
            modelBuilder.Entity<Sexo>().ToTable("Sexo");
            modelBuilder.Entity<TrasladosProductos>().ToTable("TrasladosProductos");
            modelBuilder.Entity<EstadoTraslados>().ToTable("EstadoTraslados");
            modelBuilder.Entity<DetalleTrasladoProductos>().ToTable("DetalleTraslado");
            modelBuilder.Entity<TipoBodega>().ToTable("TipoBodega");
            modelBuilder.Entity<GrupoTProducto>().ToTable("GrupoTProductos");
            modelBuilder.Entity<Grupo>().ToTable("Grupos");
            modelBuilder.Entity<Vacuna>().ToTable("Vacunas");
            modelBuilder.Entity<VacunaPaciente>().ToTable("VacunasPacientes");
            modelBuilder.Entity<PersonaSeguro>().ToTable("PersonasSeguro");
            modelBuilder.Entity<Persona>().ToTable("Personas");
            modelBuilder.Entity<TipificacionComunicacion>().ToTable("TipificacionesComunicacion");
            modelBuilder.Entity<Consulta>().ToTable("Consultas");
            modelBuilder.Entity<ConsultaServicio>().ToTable("ConsultasServicios");
            modelBuilder.Entity<ConsultaCaracteristicaDental>().ToTable("ConsultasCaracteristicasDentales");
            modelBuilder.Entity<Prescripcion>().ToTable("Prescripcion");
            modelBuilder.Entity<DetallePrescripcion>().ToTable("DetallePrescripcion");
            modelBuilder.Entity<FaseTratamiento>().ToTable("FasesTratamiento");
            modelBuilder.Entity<PacienteFaseTratamiento>().ToTable("PacientesFasesTratamiento");
            modelBuilder.Entity<Grabacion>().ToTable("Grabaciones");
            //Repositorio de archivos
            modelBuilder.Entity<RepositorioCarpeta>().ToTable("RepositorioCarpetas");
            modelBuilder.Entity<RepositorioArchivo>().ToTable("RepositorioArchivos");


            #region Configuraciones del sistema
            modelBuilder.Entity<ConfiguracionSistema>().HasData(new ConfiguracionSistema
            {
                Id = 1,
                Key = "nombre-establecimiento",
                Value = "Redowl software"
            });
            #endregion

            #region Estados de paciente
            modelBuilder.Entity<EstadoPaciente>().HasData(new EstadoPaciente
            {
                Id = 1,
                NombreEstado = "Activo"
            });
            modelBuilder.Entity<EstadoPaciente>().HasData(new EstadoPaciente
            {
                Id = 2,
                NombreEstado = "Inactivo"
            });
            #endregion

            #region Roles
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "d2716b4b-671d-4814-a04c-b51aa97051e8",
                Name = "Vendedor",
                NormalizedName = "VENDEDOR"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {

                Id = "785c160e-6a4f-4fd8-8121-4e6b2af230cd",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {

                Id = "ec320394-8501-4710-a2ae-85e04315a5f9",
                Name = "Cajero",
                NormalizedName = "CAJERO"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "4e725ea5-282e-401c-9e82-da4947e382ef",
                Name = "Mensajero",
                NormalizedName = "MENSAJERO"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {

                Id = "3c06eaf3-10d4-40ae-bd00-3d50d629cfde",
                Name = "Supervisor",
                NormalizedName = "SUPERVISOR"
            });
            #endregion

            #region Tipos de pacientes
            modelBuilder.Entity<TipoPaciente>().HasData(new TipoPaciente
            {
                Id = 1,
                NombreTipo = "Nuevo"
            });
            modelBuilder.Entity<TipoPaciente>().HasData(new TipoPaciente
            {
                Id = 2,
                NombreTipo = "Retomante"
            });
            #endregion

            #region Acciones de paciente
            modelBuilder.Entity<AccionPaciente>().HasData(new AccionPaciente
            {
                Id = 1,
                NombreAccion = "Registro"
            });
            modelBuilder.Entity<AccionPaciente>().HasData(new AccionPaciente
            {
                Id = 2,
                NombreAccion = "Retiro"
            });
            #endregion

            #region Formas de pago
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 1,
                NombreFormaPago = "Efectivo",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 2,
                NombreFormaPago = "Tarjeta de Débito",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 3,
                NombreFormaPago = "Tarjeta de Crédito",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 4,
                NombreFormaPago = "Cheques",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 5,
                NombreFormaPago = "Transferencia",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 6,
                NombreFormaPago = "Visa Link",
            });
            modelBuilder.Entity<FormaPago>().HasData(new FormaPago
            {
                Id = 7,
                NombreFormaPago = "Visa Net",
            });
            #endregion

            #region Monedas
            modelBuilder.Entity<Moneda>().HasData(new Moneda
            {
                Id = 1,
                NombreMoneda = "Dólar"
            });
            modelBuilder.Entity<Moneda>().HasData(new Moneda
            {
                Id = 2,
                NombreMoneda = "Quetzal"
            });
            #endregion

            #region Especialidades
            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 1,
                NombreEspecialidad = "Medicina general",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 2,
                NombreEspecialidad = "Medicina estética",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 3,
                NombreEspecialidad = "Ginecología y Obstetricia",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 4,
                NombreEspecialidad = "Pediatría",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 5,
                NombreEspecialidad = "Cirugía",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 6,
                NombreEspecialidad = "Traumatología",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 7,
                NombreEspecialidad = "Medicina interna",
            });


            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 8,
                NombreEspecialidad = "Laboratorio clínico",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 9,
                NombreEspecialidad = "Cardiología",
            });

            modelBuilder.Entity<Especialidad>().HasData(new Especialidad
            {
                Id = 10,
                NombreEspecialidad = "Nutrición",
            });
            #endregion

            #region Sexo
            modelBuilder.Entity<Sexo>().HasData(new Sexo
            {
                Id = 1,
                DescripcionSexo = "Masculino",
            });

            modelBuilder.Entity<Sexo>().HasData(new Sexo
            {
                Id = 2,
                DescripcionSexo = "Femenino",
            });

            modelBuilder.Entity<Sexo>().HasData(new Sexo
            {
                Id = 3,
                DescripcionSexo = "Otro",
            });
            #endregion

            #region Tipificaciones de comunicacion
            modelBuilder.Entity<TipificacionComunicacion>().HasData(new TipificacionComunicacion
            {
                Id = 1,
                NombreTipificacion = "Contactado"
            });
            modelBuilder.Entity<TipificacionComunicacion>().HasData(new TipificacionComunicacion
            {
                Id = 2,
                NombreTipificacion = "Recontactado"
            });
            modelBuilder.Entity<TipificacionComunicacion>().HasData(new TipificacionComunicacion
            {
                Id = 3,
                NombreTipificacion = "Nuevo ingreso"
            });
            #endregion

            #region Tipos de patologias - Antecedentes familiares
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 1,
                Tipo = "Diabetes",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 2,
                Tipo = "Cardiopatías",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 3,
                Tipo = "Neoplasias",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 4,
                Tipo = "Epilepsia",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 5,
                Tipo = "Malformaciones",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 6,
                Tipo = "SIDA",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 7,
                Tipo = "Enfermedades renales",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 8,
                Tipo = "Hepatitis",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 9,
                Tipo = "Artritis",
                VerInputDescripcion = false
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 10,
                Tipo = "Otra",
                VerInputDescripcion = true
            });
            modelBuilder.Entity<TipoPatologia>().HasData(new TipoPatologia
            {
                Id = 11,
                Tipo = "Aparentemente sano",
                VerInputDescripcion = false
            });
            #endregion

            #region Fases de tratamiento
            modelBuilder.Entity<FaseTratamiento>().HasData(new FaseTratamiento
            {
                Id = 1,
                NombreFase = "Adelgazamiento",
                Valor = 2650
            });
            modelBuilder.Entity<FaseTratamiento>().HasData(new FaseTratamiento
            {
                Id = 2,
                NombreFase = "Mantenimiento 1",
                Valor = 1600
            });
            modelBuilder.Entity<FaseTratamiento>().HasData(new FaseTratamiento
            {
                Id = 3,
                NombreFase = "Mantenimiento 2",
                Valor = 1600
            });
            modelBuilder.Entity<FaseTratamiento>().HasData(new FaseTratamiento
            {
                Id = 4,
                NombreFase = "Mantenimiento 3",
                Valor = 1600
            });
            #endregion

            #region Bancos
            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 1,
                Nombre = "BANCO AGROMERCANTIL DE GUATEMALA S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 2,
                Nombre = "VIVIBANCO S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 3,
                Nombre = "BANCO G&T CONTINENTAL S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 4,
                Nombre = "BANCO DE AMERICA CENTRAL S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 5,
                Nombre = "BANCO FICOHSA GUATEMALA S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 6,
                Nombre = "BANCO INTERNACIONAL S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 7,
                Nombre = "BANCO DE DESARROLLO RURAL S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 8,
                Nombre = "BANCO INDUSTRIAL S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 9,
                Nombre = "BANCO DE CREDITO S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 10,
                Nombre = "BANCO PROMERICA S.A.",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 11,
                Nombre = "CITIBANK N.A SUCURSAL GUATEMALA",
            });

            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 12,
                Nombre = "EL CREDITO HIPOTECARIO NACIONAL DE GUATEMALA",
            });


            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 13,
                Nombre = "BANCO DE LOS TRABAJADORES",
            });


            modelBuilder.Entity<Banco>().HasData(new Banco
            {
                Id = 14,
                Nombre = "BANCO INMOBILIARIO S.A.",
            });
            #endregion

            modelBuilder.Entity<EstadoTraslados>().HasData(new EstadoTraslados
            {
                Id = 1,
                DescripcionEstado = "Aceptado",
            });

            modelBuilder.Entity<EstadoTraslados>().HasData(new EstadoTraslados
            {
                Id = 2,
                DescripcionEstado = "Denegado",
            });

            modelBuilder.Entity<EstadoTraslados>().HasData(new EstadoTraslados
            {
                Id = 3,
                DescripcionEstado = "Con problema",
            });

            modelBuilder.Entity<EstadoTraslados>().HasData(new EstadoTraslados
            {
                Id = 4,
                DescripcionEstado = "Faltantes",
            });

            modelBuilder.Entity<EstadoTraslados>().HasData(new EstadoTraslados
            {
                Id = 5,
                DescripcionEstado = "En tránsito",
            });

            modelBuilder.Entity<TipoBodega>().HasData(new TipoBodega
            {
                Id = 1,
                DescripcionBodega = "FARMACIA",
            });

            modelBuilder.Entity<TipoBodega>().HasData(new TipoBodega
            {
                Id = 2,
                DescripcionBodega = "CLINICA",
            });

            modelBuilder.Entity<TipoBodega>().HasData(new TipoBodega
            {
                Id = 3,
                DescripcionBodega = "BODEGA",
            });

            modelBuilder.Entity<TipoBodega>().HasData(new TipoBodega
            {
                Id = 4,
                DescripcionBodega = "LABORATORIO",
            });

            #region TipoProducto
            modelBuilder.Entity<TipoProducto>().HasData(new TipoProducto
            {
                Id = 1,
                NombreTipoProducto = "Medicamentos",
            });

            modelBuilder.Entity<TipoProducto>().HasData(new TipoProducto
            {
                Id = 2,
                NombreTipoProducto = "Insumos Médicos",
            });

            modelBuilder.Entity<TipoProducto>().HasData(new TipoProducto
            {
                Id = 3,
                NombreTipoProducto = "Equipos Médicos",
            });

            modelBuilder.Entity<TipoProducto>().HasData(new TipoProducto
            {
                Id = 4,
                NombreTipoProducto = "Muestras Médicas",
            });
            #endregion


            modelBuilder.Entity<TipoCompra>().HasData(new TipoCompra
            {
                Id = 1,
                Tipo = "CONTADO",
            });

            modelBuilder.Entity<TipoCompra>().HasData(new TipoCompra
            {
                Id = 2,
                Tipo = "CREDITO",
            });



            modelBuilder.Entity<EstadoRecepcion>().HasData(new EstadoRecepcion
            {
                Id = 1,
                Estado = "No ingresado",
            });

            modelBuilder.Entity<EstadoRecepcion>().HasData(new EstadoRecepcion
            {
                Id = 2,
                Estado = "Ingresado",
            });


            modelBuilder.Entity<EstadoPagoConsulta>().HasData(new EstadoPagoConsulta
            {
                Id = 1,
                Estado = "Pagado",
            });

            modelBuilder.Entity<EstadoPagoConsulta>().HasData(new EstadoPagoConsulta
            {
                Id = 2,
                Estado = "Pendiente",
            });

            modelBuilder.Entity<EstadoPagoConsulta>().HasData(new EstadoPagoConsulta
            {
                Id = 3,
                Estado = "Cortesía",
            });


            // estado examenes

            modelBuilder.Entity<EstadoExamen>().HasData(new EstadoExamen
            {
                Id = 1,
                Nombre = "Solicitados",
            });

            modelBuilder.Entity<EstadoExamen>().HasData(new EstadoExamen
            {
                Id = 2,
                Nombre = " En proceso",
            });

            modelBuilder.Entity<EstadoExamen>().HasData(new EstadoExamen
            {
                Id = 3,
                Nombre = " Cancelados",
            });

            modelBuilder.Entity<EstadoExamen>().HasData(new EstadoExamen
            {
                Id = 4,
                Nombre = " Revisión",
            });

            modelBuilder.Entity<EstadoExamen>().HasData(new EstadoExamen
            {
                Id = 5,
                Nombre = " Finalizados",
            });



            modelBuilder.Entity<Sucursal>().HasData(new Sucursal
            {
                Id = 1,
                NombreSucursal = "La Gomera",
            });

            modelBuilder.Entity<Sucursal>().HasData(new Sucursal
            {
                Id = 2,
                NombreSucursal = "Zicapate",
            });

            modelBuilder.Entity<Sucursal>().HasData(new Sucursal
            {
                Id = 3,
                NombreSucursal = "Puerto de San José",
            });

            modelBuilder.Entity<Sucursal>().HasData(new Sucursal
            {
                Id = 4,
                NombreSucursal = "San Pedro Yepocapa",
            });

            modelBuilder.Entity<Sucursal>().HasData(new Sucursal
            {
                Id = 5,
                NombreSucursal = "Siquinalá",
            });

            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "dc6916f0-8d11-43a3-b143-37ce429bee33",
                UserName = "admin@redowl.com",
                NormalizedUserName = "ADMIN@REDOWL.COM",
                PasswordHash = hasher.HashPassword(null, "redowl@123"),
                Email = "admin@redowl.com",
                NormalizedEmail = "ADMIN@REDOWL.COM",
                LockoutEnabled = true
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "785c160e-6a4f-4fd8-8121-4e6b2af230cd",
                    UserId = "dc6916f0-8d11-43a3-b143-37ce429bee33"
                }
            );

            //Datos HasData ANTECEDENTES PERSONALES
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 1,
                NombreAntecedente = "Varicela"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 2,
                NombreAntecedente = "Rubeola"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 3,
                NombreAntecedente = "Sarampión"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 4,
                NombreAntecedente = "Parotiditis"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 5,
                NombreAntecedente = "Tosferina"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 6,
                NombreAntecedente = "Escarlatina"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 7,
                NombreAntecedente = "Parasitosis"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 8,
                NombreAntecedente = "Hepatitis"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 9,
                NombreAntecedente = "SIDA"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 10,
                NombreAntecedente = "VIH"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 11,
                NombreAntecedente = "Asma"
            });
            modelBuilder.Entity<AntecedentePersonal>().HasData(new AntecedentePersonal
            {
                Id = 12,
                NombreAntecedente = "Disfunciones endocrinas"
            });



            //Datos HasData VACUNAS
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 1,
                Nombre = "Hexavalente"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 2,
                Nombre = "Rotavirus"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 3,
                Nombre = "Neumococo"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 4,
                Nombre = "MMR"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 5,
                Nombre = "Varicela"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 6,
                Nombre = "Hepatitis A"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 7,
                Nombre = "Influenza"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 8,
                Nombre = "Papiloma Virus"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 9,
                Nombre = "BCG"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 10,
                Nombre = "Hepatitis B"
            });
            modelBuilder.Entity<Vacuna>().HasData(new Vacuna
            {
                Id = 11,
                Nombre = "COVID-19"
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
