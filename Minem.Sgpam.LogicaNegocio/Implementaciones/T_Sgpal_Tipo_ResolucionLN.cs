using System;
using System.Collections.Generic;
using System.Linq;
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
    public class T_Sgpal_Tipo_ResolucionLN : BaseLN, IT_Sgpal_Tipo_ResolucionLN
    {
        private readonly IT_Sgpal_Tipo_ResolucionAD Tipo_ResolucionAD;

        public T_Sgpal_Tipo_ResolucionLN(IT_Sgpal_Tipo_ResolucionAD vT_Sgpal_Tipo_ResolucionAD)
        {
            Tipo_ResolucionAD = vT_Sgpal_Tipo_ResolucionAD;
        }

        public IEnumerable<Tipo_ResolucionDTO> ListarTipo_ResolucionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_ResolucionAD.ListarT_Sgpal_Tipo_Resolucion()
                                  select new Tipo_ResolucionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Tipo_Resolucion = vTmp.ID_TIPO_RESOLUCION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ResolucionDTO RecuperarTipo_ResolucionDTOPorCodigo(int vId_Tipo_Resolucion)
        {
            try
            {
                var vResultado = Tipo_ResolucionAD.RecuperarT_Sgpal_Tipo_ResolucionPorCodigo(vId_Tipo_Resolucion);
                return new Tipo_ResolucionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ResolucionDTO InsertarTipo_ResolucionDTO(Tipo_ResolucionDTO vTipo_ResolucionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Resolucion();
                var vResultado = Tipo_ResolucionAD.InsertarT_Sgpal_Tipo_Resolucion(vRegistro);
                return vTipo_ResolucionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ResolucionDTO ActualizarTipo_ResolucionDTO(Tipo_ResolucionDTO vTipo_ResolucionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Resolucion();
                var vResultado = Tipo_ResolucionAD.ActualizarT_Sgpal_Tipo_Resolucion(vRegistro);
                return vTipo_ResolucionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_ResolucionDTOPorCodigo(Tipo_ResolucionDTO vTipo_ResolucionDTO)
        {
            try
            {
                return Tipo_ResolucionAD.AnularT_Sgpal_Tipo_ResolucionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_ResolucionDTO> ListarPaginadoTipo_ResolucionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_ResolucionAD.ListarPaginadoT_Sgpal_Tipo_Resolucion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_ResolucionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
