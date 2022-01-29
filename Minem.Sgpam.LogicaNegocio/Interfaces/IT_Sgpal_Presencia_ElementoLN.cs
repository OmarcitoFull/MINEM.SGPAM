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
    public interface IT_Sgpal_Presencia_ElementoLN
    {
        IEnumerable<Presencia_ElementoDTO> ListarPresencia_ElementoDTO();
        Presencia_ElementoDTO RecuperarPresencia_ElementoDTOPorCodigo(int vId_Presencia_Elemento);
        Presencia_ElementoDTO InsertarPresencia_ElementoDTO(Presencia_ElementoDTO vPresencia_ElementoDTO);
        Presencia_ElementoDTO ActualizarPresencia_ElementoDTO(Presencia_ElementoDTO vPresencia_ElementoDTO);
        int AnularPresencia_ElementoDTOPorCodigo(Presencia_ElementoDTO vPresencia_ElementoDTO);
        IEnumerable<Presencia_ElementoDTO> ListarPaginadoPresencia_ElementoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}