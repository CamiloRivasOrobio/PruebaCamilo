using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    public class CuentasPorCobrarRepository : ICuentasPorCobrar
    {
        private readonly Context _context = null;

        public CuentasPorCobrarRepository(Context context)
        {
            _context = context;
        }

        public IList<CuentaPorCobrar> GetList()
        {
            return _context.CuentasPorCobrar
            .Include(a => a.Paciente)
            .Where(a => a.Eliminada == false)
            .ToList();
        }

        public void Add(CuentaPorCobrar model)
        {
            _context.CuentasPorCobrar.Add(model);
            _context.SaveChanges();
        }

        public CuentaPorCobrar Get(int cuentaId)
        {
            return _context.CuentasPorCobrar
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Where(a => a.Id == cuentaId).SingleOrDefault();
        }

        public void Update(CuentaPorCobrar model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IList<FormaPago> GetFormasPago()
        {
            return _context.FormaPagos
                .ToList();
        }
        public IList<Moneda> GetMonedas()
        {
            return _context.Monedas
                .ToList();
        }
        public CuentaPorCobrar GetUltimaCuentaPendientePaciente(int pacienteId)
        {
            return _context.CuentasPorCobrar
                .Where(c => c.PacienteId == pacienteId && c.Eliminada != false && !c.Pagada)
                .FirstOrDefault();
        }
    }
}