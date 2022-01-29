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
    public interface IT_Sgpal_Situacion_PamLN
    {
        IEnumerable<Situacion_PamDTO> ListarSituacion_PamDTO();
        Situacion_PamDTO RecuperarSituacion_PamDTOPorCodigo(int vId_Situacion_Pam);
        Situacion_PamDTO InsertarSituacion_PamDTO(Situacion_PamDTO vSituacion_PamDTO);
        Situacion_PamDTO ActualizarSituacion_PamDTO(Situacion_PamDTO vSituacion_PamDTO);
        int AnularSituacion_PamDTOPorCodigo(Situacion_PamDTO vSituacion_PamDTO);
        IEnumerable<Situacion_PamDTO> ListarPaginadoSituacion_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}