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
    public class T_Sgpal_Pot_ColapsoLN : BaseLN, IT_Sgpal_Pot_ColapsoLN
    {
        private readonly IT_Sgpal_Pot_ColapsoAD Pot_ColapsoAD;

        public T_Sgpal_Pot_ColapsoLN(IT_Sgpal_Pot_ColapsoAD vT_Sgpal_Pot_ColapsoAD)
        {
            Pot_ColapsoAD = vT_Sgpal_Pot_ColapsoAD;
        }

        public IEnumerable<Pot_ColapsoDTO> ListarPot_ColapsoDTO()
        {
            try
            {
                var vResultado = (from vTmp in Pot_ColapsoAD.ListarT_Sgpal_Pot_Colapso()
                                  select new Pot_ColapsoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Pot_Colapso = vTmp.ID_POT_COLAPSO,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Lb = vTmp.PESO_LB,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Rm = vTmp.PESO_RM
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ColapsoDTO RecuperarPot_ColapsoDTOPorCodigo(int vId_Pot_Colapso)
        {
            try
            {
                var vResultado = Pot_ColapsoAD.RecuperarT_Sgpal_Pot_ColapsoPorCodigo(vId_Pot_Colapso);
                return new Pot_ColapsoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ColapsoDTO InsertarPot_ColapsoDTO(Pot_ColapsoDTO vPot_ColapsoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Colapso();
                var vResultado = Pot_ColapsoAD.InsertarT_Sgpal_Pot_Colapso(vRegistro);
                return vPot_ColapsoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ColapsoDTO ActualizarPot_ColapsoDTO(Pot_ColapsoDTO vPot_ColapsoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Colapso();
                var vResultado = Pot_ColapsoAD.ActualizarT_Sgpal_Pot_Colapso(vRegistro);
                return vPot_ColapsoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularPot_ColapsoDTOPorCodigo(Pot_ColapsoDTO vPot_ColapsoDTO)
        {
            try
            {
                return Pot_ColapsoAD.AnularT_Sgpal_Pot_ColapsoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_ColapsoDTO> ListarPaginadoPot_ColapsoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_ColapsoAD.ListarPaginadoT_Sgpal_Pot_Colapso(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_ColapsoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
