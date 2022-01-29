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
    public class T_Sgpal_Sensibilidad_AreaLN : BaseLN, IT_Sgpal_Sensibilidad_AreaLN
    {
        private readonly IT_Sgpal_Sensibilidad_AreaAD Sensibilidad_AreaAD;

        public T_Sgpal_Sensibilidad_AreaLN(IT_Sgpal_Sensibilidad_AreaAD vT_Sgpal_Sensibilidad_AreaAD)
        {
            Sensibilidad_AreaAD = vT_Sgpal_Sensibilidad_AreaAD;
        }

        public IEnumerable<Sensibilidad_AreaDTO> ListarSensibilidad_AreaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Sensibilidad_AreaAD.ListarT_Sgpal_Sensibilidad_Area()
                                  select new Sensibilidad_AreaDTO
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
                                      Id_Sensibilidad_Area = vTmp.ID_SENSIBILIDAD_AREA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sensibilidad_AreaDTO RecuperarSensibilidad_AreaDTOPorCodigo(int vId_Sensibilidad_Area)
        {
            try
            {
                var vResultado = Sensibilidad_AreaAD.RecuperarT_Sgpal_Sensibilidad_AreaPorCodigo(vId_Sensibilidad_Area);
                return new Sensibilidad_AreaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sensibilidad_AreaDTO InsertarSensibilidad_AreaDTO(Sensibilidad_AreaDTO vSensibilidad_AreaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sensibilidad_Area();
                var vResultado = Sensibilidad_AreaAD.InsertarT_Sgpal_Sensibilidad_Area(vRegistro);
                return vSensibilidad_AreaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sensibilidad_AreaDTO ActualizarSensibilidad_AreaDTO(Sensibilidad_AreaDTO vSensibilidad_AreaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sensibilidad_Area();
                var vResultado = Sensibilidad_AreaAD.ActualizarT_Sgpal_Sensibilidad_Area(vRegistro);
                return vSensibilidad_AreaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularSensibilidad_AreaDTOPorCodigo(Sensibilidad_AreaDTO vSensibilidad_AreaDTO)
        {
            try
            {
                return Sensibilidad_AreaAD.AnularT_Sgpal_Sensibilidad_AreaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Sensibilidad_AreaDTO> ListarPaginadoSensibilidad_AreaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Sensibilidad_AreaAD.ListarPaginadoT_Sgpal_Sensibilidad_Area(vFiltro, vNumPag, vCantRegxPag);
                return new List<Sensibilidad_AreaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
