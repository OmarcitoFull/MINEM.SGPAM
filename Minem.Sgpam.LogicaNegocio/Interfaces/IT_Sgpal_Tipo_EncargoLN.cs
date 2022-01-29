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
    public interface IT_Sgpal_Tipo_EncargoLN
    {
        IEnumerable<Tipo_EncargoDTO> ListarTipo_EncargoDTO();
        Tipo_EncargoDTO RecuperarTipo_EncargoDTOPorCodigo(int vId_Tipo_Encargo);
        Tipo_EncargoDTO InsertarTipo_EncargoDTO(Tipo_EncargoDTO vTipo_EncargoDTO);
        Tipo_EncargoDTO ActualizarTipo_EncargoDTO(Tipo_EncargoDTO vTipo_EncargoDTO);
        int AnularTipo_EncargoDTOPorCodigo(Tipo_EncargoDTO vTipo_EncargoDTO);
        IEnumerable<Tipo_EncargoDTO> ListarPaginadoTipo_EncargoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}