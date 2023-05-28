using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using System;
using System.Linq;
using Database.Shared.DataBindings;

namespace Database.Shared.IRepository
{
    public interface ICuentasPorCobrar
    {
        IList<CuentaPorCobrar> GetList();
        void Add(CuentaPorCobrar model);
        void Update(CuentaPorCobrar model);
        CuentaPorCobrar Get(int cuentaId);
        public IList<FormaPago> GetFormasPago();
        public IList<Moneda> GetMonedas();
        public CuentaPorCobrar GetUltimaCuentaPendientePaciente(int pacienteId);
    }
}