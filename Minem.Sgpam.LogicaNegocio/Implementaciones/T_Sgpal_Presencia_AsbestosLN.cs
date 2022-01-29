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
    public class T_Sgpal_Presencia_AsbestosLN : BaseLN, IT_Sgpal_Presencia_AsbestosLN
    {
        private readonly IT_Sgpal_Presencia_AsbestosAD Presencia_AsbestosAD;

        public T_Sgpal_Presencia_AsbestosLN(IT_Sgpal_Presencia_AsbestosAD vT_Sgpal_Presencia_AsbestosAD)
        {
            Presencia_AsbestosAD = vT_Sgpal_Presencia_AsbestosAD;
        }

        public IEnumerable<Presencia_AsbestosDTO> ListarPresencia_AsbestosDTO()
        {
            try
            {
                var vResultado = Presencia_AsbestosAD.ListarT_Sgpal_Presencia_Asbestos();
                return new List<Presencia_AsbestosDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AsbestosDTO RecuperarPresencia_AsbestosDTOPorCodigo(int vId_Presencia_Asbestos)
        {
            try
            {
                var vResultado = Presencia_AsbestosAD.RecuperarT_Sgpal_Presencia_AsbestosPorCodigo(vId_Presencia_Asbestos);
                return new Presencia_AsbestosDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AsbestosDTO InsertarPresencia_AsbestosDTO(Presencia_AsbestosDTO vPresencia_AsbestosDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Asbestos();
                var vResultado = Presencia_AsbestosAD.InsertarT_Sgpal_Presencia_Asbestos(vRegistro);
                return vPresencia_AsbestosDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_AsbestosDTO ActualizarPresencia_AsbestosDTO(Presencia_AsbestosDTO vPresencia_AsbestosDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Asbestos();
                var vResultado = Presencia_AsbestosAD.ActualizarT_Sgpal_Presencia_Asbestos(vRegistro);
                return vPresencia_AsbestosDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPresencia_AsbestosDTOPorCodigo(Presencia_AsbestosDTO vPresencia_AsbestosDTO)
        {
            try
            {
                return Presencia_AsbestosAD.AnularT_Sgpal_Presencia_AsbestosPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Presencia_AsbestosDTO> ListarPaginadoPresencia_AsbestosDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Presencia_AsbestosAD.ListarPaginadoT_Sgpal_Presencia_Asbestos(vFiltro, vNumPag, vCantRegxPag);
                return new List<Presencia_AsbestosDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
