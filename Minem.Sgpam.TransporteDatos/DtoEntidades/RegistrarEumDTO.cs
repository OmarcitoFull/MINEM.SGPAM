﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarEumDTO
    {
        public MaestraDTO Eum { get; set; }
        public List<Eum_ModDTO> ListaHistorial { get; set; }
        public List<Eum_InspeccionDTO> ListaInspeccion { get; set; }
        public List<Eum_UbicacionDTO> ListaUbicacion { get; set; }
        public List<Eum_Info_GraficaDTO> ListaInformacionGrafica { get; set; }
        public List<Eum_Info_DescargoDTO> ListaInformacionDescargo { get; set; }
        public List<ComponenteMinDTO> ListaComponenteActivo { get; set; }
        public List<ComponenteMinDTO> ListaComponenteInactivo { get; set; }


        public List<Tipo_OperacionDTO> CboTipoOperacion { get; set; }
        public List<Tipo_SustanciaDTO> CboTipoSustancia { get; set; }
        public List<Conflicto_SocialDTO> CboConflictoSocial { get; set; }
        public List<Tipo_PamDTO> CboTipoPam { get; set; }

    }
}
