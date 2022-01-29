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
    public interface IT_Sgpal_Tipo_LnrLN
    {
        IEnumerable<Tipo_LnrDTO> ListarTipo_LnrDTO();
        Tipo_LnrDTO RecuperarTipo_LnrDTOPorCodigo(int vId_Tipo_Lnr);
        Tipo_LnrDTO InsertarTipo_LnrDTO(Tipo_LnrDTO vTipo_LnrDTO);
        Tipo_LnrDTO ActualizarTipo_LnrDTO(Tipo_LnrDTO vTipo_LnrDTO);
        int AnularTipo_LnrDTOPorCodigo(Tipo_LnrDTO vTipo_LnrDTO);
        IEnumerable<Tipo_LnrDTO> ListarPaginadoTipo_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}