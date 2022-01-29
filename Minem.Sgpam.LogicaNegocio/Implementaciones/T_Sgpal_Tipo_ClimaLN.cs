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
    public class T_Sgpal_Tipo_ClimaLN : BaseLN, IT_Sgpal_Tipo_ClimaLN
    {
        private readonly IT_Sgpal_Tipo_ClimaAD Tipo_ClimaAD;

        public T_Sgpal_Tipo_ClimaLN(IT_Sgpal_Tipo_ClimaAD vT_Sgpal_Tipo_ClimaAD)
        {
            Tipo_ClimaAD = vT_Sgpal_Tipo_ClimaAD;
        }

        public IEnumerable<Tipo_ClimaDTO> ListarTipo_ClimaDTO()
        {
            try
            {
                var vResultado = Tipo_ClimaAD.ListarT_Sgpal_Tipo_Clima();
                return new List<Tipo_ClimaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ClimaDTO RecuperarTipo_ClimaDTOPorCodigo(int vId_Tipo_Clima)
        {
            try
            {
                var vResultado = Tipo_ClimaAD.RecuperarT_Sgpal_Tipo_ClimaPorCodigo(vId_Tipo_Clima);
                return new Tipo_ClimaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ClimaDTO InsertarTipo_ClimaDTO(Tipo_ClimaDTO vTipo_ClimaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Clima();
                var vResultado = Tipo_ClimaAD.InsertarT_Sgpal_Tipo_Clima(vRegistro);
                return vTipo_ClimaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ClimaDTO ActualizarTipo_ClimaDTO(Tipo_ClimaDTO vTipo_ClimaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Clima();
                var vResultado = Tipo_ClimaAD.ActualizarT_Sgpal_Tipo_Clima(vRegistro);
                return vTipo_ClimaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_ClimaDTOPorCodigo(Tipo_ClimaDTO vTipo_ClimaDTO)
        {
            try
            {
                return Tipo_ClimaAD.AnularT_Sgpal_Tipo_ClimaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_ClimaDTO> ListarPaginadoTipo_ClimaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_ClimaAD.ListarPaginadoT_Sgpal_Tipo_Clima(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_ClimaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
