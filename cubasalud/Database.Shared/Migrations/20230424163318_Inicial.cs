using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Database.Shared.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AntecedentesPersonales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreAntecedente = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesPersonales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CajaClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MontoApertura = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EstadoCaja = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajaClinicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaLabClinicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UltimoUsuarioModificado = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLabClinicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCategoria = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasGastos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCategoria = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasGastos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreClinica = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cliente = table.Column<string>(type: "text", nullable: true),
                    Empleado = table.Column<string>(type: "text", nullable: true),
                    NoComprobante = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    EnvioId = table.Column<int>(type: "integer", nullable: true),
                    FechaCotizacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaValida = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Confirmado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellido = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    Telefono_2 = table.Column<string>(type: "text", nullable: true),
                    Telefono_3 = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Edad = table.Column<string>(type: "text", nullable: true),
                    Dpi = table.Column<string>(type: "text", nullable: false),
                    Nit = table.Column<string>(type: "text", nullable: false),
                    EstadoCivil = table.Column<string>(type: "text", nullable: true),
                    TipoContrato = table.Column<string>(type: "text", nullable: true),
                    Salario = table.Column<string>(type: "text", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    Imagen = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEspecialidad = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoExamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoExamenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPagoConsultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPagoConsultas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoRecepciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoRecepciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosEnvio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosEnvio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTraslados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DescripcionEstado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTraslados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamenFisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Temperatura = table.Column<string>(type: "text", nullable: true),
                    FrecuenciaRespiratoria = table.Column<string>(type: "text", nullable: true),
                    FrecuenciaCardiaca = table.Column<string>(type: "text", nullable: true),
                    SaturacionDeOxigeno = table.Column<string>(type: "text", nullable: true),
                    PresionArterialBrazoDerecho = table.Column<string>(type: "text", nullable: true),
                    PresionArterialBrazoIzquierdo = table.Column<string>(type: "text", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    Peso = table.Column<string>(type: "text", nullable: true),
                    Talla = table.Column<string>(type: "text", nullable: true),
                    IMC = table.Column<string>(type: "text", nullable: true),
                    Glucosa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenFisico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreFormaPago = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grabaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Categoria = table.Column<string>(type: "text", nullable: true),
                    PalabraClave = table.Column<string>(type: "text", nullable: true),
                    Eliminada = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grabaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreGrupo = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoTProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreGrupoT = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoTProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HistoriaProblema = table.Column<string>(type: "text", nullable: true),
                    Sintomas = table.Column<string>(type: "text", nullable: true),
                    Diagnostico = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaboratorioProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreLaboratorioProducto = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratorioProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreMarca = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    TipificacionComunicacion = table.Column<string>(type: "text", nullable: true),
                    ModalidadAtencion = table.Column<string>(type: "text", nullable: true),
                    Religion = table.Column<string>(type: "text", nullable: true),
                    EstadoCivil = table.Column<string>(type: "text", nullable: true),
                    Ocupacion = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Nacionalidad = table.Column<string>(type: "text", nullable: true),
                    PaisResidencia = table.Column<string>(type: "text", nullable: true),
                    TipoSangre = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Dpi = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true),
                    Municipio = table.Column<string>(type: "text", nullable: true),
                    ContactoEmergencia = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonaSeguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    IdPaciente = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaSeguro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreguntasRegistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pregunta = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreguntasRegistro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PresentacionProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PresentProducto = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentacionProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Destino = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SegurosEpss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosEpss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreServicio = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DescripcionSexo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreSucursal = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoBodega",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DescripcionBodega = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoBodega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCompra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEspecialidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEspecialidad = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEspecialidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPatologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    VerInputDescripcion = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPatologias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreTipoProducto = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViaAdministracion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreViaAdministracion = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViaAdministracion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viadmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreViadmin = table.Column<string>(type: "text", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viadmin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    Giro = table.Column<string>(type: "text", nullable: true),
                    Telefono_1 = table.Column<string>(type: "text", nullable: true),
                    Telefono_2 = table.Column<string>(type: "text", nullable: true),
                    Celular_1 = table.Column<string>(type: "text", nullable: true),
                    Celular_2 = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    CuentaBancaria = table.Column<string>(type: "text", nullable: true),
                    BancoId = table.Column<int>(type: "integer", nullable: false),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    TipoProveedor = table.Column<string>(type: "text", nullable: true),
                    FrecuenciaEntrega = table.Column<string>(type: "text", nullable: true),
                    DiasEntrega = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamenLabClinicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoriaLabClinicoId = table.Column<int>(type: "integer", nullable: false),
                    NombreExamen = table.Column<string>(type: "text", nullable: false),
                    CodigoInterno = table.Column<string>(type: "text", nullable: true),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    PrecioB = table.Column<decimal>(type: "numeric", nullable: false),
                    PrecioC = table.Column<decimal>(type: "numeric", nullable: false),
                    Indicaciones = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UltimaModificacion = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    PrecioCosto = table.Column<decimal>(type: "numeric", nullable: false),
                    TipoDeExamen = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenLabClinicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamenLabClinicos_CategoriaLabClinicos_CategoriaLabClinicoId",
                        column: x => x.CategoriaLabClinicoId,
                        principalTable: "CategoriaLabClinicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoriaGastoId = table.Column<int>(type: "integer", nullable: true),
                    NombreGasto = table.Column<string>(type: "text", nullable: false),
                    Costo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastos_CategoriasGastos_CategoriaGastoId",
                        column: x => x.CategoriaGastoId,
                        principalTable: "CategoriasGastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Alias = table.Column<string>(type: "text", nullable: true),
                    no_IGGS = table.Column<string>(type: "text", nullable: true),
                    esta_Afiliado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Edad = table.Column<int>(type: "integer", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    SexoId = table.Column<int>(type: "integer", nullable: true),
                    SeguroEpssId = table.Column<int>(type: "integer", nullable: true),
                    CodigoEPS = table.Column<string>(type: "text", nullable: true),
                    Religion = table.Column<string>(type: "text", nullable: true),
                    Ocupacion = table.Column<string>(type: "text", nullable: true),
                    EstadoCivil = table.Column<string>(type: "text", nullable: true),
                    ContactoEmergencia = table.Column<string>(type: "text", nullable: true),
                    NumeroContactoEmergencia = table.Column<string>(type: "text", nullable: true),
                    NombreContactoEmergencia = table.Column<string>(type: "text", nullable: true),
                    Nacionalidad = table.Column<string>(type: "text", nullable: true),
                    TipoDeSangre = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Dpi = table.Column<string>(type: "text", nullable: true),
                    PesoAlNacer = table.Column<string>(type: "text", nullable: true),
                    Talla = table.Column<string>(type: "text", nullable: true),
                    CircunferenciaCefalica = table.Column<string>(type: "text", nullable: true),
                    TipoParto = table.Column<string>(type: "text", nullable: true),
                    TieneMembresia = table.Column<bool>(type: "boolean", nullable: true),
                    FechaInicioMembresia = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AntecedentesPersonalesObservaciones = table.Column<string>(type: "text", nullable: true),
                    AntecedentesPersonalesOtros = table.Column<string>(type: "text", nullable: true),
                    AlergiaAnestesiaLocal = table.Column<string>(type: "text", nullable: true),
                    AlergiaAspirina = table.Column<string>(type: "text", nullable: true),
                    AlergiaPenicilina = table.Column<string>(type: "text", nullable: true),
                    AlergiaBarbiturios = table.Column<string>(type: "text", nullable: true),
                    AlergiaSulfas = table.Column<string>(type: "text", nullable: true),
                    AlergiaCodeina = table.Column<string>(type: "text", nullable: true),
                    AlergiaMetales = table.Column<string>(type: "text", nullable: true),
                    AlergiaLatex = table.Column<string>(type: "text", nullable: true),
                    AlergiaYodo = table.Column<string>(type: "text", nullable: true),
                    AlergiaPolen = table.Column<string>(type: "text", nullable: true),
                    AlergiaAnimales = table.Column<string>(type: "text", nullable: true),
                    AlergiaAlimentos = table.Column<string>(type: "text", nullable: true),
                    AlergiaOtros = table.Column<string>(type: "text", nullable: true),
                    AlergiaOtrosDescripcion = table.Column<string>(type: "text", nullable: true),
                    MedicaUsaLentesContacto = table.Column<string>(type: "text", nullable: true),
                    MedicaUsaLentesContactoDescripcion = table.Column<string>(type: "text", nullable: true),
                    MedicaArticulacionesArtificiales = table.Column<string>(type: "text", nullable: true),
                    MedicaArticulacionesArtificialesFecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MedicaArticulacionesArtificialesComplicaciones = table.Column<string>(type: "text", nullable: true),
                    MedicaTomaAlendronato = table.Column<string>(type: "text", nullable: true),
                    MedicaTomaAlendronatoFecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MedicaTratamientoDolorHuesos = table.Column<string>(type: "text", nullable: true),
                    MedicaTratamientoDolorHuesosFechaInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MedicaTratamientoDolorHuesosDescripcionCaso = table.Column<string>(type: "text", nullable: true),
                    MedicaSustanciasReguladorasDrogas = table.Column<string>(type: "text", nullable: true),
                    MedicaSustanciasReguladorasDrogasFecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MedicaUsaTabaco = table.Column<string>(type: "text", nullable: true),
                    MedicaBebidasAlcoholicas = table.Column<string>(type: "text", nullable: true),
                    MedicaBebidasAlcoholicasDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalSangradoCepillar = table.Column<string>(type: "text", nullable: true),
                    DentalDolorFrio = table.Column<string>(type: "text", nullable: true),
                    DentalDolorPresionar = table.Column<string>(type: "text", nullable: true),
                    DentalObjetosAtorados = table.Column<string>(type: "text", nullable: true),
                    DentalBocaSeca = table.Column<string>(type: "text", nullable: true),
                    DentalTratamientoPeriondal = table.Column<string>(type: "text", nullable: true),
                    DentalTratamientoOrtodoncia = table.Column<string>(type: "text", nullable: true),
                    DentalProblemasTratamientoDental = table.Column<string>(type: "text", nullable: true),
                    DentalProblemasTratamientoDentalDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalFluoradaAguaDomicilio = table.Column<string>(type: "text", nullable: true),
                    DentalBebeAguaFiltrada = table.Column<string>(type: "text", nullable: true),
                    DentalDolorOidos = table.Column<string>(type: "text", nullable: true),
                    DentalMolestiaRuidoAlto = table.Column<string>(type: "text", nullable: true),
                    DentalMolestiaRuidoAltoDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalBrumismo = table.Column<string>(type: "text", nullable: true),
                    DentalLesiones = table.Column<string>(type: "text", nullable: true),
                    DentalLesionesDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalDentaduraPlacas = table.Column<string>(type: "text", nullable: true),
                    DentalDentaduraPlacasDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalActividadesRecreacion = table.Column<string>(type: "text", nullable: true),
                    DentalActividadesRecreacionDescripcion = table.Column<string>(type: "text", nullable: true),
                    DentalLesionesCabeza = table.Column<string>(type: "text", nullable: true),
                    DentalLesionesCabezaDescripcion = table.Column<string>(type: "text", nullable: true),
                    FacialPatron = table.Column<string>(type: "text", nullable: true),
                    FacialPatronObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialPerfil = table.Column<string>(type: "text", nullable: true),
                    FacialPerfilObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialAsimetria = table.Column<string>(type: "text", nullable: true),
                    FacialAsimetriaObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialAlturaFacialEquilibrada = table.Column<string>(type: "text", nullable: true),
                    FacialAlturaFacialEquilibradaObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialAnchoFacialEquilibrada = table.Column<string>(type: "text", nullable: true),
                    FacialAnchoFacialEquilibradaObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialPerfilMaxilar = table.Column<string>(type: "text", nullable: true),
                    FacialPerfilMaxilarObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialPerfilMandibular = table.Column<string>(type: "text", nullable: true),
                    FacialPerfilMandibularObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialSurcoLabialMenton = table.Column<string>(type: "text", nullable: true),
                    FacialSurcoLabialMentonObservaciones = table.Column<string>(type: "text", nullable: true),
                    FacialLabiosReposo = table.Column<string>(type: "text", nullable: true),
                    FuncionalActividadComisurial = table.Column<string>(type: "text", nullable: true),
                    FuncionalActividadLingual = table.Column<string>(type: "text", nullable: true),
                    FuncionalLabioSuperior = table.Column<string>(type: "text", nullable: true),
                    FuncionalLabioInferior = table.Column<string>(type: "text", nullable: true),
                    FuncionalMasetero = table.Column<string>(type: "text", nullable: true),
                    FuncionalMentoniano = table.Column<string>(type: "text", nullable: true),
                    FuncionalRespiracion = table.Column<string>(type: "text", nullable: true),
                    FuncionalDeglucion = table.Column<string>(type: "text", nullable: true),
                    PatronFacial = table.Column<string>(type: "text", nullable: true),
                    CaracteristicaPatronFacial = table.Column<string>(type: "text", nullable: true),
                    AntecedentesMedicos = table.Column<string>(type: "text", nullable: true),
                    AntecedentesQuirurgicos = table.Column<string>(type: "text", nullable: true),
                    AntecedentesTraumaticos = table.Column<string>(type: "text", nullable: true),
                    AntecedentesAlergias = table.Column<string>(type: "text", nullable: true),
                    AntecedentesVicios = table.Column<string>(type: "text", nullable: true),
                    AntecedentesMedicamentos = table.Column<string>(type: "text", nullable: true),
                    NombrePadre = table.Column<string>(type: "text", nullable: true),
                    NombreMadre = table.Column<string>(type: "text", nullable: true),
                    MadreFechaNacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MadreEmbarazos = table.Column<int>(type: "integer", nullable: true),
                    MadrePartosNormales = table.Column<int>(type: "integer", nullable: true),
                    MadreCesareas = table.Column<int>(type: "integer", nullable: true),
                    MadreAbortos = table.Column<int>(type: "integer", nullable: true),
                    MadreHijosVivos = table.Column<int>(type: "integer", nullable: true),
                    MadreHijosMuertos = table.Column<int>(type: "integer", nullable: true),
                    MadreComplicaciones = table.Column<string>(type: "text", nullable: true),
                    HistoriaMedicoPersonal = table.Column<string>(type: "text", nullable: true),
                    HistoriaTelefonoMedico = table.Column<string>(type: "text", nullable: true),
                    HistoriaEspecialidadMedico = table.Column<string>(type: "text", nullable: true),
                    HistoriaTratamientoMedico = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaSangraMuchoCortarse = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaHospitalizado = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaOperado = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaAlergiaMedicina = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaAlergiaComida = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaAlergiaOtros = table.Column<string>(type: "text", nullable: true),
                    HistoriaProblemaEmocional = table.Column<bool>(type: "boolean", nullable: false),
                    HistoriaObservaciones = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_SegurosEpss_SeguroEpssId",
                        column: x => x.SeguroEpssId,
                        principalTable: "SegurosEpss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipoBodegaId = table.Column<int>(type: "integer", nullable: true),
                    ViadminId = table.Column<int>(type: "integer", nullable: true),
                    TipoProductoId = table.Column<int>(type: "integer", nullable: true),
                    GrupoTProductoId = table.Column<int>(type: "integer", nullable: true),
                    PresentacionProductoId = table.Column<int>(type: "integer", nullable: true),
                    LaboratorioProductoId = table.Column<int>(type: "integer", nullable: true),
                    MarcaId = table.Column<int>(type: "integer", nullable: true),
                    CategoriaId = table.Column<int>(type: "integer", nullable: true),
                    GrupoId = table.Column<int>(type: "integer", nullable: true),
                    NombreProducto = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_2 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_3 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_4 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_5 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_6 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Precio_7 = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    PrecioCosto = table.Column<decimal>(type: "numeric(18,3)", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    StockInical = table.Column<int>(type: "integer", nullable: false),
                    CodigoReferencia = table.Column<string>(type: "text", nullable: false),
                    Imagen = table.Column<string>(type: "text", nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    ActivoYConcentracion = table.Column<string>(type: "text", nullable: true),
                    Dosis = table.Column<string>(type: "text", nullable: true),
                    FechaVencimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_GrupoTProductos_GrupoTProductoId",
                        column: x => x.GrupoTProductoId,
                        principalTable: "GrupoTProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_LaboratorioProductos_LaboratorioProductoId",
                        column: x => x.LaboratorioProductoId,
                        principalTable: "LaboratorioProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_PresentacionProductos_PresentacionProductoId",
                        column: x => x.PresentacionProductoId,
                        principalTable: "PresentacionProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_TipoBodega_TipoBodegaId",
                        column: x => x.TipoBodegaId,
                        principalTable: "TipoBodega",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_TipoProductos_TipoProductoId",
                        column: x => x.TipoProductoId,
                        principalTable: "TipoProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Viadmin_ViadminId",
                        column: x => x.ViadminId,
                        principalTable: "Viadmin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipoCompraId = table.Column<int>(type: "integer", nullable: false),
                    ProveedorId = table.Column<int>(type: "integer", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    NoComprobante = table.Column<string>(type: "text", nullable: true),
                    NombreVendedor = table.Column<string>(type: "text", nullable: true),
                    FechaLimite = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaRecepcion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Observaciones = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_TipoCompra_TipoCompraId",
                        column: x => x.TipoCompraId,
                        principalTable: "TipoCompra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatosExamenesLabClinicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExamenLabClinicoId = table.Column<int>(type: "integer", nullable: false),
                    Campos = table.Column<string>(type: "text", nullable: false),
                    Resultado = table.Column<string>(type: "text", nullable: true),
                    ValorReferencia = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false),
                    Indicaciones = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosExamenesLabClinicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosExamenesLabClinicos_ExamenLabClinicos_ExamenLabClinico~",
                        column: x => x.ExamenLabClinicoId,
                        principalTable: "ExamenLabClinicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CajaLab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    MontoApertura = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EstadoCaja = table.Column<bool>(type: "boolean", nullable: false),
                    ResponsableAperturaLabId = table.Column<string>(type: "text", nullable: true),
                    ResponsableCierreLabId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajaLab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CajaLab_AspNetUsers_ResponsableAperturaLabId",
                        column: x => x.ResponsableAperturaLabId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CajaLab_AspNetUsers_ResponsableCierreLabId",
                        column: x => x.ResponsableCierreLabId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cajas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    MontoApertura = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EstadoCaja = table.Column<bool>(type: "boolean", nullable: false),
                    ResponsableAperturaId = table.Column<string>(type: "text", nullable: true),
                    ResponsableCierreId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cajas_AspNetUsers_ResponsableAperturaId",
                        column: x => x.ResponsableAperturaId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cajas_AspNetUsers_ResponsableCierreId",
                        column: x => x.ResponsableCierreId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RutaId = table.Column<int>(type: "integer", nullable: false),
                    EstadosEnvioId = table.Column<int>(type: "integer", nullable: false),
                    NombrePiloto = table.Column<string>(type: "text", nullable: true),
                    DireccionExacta = table.Column<string>(type: "text", nullable: true),
                    NoComprobante = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    FechaEntrega = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    UserId1 = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    UserId2 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envios_AspNetUsers_UserId2",
                        column: x => x.UserId2,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envios_EstadosEnvio_EstadosEnvioId",
                        column: x => x.EstadosEnvioId,
                        principalTable: "EstadosEnvio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrasladosProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EstadoTrasladosId = table.Column<int>(type: "integer", nullable: false),
                    FechaTraslado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    ProductosRegresadosAFarmacia = table.Column<bool>(type: "boolean", nullable: false),
                    TipoTrasladoBodega = table.Column<string>(type: "text", nullable: true),
                    ResponsableEnviadoId = table.Column<string>(type: "text", nullable: true),
                    ResponsableRecibidoId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrasladosProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrasladosProductos_AspNetUsers_ResponsableEnviadoId",
                        column: x => x.ResponsableEnviadoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrasladosProductos_AspNetUsers_ResponsableRecibidoId",
                        column: x => x.ResponsableRecibidoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrasladosProductos_EstadoTraslados_EstadoTrasladosId",
                        column: x => x.EstadoTrasladosId,
                        principalTable: "EstadoTraslados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EspecialidadId = table.Column<int>(type: "integer", nullable: true),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    ServicioId = table.Column<int>(type: "integer", nullable: true),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: true),
                    Edad = table.Column<int>(type: "integer", nullable: true),
                    NombreEncargado = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Finalizada = table.Column<bool>(type: "boolean", nullable: false),
                    EsMenorDeEdad = table.Column<bool>(type: "boolean", nullable: false),
                    EstadoCita = table.Column<string>(type: "text", nullable: true),
                    NombreMedicoTemporal = table.Column<string>(type: "text", nullable: true),
                    UserId1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Especialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EspecialidadId = table.Column<int>(type: "integer", nullable: true),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    ServicioId = table.Column<int>(type: "integer", nullable: true),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: true),
                    Edad = table.Column<int>(type: "integer", nullable: true),
                    NombreEncargado = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Finalizada = table.Column<bool>(type: "boolean", nullable: false),
                    EsMenorDeEdad = table.Column<bool>(type: "boolean", nullable: false),
                    EstadoCita = table.Column<string>(type: "text", nullable: true),
                    NombreMedicoTemporal = table.Column<string>(type: "text", nullable: true),
                    CodigoDeCita = table.Column<string>(type: "text", nullable: true),
                    CodigoAutorizacion = table.Column<string>(type: "text", nullable: true),
                    Bloqueada = table.Column<bool>(type: "boolean", nullable: true),
                    UserId1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citass_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citass_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citass_Especialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citass_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citass_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuentasPorCobrar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    FechaLimitePago = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Valor = table.Column<decimal>(type: "numeric", nullable: true),
                    Pagada = table.Column<bool>(type: "boolean", nullable: false),
                    FechaPagoRealizado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Eliminada = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasPorCobrar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentasPorCobrar_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Examenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    MedicosId = table.Column<int>(type: "integer", nullable: true),
                    ClinicaId = table.Column<int>(type: "integer", nullable: true),
                    EstadoExamenId = table.Column<int>(type: "integer", nullable: true),
                    FechaRealizacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TipoA = table.Column<bool>(type: "boolean", nullable: false),
                    TipoB = table.Column<bool>(type: "boolean", nullable: false),
                    TipoC = table.Column<bool>(type: "boolean", nullable: false),
                    DoctorReferido = table.Column<string>(type: "text", nullable: true),
                    ClinicaReferida = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    UsuarioSolicita = table.Column<string>(type: "text", nullable: true),
                    UsuarioIngresa = table.Column<string>(type: "text", nullable: true),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examenes_Clinicas_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examenes_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examenes_EstadoExamenes_EstadoExamenId",
                        column: x => x.EstadoExamenId,
                        principalTable: "EstadoExamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examenes_Medicos_MedicosId",
                        column: x => x.MedicosId,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examenes_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacientesAntecedentesPersonales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    AntecedentePersonalId = table.Column<int>(type: "integer", nullable: false),
                    PresentoAntecedente = table.Column<bool>(type: "boolean", nullable: false),
                    FechaAntecedente = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesAntecedentesPersonales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientesAntecedentesPersonales_AntecedentesPersonales_Ante~",
                        column: x => x.AntecedentePersonalId,
                        principalTable: "AntecedentesPersonales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacientesAntecedentesPersonales_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacientesFasesTratamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    FaseAdelgazamiento = table.Column<bool>(type: "boolean", nullable: false),
                    FaseMantenimiento1 = table.Column<bool>(type: "boolean", nullable: false),
                    FaseMantenimiento2 = table.Column<bool>(type: "boolean", nullable: false),
                    FaseMantenimiento3 = table.Column<bool>(type: "boolean", nullable: false),
                    FechaInicioFase = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FaseFinalizada = table.Column<bool>(type: "boolean", nullable: false),
                    FechaFinalizacionFase = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesFasesTratamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientesFasesTratamiento_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacientesPreguntasRegistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    PreguntaRegistroId = table.Column<int>(type: "integer", nullable: false),
                    Respuesta = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesPreguntasRegistro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientesPreguntasRegistro_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacientesPreguntasRegistro_PreguntasRegistro_PreguntaRegist~",
                        column: x => x.PreguntaRegistroId,
                        principalTable: "PreguntasRegistro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacientesSeguimientosNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Peso = table.Column<decimal>(type: "numeric", nullable: true),
                    IMC = table.Column<decimal>(type: "numeric", nullable: true),
                    PGC = table.Column<decimal>(type: "numeric", nullable: true),
                    Cuello = table.Column<decimal>(type: "numeric", nullable: true),
                    Busto = table.Column<decimal>(type: "numeric", nullable: true),
                    CinturaAbdomen = table.Column<decimal>(type: "numeric", nullable: true),
                    Cadera = table.Column<decimal>(type: "numeric", nullable: true),
                    Muslo = table.Column<decimal>(type: "numeric", nullable: true),
                    Brazo = table.Column<decimal>(type: "numeric", nullable: true),
                    Muñeca = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesSeguimientosNutricionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientesSeguimientosNutricionales_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatologiasPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    TipoPatologiaId = table.Column<int>(type: "integer", nullable: false),
                    Madre = table.Column<bool>(type: "boolean", nullable: false),
                    AbuelaMaterna = table.Column<bool>(type: "boolean", nullable: false),
                    AbueloMaterno = table.Column<bool>(type: "boolean", nullable: false),
                    OtrosMaterno = table.Column<bool>(type: "boolean", nullable: false),
                    Padre = table.Column<bool>(type: "boolean", nullable: false),
                    AbuelaPaterna = table.Column<bool>(type: "boolean", nullable: false),
                    AbueloPaterno = table.Column<bool>(type: "boolean", nullable: false),
                    Hermanos = table.Column<bool>(type: "boolean", nullable: false),
                    OtrosPaterno = table.Column<bool>(type: "boolean", nullable: false),
                    DescripcionOtraPatologia = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatologiasPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatologiasPacientes_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacunasPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    VacunaId = table.Column<int>(type: "integer", nullable: false),
                    Primera = table.Column<bool>(type: "boolean", nullable: false),
                    Segunda = table.Column<bool>(type: "boolean", nullable: false),
                    Tercera = table.Column<bool>(type: "boolean", nullable: false),
                    PrimerRefuerzo = table.Column<bool>(type: "boolean", nullable: false),
                    SegundoRefuerzo = table.Column<bool>(type: "boolean", nullable: false),
                    FechaPrimera = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaSegunda = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaTercera = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaPrimerRefuerzo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaSegundoRefuerzo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunasPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacunasPacientes_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacunasPacientes_Vacunas_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentaServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    NoComprobante = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FormaPago = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    PacienteId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaServicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaServicios_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentaServicios_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCotizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductoId = table.Column<int>(type: "integer", nullable: true),
                    ServicioId = table.Column<int>(type: "integer", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CotizacionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCotizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCotizaciones_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCotizaciones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCotizaciones_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompraId = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,3)", nullable: false),
                    BaseImponible = table.Column<decimal>(type: "numeric(18,3)", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "numeric(18,3)", nullable: false),
                    Impuesto = table.Column<decimal>(type: "numeric(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCompras_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recepciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompraId = table.Column<int>(type: "integer", nullable: false),
                    EstadoRecepcionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepciones_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recepciones_EstadoRecepciones_EstadoRecepcionId",
                        column: x => x.EstadoRecepcionId,
                        principalTable: "EstadoRecepciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleEnvios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EnvioId = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleEnvios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleEnvios_Envios_EnvioId",
                        column: x => x.EnvioId,
                        principalTable: "Envios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleEnvios_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(type: "integer", nullable: true),
                    ClientesId = table.Column<int>(type: "integer", nullable: true),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    NoComprobante = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    EnvioId = table.Column<int>(type: "integer", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    TipoVenta = table.Column<string>(type: "text", nullable: true),
                    MontoPago = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Vuelto = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Envios_EnvioId",
                        column: x => x.EnvioId,
                        principalTable: "Envios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleTraslado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    TrasladosProductosId = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleTraslado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_TrasladosProductos_TrasladosProductosId",
                        column: x => x.TrasladosProductosId,
                        principalTable: "TrasladosProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CitasId = table.Column<int>(type: "integer", nullable: true),
                    HistoriaId = table.Column<int>(type: "integer", nullable: true),
                    ExamenFisicoId = table.Column<int>(type: "integer", nullable: true),
                    ObservacionesAdicionales = table.Column<string>(type: "text", nullable: true),
                    CostoConsulta = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FechaYHoraInicioConsulta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaProximaConsulta = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Archivado = table.Column<bool>(type: "boolean", nullable: false),
                    EstadoPagoConsultaId = table.Column<int>(type: "integer", nullable: false),
                    UrlFiles = table.Column<string>(type: "text", nullable: true),
                    ExamenGinecologico = table.Column<string>(type: "text", nullable: true),
                    ExamenNeurologico = table.Column<string>(type: "text", nullable: true),
                    SistemaCardiopulmonar = table.Column<string>(type: "text", nullable: true),
                    SistemaOsteoarticular = table.Column<string>(type: "text", nullable: true),
                    SistemaHematologico = table.Column<string>(type: "text", nullable: true),
                    TipoConsulta = table.Column<string>(type: "text", nullable: true),
                    TipoReferencia = table.Column<string>(type: "text", nullable: true),
                    MedicoReferido = table.Column<string>(type: "text", nullable: true),
                    EstaEmbarazada = table.Column<string>(type: "text", nullable: true),
                    NumeroSemanasEmbarazo = table.Column<int>(type: "integer", nullable: true),
                    TomaPildorasAnticonceptivas = table.Column<string>(type: "text", nullable: true),
                    EstaAmamantando = table.Column<string>(type: "text", nullable: true),
                    BebeBebidasAlcoholicas = table.Column<string>(type: "text", nullable: true),
                    AlcoholUltimas24Horas = table.Column<string>(type: "text", nullable: true),
                    AlcoholSemanal = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaRadiografiaDental = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Estetico_Metabolismo = table.Column<string>(type: "text", nullable: true),
                    Estetico_Grasa = table.Column<string>(type: "text", nullable: true),
                    Estetico_IMC = table.Column<string>(type: "text", nullable: true),
                    Estetico_Agua = table.Column<string>(type: "text", nullable: true),
                    Estetico_Obesidad = table.Column<string>(type: "text", nullable: true),
                    Estetico_ContornoBrazos = table.Column<string>(type: "text", nullable: true),
                    Estetico_ContornoBusto = table.Column<string>(type: "text", nullable: true),
                    Estetico_ContornoAbdomen = table.Column<string>(type: "text", nullable: true),
                    Estetico_ContornoCadera = table.Column<string>(type: "text", nullable: true),
                    Estetico_ContornoPiernas = table.Column<string>(type: "text", nullable: true),
                    Estetico_Estatura = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Citass_CitasId",
                        column: x => x.CitasId,
                        principalTable: "Citass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultas_EstadoPagoConsultas_EstadoPagoConsultaId",
                        column: x => x.EstadoPagoConsultaId,
                        principalTable: "EstadoPagoConsultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_ExamenFisico_ExamenFisicoId",
                        column: x => x.ExamenFisicoId,
                        principalTable: "ExamenFisico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultas_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleExamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExamenLabClinicoId = table.Column<int>(type: "integer", nullable: false),
                    ExamenId = table.Column<int>(type: "integer", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    Resultado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleExamenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleExamenes_Examenes_ExamenId",
                        column: x => x.ExamenId,
                        principalTable: "Examenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleExamenes_ExamenLabClinicos_ExamenLabClinicoId",
                        column: x => x.ExamenLabClinicoId,
                        principalTable: "ExamenLabClinicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentasLabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExamenId = table.Column<int>(type: "integer", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmpleadoResponsable = table.Column<string>(type: "text", nullable: true),
                    Vuelto = table.Column<decimal>(type: "numeric", nullable: false),
                    FormaPago = table.Column<string>(type: "text", nullable: true),
                    Eliminado = table.Column<bool>(type: "boolean", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasLabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasLabs_Examenes_ExamenId",
                        column: x => x.ExamenId,
                        principalTable: "Examenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServicioId = table.Column<int>(type: "integer", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    VentaServicioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleServicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleServicios_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleServicios_VentaServicios_VentaServicioId",
                        column: x => x.VentaServicioId,
                        principalTable: "VentaServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentaId = table.Column<int>(type: "integer", nullable: true),
                    CompraId = table.Column<int>(type: "integer", nullable: true),
                    VentaServicioId = table.Column<int>(type: "integer", nullable: true),
                    CajaId = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Gasto = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ingreso = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCaja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCaja_Cajas_CajaId",
                        column: x => x.CajaId,
                        principalTable: "Cajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCaja_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCaja_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCaja_VentaServicios_VentaServicioId",
                        column: x => x.VentaServicioId,
                        principalTable: "VentaServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCajaClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentaId = table.Column<int>(type: "integer", nullable: true),
                    CompraId = table.Column<int>(type: "integer", nullable: true),
                    VentaServicioId = table.Column<int>(type: "integer", nullable: true),
                    CajaClinicaId = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Gasto = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ingreso = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCajaClinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCajaClinicas_CajaClinicas_CajaClinicaId",
                        column: x => x.CajaClinicaId,
                        principalTable: "CajaClinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCajaClinicas_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCajaClinicas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCajaClinicas_VentaServicios_VentaServicioId",
                        column: x => x.VentaServicioId,
                        principalTable: "VentaServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentaId = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true),
                    ServicioId = table.Column<int>(type: "integer", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    BienOServicio = table.Column<string>(type: "text", nullable: true),
                    UsuarioAutorizaModificacion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultasCaracteristicasDentales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsultaId = table.Column<int>(type: "integer", nullable: true),
                    NumeroDiente = table.Column<int>(type: "integer", nullable: true),
                    Percusiones_VerticalMas = table.Column<bool>(type: "boolean", nullable: false),
                    Percusiones_HorizontalMas = table.Column<bool>(type: "boolean", nullable: false),
                    Percusiones_VerticalMenos = table.Column<bool>(type: "boolean", nullable: false),
                    Percusiones_HorizontalMenos = table.Column<bool>(type: "boolean", nullable: false),
                    Dolor_Localizado = table.Column<bool>(type: "boolean", nullable: false),
                    Dolor_Fugaz = table.Column<bool>(type: "boolean", nullable: false),
                    Dolor_Persistente = table.Column<bool>(type: "boolean", nullable: false),
                    Dolor_Referido = table.Column<bool>(type: "boolean", nullable: false),
                    Dolor_Espontaneo = table.Column<bool>(type: "boolean", nullable: false),
                    Estimulo_Frio = table.Column<bool>(type: "boolean", nullable: false),
                    Estimulo_Calor = table.Column<bool>(type: "boolean", nullable: false),
                    Estimulo_DulceAcido = table.Column<bool>(type: "boolean", nullable: false),
                    Estimulo_Masticacion = table.Column<bool>(type: "boolean", nullable: false),
                    Estimulo_Otro = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Positiva = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Negativa = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Localizada = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Fugaz = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Incrementa = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Referida = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Irradiado = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Persistente = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaFrio_Decrece = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Positiva = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Negativa = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Localizada = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Fugaz = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Incrementa = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Referida = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Irradiado = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Persistente = table.Column<bool>(type: "boolean", nullable: false),
                    TermicaCalor_Decrece = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_ManchaBlanca = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Caries = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Traumatismo = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Abfraccion = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Atricion = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Erosion = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Restauracion = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Ajustada = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_Desajustada = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_PulpaSana = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_PulpitisReversible = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_PulpitisIrreversible = table.Column<bool>(type: "boolean", nullable: false),
                    Diagnostico_NecrosisPulpar = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultasCaracteristicasDentales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultasCaracteristicasDentales_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultasServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsultaId = table.Column<int>(type: "integer", nullable: false),
                    ServicioId = table.Column<int>(type: "integer", nullable: false),
                    NumeroDiente = table.Column<int>(type: "integer", nullable: true),
                    Precio = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultasServicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultasServicios_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultasServicios_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsultaId = table.Column<int>(type: "integer", nullable: false),
                    NextDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescripcion_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatosExamenesLabClinicoId = table.Column<int>(type: "integer", nullable: true),
                    DetalleExamenId = table.Column<int>(type: "integer", nullable: true),
                    ValorResultado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resultados_DatosExamenesLabClinicos_DatosExamenesLabClinico~",
                        column: x => x.DatosExamenesLabClinicoId,
                        principalTable: "DatosExamenesLabClinicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resultados_DetalleExamenes_DetalleExamenId",
                        column: x => x.DetalleExamenId,
                        principalTable: "DetalleExamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCajaLab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentasLabId = table.Column<int>(type: "integer", nullable: true),
                    CajaLabId = table.Column<int>(type: "integer", nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Gasto = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Ingreso = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCajaLab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCajaLab_CajaLab_CajaLabId",
                        column: x => x.CajaLabId,
                        principalTable: "CajaLab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCajaLab_VentasLabs_VentasLabId",
                        column: x => x.VentasLabId,
                        principalTable: "VentasLabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VentaId = table.Column<int>(type: "integer", nullable: true),
                    VentaLabId = table.Column<int>(type: "integer", nullable: true),
                    FormaPagoId = table.Column<int>(type: "integer", nullable: false),
                    Monto = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_FormaPagos_FormaPagoId",
                        column: x => x.FormaPagoId,
                        principalTable: "FormaPagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_VentasLabs_VentaLabId",
                        column: x => x.VentaLabId,
                        principalTable: "VentasLabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallePrescripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Item = table.Column<int>(type: "integer", nullable: false),
                    Medicine = table.Column<string>(type: "text", nullable: true),
                    Qty = table.Column<string>(type: "text", nullable: true),
                    Indications = table.Column<string>(type: "text", nullable: true),
                    PrescripcionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePrescripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallePrescripcion_Prescripcion_PrescripcionId",
                        column: x => x.PrescripcionId,
                        principalTable: "Prescripcion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AntecedentesPersonales",
                columns: new[] { "Id", "NombreAntecedente" },
                values: new object[,]
                {
                    { 1, "Varicela" },
                    { 2, "Rubeola" },
                    { 3, "Sarampión" },
                    { 4, "Parotiditis" },
                    { 5, "Tosferina" },
                    { 6, "Escarlatina" },
                    { 7, "Parasitosis" },
                    { 8, "Hepatitis" },
                    { 9, "SIDA" },
                    { 10, "VIH" },
                    { 11, "Asma" },
                    { 12, "Disfunciones endocrinas" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec320394-8501-4710-a2ae-85e04315a5f9", "f0ef5d3c-d49c-400c-bd9e-2922e2040135", "Cajero", "CAJERO" },
                    { "785c160e-6a4f-4fd8-8121-4e6b2af230cd", "1d68c645-3793-4199-9c49-d94b686f4daa", "Administrador", "ADMINISTRADOR" },
                    { "d2716b4b-671d-4814-a04c-b51aa97051e8", "f2fec787-5993-408e-99b9-6ab0700b0da3", "Vendedor", "VENDEDOR" },
                    { "4e725ea5-282e-401c-9e82-da4947e382ef", "c2c91c44-3593-4915-a3f3-5c432a4d6511", "Mensajero", "MENSAJERO" },
                    { "3c06eaf3-10d4-40ae-bd00-3d50d629cfde", "08a41d26-eb17-4ca7-8dd2-2d7484b99307", "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "EmpleadoId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc6916f0-8d11-43a3-b143-37ce429bee33", 0, "87d60b6e-adcc-420d-850e-8ece046560f0", "User", "admin@redowl.com", false, null, true, null, "ADMIN@REDOWL.COM", "ADMIN@REDOWL.COM", "AQAAAAEAACcQAAAAEOdbAUoOXyLfj136OFPW/PbdVceTAniDgrlVyndM0MvgVtmW0dJI4bGJDdk/qoTkuA==", null, false, "44463e06-cf83-47f4-89e6-d55158f97ccb", false, "admin@redowl.com" });

            migrationBuilder.InsertData(
                table: "Bancos",
                columns: new[] { "Id", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { 6, null, "BANCO INTERNACIONAL S.A." },
                    { 3, null, "BANCO G&T CONTINENTAL S.A." },
                    { 2, null, "VIVIBANCO S.A." },
                    { 1, null, "BANCO AGROMERCANTIL DE GUATEMALA S.A." },
                    { 4, null, "BANCO DE AMERICA CENTRAL S.A." },
                    { 14, null, "BANCO INMOBILIARIO S.A." },
                    { 5, null, "BANCO FICOHSA GUATEMALA S.A." },
                    { 12, null, "EL CREDITO HIPOTECARIO NACIONAL DE GUATEMALA" },
                    { 9, null, "BANCO DE CREDITO S.A." },
                    { 8, null, "BANCO INDUSTRIAL S.A." },
                    { 7, null, "BANCO DE DESARROLLO RURAL S.A." },
                    { 11, null, "CITIBANK N.A SUCURSAL GUATEMALA" },
                    { 13, null, "BANCO DE LOS TRABAJADORES" },
                    { 10, null, "BANCO PROMERICA S.A." }
                });

            migrationBuilder.InsertData(
                table: "Especialidad",
                columns: new[] { "Id", "NombreEspecialidad" },
                values: new object[,]
                {
                    { 7, "Medicina interna" },
                    { 5, "Cirugía" },
                    { 9, "Cardiología" },
                    { 10, "Nutrición" },
                    { 4, "Pediatría" },
                    { 3, "Ginecología y Obstetricia" },
                    { 2, "Medicina estética" },
                    { 1, "Medicina general" },
                    { 6, "Traumatología" },
                    { 8, "Laboratorio clínico" }
                });

            migrationBuilder.InsertData(
                table: "EstadoExamenes",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 5, " Finalizados" },
                    { 4, " Revisión" },
                    { 3, " Cancelados" },
                    { 2, " En proceso" },
                    { 1, "Solicitados" }
                });

            migrationBuilder.InsertData(
                table: "EstadoPagoConsultas",
                columns: new[] { "Id", "Estado" },
                values: new object[,]
                {
                    { 3, "Cortesía" },
                    { 1, "Pagado" },
                    { 2, "Pendiente" }
                });

            migrationBuilder.InsertData(
                table: "EstadoRecepciones",
                columns: new[] { "Id", "Estado" },
                values: new object[,]
                {
                    { 1, "No ingresado" },
                    { 2, "Ingresado" }
                });

            migrationBuilder.InsertData(
                table: "EstadoTraslados",
                columns: new[] { "Id", "DescripcionEstado" },
                values: new object[,]
                {
                    { 1, "Aceptado" },
                    { 2, "Denegado" },
                    { 3, "Con problema" },
                    { 4, "Faltantes" },
                    { 5, "En tránsito" }
                });

            migrationBuilder.InsertData(
                table: "FormaPagos",
                columns: new[] { "Id", "NombreFormaPago" },
                values: new object[,]
                {
                    { 1, "Efectivo" },
                    { 6, "Visa Link" },
                    { 2, "Tarjeta de Débito" },
                    { 3, "Tarjeta de Crédito" },
                    { 4, "Cheques" },
                    { 5, "Transferencia" }
                });

            migrationBuilder.InsertData(
                table: "Sexo",
                columns: new[] { "Id", "DescripcionSexo" },
                values: new object[,]
                {
                    { 2, "Femenino" },
                    { 1, "Masculino" },
                    { 3, "Otro" }
                });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "Id", "Eliminado", "NombreSucursal" },
                values: new object[,]
                {
                    { 1, false, "La Gomera" },
                    { 2, false, "Zicapate" },
                    { 3, false, "Puerto de San José" },
                    { 4, false, "San Pedro Yepocapa" },
                    { 5, false, "Siquinalá" }
                });

            migrationBuilder.InsertData(
                table: "TipoBodega",
                columns: new[] { "Id", "DescripcionBodega" },
                values: new object[,]
                {
                    { 2, "CLINICA" },
                    { 3, "BODEGA" },
                    { 4, "LABORATORIO" },
                    { 1, "FARMACIA" }
                });

            migrationBuilder.InsertData(
                table: "TipoCompra",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "CONTADO" },
                    { 2, "CREDITO" }
                });

            migrationBuilder.InsertData(
                table: "TipoPatologias",
                columns: new[] { "Id", "Tipo", "VerInputDescripcion" },
                values: new object[,]
                {
                    { 11, "Aparentemente sano", false },
                    { 9, "Artritis", false },
                    { 10, "Otra", true },
                    { 7, "Enfermedades renales", false },
                    { 6, "SIDA", false },
                    { 1, "Diabetes", false },
                    { 2, "Cardiopatías", false },
                    { 5, "Malformaciones", false },
                    { 3, "Neoplasias", false },
                    { 4, "Epilepsia", false },
                    { 8, "Hepatitis", false }
                });

            migrationBuilder.InsertData(
                table: "TipoProductos",
                columns: new[] { "Id", "Eliminado", "NombreTipoProducto" },
                values: new object[,]
                {
                    { 12, false, "Equipos Médicos" },
                    { 13, false, "Muestras Médicas" },
                    { 11, false, "Insumos Médicos" },
                    { 10, false, "Medicamentos" }
                });

            migrationBuilder.InsertData(
                table: "Vacunas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 3, "Neumococo" },
                    { 4, "MMR" },
                    { 1, "Hexavalente" },
                    { 6, "Hepatitis A" },
                    { 7, "Influenza" },
                    { 8, "Papiloma Virus" },
                    { 9, "BCG" },
                    { 10, "Hepatitis B" },
                    { 11, "COVID-19" },
                    { 2, "Rotavirus" },
                    { 5, "Varicela" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "785c160e-6a4f-4fd8-8121-4e6b2af230cd", "dc6916f0-8d11-43a3-b143-37ce429bee33" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpleadoId",
                table: "AspNetUsers",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CajaLab_ResponsableAperturaLabId",
                table: "CajaLab",
                column: "ResponsableAperturaLabId");

            migrationBuilder.CreateIndex(
                name: "IX_CajaLab_ResponsableCierreLabId",
                table: "CajaLab",
                column: "ResponsableCierreLabId");

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_ResponsableAperturaId",
                table: "Cajas",
                column: "ResponsableAperturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_ResponsableCierreId",
                table: "Cajas",
                column: "ResponsableCierreId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EmpleadoId",
                table: "Citas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EspecialidadId",
                table: "Citas",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ServicioId",
                table: "Citas",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_UserId1",
                table: "Citas",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Citass_EmpleadoId",
                table: "Citass",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citass_EspecialidadId",
                table: "Citass",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Citass_PacienteId",
                table: "Citass",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citass_ServicioId",
                table: "Citass",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Citass_UserId1",
                table: "Citass",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_EmpleadoId",
                table: "Compras",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProveedorId",
                table: "Compras",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_TipoCompraId",
                table: "Compras",
                column: "TipoCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_CitasId",
                table: "Consultas",
                column: "CitasId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_EstadoPagoConsultaId",
                table: "Consultas",
                column: "EstadoPagoConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_ExamenFisicoId",
                table: "Consultas",
                column: "ExamenFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_HistoriaId",
                table: "Consultas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultasCaracteristicasDentales_ConsultaId",
                table: "ConsultasCaracteristicasDentales",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultasServicios_ConsultaId",
                table: "ConsultasServicios",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultasServicios_ServicioId",
                table: "ConsultasServicios",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentasPorCobrar_PacienteId",
                table: "CuentasPorCobrar",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosExamenesLabClinicos_ExamenLabClinicoId",
                table: "DatosExamenesLabClinicos",
                column: "ExamenLabClinicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCaja_CajaId",
                table: "DetalleCaja",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCaja_CompraId",
                table: "DetalleCaja",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCaja_VentaId",
                table: "DetalleCaja",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCaja_VentaServicioId",
                table: "DetalleCaja",
                column: "VentaServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaClinicas_CajaClinicaId",
                table: "DetalleCajaClinicas",
                column: "CajaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaClinicas_CompraId",
                table: "DetalleCajaClinicas",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaClinicas_VentaId",
                table: "DetalleCajaClinicas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaClinicas_VentaServicioId",
                table: "DetalleCajaClinicas",
                column: "VentaServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaLab_CajaLabId",
                table: "DetalleCajaLab",
                column: "CajaLabId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCajaLab_VentasLabId",
                table: "DetalleCajaLab",
                column: "VentasLabId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompras_CompraId",
                table: "DetalleCompras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompras_ProductoId",
                table: "DetalleCompras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizaciones_CotizacionId",
                table: "DetalleCotizaciones",
                column: "CotizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizaciones_ProductoId",
                table: "DetalleCotizaciones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizaciones_ServicioId",
                table: "DetalleCotizaciones",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEnvios_EnvioId",
                table: "DetalleEnvios",
                column: "EnvioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEnvios_ProductoId",
                table: "DetalleEnvios",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleExamenes_ExamenId",
                table: "DetalleExamenes",
                column: "ExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleExamenes_ExamenLabClinicoId",
                table: "DetalleExamenes",
                column: "ExamenLabClinicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePrescripcion_PrescripcionId",
                table: "DetallePrescripcion",
                column: "PrescripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleServicios_ServicioId",
                table: "DetalleServicios",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleServicios_VentaServicioId",
                table: "DetalleServicios",
                column: "VentaServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_ProductoId",
                table: "DetalleTraslado",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_TrasladosProductosId",
                table: "DetalleTraslado",
                column: "TrasladosProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_ProductoId",
                table: "DetalleVentas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_ServicioId",
                table: "DetalleVentas",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_VentaId",
                table: "DetalleVentas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_EstadosEnvioId",
                table: "Envios",
                column: "EstadosEnvioId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_RutaId",
                table: "Envios",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_UserId2",
                table: "Envios",
                column: "UserId2");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_ClinicaId",
                table: "Examenes",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_EmpleadoId",
                table: "Examenes",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_EstadoExamenId",
                table: "Examenes",
                column: "EstadoExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_MedicosId",
                table: "Examenes",
                column: "MedicosId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_PacienteId",
                table: "Examenes",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenLabClinicos_CategoriaLabClinicoId",
                table: "ExamenLabClinicos",
                column: "CategoriaLabClinicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_CategoriaGastoId",
                table: "Gastos",
                column: "CategoriaGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_SeguroEpssId",
                table: "Pacientes",
                column: "SeguroEpssId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_SexoId",
                table: "Pacientes",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesAntecedentesPersonales_AntecedentePersonalId",
                table: "PacientesAntecedentesPersonales",
                column: "AntecedentePersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesAntecedentesPersonales_PacienteId",
                table: "PacientesAntecedentesPersonales",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesFasesTratamiento_PacienteId",
                table: "PacientesFasesTratamiento",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesPreguntasRegistro_PacienteId",
                table: "PacientesPreguntasRegistro",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesPreguntasRegistro_PreguntaRegistroId",
                table: "PacientesPreguntasRegistro",
                column: "PreguntaRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesSeguimientosNutricionales_PacienteId",
                table: "PacientesSeguimientosNutricionales",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_FormaPagoId",
                table: "Pagos",
                column: "FormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_VentaId",
                table: "Pagos",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_VentaLabId",
                table: "Pagos",
                column: "VentaLabId");

            migrationBuilder.CreateIndex(
                name: "IX_PatologiasPacientes_PacienteId",
                table: "PatologiasPacientes",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripcion_ConsultaId",
                table: "Prescripcion",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_GrupoId",
                table: "Productos",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_GrupoTProductoId",
                table: "Productos",
                column: "GrupoTProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_LaboratorioProductoId",
                table: "Productos",
                column: "LaboratorioProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_NombreProducto_TipoBodegaId_Eliminado",
                table: "Productos",
                columns: new[] { "NombreProducto", "TipoBodegaId", "Eliminado" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PresentacionProductoId",
                table: "Productos",
                column: "PresentacionProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoBodegaId",
                table: "Productos",
                column: "TipoBodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoProductoId",
                table: "Productos",
                column: "TipoProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ViadminId",
                table: "Productos",
                column: "ViadminId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_BancoId",
                table: "Proveedores",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepciones_CompraId",
                table: "Recepciones",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepciones_EstadoRecepcionId",
                table: "Recepciones",
                column: "EstadoRecepcionId");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_DatosExamenesLabClinicoId",
                table: "Resultados",
                column: "DatosExamenesLabClinicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_DetalleExamenId",
                table: "Resultados",
                column: "DetalleExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_TrasladosProductos_EstadoTrasladosId",
                table: "TrasladosProductos",
                column: "EstadoTrasladosId");

            migrationBuilder.CreateIndex(
                name: "IX_TrasladosProductos_ResponsableEnviadoId",
                table: "TrasladosProductos",
                column: "ResponsableEnviadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TrasladosProductos_ResponsableRecibidoId",
                table: "TrasladosProductos",
                column: "ResponsableRecibidoId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasPacientes_PacienteId",
                table: "VacunasPacientes",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasPacientes_VacunaId",
                table: "VacunasPacientes",
                column: "VacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClientesId",
                table: "Ventas",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EnvioId",
                table: "Ventas",
                column: "EnvioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_PacienteId",
                table: "Ventas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaServicios_EmpleadoId",
                table: "VentaServicios",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaServicios_PacienteId",
                table: "VentaServicios",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasLabs_ExamenId",
                table: "VentasLabs",
                column: "ExamenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "ConsultasCaracteristicasDentales");

            migrationBuilder.DropTable(
                name: "ConsultasServicios");

            migrationBuilder.DropTable(
                name: "CuentasPorCobrar");

            migrationBuilder.DropTable(
                name: "DetalleCaja");

            migrationBuilder.DropTable(
                name: "DetalleCajaClinicas");

            migrationBuilder.DropTable(
                name: "DetalleCajaLab");

            migrationBuilder.DropTable(
                name: "DetalleCompras");

            migrationBuilder.DropTable(
                name: "DetalleCotizaciones");

            migrationBuilder.DropTable(
                name: "DetalleEnvios");

            migrationBuilder.DropTable(
                name: "DetallePrescripcion");

            migrationBuilder.DropTable(
                name: "DetalleServicios");

            migrationBuilder.DropTable(
                name: "DetalleTraslado");

            migrationBuilder.DropTable(
                name: "DetalleVentas");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Grabaciones");

            migrationBuilder.DropTable(
                name: "PacientesAntecedentesPersonales");

            migrationBuilder.DropTable(
                name: "PacientesFasesTratamiento");

            migrationBuilder.DropTable(
                name: "PacientesPreguntasRegistro");

            migrationBuilder.DropTable(
                name: "PacientesSeguimientosNutricionales");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "PatologiasPacientes");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "PersonaSeguro");

            migrationBuilder.DropTable(
                name: "Recepciones");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "TipoEspecialidad");

            migrationBuilder.DropTable(
                name: "TipoPatologias");

            migrationBuilder.DropTable(
                name: "VacunasPacientes");

            migrationBuilder.DropTable(
                name: "ViaAdministracion");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cajas");

            migrationBuilder.DropTable(
                name: "CajaClinicas");

            migrationBuilder.DropTable(
                name: "CajaLab");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Prescripcion");

            migrationBuilder.DropTable(
                name: "VentaServicios");

            migrationBuilder.DropTable(
                name: "TrasladosProductos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "CategoriasGastos");

            migrationBuilder.DropTable(
                name: "AntecedentesPersonales");

            migrationBuilder.DropTable(
                name: "PreguntasRegistro");

            migrationBuilder.DropTable(
                name: "FormaPagos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "VentasLabs");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "EstadoRecepciones");

            migrationBuilder.DropTable(
                name: "DatosExamenesLabClinicos");

            migrationBuilder.DropTable(
                name: "DetalleExamenes");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "EstadoTraslados");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "GrupoTProductos");

            migrationBuilder.DropTable(
                name: "LaboratorioProductos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "PresentacionProductos");

            migrationBuilder.DropTable(
                name: "TipoBodega");

            migrationBuilder.DropTable(
                name: "TipoProductos");

            migrationBuilder.DropTable(
                name: "Viadmin");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "TipoCompra");

            migrationBuilder.DropTable(
                name: "Examenes");

            migrationBuilder.DropTable(
                name: "ExamenLabClinicos");

            migrationBuilder.DropTable(
                name: "Citass");

            migrationBuilder.DropTable(
                name: "EstadoPagoConsultas");

            migrationBuilder.DropTable(
                name: "ExamenFisico");

            migrationBuilder.DropTable(
                name: "Historia");

            migrationBuilder.DropTable(
                name: "EstadosEnvio");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Clinicas");

            migrationBuilder.DropTable(
                name: "EstadoExamenes");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "CategoriaLabClinicos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "SegurosEpss");

            migrationBuilder.DropTable(
                name: "Sexo");
        }
    }
}
