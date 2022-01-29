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
    public interface IT_Sgpal_Tipo_PamLN
    {
        IEnumerable<Tipo_PamDTO> ListarTipo_PamDTO();
        Tipo_PamDTO RecuperarTipo_PamDTOPorCodigo(int vId_Tipo_Pam);
        Tipo_PamDTO InsertarTipo_PamDTO(Tipo_PamDTO vTipo_PamDTO);
        Tipo_PamDTO ActualizarTipo_PamDTO(Tipo_PamDTO vTipo_PamDTO);
        int AnularTipo_PamDTOPorCodigo(Tipo_PamDTO vTipo_PamDTO);
        IEnumerable<Tipo_PamDTO> ListarPaginadoTipo_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}