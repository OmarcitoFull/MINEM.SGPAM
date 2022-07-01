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
    public class T_Sgpal_CoberturaLN : BaseLN, IT_Sgpal_CoberturaLN
    {
        private readonly IT_Sgpal_CoberturaAD CoberturaAD;

        public T_Sgpal_CoberturaLN(IT_Sgpal_CoberturaAD vT_Sgpal_CoberturaAD)
        {
            CoberturaAD = vT_Sgpal_CoberturaAD;
        }

        public IEnumerable<CoberturaDTO> ListarCoberturaDTO()
        {
            try
            {
                var vResultado = (from vTmp in CoberturaAD.ListarT_Sgpal_Cobertura()
                                  select new CoberturaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Cobertura = vTmp.ID_COBERTURA,
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

        public CoberturaDTO RecuperarCoberturaDTOPorCodigo(int vId_Cobertura)
        {
            try
            {
                var vResultado = CoberturaAD.RecuperarT_Sgpal_CoberturaPorCodigo(vId_Cobertura);
                return new CoberturaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CoberturaDTO InsertarCoberturaDTO(CoberturaDTO vCoberturaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cobertura();
                var vResultado = CoberturaAD.InsertarT_Sgpal_Cobertura(vRegistro);
                return vCoberturaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CoberturaDTO ActualizarCoberturaDTO(CoberturaDTO vCoberturaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cobertura();
                var vResultado = CoberturaAD.ActualizarT_Sgpal_Cobertura(vRegistro);
                return vCoberturaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularCoberturaDTOPorCodigo(CoberturaDTO vCoberturaDTO)
        {
            try
            {
                return CoberturaAD.AnularT_Sgpal_CoberturaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<CoberturaDTO> ListarPaginadoCoberturaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = CoberturaAD.ListarPaginadoT_Sgpal_Cobertura(vFiltro, vNumPag, vCantRegxPag);
                return new List<CoberturaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

    }
}
