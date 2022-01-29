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
    public class T_Sgpal_Presencia_LiquidoLN : BaseLN, IT_Sgpal_Presencia_LiquidoLN
    {
        private readonly IT_Sgpal_Presencia_LiquidoAD Presencia_LiquidoAD;

        public T_Sgpal_Presencia_LiquidoLN(IT_Sgpal_Presencia_LiquidoAD vT_Sgpal_Presencia_LiquidoAD)
        {
            Presencia_LiquidoAD = vT_Sgpal_Presencia_LiquidoAD;
        }

        public IEnumerable<Presencia_LiquidoDTO> ListarPresencia_LiquidoDTO()
        {
            try
            {
                var vResultado = Presencia_LiquidoAD.ListarT_Sgpal_Presencia_Liquido();
                return new List<Presencia_LiquidoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_LiquidoDTO RecuperarPresencia_LiquidoDTOPorCodigo(int vId_Presencia_Liquido)
        {
            try
            {
                var vResultado = Presencia_LiquidoAD.RecuperarT_Sgpal_Presencia_LiquidoPorCodigo(vId_Presencia_Liquido);
                return new Presencia_LiquidoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_LiquidoDTO InsertarPresencia_LiquidoDTO(Presencia_LiquidoDTO vPresencia_LiquidoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Liquido();
                var vResultado = Presencia_LiquidoAD.InsertarT_Sgpal_Presencia_Liquido(vRegistro);
                return vPresencia_LiquidoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_LiquidoDTO ActualizarPresencia_LiquidoDTO(Presencia_LiquidoDTO vPresencia_LiquidoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Liquido();
                var vResultado = Presencia_LiquidoAD.ActualizarT_Sgpal_Presencia_Liquido(vRegistro);
                return vPresencia_LiquidoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularPresencia_LiquidoDTOPorCodigo(Presencia_LiquidoDTO vPresencia_LiquidoDTO)
        {
            try
            {
                return Presencia_LiquidoAD.AnularT_Sgpal_Presencia_LiquidoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Presencia_LiquidoDTO> ListarPaginadoPresencia_LiquidoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Presencia_LiquidoAD.ListarPaginadoT_Sgpal_Presencia_Liquido(vFiltro, vNumPag, vCantRegxPag);
                return new List<Presencia_LiquidoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
