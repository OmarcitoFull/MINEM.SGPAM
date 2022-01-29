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
    public interface IT_Sgpal_Conflicto_SocialLN
    {
        IEnumerable<Conflicto_SocialDTO> ListarConflicto_SocialDTO();
        Conflicto_SocialDTO RecuperarConflicto_SocialDTOPorCodigo(int vId_Conflicto_Social);
        Conflicto_SocialDTO InsertarConflicto_SocialDTO(Conflicto_SocialDTO vConflicto_SocialDTO);
        Conflicto_SocialDTO ActualizarConflicto_SocialDTO(Conflicto_SocialDTO vConflicto_SocialDTO);
        int AnularConflicto_SocialDTOPorCodigo(Conflicto_SocialDTO vConflicto_SocialDTO);
        IEnumerable<Conflicto_SocialDTO> ListarPaginadoConflicto_SocialDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}