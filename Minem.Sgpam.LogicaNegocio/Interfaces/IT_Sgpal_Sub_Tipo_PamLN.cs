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
    public interface IT_Sgpal_Sub_Tipo_PamLN
    {
        IEnumerable<Sub_Tipo_PamDTO> ListarSub_Tipo_PamDTO();
        Sub_Tipo_PamDTO RecuperarSub_Tipo_PamDTOPorCodigo(int vId_Sub_Tipo_Pam);
        Sub_Tipo_PamDTO InsertarSub_Tipo_PamDTO(Sub_Tipo_PamDTO vSub_Tipo_PamDTO);
        Sub_Tipo_PamDTO ActualizarSub_Tipo_PamDTO(Sub_Tipo_PamDTO vSub_Tipo_PamDTO);
        int AnularSub_Tipo_PamDTOPorCodigo(Sub_Tipo_PamDTO vSub_Tipo_PamDTO);
        IEnumerable<Sub_Tipo_PamDTO> ListarPaginadoSub_Tipo_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}