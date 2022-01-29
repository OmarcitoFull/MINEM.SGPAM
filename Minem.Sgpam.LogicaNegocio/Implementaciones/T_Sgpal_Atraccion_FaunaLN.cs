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
    public class T_Sgpal_Atraccion_FaunaLN : BaseLN, IT_Sgpal_Atraccion_FaunaLN
    {
        private readonly IT_Sgpal_Atraccion_FaunaAD Atraccion_FaunaAD;

        public T_Sgpal_Atraccion_FaunaLN(IT_Sgpal_Atraccion_FaunaAD vT_Sgpal_Atraccion_FaunaAD)
        {
            Atraccion_FaunaAD = vT_Sgpal_Atraccion_FaunaAD;
        }

        public IEnumerable<Atraccion_FaunaDTO> ListarAtraccion_FaunaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Atraccion_FaunaAD.ListarT_Sgpal_Atraccion_Fauna()
                                  select new Atraccion_FaunaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Rm = vTmp.PESO_RM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Lb = vTmp.PESO_LB,
                                      Id_Atraccion_Fauna = vTmp.ID_ATRACCION_FAUNA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Atraccion_FaunaDTO RecuperarAtraccion_FaunaDTOPorCodigo(int vId_Atraccion_Fauna)
        {
            try
            {
                var vResultado = Atraccion_FaunaAD.RecuperarT_Sgpal_Atraccion_FaunaPorCodigo(vId_Atraccion_Fauna);
                return new Atraccion_FaunaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Atraccion_FaunaDTO InsertarAtraccion_FaunaDTO(Atraccion_FaunaDTO vAtraccion_FaunaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Atraccion_Fauna();
                var vResultado = Atraccion_FaunaAD.InsertarT_Sgpal_Atraccion_Fauna(vRegistro);
                return vAtraccion_FaunaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Atraccion_FaunaDTO ActualizarAtraccion_FaunaDTO(Atraccion_FaunaDTO vAtraccion_FaunaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Atraccion_Fauna();
                var vResultado = Atraccion_FaunaAD.ActualizarT_Sgpal_Atraccion_Fauna(vRegistro);
                return vAtraccion_FaunaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularAtraccion_FaunaDTOPorCodigo(Atraccion_FaunaDTO vAtraccion_FaunaDTO)
        {
            try
            {
                return Atraccion_FaunaAD.AnularT_Sgpal_Atraccion_FaunaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Atraccion_FaunaDTO> ListarPaginadoAtraccion_FaunaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Atraccion_FaunaAD.ListarPaginadoT_Sgpal_Atraccion_Fauna(vFiltro, vNumPag, vCantRegxPag);
                return new List<Atraccion_FaunaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
