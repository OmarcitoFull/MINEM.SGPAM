using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
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
    public class T_Sgpam_MaestraLN : BaseLN, IT_Sgpam_MaestraLN
    {
        private readonly IT_Sgpam_MaestraAD MaestraAD;
        private readonly IT_Sgpal_Tipo_PamLN Tipo_PamLN;
        private readonly IT_Sgpal_Tipo_OperacionLN Tipo_OperacionLN;
        private readonly IT_Sgpal_Tipo_SustanciaLN Tipo_SustanciaLN;
        private readonly IT_Sgpal_Conflicto_SocialLN Conflicto_SocialLN;
        private readonly IT_Sgpah_Eum_ModLN Eum_ModLN;
        private readonly IT_Sgpad_Eum_InspeccionLN Eum_InspeccionLN;
        //private readonly IT_Sgpad_Eum_UbicacionLN Eum_UbicacionLN;
        private readonly IT_Sgpad_Eum_Info_DescargoLN Eum_Info_DescargoLN;
        private readonly IT_Sgpad_Eum_Info_GraficaLN Eum_Info_GraficaLN;
        private readonly IT_Sgpad_Eum_InformeLN Eum_InformeLN;
        private readonly IT_Sgpad_Eum_OperacionLN Eum_OperacionLN;
        private readonly IT_Sgpad_ComponenteLN ComponenteLN;
        private readonly IT_Sgpad_Comp_Dd_MineroLN Comp_Dd_MineroLN;
        private readonly IT_Sgpad_Comp_Dm_SituacionLN Comp_Dm_SituacionLN;
        private readonly IT_Sgpad_Comp_Dm_TitularLN Comp_Dm_TitularLN;
        private readonly ILogger<T_Sgpam_MaestraLN> Logger;

        public T_Sgpam_MaestraLN
        (
            IT_Sgpam_MaestraAD vT_Sgpam_MaestraAD,
            IT_Sgpal_Tipo_PamLN vIT_Sgpal_Tipo_PamLN,
            IT_Sgpal_Tipo_OperacionLN vIT_Sgpal_Tipo_OperacionLN,
            IT_Sgpal_Tipo_SustanciaLN vIT_Sgpal_Tipo_SustanciaLN,
            IT_Sgpal_Conflicto_SocialLN vIT_Sgpal_Conflicto_SocialLN,
            IT_Sgpah_Eum_ModLN vIT_Sgpah_Eum_ModLN,
            IT_Sgpad_Eum_InspeccionLN vIT_Sgpad_Eum_InspeccionLN,
            IT_Sgpad_Eum_Info_DescargoLN vIT_Sgpad_Eum_Info_DescargoLN,
            IT_Sgpad_Eum_Info_GraficaLN vIT_Sgpad_Eum_Info_GraficaLN,
            IT_Sgpad_Eum_InformeLN vIT_Sgpad_Eum_InformeLN,
            IT_Sgpad_Eum_OperacionLN vIT_Sgpad_Eum_OperacionLN,
            IT_Sgpad_ComponenteLN vIT_Sgpad_ComponenteLN,
            IT_Sgpad_Comp_Dd_MineroLN vIT_Sgpad_Comp_Dd_MineroLN,
            IT_Sgpad_Comp_Dm_SituacionLN vIT_Sgpad_Comp_Dm_SituacionLN,
            IT_Sgpad_Comp_Dm_TitularLN vIT_Sgpad_Comp_Dm_TitularLN,
            ILogger<T_Sgpam_MaestraLN> vILogger
        )
        {
            MaestraAD = vT_Sgpam_MaestraAD;
            Tipo_PamLN = vIT_Sgpal_Tipo_PamLN;
            Tipo_OperacionLN = vIT_Sgpal_Tipo_OperacionLN;
            Tipo_SustanciaLN = vIT_Sgpal_Tipo_SustanciaLN;
            Conflicto_SocialLN = vIT_Sgpal_Conflicto_SocialLN;
            Eum_ModLN = vIT_Sgpah_Eum_ModLN;
            Eum_InspeccionLN = vIT_Sgpad_Eum_InspeccionLN;
            Eum_Info_DescargoLN = vIT_Sgpad_Eum_Info_DescargoLN;
            Eum_Info_GraficaLN = vIT_Sgpad_Eum_Info_GraficaLN;
            Eum_InformeLN = vIT_Sgpad_Eum_InformeLN;
            Eum_OperacionLN = vIT_Sgpad_Eum_OperacionLN;
            ComponenteLN = vIT_Sgpad_ComponenteLN;
            Comp_Dd_MineroLN = vIT_Sgpad_Comp_Dd_MineroLN;
            Comp_Dm_SituacionLN = vIT_Sgpad_Comp_Dm_SituacionLN;
            Comp_Dm_TitularLN = vIT_Sgpad_Comp_Dm_TitularLN;
            Logger = vILogger;
        }

        public IEnumerable<MaestraDTO> ListarMaestraDTO()
        {
            try
            {
                var vResultado = MaestraAD.ListarT_Sgpam_Maestra();
                return new List<MaestraDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public MaestraDTO RecuperarMaestraDTOPorCodigo(int vId_Eum)
        {
            try
            {
                var vRegistro = MaestraAD.RecuperarT_Sgpam_MaestraPorCodigo(vId_Eum);
                if (vRegistro != null)
                {
                    var vResultado = new MaestraDTO
                    {
                        Acceso_Eum = vRegistro.ACCESO_EUM,
                        Area_Conservacion = vRegistro.AREA_CONSERVACION,
                        Comentario_Adi = vRegistro.COMENTARIO_ADI,
                        Conflicto_Social = vRegistro.CONFLICTO_SOCIAL,
                        Cuerpos_Agua = vRegistro.CUERPOS_AGUA,
                        Descripcion_Eum = vRegistro.DESCRIPCION_EUM,
                        Eum_Descripcion = vRegistro.EUM_DESCRIPCION,
                        Evidencia_Act_Rec = vRegistro.EVIDENCIA_ACT_REC,
                        Fauna_Terreste = vRegistro.FAUNA_TERRESTE,
                        Flora_Fauna_Acuatica = vRegistro.FLORA_FAUNA_ACUATICA,
                        Flora_Terrestre = vRegistro.FLORA_TERRESTRE,
                        Historia_Eum = vRegistro.HISTORIA_EUM,
                        Id_Conflicto_Social = vRegistro.ID_CONFLICTO_SOCIAL,
                        Id_Estado_Registro = vRegistro.ID_ESTADO_REGISTRO,
                        Id_Eum = vRegistro.ID_EUM,
                        Id_Tipo_Operacion = 1, //vRegistro.ID_TIPO_OPERACION,
                        Id_Tipo_Sustancia = vRegistro.ID_TIPO_SUSTANCIA,
                        Infra_Urbana = vRegistro.INFRA_URBANA,
                        Num_Eum = vRegistro.NUM_EUM,
                        Relieve = vRegistro.RELIEVE,
                        Sitio_Arque_Turistico = vRegistro.SITIO_ARQUE_TURISTICO,
                        Uso_Agua = vRegistro.USO_AGUA,
                        Uso_Suelo = vRegistro.USO_SUELO,
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

        public MaestraDTO GrabarMaestraDTO(MaestraDTO vMaestraDTO)
        {
            try
            {
                if (vMaestraDTO.Id_Eum == 0)
                    return InsertarMaestraDTO(vMaestraDTO);
                else
                    return ActualizarMaestraDTO(vMaestraDTO);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public MaestraDTO InsertarMaestraDTO(MaestraDTO vMaestraDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Maestra
                {
                    ID_EUM = vMaestraDTO.Id_Eum,
                    EUM_DESCRIPCION = vMaestraDTO.Eum_Descripcion.ToUpper(),
                    ACCESO_EUM = vMaestraDTO.Acceso_Eum,
                    HISTORIA_EUM = vMaestraDTO.Historia_Eum,
                    EVIDENCIA_ACT_REC = vMaestraDTO.Evidencia_Act_Rec,
                    ID_TIPO_OPERACION = 1,
                    ID_TIPO_SUSTANCIA = vMaestraDTO.Id_Tipo_Sustancia,
                    RELIEVE = vMaestraDTO.Relieve,
                    CUERPOS_AGUA = vMaestraDTO.Cuerpos_Agua,
                    FLORA_TERRESTRE = vMaestraDTO.Flora_Terrestre,
                    FAUNA_TERRESTE = vMaestraDTO.Fauna_Terreste,
                    FLORA_FAUNA_ACUATICA = vMaestraDTO.Flora_Fauna_Acuatica,
                    INFRA_URBANA = vMaestraDTO.Infra_Urbana,
                    USO_SUELO = vMaestraDTO.Uso_Suelo,
                    USO_AGUA = vMaestraDTO.Uso_Agua,
                    AREA_CONSERVACION = vMaestraDTO.Area_Conservacion,
                    SITIO_ARQUE_TURISTICO = vMaestraDTO.Sitio_Arque_Turistico,
                    ID_CONFLICTO_SOCIAL = vMaestraDTO.Id_Conflicto_Social,
                    CONFLICTO_SOCIAL = vMaestraDTO.Conflicto_Social,
                    DESCRIPCION_EUM = vMaestraDTO.Descripcion_Eum,
                    COMENTARIO_ADI = vMaestraDTO.Comentario_Adi,
                    NUM_EUM = vMaestraDTO.Num_Eum,
                    ID_ESTADO_REGISTRO = vMaestraDTO.Id_Estado_Registro,
                    USU_INGRESO = vMaestraDTO.Usu_Ingreso,
                    FEC_INGRESO = vMaestraDTO.Fec_Ingreso,
                    IP_INGRESO = vMaestraDTO.Ip_Ingreso,
                    FLG_ESTADO = "1"
                };
                var vResultado = MaestraAD.InsertarT_Sgpam_Maestra(vRegistro);
                vMaestraDTO = RecuperarMaestraDTOPorCodigo(vResultado.ID_EUM);

                return vMaestraDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public MaestraDTO ActualizarMaestraDTO(MaestraDTO vMaestraDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Maestra
                {
                    ID_EUM = vMaestraDTO.Id_Eum,
                    EUM_DESCRIPCION = vMaestraDTO.Eum_Descripcion.ToUpper(),
                    ACCESO_EUM = vMaestraDTO.Acceso_Eum,
                    HISTORIA_EUM = vMaestraDTO.Historia_Eum,
                    EVIDENCIA_ACT_REC = vMaestraDTO.Evidencia_Act_Rec,
                    ID_TIPO_OPERACION = 1,
                    ID_TIPO_SUSTANCIA = vMaestraDTO.Id_Tipo_Sustancia,
                    RELIEVE = vMaestraDTO.Relieve,
                    CUERPOS_AGUA = vMaestraDTO.Cuerpos_Agua,
                    FLORA_TERRESTRE = vMaestraDTO.Flora_Terrestre,
                    FAUNA_TERRESTE = vMaestraDTO.Fauna_Terreste,
                    FLORA_FAUNA_ACUATICA = vMaestraDTO.Flora_Fauna_Acuatica,
                    INFRA_URBANA = vMaestraDTO.Infra_Urbana,
                    USO_SUELO = vMaestraDTO.Uso_Suelo,
                    USO_AGUA = vMaestraDTO.Uso_Agua,
                    AREA_CONSERVACION = vMaestraDTO.Area_Conservacion,
                    SITIO_ARQUE_TURISTICO = vMaestraDTO.Sitio_Arque_Turistico,
                    ID_CONFLICTO_SOCIAL = vMaestraDTO.Id_Conflicto_Social,
                    CONFLICTO_SOCIAL = vMaestraDTO.Conflicto_Social,
                    DESCRIPCION_EUM = vMaestraDTO.Descripcion_Eum,
                    COMENTARIO_ADI = vMaestraDTO.Comentario_Adi,
                    NUM_EUM = vMaestraDTO.Num_Eum,
                    ID_ESTADO_REGISTRO = vMaestraDTO.Id_Estado_Registro,
                    FEC_MODIFICA = vMaestraDTO.Fec_Modifica,
                    IP_MODIFICA = vMaestraDTO.Ip_Modifica,
                    USU_MODIFICA = vMaestraDTO.Usu_Modifica
                };
                var vResultado = MaestraAD.ActualizarT_Sgpam_Maestra(vRegistro);
                var vHistoria = Eum_ModLN.InsertarEum_ModDTO(new Eum_ModDTO
                {
                    Id_Eum_Mod = 0,
                    Id_Eum = vRegistro.ID_EUM,
                    Cargo = "SISTEMAS",
                    Usu_Ingreso = vRegistro.USU_MODIFICA,
                    Fec_Ingreso = DateTime.Now,
                    Ip_Ingreso = vRegistro.IP_MODIFICA,
                    Flg_Estado = "1",
                });
                vMaestraDTO = RecuperarMaestraDTOPorCodigo(vResultado.ID_EUM);

                return vMaestraDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularMaestraDTOPorCodigo(MaestraDTO vMaestraDTO)
        {
            int vResult = 0;
            try
            {
                if (vMaestraDTO != null)
                {
                    var vRegistro = new T_Sgpam_Maestra
                    {
                        ID_EUM = vMaestraDTO.Id_Eum,
                        USU_MODIFICA = vMaestraDTO.Usu_Modifica,
                        FEC_MODIFICA = vMaestraDTO.Fec_Modifica,
                        IP_MODIFICA = vMaestraDTO.Ip_Modifica
                    };
                    vResult = MaestraAD.AnularT_Sgpam_MaestraPorCodigo(vRegistro); // != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<MaestraDTO> ListarPaginadoMaestraDTO(string vFiltro, string vUbigeo, int vNumPag, int vCantRegxPag)
        {
            try
            {
                if (vFiltro == null || vFiltro.Trim().Length == 0)
                    vFiltro = "";
                else
                    vFiltro = vFiltro.ToUpper();


                if (vUbigeo == null || vUbigeo.Trim().Length == 0)
                    vUbigeo = "0";


                IEnumerable<T_Sgpam_Maestra> vResultado = MaestraAD.ListarPaginadoT_Sgpam_Maestra(vFiltro, vUbigeo, vNumPag, vCantRegxPag);
                if (vResultado != null)
                {
                    List<MaestraDTO> vLista = new List<MaestraDTO>();
                    MaestraDTO vEntidad;
                    foreach (T_Sgpam_Maestra item in vResultado)
                    {
                        vEntidad = new MaestraDTO()
                        {
                            Acceso_Eum = item.ACCESO_EUM,
                            Area_Conservacion = item.AREA_CONSERVACION,
                            Comentario_Adi = item.COMENTARIO_ADI,
                            Conflicto_Social = item.CONFLICTO_SOCIAL,
                            Cuerpos_Agua = item.CUERPOS_AGUA,
                            Descripcion_Eum = item.DESCRIPCION_EUM,
                            Eum_Descripcion = item.EUM_DESCRIPCION,
                            Evidencia_Act_Rec = item.EVIDENCIA_ACT_REC,
                            Fauna_Terreste = item.FAUNA_TERRESTE,
                            Flora_Fauna_Acuatica = item.FLORA_FAUNA_ACUATICA,
                            Flora_Terrestre = item.FLORA_TERRESTRE,
                            Historia_Eum = item.HISTORIA_EUM,
                            Id_Conflicto_Social = item.ID_CONFLICTO_SOCIAL,
                            Id_Estado_Registro = item.ID_ESTADO_REGISTRO,
                            Id_Eum = item.ID_EUM,
                            Id_Tipo_Operacion = 1,//item.ID_TIPO_OPERACION,
                            Id_Tipo_Sustancia = item.ID_TIPO_SUSTANCIA,
                            Infra_Urbana = item.INFRA_URBANA,
                            Num_Eum = item.NUM_EUM,
                            Relieve = item.RELIEVE,
                            Sitio_Arque_Turistico = item.SITIO_ARQUE_TURISTICO,
                            Uso_Agua = item.USO_AGUA,
                            Uso_Suelo = item.USO_SUELO,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,

                            Ult_Visita = item.ULT_VISITA,
                            Fecha_Informe = item.FECHA_INFORME,
                            Nro_Informe = item.NRO_INFORME//,
                            //Region = item.REGION,
                            //Provincia = item.PROVINCIA,
                            //Distrito = item.DISTRITO
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public RegistrarEumDTO RecuperarFullMaestraDTOPorCodigo(int vId_Eum)
        {
            try
            {
                var vListComponente = ComponenteLN.ListarComponenteEumDTO(vId_Eum);
                RegistrarEumDTO vResultado = new RegistrarEumDTO
                {
                    Eum = RecuperarMaestraDTOPorCodigo(vId_Eum),
                    CboConflictoSocial = (List<Conflicto_SocialDTO>)Conflicto_SocialLN.ListarConflicto_SocialDTO(),
                    CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO(),
                    CboTipoSustancia = (List<Tipo_SustanciaDTO>)Tipo_SustanciaLN.ListarTipo_SustanciaDTO(),
                    CboTipoPam = (List<Tipo_PamDTO>)Tipo_PamLN.ListarTipo_PamDTO(),
                    ListaHistorial = (List<Eum_ModDTO>)Eum_ModLN.ListarPorIdEumEum_ModDTO(vId_Eum),
                    ListaInspeccion = (List<Eum_InspeccionDTO>)Eum_InspeccionLN.ListarPorIdEumEum_InspeccionDTO(vId_Eum),
                    ListaUbicacion = (List<ComponenteMinDTO>)ComponenteLN.ListarPorIdEum_ComponenteDTO(vId_Eum),

                    ListaInformacionDescargo = (List<Eum_Info_DescargoDTO>)Eum_Info_DescargoLN.ListarPorIdEumEum_Info_DescargoDTO(vId_Eum),
                    ListaInformacionGrafica = (List<Eum_Info_GraficaDTO>)Eum_Info_GraficaLN.ListarPorIdEumEum_Info_GraficaDTO(vId_Eum),
                    ListaInforme = (List<Eum_InformeDTO>)Eum_InformeLN.ListarPorIdEumEum_InformeDTO(vId_Eum),
                    ListaOperacion = (List<Eum_OperacionDTO>)Eum_OperacionLN.ListarPorIdEumEum_OperacionDTO(vId_Eum),
                    ListaDerechosMineros = (List<Comp_Dd_MineroDTO>)Comp_Dd_MineroLN.ListarPorIdEumComp_Dd_MineroDTO(vId_Eum),
                    ListaSituacionPrincipalesProducto = (List<Comp_Dm_SituacionDTO>)Comp_Dm_SituacionLN.ListarPorIdEumComp_Dm_Situacion(vId_Eum),
                    ListaTitularesReferencialesDerechos = (List<Comp_Dm_TitularDTO>)Comp_Dm_TitularLN.ListarPorIdEumComp_Dm_Titular(vId_Eum),

                    ListaComponenteActivo = vListComponente.Where(x => x.Flg_Estado == Constantes.Activo).ToList(),
                    ListaComponenteInactivo = vListComponente.Where(x => x.Flg_Estado == Constantes.Inactivo).ToList()
                };
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }

        }

        public IEnumerable<MaestraDTO> ListaAutocompletarMaestraDTO(string vFiltro)
        {
            try
            {
                if (vFiltro == null || vFiltro.Trim().Length == 0)
                    vFiltro = "";
                else
                    vFiltro = vFiltro.ToUpper();

                IEnumerable<T_Sgpam_Maestra> vResultado = MaestraAD.ListarAutocompletarT_Sgpam_Maestra(vFiltro);
                if (vResultado != null)
                {
                    List<MaestraDTO> vLista = new List<MaestraDTO>();
                    MaestraDTO vEntidad;
                    foreach (T_Sgpam_Maestra item in vResultado)
                    {
                        vEntidad = new MaestraDTO()
                        {
                            Eum_Descripcion = item.EUM_DESCRIPCION,
                            Id_Eum = item.ID_EUM//,
                            //Distrito = item.DISTRITO
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

    }
}
