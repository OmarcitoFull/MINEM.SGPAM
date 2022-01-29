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
    public interface IT_Sgpaj_Usuario_PerfilLN
    {
        IEnumerable<Usuario_PerfilDTO> ListarUsuario_PerfilDTO();
        Usuario_PerfilDTO RecuperarUsuario_PerfilDTOPorCodigo(int vId_Usuario_Perfil);
        Usuario_PerfilDTO InsertarUsuario_PerfilDTO(Usuario_PerfilDTO vUsuario_PerfilDTO);
        Usuario_PerfilDTO ActualizarUsuario_PerfilDTO(Usuario_PerfilDTO vUsuario_PerfilDTO);
        int AnularUsuario_PerfilDTOPorCodigo(Usuario_PerfilDTO vUsuario_PerfilDTO);
        IEnumerable<Usuario_PerfilDTO> ListarPaginadoUsuario_PerfilDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}