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
    public class T_Sgpal_Situacion_PamLN : BaseLN, IT_Sgpal_Situacion_PamLN
    {
        private readonly IT_Sgpal_Situacion_PamAD Situacion_PamAD;

        public T_Sgpal_Situacion_PamLN(IT_Sgpal_Situacion_PamAD vT_Sgpal_Situacion_PamAD)
        {
            Situacion_PamAD = vT_Sgpal_Situacion_PamAD;
        }

        public IEnumerable<Situacion_PamDTO> ListarSituacion_PamDTO()
        {
            try
            {
                var vResultado = Situacion_PamAD.ListarT_Sgpal_Situacion_Pam();
                return new List<Situacion_PamDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Situacion_PamDTO RecuperarSituacion_PamDTOPorCodigo(int vId_Situacion_Pam)
        {
            try
            {
                var vResultado = Situacion_PamAD.RecuperarT_Sgpal_Situacion_PamPorCodigo(vId_Situacion_Pam);
                return new Situacion_PamDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Situacion_PamDTO InsertarSituacion_PamDTO(Situacion_PamDTO vSituacion_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Situacion_Pam();
                var vResultado = Situacion_PamAD.InsertarT_Sgpal_Situacion_Pam(vRegistro);
                return vSituacion_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Situacion_PamDTO ActualizarSituacion_PamDTO(Situacion_PamDTO vSituacion_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Situacion_Pam();
                var vResultado = Situacion_PamAD.ActualizarT_Sgpal_Situacion_Pam(vRegistro);
                return vSituacion_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularSituacion_PamDTOPorCodigo(Situacion_PamDTO vSituacion_PamDTO)
        {
            try
            {
                return Situacion_PamAD.AnularT_Sgpal_Situacion_PamPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Situacion_PamDTO> ListarPaginadoSituacion_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Situacion_PamAD.ListarPaginadoT_Sgpal_Situacion_Pam(vFiltro, vNumPag, vCantRegxPag);
                return new List<Situacion_PamDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
