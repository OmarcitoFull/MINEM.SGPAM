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
    public class T_Sgpad_Eum_InformeLN : BaseLN, IT_Sgpad_Eum_InformeLN
    {
        private readonly IT_Sgpad_Eum_InformeAD Eum_InformeAD;

        public T_Sgpad_Eum_InformeLN(IT_Sgpad_Eum_InformeAD vT_Sgpad_Eum_InformeAD)
        {
            Eum_InformeAD = vT_Sgpad_Eum_InformeAD;
        }

        public IEnumerable<Eum_InformeDTO> ListarEum_InformeDTO()
        {
            try
            {
                var vResultado = Eum_InformeAD.ListarT_Sgpad_Eum_Informe();
                return new List<Eum_InformeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InformeDTO RecuperarEum_InformeDTOPorCodigo(int vId_Eum_Informe)
        {
            try
            {
                var vResultado = Eum_InformeAD.RecuperarT_Sgpad_Eum_InformePorCodigo(vId_Eum_Informe);
                return new Eum_InformeDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InformeDTO InsertarEum_InformeDTO(Eum_InformeDTO vEum_InformeDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Informe();
                var vResultado = Eum_InformeAD.InsertarT_Sgpad_Eum_Informe(vRegistro);
                return vEum_InformeDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InformeDTO ActualizarEum_InformeDTO(Eum_InformeDTO vEum_InformeDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Informe();
                var vResultado = Eum_InformeAD.ActualizarT_Sgpad_Eum_Informe(vRegistro);
                return vEum_InformeDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularEum_InformeDTOPorCodigo(Eum_InformeDTO vEum_InformeDTO)
        {
            try
            {
                return Eum_InformeAD.AnularT_Sgpad_Eum_InformePorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_InformeDTO> ListarPaginadoEum_InformeDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_InformeAD.ListarPaginadoT_Sgpad_Eum_Informe(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_InformeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}