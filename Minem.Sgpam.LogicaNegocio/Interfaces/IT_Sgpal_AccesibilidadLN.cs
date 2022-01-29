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
    public interface IT_Sgpal_AccesibilidadLN
    {
        IEnumerable<AccesibilidadDTO> ListarAccesibilidadDTO();
        AccesibilidadDTO RecuperarAccesibilidadDTOPorCodigo(int vId_Accesibilidad);
        AccesibilidadDTO InsertarAccesibilidadDTO(AccesibilidadDTO vAccesibilidadDTO);
        AccesibilidadDTO ActualizarAccesibilidadDTO(AccesibilidadDTO vAccesibilidadDTO);
        int AnularAccesibilidadDTOPorCodigo(AccesibilidadDTO vAccesibilidadDTO);
        IEnumerable<AccesibilidadDTO> ListarPaginadoAccesibilidadDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}