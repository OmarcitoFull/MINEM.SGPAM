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
    public class T_Sgpad_Comp_Dd_MineroLN : BaseLN, IT_Sgpad_Comp_Dd_MineroLN
    {
        private readonly IT_Sgpad_Comp_Dd_MineroAD Comp_Dd_MineroAD;

        public T_Sgpad_Comp_Dd_MineroLN(IT_Sgpad_Comp_Dd_MineroAD vT_Sgpad_Comp_Dd_MineroAD)
        {
            Comp_Dd_MineroAD = vT_Sgpad_Comp_Dd_MineroAD;
        }

        public IEnumerable<Comp_Dd_MineroDTO> ListarComp_Dd_MineroDTO()
        {
            try
            {
                var vResultado = Comp_Dd_MineroAD.ListarT_Sgpad_Comp_Dd_Minero();
                return new List<Comp_Dd_MineroDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dd_MineroDTO RecuperarComp_Dd_MineroDTOPorCodigo(int vId_Comp_Dm)
        {
            try
            {
                var vResultado = Comp_Dd_MineroAD.RecuperarT_Sgpad_Comp_Dd_MineroPorCodigo(vId_Comp_Dm);
                return new Comp_Dd_MineroDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dd_MineroDTO InsertarComp_Dd_MineroDTO(Comp_Dd_MineroDTO vComp_Dd_MineroDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dd_Minero();
                var vResultado = Comp_Dd_MineroAD.InsertarT_Sgpad_Comp_Dd_Minero(vRegistro);
                return vComp_Dd_MineroDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dd_MineroDTO ActualizarComp_Dd_MineroDTO(Comp_Dd_MineroDTO vComp_Dd_MineroDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dd_Minero();
                var vResultado = Comp_Dd_MineroAD.ActualizarT_Sgpad_Comp_Dd_Minero(vRegistro);
                return vComp_Dd_MineroDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularComp_Dd_MineroDTOPorCodigo(Comp_Dd_MineroDTO vComp_Dd_MineroDTO)
        {
            try
            {
                return Comp_Dd_MineroAD.AnularT_Sgpad_Comp_Dd_MineroPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dd_MineroDTO> ListarPaginadoComp_Dd_MineroDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Dd_MineroAD.ListarPaginadoT_Sgpad_Comp_Dd_Minero(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Dd_MineroDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dd_MineroDTO> ListarPorIdEumComp_Dd_MineroDTO(int vId_Eum)
        {
            try
            {
                var vResultado = Comp_Dd_MineroAD.ListarPorIdEumT_Sgpad_Comp_Dd_Minero(vId_Eum);
                return new List<Comp_Dd_MineroDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
