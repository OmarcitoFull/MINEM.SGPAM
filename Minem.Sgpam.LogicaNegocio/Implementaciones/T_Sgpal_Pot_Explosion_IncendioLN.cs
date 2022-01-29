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
    public class T_Sgpal_Pot_Explosion_IncendioLN : BaseLN, IT_Sgpal_Pot_Explosion_IncendioLN
    {
        private readonly IT_Sgpal_Pot_Explosion_IncendioAD Pot_Explosion_IncendioAD;

        public T_Sgpal_Pot_Explosion_IncendioLN(IT_Sgpal_Pot_Explosion_IncendioAD vT_Sgpal_Pot_Explosion_IncendioAD)
        {
            Pot_Explosion_IncendioAD = vT_Sgpal_Pot_Explosion_IncendioAD;
        }

        public IEnumerable<Pot_Explosion_IncendioDTO> ListarPot_Explosion_IncendioDTO()
        {
            try
            {
                var vResultado = Pot_Explosion_IncendioAD.ListarT_Sgpal_Pot_Explosion_Incendio();
                return new List<Pot_Explosion_IncendioDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Explosion_IncendioDTO RecuperarPot_Explosion_IncendioDTOPorCodigo()
        {
            try
            {
                var vResultado = Pot_Explosion_IncendioAD.RecuperarT_Sgpal_Pot_Explosion_IncendioPorCodigo();
                return new Pot_Explosion_IncendioDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Explosion_IncendioDTO InsertarPot_Explosion_IncendioDTO(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Explosion_Incendio();
                var vResultado = Pot_Explosion_IncendioAD.InsertarT_Sgpal_Pot_Explosion_Incendio(vRegistro);
                return vPot_Explosion_IncendioDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Pot_Explosion_IncendioDTO ActualizarPot_Explosion_IncendioDTO(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Pot_Explosion_Incendio();
                var vResultado = Pot_Explosion_IncendioAD.ActualizarT_Sgpal_Pot_Explosion_Incendio(vRegistro);
                return vPot_Explosion_IncendioDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPot_Explosion_IncendioDTOPorCodigo(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO)
        {
            try
            {
                //return Pot_Explosion_IncendioAD.AnularT_Sgpal_Pot_Explosion_IncendioPorCodigo(vPot_Explosion_IncendioDTO.Id_Pot_Explosion_Incendio);
                return 0;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Pot_Explosion_IncendioDTO> ListarPaginadoPot_Explosion_IncendioDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Pot_Explosion_IncendioAD.ListarPaginadoT_Sgpal_Pot_Explosion_Incendio(vFiltro, vNumPag, vCantRegxPag);
                return new List<Pot_Explosion_IncendioDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
