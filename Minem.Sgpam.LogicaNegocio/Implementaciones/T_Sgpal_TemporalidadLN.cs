using System;
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
    public class T_Sgpal_TemporalidadLN : BaseLN, IT_Sgpal_TemporalidadLN
    {
        private readonly IT_Sgpal_TemporalidadAD TemporalidadAD;

        public T_Sgpal_TemporalidadLN(IT_Sgpal_TemporalidadAD vT_Sgpal_TemporalidadAD)
        {
            TemporalidadAD = vT_Sgpal_TemporalidadAD;
        }

        public IEnumerable<TemporalidadDTO> ListarTemporalidadDTO()
        {
            try
            {
                IEnumerable<T_Sgpal_Temporalidad> vResultado = TemporalidadAD.ListarT_Sgpal_Temporalidad();
                if (vResultado != null)
                {
                    List<TemporalidadDTO> vLista = new List<TemporalidadDTO>();
                    TemporalidadDTO vEntidad;
                    foreach (T_Sgpal_Temporalidad item in vResultado)
                    {
                        vEntidad = new TemporalidadDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Descripcion = item.DESCRIPCION,
                            Id_Temporalidad = item.ID_TEMPORALIDAD
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public TemporalidadDTO RecuperarTemporalidadDTOPorCodigo(int vId_Temporalidad)
        {
            try
            {
                var vResultado = TemporalidadAD.RecuperarT_Sgpal_TemporalidadPorCodigo(vId_Temporalidad);
                return new TemporalidadDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public TemporalidadDTO InsertarTemporalidadDTO(TemporalidadDTO vTemporalidadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Temporalidad();
                var vResultado = TemporalidadAD.InsertarT_Sgpal_Temporalidad(vRegistro);
                return vTemporalidadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public TemporalidadDTO ActualizarTemporalidadDTO(TemporalidadDTO vTemporalidadDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Temporalidad();
                var vResultado = TemporalidadAD.ActualizarT_Sgpal_Temporalidad(vRegistro);
                return vTemporalidadDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTemporalidadDTOPorCodigo(TemporalidadDTO vTemporalidadDTO)
        {
            try
            {
                return TemporalidadAD.AnularT_Sgpal_TemporalidadPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<TemporalidadDTO> ListarPaginadoTemporalidadDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = TemporalidadAD.ListarPaginadoT_Sgpal_Temporalidad(vFiltro, vNumPag, vCantRegxPag);
                return new List<TemporalidadDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
