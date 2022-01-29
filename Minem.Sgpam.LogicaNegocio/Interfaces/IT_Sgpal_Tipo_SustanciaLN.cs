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
    public interface IT_Sgpal_Tipo_SustanciaLN
    {
        IEnumerable<Tipo_SustanciaDTO> ListarTipo_SustanciaDTO();
        Tipo_SustanciaDTO RecuperarTipo_SustanciaDTOPorCodigo(int vId_Tipo_Sustancia);
        Tipo_SustanciaDTO InsertarTipo_SustanciaDTO(Tipo_SustanciaDTO vTipo_SustanciaDTO);
        Tipo_SustanciaDTO ActualizarTipo_SustanciaDTO(Tipo_SustanciaDTO vTipo_SustanciaDTO);
        int AnularTipo_SustanciaDTOPorCodigo(Tipo_SustanciaDTO vTipo_SustanciaDTO);
        IEnumerable<Tipo_SustanciaDTO> ListarPaginadoTipo_SustanciaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}