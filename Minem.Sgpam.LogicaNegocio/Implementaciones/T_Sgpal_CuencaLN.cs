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
    public class T_Sgpal_CuencaLN : BaseLN, IT_Sgpal_CuencaLN
    {
        private readonly IT_Sgpal_CuencaAD CuencaAD;

        public T_Sgpal_CuencaLN(IT_Sgpal_CuencaAD vT_Sgpal_CuencaAD)
        {
            CuencaAD = vT_Sgpal_CuencaAD;
        }

        public IEnumerable<CuencaDTO> ListarCuencaDTO()
        {
            try
            {
                var vResultado = CuencaAD.ListarT_Sgpal_Cuenca();
                return new List<CuencaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CuencaDTO RecuperarCuencaDTOPorCodigo(int vId_Cuenca)
        {
            try
            {
                var vResultado = CuencaAD.RecuperarT_Sgpal_CuencaPorCodigo(vId_Cuenca);
                return new CuencaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CuencaDTO InsertarCuencaDTO(CuencaDTO vCuencaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cuenca();
                var vResultado = CuencaAD.InsertarT_Sgpal_Cuenca(vRegistro);
                return vCuencaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CuencaDTO ActualizarCuencaDTO(CuencaDTO vCuencaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cuenca();
                var vResultado = CuencaAD.ActualizarT_Sgpal_Cuenca(vRegistro);
                return vCuencaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularCuencaDTOPorCodigo(CuencaDTO vCuencaDTO)
        {
            try
            {
                return CuencaAD.AnularT_Sgpal_CuencaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<CuencaDTO> ListarPaginadoCuencaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = CuencaAD.ListarPaginadoT_Sgpal_Cuenca(vFiltro, vNumPag, vCantRegxPag);
                return new List<CuencaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
