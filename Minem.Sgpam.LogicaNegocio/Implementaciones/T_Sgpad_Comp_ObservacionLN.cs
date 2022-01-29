using System;
using System.Linq;
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
    public class T_Sgpad_Comp_ObservacionLN : BaseLN, IT_Sgpad_Comp_ObservacionLN
    {
        private readonly IT_Sgpad_Comp_ObservacionAD Comp_ObservacionAD;

        public T_Sgpad_Comp_ObservacionLN(IT_Sgpad_Comp_ObservacionAD vT_Sgpad_Comp_ObservacionAD)
        {
            Comp_ObservacionAD = vT_Sgpad_Comp_ObservacionAD;
        }

        public IEnumerable<Comp_ObservacionDTO> ListarComp_ObservacionDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_ObservacionAD.ListarT_Sgpad_Comp_Observacion(vIdComponente)
                                  select new Comp_ObservacionDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Descripcion_Comp = vTmp.DESCRIPCION_COMP,
                                      Fecha = vTmp.FECHA,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Comp_Observacion = vTmp.ID_COMP_OBSERVACION,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Obras_Rehabilitacion = vTmp.OBRAS_REHABILITACION,
                                      Suelos_Disturbados = vTmp.SUELOS_DISTURBADOS,
                                      Usu_Modifica = vTmp.USU_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ObservacionDTO RecuperarComp_ObservacionDTOPorCodigo(int vId_Comp_Observacion)
        {
            try
            {
                var vResultado = Comp_ObservacionAD.RecuperarT_Sgpad_Comp_ObservacionPorCodigo(vId_Comp_Observacion);
                return new Comp_ObservacionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ObservacionDTO GrabarComp_ObservacionDTO(Comp_ObservacionDTO vComp_ObservacionDTO)
        {
            try
            {
                if (vComp_ObservacionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Observacion
                    {
                        FEC_INGRESO = vComp_ObservacionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_ObservacionDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_ObservacionDTO.Flg_Estado,
                        IP_INGRESO = vComp_ObservacionDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_ObservacionDTO.Ip_Modifica,
                        USU_INGRESO = vComp_ObservacionDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_ObservacionDTO.Usu_Modifica,
                        FECHA = vComp_ObservacionDTO.Fecha,
                        ID_COMPONENTE = vComp_ObservacionDTO.Id_Componente,
                        DESCRIPCION_COMP = vComp_ObservacionDTO.Descripcion_Comp,
                        ID_COMP_OBSERVACION = vComp_ObservacionDTO.Id_Comp_Observacion,
                        OBRAS_REHABILITACION = vComp_ObservacionDTO.Obras_Rehabilitacion,
                        SUELOS_DISTURBADOS = vComp_ObservacionDTO.Suelos_Disturbados
                    };
                    if (vComp_ObservacionDTO.Id_Comp_Observacion == 0)
                    {
                        var vResultado = Comp_ObservacionAD.InsertarT_Sgpad_Comp_Observacion(vRegistro);
                        vComp_ObservacionDTO.Id_Comp_Observacion = vResultado.ID_COMP_OBSERVACION;
                    }
                    else
                    {
                        var vResultado = Comp_ObservacionAD.ActualizarT_Sgpad_Comp_Observacion(vRegistro);
                        vComp_ObservacionDTO = RecuperarComp_ObservacionDTOPorCodigo(vResultado.ID_COMP_OBSERVACION);
                    }
                }
                return vComp_ObservacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_ObservacionDTOPorCodigo(Comp_ObservacionDTO vComp_ObservacionDTO)
        {
            try
            {
                return Comp_ObservacionAD.AnularT_Sgpad_Comp_ObservacionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_ObservacionDTO> ListarPaginadoComp_ObservacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_ObservacionAD.ListarPaginadoT_Sgpad_Comp_Observacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_ObservacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
