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
    public class T_Sgpal_Tipo_SustanciaLN : BaseLN, IT_Sgpal_Tipo_SustanciaLN
    {
        private readonly IT_Sgpal_Tipo_SustanciaAD Tipo_SustanciaAD;

        public T_Sgpal_Tipo_SustanciaLN(IT_Sgpal_Tipo_SustanciaAD vT_Sgpal_Tipo_SustanciaAD)
        {
            Tipo_SustanciaAD = vT_Sgpal_Tipo_SustanciaAD;
        }

        public IEnumerable<Tipo_SustanciaDTO> ListarTipo_SustanciaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_SustanciaAD.ListarT_Sgpal_Tipo_Sustancia()
                                  select new Tipo_SustanciaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Tipo_Sustancia = vTmp.ID_TIPO_SUSTANCIA,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_SustanciaDTO RecuperarTipo_SustanciaDTOPorCodigo(int vId_Tipo_Sustancia)
        {
            try
            {
                var vResultado = Tipo_SustanciaAD.RecuperarT_Sgpal_Tipo_SustanciaPorCodigo(vId_Tipo_Sustancia);
                return new Tipo_SustanciaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_SustanciaDTO InsertarTipo_SustanciaDTO(Tipo_SustanciaDTO vTipo_SustanciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Sustancia();
                var vResultado = Tipo_SustanciaAD.InsertarT_Sgpal_Tipo_Sustancia(vRegistro);
                return vTipo_SustanciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_SustanciaDTO ActualizarTipo_SustanciaDTO(Tipo_SustanciaDTO vTipo_SustanciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Sustancia();
                var vResultado = Tipo_SustanciaAD.ActualizarT_Sgpal_Tipo_Sustancia(vRegistro);
                return vTipo_SustanciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_SustanciaDTOPorCodigo(Tipo_SustanciaDTO vTipo_SustanciaDTO)
        {
            try
            {
                return Tipo_SustanciaAD.AnularT_Sgpal_Tipo_SustanciaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_SustanciaDTO> ListarPaginadoTipo_SustanciaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_SustanciaAD.ListarPaginadoT_Sgpal_Tipo_Sustancia(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_SustanciaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
