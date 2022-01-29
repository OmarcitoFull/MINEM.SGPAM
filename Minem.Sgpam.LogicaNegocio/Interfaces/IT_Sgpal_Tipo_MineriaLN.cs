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
    public interface IT_Sgpal_Tipo_MineriaLN
    {
        IEnumerable<Tipo_MineriaDTO> ListarTipo_MineriaDTO();
        Tipo_MineriaDTO RecuperarTipo_MineriaDTOPorCodigo(int vId_Tipo_Mineria);
        Tipo_MineriaDTO InsertarTipo_MineriaDTO(Tipo_MineriaDTO vTipo_MineriaDTO);
        Tipo_MineriaDTO ActualizarTipo_MineriaDTO(Tipo_MineriaDTO vTipo_MineriaDTO);
        int AnularTipo_MineriaDTOPorCodigo(Tipo_MineriaDTO vTipo_MineriaDTO);
        IEnumerable<Tipo_MineriaDTO> ListarPaginadoTipo_MineriaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}