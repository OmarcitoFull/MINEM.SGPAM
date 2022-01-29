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
    public class T_Sgpal_HundimientoLN : BaseLN, IT_Sgpal_HundimientoLN
    {
        private readonly IT_Sgpal_HundimientoAD HundimientoAD;

        public T_Sgpal_HundimientoLN(IT_Sgpal_HundimientoAD vT_Sgpal_HundimientoAD)
        {
            HundimientoAD = vT_Sgpal_HundimientoAD;
        }

        public IEnumerable<HundimientoDTO> ListarHundimientoDTO()
        {
            try
            {
                var vResultado = (from vTmp in HundimientoAD.ListarT_Sgpal_Hundimiento()
                                  select new HundimientoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Hundimiento = vTmp.ID_HUNDIMIENTO,
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

        public HundimientoDTO RecuperarHundimientoDTOPorCodigo(int vId_Hundimiento)
        {
            try
            {
                var vResultado = HundimientoAD.RecuperarT_Sgpal_HundimientoPorCodigo(vId_Hundimiento);
                return new HundimientoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public HundimientoDTO InsertarHundimientoDTO(HundimientoDTO vHundimientoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Hundimiento();
                var vResultado = HundimientoAD.InsertarT_Sgpal_Hundimiento(vRegistro);
                return vHundimientoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public HundimientoDTO ActualizarHundimientoDTO(HundimientoDTO vHundimientoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Hundimiento();
                var vResultado = HundimientoAD.ActualizarT_Sgpal_Hundimiento(vRegistro);
                return vHundimientoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularHundimientoDTOPorCodigo(HundimientoDTO vHundimientoDTO)
        {
            try
            {
                return HundimientoAD.AnularT_Sgpal_HundimientoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<HundimientoDTO> ListarPaginadoHundimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = HundimientoAD.ListarPaginadoT_Sgpal_Hundimiento(vFiltro, vNumPag, vCantRegxPag);
                return new List<HundimientoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
