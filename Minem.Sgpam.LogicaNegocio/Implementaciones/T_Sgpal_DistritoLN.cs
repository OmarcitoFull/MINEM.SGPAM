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
    public class T_Sgpal_DistritoLN : BaseLN, IT_Sgpal_DistritoLN
    {
        private readonly IT_Sgpal_DistritoAD DistritoAD;

        public T_Sgpal_DistritoLN(IT_Sgpal_DistritoAD vT_Sgpal_DistritoAD)
        {
            DistritoAD = vT_Sgpal_DistritoAD;
        }

        public IEnumerable<DistritoDTO> ListarDistritoDTO()
        {
            try
            {
                var vResultado = (from vTmp in DistritoAD.ListarT_Sgpal_Distrito()
                                  select new DistritoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Distrito = vTmp.ID_DISTRITO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Cod_Referencial = vTmp.COD_REFERENCIAL,
                                      Id_Provincia = vTmp.ID_PROVINCIA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public DistritoDTO RecuperarDistritoDTOPorCodigo(int vId_Distrito)
        {
            try
            {
                var vResultado = DistritoAD.RecuperarT_Sgpal_DistritoPorCodigo(vId_Distrito);
                return new DistritoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public DistritoDTO InsertarDistritoDTO(DistritoDTO vDistritoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Distrito();
                var vResultado = DistritoAD.InsertarT_Sgpal_Distrito(vRegistro);
                return vDistritoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public DistritoDTO ActualizarDistritoDTO(DistritoDTO vDistritoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Distrito();
                var vResultado = DistritoAD.ActualizarT_Sgpal_Distrito(vRegistro);
                return vDistritoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularDistritoDTOPorCodigo(DistritoDTO vDistritoDTO)
        {
            try
            {
                return DistritoAD.AnularT_Sgpal_DistritoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<DistritoDTO> ListarPaginadoDistritoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = DistritoAD.ListarPaginadoT_Sgpal_Distrito(vFiltro, vNumPag, vCantRegxPag);
                return new List<DistritoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<UbigeoDTO> ListarUbigeoDTO()
        {
            try
            {
                var vResultado = (from vTmp in DistritoAD.ListarT_Ubigeo()
                                  select new UbigeoDTO
                                  {
                                      Distrito = vTmp.DISTRITO,
                                      Id_Distrito = vTmp.ID_DISTRITO,
                                      Id_Provincia = vTmp.ID_PROVINCIA,
                                      Id_Region = vTmp.ID_REGION,
                                      Provincia = vTmp.PROVINCIA,
                                      Region = vTmp.REGION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
