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
        ExpedienteDTO GrabarExpedienteDTO(ExpedienteDTO vExpedienteDTO);
        int AnularExpedienteDTOPorCodigo(ExpedienteDTO vExpedienteDTO);
        IEnumerable<ExpedienteDTO> ListarPaginadoExpedienteDTO(string vNroExp, string vZona, string vUbigeo, int vNumPag, int vCantRegxPag);
        RegistrarExpedienteDTO RecuperarFullExpedienteDTOPorCodigo(int vId_Expediente);
        IEnumerable<ExpedienteDTO> ListaAutocompletarExpedienteDTO(string vNroExp);
    }
}