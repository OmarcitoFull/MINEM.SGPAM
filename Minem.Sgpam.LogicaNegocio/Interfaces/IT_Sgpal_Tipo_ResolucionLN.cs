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
    public interface IT_Sgpal_Tipo_ResolucionLN
    {
        IEnumerable<Tipo_ResolucionDTO> ListarTipo_ResolucionDTO();
        Tipo_ResolucionDTO RecuperarTipo_ResolucionDTOPorCodigo(int vId_Tipo_Resolucion);
        Tipo_ResolucionDTO InsertarTipo_ResolucionDTO(Tipo_ResolucionDTO vTipo_ResolucionDTO);
        Tipo_ResolucionDTO ActualizarTipo_ResolucionDTO(Tipo_ResolucionDTO vTipo_ResolucionDTO);
        int AnularTipo_ResolucionDTOPorCodigo(Tipo_ResolucionDTO vTipo_ResolucionDTO);
        IEnumerable<Tipo_ResolucionDTO> ListarPaginadoTipo_ResolucionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}