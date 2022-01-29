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
    public class T_Sgpal_Fuente_PasivoLN : BaseLN, IT_Sgpal_Fuente_PasivoLN
    {
        private readonly IT_Sgpal_Fuente_PasivoAD Fuente_PasivoAD;

        public T_Sgpal_Fuente_PasivoLN(IT_Sgpal_Fuente_PasivoAD vT_Sgpal_Fuente_PasivoAD)
        {
            Fuente_PasivoAD = vT_Sgpal_Fuente_PasivoAD;
        }

        public IEnumerable<Fuente_PasivoDTO> ListarFuente_PasivoDTO()
        {
            try
            {
                var vResultado = Fuente_PasivoAD.ListarT_Sgpal_Fuente_Pasivo();
                return new List<Fuente_PasivoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Fuente_PasivoDTO RecuperarFuente_PasivoDTOPorCodigo(int vId_Fuente_Pasivo)
        {
            try
            {
                var vResultado = Fuente_PasivoAD.RecuperarT_Sgpal_Fuente_PasivoPorCodigo(vId_Fuente_Pasivo);
                return new Fuente_PasivoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Fuente_PasivoDTO InsertarFuente_PasivoDTO(Fuente_PasivoDTO vFuente_PasivoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Fuente_Pasivo();
                var vResultado = Fuente_PasivoAD.InsertarT_Sgpal_Fuente_Pasivo(vRegistro);
                return vFuente_PasivoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Fuente_PasivoDTO ActualizarFuente_PasivoDTO(Fuente_PasivoDTO vFuente_PasivoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Fuente_Pasivo();
                var vResultado = Fuente_PasivoAD.ActualizarT_Sgpal_Fuente_Pasivo(vRegistro);
                return vFuente_PasivoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularFuente_PasivoDTOPorCodigo(Fuente_PasivoDTO vFuente_PasivoDTO)
        {
            try
            {
                return Fuente_PasivoAD.AnularT_Sgpal_Fuente_PasivoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Fuente_PasivoDTO> ListarPaginadoFuente_PasivoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Fuente_PasivoAD.ListarPaginadoT_Sgpal_Fuente_Pasivo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Fuente_PasivoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
