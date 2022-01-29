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
    public class T_Sgpaj_Tipo_Pam_Tipo_RecoLN : BaseLN, IT_Sgpaj_Tipo_Pam_Tipo_RecoLN
    {
        private readonly IT_Sgpaj_Tipo_Pam_Tipo_RecoAD Tipo_Pam_Tipo_RecoAD;

        public T_Sgpaj_Tipo_Pam_Tipo_RecoLN(IT_Sgpaj_Tipo_Pam_Tipo_RecoAD vT_Sgpaj_Tipo_Pam_Tipo_RecoAD)
        {
            Tipo_Pam_Tipo_RecoAD = vT_Sgpaj_Tipo_Pam_Tipo_RecoAD;
        }

        public IEnumerable<Tipo_Pam_Tipo_RecoDTO> ListarTipo_Pam_Tipo_RecoDTO()
        {
            try
            {
                var vResultado = Tipo_Pam_Tipo_RecoAD.ListarT_Sgpaj_Tipo_Pam_Tipo_Reco();
                return new List<Tipo_Pam_Tipo_RecoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_Pam_Tipo_RecoDTO RecuperarTipo_Pam_Tipo_RecoDTOPorCodigo(int vId_Tipo_Pam_Tipo_Reco)
        {
            try
            {
                var vResultado = Tipo_Pam_Tipo_RecoAD.RecuperarT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(vId_Tipo_Pam_Tipo_Reco);
                return new Tipo_Pam_Tipo_RecoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_Pam_Tipo_RecoDTO InsertarTipo_Pam_Tipo_RecoDTO(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Tipo_Pam_Tipo_Reco();
                var vResultado = Tipo_Pam_Tipo_RecoAD.InsertarT_Sgpaj_Tipo_Pam_Tipo_Reco(vRegistro);
                return vTipo_Pam_Tipo_RecoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_Pam_Tipo_RecoDTO ActualizarTipo_Pam_Tipo_RecoDTO(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Tipo_Pam_Tipo_Reco();
                var vResultado = Tipo_Pam_Tipo_RecoAD.ActualizarT_Sgpaj_Tipo_Pam_Tipo_Reco(vRegistro);
                return vTipo_Pam_Tipo_RecoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_Pam_Tipo_RecoDTOPorCodigo(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO)
        {
            try
            {
                return Tipo_Pam_Tipo_RecoAD.AnularT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_Pam_Tipo_RecoDTO> ListarPaginadoTipo_Pam_Tipo_RecoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_Pam_Tipo_RecoAD.ListarPaginadoT_Sgpaj_Tipo_Pam_Tipo_Reco(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_Pam_Tipo_RecoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
