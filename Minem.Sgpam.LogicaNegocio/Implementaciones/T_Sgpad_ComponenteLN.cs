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
    public class T_Sgpad_ComponenteLN : BaseLN, IT_Sgpad_ComponenteLN
    {
        private readonly IT_Sgpad_ComponenteAD ComponenteAD;
        private readonly IT_Sgpal_Tipo_PamLN Tipo_PamLN;
        private readonly IT_Sgpal_Sub_Tipo_PamLN Sub_Tipo_PamLN;
        private readonly IT_Sgpah_Componente_ModLN Componente_ModLN;
        private readonly IT_Sgpad_Comp_ObservacionLN ObservacionLN;
        //private readonly IT_Sgpal_RegionLN RegionLN;
        //private readonly IT_Sgpal_ProvinciaLN ProvinciaLN;
        //private readonly IT_Sgpal_DistritoLN DistritoLN;
        private readonly IT_Genl_Ubigeo_IneiLN UbigeoLN; 

        private readonly IT_Sgpad_Comp_MedicionLN Comp_MedicionLN;
        private readonly IT_Sgpad_Comp_Info_GraficaLN Comp_Info_GraficaLN;
        private readonly IT_Sgpad_Comp_ComentarioLN Comp_ComentarioLN;
        private readonly IT_Sgpad_Comp_Enc_RemLN Comp_Enc_RemLN;
        private readonly IT_Sgpad_Comp_ReaproLN Comp_ReaproLN;
        private readonly IT_Sgpad_Comp_Info_CampoLN Comp_Info_CampoLN;
        private readonly IT_Sgpad_Comp_ReconocimientoLN Comp_ReconocimientoLN;
        private readonly IV_ExternosLN ExternosLN;
        private readonly IT_Sgpad_Comp_Est_GestionLN Est_GestionLN;
        private readonly IT_Sgpad_Comp_Riesgo_Seg_HumLN Riesgo_Seg_HumLN;
        private readonly IT_Sgpad_Comp_Riesgo_Sal_AmbLN Riesgo_Sal_AmbLN;
        private readonly IT_Sgpad_Comp_Riesgo_Fau_ConLN Riesgo_Fau_ConLN;
        private readonly IT_Sgpad_Comp_ResultadoLN ResultadoLN;
        private readonly IT_Sgpad_Comp_Est_AmbLN Comp_Est_AmbLN;
        private readonly IT_Sgpal_Tamano_ParticulaLN Tamano_ParticulaLN;
        private readonly IT_Sgpal_HumedadLN HumedadLN;
        private readonly IT_Sgpal_Tipo_ConcesionLN Tipo_ConcesionLN;
        private readonly IT_Sgpal_CoberturaLN CoberturaLN;

        public T_Sgpad_ComponenteLN(
            IT_Sgpad_ComponenteAD vT_Sgpad_ComponenteAD,
            IT_Sgpal_Tipo_PamLN vIT_Sgpal_Tipo_PamLN,
            IT_Sgpal_Sub_Tipo_PamLN vIT_Sgpal_Sub_Tipo_PamLN,
            IT_Sgpah_Componente_ModLN vIT_Sgpah_Componente_ModLN,
            IT_Sgpad_Comp_ObservacionLN vIT_Sgpad_Comp_ObservacionLN,
            //IT_Sgpal_RegionLN vIT_Sgpal_RegionLN,
            //IT_Sgpal_ProvinciaLN vIT_Sgpal_ProvinciaLN,
            //IT_Sgpal_DistritoLN vIT_Sgpal_DistritoLN,
            IT_Genl_Ubigeo_IneiLN vIT_Genl_Ubigeo_IneiLN,
            IT_Sgpad_Comp_MedicionLN vIT_Sgpad_Comp_MedicionLN,
            IT_Sgpad_Comp_Info_GraficaLN vIT_Sgpad_Comp_Info_GraficaLN,
            IT_Sgpad_Comp_ComentarioLN vIT_Sgpad_Comp_ComentarioLN,
            IT_Sgpad_Comp_Enc_RemLN vIT_Sgpad_Comp_Enc_RemLN,
            IT_Sgpad_Comp_ReaproLN vIT_Sgpad_Comp_ReaproLN,
            IT_Sgpad_Comp_Info_CampoLN vIT_Sgpad_Comp_Info_CampoLN,
            IT_Sgpad_Comp_ReconocimientoLN vIT_Sgpad_Comp_ReconocimientoLN,
            IV_ExternosLN vIV_ExternosLN,
            IT_Sgpad_Comp_Est_GestionLN vIT_Sgpad_Comp_Est_GestionLN,
            IT_Sgpal_Estado_GestionLN vIT_Sgpal_Estado_GestionLN,
            IT_Sgpad_Comp_Riesgo_Seg_HumLN vIT_Sgpad_Comp_Riesgo_Seg_HumLN,
            IT_Sgpad_Comp_Riesgo_Sal_AmbLN vIT_Sgpad_Comp_Riesgo_Sal_AmbLN,
            IT_Sgpad_Comp_Riesgo_Fau_ConLN vIT_Sgpad_Comp_Riesgo_Fau_ConLN,
            IT_Sgpad_Comp_ResultadoLN vIT_Sgpad_Comp_ResultadoLN,
            IT_Sgpad_Comp_Est_AmbLN vIT_Sgpad_Comp_Est_AmbLN,
            IT_Sgpal_Tamano_ParticulaLN vIT_Sgpal_Tamano_ParticulaLN,
            IT_Sgpal_HumedadLN vIT_Sgpal_HumedadLN,
            IT_Sgpal_Tipo_ConcesionLN vIT_Sgpal_Tipo_ConcesionLN,
            IT_Sgpal_CoberturaLN vIT_Sgpal_CoberturaLN
            )
        {
            ComponenteAD = vT_Sgpad_ComponenteAD;
            Tipo_PamLN = vIT_Sgpal_Tipo_PamLN;
            Sub_Tipo_PamLN = vIT_Sgpal_Sub_Tipo_PamLN;
            Componente_ModLN = vIT_Sgpah_Componente_ModLN;
            ObservacionLN = vIT_Sgpad_Comp_ObservacionLN;
            //RegionLN = vIT_Sgpal_RegionLN;
            //ProvinciaLN = vIT_Sgpal_ProvinciaLN;
            UbigeoLN = vIT_Genl_Ubigeo_IneiLN;

            Comp_MedicionLN = vIT_Sgpad_Comp_MedicionLN;
            Comp_Info_GraficaLN = vIT_Sgpad_Comp_Info_GraficaLN;
            Comp_ComentarioLN = vIT_Sgpad_Comp_ComentarioLN;
            Comp_Enc_RemLN = vIT_Sgpad_Comp_Enc_RemLN;
            Comp_ReaproLN = vIT_Sgpad_Comp_ReaproLN;
            Comp_Info_CampoLN = vIT_Sgpad_Comp_Info_CampoLN;
            Comp_ReconocimientoLN = vIT_Sgpad_Comp_ReconocimientoLN;
            ExternosLN = vIV_ExternosLN;
            Est_GestionLN = vIT_Sgpad_Comp_Est_GestionLN;
            Riesgo_Seg_HumLN = vIT_Sgpad_Comp_Riesgo_Seg_HumLN;
            Riesgo_Sal_AmbLN = vIT_Sgpad_Comp_Riesgo_Sal_AmbLN;
            Riesgo_Fau_ConLN = vIT_Sgpad_Comp_Riesgo_Fau_ConLN;
            ResultadoLN = vIT_Sgpad_Comp_ResultadoLN;
            Comp_Est_AmbLN = vIT_Sgpad_Comp_Est_AmbLN;
            Tamano_ParticulaLN = vIT_Sgpal_Tamano_ParticulaLN;
            HumedadLN = vIT_Sgpal_HumedadLN;
            Tipo_ConcesionLN = vIT_Sgpal_Tipo_ConcesionLN;
            CoberturaLN = vIT_Sgpal_CoberturaLN;
        }

        public IEnumerable<ComponenteDTO> ListarComponenteDTO()
        {
            try
            {
                var vResultado = ComponenteAD.ListarT_Sgpad_Componente();
                return new List<ComponenteDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ComponenteDTO RecuperarComponenteDTOPorCodigo(int vId_Componente)
        {
            try
            {
                var vRegistro = ComponenteAD.RecuperarT_Sgpad_ComponentePorCodigo(vId_Componente);

                if (vRegistro != null)
                {
                    var vResultado = new ComponenteDTO
                    {
                        Descripcion = vRegistro.DESCRIPCION,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Caracteristica = vRegistro.CARACTERISTICA,
                        Id_Datum = vRegistro.ID_DATUM,
                        Este = vRegistro.ESTE,
                        Id_Cobertura = vRegistro.ID_COBERTURA,
                        Id_Componente = vRegistro.ID_COMPONENTE,
                        Id_Cuenca = vRegistro.ID_CUENCA,
                        Id_Cuenca_Hidro = vRegistro.ID_CUENCA_HIDRO,
                        Id_Cuenca_Secundaria = vRegistro.ID_CUENCA_SECUNDARIA,
                        Id_Eum = vRegistro.ID_EUM,
                        Id_Humedad = vRegistro.ID_HUMEDAD,
                        Id_Situacion_Pam = vRegistro.ID_SITUACION_PAM,
                        Id_Sub_Tipo_Pam = vRegistro.ID_SUB_TIPO_PAM,
                        Id_Tamano_Particula = vRegistro.ID_TAMANO_PARTICULA,
                        Id_Tipo_Concesion = vRegistro.ID_TIPO_CONCESION,
                        Id_Tipo_Mineria = vRegistro.ID_TIPO_MINERIA,
                        Id_Tipo_Pam = vRegistro.ID_TIPO_PAM,
                        Nombre = vRegistro.NOMBRE,
                        Norte = vRegistro.NORTE,
                        Otro_Descripcion = vRegistro.OTRO_DESCRIPCION,
                        Puntaje = vRegistro.PUNTAJE,
                        Puntaje_Normalizado = vRegistro.PUNTAJE_NORMALIZADO,
                        Ubicacion = vRegistro.UBICACION,
                        Ubigeo = vRegistro.UBIGEO,
                        Id_Zona = vRegistro.ID_ZONA,
                        Riesgo = vRegistro.RIESGO,

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

        public ComponenteDTO GrabarComponenteDTO(ComponenteDTO vComponenteDTO)
        {
            try
            {
                if (vComponenteDTO != null)
                {
                    var vRegistro = new T_Sgpad_Componente
                    {
                        ID_DATUM = vComponenteDTO.Id_Datum,
                        ID_HUMEDAD = vComponenteDTO.Id_Humedad,
                        CARACTERISTICA = vComponenteDTO.Caracteristica,
                        ESTE = vComponenteDTO.Este,
                        ID_COBERTURA = vComponenteDTO.Id_Cobertura,
                        ID_COMPONENTE = vComponenteDTO.Id_Componente,
                        ID_CUENCA = vComponenteDTO.Id_Cuenca,
                        ID_CUENCA_HIDRO = vComponenteDTO.Id_Cuenca_Hidro,
                        ID_CUENCA_SECUNDARIA = vComponenteDTO.Id_Cuenca_Secundaria,
                        ID_EUM = vComponenteDTO.Id_Eum,
                        ID_SITUACION_PAM = vComponenteDTO.Id_Situacion_Pam,
                        ID_SUB_TIPO_PAM = vComponenteDTO.Id_Sub_Tipo_Pam,
                        ID_TAMANO_PARTICULA = vComponenteDTO.Id_Tamano_Particula,
                        ID_TIPO_CONCESION = vComponenteDTO.Id_Tipo_Concesion,
                        ID_TIPO_MINERIA = vComponenteDTO.Id_Tipo_Mineria,
                        ID_TIPO_PAM = vComponenteDTO.Id_Tipo_Pam,
                        NOMBRE = vComponenteDTO.Nombre,
                        NORTE = vComponenteDTO.Norte,
                        OTRO_DESCRIPCION = vComponenteDTO.Otro_Descripcion,
                        PUNTAJE = vComponenteDTO.Puntaje,
                        PUNTAJE_NORMALIZADO = vComponenteDTO.Puntaje_Normalizado,
                        UBICACION = vComponenteDTO.Ubicacion,
                        UBIGEO = vComponenteDTO.Ubigeo == null ? vComponenteDTO.Id_Distrito : vComponenteDTO.Ubigeo,
                        ID_ZONA = vComponenteDTO.Id_Zona,
                        DESCRIPCION = vComponenteDTO.Descripcion + " ",
                        FEC_INGRESO = vComponenteDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComponenteDTO.Fec_Modifica,
                        FLG_ESTADO = vComponenteDTO.Flg_Estado == null ? Constantes.Activo : vComponenteDTO.Flg_Estado,
                        IP_INGRESO = vComponenteDTO.Ip_Ingreso,
                        IP_MODIFICA = vComponenteDTO.Ip_Modifica,
                        USU_INGRESO = vComponenteDTO.Usu_Ingreso,
                        USU_MODIFICA = vComponenteDTO.Usu_Modifica,
                        RIESGO = vComponenteDTO.Riesgo
                    };

                    if (vComponenteDTO.Id_Componente == 0)
                    {
                        var vResultado = ComponenteAD.InsertarT_Sgpad_Componente(vRegistro);
                        vComponenteDTO.Id_Componente = vResultado.ID_COMPONENTE;

                        Comp_ReconocimientoLN.Insertar_Reconocimiento_Tipo(new Comp_ReconocimientoDTO
                        {
                            Id_Componente = vComponenteDTO.Id_Componente,
                            Id_Tipo_Mineria = vComponenteDTO.Id_Tipo_Mineria,
                            Usu_Ingreso = vComponenteDTO.Usu_Ingreso,
                            Ip_Ingreso = vComponenteDTO.Ip_Ingreso,
                            Fec_Ingreso = vComponenteDTO.Fec_Ingreso,
                            Usu_Modifica = vComponenteDTO.Usu_Modifica,
                            Ip_Modifica = vComponenteDTO.Ip_Modifica,
                            Fec_Modifica = vComponenteDTO.Fec_Modifica,
                            Id_Tipo_Pam = vComponenteDTO.Id_Tipo_Pam
                        });
                    }
                    else
                    {
                        var vExistComp = RecuperarComponenteDTOPorCodigo(vComponenteDTO.Id_Componente);
                        if (vExistComp != null && vExistComp.Id_Tipo_Pam == vComponenteDTO.Id_Tipo_Pam)
                        {
                            if (vComponenteDTO.ListaReconocimientoMin != null)
                            {
                                var vListaReconocimiento = (from vTmp in vComponenteDTO.ListaReconocimientoMin
                                                            select new Comp_ReconocimientoDTO
                                                            {
                                                                Altura = vTmp.Altura,
                                                                Ancho = vTmp.Ancho,
                                                                Area = vTmp.Area,
                                                                Base = vTmp.Base,
                                                                Cantidad = vTmp.Cantidad,
                                                                Fec_Ingreso = vRegistro.FEC_INGRESO,
                                                                Fec_Modifica = vRegistro.FEC_MODIFICA,
                                                                Flg_Estado = vRegistro.FLG_ESTADO,
                                                                Id_Componente = vRegistro.ID_COMPONENTE,
                                                                Id_Comp_Reconocimiento = vTmp.Id,
                                                                Id_Tipo_Mineria = vRegistro.ID_TIPO_MINERIA,
                                                                Id_Tipo_Reconocimiento = vTmp.Tipo,
                                                                Ip_Ingreso = vRegistro.IP_INGRESO,
                                                                Ip_Modifica = vRegistro.IP_MODIFICA,
                                                                Largo = vTmp.Largo,
                                                                Profundidad = vTmp.Profundidad,
                                                                Volumen = vTmp.Volumen,
                                                                Usu_Ingreso = vRegistro.USU_INGRESO,
                                                                Usu_Modifica = vRegistro.USU_MODIFICA
                                                            });

                                foreach (var item in vListaReconocimiento)
                                {
                                    Comp_ReconocimientoLN.GrabarComp_ReconocimientoDTO(item);
                                }
                            }

                            var vResultado = ComponenteAD.ActualizarT_Sgpad_Componente(vRegistro);

                            if (vComponenteDTO.Id_Zona.GetValueOrDefault() > 0 && !string.IsNullOrEmpty(vComponenteDTO.Id_Datum) && vComponenteDTO.Este.GetValueOrDefault() != 0 && vComponenteDTO.Norte.GetValueOrDefault() != 0 && !string.IsNullOrEmpty(vComponenteDTO.Id_Distrito))
                            {
                                ExternosLN.Insertar_DerechosMineros(vComponenteDTO);

                                var vListDerechosMineros = ExternosLN.Listar_DerechosMineros(vComponenteDTO.Id_Componente);
                                foreach (var vDerechoMinero in vListDerechosMineros)
                                {
                                    vComponenteDTO.Id_DerechoMinero = vDerechoMinero.Id;

                                    ExternosLN.Insertar_SituacionPrincipalesProductos(vComponenteDTO);

                                    ExternosLN.Insertar_TitularesReferenciales(vComponenteDTO);

                                    ExternosLN.Insertar_ReinfoDerechosMineros(vComponenteDTO);
                                }
                            }
                            //ListaDerechosMineros = ExternosLN.Listar_DerechosMineros(new ComponenteDTO
                            //{
                            //    Id_Zona = 18,
                            //    Id_Datum = "2",
                            //    Este = 800324,
                            //    Norte = 8305104,
                            //    Ubigeo = "041010"
                            //})

                            var vHistoria = Componente_ModLN.GrabarComponente_ModDTO(new Componente_ModDTO
                            {
                                Cargo = "SISTEMAS",
                                Fec_Ingreso = DateTime.Now,
                                Flg_Estado = Constantes.Activo,
                                Id_Componente = vRegistro.ID_COMPONENTE,
                                Id_Componente_Mod = 0,
                                Ip_Ingreso = vRegistro.IP_MODIFICA,
                                Usu_Ingreso = vRegistro.USU_MODIFICA
                            });
                            vComponenteDTO = RecuperarComponenteDTOPorCodigo(vResultado.ID_COMPONENTE);
                        }
                        else
                        {
                            vComponenteDTO = vExistComp;
                        }
                    }
                }
                return vComponenteDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularComponenteDTOPorCodigo(ComponenteDTO vComponenteDTO)
        {
            bool vResult = false;
            try
            {
                if (vComponenteDTO != null)
                {
                    var vRegistro = new T_Sgpad_Componente
                    {
                        ID_COMPONENTE = vComponenteDTO.Id_Componente,
                        FLG_ESTADO = Constantes.Inactivo,
                        IP_MODIFICA = vComponenteDTO.Ip_Modifica,
                        USU_MODIFICA = vComponenteDTO.Usu_Modifica,
                        FEC_MODIFICA = vComponenteDTO.Fec_Modifica
                    };
                    vResult = ComponenteAD.AnularT_Sgpad_ComponentePorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<ComponenteDTO> ListarPaginadoComponenteDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = ComponenteAD.ListarPaginadoT_Sgpad_Componente(vFiltro, vNumPag, vCantRegxPag);
                return new List<ComponenteDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegistrarPamDTO RecuperarFullComponenteDTOPorCodigo(int vId_Componente)
        {
            try
            {
                if (vId_Componente > 0)
                {
                    RegistrarPamDTO vResultado = new RegistrarPamDTO
                    {
                        Componente = RecuperarComponenteDTOPorCodigo(vId_Componente),
                        CboTipo = Tipo_PamLN.ListarTipo_PamDTO().ToList(),
                        CboSubTipo = Sub_Tipo_PamLN.ListarSub_Tipo_PamDTO().ToList(),
                        //CboUbigeo = DistritoLN.ListarUbigeoDTO().ToList(),
                        CboUbigeo = UbigeoLN.ListarUbigeoDTO().ToList(),

                        CboParticula = Tamano_ParticulaLN.ListarTamano_ParticulaDTO().ToList(),
                        CboHumedad = HumedadLN.ListarHumedadDTO().ToList(),
                        CboConcesion = Tipo_ConcesionLN.ListarTipo_ConcesionDTO().ToList(),
                        CboCobertura = CoberturaLN.ListarCoberturaDTO().ToList(),
                        //CboRegion = (List<RegionDTO>)RegionLN.ListarRegionDTO(),
                        //CboProvincia = (List<ProvinciaDTO>)ProvinciaLN.ListarProvinciaDTO(),
                        //CboDistrito = (List<DistritoDTO>)DistritoLN.ListarDistritoDTO(),

                        ListaHistorial = Componente_ModLN.ListarComponente_ModDTO(vId_Componente).ToList(),
                        ListaObservaciones = ObservacionLN.ListarComp_ObservacionDTO(vId_Componente).ToList(),
                        ListaMedicionesCampo = Comp_MedicionLN.ListarComp_MedicionDTO(vId_Componente).ToList(),
                        ListaInformacionGrafica = Comp_Info_GraficaLN.ListarComp_Info_GraficaDTO(vId_Componente).ToList(),
                        ListaComentariosAdicionales = Comp_ComentarioLN.ListarComp_ComentarioDTO(vId_Componente).ToList(),
                        ListaEncargoRemediacion = Comp_Enc_RemLN.ListarComp_Enc_RemDTO(vId_Componente).ToList(),
                        ListaReaprovechamientos = Comp_ReaproLN.ListarComp_ReaproDTO(vId_Componente).ToList(),
                        ListaInformeCampo = Comp_Info_CampoLN.ListarComp_Info_CampoDTO(vId_Componente).ToList(),
                        ListarReconocimientoVisual = Comp_ReconocimientoLN.ListarComp_ReconocimientoDTO(vId_Componente).ToList(),
                        ListaEstadoGestion = Est_GestionLN.ListarComp_Est_GestionDTO(vId_Componente).ToList(),
                        ListaRiesgosSeguridadHumana = Riesgo_Seg_HumLN.ListarComp_Riesgo_Seg_HumDTO(vId_Componente).ToList(),
                        ListaRiesgosSaludHumanaAmbiente = Riesgo_Sal_AmbLN.ListarComp_Riesgo_Sal_AmbDTO(vId_Componente).ToList(),
                        ListaRiesgosFaunaSilvestre = Riesgo_Fau_ConLN.ListarComp_Riesgo_Fau_ConDTO(vId_Componente).ToList(),
                        ListaResultados = ResultadoLN.ListarComp_ResultadoDTO(vId_Componente).ToList(),
                        ListaEstudioAmbientales = Comp_Est_AmbLN.ListarComp_Est_AmbDTO(vId_Componente).ToList(),

                        ListaDerechosMineros = ExternosLN.Listar_DerechosMineros(vId_Componente),
                        ListaSituacionPrincipalesProducto = ExternosLN.Listar_SituacionPrincipalesProductos(vId_Componente),
                        ListaTitularesReferencialesDerechos = ExternosLN.Listar_TitularesReferencialesDerechos(vId_Componente),
                        ListaReinfoDerechosMineros = ExternosLN.Listar_ReinfoDerechosMineros(vId_Componente),

                        CboCuenca = ExternosLN.Listar_Cuenca(vId_Componente)
                        
                        //ListaDerechosMineros = ExternosLN.Listar_DerechosMineros(new ComponenteDTO
                        //{
                        //    Id_Zona = 18,
                        //    Id_Datum = "2",
                        //    Este = 800324,
                        //    Norte = 8305104,
                        //    Ubigeo = "041010"
                        //})
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

        public IEnumerable<ComponenteMinDTO> ListarComponenteEumDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in ComponenteAD.ListarT_Sgpad_Componente_Eum(vId_Eum)
                                  select new ComponenteMinDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Datum = vTmp.DATUM,
                                      Este = vTmp.ESTE,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Imagen = vTmp.IMAGEN,
                                      Nombre = vTmp.NOMBRE,
                                      Norte = vTmp.NORTE,
                                      Puntaje = vTmp.PUNTAJE,
                                      Responsable = vTmp.RESPONSABLE,
                                      Riesgo = vTmp.RIESGO,
                                      SubTipo = vTmp.SUBTIPO,
                                      Tipo = vTmp.TIPO,
                                      Zona = vTmp.ZONA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<ComponenteMinDTO> ListarPorIdEum_ComponenteDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in ComponenteAD.ListarPorIdEumT_Sgpad_Componente_Eum(vId_Eum)
                                  select new ComponenteMinDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Ubigeo = vTmp.UBIGEO,
                                      Departamento = vTmp.DEPARTAMENTO,
                                      Provincia = vTmp.PROVINCIA,
                                      Distrito = vTmp.DISTRITO,
                                      Nombre = vTmp.NOMBRE,
                                      Id_Cuenca = vTmp.ID_CUENCA,
                                      Id_Cuenca_Hidro = vTmp.ID_CUENCA_HIDRO,
                                      Cuenca_Principal = vTmp.CUENCA_PRINCIPAL,
                                      Uni_Hidrografica = vTmp.UNI_HIDROGRAFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO
                                  }).ToList();
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
