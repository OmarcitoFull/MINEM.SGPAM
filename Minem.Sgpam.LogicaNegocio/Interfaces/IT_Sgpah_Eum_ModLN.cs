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
    public interface IT_Sgpah_Eum_ModLN
    {
        IEnumerable<Eum_ModDTO> ListarEum_ModDTO();
        Eum_ModDTO RecuperarEum_ModDTOPorCodigo(int vId_Eum_Mod);
        Eum_ModDTO InsertarEum_ModDTO(Eum_ModDTO vEum_ModDTO);
        Eum_ModDTO ActualizarEum_ModDTO(Eum_ModDTO vEum_ModDTO);
        int AnularEum_ModDTOPorCodigo(Eum_ModDTO vEum_ModDTO);
        IEnumerable<Eum_ModDTO> ListarPaginadoEum_ModDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_ModDTO> ListarPorIdEumEum_ModDTO(int vId_Eum);
    }
}