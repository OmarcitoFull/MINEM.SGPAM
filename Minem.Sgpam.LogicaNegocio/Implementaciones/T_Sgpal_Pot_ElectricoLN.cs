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
    public class T_Sgpal_Pot_ElectricoLN : BaseLN, IT_Sgpal_Pot_ElectricoLN
    {
        private readonly IT_Sgpal_Pot_ElectricoAD Pot_ElectricoAD;

        public T_Sgpal_Pot_ElectricoLN(IT_Sgpal_Pot_ElectricoAD vT_Sgpal_Pot_ElectricoAD)
        {
            Pot_ElectricoAD = vT_Sgpal_Pot_ElectricoAD;
        }

        public IEnumerable<Pot_ElectricoDTO> ListarPot_ElectricoDTO()
        {
            try
            {
                var vResultado = Pot_ElectricoAD.ListarT_Sgpal_Pot_Electrico();
                return new List<Pot_ElectricoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ElectricoDTO RecuperarPot_ElectricoDTOPorCodigo(int vId_Pot_Electrico)
        {
            try
            {
                var vResultado = Pot_ElectricoAD.RecuperarT_Sgpal_Pot_ElectricoPorCodigo(vId_Pot_Electrico);
                return new Pot_ElectricoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ElectricoDTO InsertarPot_ElectricoDTO(Pot_ElectricoDTO vPot_ElectricoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Electrico();
                var vResultado = Pot_ElectricoAD.InsertarT_Sgpal_Pot_Electrico(vRegistro);
                return vPot_ElectricoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_ElectricoDTO ActualizarPot_ElectricoDTO(Pot_ElectricoDTO vPot_ElectricoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Electrico();
                var vResultado = Pot_ElectricoAD.ActualizarT_Sgpal_Pot_Electrico(vRegistro);
                return vPot_ElectricoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPot_ElectricoDTOPorCodigo(Pot_ElectricoDTO vPot_ElectricoDTO)
        {
            try
            {
                return Pot_ElectricoAD.AnularT_Sgpal_Pot_ElectricoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_ElectricoDTO> ListarPaginadoPot_ElectricoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_ElectricoAD.ListarPaginadoT_Sgpal_Pot_Electrico(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_ElectricoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
