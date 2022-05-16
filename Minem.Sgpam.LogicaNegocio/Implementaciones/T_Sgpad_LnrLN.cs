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
        private readonly IT_Sgpal_Tipo_LnrLN Tipo_LnrLN;
        private readonly IT_Sgpal_Sub_Tipo_LnrLN Sub_Tipo_LnrLN;
        private readonly IT_Sgpal_TemporalidadLN TemporalidadLN;

        public T_Sgpad_LnrLN
        (
            IT_Sgpad_LnrAD vT_Sgpad_LnrAD,
            IT_Sgpad_Lnr_Info_DocumentoLN vIT_Sgpad_Lnr_Info_DocumentoLN,
            IT_Sgpad_Lnr_Info_GraficaLN vIT_Sgpad_Lnr_Info_GraficaLN,
            IT_Sgpal_Tipo_LnrLN vIT_Sgpal_Tipo_LnrLN,
            IT_Sgpal_Sub_Tipo_LnrLN vIT_Sgpal_Sub_Tipo_LnrLN,
            IT_Sgpal_TemporalidadLN vIT_Sgpal_TemporalidadLN
        )
        {
            LnrAD = vT_Sgpad_LnrAD;
            Lnr_Info_DocumentoLN = vIT_Sgpad_Lnr_Info_DocumentoLN;
            Lnr_Info_GraficaLN = vIT_Sgpad_Lnr_Info_GraficaLN;
            Tipo_LnrLN = vIT_Sgpal_Tipo_LnrLN;
            Sub_Tipo_LnrLN = vIT_Sgpal_Sub_Tipo_LnrLN;
            TemporalidadLN = vIT_Sgpal_TemporalidadLN;
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
                        Eva_Afectacion = vRegistro.EVA_AFECTACION,
                        Eva_Caida = vRegistro.EVA_CAIDA,
                        Eva_Drenajes = vRegistro.EVA_DRENAJES,
                        Eva_Elemento = vRegistro.EVA_ELEMENTO,
                        Eva_Elementos = vRegistro.EVA_ELEMENTOS,
                        Eva_Evidencia = vRegistro.EVA_EVIDENCIA,
                        Eva_Generador = vRegistro.EVA_GENERADOR,
                        Eva_Labor = vRegistro.EVA_LABOR,
                        Eva_Material = vRegistro.EVA_MATERIAL,
                        Eva_Posibilidad = vRegistro.EVA_POSIBILIDAD,
                        Eva_Potencial = vRegistro.EVA_POTENCIAL,
                        Eva_Restos = vRegistro.EVA_RESTOS,
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
                        Usu_Modifica = vRegistro.USU_MODIFICA
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

        public LnrDTO InsertarLnrDTO(LnrDTO vLnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr();
                var vResultado = LnrAD.InsertarT_Sgpad_Lnr(vRegistro);
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
                var vRegistro = new T_Sgpad_Lnr();
                var vResultado = LnrAD.ActualizarT_Sgpad_Lnr(vRegistro);
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

        public IEnumerable<LnrDTO> ListarPaginadoLnrDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = LnrAD.ListarPaginadoT_Sgpad_Lnr(vFiltro, vNumPag, vCantRegxPag);
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
                //if (vId_Eum > 0)
                //{
                RegistrarLnrDTO vResultado = new RegistrarLnrDTO
                {
                    Lnr = RecuperarLnrDTOPorCodigo(vId_Lnr),
                    CboTipoLnr = (List<Tipo_LnrDTO>)Tipo_LnrLN.ListarTipo_LnrDTO(),
                    CboSubTipoLnr = (List<Sub_Tipo_LnrDTO>)Sub_Tipo_LnrLN.ListarSub_Tipo_LnrDTO(),
                    CboTemporalidad = (List<TemporalidadDTO>)TemporalidadLN.ListarTemporalidadDTO(),

                    ListaInformacionDocumento = (List<Lnr_Info_DocumentoDTO>)Lnr_Info_DocumentoLN.ListarPorIdLnrLnr_Info_DocumentoDTO(vId_Lnr),
                    ListaInformacionGrafica = (List<Lnr_Info_GraficaDTO>)Lnr_Info_GraficaLN.ListarPorIdLnrLnr_Info_GraficaDTO(vId_Lnr)
                };
                return vResultado;
                //}
                //return null;
            }
            catch (Exception)
            {

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
                            Eva_Afectacion = item.EVA_AFECTACION,
                            Eva_Caida = item.EVA_AFECTACION,
                            Eva_Drenajes = item.EVA_DRENAJES,
                            Eva_Elemento = item.EVA_ELEMENTO,
                            Eva_Elementos = item.EVA_ELEMENTOS,
                            Eva_Evidencia = item.EVA_EVIDENCIA,
                            Eva_Generador = item.EVA_GENERADOR,
                            Eva_Labor = item.EVA_LABOR,
                            Eva_Material = item.EVA_MATERIAL,
                            Eva_Posibilidad = item.EVA_POSIBILIDAD,
                            Eva_Potencial = item.EVA_POTENCIAL,
                            Eva_Restos = item.EVA_RESTOS,
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
    }
}
