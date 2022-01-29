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
    public interface IT_Sgpal_Contencion_ResiduoLN
    {
        IEnumerable<Contencion_ResiduoDTO> ListarContencion_ResiduoDTO();
        Contencion_ResiduoDTO RecuperarContencion_ResiduoDTOPorCodigo(int vId_Contencion_Residuo);
        Contencion_ResiduoDTO InsertarContencion_ResiduoDTO(Contencion_ResiduoDTO vContencion_ResiduoDTO);
        Contencion_ResiduoDTO ActualizarContencion_ResiduoDTO(Contencion_ResiduoDTO vContencion_ResiduoDTO);
        int AnularContencion_ResiduoDTOPorCodigo(Contencion_ResiduoDTO vContencion_ResiduoDTO);
        IEnumerable<Contencion_ResiduoDTO> ListarPaginadoContencion_ResiduoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}