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
    public interface IT_Sgpal_TemporalidadLN
    {
        IEnumerable<TemporalidadDTO> ListarTemporalidadDTO();
        TemporalidadDTO RecuperarTemporalidadDTOPorCodigo(int vId_Temporalidad);
        TemporalidadDTO InsertarTemporalidadDTO(TemporalidadDTO vTemporalidadDTO);
        TemporalidadDTO ActualizarTemporalidadDTO(TemporalidadDTO vTemporalidadDTO);
        int AnularTemporalidadDTOPorCodigo(TemporalidadDTO vTemporalidadDTO);
        IEnumerable<TemporalidadDTO> ListarPaginadoTemporalidadDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}