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
    public class T_Sgpal_Evidencia_ErosionLN : BaseLN, IT_Sgpal_Evidencia_ErosionLN
    {
        private readonly IT_Sgpal_Evidencia_ErosionAD Evidencia_ErosionAD;

        public T_Sgpal_Evidencia_ErosionLN(IT_Sgpal_Evidencia_ErosionAD vT_Sgpal_Evidencia_ErosionAD)
        {
            Evidencia_ErosionAD = vT_Sgpal_Evidencia_ErosionAD;
        }

        public IEnumerable<Evidencia_ErosionDTO> ListarEvidencia_ErosionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Evidencia_ErosionAD.ListarT_Sgpal_Evidencia_Erosion()
                                  select new Evidencia_ErosionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Evidencia_Erosion = vTmp.ID_EVIDENCIA_EROSION,
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

        public Evidencia_ErosionDTO RecuperarEvidencia_ErosionDTOPorCodigo(int vId_Evidencia_Erosion)
        {
            try
            {
                var vResultado = Evidencia_ErosionAD.RecuperarT_Sgpal_Evidencia_ErosionPorCodigo(vId_Evidencia_Erosion);
                return new Evidencia_ErosionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_ErosionDTO InsertarEvidencia_ErosionDTO(Evidencia_ErosionDTO vEvidencia_ErosionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Erosion();
                var vResultado = Evidencia_ErosionAD.InsertarT_Sgpal_Evidencia_Erosion(vRegistro);
                return vEvidencia_ErosionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_ErosionDTO ActualizarEvidencia_ErosionDTO(Evidencia_ErosionDTO vEvidencia_ErosionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Erosion();
                var vResultado = Evidencia_ErosionAD.ActualizarT_Sgpal_Evidencia_Erosion(vRegistro);
                return vEvidencia_ErosionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularEvidencia_ErosionDTOPorCodigo(Evidencia_ErosionDTO vEvidencia_ErosionDTO)
        {
            try
            {
                return Evidencia_ErosionAD.AnularT_Sgpal_Evidencia_ErosionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Evidencia_ErosionDTO> ListarPaginadoEvidencia_ErosionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Evidencia_ErosionAD.ListarPaginadoT_Sgpal_Evidencia_Erosion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Evidencia_ErosionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
