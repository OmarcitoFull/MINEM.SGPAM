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
    public class T_Sgpam_VisitaLN : BaseLN, IT_Sgpam_VisitaLN
    {
        private readonly IT_Sgpam_VisitaAD VisitaAD;

        public T_Sgpam_VisitaLN(IT_Sgpam_VisitaAD vT_Sgpam_VisitaAD)
        {
            VisitaAD = vT_Sgpam_VisitaAD;
        }

        public IEnumerable<VisitaDTO> ListarVisitaDTO()
        {
            try
            {
                var vResultado = VisitaAD.ListarT_Sgpam_Visita();
                return new List<VisitaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO RecuperarVisitaDTOPorCodigo(int vId_Visita)
        {
            try
            {
                var vResultado = VisitaAD.RecuperarT_Sgpam_VisitaPorCodigo(vId_Visita);
                return new VisitaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO InsertarVisitaDTO(VisitaDTO vVisitaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Visita();
                var vResultado = VisitaAD.InsertarT_Sgpam_Visita(vRegistro);
                return vVisitaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO ActualizarVisitaDTO(VisitaDTO vVisitaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Visita();
                var vResultado = VisitaAD.ActualizarT_Sgpam_Visita(vRegistro);
                return vVisitaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularVisitaDTOPorCodigo(VisitaDTO vVisitaDTO)
        {
            try
            {
                return VisitaAD.AnularT_Sgpam_VisitaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<VisitaDTO> ListarPaginadoVisitaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = VisitaAD.ListarPaginadoT_Sgpam_Visita(vFiltro, vNumPag, vCantRegxPag);
                return new List<VisitaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
