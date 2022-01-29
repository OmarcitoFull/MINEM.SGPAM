using System;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class T_Sgpaj_Usuario_PerfilLN : BaseLN, IT_Sgpaj_Usuario_PerfilLN
    {
        private readonly IT_Sgpaj_Usuario_PerfilAD Usuario_PerfilAD;

        public T_Sgpaj_Usuario_PerfilLN(IT_Sgpaj_Usuario_PerfilAD vT_Sgpaj_Usuario_PerfilAD)
        {
            Usuario_PerfilAD = vT_Sgpaj_Usuario_PerfilAD;
        }

        public IEnumerable<Usuario_PerfilDTO> ListarUsuario_PerfilDTO()
        {
            try
            {
                var vResultado = Usuario_PerfilAD.ListarT_Sgpaj_Usuario_Perfil();
                return new List<Usuario_PerfilDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Usuario_PerfilDTO RecuperarUsuario_PerfilDTOPorCodigo(int vId_Usuario_Perfil)
        {
            try
            {
                var vResultado = Usuario_PerfilAD.RecuperarT_Sgpaj_Usuario_PerfilPorCodigo(vId_Usuario_Perfil);
                return new Usuario_PerfilDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Usuario_PerfilDTO InsertarUsuario_PerfilDTO(Usuario_PerfilDTO vUsuario_PerfilDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Usuario_Perfil();
                var vResultado = Usuario_PerfilAD.InsertarT_Sgpaj_Usuario_Perfil(vRegistro);
                return vUsuario_PerfilDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Usuario_PerfilDTO ActualizarUsuario_PerfilDTO(Usuario_PerfilDTO vUsuario_PerfilDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Usuario_Perfil();
                var vResultado = Usuario_PerfilAD.ActualizarT_Sgpaj_Usuario_Perfil(vRegistro);
                return vUsuario_PerfilDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularUsuario_PerfilDTOPorCodigo(Usuario_PerfilDTO vUsuario_PerfilDTO)
        {
            try
            {
                return Usuario_PerfilAD.AnularT_Sgpaj_Usuario_PerfilPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Usuario_PerfilDTO> ListarPaginadoUsuario_PerfilDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Usuario_PerfilAD.ListarPaginadoT_Sgpaj_Usuario_Perfil(vFiltro, vNumPag, vCantRegxPag);
                return new List<Usuario_PerfilDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
