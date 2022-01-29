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
    public interface IT_Sgpad_Eum_InspeccionLN
    {
        IEnumerable<Eum_InspeccionDTO> ListarEum_InspeccionDTO();
        Eum_InspeccionDTO RecuperarEum_InspeccionDTOPorCodigo(int vId_Eum_Inspeccion);
        Eum_InspeccionDTO InsertarEum_InspeccionDTO(Eum_InspeccionDTO vEum_InspeccionDTO);
        Eum_InspeccionDTO ActualizarEum_InspeccionDTO(Eum_InspeccionDTO vEum_InspeccionDTO);
        int AnularEum_InspeccionDTOPorCodigo(Eum_InspeccionDTO vEum_InspeccionDTO);
        IEnumerable<Eum_InspeccionDTO> ListarPaginadoEum_InspeccionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_InspeccionDTO> ListarPorIdEumEum_InspeccionDTO(int vId_Eum);

    }
}