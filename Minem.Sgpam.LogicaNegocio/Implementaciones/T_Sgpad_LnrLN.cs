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
    public class T_Sgpad_LnrLN : BaseLN, IT_Sgpad_LnrLN
    {
        private readonly IT_Sgpad_LnrAD LnrAD;

        public T_Sgpad_LnrLN(IT_Sgpad_LnrAD vT_Sgpad_LnrAD)
        {
            LnrAD = vT_Sgpad_LnrAD;
        }

        public IEnumerable<LnrDTO> ListarLnrDTO()
        {
            try
            {
                var vResultado = LnrAD.ListarT_Sgpad_Lnr();
                return new List<LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO RecuperarLnrDTOPorCodigo(int vId_Lnr)
        {
            try
            {
                var vResultado = LnrAD.RecuperarT_Sgpad_LnrPorCodigo(vId_Lnr);
                return new LnrDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO InsertarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr();
                var vResultado = LnrAD.InsertarT_Sgpad_Lnr(vRegistro);
                return vLnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO ActualizarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr();
                var vResultado = LnrAD.ActualizarT_Sgpad_Lnr(vRegistro);
                return vLnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularLnrDTOPorCodigo(LnrDTO vLnrDTO)
        {
            try
            {
                return LnrAD.AnularT_Sgpad_LnrPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<LnrDTO> ListarPaginadoLnrDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = LnrAD.ListarPaginadoT_Sgpad_Lnr(vFiltro, vNumPag, vCantRegxPag);
                return new List<LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
