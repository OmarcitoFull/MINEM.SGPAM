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
    public class T_Sgpad_Comp_Reinfo_DmLN : BaseLN, IT_Sgpad_Comp_Reinfo_DmLN
    {
        private readonly IT_Sgpad_Comp_Reinfo_DmAD Comp_Reinfo_DmAD;

        public T_Sgpad_Comp_Reinfo_DmLN(IT_Sgpad_Comp_Reinfo_DmAD vT_Sgpad_Comp_Reinfo_DmAD)
        {
            Comp_Reinfo_DmAD = vT_Sgpad_Comp_Reinfo_DmAD;
        }

        public IEnumerable<Comp_Reinfo_DmDTO> ListarComp_Reinfo_DmDTO()
        {
            try
            {
                var vResultado = Comp_Reinfo_DmAD.ListarT_Sgpad_Comp_Reinfo_Dm();
                return new List<Comp_Reinfo_DmDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Reinfo_DmDTO RecuperarComp_Reinfo_DmDTOPorCodigo(int vId_Comp_Reinfo_Dm)
        {
            try
            {
                var vResultado = Comp_Reinfo_DmAD.RecuperarT_Sgpad_Comp_Reinfo_DmPorCodigo(vId_Comp_Reinfo_Dm);
                return new Comp_Reinfo_DmDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Reinfo_DmDTO InsertarComp_Reinfo_DmDTO(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Reinfo_Dm();
                var vResultado = Comp_Reinfo_DmAD.InsertarT_Sgpad_Comp_Reinfo_Dm(vRegistro);
                return vComp_Reinfo_DmDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Reinfo_DmDTO ActualizarComp_Reinfo_DmDTO(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Reinfo_Dm();
                var vResultado = Comp_Reinfo_DmAD.ActualizarT_Sgpad_Comp_Reinfo_Dm(vRegistro);
                return vComp_Reinfo_DmDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularComp_Reinfo_DmDTOPorCodigo(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO)
        {
            try
            {
                return Comp_Reinfo_DmAD.AnularT_Sgpad_Comp_Reinfo_DmPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Reinfo_DmDTO> ListarPaginadoComp_Reinfo_DmDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Reinfo_DmAD.ListarPaginadoT_Sgpad_Comp_Reinfo_Dm(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Reinfo_DmDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
