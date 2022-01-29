using System;
using System.Collections.Generic;
using System.Linq;
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
    public class T_Sgpad_Comp_ResultadoLN : BaseLN, IT_Sgpad_Comp_ResultadoLN
    {
        private readonly IT_Sgpad_Comp_ResultadoAD Comp_ResultadoAD;

        public T_Sgpad_Comp_ResultadoLN(IT_Sgpad_Comp_ResultadoAD vT_Sgpad_Comp_ResultadoAD)
        {
            Comp_ResultadoAD = vT_Sgpad_Comp_ResultadoAD;
        }

        public IEnumerable<Comp_ResultadoResumenDTO> ListarComp_ResultadoDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_ResultadoAD.ListarT_Sgpad_Comp_Resultado(vIdComponente)
                                  select new Comp_ResultadoResumenDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Act_Inventario = (string.IsNullOrEmpty(vTmp.ACT_INV_EUM) ? "" : vTmp.ACT_INV_EUM + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_SUB_TIPO) ? "" : vTmp.ACT_INV_SUB_TIPO + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_CUENCA) ? "" : vTmp.ACT_INV_CUENCA + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_REGION) ? "" : vTmp.ACT_INV_REGION + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_PROVINCIA) ? "" : vTmp.ACT_INV_PROVINCIA + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_DISTRITO) ? "" : vTmp.ACT_INV_DISTRITO + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_COORDENADAS) ? "" : vTmp.ACT_INV_COORDENADAS + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_GENERADOR) ? "" : vTmp.ACT_INV_GENERADOR + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_INV_RES_REMEDIA) ? "" : vTmp.ACT_INV_RES_REMEDIA + ","),

                                      Act_IGEPAM = (string.IsNullOrEmpty(vTmp.ACT_SGP_Q) ? "" : vTmp.ACT_SGP_Q + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_SGP_PH) ? "" : vTmp.ACT_SGP_PH + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_SGP_CONDICIONES) ? "" : vTmp.ACT_SGP_CONDICIONES + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_SGP_AREAS) ? "" : vTmp.ACT_SGP_AREAS + ",") +
                                                        (string.IsNullOrEmpty(vTmp.ACT_SGP_DESCRIPCION) ? "" : vTmp.ACT_SGP_DESCRIPCION + ","),

                                      Excluir = (string.IsNullOrEmpty(vTmp.EXC_NO_EXI_PAM) ? "" : vTmp.EXC_NO_EXI_PAM + ",") +
                                                        (string.IsNullOrEmpty(vTmp.EXC_AGR_PAM_ID) ? "" : vTmp.EXC_AGR_PAM_ID + ",") +
                                                        (string.IsNullOrEmpty(vTmp.EXC_PAM_INF_DUP) ? "" : vTmp.EXC_PAM_INF_DUP + ",") +
                                                        (string.IsNullOrEmpty(vTmp.EXC_NO_SIG_RIE) ? "" : vTmp.EXC_NO_SIG_RIE + ",") +
                                                        (string.IsNullOrEmpty(vTmp.EXC_OTROS) ? "" : vTmp.EXC_OTROS + ","),

                                      Incluir = vTmp.INC_INVENTARIO,
                                      Fecha = vTmp.FEC_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ResultadoDTO RecuperarComp_ResultadoDTOPorCodigo(int vId_Comp_Resultado)
        {
            try
            {
                var vRegistro = Comp_ResultadoAD.RecuperarT_Sgpad_Comp_ResultadoPorCodigo(vId_Comp_Resultado);

                if (vRegistro != null)
                {
                    var vResultado = new Comp_ResultadoDTO
                    {
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Id_Componente = vRegistro.ID_COMPONENTE,
                        Act_Inv_Coordenadas = vRegistro.ACT_INV_COORDENADAS,
                        Act_Inv_Cuenca = vRegistro.ACT_INV_CUENCA,
                        Act_Inv_Distrito = vRegistro.ACT_INV_DISTRITO,
                        Act_Inv_Eum = vRegistro.ACT_INV_EUM,
                        Act_Inv_Generador = vRegistro.ACT_INV_GENERADOR,
                        Act_Inv_Provincia = vRegistro.ACT_INV_PROVINCIA,
                        Act_Inv_Region = vRegistro.ACT_INV_REGION,
                        Act_Inv_Res_Remedia = vRegistro.ACT_INV_RES_REMEDIA,
                        Act_Inv_Sub_Tipo = vRegistro.ACT_INV_SUB_TIPO,
                        Act_Sgp_Areas = vRegistro.ACT_SGP_AREAS,
                        Act_Sgp_Condiciones = vRegistro.ACT_SGP_CONDICIONES,
                        Act_Sgp_Descripcion = vRegistro.ACT_SGP_DESCRIPCION,
                        Act_Sgp_Ph = vRegistro.ACT_SGP_PH,
                        Act_Sgp_Q = vRegistro.ACT_SGP_Q,
                        Exc_Agr_Pam_Id = vRegistro.EXC_AGR_PAM_ID,
                        Exc_No_Exi_Pam = vRegistro.EXC_NO_EXI_PAM,
                        Exc_No_Sig_Rie = vRegistro.EXC_NO_SIG_RIE,
                        Exc_Otros = vRegistro.EXC_OTROS,
                        Exc_Pam_Inf_Dup = vRegistro.EXC_PAM_INF_DUP,
                        Id_Comp_Resultado = vRegistro.ID_COMP_RESULTADO,
                        Inc_Inventario = vRegistro.INC_INVENTARIO
                    };
                    return vResultado;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ResultadoDTO GrabarComp_ResultadoDTO(Comp_ResultadoDTO vComp_ResultadoDTO)
        {
            try
            {
                if (vComp_ResultadoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Resultado
                    {
                        FEC_INGRESO = vComp_ResultadoDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_ResultadoDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_ResultadoDTO.Flg_Estado,
                        IP_INGRESO = vComp_ResultadoDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_ResultadoDTO.Ip_Modifica,
                        USU_INGRESO = vComp_ResultadoDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_ResultadoDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_ResultadoDTO.Id_Componente,
                        ACT_INV_COORDENADAS = (vComp_ResultadoDTO.Act_Inv_Coordenadas == "true" ? "1" : "0"),
                        ACT_INV_CUENCA = (vComp_ResultadoDTO.Act_Inv_Cuenca == "true" ? "1" : "0"),
                        ACT_INV_DISTRITO = (vComp_ResultadoDTO.Act_Inv_Distrito == "true" ? "1" : "0"),
                        ACT_INV_EUM = (vComp_ResultadoDTO.Act_Inv_Eum == "true" ? "1" : "0"),
                        ACT_INV_GENERADOR = (vComp_ResultadoDTO.Act_Inv_Generador == "true" ? "1" : "0"),
                        ACT_INV_PROVINCIA = (vComp_ResultadoDTO.Act_Inv_Provincia == "true" ? "1" : "0"),
                        ACT_INV_REGION = (vComp_ResultadoDTO.Act_Inv_Region == "true" ? "1" : "0"),
                        ACT_INV_RES_REMEDIA = (vComp_ResultadoDTO.Act_Inv_Res_Remedia == "true" ? "1" : "0"),
                        ACT_INV_SUB_TIPO = (vComp_ResultadoDTO.Act_Inv_Sub_Tipo == "true" ? "1" : "0"),
                        ACT_SGP_AREAS = (vComp_ResultadoDTO.Act_Sgp_Areas == "true" ? "1" : "0"),
                        ACT_SGP_CONDICIONES = (vComp_ResultadoDTO.Act_Sgp_Condiciones == "true" ? "1" : "0"),
                        ACT_SGP_DESCRIPCION = (vComp_ResultadoDTO.Act_Sgp_Descripcion == "true" ? "1" : "0"),
                        ACT_SGP_PH = (vComp_ResultadoDTO.Act_Sgp_Ph == "true" ? "1" : "0"),
                        ACT_SGP_Q = (vComp_ResultadoDTO.Act_Sgp_Q == "true" ? "1" : "0"),
                        EXC_AGR_PAM_ID = (vComp_ResultadoDTO.Exc_Agr_Pam_Id == "true" ? "1" : "0"),
                        EXC_NO_EXI_PAM = (vComp_ResultadoDTO.Exc_No_Exi_Pam == "true" ? "1" : "0"),
                        EXC_NO_SIG_RIE = (vComp_ResultadoDTO.Exc_No_Sig_Rie == "true" ? "1" : "0"),
                        EXC_OTROS = (vComp_ResultadoDTO.Exc_Otros == "true" ? "1" : "0"),
                        EXC_PAM_INF_DUP = (vComp_ResultadoDTO.Exc_Pam_Inf_Dup == "true" ? "1" : "0"),
                        ID_COMP_RESULTADO = vComp_ResultadoDTO.Id_Comp_Resultado,
                        INC_INVENTARIO = (vComp_ResultadoDTO.Inc_Inventario == "true" ? "1" : "0")
                    };
                    if (vComp_ResultadoDTO.Id_Comp_Resultado == 0)
                    {
                        var vResultado = Comp_ResultadoAD.InsertarT_Sgpad_Comp_Resultado(vRegistro);
                        vComp_ResultadoDTO.Id_Comp_Resultado = vResultado.ID_COMP_RESULTADO;
                    }
                    else
                    {
                        var vResultado = Comp_ResultadoAD.ActualizarT_Sgpad_Comp_Resultado(vRegistro);
                        vComp_ResultadoDTO = RecuperarComp_ResultadoDTOPorCodigo(vResultado.ID_COMP_RESULTADO);
                    }
                }
                return vComp_ResultadoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_ResultadoDTOPorCodigo(Comp_ResultadoDTO vComp_ResultadoDTO)
        {
            try
            {
                return Comp_ResultadoAD.AnularT_Sgpad_Comp_ResultadoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_ResultadoDTO> ListarPaginadoComp_ResultadoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_ResultadoAD.ListarPaginadoT_Sgpad_Comp_Resultado(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_ResultadoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
