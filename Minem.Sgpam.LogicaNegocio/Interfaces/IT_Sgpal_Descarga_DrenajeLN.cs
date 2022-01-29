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
    public interface IT_Sgpal_Descarga_DrenajeLN
    {
        IEnumerable<Descarga_DrenajeDTO> ListarDescarga_DrenajeDTO();
        Descarga_DrenajeDTO RecuperarDescarga_DrenajeDTOPorCodigo(int vId_Descarga_Drenaje);
        Descarga_DrenajeDTO InsertarDescarga_DrenajeDTO(Descarga_DrenajeDTO vDescarga_DrenajeDTO);
        Descarga_DrenajeDTO ActualizarDescarga_DrenajeDTO(Descarga_DrenajeDTO vDescarga_DrenajeDTO);
        int AnularDescarga_DrenajeDTOPorCodigo(Descarga_DrenajeDTO vDescarga_DrenajeDTO);
        IEnumerable<Descarga_DrenajeDTO> ListarPaginadoDescarga_DrenajeDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}