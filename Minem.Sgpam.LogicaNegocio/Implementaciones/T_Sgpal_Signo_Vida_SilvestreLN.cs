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
    public class T_Sgpal_Signo_Vida_SilvestreLN : BaseLN, IT_Sgpal_Signo_Vida_SilvestreLN
    {
        private readonly IT_Sgpal_Signo_Vida_SilvestreAD Signo_Vida_SilvestreAD;

        public T_Sgpal_Signo_Vida_SilvestreLN(IT_Sgpal_Signo_Vida_SilvestreAD vT_Sgpal_Signo_Vida_SilvestreAD)
        {
            Signo_Vida_SilvestreAD = vT_Sgpal_Signo_Vida_SilvestreAD;
        }

        public IEnumerable<Signo_Vida_SilvestreDTO> ListarSigno_Vida_SilvestreDTO()
        {
            try
            {
                var vResultado = Signo_Vida_SilvestreAD.ListarT_Sgpal_Signo_Vida_Silvestre();
                return new List<Signo_Vida_SilvestreDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Signo_Vida_SilvestreDTO RecuperarSigno_Vida_SilvestreDTOPorCodigo(int vId_Signo_Vida_Silvestre)
        {
            try
            {
                var vResultado = Signo_Vida_SilvestreAD.RecuperarT_Sgpal_Signo_Vida_SilvestrePorCodigo(vId_Signo_Vida_Silvestre);
                return new Signo_Vida_SilvestreDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Signo_Vida_SilvestreDTO InsertarSigno_Vida_SilvestreDTO(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Signo_Vida_Silvestre();
                var vResultado = Signo_Vida_SilvestreAD.InsertarT_Sgpal_Signo_Vida_Silvestre(vRegistro);
                return vSigno_Vida_SilvestreDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Signo_Vida_SilvestreDTO ActualizarSigno_Vida_SilvestreDTO(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Signo_Vida_Silvestre();
                var vResultado = Signo_Vida_SilvestreAD.ActualizarT_Sgpal_Signo_Vida_Silvestre(vRegistro);
                return vSigno_Vida_SilvestreDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularSigno_Vida_SilvestreDTOPorCodigo(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO)
        {
            try
            {
                return Signo_Vida_SilvestreAD.AnularT_Sgpal_Signo_Vida_SilvestrePorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Signo_Vida_SilvestreDTO> ListarPaginadoSigno_Vida_SilvestreDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Signo_Vida_SilvestreAD.ListarPaginadoT_Sgpal_Signo_Vida_Silvestre(vFiltro, vNumPag, vCantRegxPag);
                return new List<Signo_Vida_SilvestreDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
