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
    public class T_Sgpam_PerfilLN : BaseLN, IT_Sgpam_PerfilLN
    {
        private readonly IT_Sgpam_PerfilAD PerfilAD;

        public T_Sgpam_PerfilLN(IT_Sgpam_PerfilAD vT_Sgpam_PerfilAD)
        {
            PerfilAD = vT_Sgpam_PerfilAD;
        }

        public IEnumerable<PerfilDTO> ListarPerfilDTO()
        {
            try
            {
                var vResultado = PerfilAD.ListarT_Sgpam_Perfil();
                return new List<PerfilDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public PerfilDTO RecuperarPerfilDTOPorCodigo(int vId_Perfil)
        {
            try
            {
                var vResultado = PerfilAD.RecuperarT_Sgpam_PerfilPorCodigo(vId_Perfil);
                return new PerfilDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public PerfilDTO InsertarPerfilDTO(PerfilDTO vPerfilDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Perfil();
                var vResultado = PerfilAD.InsertarT_Sgpam_Perfil(vRegistro);
                return vPerfilDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public PerfilDTO ActualizarPerfilDTO(PerfilDTO vPerfilDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Perfil();
                var vResultado = PerfilAD.ActualizarT_Sgpam_Perfil(vRegistro);
                return vPerfilDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPerfilDTOPorCodigo(PerfilDTO vPerfilDTO)
        {
            try
            {
                return PerfilAD.AnularT_Sgpam_PerfilPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<PerfilDTO> ListarPaginadoPerfilDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = PerfilAD.ListarPaginadoT_Sgpam_Perfil(vFiltro, vNumPag, vCantRegxPag);
                return new List<PerfilDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
