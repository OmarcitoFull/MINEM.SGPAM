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
    public interface IT_Sgpad_LnrLN
    {
        IEnumerable<LnrDTO> ListarLnrDTO();
        LnrDTO RecuperarLnrDTOPorCodigo(int vId_Lnr);
        LnrDTO GrabarLnrDTO(LnrDTO vLnrDTO);
        int AnularLnrDTOPorCodigo(LnrDTO vLnrDTO);
        IEnumerable<LnrDTO> ListarPaginadoLnrDTO(int vIdExpediente, int vNumPag, int vCantRegxPag);
        RegistrarLnrDTO RecuperarFullLnrDTOPorCodigo(int vId_Lnr);
        IEnumerable<LnrDTO> ListarPorIdExpedienteLnrDTO(int vId_Expediente);
        RegistrarEvaluacionLnrDTO RecuperarFullEvaluarLnrDTOPorCodigo(int vId_Lnr);
    }
}