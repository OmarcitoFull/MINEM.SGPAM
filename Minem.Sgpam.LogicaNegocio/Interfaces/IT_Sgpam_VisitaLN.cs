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
    public interface IT_Sgpam_VisitaLN
    {
        IEnumerable<VisitaDTO> ListarVisitaDTO();
        VisitaDTO RecuperarVisitaDTOPorCodigo(int vId_Visita);
        VisitaDTO InsertarVisitaDTO(VisitaDTO vVisitaDTO);
        VisitaDTO ActualizarVisitaDTO(VisitaDTO vVisitaDTO);
        int AnularVisitaDTOPorCodigo(VisitaDTO vVisitaDTO);
        IEnumerable<VisitaDTO> ListarPaginadoVisitaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}