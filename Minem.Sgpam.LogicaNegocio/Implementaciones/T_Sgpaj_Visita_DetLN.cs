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
    public class T_Sgpaj_Visita_DetLN : BaseLN, IT_Sgpaj_Visita_DetLN
    {
        private readonly IT_Sgpaj_Visita_DetAD Visita_DetAD;

        public T_Sgpaj_Visita_DetLN(IT_Sgpaj_Visita_DetAD vT_Sgpaj_Visita_DetAD)
        {
            Visita_DetAD = vT_Sgpaj_Visita_DetAD;
        }

        public IEnumerable<Visita_DetDTO> ListarVisita_DetDTO()
        {
            try
            {
                var vResultado = Visita_DetAD.ListarT_Sgpaj_Visita_Det();
                return new List<Visita_DetDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_DetDTO RecuperarVisita_DetDTOPorCodigo(int vId_Visita_Det)
        {
            try
            {
                var vResultado = Visita_DetAD.RecuperarT_Sgpaj_Visita_DetPorCodigo(vId_Visita_Det);
                return new Visita_DetDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_DetDTO InsertarVisita_DetDTO(Visita_DetDTO vVisita_DetDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Visita_Det();
                var vResultado = Visita_DetAD.InsertarT_Sgpaj_Visita_Det(vRegistro);
                return vVisita_DetDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_DetDTO ActualizarVisita_DetDTO(Visita_DetDTO vVisita_DetDTO)
        {
            try
            {
                var vRegistro = new T_Sgpaj_Visita_Det();
                var vResultado = Visita_DetAD.ActualizarT_Sgpaj_Visita_Det(vRegistro);
                return vVisita_DetDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularVisita_DetDTOPorCodigo(Visita_DetDTO vVisita_DetDTO)
        {
            try
            {
                return Visita_DetAD.AnularT_Sgpaj_Visita_DetPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_DetDTO> ListarPaginadoVisita_DetDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Visita_DetAD.ListarPaginadoT_Sgpaj_Visita_Det(vFiltro, vNumPag, vCantRegxPag);
                return new List<Visita_DetDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
