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
    public class T_Sgpad_Eum_UbicacionLN : BaseLN, IT_Sgpad_Eum_UbicacionLN
    {
        private readonly IT_Sgpad_Eum_UbicacionAD Eum_UbicacionAD;

        public T_Sgpad_Eum_UbicacionLN(IT_Sgpad_Eum_UbicacionAD vT_Sgpad_Eum_UbicacionAD)
        {
            Eum_UbicacionAD = vT_Sgpad_Eum_UbicacionAD;
        }

        public IEnumerable<Eum_UbicacionDTO> ListarEum_UbicacionDTO()
        {
            try
            {
                var vResultado = Eum_UbicacionAD.ListarT_Sgpad_Eum_Ubicacion();
                return new List<Eum_UbicacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_UbicacionDTO RecuperarEum_UbicacionDTOPorCodigo(int vId_Eum_Ubicacion)
        {
            try
            {
                var vResultado = Eum_UbicacionAD.RecuperarT_Sgpad_Eum_UbicacionPorCodigo(vId_Eum_Ubicacion);
                return new Eum_UbicacionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_UbicacionDTO InsertarEum_UbicacionDTO(Eum_UbicacionDTO vEum_UbicacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Ubicacion();
                var vResultado = Eum_UbicacionAD.InsertarT_Sgpad_Eum_Ubicacion(vRegistro);
                return vEum_UbicacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_UbicacionDTO ActualizarEum_UbicacionDTO(Eum_UbicacionDTO vEum_UbicacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Ubicacion();
                var vResultado = Eum_UbicacionAD.ActualizarT_Sgpad_Eum_Ubicacion(vRegistro);
                return vEum_UbicacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularEum_UbicacionDTOPorCodigo(Eum_UbicacionDTO vEum_UbicacionDTO)
        {
            try
            {
                return Eum_UbicacionAD.AnularT_Sgpad_Eum_UbicacionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_UbicacionDTO> ListarPaginadoEum_UbicacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_UbicacionAD.ListarPaginadoT_Sgpad_Eum_Ubicacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_UbicacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
