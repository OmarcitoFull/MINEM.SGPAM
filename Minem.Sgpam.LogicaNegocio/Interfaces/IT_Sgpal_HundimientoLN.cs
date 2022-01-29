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
    public interface IT_Sgpal_HundimientoLN
    {
        IEnumerable<HundimientoDTO> ListarHundimientoDTO();
        HundimientoDTO RecuperarHundimientoDTOPorCodigo(int vId_Hundimiento);
        HundimientoDTO InsertarHundimientoDTO(HundimientoDTO vHundimientoDTO);
        HundimientoDTO ActualizarHundimientoDTO(HundimientoDTO vHundimientoDTO);
        int AnularHundimientoDTOPorCodigo(HundimientoDTO vHundimientoDTO);
        IEnumerable<HundimientoDTO> ListarPaginadoHundimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}