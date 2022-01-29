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
    public interface IT_Sgpal_RegionLN
    {
        IEnumerable<RegionDTO> ListarRegionDTO();
        RegionDTO RecuperarRegionDTOPorCodigo(int vId_Region);
        RegionDTO InsertarRegionDTO(RegionDTO vRegionDTO);
        RegionDTO ActualizarRegionDTO(RegionDTO vRegionDTO);
        int AnularRegionDTOPorCodigo(RegionDTO vRegionDTO);
        IEnumerable<RegionDTO> ListarPaginadoRegionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}