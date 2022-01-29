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
    public interface IT_Sgpal_Condicion_CierreLN
    {
        IEnumerable<Condicion_CierreDTO> ListarCondicion_CierreDTO();
        Condicion_CierreDTO RecuperarCondicion_CierreDTOPorCodigo(int vId_Condicion_Cierre);
        Condicion_CierreDTO InsertarCondicion_CierreDTO(Condicion_CierreDTO vCondicion_CierreDTO);
        Condicion_CierreDTO ActualizarCondicion_CierreDTO(Condicion_CierreDTO vCondicion_CierreDTO);
        int AnularCondicion_CierreDTOPorCodigo(Condicion_CierreDTO vCondicion_CierreDTO);
        IEnumerable<Condicion_CierreDTO> ListarPaginadoCondicion_CierreDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}