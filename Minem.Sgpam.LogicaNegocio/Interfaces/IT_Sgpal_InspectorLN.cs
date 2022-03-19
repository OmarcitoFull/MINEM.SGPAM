using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public interface IT_Sgpal_InspectorLN
    {
        IEnumerable<InspectorDTO> ListarInspectorDTO();
        InspectorDTO RecuperarInspectorDTOPorCodigo(int vId_Inspector);
        InspectorDTO InsertarInspectorDTO(InspectorDTO vInspectorDTO);
        InspectorDTO ActualizarInspectorDTO(InspectorDTO vInspectorDTO);
        int AnularInspectorDTOPorCodigo(InspectorDTO vInspectorDTO);
        IEnumerable<InspectorDTO> ListarPaginadoInspectorDTO(string vFiltro, int vNumPag, int vCantRegxPag);

    }
}
