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
    public class T_Sgpal_Presencia_AdvertenciaLN : BaseLN, IT_Sgpal_Presencia_AdvertenciaLN
    {
        private readonly IT_Sgpal_Presencia_AdvertenciaAD Presencia_AdvertenciaAD;

        public T_Sgpal_Presencia_AdvertenciaLN(IT_Sgpal_Presencia_AdvertenciaAD vT_Sgpal_Presencia_AdvertenciaAD)
        {
            Presencia_AdvertenciaAD = vT_Sgpal_Presencia_AdvertenciaAD;
        }

        public IEnumerable<Presencia_AdvertenciaDTO> ListarPresencia_AdvertenciaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Presencia_AdvertenciaAD.ListarT_Sgpal_Presencia_Advertencia()
                                  select new Presencia_AdvertenciaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Presencia_Advertencia = vTmp.ID_PRESENCIA_ADVERTENCIA,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Lb = vTmp.PESO_LB,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Rm = vTmp.PESO_RM
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AdvertenciaDTO RecuperarPresencia_AdvertenciaDTOPorCodigo(int vId_Presencia_Advertencia)
        {
            try
            {
                var vResultado = Presencia_AdvertenciaAD.RecuperarT_Sgpal_Presencia_AdvertenciaPorCodigo(vId_Presencia_Advertencia);
                return new Presencia_AdvertenciaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AdvertenciaDTO InsertarPresencia_AdvertenciaDTO(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Advertencia();
                var vResultado = Presencia_AdvertenciaAD.InsertarT_Sgpal_Presencia_Advertencia(vRegistro);
                return vPresencia_AdvertenciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AdvertenciaDTO ActualizarPresencia_AdvertenciaDTO(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Advertencia();
                var vResultado = Presencia_AdvertenciaAD.ActualizarT_Sgpal_Presencia_Advertencia(vRegistro);
                return vPresencia_AdvertenciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularPresencia_AdvertenciaDTOPorCodigo(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO)
        {
            try
            {
                return Presencia_AdvertenciaAD.AnularT_Sgpal_Presencia_AdvertenciaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Presencia_AdvertenciaDTO> ListarPaginadoPresencia_AdvertenciaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Presencia_AdvertenciaAD.ListarPaginadoT_Sgpal_Presencia_Advertencia(vFiltro, vNumPag, vCantRegxPag);
                return new List<Presencia_AdvertenciaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
