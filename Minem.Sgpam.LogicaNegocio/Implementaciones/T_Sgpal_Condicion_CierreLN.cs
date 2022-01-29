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
    public class T_Sgpal_Condicion_CierreLN : BaseLN, IT_Sgpal_Condicion_CierreLN
    {
        private readonly IT_Sgpal_Condicion_CierreAD Condicion_CierreAD;

        public T_Sgpal_Condicion_CierreLN(IT_Sgpal_Condicion_CierreAD vT_Sgpal_Condicion_CierreAD)
        {
            Condicion_CierreAD = vT_Sgpal_Condicion_CierreAD;
        }

        public IEnumerable<Condicion_CierreDTO> ListarCondicion_CierreDTO()
        {
            try
            {
                var vResultado = (from vTmp in Condicion_CierreAD.ListarT_Sgpal_Condicion_Cierre()
                                  select new Condicion_CierreDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Condicion_Cierre = vTmp.ID_CONDICION_CIERRE,
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

        public Condicion_CierreDTO RecuperarCondicion_CierreDTOPorCodigo(int vId_Condicion_Cierre)
        {
            try
            {
                var vResultado = Condicion_CierreAD.RecuperarT_Sgpal_Condicion_CierrePorCodigo(vId_Condicion_Cierre);
                return new Condicion_CierreDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Condicion_CierreDTO InsertarCondicion_CierreDTO(Condicion_CierreDTO vCondicion_CierreDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Condicion_Cierre();
                var vResultado = Condicion_CierreAD.InsertarT_Sgpal_Condicion_Cierre(vRegistro);
                return vCondicion_CierreDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Condicion_CierreDTO ActualizarCondicion_CierreDTO(Condicion_CierreDTO vCondicion_CierreDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Condicion_Cierre();
                var vResultado = Condicion_CierreAD.ActualizarT_Sgpal_Condicion_Cierre(vRegistro);
                return vCondicion_CierreDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularCondicion_CierreDTOPorCodigo(Condicion_CierreDTO vCondicion_CierreDTO)
        {
            try
            {
                return Condicion_CierreAD.AnularT_Sgpal_Condicion_CierrePorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Condicion_CierreDTO> ListarPaginadoCondicion_CierreDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Condicion_CierreAD.ListarPaginadoT_Sgpal_Condicion_Cierre(vFiltro, vNumPag, vCantRegxPag);
                return new List<Condicion_CierreDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
