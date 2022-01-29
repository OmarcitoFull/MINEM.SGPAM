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
    public class T_Sgpal_Sub_Tipo_PamLN : BaseLN, IT_Sgpal_Sub_Tipo_PamLN
    {
        private readonly IT_Sgpal_Sub_Tipo_PamAD Sub_Tipo_PamAD;

        public T_Sgpal_Sub_Tipo_PamLN(IT_Sgpal_Sub_Tipo_PamAD vT_Sgpal_Sub_Tipo_PamAD)
        {
            Sub_Tipo_PamAD = vT_Sgpal_Sub_Tipo_PamAD;
        }

        public IEnumerable<Sub_Tipo_PamDTO> ListarSub_Tipo_PamDTO()
        {
            try
            {
                var vResultado = (from vTmp in Sub_Tipo_PamAD.ListarT_Sgpal_Sub_Tipo_Pam()
                                  select new Sub_Tipo_PamDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Sub_Tipo_Pam = vTmp.ID_SUB_TIPO_PAM,
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

        public Sub_Tipo_PamDTO RecuperarSub_Tipo_PamDTOPorCodigo(int vId_Sub_Tipo_Pam)
        {
            try
            {
                var vResultado = Sub_Tipo_PamAD.RecuperarT_Sgpal_Sub_Tipo_PamPorCodigo(vId_Sub_Tipo_Pam);
                return new Sub_Tipo_PamDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sub_Tipo_PamDTO InsertarSub_Tipo_PamDTO(Sub_Tipo_PamDTO vSub_Tipo_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sub_Tipo_Pam();
                var vResultado = Sub_Tipo_PamAD.InsertarT_Sgpal_Sub_Tipo_Pam(vRegistro);
                return vSub_Tipo_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sub_Tipo_PamDTO ActualizarSub_Tipo_PamDTO(Sub_Tipo_PamDTO vSub_Tipo_PamDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sub_Tipo_Pam();
                var vResultado = Sub_Tipo_PamAD.ActualizarT_Sgpal_Sub_Tipo_Pam(vRegistro);
                return vSub_Tipo_PamDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularSub_Tipo_PamDTOPorCodigo(Sub_Tipo_PamDTO vSub_Tipo_PamDTO)
        {
            try
            {
                return Sub_Tipo_PamAD.AnularT_Sgpal_Sub_Tipo_PamPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Sub_Tipo_PamDTO> ListarPaginadoSub_Tipo_PamDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Sub_Tipo_PamAD.ListarPaginadoT_Sgpal_Sub_Tipo_Pam(vFiltro, vNumPag, vCantRegxPag);
                return new List<Sub_Tipo_PamDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
