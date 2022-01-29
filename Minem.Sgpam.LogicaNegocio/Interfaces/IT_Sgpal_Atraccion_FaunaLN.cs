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
    public interface IT_Sgpal_Atraccion_FaunaLN
    {
        IEnumerable<Atraccion_FaunaDTO> ListarAtraccion_FaunaDTO();
        Atraccion_FaunaDTO RecuperarAtraccion_FaunaDTOPorCodigo(int vId_Atraccion_Fauna);
        Atraccion_FaunaDTO InsertarAtraccion_FaunaDTO(Atraccion_FaunaDTO vAtraccion_FaunaDTO);
        Atraccion_FaunaDTO ActualizarAtraccion_FaunaDTO(Atraccion_FaunaDTO vAtraccion_FaunaDTO);
        int AnularAtraccion_FaunaDTOPorCodigo(Atraccion_FaunaDTO vAtraccion_FaunaDTO);
        IEnumerable<Atraccion_FaunaDTO> ListarPaginadoAtraccion_FaunaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}