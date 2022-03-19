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
        private readonly IT_Sgpal_Tipo_ClimaLN Tipo_ClimaLN;
        private readonly IT_Sgpal_InspectorLN InspectorLN;
        public T_Sgpad_Eum_InspeccionLN(IT_Sgpad_Eum_InspeccionAD vT_Sgpad_Eum_InspeccionAD, IT_Sgpal_Tipo_ClimaLN vIT_Sgpal_Tipo_ClimaLN, IT_Sgpal_InspectorLN vIT_Sgpal_InspectorLN)
        {
            Eum_InspeccionAD = vT_Sgpad_Eum_InspeccionAD;
            Tipo_ClimaLN = vIT_Sgpal_Tipo_ClimaLN;
            InspectorLN = vIT_Sgpal_InspectorLN;
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
                            Descripcion_Clima = item.DESCRIPCION_CLIMA,
                            Usu_Ingreso = item.USU_INGRESO,
                            Fecha_Inspeccion = item.FECHA_INSPECCION,
                            Nomnbre_Inspector = item.NOMBRE_INSPECTOR
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

        public RegistrarEumInspeccionDTO RecuperarFullEum_InspeccionDTOPorCodigo(int vId_Eum_Inspeccion)
        {
            try
            {
                RegistrarEumInspeccionDTO vResultado = new RegistrarEumInspeccionDTO
                {
                    Eum_Inspeccion = RecuperarEum_InspeccionDTOPorCodigo(vId_Eum_Inspeccion),
                    CboTipoClima = (List<Tipo_ClimaDTO>)Tipo_ClimaLN.ListarTipo_ClimaDTO(), 
                    CboInspector = (List<InspectorDTO>)InspectorLN.ListarInspectorDTO()
                };
                return vResultado;
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();

        }

        public Eum_InspeccionDTO GrabarEum_InspeccionDTO(Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            try
            {
                if (vEum_InspeccionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Inspeccion
                    {
                        FEC_INGRESO = vEum_InspeccionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vEum_InspeccionDTO.Fec_Modifica,
                        FLG_ESTADO = vEum_InspeccionDTO.Flg_Estado,
                        IP_INGRESO = vEum_InspeccionDTO.Ip_Ingreso,
                        IP_MODIFICA = vEum_InspeccionDTO.Ip_Modifica,
                        USU_INGRESO = vEum_InspeccionDTO.Usu_Ingreso,
                        USU_MODIFICA = vEum_InspeccionDTO.Usu_Modifica,
                        ID_INSPECTOR = vEum_InspeccionDTO.Id_Inspector,
                        ID_EUM = vEum_InspeccionDTO.Id_Eum,
                        ID_EUM_INSPECCION = vEum_InspeccionDTO.Id_Eum_Inspeccion,
                        ID_TIPO_CLIMA = vEum_InspeccionDTO.Id_Tipo_Clima,
                        FECHA_INSPECCION = vEum_InspeccionDTO.Fecha_Inspeccion,
                        DESCRIPCION_CLIMA = vEum_InspeccionDTO.Descripcion_Clima
                    };
                    if (vEum_InspeccionDTO.Id_Eum_Inspeccion == 0)
                    {
                        var vResultado = Eum_InspeccionAD.InsertarT_Sgpad_Eum_Inspeccion(vRegistro);
                        vEum_InspeccionDTO.Id_Eum_Inspeccion = vResultado.ID_EUM_INSPECCION;
                    }
                    else
                    {
                        var vResultado = Eum_InspeccionAD.ActualizarT_Sgpad_Eum_Inspeccion(vRegistro);
                        vEum_InspeccionDTO = RecuperarFullEum_InspeccionDTOPorCodigo(vResultado.ID_EUM_INSPECCION).Eum_Inspeccion;
                    }
                }
                return vEum_InspeccionDTO;

            }
            catch (Exception)
            {

                throw;
            }    
        }
    }
}
