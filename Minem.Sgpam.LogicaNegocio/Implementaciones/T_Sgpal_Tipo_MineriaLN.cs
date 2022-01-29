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
    public class T_Sgpal_Tipo_MineriaLN : BaseLN, IT_Sgpal_Tipo_MineriaLN
    {
        private readonly IT_Sgpal_Tipo_MineriaAD Tipo_MineriaAD;

        public T_Sgpal_Tipo_MineriaLN(IT_Sgpal_Tipo_MineriaAD vT_Sgpal_Tipo_MineriaAD)
        {
            Tipo_MineriaAD = vT_Sgpal_Tipo_MineriaAD;
        }

        public IEnumerable<Tipo_MineriaDTO> ListarTipo_MineriaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_MineriaAD.ListarT_Sgpal_Tipo_Mineria()
                                  select new Tipo_MineriaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Tipo_Mineria = vTmp.ID_TIPO_MINERIA,
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

        public Tipo_MineriaDTO RecuperarTipo_MineriaDTOPorCodigo(int vId_Tipo_Mineria)
        {
            try
            {
                var vResultado = Tipo_MineriaAD.RecuperarT_Sgpal_Tipo_MineriaPorCodigo(vId_Tipo_Mineria);
                return new Tipo_MineriaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_MineriaDTO InsertarTipo_MineriaDTO(Tipo_MineriaDTO vTipo_MineriaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Mineria();
                var vResultado = Tipo_MineriaAD.InsertarT_Sgpal_Tipo_Mineria(vRegistro);
                return vTipo_MineriaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_MineriaDTO ActualizarTipo_MineriaDTO(Tipo_MineriaDTO vTipo_MineriaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Mineria();
                var vResultado = Tipo_MineriaAD.ActualizarT_Sgpal_Tipo_Mineria(vRegistro);
                return vTipo_MineriaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_MineriaDTOPorCodigo(Tipo_MineriaDTO vTipo_MineriaDTO)
        {
            try
            {
                return Tipo_MineriaAD.AnularT_Sgpal_Tipo_MineriaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_MineriaDTO> ListarPaginadoTipo_MineriaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_MineriaAD.ListarPaginadoT_Sgpal_Tipo_Mineria(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_MineriaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
