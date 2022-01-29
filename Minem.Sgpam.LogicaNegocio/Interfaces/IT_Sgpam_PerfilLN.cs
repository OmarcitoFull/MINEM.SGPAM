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
    public interface IT_Sgpam_PerfilLN
    {
        IEnumerable<PerfilDTO> ListarPerfilDTO();
        PerfilDTO RecuperarPerfilDTOPorCodigo(int vId_Perfil);
        PerfilDTO InsertarPerfilDTO(PerfilDTO vPerfilDTO);
        PerfilDTO ActualizarPerfilDTO(PerfilDTO vPerfilDTO);
        int AnularPerfilDTOPorCodigo(PerfilDTO vPerfilDTO);
        IEnumerable<PerfilDTO> ListarPaginadoPerfilDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}