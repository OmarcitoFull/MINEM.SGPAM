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
    public class T_Sgpal_Potencial_ArdLN : BaseLN, IT_Sgpal_Potencial_ArdLN
    {
        private readonly IT_Sgpal_Potencial_ArdAD Potencial_ArdAD;

        public T_Sgpal_Potencial_ArdLN(IT_Sgpal_Potencial_ArdAD vT_Sgpal_Potencial_ArdAD)
        {
            Potencial_ArdAD = vT_Sgpal_Potencial_ArdAD;
        }

        public IEnumerable<Potencial_ArdDTO> ListarPotencial_ArdDTO()
        {
            try
            {
                var vResultado = (from vTmp in Potencial_ArdAD.ListarT_Sgpal_Potencial_Ard()
                                  select new Potencial_ArdDTO
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
                                      Peso_Lb = vTmp.PESO_LB,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Rm = vTmp.PESO_RM,
                                      Id_Potencial_Ard = vTmp.ID_POTENCIAL_ARD
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Potencial_ArdDTO RecuperarPotencial_ArdDTOPorCodigo(int vId_Potencial_Ard)
        {
            try
            {
                var vResultado = Potencial_ArdAD.RecuperarT_Sgpal_Potencial_ArdPorCodigo(vId_Potencial_Ard);
                return new Potencial_ArdDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Potencial_ArdDTO InsertarPotencial_ArdDTO(Potencial_ArdDTO vPotencial_ArdDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Potencial_Ard();
                var vResultado = Potencial_ArdAD.InsertarT_Sgpal_Potencial_Ard(vRegistro);
                return vPotencial_ArdDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Potencial_ArdDTO ActualizarPotencial_ArdDTO(Potencial_ArdDTO vPotencial_ArdDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Potencial_Ard();
                var vResultado = Potencial_ArdAD.ActualizarT_Sgpal_Potencial_Ard(vRegistro);
                return vPotencial_ArdDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularPotencial_ArdDTOPorCodigo(Potencial_ArdDTO vPotencial_ArdDTO)
        {
            try
            {
                return Potencial_ArdAD.AnularT_Sgpal_Potencial_ArdPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Potencial_ArdDTO> ListarPaginadoPotencial_ArdDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Potencial_ArdAD.ListarPaginadoT_Sgpal_Potencial_Ard(vFiltro, vNumPag, vCantRegxPag);
                return new List<Potencial_ArdDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
