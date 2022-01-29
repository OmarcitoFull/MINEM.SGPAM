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
    public class T_Sgpad_Eum_InspeccionLN : BaseLN, IT_Sgpad_Eum_InspeccionLN
    {
        private readonly IT_Sgpad_Eum_InspeccionAD Eum_InspeccionAD;

        public T_Sgpad_Eum_InspeccionLN(IT_Sgpad_Eum_InspeccionAD vT_Sgpad_Eum_InspeccionAD)
        {
            Eum_InspeccionAD = vT_Sgpad_Eum_InspeccionAD;
        }

        public IEnumerable<Eum_InspeccionDTO> ListarEum_InspeccionDTO()
        {
            try
            {
                var vResultado = Eum_InspeccionAD.ListarT_Sgpad_Eum_Inspeccion();
                return new List<Eum_InspeccionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InspeccionDTO RecuperarEum_InspeccionDTOPorCodigo(int vId_Eum_Inspeccion)
        {
            try
            {
                var vResultado = Eum_InspeccionAD.RecuperarT_Sgpad_Eum_InspeccionPorCodigo(vId_Eum_Inspeccion);
                return new Eum_InspeccionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InspeccionDTO InsertarEum_InspeccionDTO(Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Inspeccion();
                var vResultado = Eum_InspeccionAD.InsertarT_Sgpad_Eum_Inspeccion(vRegistro);
                return vEum_InspeccionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InspeccionDTO ActualizarEum_InspeccionDTO(Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Inspeccion();
                var vResultado = Eum_InspeccionAD.ActualizarT_Sgpad_Eum_Inspeccion(vRegistro);
                return vEum_InspeccionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularEum_InspeccionDTOPorCodigo(Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            try
            {
                return Eum_InspeccionAD.AnularT_Sgpad_Eum_InspeccionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_InspeccionDTO> ListarPaginadoEum_InspeccionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_InspeccionAD.ListarPaginadoT_Sgpad_Eum_Inspeccion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_InspeccionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_InspeccionDTO> ListarPorIdEumEum_InspeccionDTO(int vId_Eum)
        {
            try
            {
                IEnumerable<T_Sgpad_Eum_Inspeccion> vResultado = Eum_InspeccionAD.ListarPorIdEumT_Sgpad_Eum_Inspeccion(vId_Eum);
                if (vResultado != null)
                {
                    List<Eum_InspeccionDTO> vLista = new List<Eum_InspeccionDTO>();
                    Eum_InspeccionDTO vEntidad;
                    foreach (T_Sgpad_Eum_Inspeccion item in vResultado)
                    {
                        vEntidad = new Eum_InspeccionDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Eum = item.ID_EUM,
                            Id_Eum_Inspeccion = item.ID_EUM_INSPECCION,
                            Ip_Ingreso = item.IP_INGRESO,
                            Id_Inspector = item.ID_INSPECTOR,
                            Id_Tipo_Clima = item.ID_TIPO_CLIMA,
                            Usu_Ingreso = item.USU_INGRESO,
                            Fecha_Inspeccion = item.FECHA_INSPECCION
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

    }
}
