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
    public interface IT_Sgpal_CoberturaLN
    {
        IEnumerable<CoberturaDTO> ListarCoberturaDTO();
        CoberturaDTO RecuperarCoberturaDTOPorCodigo(int vId_Cobertura);
        CoberturaDTO InsertarCoberturaDTO(CoberturaDTO vCoberturaDTO);
        CoberturaDTO ActualizarCoberturaDTO(CoberturaDTO vCoberturaDTO);
        int AnularCoberturaDTOPorCodigo(CoberturaDTO vCoberturaDTO);
        IEnumerable<CoberturaDTO> ListarPaginadoCoberturaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}