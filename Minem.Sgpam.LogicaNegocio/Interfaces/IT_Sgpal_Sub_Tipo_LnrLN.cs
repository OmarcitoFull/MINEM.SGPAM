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
    public interface IT_Sgpal_Sub_Tipo_LnrLN
    {
        IEnumerable<Sub_Tipo_LnrDTO> ListarSub_Tipo_LnrDTO();
        Sub_Tipo_LnrDTO RecuperarSub_Tipo_LnrDTOPorCodigo(int vId_Sub_Tipo_Lnr);
        Sub_Tipo_LnrDTO InsertarSub_Tipo_LnrDTO(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO);
        Sub_Tipo_LnrDTO ActualizarSub_Tipo_LnrDTO(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO);
        int AnularSub_Tipo_LnrDTOPorCodigo(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO);
        IEnumerable<Sub_Tipo_LnrDTO> ListarPaginadoSub_Tipo_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}