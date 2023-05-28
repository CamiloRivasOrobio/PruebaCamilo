using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;

namespace sistema.Models
{
    public class CuentasPorCobrarPagarViewModel
    {
        //Datos de factura
        public string NoComprobante { get; set; }
        public int EmpleadoId { get; set; }

        //Datos de cuenta
        public int CuentaId { get; set; }
        public decimal Valor { get; set; }
        public string Observaciones { get; set; }

        //Datos del paciente
        public int PacienteId { get; set; }
        public string PacienteNombre { get; set; }
        public string PacienteNit { get; set; }
        public string PacienteDireccion { get; set; }

        //Datos de pago
        public int FormaPagoId { get; set; }
        public SelectList FormaPagoSelectListItems { get; set; }
        public int MonedaId { get; set; }
        public SelectList MonedaSelectListItems { get; set; }

        public void Init(ICuentasPorCobrar cuentasPorCobrarRepository)
        {
            FormaPagoSelectListItems = new SelectList(cuentasPorCobrarRepository.GetFormasPago(), "Id", "NombreFormaPago");
            MonedaSelectListItems = new SelectList(cuentasPorCobrarRepository.GetMonedas(), "Id", "NombreMoneda");
        }
    }
}
