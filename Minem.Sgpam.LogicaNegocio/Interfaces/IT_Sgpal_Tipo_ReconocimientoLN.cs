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
    public interface IT_Sgpal_Tipo_ReconocimientoLN
    {
        IEnumerable<Tipo_ReconocimientoDTO> ListarTipo_ReconocimientoDTO();
        Tipo_ReconocimientoDTO RecuperarTipo_ReconocimientoDTOPorCodigo(int vId_Tipo_Reconocimiento);
        Tipo_ReconocimientoDTO InsertarTipo_ReconocimientoDTO(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO);
        Tipo_ReconocimientoDTO ActualizarTipo_ReconocimientoDTO(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO);
        int AnularTipo_ReconocimientoDTOPorCodigo(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO);
        IEnumerable<Tipo_ReconocimientoDTO> ListarPaginadoTipo_ReconocimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}