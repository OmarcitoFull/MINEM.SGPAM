using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public interface IT_Sgpam_ExpedienteLN
    {
        IEnumerable<ExpedienteDTO> ListarExpedienteDTO();
        ExpedienteDTO RecuperarExpedienteDTOPorCodigo(int vId_Expediente);
        ExpedienteDTO InsertarExpedienteDTO(ExpedienteDTO vExpedienteDTO);
        ExpedienteDTO ActualizarExpedienteDTO(ExpedienteDTO vExpedienteDTO);
        int AnularExpedienteDTOPorCodigo(ExpedienteDTO vExpedienteDTO);
        IEnumerable<ExpedienteDTO> ListarPaginadoExpedienteDTO(string vNroExp, string vFiltro, int vNumPag, int vCantRegxPag);
    }
}