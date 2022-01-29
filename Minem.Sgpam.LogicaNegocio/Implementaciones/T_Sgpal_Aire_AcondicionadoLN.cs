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
    public class T_Sgpal_Aire_AcondicionadoLN : BaseLN, IT_Sgpal_Aire_AcondicionadoLN
    {
        private readonly IT_Sgpal_Aire_AcondicionadoAD Aire_AcondicionadoAD;

        public T_Sgpal_Aire_AcondicionadoLN(IT_Sgpal_Aire_AcondicionadoAD vT_Sgpal_Aire_AcondicionadoAD)
        {
            Aire_AcondicionadoAD = vT_Sgpal_Aire_AcondicionadoAD;
        }

        public IEnumerable<Aire_AcondicionadoDTO> ListarAire_AcondicionadoDTO()
        {
            try
            {
                var vResultado = Aire_AcondicionadoAD.ListarT_Sgpal_Aire_Acondicionado();
                return new List<Aire_AcondicionadoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Aire_AcondicionadoDTO RecuperarAire_AcondicionadoDTOPorCodigo(int vId_Aire_Acondicionado)
        {
            try
            {
                var vResultado = Aire_AcondicionadoAD.RecuperarT_Sgpal_Aire_AcondicionadoPorCodigo(vId_Aire_Acondicionado);
                return new Aire_AcondicionadoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Aire_AcondicionadoDTO InsertarAire_AcondicionadoDTO(Aire_AcondicionadoDTO vAire_AcondicionadoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Aire_Acondicionado();
                var vResultado = Aire_AcondicionadoAD.InsertarT_Sgpal_Aire_Acondicionado(vRegistro);
                return vAire_AcondicionadoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Aire_AcondicionadoDTO ActualizarAire_AcondicionadoDTO(Aire_AcondicionadoDTO vAire_AcondicionadoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Aire_Acondicionado();
                var vResultado = Aire_AcondicionadoAD.ActualizarT_Sgpal_Aire_Acondicionado(vRegistro);
                return vAire_AcondicionadoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularAire_AcondicionadoDTOPorCodigo(Aire_AcondicionadoDTO vAire_AcondicionadoDTO)
        {
            try
            {
                return Aire_AcondicionadoAD.AnularT_Sgpal_Aire_AcondicionadoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Aire_AcondicionadoDTO> ListarPaginadoAire_AcondicionadoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Aire_AcondicionadoAD.ListarPaginadoT_Sgpal_Aire_Acondicionado(vFiltro, vNumPag, vCantRegxPag);
                return new List<Aire_AcondicionadoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
