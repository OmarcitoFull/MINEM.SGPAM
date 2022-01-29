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
    public class T_Sgpam_UsuarioLN : BaseLN, IT_Sgpam_UsuarioLN
    {
        private readonly IT_Sgpam_UsuarioAD UsuarioAD;

        public T_Sgpam_UsuarioLN(IT_Sgpam_UsuarioAD vT_Sgpam_UsuarioAD)
        {
            UsuarioAD = vT_Sgpam_UsuarioAD;
        }

        public IEnumerable<UsuarioDTO> ListarUsuarioDTO()
        {
            try
            {
                var vResultado = UsuarioAD.ListarT_Sgpam_Usuario();
                return new List<UsuarioDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public UsuarioDTO RecuperarUsuarioDTOPorCodigo(int vId_Usuario)
        {
            try
            {
                var vResultado = UsuarioAD.RecuperarT_Sgpam_UsuarioPorCodigo(vId_Usuario);
                return new UsuarioDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public UsuarioDTO InsertarUsuarioDTO(UsuarioDTO vUsuarioDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Usuario();
                var vResultado = UsuarioAD.InsertarT_Sgpam_Usuario(vRegistro);
                return vUsuarioDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public UsuarioDTO ActualizarUsuarioDTO(UsuarioDTO vUsuarioDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Usuario();
                var vResultado = UsuarioAD.ActualizarT_Sgpam_Usuario(vRegistro);
                return vUsuarioDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularUsuarioDTOPorCodigo(UsuarioDTO vUsuarioDTO)
        {
            try
            {
                return UsuarioAD.AnularT_Sgpam_UsuarioPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<UsuarioDTO> ListarPaginadoUsuarioDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = UsuarioAD.ListarPaginadoT_Sgpam_Usuario(vFiltro, vNumPag, vCantRegxPag);
                return new List<UsuarioDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
