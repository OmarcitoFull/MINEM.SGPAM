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
    public class T_Sgpad_Comp_ReaproLN : BaseLN, IT_Sgpad_Comp_ReaproLN
    {
        private readonly IT_Sgpad_Comp_ReaproAD Comp_ReaproAD;

        public T_Sgpad_Comp_ReaproLN(IT_Sgpad_Comp_ReaproAD vT_Sgpad_Comp_ReaproAD)
        {
            Comp_ReaproAD = vT_Sgpad_Comp_ReaproAD;
        }

        public IEnumerable<Comp_ReaproDTO> ListarComp_ReaproDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_ReaproAD.ListarT_Sgpad_Comp_Reapro(vIdComponente)
                                  select new Comp_ReaproDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fecha_Expediente = vTmp.FECHA_EXPEDIENTE,
                                      Fecha_Resolucion = vTmp.FECHA_RESOLUCION,
                                      Id_Comp_Reapro = vTmp.ID_COMP_REAPRO,
                                      Nombre_Proyecto = vTmp.NOMBRE_PROYECTO,
                                      Nro_Expediente = vTmp.NRO_EXPEDIENTE,
                                      Resolucion_Reapro = vTmp.RESOLUCION_REAPRO,
                                      Titular = vTmp.TITULAR
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ReaproDTO RecuperarComp_ReaproDTOPorCodigo(int vId_Comp_Reapro)
        {
            try
            {
                var vResultado = Comp_ReaproAD.RecuperarT_Sgpad_Comp_ReaproPorCodigo(vId_Comp_Reapro);
                return new Comp_ReaproDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ReaproDTO GrabarComp_ReaproDTO(Comp_ReaproDTO vComp_ReaproDTO)
        {
            try
            {
                if (vComp_ReaproDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Reapro
                    {
                        FEC_INGRESO = vComp_ReaproDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_ReaproDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_ReaproDTO.Flg_Estado,
                        IP_INGRESO = vComp_ReaproDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_ReaproDTO.Ip_Modifica,
                        USU_INGRESO = vComp_ReaproDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_ReaproDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_ReaproDTO.Id_Componente,
                        FECHA_EXPEDIENTE = vComp_ReaproDTO.Fecha_Expediente,
                        FECHA_RESOLUCION = vComp_ReaproDTO.Fecha_Resolucion,
                        ID_COMP_REAPRO = vComp_ReaproDTO.Id_Comp_Reapro,
                        NOMBRE_PROYECTO = vComp_ReaproDTO.Nombre_Proyecto,
                        NRO_EXPEDIENTE = vComp_ReaproDTO.Nro_Expediente,
                        RESOLUCION_REAPRO = vComp_ReaproDTO.Resolucion_Reapro,
                        TITULAR = vComp_ReaproDTO.Titular
                    };
                    if (vComp_ReaproDTO.Id_Comp_Reapro == 0)
                    {
                        var vResultado = Comp_ReaproAD.InsertarT_Sgpad_Comp_Reapro(vRegistro);
                        vComp_ReaproDTO.Id_Comp_Reapro = vResultado.ID_COMP_REAPRO;
                    }
                    else
                    {
                        var vResultado = Comp_ReaproAD.ActualizarT_Sgpad_Comp_Reapro(vRegistro);
                        vComp_ReaproDTO = RecuperarComp_ReaproDTOPorCodigo(vResultado.ID_COMP_REAPRO);
                    }
                }
                return vComp_ReaproDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_ReaproDTOPorCodigo(Comp_ReaproDTO vComp_ReaproDTO)
        {
            try
            {
                return Comp_ReaproAD.AnularT_Sgpad_Comp_ReaproPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_ReaproDTO> ListarPaginadoComp_ReaproDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_ReaproAD.ListarPaginadoT_Sgpad_Comp_Reapro(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_ReaproDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
