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
    public class T_Sgpal_AccesibilidadLN : BaseLN, IT_Sgpal_AccesibilidadLN
    {
        private readonly IT_Sgpal_AccesibilidadAD AccesibilidadAD;

        public T_Sgpal_AccesibilidadLN(IT_Sgpal_AccesibilidadAD vT_Sgpal_AccesibilidadAD)
        {
            AccesibilidadAD = vT_Sgpal_AccesibilidadAD;
        }

        public IEnumerable<AccesibilidadDTO> ListarAccesibilidadDTO()
        {
            try
            {
                var vResultado = (from vTmp in AccesibilidadAD.ListarT_Sgpal_Accesibilidad()
                                  select new AccesibilidadDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Accesibilidad = vTmp.ID_ACCESIBILIDAD,
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

        public AccesibilidadDTO RecuperarAccesibilidadDTOPorCodigo(int vId_Accesibilidad)
        {
            try
            {
                var vResultado = AccesibilidadAD.RecuperarT_Sgpal_AccesibilidadPorCodigo(vId_Accesibilidad);
                return new AccesibilidadDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public AccesibilidadDTO InsertarAccesibilidadDTO(AccesibilidadDTO vAccesibilidadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Accesibilidad();
                var vResultado = AccesibilidadAD.InsertarT_Sgpal_Accesibilidad(vRegistro);
                return vAccesibilidadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public AccesibilidadDTO ActualizarAccesibilidadDTO(AccesibilidadDTO vAccesibilidadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Accesibilidad();
                var vResultado = AccesibilidadAD.ActualizarT_Sgpal_Accesibilidad(vRegistro);
                return vAccesibilidadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularAccesibilidadDTOPorCodigo(AccesibilidadDTO vAccesibilidadDTO)
        {
            try
            {
                return AccesibilidadAD.AnularT_Sgpal_AccesibilidadPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<AccesibilidadDTO> ListarPaginadoAccesibilidadDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = AccesibilidadAD.ListarPaginadoT_Sgpal_Accesibilidad(vFiltro, vNumPag, vCantRegxPag);
                return new List<AccesibilidadDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
