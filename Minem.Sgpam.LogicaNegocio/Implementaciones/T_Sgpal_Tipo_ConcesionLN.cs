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
    public class T_Sgpal_Tipo_ConcesionLN : BaseLN, IT_Sgpal_Tipo_ConcesionLN
    {
        private readonly IT_Sgpal_Tipo_ConcesionAD Tipo_ConcesionAD;

        public T_Sgpal_Tipo_ConcesionLN(IT_Sgpal_Tipo_ConcesionAD vT_Sgpal_Tipo_ConcesionAD)
        {
            Tipo_ConcesionAD = vT_Sgpal_Tipo_ConcesionAD;
        }

        public IEnumerable<Tipo_ConcesionDTO> ListarTipo_ConcesionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_ConcesionAD.ListarT_Sgpal_Tipo_Concesion()
                                  select new Tipo_ConcesionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Tipo_Concesion = vTmp.ID_TIPO_CONCESION,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ConcesionDTO RecuperarTipo_ConcesionDTOPorCodigo(int vId_Tipo_Concesion)
        {
            try
            {
                var vResultado = Tipo_ConcesionAD.RecuperarT_Sgpal_Tipo_ConcesionPorCodigo(vId_Tipo_Concesion);
                return new Tipo_ConcesionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ConcesionDTO InsertarTipo_ConcesionDTO(Tipo_ConcesionDTO vTipo_ConcesionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Concesion();
                var vResultado = Tipo_ConcesionAD.InsertarT_Sgpal_Tipo_Concesion(vRegistro);
                return vTipo_ConcesionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ConcesionDTO ActualizarTipo_ConcesionDTO(Tipo_ConcesionDTO vTipo_ConcesionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Concesion();
                var vResultado = Tipo_ConcesionAD.ActualizarT_Sgpal_Tipo_Concesion(vRegistro);
                return vTipo_ConcesionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_ConcesionDTOPorCodigo(Tipo_ConcesionDTO vTipo_ConcesionDTO)
        {
            try
            {
                return Tipo_ConcesionAD.AnularT_Sgpal_Tipo_ConcesionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_ConcesionDTO> ListarPaginadoTipo_ConcesionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_ConcesionAD.ListarPaginadoT_Sgpal_Tipo_Concesion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_ConcesionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
