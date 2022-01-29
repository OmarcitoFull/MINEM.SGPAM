using System;
using System.Linq;
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
    public class T_Sgpal_Tipo_PamLN : BaseLN, IT_Sgpal_Tipo_PamLN
    {
        private readonly IT_Sgpal_Tipo_PamAD Tipo_PamAD;

        public T_Sgpal_Tipo_PamLN(IT_Sgpal_Tipo_PamAD vT_Sgpal_Tipo_PamAD)
        {
            Tipo_PamAD = vT_Sgpal_Tipo_PamAD;
        }

        public IEnumerable<Tipo_PamDTO> ListarTipo_PamDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_PamAD.ListarT_Sgpal_Tipo_Pam()
                                  select new Tipo_PamDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Tipo_Pam = vTmp.ID_TIPO_PAM,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_PamDTO RecuperarTipo_PamDTOPorCodigo(int vId_Tipo_Pam)
        {
            try
            {
                var vResultado = Tipo_PamAD.RecuperarT_Sgpal_Tipo_PamPorCodigo(vId_Tipo_Pam);
                return new Tipo_PamDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_PamDTO InsertarTipo_PamDTO(Tipo_PamDTO vTipo_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Pam();
                var vResultado = Tipo_PamAD.InsertarT_Sgpal_Tipo_Pam(vRegistro);
                return vTipo_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_PamDTO ActualizarTipo_PamDTO(Tipo_PamDTO vTipo_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Pam();
                var vResultado = Tipo_PamAD.ActualizarT_Sgpal_Tipo_Pam(vRegistro);
                return vTipo_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_PamDTOPorCodigo(Tipo_PamDTO vTipo_PamDTO)
        {
            try
            {
                return Tipo_PamAD.AnularT_Sgpal_Tipo_PamPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_PamDTO> ListarPaginadoTipo_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_PamAD.ListarPaginadoT_Sgpal_Tipo_Pam(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_PamDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
