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
    public interface IT_Sgpal_Sensibilidad_AreaLN
    {
        IEnumerable<Sensibilidad_AreaDTO> ListarSensibilidad_AreaDTO();
        Sensibilidad_AreaDTO RecuperarSensibilidad_AreaDTOPorCodigo(int vId_Sensibilidad_Area);
        Sensibilidad_AreaDTO InsertarSensibilidad_AreaDTO(Sensibilidad_AreaDTO vSensibilidad_AreaDTO);
        Sensibilidad_AreaDTO ActualizarSensibilidad_AreaDTO(Sensibilidad_AreaDTO vSensibilidad_AreaDTO);
        int AnularSensibilidad_AreaDTOPorCodigo(Sensibilidad_AreaDTO vSensibilidad_AreaDTO);
        IEnumerable<Sensibilidad_AreaDTO> ListarPaginadoSensibilidad_AreaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}