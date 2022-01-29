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
    public class T_Sgpad_Lnr_Info_GraficaLN : BaseLN, IT_Sgpad_Lnr_Info_GraficaLN
    {
        private readonly IT_Sgpad_Lnr_Info_GraficaAD Lnr_Info_GraficaAD;

        public T_Sgpad_Lnr_Info_GraficaLN(IT_Sgpad_Lnr_Info_GraficaAD vT_Sgpad_Lnr_Info_GraficaAD)
        {
            Lnr_Info_GraficaAD = vT_Sgpad_Lnr_Info_GraficaAD;
        }

        public IEnumerable<Lnr_Info_GraficaDTO> ListarLnr_Info_GraficaDTO()
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.ListarT_Sgpad_Lnr_Info_Grafica();
                return new List<Lnr_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_GraficaDTO RecuperarLnr_Info_GraficaDTOPorCodigo(int vId_Lnr_Info_Grafica)
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.RecuperarT_Sgpad_Lnr_Info_GraficaPorCodigo(vId_Lnr_Info_Grafica);
                return new Lnr_Info_GraficaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_GraficaDTO InsertarLnr_Info_GraficaDTO(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr_Info_Grafica();
                var vResultado = Lnr_Info_GraficaAD.InsertarT_Sgpad_Lnr_Info_Grafica(vRegistro);
                return vLnr_Info_GraficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_GraficaDTO ActualizarLnr_Info_GraficaDTO(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr_Info_Grafica();
                var vResultado = Lnr_Info_GraficaAD.ActualizarT_Sgpad_Lnr_Info_Grafica(vRegistro);
                return vLnr_Info_GraficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularLnr_Info_GraficaDTOPorCodigo(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            try
            {
                return Lnr_Info_GraficaAD.AnularT_Sgpad_Lnr_Info_GraficaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Lnr_Info_GraficaDTO> ListarPaginadoLnr_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.ListarPaginadoT_Sgpad_Lnr_Info_Grafica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Lnr_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
