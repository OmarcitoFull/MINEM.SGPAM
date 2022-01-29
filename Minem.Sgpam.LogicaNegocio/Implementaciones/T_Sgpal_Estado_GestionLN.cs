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
    public class T_Sgpal_Estado_GestionLN : BaseLN, IT_Sgpal_Estado_GestionLN
    {
        private readonly IT_Sgpal_Estado_GestionAD Estado_GestionAD;

        public T_Sgpal_Estado_GestionLN(IT_Sgpal_Estado_GestionAD vT_Sgpal_Estado_GestionAD)
        {
            Estado_GestionAD = vT_Sgpal_Estado_GestionAD;
        }

        public IEnumerable<Estado_GestionDTO> ListarEstado_GestionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Estado_GestionAD.ListarT_Sgpal_Estado_Gestion()
                                  select new Estado_GestionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Estado_Gestion = vTmp.ID_ESTADO_GESTION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_GestionDTO RecuperarEstado_GestionDTOPorCodigo(int vId_Estado_Gestion)
        {
            try
            {
                var vResultado = Estado_GestionAD.RecuperarT_Sgpal_Estado_GestionPorCodigo(vId_Estado_Gestion);
                return new Estado_GestionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_GestionDTO InsertarEstado_GestionDTO(Estado_GestionDTO vEstado_GestionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Estado_Gestion();
                var vResultado = Estado_GestionAD.InsertarT_Sgpal_Estado_Gestion(vRegistro);
                return vEstado_GestionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_GestionDTO ActualizarEstado_GestionDTO(Estado_GestionDTO vEstado_GestionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Estado_Gestion();
                var vResultado = Estado_GestionAD.ActualizarT_Sgpal_Estado_Gestion(vRegistro);
                return vEstado_GestionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularEstado_GestionDTOPorCodigo(Estado_GestionDTO vEstado_GestionDTO)
        {
            try
            {
                return Estado_GestionAD.AnularT_Sgpal_Estado_GestionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Estado_GestionDTO> ListarPaginadoEstado_GestionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Estado_GestionAD.ListarPaginadoT_Sgpal_Estado_Gestion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Estado_GestionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
