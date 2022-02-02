using Microsoft.Extensions.DependencyInjection;
using Minem.Sgpam.AccesoDatos.Implementaciones;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.LogicaNegocio.Implementaciones;
using Minem.Sgpam.LogicaNegocio.Interfaces;

namespace Minem.Sgpam.WebApi
{
    /// <summary>
    /// Objetivo:	Clase donde se Instancias de las interfaces
    /// Creado Por:	(ORM) - Omar Rodriguez M.
    /// Fecha Creación:	01/11/2021
    /// </summary>
    public static class Extensiones
    {
        public static void Inyecciones(this IServiceCollection vServices)
        {
            vServices.AddTransient<IT_Sgpam_MaestraAD, T_Sgpam_MaestraAD>();
            vServices.AddTransient<IT_Sgpam_MaestraLN, T_Sgpam_MaestraLN>();

            vServices.AddTransient<IT_Sgpah_Eum_ModAD, T_Sgpah_Eum_ModAD>();
            vServices.AddTransient<IT_Sgpah_Eum_ModLN, T_Sgpah_Eum_ModLN>();

            vServices.AddTransient<IT_Sgpad_Eum_InspeccionAD, T_Sgpad_Eum_InspeccionAD>();
            vServices.AddTransient<IT_Sgpad_Eum_InspeccionLN, T_Sgpad_Eum_InspeccionLN>();

            vServices.AddTransient<IT_Sgpad_Eum_Info_GraficaAD, T_Sgpad_Eum_Info_GraficaAD>();
            vServices.AddTransient<IT_Sgpad_Eum_Info_GraficaLN, T_Sgpad_Eum_Info_GraficaLN>();

            vServices.AddTransient<IT_Sgpad_Eum_Info_DescargoAD, T_Sgpad_Eum_Info_DescargoAD>();
            vServices.AddTransient<IT_Sgpad_Eum_Info_DescargoLN, T_Sgpad_Eum_Info_DescargoLN>();


            vServices.AddTransient<IT_Sgpam_ExpedienteAD, T_Sgpam_ExpedienteAD>();
            vServices.AddTransient<IT_Sgpam_ExpedienteLN, T_Sgpam_ExpedienteLN>();



            vServices.AddTransient<IT_Sgpal_Conflicto_SocialAD, T_Sgpal_Conflicto_SocialAD>();
            vServices.AddTransient<IT_Sgpal_Conflicto_SocialLN, T_Sgpal_Conflicto_SocialLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_SustanciaAD, T_Sgpal_Tipo_SustanciaAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_SustanciaLN, T_Sgpal_Tipo_SustanciaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_OperacionAD, T_Sgpal_Tipo_OperacionAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_OperacionLN, T_Sgpal_Tipo_OperacionLN>();

            vServices.AddTransient<IT_Sgpal_CoberturaAD, T_Sgpal_CoberturaAD>();
            vServices.AddTransient<IT_Sgpal_CoberturaLN, T_Sgpal_CoberturaLN>();

            vServices.AddTransient<IT_Sgpah_Componente_ModAD, T_Sgpah_Componente_ModAD>();
            vServices.AddTransient<IT_Sgpah_Componente_ModLN, T_Sgpah_Componente_ModLN>();

            vServices.AddTransient<IT_Sgpal_HumedadAD, T_Sgpal_HumedadAD>();
            vServices.AddTransient<IT_Sgpal_HumedadLN, T_Sgpal_HumedadLN>();

            vServices.AddTransient<IT_Sgpal_Sub_Tipo_PamAD, T_Sgpal_Sub_Tipo_PamAD>();
            vServices.AddTransient<IT_Sgpal_Sub_Tipo_PamLN, T_Sgpal_Sub_Tipo_PamLN>();

            vServices.AddTransient<IT_Sgpal_Tamano_ParticulaAD, T_Sgpal_Tamano_ParticulaAD>();
            vServices.AddTransient<IT_Sgpal_Tamano_ParticulaLN, T_Sgpal_Tamano_ParticulaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_ClimaAD, T_Sgpal_Tipo_ClimaAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_ClimaLN, T_Sgpal_Tipo_ClimaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_ConcesionAD, T_Sgpal_Tipo_ConcesionAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_ConcesionLN, T_Sgpal_Tipo_ConcesionLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_MineriaAD, T_Sgpal_Tipo_MineriaAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_MineriaLN, T_Sgpal_Tipo_MineriaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_PamAD, T_Sgpal_Tipo_PamAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_PamLN, T_Sgpal_Tipo_PamLN>();

            vServices.AddTransient<IT_Sgpad_ComponenteAD, T_Sgpad_ComponenteAD>();
            vServices.AddTransient<IT_Sgpad_ComponenteLN, T_Sgpad_ComponenteLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ObservacionAD, T_Sgpad_Comp_ObservacionAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ObservacionLN, T_Sgpad_Comp_ObservacionLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_OperacionAD, T_Sgpal_Tipo_OperacionAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_OperacionLN, T_Sgpal_Tipo_OperacionLN>();

            vServices.AddTransient<IT_Sgpal_CoberturaAD, T_Sgpal_CoberturaAD>();
            vServices.AddTransient<IT_Sgpal_CoberturaLN, T_Sgpal_CoberturaLN>();

            vServices.AddTransient<IT_Sgpah_Componente_ModAD, T_Sgpah_Componente_ModAD>();
            vServices.AddTransient<IT_Sgpah_Componente_ModLN, T_Sgpah_Componente_ModLN>();

            vServices.AddTransient<IT_Sgpal_HumedadAD, T_Sgpal_HumedadAD>();
            vServices.AddTransient<IT_Sgpal_HumedadLN, T_Sgpal_HumedadLN>();

            vServices.AddTransient<IT_Sgpal_Sub_Tipo_PamAD, T_Sgpal_Sub_Tipo_PamAD>();
            vServices.AddTransient<IT_Sgpal_Sub_Tipo_PamLN, T_Sgpal_Sub_Tipo_PamLN>();

            vServices.AddTransient<IT_Sgpal_Tamano_ParticulaAD, T_Sgpal_Tamano_ParticulaAD>();
            vServices.AddTransient<IT_Sgpal_Tamano_ParticulaLN, T_Sgpal_Tamano_ParticulaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_ConcesionAD, T_Sgpal_Tipo_ConcesionAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_ConcesionLN, T_Sgpal_Tipo_ConcesionLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_MineriaAD, T_Sgpal_Tipo_MineriaAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_MineriaLN, T_Sgpal_Tipo_MineriaLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_PamAD, T_Sgpal_Tipo_PamAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_PamLN, T_Sgpal_Tipo_PamLN>();

            vServices.AddTransient<IT_Sgpad_ComponenteAD, T_Sgpad_ComponenteAD>();
            vServices.AddTransient<IT_Sgpad_ComponenteLN, T_Sgpad_ComponenteLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ObservacionAD, T_Sgpad_Comp_ObservacionAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ObservacionLN, T_Sgpad_Comp_ObservacionLN>();

            vServices.AddTransient<IT_Sgpal_RegionAD, T_Sgpal_RegionAD>();
            vServices.AddTransient<IT_Sgpal_RegionLN, T_Sgpal_RegionLN>();

            vServices.AddTransient<IT_Sgpal_ProvinciaAD, T_Sgpal_ProvinciaAD>();
            vServices.AddTransient<IT_Sgpal_ProvinciaLN, T_Sgpal_ProvinciaLN>();

            vServices.AddTransient<IT_Sgpal_DistritoAD, T_Sgpal_DistritoAD>();
            vServices.AddTransient<IT_Sgpal_DistritoLN, T_Sgpal_DistritoLN>();

            vServices.AddTransient<IT_Sgpad_Comp_MedicionAD, T_Sgpad_Comp_MedicionAD>();
            vServices.AddTransient<IT_Sgpad_Comp_MedicionLN, T_Sgpad_Comp_MedicionLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ComentarioAD, T_Sgpad_Comp_ComentarioAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ComentarioLN, T_Sgpad_Comp_ComentarioLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Info_GraficaAD, T_Sgpad_Comp_Info_GraficaAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Info_GraficaLN, T_Sgpad_Comp_Info_GraficaLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Enc_RemAD, T_Sgpad_Comp_Enc_RemAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Enc_RemLN, T_Sgpad_Comp_Enc_RemLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ReaproAD, T_Sgpad_Comp_ReaproAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ReaproLN, T_Sgpad_Comp_ReaproLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Info_CampoAD, T_Sgpad_Comp_Info_CampoAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Info_CampoLN, T_Sgpad_Comp_Info_CampoLN>();

            vServices.AddTransient<IV_ExternosAD, V_ExternosAD>();
            vServices.AddTransient<IV_ExternosLN, V_ExternosLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ReconocimientoAD, T_Sgpad_Comp_ReconocimientoAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ReconocimientoLN, T_Sgpad_Comp_ReconocimientoLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Est_GestionAD, T_Sgpad_Comp_Est_GestionAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Est_GestionLN, T_Sgpad_Comp_Est_GestionLN>();

            vServices.AddTransient<IT_Sgpal_Estado_GestionAD, T_Sgpal_Estado_GestionAD>();
            vServices.AddTransient<IT_Sgpal_Estado_GestionLN, T_Sgpal_Estado_GestionLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Seg_HumAD, T_Sgpad_Comp_Riesgo_Seg_HumAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Seg_HumLN, T_Sgpad_Comp_Riesgo_Seg_HumLN>();

            vServices.AddTransient<IT_Sgpal_AccesibilidadAD, T_Sgpal_AccesibilidadAD>();
            vServices.AddTransient<IT_Sgpal_AccesibilidadLN, T_Sgpal_AccesibilidadLN>();

            vServices.AddTransient<IT_Sgpal_Pot_ColapsoAD, T_Sgpal_Pot_ColapsoAD>();
            vServices.AddTransient<IT_Sgpal_Pot_ColapsoLN, T_Sgpal_Pot_ColapsoLN>();

            vServices.AddTransient<IT_Sgpal_Condicion_CierreAD, T_Sgpal_Condicion_CierreAD>();
            vServices.AddTransient<IT_Sgpal_Condicion_CierreLN, T_Sgpal_Condicion_CierreLN>();

            vServices.AddTransient<IT_Sgpal_Presencia_ElementoAD, T_Sgpal_Presencia_ElementoAD>();
            vServices.AddTransient<IT_Sgpal_Presencia_ElementoLN, T_Sgpal_Presencia_ElementoLN>();

            vServices.AddTransient<IT_Sgpal_HundimientoAD, T_Sgpal_HundimientoAD>();
            vServices.AddTransient<IT_Sgpal_HundimientoLN, T_Sgpal_HundimientoLN>();

            vServices.AddTransient<IT_Sgpal_Pot_Caida_PersonaAD, T_Sgpal_Pot_Caida_PersonaAD>();
            vServices.AddTransient<IT_Sgpal_Pot_Caida_PersonaLN, T_Sgpal_Pot_Caida_PersonaLN>();

            vServices.AddTransient<IT_Sgpal_Presencia_AdvertenciaAD, T_Sgpal_Presencia_AdvertenciaAD>();
            vServices.AddTransient<IT_Sgpal_Presencia_AdvertenciaLN, T_Sgpal_Presencia_AdvertenciaLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Sal_AmbAD, T_Sgpad_Comp_Riesgo_Sal_AmbAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Sal_AmbLN, T_Sgpad_Comp_Riesgo_Sal_AmbLN>();

            vServices.AddTransient<IT_Sgpal_Evidencia_ErosionAD, T_Sgpal_Evidencia_ErosionAD>();
            vServices.AddTransient<IT_Sgpal_Evidencia_ErosionLN, T_Sgpal_Evidencia_ErosionLN>();

            vServices.AddTransient<IT_Sgpal_Evidencia_InundacionAD, T_Sgpal_Evidencia_InundacionAD>();
            vServices.AddTransient<IT_Sgpal_Evidencia_InundacionLN, T_Sgpal_Evidencia_InundacionLN>();

            vServices.AddTransient<IT_Sgpal_Potencial_ArdAD, T_Sgpal_Potencial_ArdAD>();
            vServices.AddTransient<IT_Sgpal_Potencial_ArdLN, T_Sgpal_Potencial_ArdLN>();

            vServices.AddTransient<IT_Sgpal_Evidencia_Sus_ToxicaAD, T_Sgpal_Evidencia_Sus_ToxicaAD>();
            vServices.AddTransient<IT_Sgpal_Evidencia_Sus_ToxicaLN, T_Sgpal_Evidencia_Sus_ToxicaLN>();

            vServices.AddTransient<IT_Sgpal_Acceso_FaunaAD, T_Sgpal_Acceso_FaunaAD>();
            vServices.AddTransient<IT_Sgpal_Acceso_FaunaLN, T_Sgpal_Acceso_FaunaLN>();

            vServices.AddTransient<IT_Sgpal_Atraccion_FaunaAD, T_Sgpal_Atraccion_FaunaAD>();
            vServices.AddTransient<IT_Sgpal_Atraccion_FaunaLN, T_Sgpal_Atraccion_FaunaLN>();

            vServices.AddTransient<IT_Sgpal_Vegetacion_InvasivaAD, T_Sgpal_Vegetacion_InvasivaAD>();
            vServices.AddTransient<IT_Sgpal_Vegetacion_InvasivaLN, T_Sgpal_Vegetacion_InvasivaLN>();

            vServices.AddTransient<IT_Sgpal_Cerca_Area_ProtegidaAD, T_Sgpal_Cerca_Area_ProtegidaAD>();
            vServices.AddTransient<IT_Sgpal_Cerca_Area_ProtegidaLN, T_Sgpal_Cerca_Area_ProtegidaLN>();

            vServices.AddTransient<IT_Sgpal_Sensibilidad_AreaAD, T_Sgpal_Sensibilidad_AreaAD>();
            vServices.AddTransient<IT_Sgpal_Sensibilidad_AreaLN, T_Sgpal_Sensibilidad_AreaLN>();

            vServices.AddTransient<IT_Sgpal_Agua_ContaminadaAD, T_Sgpal_Agua_ContaminadaAD>();
            vServices.AddTransient<IT_Sgpal_Agua_ContaminadaLN, T_Sgpal_Agua_ContaminadaLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Fau_ConAD, T_Sgpad_Comp_Riesgo_Fau_ConAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Riesgo_Fau_ConLN, T_Sgpad_Comp_Riesgo_Fau_ConLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_EncargoAD, T_Sgpal_Tipo_EncargoAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_EncargoLN, T_Sgpal_Tipo_EncargoLN>();

            vServices.AddTransient<IT_Sgpal_Tipo_ResolucionAD, T_Sgpal_Tipo_ResolucionAD>();
            vServices.AddTransient<IT_Sgpal_Tipo_ResolucionLN, T_Sgpal_Tipo_ResolucionLN>();

            vServices.AddTransient<IT_Sgpad_Comp_ResultadoAD, T_Sgpad_Comp_ResultadoAD>();
            vServices.AddTransient<IT_Sgpad_Comp_ResultadoLN, T_Sgpad_Comp_ResultadoLN>();

            vServices.AddTransient<IT_Sgpad_Comp_Est_AmbAD, T_Sgpad_Comp_Est_AmbAD>();
            vServices.AddTransient<IT_Sgpad_Comp_Est_AmbLN, T_Sgpad_Comp_Est_AmbLN>();

        }
    }
}
