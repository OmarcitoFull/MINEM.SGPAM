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
    public class T_Sgpad_Comp_Riesgo_Seg_HumLN : BaseLN, IT_Sgpad_Comp_Riesgo_Seg_HumLN

    {
        private readonly IT_Sgpad_Comp_Riesgo_Seg_HumAD Comp_Riesgo_Seg_HumAD;
        private readonly IT_Sgpal_AccesibilidadLN AccesibilidadLN;
        private readonly IT_Sgpal_Pot_ColapsoLN Pot_ColapsoLN;
        private readonly IT_Sgpal_Condicion_CierreLN Condicion_CierreLN;
        private readonly IT_Sgpal_Presencia_ElementoLN Presencia_ElementoLN;
        private readonly IT_Sgpal_HundimientoLN HundimientoLN;
        private readonly IT_Sgpal_Pot_Caida_PersonaLN Pot_Caida_PersonaLN;
        private readonly IT_Sgpal_Presencia_AdvertenciaLN Presencia_AdvertenciaLN;

        public T_Sgpad_Comp_Riesgo_Seg_HumLN(IT_Sgpad_Comp_Riesgo_Seg_HumAD vT_Sgpad_Comp_Riesgo_Seg_HumAD,
            IT_Sgpal_AccesibilidadLN vIT_Sgpal_AccesibilidadLN,
            IT_Sgpal_Pot_ColapsoLN vIT_Sgpal_Pot_ColapsoLN,
            IT_Sgpal_Condicion_CierreLN vIT_Sgpal_Condicion_CierreLN,
            IT_Sgpal_Presencia_ElementoLN vIT_Sgpal_Presencia_ElementoLN,
            IT_Sgpal_HundimientoLN vIT_Sgpal_HundimientoLN,
            IT_Sgpal_Pot_Caida_PersonaLN vIT_Sgpal_Pot_Caida_PersonaLN,
            IT_Sgpal_Presencia_AdvertenciaLN vIT_Sgpal_Presencia_AdvertenciaLN)
        {
            Comp_Riesgo_Seg_HumAD = vT_Sgpad_Comp_Riesgo_Seg_HumAD;
            AccesibilidadLN = vIT_Sgpal_AccesibilidadLN;
            Pot_ColapsoLN = vIT_Sgpal_Pot_ColapsoLN;
            Condicion_CierreLN = vIT_Sgpal_Condicion_CierreLN;
            Presencia_ElementoLN = vIT_Sgpal_Presencia_ElementoLN;
            HundimientoLN = vIT_Sgpal_HundimientoLN;
            Pot_Caida_PersonaLN = vIT_Sgpal_Pot_Caida_PersonaLN;
            Presencia_AdvertenciaLN = vIT_Sgpal_Presencia_AdvertenciaLN;
        }

        public IEnumerable<Comp_Riesgo_Seg_HumDTO> ListarComp_Riesgo_Seg_HumDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Riesgo_Seg_HumAD.ListarT_Sgpad_Comp_Riesgo_Seg_Hum(vIdComponente)
                                  select new Comp_Riesgo_Seg_HumDTO
                                  {
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Id_Accesibilidad = vTmp.ID_ACCESIBILIDAD,
                                      Id_Comp_Riesgo_Seg_Hum = vTmp.ID_COMP_RIESGO_SEG_HUM,
                                      Id_Hundimiento = vTmp.ID_HUNDIMIENTO,
                                      Id_Condicion_Cierre = vTmp.ID_CONDICION_CIERRE,
                                      Id_Pot_Caida_Persona = vTmp.ID_POT_CAIDA_PERSONA,
                                      Id_Pot_Colapso = vTmp.ID_POT_COLAPSO,
                                      Id_Presencia_Advertencia = vTmp.ID_PRESENCIA_ADVERTENCIA,
                                      Id_Presencia_Elemento = vTmp.ID_PRESENCIA_ELEMENTO,
                                      Accesibilidad = vTmp.ACCESIBILIDAD,
                                      Condicion_Cierre = vTmp.CONDICION_CIERRE,
                                      Hundimiento = vTmp.HUNDIMIENTO,
                                      Pot_Caida_Persona = vTmp.POT_CAIDA_PERSONA,
                                      Pot_Colapso = vTmp.POT_COLAPSO,
                                      Presencia_Advertencia = vTmp.PRESENCIA_ADVERTENCIA,
                                      Presencia_Elemento = vTmp.PRESENCIA_ELEMENTO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Riesgo_Seg_HumDTO RecuperarComp_Riesgo_Seg_HumDTOPorCodigo(int vId_Comp_Riesgo_Seg_Hum)
        {
            try
            {
                if (vId_Comp_Riesgo_Seg_Hum > 0)
                {
                    var vRegistro = Comp_Riesgo_Seg_HumAD.RecuperarT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(vId_Comp_Riesgo_Seg_Hum);
                    if (vRegistro != null)
                    {
                        var vResultado = new Comp_Riesgo_Seg_HumDTO
                        {
                            Fec_Ingreso = vRegistro.FEC_INGRESO,
                            Fec_Modifica = vRegistro.FEC_MODIFICA,
                            Flg_Estado = vRegistro.FLG_ESTADO,
                            Ip_Ingreso = vRegistro.IP_INGRESO,
                            Ip_Modifica = vRegistro.IP_MODIFICA,
                            Usu_Ingreso = vRegistro.USU_INGRESO,
                            Usu_Modifica = vRegistro.USU_MODIFICA,
                            Id_Componente = vRegistro.ID_COMPONENTE,
                            Id_Accesibilidad = vRegistro.ID_ACCESIBILIDAD,
                            Id_Comp_Riesgo_Seg_Hum = vRegistro.ID_COMP_RIESGO_SEG_HUM,
                            Id_Condicion_Cierre = vRegistro.ID_CONDICION_CIERRE,
                            Id_Hundimiento = vRegistro.ID_HUNDIMIENTO,
                            Id_Pot_Caida_Persona = vRegistro.ID_POT_CAIDA_PERSONA,
                            Id_Pot_Colapso = vRegistro.ID_POT_COLAPSO,
                            Id_Presencia_Advertencia = vRegistro.ID_PRESENCIA_ADVERTENCIA,
                            Id_Presencia_Elemento = vRegistro.ID_PRESENCIA_ELEMENTO
                        };
                        return vResultado;
                    }
                    return null;
                }
                else
                {
                    var vResultado = new Comp_Riesgo_Seg_HumDTO
                    {
                        CboAccesibilidad = AccesibilidadLN.ListarAccesibilidadDTO().ToList(),
                        CboPotenciaColapso = Pot_ColapsoLN.ListarPot_ColapsoDTO().ToList(),
                        CboCondicionCierre = Condicion_CierreLN.ListarCondicion_CierreDTO().ToList(),
                        CboPresenciaSeniales = Presencia_ElementoLN.ListarPresencia_ElementoDTO().ToList(),
                        CboHundimiento = HundimientoLN.ListarHundimientoDTO().ToList(),
                        CboPotenciaDanio = Pot_Caida_PersonaLN.ListarPot_Caida_PersonaDTO().ToList(),
                        CboPresenciaEscombros = Presencia_AdvertenciaLN.ListarPresencia_AdvertenciaDTO().ToList()
                    };
                    return vResultado;
                }
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Riesgo_Seg_HumDTO GrabarComp_Riesgo_Seg_HumDTO(Comp_Riesgo_Seg_HumDTO vComp_Riesgo_Seg_HumDTO)
        {
            try
            {
                if (vComp_Riesgo_Seg_HumDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Riesgo_Seg_Hum
                    {
                        FEC_INGRESO = vComp_Riesgo_Seg_HumDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Riesgo_Seg_HumDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Riesgo_Seg_HumDTO.Flg_Estado,
                        IP_INGRESO = vComp_Riesgo_Seg_HumDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Riesgo_Seg_HumDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Riesgo_Seg_HumDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Riesgo_Seg_HumDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Riesgo_Seg_HumDTO.Id_Componente,
                        ID_ACCESIBILIDAD = vComp_Riesgo_Seg_HumDTO.Id_Accesibilidad,
                        ID_COMP_RIESGO_SEG_HUM = vComp_Riesgo_Seg_HumDTO.Id_Comp_Riesgo_Seg_Hum,
                        ID_CONDICION_CIERRE = vComp_Riesgo_Seg_HumDTO.Id_Condicion_Cierre,
                        ID_HUNDIMIENTO = vComp_Riesgo_Seg_HumDTO.Id_Hundimiento,
                        ID_POT_CAIDA_PERSONA = vComp_Riesgo_Seg_HumDTO.Id_Pot_Caida_Persona,
                        ID_POT_COLAPSO = vComp_Riesgo_Seg_HumDTO.Id_Pot_Colapso,
                        ID_PRESENCIA_ADVERTENCIA = vComp_Riesgo_Seg_HumDTO.Id_Presencia_Advertencia,
                        ID_PRESENCIA_ELEMENTO = vComp_Riesgo_Seg_HumDTO.Id_Presencia_Elemento
                    };
                    if (vComp_Riesgo_Seg_HumDTO.Id_Comp_Riesgo_Seg_Hum == 0)
                    {
                        var vResultado = Comp_Riesgo_Seg_HumAD.InsertarT_Sgpad_Comp_Riesgo_Seg_Hum(vRegistro);
                        vComp_Riesgo_Seg_HumDTO.Id_Comp_Riesgo_Seg_Hum = vResultado.ID_COMP_RIESGO_SEG_HUM;
                    }
                    else
                    {
                        var vResultado = Comp_Riesgo_Seg_HumAD.ActualizarT_Sgpad_Comp_Riesgo_Seg_Hum(vRegistro);
                        vComp_Riesgo_Seg_HumDTO = RecuperarComp_Riesgo_Seg_HumDTOPorCodigo(vResultado.ID_COMP_RIESGO_SEG_HUM);
                    }
                }
                return vComp_Riesgo_Seg_HumDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Riesgo_Seg_HumDTOPorCodigo(Comp_Riesgo_Seg_HumDTO vComp_Riesgo_Seg_HumDTO)
        {
            try
            {
                return Comp_Riesgo_Seg_HumAD.AnularT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Riesgo_Seg_HumDTO> ListarPaginadoComp_Riesgo_Seg_HumDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Riesgo_Seg_HumAD.ListarPaginadoT_Sgpad_Comp_Riesgo_Seg_Hum(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Riesgo_Seg_HumDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
