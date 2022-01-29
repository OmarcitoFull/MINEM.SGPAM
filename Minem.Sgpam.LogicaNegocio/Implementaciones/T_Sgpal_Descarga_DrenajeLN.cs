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
    public class T_Sgpal_Descarga_DrenajeLN : BaseLN, IT_Sgpal_Descarga_DrenajeLN
    {
        private readonly IT_Sgpal_Descarga_DrenajeAD Descarga_DrenajeAD;

        public T_Sgpal_Descarga_DrenajeLN(IT_Sgpal_Descarga_DrenajeAD vT_Sgpal_Descarga_DrenajeAD)
        {
            Descarga_DrenajeAD = vT_Sgpal_Descarga_DrenajeAD;
        }

        public IEnumerable<Descarga_DrenajeDTO> ListarDescarga_DrenajeDTO()
        {
            try
            {
                var vResultado = Descarga_DrenajeAD.ListarT_Sgpal_Descarga_Drenaje();
                return new List<Descarga_DrenajeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Descarga_DrenajeDTO RecuperarDescarga_DrenajeDTOPorCodigo(int vId_Descarga_Drenaje)
        {
            try
            {
                var vResultado = Descarga_DrenajeAD.RecuperarT_Sgpal_Descarga_DrenajePorCodigo(vId_Descarga_Drenaje);
                return new Descarga_DrenajeDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Descarga_DrenajeDTO InsertarDescarga_DrenajeDTO(Descarga_DrenajeDTO vDescarga_DrenajeDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Descarga_Drenaje();
                var vResultado = Descarga_DrenajeAD.InsertarT_Sgpal_Descarga_Drenaje(vRegistro);
                return vDescarga_DrenajeDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Descarga_DrenajeDTO ActualizarDescarga_DrenajeDTO(Descarga_DrenajeDTO vDescarga_DrenajeDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Descarga_Drenaje();
                var vResultado = Descarga_DrenajeAD.ActualizarT_Sgpal_Descarga_Drenaje(vRegistro);
                return vDescarga_DrenajeDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularDescarga_DrenajeDTOPorCodigo(Descarga_DrenajeDTO vDescarga_DrenajeDTO)
        {
            try
            {
                return Descarga_DrenajeAD.AnularT_Sgpal_Descarga_DrenajePorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Descarga_DrenajeDTO> ListarPaginadoDescarga_DrenajeDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Descarga_DrenajeAD.ListarPaginadoT_Sgpal_Descarga_Drenaje(vFiltro, vNumPag, vCantRegxPag);
                return new List<Descarga_DrenajeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
