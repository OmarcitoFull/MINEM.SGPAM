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
    public interface IT_Sgpal_Evidencia_InundacionLN
    {
        IEnumerable<Evidencia_InundacionDTO> ListarEvidencia_InundacionDTO();
        Evidencia_InundacionDTO RecuperarEvidencia_InundacionDTOPorCodigo(int vId_Evidencia_Inundacion);
        Evidencia_InundacionDTO InsertarEvidencia_InundacionDTO(Evidencia_InundacionDTO vEvidencia_InundacionDTO);
        Evidencia_InundacionDTO ActualizarEvidencia_InundacionDTO(Evidencia_InundacionDTO vEvidencia_InundacionDTO);
        int AnularEvidencia_InundacionDTOPorCodigo(Evidencia_InundacionDTO vEvidencia_InundacionDTO);
        IEnumerable<Evidencia_InundacionDTO> ListarPaginadoEvidencia_InundacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}