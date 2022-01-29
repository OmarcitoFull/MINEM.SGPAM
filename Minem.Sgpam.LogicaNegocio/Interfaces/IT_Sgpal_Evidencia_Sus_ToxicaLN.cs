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
    public interface IT_Sgpal_Evidencia_Sus_ToxicaLN
    {
        IEnumerable<Evidencia_Sus_ToxicaDTO> ListarEvidencia_Sus_ToxicaDTO();
        Evidencia_Sus_ToxicaDTO RecuperarEvidencia_Sus_ToxicaDTOPorCodigo(int vId_Evidencia_Sus_Toxica);
        Evidencia_Sus_ToxicaDTO InsertarEvidencia_Sus_ToxicaDTO(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO);
        Evidencia_Sus_ToxicaDTO ActualizarEvidencia_Sus_ToxicaDTO(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO);
        int AnularEvidencia_Sus_ToxicaDTOPorCodigo(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO);
        IEnumerable<Evidencia_Sus_ToxicaDTO> ListarPaginadoEvidencia_Sus_ToxicaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}