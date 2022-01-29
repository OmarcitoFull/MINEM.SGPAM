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
    public class T_Sgpal_Estado_EumLN : BaseLN, IT_Sgpal_Estado_EumLN
    {
        private readonly IT_Sgpal_Estado_EumAD Estado_EumAD;

        public T_Sgpal_Estado_EumLN(IT_Sgpal_Estado_EumAD vT_Sgpal_Estado_EumAD)
        {
            Estado_EumAD = vT_Sgpal_Estado_EumAD;
        }

        public IEnumerable<Estado_EumDTO> ListarEstado_EumDTO()
        {
            try
            {
                var vResultado = Estado_EumAD.ListarT_Sgpal_Estado_Eum();
                return new List<Estado_EumDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_EumDTO RecuperarEstado_EumDTOPorCodigo(int vId_Estado_Eum)
        {
            try
            {
                var vResultado = Estado_EumAD.RecuperarT_Sgpal_Estado_EumPorCodigo(vId_Estado_Eum);
                return new Estado_EumDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_EumDTO InsertarEstado_EumDTO(Estado_EumDTO vEstado_EumDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Estado_Eum();
                var vResultado = Estado_EumAD.InsertarT_Sgpal_Estado_Eum(vRegistro);
                return vEstado_EumDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Estado_EumDTO ActualizarEstado_EumDTO(Estado_EumDTO vEstado_EumDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Estado_Eum();
                var vResultado = Estado_EumAD.ActualizarT_Sgpal_Estado_Eum(vRegistro);
                return vEstado_EumDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularEstado_EumDTOPorCodigo(Estado_EumDTO vEstado_EumDTO)
        {
            try
            {
                return Estado_EumAD.AnularT_Sgpal_Estado_EumPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Estado_EumDTO> ListarPaginadoEstado_EumDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Estado_EumAD.ListarPaginadoT_Sgpal_Estado_Eum(vFiltro, vNumPag, vCantRegxPag);
                return new List<Estado_EumDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
