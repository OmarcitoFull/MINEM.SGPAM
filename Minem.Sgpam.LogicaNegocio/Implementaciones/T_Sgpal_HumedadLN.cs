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
    public class T_Sgpal_HumedadLN : BaseLN, IT_Sgpal_HumedadLN
    {
        private readonly IT_Sgpal_HumedadAD HumedadAD;

        public T_Sgpal_HumedadLN(IT_Sgpal_HumedadAD vT_Sgpal_HumedadAD)
        {
            HumedadAD = vT_Sgpal_HumedadAD;
        }

        public IEnumerable<HumedadDTO> ListarHumedadDTO()
        {
            try
            {
                var vResultado = (from vTmp in HumedadAD.ListarT_Sgpal_Humedad()
                                  select new HumedadDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Humedad = vTmp.ID_HUMEDAD,
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

        public HumedadDTO RecuperarHumedadDTOPorCodigo(int vId_Humedad)
        {
            try
            {
                var vResultado = HumedadAD.RecuperarT_Sgpal_HumedadPorCodigo(vId_Humedad);
                return new HumedadDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public HumedadDTO InsertarHumedadDTO(HumedadDTO vHumedadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Humedad();
                var vResultado = HumedadAD.InsertarT_Sgpal_Humedad(vRegistro);
                return vHumedadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public HumedadDTO ActualizarHumedadDTO(HumedadDTO vHumedadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Humedad();
                var vResultado = HumedadAD.ActualizarT_Sgpal_Humedad(vRegistro);
                return vHumedadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularHumedadDTOPorCodigo(HumedadDTO vHumedadDTO)
        {
            try
            {
                return HumedadAD.AnularT_Sgpal_HumedadPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<HumedadDTO> ListarPaginadoHumedadDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = HumedadAD.ListarPaginadoT_Sgpal_Humedad(vFiltro, vNumPag, vCantRegxPag);
                return new List<HumedadDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
