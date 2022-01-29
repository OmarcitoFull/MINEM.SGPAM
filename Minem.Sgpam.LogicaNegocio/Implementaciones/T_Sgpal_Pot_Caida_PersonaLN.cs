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
    public class T_Sgpal_Pot_Caida_PersonaLN : BaseLN, IT_Sgpal_Pot_Caida_PersonaLN
    {
        private readonly IT_Sgpal_Pot_Caida_PersonaAD Pot_Caida_PersonaAD;

        public T_Sgpal_Pot_Caida_PersonaLN(IT_Sgpal_Pot_Caida_PersonaAD vT_Sgpal_Pot_Caida_PersonaAD)
        {
            Pot_Caida_PersonaAD = vT_Sgpal_Pot_Caida_PersonaAD;
        }

        public IEnumerable<Pot_Caida_PersonaDTO> ListarPot_Caida_PersonaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Pot_Caida_PersonaAD.ListarT_Sgpal_Pot_Caida_Persona()
                                  select new Pot_Caida_PersonaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Pot_Caida_Persona = vTmp.ID_POT_CAIDA_PERSONA,
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

        public Pot_Caida_PersonaDTO RecuperarPot_Caida_PersonaDTOPorCodigo(int vId_Pot_Caida_Persona)
        {
            try
            {
                var vResultado = Pot_Caida_PersonaAD.RecuperarT_Sgpal_Pot_Caida_PersonaPorCodigo(vId_Pot_Caida_Persona);
                return new Pot_Caida_PersonaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Caida_PersonaDTO InsertarPot_Caida_PersonaDTO(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Caida_Persona();
                var vResultado = Pot_Caida_PersonaAD.InsertarT_Sgpal_Pot_Caida_Persona(vRegistro);
                return vPot_Caida_PersonaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Caida_PersonaDTO ActualizarPot_Caida_PersonaDTO(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Caida_Persona();
                var vResultado = Pot_Caida_PersonaAD.ActualizarT_Sgpal_Pot_Caida_Persona(vRegistro);
                return vPot_Caida_PersonaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularPot_Caida_PersonaDTOPorCodigo(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO)
        {
            try
            {
                return Pot_Caida_PersonaAD.AnularT_Sgpal_Pot_Caida_PersonaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_Caida_PersonaDTO> ListarPaginadoPot_Caida_PersonaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_Caida_PersonaAD.ListarPaginadoT_Sgpal_Pot_Caida_Persona(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_Caida_PersonaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
