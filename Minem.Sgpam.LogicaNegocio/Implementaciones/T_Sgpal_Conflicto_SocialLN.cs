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
    public class T_Sgpal_Conflicto_SocialLN : BaseLN, IT_Sgpal_Conflicto_SocialLN
    {
        private readonly IT_Sgpal_Conflicto_SocialAD Conflicto_SocialAD;

        public T_Sgpal_Conflicto_SocialLN(IT_Sgpal_Conflicto_SocialAD vT_Sgpal_Conflicto_SocialAD)
        {
            Conflicto_SocialAD = vT_Sgpal_Conflicto_SocialAD;
        }

        public IEnumerable<Conflicto_SocialDTO> ListarConflicto_SocialDTO()
        {
            try
            {
                var vResultado = (from vTmp in Conflicto_SocialAD.ListarT_Sgpal_Conflicto_Social()
                                  select new Conflicto_SocialDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Conflicto_Social = vTmp.ID_CONFLICTO_SOCIAL,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Conflicto_SocialDTO RecuperarConflicto_SocialDTOPorCodigo(int vId_Conflicto_Social)
        {
            try
            {
                var vResultado = Conflicto_SocialAD.RecuperarT_Sgpal_Conflicto_SocialPorCodigo(vId_Conflicto_Social);
                return new Conflicto_SocialDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Conflicto_SocialDTO InsertarConflicto_SocialDTO(Conflicto_SocialDTO vConflicto_SocialDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Conflicto_Social();
                var vResultado = Conflicto_SocialAD.InsertarT_Sgpal_Conflicto_Social(vRegistro);
                return vConflicto_SocialDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Conflicto_SocialDTO ActualizarConflicto_SocialDTO(Conflicto_SocialDTO vConflicto_SocialDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Conflicto_Social();
                var vResultado = Conflicto_SocialAD.ActualizarT_Sgpal_Conflicto_Social(vRegistro);
                return vConflicto_SocialDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularConflicto_SocialDTOPorCodigo(Conflicto_SocialDTO vConflicto_SocialDTO)
        {
            try
            {
                return Conflicto_SocialAD.AnularT_Sgpal_Conflicto_SocialPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Conflicto_SocialDTO> ListarPaginadoConflicto_SocialDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Conflicto_SocialAD.ListarPaginadoT_Sgpal_Conflicto_Social(vFiltro, vNumPag, vCantRegxPag);
                return new List<Conflicto_SocialDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
