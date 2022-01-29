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
    public class T_Sgpal_ProvinciaLN : BaseLN, IT_Sgpal_ProvinciaLN
    {
        private readonly IT_Sgpal_ProvinciaAD ProvinciaAD;

        public T_Sgpal_ProvinciaLN(IT_Sgpal_ProvinciaAD vT_Sgpal_ProvinciaAD)
        {
            ProvinciaAD = vT_Sgpal_ProvinciaAD;
        }

        public IEnumerable<ProvinciaDTO> ListarProvinciaDTO()
        {
            try
            {
                var vResultado = ProvinciaAD.ListarT_Sgpal_Provincia();
                return new List<ProvinciaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ProvinciaDTO RecuperarProvinciaDTOPorCodigo(int vId_Provincia)
        {
            try
            {
                var vResultado = ProvinciaAD.RecuperarT_Sgpal_ProvinciaPorCodigo(vId_Provincia);
                return new ProvinciaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ProvinciaDTO InsertarProvinciaDTO(ProvinciaDTO vProvinciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Provincia();
                var vResultado = ProvinciaAD.InsertarT_Sgpal_Provincia(vRegistro);
                return vProvinciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ProvinciaDTO ActualizarProvinciaDTO(ProvinciaDTO vProvinciaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Provincia();
                var vResultado = ProvinciaAD.ActualizarT_Sgpal_Provincia(vRegistro);
                return vProvinciaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularProvinciaDTOPorCodigo(ProvinciaDTO vProvinciaDTO)
        {
            try
            {
                return ProvinciaAD.AnularT_Sgpal_ProvinciaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<ProvinciaDTO> ListarPaginadoProvinciaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = ProvinciaAD.ListarPaginadoT_Sgpal_Provincia(vFiltro, vNumPag, vCantRegxPag);
                return new List<ProvinciaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
