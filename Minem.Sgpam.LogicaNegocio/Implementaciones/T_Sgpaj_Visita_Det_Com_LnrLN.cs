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
    public class T_Sgpaj_Visita_Det_Com_LnrLN : BaseLN, IT_Sgpaj_Visita_Det_Com_LnrLN
    {
        private readonly IT_Sgpaj_Visita_Det_Com_LnrAD Visita_Det_Com_LnrAD;

        public T_Sgpaj_Visita_Det_Com_LnrLN(IT_Sgpaj_Visita_Det_Com_LnrAD vT_Sgpaj_Visita_Det_Com_LnrAD)
        {
            Visita_Det_Com_LnrAD = vT_Sgpaj_Visita_Det_Com_LnrAD;
        }

        public IEnumerable<Visita_Det_Com_LnrDTO> ListarVisita_Det_Com_LnrDTO()
        {
            try
            {
                var vResultado = Visita_Det_Com_LnrAD.ListarT_Sgpaj_Visita_Det_Com_Lnr();
                return new List<Visita_Det_Com_LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_Det_Com_LnrDTO RecuperarVisita_Det_Com_LnrDTOPorCodigo(int vId_Visita_Det_Com_Lnr)
        {
            try
            {
                var vResultado = Visita_Det_Com_LnrAD.RecuperarT_Sgpaj_Visita_Det_Com_LnrPorCodigo(vId_Visita_Det_Com_Lnr);
                return new Visita_Det_Com_LnrDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_Det_Com_LnrDTO InsertarVisita_Det_Com_LnrDTO(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Visita_Det_Com_Lnr();
                var vResultado = Visita_Det_Com_LnrAD.InsertarT_Sgpaj_Visita_Det_Com_Lnr(vRegistro);
                return vVisita_Det_Com_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_Det_Com_LnrDTO ActualizarVisita_Det_Com_LnrDTO(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Visita_Det_Com_Lnr();
                var vResultado = Visita_Det_Com_LnrAD.ActualizarT_Sgpaj_Visita_Det_Com_Lnr(vRegistro);
                return vVisita_Det_Com_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularVisita_Det_Com_LnrDTOPorCodigo(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO)
        {
            try
            {
                return Visita_Det_Com_LnrAD.AnularT_Sgpaj_Visita_Det_Com_LnrPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_Det_Com_LnrDTO> ListarPaginadoVisita_Det_Com_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Visita_Det_Com_LnrAD.ListarPaginadoT_Sgpaj_Visita_Det_Com_Lnr(vFiltro, vNumPag, vCantRegxPag);
                return new List<Visita_Det_Com_LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
