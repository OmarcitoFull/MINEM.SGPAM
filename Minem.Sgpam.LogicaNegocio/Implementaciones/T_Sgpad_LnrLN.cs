using System;
using System.Linq;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using Minem.Sgpam.InfraEstructura;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class T_Sgpad_LnrLN : BaseLN, IT_Sgpad_LnrLN
    {
        private readonly IT_Sgpad_LnrAD LnrAD;
        private readonly IT_Sgpad_Lnr_Info_DocumentoLN Lnr_Info_DocumentoLN;
        private readonly IT_Sgpad_Lnr_Info_GraficaLN Lnr_Info_GraficaLN;
        private readonly IT_Sgpal_Tipo_PamLN Tipo_PamLN;
        private readonly IT_Sgpal_Sub_Tipo_PamLN Sub_Tipo_PamLN;
        //private readonly IT_Sgpal_Tipo_LnrLN Tipo_LnrLN;
        //private readonly IT_Sgpal_Sub_Tipo_LnrLN Sub_Tipo_LnrLN;
        private readonly IT_Sgpal_TemporalidadLN TemporalidadLN;
        private readonly IT_Genl_Ubigeo_IneiLN UbigeoLN;

        public T_Sgpad_LnrLN
        (
            IT_Sgpad_LnrAD vT_Sgpad_LnrAD,
            IT_Sgpad_Lnr_Info_DocumentoLN vIT_Sgpad_Lnr_Info_DocumentoLN,
            IT_Sgpad_Lnr_Info_GraficaLN vIT_Sgpad_Lnr_Info_GraficaLN,
            IT_Sgpal_Tipo_PamLN vIT_Sgpal_Tipo_PamLN,
            IT_Sgpal_Sub_Tipo_PamLN vIT_Sgpal_Sub_Tipo_PamLN,
            //IT_Sgpal_Tipo_LnrLN vIT_Sgpal_Tipo_LnrLN,
            //IT_Sgpal_Sub_Tipo_LnrLN vIT_Sgpal_Sub_Tipo_LnrLN,
            IT_Sgpal_TemporalidadLN vIT_Sgpal_TemporalidadLN,
            IT_Genl_Ubigeo_IneiLN vIT_Genl_Ubigeo_IneiLN
        )
        {
            LnrAD = vT_Sgpad_LnrAD;
            Lnr_Info_DocumentoLN = vIT_Sgpad_Lnr_Info_DocumentoLN;
            Lnr_Info_GraficaLN = vIT_Sgpad_Lnr_Info_GraficaLN;
            Tipo_PamLN = vIT_Sgpal_Tipo_PamLN;
            Sub_Tipo_PamLN = vIT_Sgpal_Sub_Tipo_PamLN;
            //Tipo_LnrLN = vIT_Sgpal_Tipo_LnrLN;
            //Sub_Tipo_LnrLN = vIT_Sgpal_Sub_Tipo_LnrLN;
            TemporalidadLN = vIT_Sgpal_TemporalidadLN;
            UbigeoLN = vIT_Genl_Ubigeo_IneiLN;
        }

        public IEnumerable<LnrDTO> ListarLnrDTO()
        {
            try
            {
                var vResultado = LnrAD.ListarT_Sgpad_Lnr();
                return new List<LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO RecuperarLnrDTOPorCodigo(int vId_Lnr)
        {
            try
            {
                var vRegistro = LnrAD.RecuperarT_Sgpad_LnrPorCodigo(vId_Lnr);
                if (vRegistro != null)
                {
                    var vResultado = new LnrDTO
                    {
                        Alto = vRegistro.ALTO,
                        Alto_Desc = vRegistro.ALTO_DESC,
                        Ancho = vRegistro.ANCHO,
                        Ancho_Desc = vRegistro.ANCHO_DESC,
                        Area = vRegistro.AREA,
                        Area_Desc = vRegistro.AREA_DESC,
                        Codigo_Declarado = vRegistro.CODIGO_DECLARADO,
                        Este = vRegistro.ESTE,
                        Eva_Afectacion = vRegistro.EVA_AFECTACION == "1" ? true : false,
                        Eva_Caida = vRegistro.EVA_CAIDA == "1" ? true : false,
                        Eva_Drenajes = vRegistro.EVA_DRENAJES == "1" ? true : false,
                        Eva_Elemento = vRegistro.EVA_ELEMENTO == "1" ? true : false,
                        Eva_Elementos = vRegistro.EVA_ELEMENTOS == "1" ? true : false,
                        Eva_Evidencia = vRegistro.EVA_EVIDENCIA == "1" ? true : false,
                        Eva_Generador = vRegistro.EVA_GENERADOR == "1" ? true : false,
                        Eva_Labor = vRegistro.EVA_LABOR == "1" ? true : false,
                        Eva_Material = vRegistro.EVA_MATERIAL == "1" ? true : false,
                        Eva_Posibilidad = vRegistro.EVA_POSIBILIDAD == "1" ? true : false,
                        Eva_Potencial = vRegistro.EVA_POTENCIAL == "1" ? true : false,
                        Eva_Restos = vRegistro.EVA_RESTOS == "1" ? true : false,
                        Fec_Registro = vRegistro.FEC_REGISTRO,
                        Id_Expediente = vRegistro.ID_EXPEDIENTE,
                        Id_Lnr = vRegistro.ID_LNR,
                        Id_Sub_Tipo_Lnr = vRegistro.ID_SUB_TIPO_LNR,
                        Id_Temporalidad = vRegistro.ID_TEMPORALIDAD,
                        Id_Tipo_Lnr = vRegistro.ID_TIPO_LNR,
                        Id_Zona = vRegistro.ID_ZONA,
                        Largo = vRegistro.LARGO,
                        Largo_Desc = vRegistro.LARGO_DESC,
                        Nom_Declarante = vRegistro.NOM_DECLARANTE,
                        Norte = vRegistro.NORTE,
                        Nro_Expediente = vRegistro.NRO_EXPEDIENTE,
                        Profundidad = vRegistro.PROFUNDIDAD,
                        Profundidad_Desc = vRegistro.PROFUNDIDAD_DESC,
                        Sub_Tipo_Declarado = vRegistro.SUB_TIPO_DECLARADO,
                        Ubigeo = vRegistro.UBIGEO,
                        Volumen = vRegistro.VOLUMEN,
                        Volumen_Desc = vRegistro.VOLUMEN_DESC,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,

                        Id_Distrito = vRegistro.UBIGEO,
                        Id_Provincia = string.IsNullOrEmpty(vRegistro.UBIGEO) ? "" : vRegistro.UBIGEO.Substring(0, 4),
                        Id_Region = string.IsNullOrEmpty(vRegistro.UBIGEO) ? "" : vRegistro.UBIGEO.Substring(0, 2)
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

        public LnrDTO GrabarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                if (vLnrDTO.Id_Lnr == 0)
                    return InsertarLnrDTO(vLnrDTO);
                else
                    return ActualizarLnrDTO(vLnrDTO);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO InsertarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr {
                    ID_LNR = vLnrDTO.Id_Lnr,
                    ID_EXPEDIENTE = vLnrDTO.Id_Expediente,
                    NRO_EXPEDIENTE = "102030",//vLnrDTO.Nro_Expediente,
                    CODIGO_DECLARADO = vLnrDTO.Codigo_Declarado,
                    ID_TIPO_LNR = vLnrDTO.Id_Tipo_Lnr,
                    ID_SUB_TIPO_LNR = vLnrDTO.Id_Sub_Tipo_Lnr,
                    SUB_TIPO_DECLARADO = vLnrDTO.Sub_Tipo_Declarado,
                    UBIGEO = vLnrDTO.Ubigeo,
                    ESTE = vLnrDTO.Este,
                    NORTE = vLnrDTO.Norte,
                    ID_ZONA = vLnrDTO.Id_Zona,
                    ANCHO = vLnrDTO.Ancho,
                    ANCHO_DESC = vLnrDTO.Ancho_Desc,
                    LARGO = vLnrDTO.Largo,
                    LARGO_DESC = vLnrDTO.Largo_Desc,
                    ALTO = vLnrDTO.Alto,
                    ALTO_DESC = vLnrDTO.Alto_Desc,
                    PROFUNDIDAD = vLnrDTO.Profundidad,
                    PROFUNDIDAD_DESC = vLnrDTO.Profundidad_Desc,
                    AREA = vLnrDTO.Area,
                    AREA_DESC = vLnrDTO.Area_Desc,
                    VOLUMEN = vLnrDTO.Volumen,
                    VOLUMEN_DESC = vLnrDTO.Volumen_Desc,
                    ID_TEMPORALIDAD = vLnrDTO.Id_Temporalidad,
                    EVA_AFECTACION = vLnrDTO.Eva_Afectacion == true ? "1" : "0",
                    EVA_CAIDA = vLnrDTO.Eva_Caida == true ? "1" : "0",
                    EVA_DRENAJES = vLnrDTO.Eva_Drenajes == true ? "1" : "0",
                    EVA_ELEMENTO = vLnrDTO.Eva_Elemento == true ? "1" : "0",
                    EVA_ELEMENTOS = vLnrDTO.Eva_Elementos == true ? "1" : "0",
                    EVA_EVIDENCIA = vLnrDTO.Eva_Evidencia == true ? "1" : "0",
                    EVA_GENERADOR = vLnrDTO.Eva_Generador == true ? "1" : "0",
                    EVA_LABOR = vLnrDTO.Eva_Labor == true ? "1" : "0",
                    EVA_MATERIAL = vLnrDTO.Eva_Material == true ? "1" : "0",
                    EVA_POSIBILIDAD = vLnrDTO.Eva_Material == true ? "1" : "0",
                    EVA_POTENCIAL = vLnrDTO.Eva_Posibilidad == true ? "1" : "0",
                    EVA_RESTOS = vLnrDTO.Eva_Restos == true ? "1" : "0",
                    FEC_REGISTRO = vLnrDTO.Fec_Registro,
                    NOM_DECLARANTE = vLnrDTO.Nom_Declarante,
                    USU_INGRESO = vLnrDTO.Usu_Ingreso,
                    FEC_INGRESO = vLnrDTO.Fec_Ingreso,
                    IP_INGRESO = vLnrDTO.Ip_Ingreso,
                    FLG_ESTADO = "1"
                };
                var vResultado = LnrAD.InsertarT_Sgpad_Lnr(vRegistro);
                vLnrDTO = RecuperarLnrDTOPorCodigo(vResultado.ID_LNR);

                return vLnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public LnrDTO ActualizarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr {
                    ID_LNR = vLnrDTO.Id_Lnr,
                    ID_EXPEDIENTE = vLnrDTO.Id_Expediente,
                    NRO_EXPEDIENTE = vLnrDTO.Nro_Expediente,
                    CODIGO_DECLARADO = vLnrDTO.Codigo_Declarado,
                    ID_TIPO_LNR = vLnrDTO.Id_Tipo_Lnr,
                    ID_SUB_TIPO_LNR = vLnrDTO.Id_Sub_Tipo_Lnr,
                    SUB_TIPO_DECLARADO = vLnrDTO.Sub_Tipo_Declarado,
                    UBIGEO = vLnrDTO.Ubigeo,
                    ESTE = vLnrDTO.Este,
                    NORTE = vLnrDTO.Norte,
                    ID_ZONA = vLnrDTO.Id_Zona,
                    ANCHO = vLnrDTO.Ancho,
                    ANCHO_DESC = vLnrDTO.Ancho_Desc,
                    LARGO = vLnrDTO.Largo,
                    LARGO_DESC = vLnrDTO.Largo_Desc,
                    ALTO = vLnrDTO.Alto,
                    ALTO_DESC = vLnrDTO.Alto_Desc,
                    PROFUNDIDAD = vLnrDTO.Profundidad,
                    PROFUNDIDAD_DESC = vLnrDTO.Profundidad_Desc,
                    AREA = vLnrDTO.Area,
                    AREA_DESC = vLnrDTO.Area_Desc,
                    VOLUMEN = vLnrDTO.Volumen,
                    VOLUMEN_DESC = vLnrDTO.Volumen_Desc,
                    ID_TEMPORALIDAD = vLnrDTO.Id_Temporalidad,
                    EVA_AFECTACION = vLnrDTO.Eva_Afectacion == true ? "1" : "0",
                    EVA_CAIDA = vLnrDTO.Eva_Caida == true ? "1" : "0",
                    EVA_DRENAJES = vLnrDTO.Eva_Drenajes == true ? "1" : "0",
                    EVA_ELEMENTO = vLnrDTO.Eva_Elemento == true ? "1" : "0",
                    EVA_ELEMENTOS = vLnrDTO.Eva_Elementos == true ? "1" : "0",
                    EVA_EVIDENCIA = vLnrDTO.Eva_Evidencia == true ? "1" : "0",
                    EVA_GENERADOR = vLnrDTO.Eva_Generador == true ? "1" : "0",
                    EVA_LABOR = vLnrDTO.Eva_Labor == true ? "1" : "0",
                    EVA_MATERIAL = vLnrDTO.Eva_Material == true ? "1" : "0",
                    EVA_POSIBILIDAD = vLnrDTO.Eva_Material == true ? "1" : "0",
                    EVA_POTENCIAL = vLnrDTO.Eva_Posibilidad == true ? "1" : "0",
                    EVA_RESTOS = vLnrDTO.Eva_Restos == true ? "1" : "0",
                    FEC_REGISTRO = vLnrDTO.Fec_Registro,
                    NOM_DECLARANTE = vLnrDTO.Nom_Declarante,
                    USU_MODIFICA = vLnrDTO.Usu_Modifica,
                    FEC_MODIFICA = vLnrDTO.Fec_Modifica,
                    IP_MODIFICA = vLnrDTO.Ip_Modifica
                };
                var vResultado = LnrAD.ActualizarT_Sgpad_Lnr(vRegistro);
                vLnrDTO = RecuperarLnrDTOPorCodigo(vResultado.ID_LNR);

                return vLnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularLnrDTOPorCodigo(LnrDTO vLnrDTO)
        {
            try
            {
                return LnrAD.AnularT_Sgpad_LnrPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<LnrDTO> ListarPaginadoLnrDTO(int vIdExpediente, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = LnrAD.ListarPaginadoT_Sgpad_Lnr(vIdExpediente, vNumPag, vCantRegxPag);
                return new List<LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegistrarLnrDTO RecuperarFullLnrDTOPorCodigo(int vId_Lnr)
        {
            try
            {
                RegistrarLnrDTO vResultado = new RegistrarLnrDTO
                {
                    Lnr = RecuperarLnrDTOPorCodigo(vId_Lnr),
                    CboTipo = (List<Tipo_PamDTO>)Tipo_PamLN.ListarTipo_PamDTO(),
                    CboSubTipo = (List<Sub_Tipo_PamDTO>)Sub_Tipo_PamLN.ListarSub_Tipo_PamDTO(),
                    CboTemporalidad = (List<TemporalidadDTO>)TemporalidadLN.ListarTemporalidadDTO(),
                    CboUbigeo = UbigeoLN.ListarUbigeoDTO().ToList(),

                    ListaInformacionDocumento = (List<Lnr_Info_DocumentoDTO>)Lnr_Info_DocumentoLN.ListarPorIdLnrLnr_Info_DocumentoDTO(vId_Lnr),
                    ListaInformacionGrafica = (List<Lnr_Info_GraficaDTO>)Lnr_Info_GraficaLN.ListarPorIdLnrLnr_Info_GraficaDTO(vId_Lnr)
                };
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<LnrDTO> ListarPorIdExpedienteLnrDTO(int vId_Expediente)
        {
            try
            {
                IEnumerable<T_Sgpad_Lnr> vResultado = LnrAD.ListarPorIdExpedienteT_Sgpad_Lnr(vId_Expediente);
                if (vResultado != null)
                {
                    List<LnrDTO> vLista = new List<LnrDTO>();
                    LnrDTO vEntidad;
                    foreach (T_Sgpad_Lnr item in vResultado)
                    {
                        vEntidad = new LnrDTO()
                        {
                            Alto = item.ALTO,
                            Alto_Desc = item.ALTO_DESC,
                            Ancho = item.ANCHO,
                            Ancho_Desc = item.ANCHO_DESC,
                            Area = item.AREA,
                            Area_Desc = item.AREA_DESC,
                            Codigo_Declarado = item.CODIGO_DECLARADO,
                            Este = item.ESTE,
                            Eva_Afectacion = item.EVA_AFECTACION == "1" ? false : true,
                            Eva_Caida = item.EVA_CAIDA == "1" ? false : true,
                            Eva_Drenajes = item.EVA_DRENAJES == "1" ? false : true,
                            Eva_Elemento = item.EVA_ELEMENTO == "1" ? false : true,
                            Eva_Elementos = item.EVA_ELEMENTOS == "1" ? false : true,
                            Eva_Evidencia = item.EVA_EVIDENCIA == "1" ? false : true,
                            Eva_Generador = item.EVA_GENERADOR == "1" ? false : true,
                            Eva_Labor = item.EVA_LABOR == "1" ? false : true,
                            Eva_Material = item.EVA_MATERIAL == "1" ? false : true,
                            Eva_Posibilidad = item.EVA_POSIBILIDAD == "1" ? false : true,
                            Eva_Potencial = item.EVA_POTENCIAL == "1" ? false : true,
                            Eva_Restos = item.EVA_RESTOS == "1" ? false : true,
                            Fec_Registro = item.FEC_REGISTRO,
                            Id_Expediente = item.ID_EXPEDIENTE,
                            Id_Lnr = item.ID_LNR,
                            Id_Sub_Tipo_Lnr = item.ID_SUB_TIPO_LNR,
                            Id_Temporalidad = item.ID_TEMPORALIDAD,
                            Id_Tipo_Lnr = item.ID_TIPO_LNR,
                            Id_Zona = item.ID_ZONA,
                            Largo = item.LARGO,
                            Largo_Desc = item.LARGO_DESC,
                            Nom_Declarante = item.NOM_DECLARANTE,
                            Nro_Expediente = item.NRO_EXPEDIENTE,
                            Norte = item.NORTE,
                            Profundidad = item.PROFUNDIDAD,
                            Profundidad_Desc = item.PROFUNDIDAD_DESC,
                            Sub_Tipo_Declarado = item.SUB_TIPO_DECLARADO,
                            Ubigeo = item.UBIGEO,
                            Volumen = item.VOLUMEN,
                            Volumen_Desc = item.VOLUMEN_DESC,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Des_Tipo_Lnr = item.DES_TIPO_LNR
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

        public RegistrarEvaluacionLnrDTO RecuperarFullEvaluarLnrDTOPorCodigo(int vId_Lnr)
        {
            try
            {
                RegistrarEvaluacionLnrDTO vResultado = new RegistrarEvaluacionLnrDTO
                {
                    Lnr = RecuperarLnrDTOPorCodigo(vId_Lnr),
                    //CboUbigeo = UbigeoLN.ListarUbigeoDTO().ToList(),
                    //ListaInformacionGrafica = (List<Lnr_Info_GraficaDTO>)Lnr_Info_GraficaLN.ListarPorIdLnrLnr_Info_GraficaDTO(vId_Lnr)
                    listaConcesiones = new List<Visita_DetDTO>(),
                    listaEvaluacionInventario = new List<Visita_DetDTO>(),
                    listaEvaluacionPCPAM = new List<Visita_DetDTO>(),
                    ListaReinfoDerechosMineros = new List<ReinfoDerechosMinerosDTO>()
                };
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

    }
}
