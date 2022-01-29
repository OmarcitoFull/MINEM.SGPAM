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
    public class T_Sgpal_RegionLN : BaseLN, IT_Sgpal_RegionLN
    {
        private readonly IT_Sgpal_RegionAD RegionAD;

        public T_Sgpal_RegionLN(IT_Sgpal_RegionAD vT_Sgpal_RegionAD)
        {
            RegionAD = vT_Sgpal_RegionAD;
        }

        public IEnumerable<RegionDTO> ListarRegionDTO()
        {
            try
            {
                var vResultado = RegionAD.ListarT_Sgpal_Region();
                return new List<RegionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegionDTO RecuperarRegionDTOPorCodigo(int vId_Region)
        {
            try
            {
                var vResultado = RegionAD.RecuperarT_Sgpal_RegionPorCodigo(vId_Region);
                return new RegionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegionDTO InsertarRegionDTO(RegionDTO vRegionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Region();
                var vResultado = RegionAD.InsertarT_Sgpal_Region(vRegistro);
                return vRegionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegionDTO ActualizarRegionDTO(RegionDTO vRegionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Region();
                var vResultado = RegionAD.ActualizarT_Sgpal_Region(vRegistro);
                return vRegionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularRegionDTOPorCodigo(RegionDTO vRegionDTO)
        {
            try
            {
                return RegionAD.AnularT_Sgpal_RegionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<RegionDTO> ListarPaginadoRegionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = RegionAD.ListarPaginadoT_Sgpal_Region(vFiltro, vNumPag, vCantRegxPag);
                return new List<RegionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
