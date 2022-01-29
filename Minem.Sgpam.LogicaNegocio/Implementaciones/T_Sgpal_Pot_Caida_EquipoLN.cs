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
    public class T_Sgpal_Pot_Caida_EquipoLN : BaseLN, IT_Sgpal_Pot_Caida_EquipoLN
    {
        private readonly IT_Sgpal_Pot_Caida_EquipoAD Pot_Caida_EquipoAD;

        public T_Sgpal_Pot_Caida_EquipoLN(IT_Sgpal_Pot_Caida_EquipoAD vT_Sgpal_Pot_Caida_EquipoAD)
        {
            Pot_Caida_EquipoAD = vT_Sgpal_Pot_Caida_EquipoAD;
        }

        public IEnumerable<Pot_Caida_EquipoDTO> ListarPot_Caida_EquipoDTO()
        {
            try
            {
                var vResultado = Pot_Caida_EquipoAD.ListarT_Sgpal_Pot_Caida_Equipo();
                return new List<Pot_Caida_EquipoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Caida_EquipoDTO RecuperarPot_Caida_EquipoDTOPorCodigo(int vId_Pot_Caida_Equipo)
        {
            try
            {
                var vResultado = Pot_Caida_EquipoAD.RecuperarT_Sgpal_Pot_Caida_EquipoPorCodigo(vId_Pot_Caida_Equipo);
                return new Pot_Caida_EquipoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Caida_EquipoDTO InsertarPot_Caida_EquipoDTO(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Caida_Equipo();
                var vResultado = Pot_Caida_EquipoAD.InsertarT_Sgpal_Pot_Caida_Equipo(vRegistro);
                return vPot_Caida_EquipoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Caida_EquipoDTO ActualizarPot_Caida_EquipoDTO(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Caida_Equipo();
                var vResultado = Pot_Caida_EquipoAD.ActualizarT_Sgpal_Pot_Caida_Equipo(vRegistro);
                return vPot_Caida_EquipoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPot_Caida_EquipoDTOPorCodigo(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO)
        {
            try
            {
                return Pot_Caida_EquipoAD.AnularT_Sgpal_Pot_Caida_EquipoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_Caida_EquipoDTO> ListarPaginadoPot_Caida_EquipoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_Caida_EquipoAD.ListarPaginadoT_Sgpal_Pot_Caida_Equipo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_Caida_EquipoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
