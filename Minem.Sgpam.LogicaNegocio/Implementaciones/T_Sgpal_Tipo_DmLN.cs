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
    public class T_Sgpal_Tipo_DmLN : BaseLN, IT_Sgpal_Tipo_DmLN
    {
        private readonly IT_Sgpal_Tipo_DmAD Tipo_DmAD;

        public T_Sgpal_Tipo_DmLN(IT_Sgpal_Tipo_DmAD vT_Sgpal_Tipo_DmAD)
        {
            Tipo_DmAD = vT_Sgpal_Tipo_DmAD;
        }

        public IEnumerable<Tipo_DmDTO> ListarTipo_DmDTO()
        {
            try
            {
                var vResultado = Tipo_DmAD.ListarT_Sgpal_Tipo_Dm();
                return new List<Tipo_DmDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_DmDTO RecuperarTipo_DmDTOPorCodigo(int vId_Tipo_Dm)
        {
            try
            {
                var vResultado = Tipo_DmAD.RecuperarT_Sgpal_Tipo_DmPorCodigo(vId_Tipo_Dm);
                return new Tipo_DmDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_DmDTO InsertarTipo_DmDTO(Tipo_DmDTO vTipo_DmDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Dm();
                var vResultado = Tipo_DmAD.InsertarT_Sgpal_Tipo_Dm(vRegistro);
                return vTipo_DmDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_DmDTO ActualizarTipo_DmDTO(Tipo_DmDTO vTipo_DmDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Dm();
                var vResultado = Tipo_DmAD.ActualizarT_Sgpal_Tipo_Dm(vRegistro);
                return vTipo_DmDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_DmDTOPorCodigo(Tipo_DmDTO vTipo_DmDTO)
        {
            try
            {
                return Tipo_DmAD.AnularT_Sgpal_Tipo_DmPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_DmDTO> ListarPaginadoTipo_DmDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_DmAD.ListarPaginadoT_Sgpal_Tipo_Dm(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_DmDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
