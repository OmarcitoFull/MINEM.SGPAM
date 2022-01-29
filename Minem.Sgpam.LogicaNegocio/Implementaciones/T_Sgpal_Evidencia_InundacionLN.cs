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
    public class T_Sgpal_Evidencia_InundacionLN : BaseLN, IT_Sgpal_Evidencia_InundacionLN
    {
        private readonly IT_Sgpal_Evidencia_InundacionAD Evidencia_InundacionAD;

        public T_Sgpal_Evidencia_InundacionLN(IT_Sgpal_Evidencia_InundacionAD vT_Sgpal_Evidencia_InundacionAD)
        {
            Evidencia_InundacionAD = vT_Sgpal_Evidencia_InundacionAD;
        }

        public IEnumerable<Evidencia_InundacionDTO> ListarEvidencia_InundacionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Evidencia_InundacionAD.ListarT_Sgpal_Evidencia_Inundacion()
                                  select new Evidencia_InundacionDTO
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
                                      Id_Evidencia_Inundacion = vTmp.ID_EVIDENCIA_INUNDACION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_InundacionDTO RecuperarEvidencia_InundacionDTOPorCodigo(int vId_Evidencia_Inundacion)
        {
            try
            {
                var vResultado = Evidencia_InundacionAD.RecuperarT_Sgpal_Evidencia_InundacionPorCodigo(vId_Evidencia_Inundacion);
                return new Evidencia_InundacionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_InundacionDTO InsertarEvidencia_InundacionDTO(Evidencia_InundacionDTO vEvidencia_InundacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Inundacion();
                var vResultado = Evidencia_InundacionAD.InsertarT_Sgpal_Evidencia_Inundacion(vRegistro);
                return vEvidencia_InundacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Evidencia_InundacionDTO ActualizarEvidencia_InundacionDTO(Evidencia_InundacionDTO vEvidencia_InundacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Evidencia_Inundacion();
                var vResultado = Evidencia_InundacionAD.ActualizarT_Sgpal_Evidencia_Inundacion(vRegistro);
                return vEvidencia_InundacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularEvidencia_InundacionDTOPorCodigo(Evidencia_InundacionDTO vEvidencia_InundacionDTO)
        {
            try
            {
                return Evidencia_InundacionAD.AnularT_Sgpal_Evidencia_InundacionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Evidencia_InundacionDTO> ListarPaginadoEvidencia_InundacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Evidencia_InundacionAD.ListarPaginadoT_Sgpal_Evidencia_Inundacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Evidencia_InundacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
