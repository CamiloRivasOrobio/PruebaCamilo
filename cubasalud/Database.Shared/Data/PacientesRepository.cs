using System.Reflection.Metadata;
using System.ComponentModel;
using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using Database.Shared.Enumeraciones;

namespace Database.Shared.Data
{
    public class PacientesRepository : IPacientes
    {
        private readonly Context _context = null;
        public PacientesRepository(Context context)
        {
            _context = context;
        }

        public Paciente Add(Paciente cliente, bool saveChanges = true)
        {
            _context.Pacientes.Add(cliente);

            if (saveChanges)
            {
                _context.SaveChanges();
            }

            return cliente;
        }
        public PacienteHistorial AddHistorial(PacienteHistorial historial)
        {
            _context.PacientesHistorial.Add(historial);
            _context.SaveChanges();
            return historial;
        }
        public List<PacienteHistorial> GetHistorial(int pacienteId)
        {
            return _context.PacientesHistorial
                .Where(p => p.PacienteId == pacienteId)
                .ToList();
        }
        public List<TipoPatologia> GetTipoPatologias()
        {
            return _context.TipoPatologias.ToList();
        }
        public List<PatologiaPaciente> GetAntecedentesFamiliaresPaciente(int pacienteId)
        {
            return _context.PatologiasPacientes
            .Include(v => v.TipoPatologia)
            .Where(a => a.PacienteId == pacienteId)
            .ToList();
        }
        public List<PersonaSeguro> GetPersonasSeguro(int pacienteId)
        {
            return _context.PersonasSeguro
            .Where(a => a.PacienteId == pacienteId)
            .ToList();
        }
        //vacunas paciente
        public List<Vacuna> GetVacunas()
        {
            return _context.Vacunas.ToList();
        }
        public List<VacunaPaciente> GetVacunasPaciente(int idPaciente)
        {
            return _context.VacunasPacientes
            .Include(v => v.Vacuna)
            .Where(a => a.PacienteId == idPaciente)
            .ToList();
        }
        public void UpdateVacuna(VacunaPaciente vacunaPaciente)
        {
            var vacuna = _context.VacunasPacientes.Where(v => v.Id == vacunaPaciente.Id).FirstOrDefault();
            vacuna.Primera = vacunaPaciente.Primera;
            vacuna.FechaPrimera = vacunaPaciente.FechaPrimera;
            vacuna.Segunda = vacunaPaciente.Segunda;
            vacuna.FechaSegunda = vacunaPaciente.FechaSegunda;
            vacuna.Tercera = vacunaPaciente.Tercera;
            vacuna.FechaTercera = vacunaPaciente.FechaTercera;
            vacuna.PrimerRefuerzo = vacunaPaciente.PrimerRefuerzo;
            vacuna.FechaPrimerRefuerzo = vacunaPaciente.FechaPrimerRefuerzo;
            vacuna.SegundoRefuerzo = vacunaPaciente.SegundoRefuerzo;
            vacuna.FechaSegundoRefuerzo = vacunaPaciente.FechaSegundoRefuerzo;

            _context.Entry(vacuna).State = EntityState.Modified;
            _context.SaveChanges();
        }


        //Antecedentes personales
        public List<AntecedentePersonal> GetAntecedentesPersonales()
        {
            return _context.AntecedentesPersonales.ToList();
        }
        public List<PacienteAntecedentePersonal> GetAntecedentesPersonalesPaciente(int idPaciente)
        {
            return _context.PacientesAntecedentesPersonales
            .Include(v => v.AntecedentePersonal)
            .Where(a => a.PacienteId == idPaciente)
            .ToList();
        }

        //Preguntas registro
        public List<PreguntaRegistro> GetPreguntasRegistro()
        {
            return _context.PreguntasRegistro.ToList();
        }
        public List<PacientePreguntaRegistro> GetPreguntasRegistroPaciente(int idPaciente)
        {
            return _context.PacientesPreguntasRegistro
            .Include(v => v.PreguntaRegistro)
            .Where(a => a.PacienteId == idPaciente)
            .ToList();
        }
        public List<PacienteRangoSaludable> GetRangosSaludablesPaciente(int pacienteId)
        {
            return _context.PacientesRangosSaludables
            .Where(s => s.PacienteId == pacienteId)
            .ToList();
        }
        public List<PacienteSeguimientoNutricional> GetSeguimientosNutricionalesPaciente(int idPaciente)
        {
            return _context.PacientesSeguimientosNutricionales
            .Where(s => s.PacienteId == idPaciente)
            .ToList();
        }
        public void AddSeguimientoNutricional(PacienteSeguimientoNutricional seguimiento)
        {
            _context.PacientesSeguimientosNutricionales.Add(seguimiento);
            _context.SaveChanges();
        }
        public void UpdateSeguimientoNutricional(PacienteSeguimientoNutricional seguimiento)
        {
            var seguimientoEditado = _context.PacientesSeguimientosNutricionales
                                    .Where(p => p.Id == seguimiento.Id)
                                    .FirstOrDefault();
            seguimientoEditado.Fecha = seguimiento.Fecha;
            seguimientoEditado.Peso = seguimiento.Peso;
            seguimientoEditado.IMC = seguimiento.IMC;
            seguimientoEditado.PGC = seguimiento.PGC;
            seguimientoEditado.Cuello = seguimiento.Cuello;
            seguimientoEditado.Busto = seguimiento.Busto;
            seguimientoEditado.CinturaAbdomen = seguimiento.CinturaAbdomen;
            seguimientoEditado.Cadera = seguimiento.Cadera;
            seguimientoEditado.Muslo = seguimiento.Muslo;
            seguimientoEditado.Brazo = seguimiento.Brazo;
            seguimientoEditado.Muñeca = seguimiento.Muñeca;
            _context.Entry(seguimientoEditado).State = EntityState.Modified;
            _context.Entry(seguimientoEditado).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void AddResultadoExamenLaboratorio(PacienteResultadoExamenLaboratorio resultado)
        {
            _context.PacientesResultadosExamenesLaboratorio.Add(resultado);
            _context.SaveChanges();
        }
        public void UpdateResultadoExamenLaboratorio(PacienteResultadoExamenLaboratorio resultado)
        {
            _context.Entry(resultado).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IList<Sexo> GetSexosList()
        {
            return _context.Sexo.ToList();
        }
        public IList<TipoPaciente> GetTiposPaciente()
        {
            return _context.TiposPacientes
                .ToList();
        }
        public IList<SeguroEpss> GetSegurosEpssList()
        {
            return _context.SegurosEpss.ToList();
        }
        public Paciente Get(int pacienteId, bool includeRelatedEntities = true)
        {
            var paciente = _context.Pacientes
                .Where(p => p.Id == pacienteId).FirstOrDefault();

            if (includeRelatedEntities)
            {
                //La razon por la que no se hace la consulta con el include de las
                //entidades relacionadas desde el principio
                //es para que la consulta no de la excepcion de time out expired
                //Por esa razon, se consulta primero al paciente y despues todas
                //las entidades enlazadas solamente de ese paciente
                paciente.Sexo = _context.Sexo
                    .Where(s => s.Id == paciente.SexoId)
                    .FirstOrDefault();
                paciente.PacientesFasesTratamiento = _context.PacientesFasesTratamiento
                    .Include(p => p.FaseTratamiento)
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.PacienteArchivos = _context.PacienteArchivos
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.PacientesAntecedentesPersonales = _context.PacientesAntecedentesPersonales
                    .Include(p => p.AntecedentePersonal)
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.PacientesPreguntasRegistro = _context.PacientesPreguntasRegistro
                    .Include(p => p.PreguntaRegistro)
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.SeguroEpss = _context.SegurosEpss
                    .Where(p => p.Id == paciente.SeguroEpssId)
                    .FirstOrDefault();
                paciente.TipoPaciente = _context.TiposPacientes
                    .Where(p => p.Id == paciente.TipoPacienteId)
                    .FirstOrDefault();
                paciente.VacunasPaciente = _context.VacunasPacientes
                    .Include(p => p.Vacuna)
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.PatologiasPaciente = _context.PatologiasPacientes
                    .Include(p => p.TipoPatologia)
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
                paciente.PersonasSeguro = _context.PersonasSeguro
                    .Where(p => p.PacienteId == pacienteId)
                    .ToList();
            }

            return paciente;
        }
        public PacienteFaseTratamiento GetFaseTratamientoActual(int pacienteId)
        {
            return _context.PacientesFasesTratamiento
                .Include(p => p.FaseTratamiento)
                .Where(p => p.PacienteId == pacienteId
                 && !p.FaseFinalizada)
                .FirstOrDefault();
        }
        public List<Paciente> GetList()
        {
            return _context.Pacientes
                .Include(p => p.Sexo)
                .Where(x => x.Eliminado == false).OrderBy(x => x.Nombre).ToList();
        }
        public List<Paciente> GetPacientesInactivos()
        {
            return _context.Pacientes
                .Include(p => p.PacienteHistorial)
                .Where(p => p.EstadoPacienteId == (int)EstadoPacienteEnum.Inactivo)
                .ToList();
        }
        public List<EstadoExamen> GetListEstadosExamen()
        {
            return _context.EstadoExamenes.OrderBy(a => a.Nombre).ToList();
        }
        public void Update(Paciente model, bool saveChanges = true)
        {
            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }
        public Paciente GetPacientePorNombre(string nombre)
        {
            return _context.Pacientes.Where(a => a.Nombre == nombre && a.Eliminado == false).FirstOrDefault();
        }
        public Paciente GetPacientePorId(int id)
        {
            return _context.Pacientes.Where(a => a.Id == id && a.Eliminado == false).SingleOrDefault();
        }
        public int LastPatientGenerate()
        {
            return _context.Pacientes.OrderByDescending(p => p.Id).FirstOrDefault()?.Id + 1 ?? 0;
        }
        public IList<FaseTratamiento> GetFasesTratamiento()
        {
            return _context.FasesTratamiento
                .ToList();
        }
        public IList<PacienteFaseTratamiento> GetFasesTratamientoPacientes()
        {
            return _context.PacientesFasesTratamiento
                .Include(f => f.FaseTratamiento)
                .Include(f => f.Paciente)
                .ToList();
        }
    }
}