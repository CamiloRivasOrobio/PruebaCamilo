using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using System;
using System.Linq;
using Database.Shared.DataBindings;

namespace Database.Shared.IRepository
{
    public interface IConsultas
    {
        void Add(Consulta consulta, bool saveChanges = true);
        int AddConsulta(Consulta consulta);
        IList<Consulta> ListaConsultas();
        Consulta GetConsulta(int id, bool relatedEntities = true);
        List<ConsultaCaracteristicaDental> GetCaracteristicasDentales(int? idConsulta);
        List<ConsultaServicio> GetServiciosAgregados(int consultaId);
        Consulta GetUltimaConsultaPaciente(int? idPaciente);
        void Update(Consulta consulta, bool saveChanges = true);
        void Update(ExamenFisico examen, bool saveChanges = true);
        void AddPrescipcion(Prescripcion prescripcion);
        void AddDetallePrescipcion(DetallePrescripcion detallePrescripcion);
        Prescripcion GetPrescripcion(int prescripcionId);
        void UpdateTablePrescription();
    }
}