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
    public interface IT_Sgpal_Presencia_AsbestosLN
    {
        IEnumerable<Presencia_AsbestosDTO> ListarPresencia_AsbestosDTO();
        Presencia_AsbestosDTO RecuperarPresencia_AsbestosDTOPorCodigo(int vId_Presencia_Asbestos);
        Presencia_AsbestosDTO InsertarPresencia_AsbestosDTO(Presencia_AsbestosDTO vPresencia_AsbestosDTO);
        Presencia_AsbestosDTO ActualizarPresencia_AsbestosDTO(Presencia_AsbestosDTO vPresencia_AsbestosDTO);
        int AnularPresencia_AsbestosDTOPorCodigo(Presencia_AsbestosDTO vPresencia_AsbestosDTO);
        IEnumerable<Presencia_AsbestosDTO> ListarPaginadoPresencia_AsbestosDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}