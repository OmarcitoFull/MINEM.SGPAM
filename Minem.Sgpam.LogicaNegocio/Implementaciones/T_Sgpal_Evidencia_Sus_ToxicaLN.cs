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
    public class T_Sgpal_Evidencia_Sus_ToxicaLN : BaseLN, IT_Sgpal_Evidencia_Sus_ToxicaLN
    {
        private readonly IT_Sgpal_Evidencia_Sus_ToxicaAD Evidencia_Sus_ToxicaAD;

        public T_Sgpal_Evidencia_Sus_ToxicaLN(IT_Sgpal_Evidencia_Sus_ToxicaAD vT_Sgpal_Evidencia_Sus_ToxicaAD)
        {
            Evidencia_Sus_ToxicaAD = vT_Sgpal_Evidencia_Sus_ToxicaAD;
        }

        public IEnumerable<Evidencia_Sus_ToxicaDTO> ListarEvidencia_Sus_ToxicaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Evidencia_Sus_ToxicaAD.ListarT_Sgpal_Evidencia_Sus_Toxica()
                                  select new Evidencia_Sus_ToxicaDTO
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
                                      Peso_Lb = vTmp.PESO_LB,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Rm = vTmp.PESO_RM,
                                      Id_Evidencia_Sus_Toxica = vTmp.ID_EVIDENCIA_SUS_TOXICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_Sus_ToxicaDTO RecuperarEvidencia_Sus_ToxicaDTOPorCodigo(int vId_Evidencia_Sus_Toxica)
        {
            try
            {
                var vResultado = Evidencia_Sus_ToxicaAD.RecuperarT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(vId_Evidencia_Sus_Toxica);
                return new Evidencia_Sus_ToxicaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_Sus_ToxicaDTO InsertarEvidencia_Sus_ToxicaDTO(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Sus_Toxica();
                var vResultado = Evidencia_Sus_ToxicaAD.InsertarT_Sgpal_Evidencia_Sus_Toxica(vRegistro);
                return vEvidencia_Sus_ToxicaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_Sus_ToxicaDTO ActualizarEvidencia_Sus_ToxicaDTO(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Sus_Toxica();
                var vResultado = Evidencia_Sus_ToxicaAD.ActualizarT_Sgpal_Evidencia_Sus_Toxica(vRegistro);
                return vEvidencia_Sus_ToxicaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularEvidencia_Sus_ToxicaDTOPorCodigo(Evidencia_Sus_ToxicaDTO vEvidencia_Sus_ToxicaDTO)
        {
            try
            {
                return Evidencia_Sus_ToxicaAD.AnularT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Evidencia_Sus_ToxicaDTO> ListarPaginadoEvidencia_Sus_ToxicaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Evidencia_Sus_ToxicaAD.ListarPaginadoT_Sgpal_Evidencia_Sus_Toxica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Evidencia_Sus_ToxicaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
