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
    public interface IT_Sgpal_Tipo_ConcesionLN
    {
        IEnumerable<Tipo_ConcesionDTO> ListarTipo_ConcesionDTO();
        Tipo_ConcesionDTO RecuperarTipo_ConcesionDTOPorCodigo(int vId_Tipo_Concesion);
        Tipo_ConcesionDTO InsertarTipo_ConcesionDTO(Tipo_ConcesionDTO vTipo_ConcesionDTO);
        Tipo_ConcesionDTO ActualizarTipo_ConcesionDTO(Tipo_ConcesionDTO vTipo_ConcesionDTO);
        int AnularTipo_ConcesionDTOPorCodigo(Tipo_ConcesionDTO vTipo_ConcesionDTO);
        IEnumerable<Tipo_ConcesionDTO> ListarPaginadoTipo_ConcesionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}