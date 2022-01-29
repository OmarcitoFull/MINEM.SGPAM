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
    public class T_Sgpad_Comp_Riesgo_Sal_AmbLN : BaseLN, IT_Sgpad_Comp_Riesgo_Sal_AmbLN
    {
        private readonly IT_Sgpad_Comp_Riesgo_Sal_AmbAD Comp_Riesgo_Sal_AmbAD;
        private readonly IT_Sgpal_Evidencia_ErosionLN Evidencia_ErosionLN;
        private readonly IT_Sgpal_Evidencia_InundacionLN Evidencia_InundacionLN;
        private readonly IT_Sgpal_Potencial_ArdLN Potencial_ArdLN;
        private readonly IT_Sgpal_Evidencia_Sus_ToxicaLN Evidencia_Sus_ToxicaLN;

        public T_Sgpad_Comp_Riesgo_Sal_AmbLN(IT_Sgpad_Comp_Riesgo_Sal_AmbAD vT_Sgpad_Comp_Riesgo_Sal_AmbAD,
            IT_Sgpal_Evidencia_ErosionLN vIT_Sgpal_Evidencia_ErosionLN,
            IT_Sgpal_Evidencia_InundacionLN vIT_Sgpal_Evidencia_InundacionLN,
            IT_Sgpal_Potencial_ArdLN vIT_Sgpal_Potencial_ArdLN,
            IT_Sgpal_Evidencia_Sus_ToxicaLN vIT_Sgpal_Evidencia_Sus_ToxicaLN)
        {
            Comp_Riesgo_Sal_AmbAD = vT_Sgpad_Comp_Riesgo_Sal_AmbAD;
            Evidencia_ErosionLN = vIT_Sgpal_Evidencia_ErosionLN;
            Evidencia_InundacionLN = vIT_Sgpal_Evidencia_InundacionLN;
            Potencial_ArdLN = vIT_Sgpal_Potencial_ArdLN;
            Evidencia_Sus_ToxicaLN = vIT_Sgpal_Evidencia_Sus_ToxicaLN;
        }

        public IEnumerable<Comp_Riesgo_Sal_AmbDTO> ListarComp_Riesgo_Sal_AmbDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Riesgo_Sal_AmbAD.ListarT_Sgpad_Comp_Riesgo_Sal_Amb(vIdComponente)
                                  select new Comp_Riesgo_Sal_AmbDTO
                                  {
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Evidencia_Erosion = vTmp.EVIDENCIA_EROSION,
                                      Evidencia_Inundacion = vTmp.EVIDENCIA_INUNDACION,
                                      Evidencia_Sus_Toxica = vTmp.EVIDENCIA_SUS_TOXICA,
                                      Id_Comp_Riesgo_Sal_Amb = vTmp.ID_COMP_RIESGO_SAL_AMB,
                                      Id_Evidencia_Erosion = vTmp.ID_EVIDENCIA_EROSION,
                                      Id_Evidencia_Inundacion = vTmp.ID_EVIDENCIA_INUNDACION,
                                      Id_Evidencia_Sus_Toxica = vTmp.ID_EVIDENCIA_SUS_TOXICA,
                                      Id_Potencial_Ard = vTmp.ID_POTENCIAL_ARD,
                                      Potencial_Ard = vTmp.POTENCIAL_ARD
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Riesgo_Sal_AmbDTO RecuperarComp_Riesgo_Sal_AmbDTOPorCodigo(int vId_Comp_Riesgo_Sal_Amb)
        {
            try
            {
                if (vId_Comp_Riesgo_Sal_Amb > 0)
                {
                    var vRegistro = Comp_Riesgo_Sal_AmbAD.RecuperarT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(vId_Comp_Riesgo_Sal_Amb);
                    if (vRegistro != null)
                    {
                        var vResultado = new Comp_Riesgo_Sal_AmbDTO
                        {
                            Fec_Ingreso = vRegistro.FEC_INGRESO,
                            Fec_Modifica = vRegistro.FEC_MODIFICA,
                            Flg_Estado = vRegistro.FLG_ESTADO,
                            Ip_Ingreso = vRegistro.IP_INGRESO,
                            Ip_Modifica = vRegistro.IP_MODIFICA,
                            Usu_Ingreso = vRegistro.USU_INGRESO,
                            Usu_Modifica = vRegistro.USU_MODIFICA,
                            Id_Componente = vRegistro.ID_COMPONENTE,
                            Id_Comp_Riesgo_Sal_Amb = vRegistro.ID_COMP_RIESGO_SAL_AMB,
                            Id_Evidencia_Erosion = vRegistro.ID_EVIDENCIA_EROSION,
                            Id_Evidencia_Inundacion = vRegistro.ID_EVIDENCIA_INUNDACION,
                            Id_Evidencia_Sus_Toxica = vRegistro.ID_EVIDENCIA_SUS_TOXICA,
                            Id_Potencial_Ard = vRegistro.ID_POTENCIAL_ARD
                        };
                        return vResultado;
                    }
                    return null;
                }
                else
                {
                    var vResultado = new Comp_Riesgo_Sal_AmbDTO
                    {
                        CboEvidencia_Erosion = Evidencia_ErosionLN.ListarEvidencia_ErosionDTO().ToList(),
                        CboEvidencia_Inundacion = Evidencia_InundacionLN.ListarEvidencia_InundacionDTO().ToList(),
                        CboPotencial_Ard = Potencial_ArdLN.ListarPotencial_ArdDTO().ToList(),
                        CboEvidencia_Sus_Toxica = Evidencia_Sus_ToxicaLN.ListarEvidencia_Sus_ToxicaDTO().ToList()
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

        public Comp_Riesgo_Sal_AmbDTO GrabarComp_Riesgo_Sal_AmbDTO(Comp_Riesgo_Sal_AmbDTO vComp_Riesgo_Sal_AmbDTO)
        {
            try
            {
                if (vComp_Riesgo_Sal_AmbDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Riesgo_Sal_Amb
                    {
                        FEC_INGRESO = vComp_Riesgo_Sal_AmbDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Riesgo_Sal_AmbDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Riesgo_Sal_AmbDTO.Flg_Estado,
                        IP_INGRESO = vComp_Riesgo_Sal_AmbDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Riesgo_Sal_AmbDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Riesgo_Sal_AmbDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Riesgo_Sal_AmbDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Riesgo_Sal_AmbDTO.Id_Componente,
                        ID_COMP_RIESGO_SAL_AMB = vComp_Riesgo_Sal_AmbDTO.Id_Comp_Riesgo_Sal_Amb,
                        ID_EVIDENCIA_EROSION = vComp_Riesgo_Sal_AmbDTO.Id_Evidencia_Erosion,
                        ID_EVIDENCIA_INUNDACION = vComp_Riesgo_Sal_AmbDTO.Id_Evidencia_Inundacion,
                        ID_EVIDENCIA_SUS_TOXICA = vComp_Riesgo_Sal_AmbDTO.Id_Evidencia_Sus_Toxica,
                        ID_POTENCIAL_ARD = vComp_Riesgo_Sal_AmbDTO.Id_Potencial_Ard
                    };
                    if (vComp_Riesgo_Sal_AmbDTO.Id_Comp_Riesgo_Sal_Amb == 0)
                    {
                        var vResultado = Comp_Riesgo_Sal_AmbAD.InsertarT_Sgpad_Comp_Riesgo_Sal_Amb(vRegistro);
                        vComp_Riesgo_Sal_AmbDTO.Id_Comp_Riesgo_Sal_Amb = vResultado.ID_COMP_RIESGO_SAL_AMB;
                    }
                    else
                    {
                        var vResultado = Comp_Riesgo_Sal_AmbAD.ActualizarT_Sgpad_Comp_Riesgo_Sal_Amb(vRegistro);
                        vComp_Riesgo_Sal_AmbDTO = RecuperarComp_Riesgo_Sal_AmbDTOPorCodigo(vResultado.ID_COMP_RIESGO_SAL_AMB);
                    }
                }
                return vComp_Riesgo_Sal_AmbDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Riesgo_Sal_AmbDTOPorCodigo(Comp_Riesgo_Sal_AmbDTO vComp_Riesgo_Sal_AmbDTO)
        {
            try
            {
                return Comp_Riesgo_Sal_AmbAD.AnularT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Riesgo_Sal_AmbDTO> ListarPaginadoComp_Riesgo_Sal_AmbDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Riesgo_Sal_AmbAD.ListarPaginadoT_Sgpad_Comp_Riesgo_Sal_Amb(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Riesgo_Sal_AmbDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
