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
    public class T_Sgpal_Tipo_EncargoLN : BaseLN, IT_Sgpal_Tipo_EncargoLN
    {
        private readonly IT_Sgpal_Tipo_EncargoAD Tipo_EncargoAD;

        public T_Sgpal_Tipo_EncargoLN(IT_Sgpal_Tipo_EncargoAD vT_Sgpal_Tipo_EncargoAD)
        {
            Tipo_EncargoAD = vT_Sgpal_Tipo_EncargoAD;
        }

        public IEnumerable<Tipo_EncargoDTO> ListarTipo_EncargoDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_EncargoAD.ListarT_Sgpal_Tipo_Encargo()
                                  select new Tipo_EncargoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Tipo_Encargo = vTmp.ID_TIPO_ENCARGO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_EncargoDTO RecuperarTipo_EncargoDTOPorCodigo(int vId_Tipo_Encargo)
        {
            try
            {
                var vResultado = Tipo_EncargoAD.RecuperarT_Sgpal_Tipo_EncargoPorCodigo(vId_Tipo_Encargo);
                return new Tipo_EncargoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_EncargoDTO InsertarTipo_EncargoDTO(Tipo_EncargoDTO vTipo_EncargoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Encargo();
                var vResultado = Tipo_EncargoAD.InsertarT_Sgpal_Tipo_Encargo(vRegistro);
                return vTipo_EncargoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_EncargoDTO ActualizarTipo_EncargoDTO(Tipo_EncargoDTO vTipo_EncargoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Encargo();
                var vResultado = Tipo_EncargoAD.ActualizarT_Sgpal_Tipo_Encargo(vRegistro);
                return vTipo_EncargoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularTipo_EncargoDTOPorCodigo(Tipo_EncargoDTO vTipo_EncargoDTO)
        {
            try
            {
                return Tipo_EncargoAD.AnularT_Sgpal_Tipo_EncargoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_EncargoDTO> ListarPaginadoTipo_EncargoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_EncargoAD.ListarPaginadoT_Sgpal_Tipo_Encargo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_EncargoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
