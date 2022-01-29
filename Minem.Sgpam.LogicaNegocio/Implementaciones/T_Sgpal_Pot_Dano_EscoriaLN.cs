using System;
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
    public class T_Sgpal_Pot_Dano_EscoriaLN : BaseLN, IT_Sgpal_Pot_Dano_EscoriaLN
    {
        private readonly IT_Sgpal_Pot_Dano_EscoriaAD Pot_Dano_EscoriaAD;

        public T_Sgpal_Pot_Dano_EscoriaLN(IT_Sgpal_Pot_Dano_EscoriaAD vT_Sgpal_Pot_Dano_EscoriaAD)
        {
            Pot_Dano_EscoriaAD = vT_Sgpal_Pot_Dano_EscoriaAD;
        }

        public IEnumerable<Pot_Dano_EscoriaDTO> ListarPot_Dano_EscoriaDTO()
        {
            try
            {
                var vResultado = Pot_Dano_EscoriaAD.ListarT_Sgpal_Pot_Dano_Escoria();
                return new List<Pot_Dano_EscoriaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Dano_EscoriaDTO RecuperarPot_Dano_EscoriaDTOPorCodigo(int vId_Pot_Dano_Escoria)
        {
            try
            {
                var vResultado = Pot_Dano_EscoriaAD.RecuperarT_Sgpal_Pot_Dano_EscoriaPorCodigo(vId_Pot_Dano_Escoria);
                return new Pot_Dano_EscoriaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Dano_EscoriaDTO InsertarPot_Dano_EscoriaDTO(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Dano_Escoria();
                var vResultado = Pot_Dano_EscoriaAD.InsertarT_Sgpal_Pot_Dano_Escoria(vRegistro);
                return vPot_Dano_EscoriaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Dano_EscoriaDTO ActualizarPot_Dano_EscoriaDTO(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Dano_Escoria();
                var vResultado = Pot_Dano_EscoriaAD.ActualizarT_Sgpal_Pot_Dano_Escoria(vRegistro);
                return vPot_Dano_EscoriaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPot_Dano_EscoriaDTOPorCodigo(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO)
        {
            try
            {
                return Pot_Dano_EscoriaAD.AnularT_Sgpal_Pot_Dano_EscoriaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_Dano_EscoriaDTO> ListarPaginadoPot_Dano_EscoriaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_Dano_EscoriaAD.ListarPaginadoT_Sgpal_Pot_Dano_Escoria(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_Dano_EscoriaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
