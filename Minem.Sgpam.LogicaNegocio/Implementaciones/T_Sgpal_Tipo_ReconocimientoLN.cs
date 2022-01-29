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
    public class T_Sgpal_Tipo_ReconocimientoLN : BaseLN, IT_Sgpal_Tipo_ReconocimientoLN
    {
        private readonly IT_Sgpal_Tipo_ReconocimientoAD Tipo_ReconocimientoAD;

        public T_Sgpal_Tipo_ReconocimientoLN(IT_Sgpal_Tipo_ReconocimientoAD vT_Sgpal_Tipo_ReconocimientoAD)
        {
            Tipo_ReconocimientoAD = vT_Sgpal_Tipo_ReconocimientoAD;
        }

        public IEnumerable<Tipo_ReconocimientoDTO> ListarTipo_ReconocimientoDTO()
        {
            try
            {
                var vResultado = Tipo_ReconocimientoAD.ListarT_Sgpal_Tipo_Reconocimiento();
                return new List<Tipo_ReconocimientoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ReconocimientoDTO RecuperarTipo_ReconocimientoDTOPorCodigo(int vId_Tipo_Reconocimiento)
        {
            try
            {
                var vResultado = Tipo_ReconocimientoAD.RecuperarT_Sgpal_Tipo_ReconocimientoPorCodigo(vId_Tipo_Reconocimiento);
                return new Tipo_ReconocimientoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ReconocimientoDTO InsertarTipo_ReconocimientoDTO(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Reconocimiento();
                var vResultado = Tipo_ReconocimientoAD.InsertarT_Sgpal_Tipo_Reconocimiento(vRegistro);
                return vTipo_ReconocimientoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_ReconocimientoDTO ActualizarTipo_ReconocimientoDTO(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Reconocimiento();
                var vResultado = Tipo_ReconocimientoAD.ActualizarT_Sgpal_Tipo_Reconocimiento(vRegistro);
                return vTipo_ReconocimientoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_ReconocimientoDTOPorCodigo(Tipo_ReconocimientoDTO vTipo_ReconocimientoDTO)
        {
            try
            {
                return Tipo_ReconocimientoAD.AnularT_Sgpal_Tipo_ReconocimientoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_ReconocimientoDTO> ListarPaginadoTipo_ReconocimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_ReconocimientoAD.ListarPaginadoT_Sgpal_Tipo_Reconocimiento(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_ReconocimientoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
