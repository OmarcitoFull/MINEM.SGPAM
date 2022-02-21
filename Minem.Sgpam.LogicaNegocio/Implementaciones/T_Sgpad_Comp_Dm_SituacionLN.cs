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
    public class T_Sgpad_Comp_Dm_SituacionLN : BaseLN, IT_Sgpad_Comp_Dm_SituacionLN
    {
        private readonly IT_Sgpad_Comp_Dm_SituacionAD Comp_Dm_SituacionAD;

        public T_Sgpad_Comp_Dm_SituacionLN(IT_Sgpad_Comp_Dm_SituacionAD vT_Sgpad_Comp_Dm_SituacionAD)
        {
            Comp_Dm_SituacionAD = vT_Sgpad_Comp_Dm_SituacionAD;
        }

        public IEnumerable<Comp_Dm_SituacionDTO> ListarComp_Dm_SituacionDTO()
        {
            try
            {
                var vResultado = Comp_Dm_SituacionAD.ListarT_Sgpad_Comp_Dm_Situacion();
                return new List<Comp_Dm_SituacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_SituacionDTO RecuperarComp_Dm_SituacionDTOPorCodigo(int vId_Comp_Dm_Situacion)
        {
            try
            {
                var vResultado = Comp_Dm_SituacionAD.RecuperarT_Sgpad_Comp_Dm_SituacionPorCodigo(vId_Comp_Dm_Situacion);
                return new Comp_Dm_SituacionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_SituacionDTO InsertarComp_Dm_SituacionDTO(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dm_Situacion();
                var vResultado = Comp_Dm_SituacionAD.InsertarT_Sgpad_Comp_Dm_Situacion(vRegistro);
                return vComp_Dm_SituacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Dm_SituacionDTO ActualizarComp_Dm_SituacionDTO(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Dm_Situacion();
                var vResultado = Comp_Dm_SituacionAD.ActualizarT_Sgpad_Comp_Dm_Situacion(vRegistro);
                return vComp_Dm_SituacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularComp_Dm_SituacionDTOPorCodigo(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO)
        {
            try
            {
                return Comp_Dm_SituacionAD.AnularT_Sgpad_Comp_Dm_SituacionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dm_SituacionDTO> ListarPaginadoComp_Dm_SituacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Dm_SituacionAD.ListarPaginadoT_Sgpad_Comp_Dm_Situacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Dm_SituacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Dm_SituacionDTO> ListarPorIdEumComp_Dm_Situacion(int vId_Eum)
        {
            try
            {
                var vResultado = Comp_Dm_SituacionAD.ListarPorIdEumT_Sgpad_Comp_Dm_Situacion(vId_Eum);
                return new List<Comp_Dm_SituacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
