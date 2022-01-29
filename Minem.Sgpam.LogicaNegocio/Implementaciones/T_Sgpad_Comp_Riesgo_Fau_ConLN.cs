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
    public class T_Sgpad_Comp_Riesgo_Fau_ConLN : BaseLN, IT_Sgpad_Comp_Riesgo_Fau_ConLN
    {
        private readonly IT_Sgpad_Comp_Riesgo_Fau_ConAD Comp_Riesgo_Fau_ConAD;
        private readonly IT_Sgpal_Acceso_FaunaLN Acceso_FaunaLN;
        private readonly IT_Sgpal_Atraccion_FaunaLN Atraccion_FaunaLN;
        private readonly IT_Sgpal_Vegetacion_InvasivaLN Vegetacion_InvasivaLN;
        private readonly IT_Sgpal_Cerca_Area_ProtegidaLN Cerca_Area_ProtegidaLN;
        private readonly IT_Sgpal_Sensibilidad_AreaLN Sensibilidad_AreaLN;
        private readonly IT_Sgpal_Agua_ContaminadaLN Agua_ContaminadaLN;

        public T_Sgpad_Comp_Riesgo_Fau_ConLN(IT_Sgpad_Comp_Riesgo_Fau_ConAD vT_Sgpad_Comp_Riesgo_Fau_ConAD,
            IT_Sgpal_Acceso_FaunaLN vIT_Sgpal_Acceso_FaunaLN,
            IT_Sgpal_Atraccion_FaunaLN vIT_Sgpal_Atraccion_FaunaLN,
            IT_Sgpal_Vegetacion_InvasivaLN vIT_Sgpal_Vegetacion_InvasivaLN,
            IT_Sgpal_Cerca_Area_ProtegidaLN vIT_Sgpal_Cerca_Area_ProtegidaLN,
            IT_Sgpal_Sensibilidad_AreaLN vIT_Sgpal_Sensibilidad_AreaLN,
            IT_Sgpal_Agua_ContaminadaLN vIT_Sgpal_Agua_ContaminadaLN)
        {
            Comp_Riesgo_Fau_ConAD = vT_Sgpad_Comp_Riesgo_Fau_ConAD;
            Acceso_FaunaLN = vIT_Sgpal_Acceso_FaunaLN;
            Atraccion_FaunaLN = vIT_Sgpal_Atraccion_FaunaLN;
            Vegetacion_InvasivaLN = vIT_Sgpal_Vegetacion_InvasivaLN;
            Cerca_Area_ProtegidaLN = vIT_Sgpal_Cerca_Area_ProtegidaLN;
            Sensibilidad_AreaLN = vIT_Sgpal_Sensibilidad_AreaLN;
            Agua_ContaminadaLN = vIT_Sgpal_Agua_ContaminadaLN;
        }

        public IEnumerable<Comp_Riesgo_Fau_ConDTO> ListarComp_Riesgo_Fau_ConDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Riesgo_Fau_ConAD.ListarT_Sgpad_Comp_Riesgo_Fau_Con(vIdComponente)
                                  select new Comp_Riesgo_Fau_ConDTO
                                  {
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Id_Acceso_Fauna = vTmp.ID_ACCESO_FAUNA,
                                      Id_Agua_Contaminada = vTmp.ID_AGUA_CONTAMINADA,
                                      Id_Atraccion_Fauna = vTmp.ID_ATRACCION_FAUNA,
                                      Id_Cerca_Area_Protegida = vTmp.ID_CERCA_AREA_PROTEGIDA,
                                      Id_Comp_Riesgo_Fau_Con = vTmp.ID_COMP_RIESGO_FAU_CON,
                                      Id_Sensibilidad_Area = vTmp.ID_SENSIBILIDAD_AREA,
                                      Id_Vegetacion_Invasiva = vTmp.ID_VEGETACION_INVASIVA,
                                      Acceso_Fauna = vTmp.ACCESO_FAUNA,
                                      Agua_Contaminada = vTmp.AGUA_CONTAMINADA,
                                      Atraccion_Fauna = vTmp.ATRACCION_FAUNA,
                                      Cerca_Area_Protegida = vTmp.CERCA_AREA_PROTEGIDA,
                                      Sensibilidad_Area = vTmp.SENSIBILIDAD_AREA,
                                      Vegetacion_Invasiva = vTmp.VEGETACION_INVASIVA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Riesgo_Fau_ConDTO RecuperarComp_Riesgo_Fau_ConDTOPorCodigo(int vId_Comp_Riesgo_Fau_Con)
        {
            try
            {
                if (vId_Comp_Riesgo_Fau_Con > 0)
                {
                    var vRegistro = Comp_Riesgo_Fau_ConAD.RecuperarT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(vId_Comp_Riesgo_Fau_Con);
                    if (vRegistro != null)
                    {
                        var vResultado = new Comp_Riesgo_Fau_ConDTO
                        {
                            Fec_Ingreso = vRegistro.FEC_INGRESO,
                            Fec_Modifica = vRegistro.FEC_MODIFICA,
                            Flg_Estado = vRegistro.FLG_ESTADO,
                            Ip_Ingreso = vRegistro.IP_INGRESO,
                            Ip_Modifica = vRegistro.IP_MODIFICA,
                            Usu_Ingreso = vRegistro.USU_INGRESO,
                            Usu_Modifica = vRegistro.USU_MODIFICA,
                            Id_Componente = vRegistro.ID_COMPONENTE,
                            Id_Acceso_Fauna = vRegistro.ID_ACCESO_FAUNA,
                            Id_Agua_Contaminada = vRegistro.ID_AGUA_CONTAMINADA,
                            Id_Atraccion_Fauna = vRegistro.ID_ATRACCION_FAUNA,
                            Id_Cerca_Area_Protegida = vRegistro.ID_CERCA_AREA_PROTEGIDA,
                            Id_Comp_Riesgo_Fau_Con = vRegistro.ID_COMP_RIESGO_FAU_CON,
                            Id_Sensibilidad_Area = vRegistro.ID_SENSIBILIDAD_AREA,
                            Id_Vegetacion_Invasiva = vRegistro.ID_VEGETACION_INVASIVA
                        };
                        return vResultado;
                    }
                    return null;
                }
                else
                {
                    var vResultado = new Comp_Riesgo_Fau_ConDTO
                    {
                        CboAcceso_Fauna = Acceso_FaunaLN.ListarAcceso_FaunaDTO().ToList(),
                        CboAgua_Contaminada = Agua_ContaminadaLN.ListarAgua_ContaminadaDTO().ToList(),
                        CboAtraccion_Fauna = Atraccion_FaunaLN.ListarAtraccion_FaunaDTO().ToList(),
                        CboCerca_Area_Protegida = Cerca_Area_ProtegidaLN.ListarCerca_Area_ProtegidaDTO().ToList(),
                        CboSensibilidad_Area = Sensibilidad_AreaLN.ListarSensibilidad_AreaDTO().ToList(),
                        CboVegetacion_Invasiva = Vegetacion_InvasivaLN.ListarVegetacion_InvasivaDTO().ToList()
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

        public Comp_Riesgo_Fau_ConDTO GrabarComp_Riesgo_Fau_ConDTO(Comp_Riesgo_Fau_ConDTO vComp_Riesgo_Fau_ConDTO)
        {
            try
            {
                if (vComp_Riesgo_Fau_ConDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Riesgo_Fau_Con
                    {
                        FEC_INGRESO = vComp_Riesgo_Fau_ConDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Riesgo_Fau_ConDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Riesgo_Fau_ConDTO.Flg_Estado,
                        IP_INGRESO = vComp_Riesgo_Fau_ConDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Riesgo_Fau_ConDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Riesgo_Fau_ConDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Riesgo_Fau_ConDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Riesgo_Fau_ConDTO.Id_Componente,
                        ID_ACCESO_FAUNA = vComp_Riesgo_Fau_ConDTO.Id_Acceso_Fauna,
                        ID_AGUA_CONTAMINADA = vComp_Riesgo_Fau_ConDTO.Id_Agua_Contaminada,
                        ID_ATRACCION_FAUNA = vComp_Riesgo_Fau_ConDTO.Id_Atraccion_Fauna,
                        ID_CERCA_AREA_PROTEGIDA = vComp_Riesgo_Fau_ConDTO.Id_Cerca_Area_Protegida,
                        ID_COMP_RIESGO_FAU_CON = vComp_Riesgo_Fau_ConDTO.Id_Comp_Riesgo_Fau_Con,
                        ID_SENSIBILIDAD_AREA = vComp_Riesgo_Fau_ConDTO.Id_Sensibilidad_Area,
                        ID_VEGETACION_INVASIVA = vComp_Riesgo_Fau_ConDTO.Id_Vegetacion_Invasiva
                    };
                    if (vComp_Riesgo_Fau_ConDTO.Id_Comp_Riesgo_Fau_Con == 0)
                    {
                        var vResultado = Comp_Riesgo_Fau_ConAD.InsertarT_Sgpad_Comp_Riesgo_Fau_Con(vRegistro);
                        vComp_Riesgo_Fau_ConDTO.Id_Comp_Riesgo_Fau_Con = vResultado.ID_COMP_RIESGO_FAU_CON;
                    }
                    else
                    {
                        var vResultado = Comp_Riesgo_Fau_ConAD.ActualizarT_Sgpad_Comp_Riesgo_Fau_Con(vRegistro);
                        vComp_Riesgo_Fau_ConDTO = RecuperarComp_Riesgo_Fau_ConDTOPorCodigo(vResultado.ID_COMP_RIESGO_FAU_CON);
                    }
                }
                return vComp_Riesgo_Fau_ConDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Riesgo_Fau_ConDTOPorCodigo(Comp_Riesgo_Fau_ConDTO vComp_Riesgo_Fau_ConDTO)
        {
            try
            {
                return Comp_Riesgo_Fau_ConAD.AnularT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Riesgo_Fau_ConDTO> ListarPaginadoComp_Riesgo_Fau_ConDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Riesgo_Fau_ConAD.ListarPaginadoT_Sgpad_Comp_Riesgo_Fau_Con(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Riesgo_Fau_ConDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
