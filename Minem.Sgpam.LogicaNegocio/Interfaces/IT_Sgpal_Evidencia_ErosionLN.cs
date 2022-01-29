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
    public interface IT_Sgpal_Evidencia_ErosionLN
    {
        IEnumerable<Evidencia_ErosionDTO> ListarEvidencia_ErosionDTO();
        Evidencia_ErosionDTO RecuperarEvidencia_ErosionDTOPorCodigo(int vId_Evidencia_Erosion);
        Evidencia_ErosionDTO InsertarEvidencia_ErosionDTO(Evidencia_ErosionDTO vEvidencia_ErosionDTO);
        Evidencia_ErosionDTO ActualizarEvidencia_ErosionDTO(Evidencia_ErosionDTO vEvidencia_ErosionDTO);
        int AnularEvidencia_ErosionDTOPorCodigo(Evidencia_ErosionDTO vEvidencia_ErosionDTO);
        IEnumerable<Evidencia_ErosionDTO> ListarPaginadoEvidencia_ErosionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}