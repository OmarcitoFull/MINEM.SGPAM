using System;
using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public class RegistrarPamDTO
    {
        public ComponenteDTO Componente { get; set; }
        public List<Componente_ModDTO> ListaHistorial { get; set; }
        public List<Comp_ObservacionDTO> ListaObservaciones { get; set; }
        public List<Comp_Riesgo_Seg_HumDTO> ListaRiesgosSeguridadHumana { get; set; }
        public List<Comp_Riesgo_Sal_AmbDTO> ListaRiesgosSaludHumanaAmbiente { get; set; }
        public List<Comp_Riesgo_Fau_ConDTO> ListaRiesgosFaunaSilvestre { get; set; }
        public List<Comp_MedicionDTO> ListaMedicionesCampo { get; set; }
        public List<Comp_Info_GraficaDTO> ListaInformacionGrafica { get; set; }
        public List<Comp_ComentarioDTO> ListaComentariosAdicionales { get; set; }
        public List<Comp_Enc_RemDTO> ListaEncargoRemediacion { get; set; }
        public List<Comp_ReaproDTO> ListaReaprovechamientos { get; set; }
        public List<Comp_Info_CampoDTO> ListaInformeCampo { get; set; }
        public List<Comp_ReconocimientoDTO> ListarReconocimientoVisual { get; set; }
        public List<ReinfoDerechosMinerosDTO> ListaReinfoDerechosMineros { get; set; }
        public List<SituacionPrincipalesProductosDTO> ListaSituacionPrincipalesProducto { get; set; }
        public List<TitularesReferencialesDerechosDTO> ListaTitularesReferencialesDerechos { get; set; }
        public List<Comp_Est_GestionDTO> ListaEstadoGestion { get; set; }
        public List<DerechosMinerosDTO> ListaDerechosMineros { get; set; }
        public List<Comp_ResultadoResumenDTO> ListaResultados { get; set; }
        public List<Comp_Est_AmbDTO> ListaEstudioAmbientales { get; set; }




        public List<Tipo_PamDTO> CboTipo { get; set; }
        public List<Sub_Tipo_PamDTO> CboSubTipo { get; set; }
        public List<Tipo_MineriaDTO> CboTipoMineria { get; set; }
        public List<Tamano_ParticulaDTO> CboParticula { get; set; }
        public List<HumedadDTO> CboHumedad { get; set; }
        public List<Tipo_ConcesionDTO> CboConcesion { get; set; }
        public List<CoberturaDTO> CboCobertura { get; set; }
        public List<UbigeoDTO> CboUbigeo { get; set; }


        //public List<Estado_GestionDTO> CboEstadoGestion { get; set; }
        //public List<RegionDTO> CboRegion { get; set; }
        //public List<ProvinciaDTO> CboProvincia { get; set; }
        //public List<DistritoDTO> CboDistrito { get; set; }
        //public Comp_ObservacionDTO Observacion { get; set; }
    }
}
