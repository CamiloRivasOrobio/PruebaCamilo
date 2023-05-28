using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    public class ConsultasRepository : IConsultas
    {
        private readonly Context _context = null;

        public ConsultasRepository(Context context)
        {
            _context = context;
        }

        public void Add(Consulta consulta, bool saveChanges = true)
        {
            _context.Consultas.Add(consulta);
            if (saveChanges) _context.SaveChanges();
        }

        public int AddConsulta(Consulta consulta)
        {
            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            return consulta.Id;
        }

        public void Update(Consulta consulta, bool saveChanges = true)
        {
            _context.Entry(consulta).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(ExamenFisico examen, bool saveChanges = true)
        {
            _context.Entry(examen).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public IList<Consulta> ListaConsultas()
        {
            return _context.Consultas
                .Include(a => a.Citas).ThenInclude(a => a.Paciente)
                .Include(a => a.Citas).ThenInclude(a => a.Empleado)
                .Include(a => a.Citas).ThenInclude(a => a.Servicio)
                .Include(a => a.Citas).ThenInclude(a => a.Especialidad)
                .Include(a => a.EstadoPagoConsulta)
                .OrderByDescending(a => a.FechaYHoraInicioConsulta).ToList();
        }

        public Consulta GetUltimaConsultaPaciente(int? idPaciente)
        {
            return _context.Consultas
                .Include(c => c.Citas)
                .Where(c => c.Citas.PacienteId == idPaciente)
                .OrderByDescending(c => c.Id)
                .FirstOrDefault();
        }

        public List<ConsultaCaracteristicaDental> GetCaracteristicasDentales(int? idConsulta)
        {
            return _context.ConsultasCaracteristicasDentales
            .Where(c => c.ConsultaId == (int)idConsulta)
            .ToList();
        }

        public List<ConsultaServicio> GetServiciosAgregados(int consultaId)
        {
            return _context.ConsultasServicios
            .Include(c => c.Servicio)
            .Where(c => c.ConsultaId == consultaId)
            .ToList();
        }

        public Consulta GetConsulta(int id, bool relatedEntities = true)
        {
            if (relatedEntities)
            {
                return _context.Consultas
                .Include(a => a.Citas).ThenInclude(a => a.Especialidad)
                .Include(a => a.Citas).ThenInclude(a => a.Servicio)
                .Include(a => a.Citas).ThenInclude(a => a.Empleado)
                .Include(a => a.Historia)
                .Include(a => a.Citas).ThenInclude(b => b.Paciente)
                .Include(a => a.Citas).ThenInclude(a => a.Paciente).ThenInclude(a => a.Sexo)
                .Include(a => a.Citas).ThenInclude(a => a.Paciente).ThenInclude(a => a.PacientesSeguimientosNutricionales)
                .Include(a => a.Citas).ThenInclude(a => a.Paciente).ThenInclude(a => a.VacunasPaciente)
                .Include(a => a.Citas).ThenInclude(a => a.Paciente).ThenInclude(a => a.VacunasPaciente).ThenInclude(a => a.Vacuna)
                .Include(t => t.ExamenFisico)
                .Include(a => a.ConsultasCaracteristicasDentales)
                .Include(a => a.ConsultasServicios).ThenInclude(a => a.Servicio)
                .Include(a => a.EstadoPagoConsulta)
                .Where(a => a.Id == id).SingleOrDefault();
            }
            else
            {
                return _context.Consultas.Where(a => a.Id == id).SingleOrDefault();
            }
        }

        public void AddPrescipcion(Prescripcion prescripcion)
        {
            _context.Prescripciones.Add(prescripcion);
            _context.SaveChanges();
        }

        public void AddDetallePrescipcion(DetallePrescripcion detallePrescripcion)
        {
            _context.DetallePrescripcion.Add(detallePrescripcion);
            _context.SaveChanges();
        }
        public Prescripcion GetPrescripcion(int prescripcionId) =>
        _context.Prescripciones
            .Include(x => x.Consulta).ThenInclude(x => x.Citas).ThenInclude(x => x.Paciente)
            .Include(x => x.DetallePrescripcion)
            .FirstOrDefault(x => x.Id == prescripcionId);

        public void UpdateTablePrescription()
        {
            _context.Database.ExecuteSqlRaw("UPDATE public.\"Prescripcion\" SET \"ConsultaId1\" = \"ConsultaId\";");
            _context.SaveChanges();
        }
    }
}