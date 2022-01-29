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
    public class T_Sgpal_Cuenca_HidrograficaLN : BaseLN, IT_Sgpal_Cuenca_HidrograficaLN
    {
        private readonly IT_Sgpal_Cuenca_HidrograficaAD Cuenca_HidrograficaAD;

        public T_Sgpal_Cuenca_HidrograficaLN(IT_Sgpal_Cuenca_HidrograficaAD vT_Sgpal_Cuenca_HidrograficaAD)
        {
            Cuenca_HidrograficaAD = vT_Sgpal_Cuenca_HidrograficaAD;
        }

        public IEnumerable<Cuenca_HidrograficaDTO> ListarCuenca_HidrograficaDTO()
        {
            try
            {
                var vResultado = Cuenca_HidrograficaAD.ListarT_Sgpal_Cuenca_Hidrografica();
                return new List<Cuenca_HidrograficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cuenca_HidrograficaDTO RecuperarCuenca_HidrograficaDTOPorCodigo(int vId_Cuenca_Hidro)
        {
            try
            {
                var vResultado = Cuenca_HidrograficaAD.RecuperarT_Sgpal_Cuenca_HidrograficaPorCodigo(vId_Cuenca_Hidro);
                return new Cuenca_HidrograficaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cuenca_HidrograficaDTO InsertarCuenca_HidrograficaDTO(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cuenca_Hidrografica();
                var vResultado = Cuenca_HidrograficaAD.InsertarT_Sgpal_Cuenca_Hidrografica(vRegistro);
                return vCuenca_HidrograficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cuenca_HidrograficaDTO ActualizarCuenca_HidrograficaDTO(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cuenca_Hidrografica();
                var vResultado = Cuenca_HidrograficaAD.ActualizarT_Sgpal_Cuenca_Hidrografica(vRegistro);
                return vCuenca_HidrograficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularCuenca_HidrograficaDTOPorCodigo(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO)
        {
            try
            {
                return Cuenca_HidrograficaAD.AnularT_Sgpal_Cuenca_HidrograficaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Cuenca_HidrograficaDTO> ListarPaginadoCuenca_HidrograficaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Cuenca_HidrograficaAD.ListarPaginadoT_Sgpal_Cuenca_Hidrografica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Cuenca_HidrograficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
