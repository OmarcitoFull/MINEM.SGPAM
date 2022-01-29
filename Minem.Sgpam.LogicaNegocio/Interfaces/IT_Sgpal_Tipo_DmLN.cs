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
    public interface IT_Sgpal_Tipo_DmLN
    {
        IEnumerable<Tipo_DmDTO> ListarTipo_DmDTO();
        Tipo_DmDTO RecuperarTipo_DmDTOPorCodigo(int vId_Tipo_Dm);
        Tipo_DmDTO InsertarTipo_DmDTO(Tipo_DmDTO vTipo_DmDTO);
        Tipo_DmDTO ActualizarTipo_DmDTO(Tipo_DmDTO vTipo_DmDTO);
        int AnularTipo_DmDTOPorCodigo(Tipo_DmDTO vTipo_DmDTO);
        IEnumerable<Tipo_DmDTO> ListarPaginadoTipo_DmDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}