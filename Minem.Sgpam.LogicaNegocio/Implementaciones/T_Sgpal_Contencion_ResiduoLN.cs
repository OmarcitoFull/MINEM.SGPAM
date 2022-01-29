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
    public class T_Sgpal_Contencion_ResiduoLN : BaseLN, IT_Sgpal_Contencion_ResiduoLN
    {
        private readonly IT_Sgpal_Contencion_ResiduoAD Contencion_ResiduoAD;

        public T_Sgpal_Contencion_ResiduoLN(IT_Sgpal_Contencion_ResiduoAD vT_Sgpal_Contencion_ResiduoAD)
        {
            Contencion_ResiduoAD = vT_Sgpal_Contencion_ResiduoAD;
        }

        public IEnumerable<Contencion_ResiduoDTO> ListarContencion_ResiduoDTO()
        {
            try
            {
                var vResultado = Contencion_ResiduoAD.ListarT_Sgpal_Contencion_Residuo();
                return new List<Contencion_ResiduoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Contencion_ResiduoDTO RecuperarContencion_ResiduoDTOPorCodigo(int vId_Contencion_Residuo)
        {
            try
            {
                var vResultado = Contencion_ResiduoAD.RecuperarT_Sgpal_Contencion_ResiduoPorCodigo(vId_Contencion_Residuo);
                return new Contencion_ResiduoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Contencion_ResiduoDTO InsertarContencion_ResiduoDTO(Contencion_ResiduoDTO vContencion_ResiduoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Contencion_Residuo();
                var vResultado = Contencion_ResiduoAD.InsertarT_Sgpal_Contencion_Residuo(vRegistro);
                return vContencion_ResiduoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Contencion_ResiduoDTO ActualizarContencion_ResiduoDTO(Contencion_ResiduoDTO vContencion_ResiduoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Contencion_Residuo();
                var vResultado = Contencion_ResiduoAD.ActualizarT_Sgpal_Contencion_Residuo(vRegistro);
                return vContencion_ResiduoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularContencion_ResiduoDTOPorCodigo(Contencion_ResiduoDTO vContencion_ResiduoDTO)
        {
            try
            {
                return Contencion_ResiduoAD.AnularT_Sgpal_Contencion_ResiduoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Contencion_ResiduoDTO> ListarPaginadoContencion_ResiduoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Contencion_ResiduoAD.ListarPaginadoT_Sgpal_Contencion_Residuo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Contencion_ResiduoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
